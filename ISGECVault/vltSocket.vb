Imports System.Threading
Imports System.Text
Imports System.Net.Sockets
Imports System.Net
Imports System
Public Class StateObject
  Public workSocket As Socket = Nothing
  Public Const BufferSize As Integer = 1024
  Public buffer As Byte() = New Byte(BufferSize) {}
  Public sb As New StringBuilder()
End Class
Public Class AsynchronousSocketListener
  Public Shared allDone As New ManualResetEvent(False)
  Public Sub New()
  End Sub
  Public Shared Sub StartListening()
    Dim ipHostInfo As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName())
    Dim ipAddress As IPAddress = ipHostInfo.AddressList(0)
    Dim localEndPoint As New IPEndPoint(ipAddress, 11000)
    Dim listener As New Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp)
    Try
      listener.Bind(localEndPoint)
      listener.Listen(100)
      While True
        allDone.Reset()
        'Console.WriteLine("Waiting for a connection...")
        listener.BeginAccept(New AsyncCallback(AddressOf AcceptCallback), listener)
        allDone.WaitOne()
      End While
    Catch e As Exception
      'Console.WriteLine(e.ToString())
    End Try
    'Console.WriteLine(vbLf & "Press ENTER to continue...")
    'Console.Read()
  End Sub
  Public Shared Sub AcceptCallback(ar As IAsyncResult)
    allDone.[Set]()
    Dim listener As Socket = CType(ar.AsyncState, Socket)
    Dim handler As Socket = listener.EndAccept(ar)
    Dim state As New StateObject()
    state.workSocket = handler
    handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, New AsyncCallback(AddressOf ReadCallback), state)
  End Sub
  Public Shared Sub ReadCallback(ar As IAsyncResult)
    Dim content As String = [String].Empty
    Dim state As StateObject = CType(ar.AsyncState, StateObject)
    Dim handler As Socket = state.workSocket
    Dim bytesRead As Integer = handler.EndReceive(ar)
    If bytesRead > 0 Then
      state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead))
      content = state.sb.ToString()
      If content.IndexOf("<EOF>") > -1 Then
        'Console.WriteLine("Read {0} bytes from socket. " & vbLf & " Data : {1}", content.Length, content)
        Send(handler, content)
      Else
        handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, New AsyncCallback(AddressOf ReadCallback), state)
      End If
    End If
  End Sub
  Private Shared Sub Send(handler As Socket, data As String)
    Dim byteData As Byte() = Encoding.ASCII.GetBytes(data)
    handler.BeginSend(byteData, 0, byteData.Length, 0, New AsyncCallback(AddressOf SendCallback), handler)
  End Sub
  Private Shared Sub SendCallback(ar As IAsyncResult)
    Try
      Dim handler As Socket = CType(ar.AsyncState, Socket)
      Dim bytesSent As Integer = handler.EndSend(ar)
      'Console.WriteLine("Sent {0} bytes to client.", bytesSent)
      handler.Shutdown(SocketShutdown.Both)
      handler.Close()
    Catch e As Exception
      'Console.WriteLine(e.ToString())
    End Try
  End Sub
  Public Shared Function Main(args As String()) As Integer
    StartListening()
    Return 0
  End Function
End Class

Public Class AsynchronousClient
  Private Const port As Integer = 11000
  Private Shared connectDone As New ManualResetEvent(False)
  Private Shared sendDone As New ManualResetEvent(False)
  Private Shared receiveDone As New ManualResetEvent(False)
  Private Shared response As String = [String].Empty
  Private Shared Sub StartClient()
    Try
      Dim ipHostInfo As IPHostEntry = Dns.GetHostEntry("host.contoso.com")
      Dim ipAddress As IPAddress = ipHostInfo.AddressList(0)
      Dim remoteEP As New IPEndPoint(ipAddress, port)
      Dim client As New Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp)
      client.BeginConnect(remoteEP, New AsyncCallback(AddressOf ConnectCallback), client)
      connectDone.WaitOne()
      Send(client, "This is a test<EOF>")
      sendDone.WaitOne()
      Receive(client)
      receiveDone.WaitOne()
      'Console.WriteLine("Response received : {0}", response)
      client.Shutdown(SocketShutdown.Both)
      client.Close()
    Catch e As Exception
      'Console.WriteLine(e.ToString())
    End Try
  End Sub
  Private Shared Sub ConnectCallback(ar As IAsyncResult)
    Try
      Dim client As Socket = CType(ar.AsyncState, Socket)
      client.EndConnect(ar)
      'Console.WriteLine("Socket connected to {0}", client.RemoteEndPoint.ToString())
      connectDone.[Set]()
    Catch e As Exception
      'Console.WriteLine(e.ToString())
    End Try
  End Sub
  Private Shared Sub Receive(client As Socket)
    Try
      Dim state As New StateObject()
      state.workSocket = client
      client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, New AsyncCallback(AddressOf ReceiveCallback), state)
    Catch e As Exception
      'Console.WriteLine(e.ToString())
    End Try
  End Sub
  Private Shared Sub ReceiveCallback(ar As IAsyncResult)
    Try
      Dim state As StateObject = CType(ar.AsyncState, StateObject)
      Dim client As Socket = state.workSocket
      Dim bytesRead As Integer = client.EndReceive(ar)
      If bytesRead > 0 Then
        state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead))
        client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, New AsyncCallback(AddressOf ReceiveCallback), state)
      Else
        If state.sb.Length > 1 Then
          response = state.sb.ToString()
        End If
        receiveDone.[Set]()
      End If
    Catch e As Exception
      'Console.WriteLine(e.ToString())
    End Try
  End Sub
  Private Shared Sub Send(client As Socket, data As String)
    Dim byteData As Byte() = Encoding.ASCII.GetBytes(data)
    client.BeginSend(byteData, 0, byteData.Length, 0, New AsyncCallback(AddressOf SendCallback), client)
  End Sub
  Private Shared Sub SendCallback(ar As IAsyncResult)
    Try
      Dim client As Socket = CType(ar.AsyncState, Socket)
      Dim bytesSent As Integer = client.EndSend(ar)
      'Console.WriteLine("Sent {0} bytes to server.", bytesSent)
      sendDone.[Set]()
    Catch e As Exception
      'Console.WriteLine(e.ToString())
    End Try
  End Sub
  Public Shared Function Main(args As String()) As Integer
    StartClient()
    Return 0
  End Function
End Class