Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Imports System.IO
Public Class frmDownload
  Delegate Sub ThreadedSub(x As ListBox)
  Delegate Sub ThreadedInt(x As Integer)
  Delegate Sub ThreadedDN(dn As SIS.VLT.SelectedForDownload)
  Delegate Sub ThreadedNone()
  Private _ToDownload As List(Of SIS.VLT.SelectedForDownload) = Nothing
  Private WithEvents mycli As xtcClient = Nothing
  Private Downloading As Integer = -1
  Private timc As TimerCallback = Nothing
  Private xt As System.Threading.Timer = Nothing
  Private ToOpenFile As Boolean = False
  Public Event FileOpend(success As Boolean, str As String)
  Private _vltForm As frmVault = Nothing
  Public Property vltForm As frmVault
    Get
      Return _vltForm
    End Get
    Set(value As frmVault)
      _vltForm = value
      _vltForm.pic1.Visible = True
    End Set
  End Property
  Public Sub OpenFile()
    ToOpenFile = True
    F_SaveAsPath.Text = SIS.VLT.modMain.Settings.SelectedPath
    cmdDownload_Click(Nothing, Nothing)
  End Sub
  Public Sub CloseForm()
    If mycli IsNot Nothing Then
      mycli.StopIt = True
    End If
    If _vltForm IsNot Nothing Then
      If _vltForm.pic1.InvokeRequired Then
        _vltForm.pic1.Invoke(New ThreadedNone(AddressOf CloseForm))
      Else
        _vltForm.pic1.Visible = False
        _vltForm = Nothing
      End If
    End If
  End Sub

  Public Property ToDownload As List(Of SIS.VLT.SelectedForDownload)
    Get
      Return _ToDownload
    End Get
    Set(value As List(Of SIS.VLT.SelectedForDownload))
      _ToDownload = value
      TotFiles.Text = value.Count
      bs1.DataSource = value
    End Set
  End Property
  Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
    If mycli IsNot Nothing Then
      mycli.StopIt = True
    End If
  End Sub
  Public Sub ConnectServer(x As ListBox)
    Dim IP As IPAddress = Nothing
    Dim str As String = SIS.VLT.modMain.Settings.ServerIP.Trim()
    If str = "" Then
      MessageBox.Show("Server Name NOT configured.")
      Exit Sub
    End If
    Try
      Dim host As IPHostEntry = Dns.GetHostEntry(str)
      If host IsNot Nothing Then
        If host.AddressList.Count <= 0 Then
          'Using Obsolute Method, as BAD DNS configuration setting on DNS Server
          host = Dns.Resolve(str)
        End If
      End If
      Dim ipaddr As IPAddress() = host.AddressList
      For Each addr As IPAddress In ipaddr
        If addr.AddressFamily = AddressFamily.InterNetwork Then
          IP = addr
          Exit For
        End If
      Next addr
    Catch ex As System.Net.Sockets.SocketException
      MessageBox.Show(str & " : " & ex.Message)
    Catch ex As System.Exception
      MessageBox.Show(ex.Message)
    End Try
    If IP IsNot Nothing Then
      Try
        mycli = New xtcClient(x, IP)
      Catch ex As Exception
        MessageBox.Show("Error During Connection : " & ex.Message)
      End Try
    End If
  End Sub
  Private Sub cmdDownload_Click(sender As Object, e As EventArgs) Handles cmdDownload.Click
    'Validate FileCount and Size
    Dim FSize As Int64 = 0
    Dim FCount As Integer = 0
    Try
      FSize = Convert.ToInt32(SIS.VLT.modMain.User.SizeLimit) * 1024 * 1024
    Catch ex As Exception
      FSize = 0
    End Try
    Try
      FCount = Convert.ToInt32(SIS.VLT.modMain.User.FileLimit)
    Catch ex As Exception
      FCount = 0
    End Try
    If F_SaveAsPath.Text <> "" Then
      If My.Computer.FileSystem.DirectoryExists(F_SaveAsPath.Text) Then
        Dim cnt As Integer = 0
        Dim siz As Int64 = 0
        For i = 0 To _ToDownload.Count - 1
          If _ToDownload(i).Marked AndAlso _ToDownload(i).Downloaded = False Then
            cnt += 1
            If _ToDownload(i).FileSize <> "" Then
              siz += Convert.ToInt64(_ToDownload(i).FileSize)
            End If
          End If
        Next
        If cnt > FCount Or siz > FSize Then
          MessageBox.Show("File Size/Count Limit voilated, can not download.")
          Exit Sub
        End If
        TotFiles.Text = cnt
        dnFiles.Text = 0
        If F_SaveAsPath.Text <> SIS.VLT.modMain.Settings.SelectedPath Then
          SIS.VLT.modMain.Settings.SelectedPath = F_SaveAsPath.Text
          SIS.VLT.modMain.Settings = SIS.VLT.VLTSettings.Serialize(SIS.VLT.modMain.Settings)
          SIS.VLT.vltUser.UpdateSelectedPath(SIS.VLT.modMain.User.LoginID, F_SaveAsPath.Text)
        End If
        If ToDownload.Count > 0 Then
          Dim x As ThreadedSub = AddressOf ConnectServer
          x.BeginInvoke(ListBox1, Nothing, Nothing)
        End If
      Else
        MsgBox("Select Folder NOT Found.")
      End If
    Else
      MsgBox("Select Folder to Save downloaded files(s).")
    End If
  End Sub
  Private Sub setDN(x As Integer)
    If Grid1.InvokeRequired Then
      Grid1.Invoke(New ThreadedInt(AddressOf setDN), x)
    Else
      dnFiles.Text = x + 1
    End If
  End Sub
  Private Sub DownloadNext()
    Downloading += 1
    If Downloading < ToDownload.Count Then
      setDN(Downloading)
      Dim dn As SIS.VLT.SelectedForDownload = ToDownload(Downloading)
      dn.Invalid = False
      If dn.Extension.ToLower = "pdf" Then
        dn.OriginalCanBeDownloaded = True
        dn.SaveAsPath = F_SaveAsPath.Text & "\" & dn.FileName
      Else
        If dn.PDFAvailable Then
          dn.SaveAsPath = F_SaveAsPath.Text & "\" & IO.Path.GetFileNameWithoutExtension(dn.FileName) & ".PDF"
        Else
          If SIS.VLT.modMain.User.OriginalWhenNoPDF Then
            dn.OriginalCanBeDownloaded = True
            dn.SaveAsPath = F_SaveAsPath.Text & "\" & dn.FileName
          Else
            If SIS.VLT.modMain.User.OriginalAllowed Then
              dn.OriginalCanBeDownloaded = True
              dn.SaveAsPath = F_SaveAsPath.Text & "\" & dn.FileName
            Else
              dn.Invalid = True
            End If
          End If
        End If
        If dn.Original Then
          If SIS.VLT.modMain.User.OriginalAllowed Then
            dn.OriginalCanBeDownloaded = True
            dn.SaveAsPath = F_SaveAsPath.Text & "\" & dn.FileName
          End If
        End If
      End If
      If dn.Invalid Then
        SetInvalid(dn)
      Else
        If Not dn.Downloaded Then
          mycli.Send(dn, "File")
        End If
      End If
    Else
      mySvr_Stopped()
    End If
  End Sub
  Private Sub mySvr_Started() Handles mycli.Started
    If cmdDownload.InvokeRequired Then
      cmdDownload.Invoke(New ThreadedNone(AddressOf mySvr_Started))
    Else
      cmdDownload.Enabled = False
      Downloading = -1
      timc = New TimerCallback(AddressOf DownloadNext)
      xt = New System.Threading.Timer(timc, Nothing, 1000, Timeout.Infinite)
    End If
  End Sub
  Private Sub mySvr_Stopped() Handles mycli.Stopped
    If cmdDownload.InvokeRequired Then
      cmdDownload.Invoke(New ThreadedNone(AddressOf mySvr_Stopped))
    Else
      cmdDownload.Enabled = True
    End If
  End Sub
  Private Sub myCli_FileReceived(dn As SIS.VLT.SelectedForDownload) Handles mycli.FileReceived
    If cmdDownload.InvokeRequired Then
      cmdDownload.Invoke(New ThreadedDN(AddressOf myCli_FileReceived), dn)
    Else
      For Each x As DataGridViewRow In Grid1.Rows
        Dim t As SIS.VLT.SelectedForDownload = x.DataBoundItem
        If t.ResourceId = dn.ResourceId Then
          t.Downloaded = True
          x.DefaultCellStyle.ForeColor = Color.Green
          Exit For
        End If
      Next
      Dim log As New SIS.VLT.vltLog
      With log
        .FileName = IO.Path.GetFileName(dn.SaveAsPath)
        .IP_Address = mycli.LocalEndPoint
        .LoginID = SIS.VLT.modMain.User.LoginID
        .LoggedOn = Now
      End With
      SIS.VLT.vltLog.InsertData(log)
      If ToOpenFile Then
        Try
          System.Diagnostics.Process.Start(dn.SaveAsPath)
          RaiseEvent FileOpend(True, "")
        Catch ex As Exception
          RaiseEvent FileOpend(False, ex.Message)
        End Try
      Else
        timc = New TimerCallback(AddressOf DownloadNext)
        xt = New System.Threading.Timer(timc, Nothing, 1000, Timeout.Infinite)
      End If
    End If

  End Sub
  Private Sub SetInvalid(dn As SIS.VLT.SelectedForDownload)
    If cmdDownload.InvokeRequired Then
      cmdDownload.Invoke(New ThreadedDN(AddressOf SetInvalid), dn)
    Else
      For Each x As DataGridViewRow In Grid1.Rows
        Dim t As SIS.VLT.SelectedForDownload = x.DataBoundItem
        If t.ResourceId = dn.ResourceId Then
          t.Downloaded = False
          x.DefaultCellStyle.ForeColor = Color.Red
          Exit For
        End If
      Next
      timc = New TimerCallback(AddressOf DownloadNext)
      xt = New System.Threading.Timer(timc, Nothing, 1000, Timeout.Infinite)
    End If

  End Sub

  Private Sub frmDownload_Load(sender As Object, e As EventArgs) Handles Me.Load
    F_SaveAsPath.Text = SIS.VLT.modMain.Settings.SelectedPath
  End Sub

  Private Sub cmdOpen_Click(sender As Object, e As EventArgs) Handles cmdOpen.Click
    Process.Start(F_SaveAsPath.Text)
  End Sub

  Private Sub cmdSelectFolder_Click(sender As Object, e As EventArgs) Handles cmdSelectFolder.Click
    With FBD1
      .Description = "Select Folder"
      .SelectedPath = F_SaveAsPath.Text
      .ShowDialog()
      If FBD1.SelectedPath <> "" Then
        F_SaveAsPath.Text = FBD1.SelectedPath
      End If
    End With
  End Sub

  Private Sub frmDownload_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    If _vltForm IsNot Nothing Then
      _vltForm.pic1.Visible = False
      _vltForm = Nothing
    End If
  End Sub
End Class
Public Class xtcClient
  Private lst As ListBox = Nothing
  Private ts As TcpClient = Nothing
  Private Received As New List(Of Byte)
  Private _StopIt As Boolean = False
  Delegate Sub dByte(x As List(Of Byte))
  Public Property Reading As Boolean = False
  Public Property ReadingMode As Boolean = False
  Public Property FileMode As Boolean = False
  Public Property ServerIP As IPAddress = GetLocalIP()
  Public ReadOnly Property LocalEndPoint As String
    Get
      Return ts.Client.LocalEndPoint.ToString()
    End Get
  End Property

  Public Property StopIt As Boolean
    Get
      Return _StopIt
    End Get
    Set(value As Boolean)
      _StopIt = value
      Send("xxx", "DisconnectMe")
      ts.Close()
      RaiseEvent Stopped()
    End Set
  End Property
  Public Property dn As SIS.VLT.SelectedForDownload = Nothing
  Public Event Started()
  Public Event Stopped()
  Public Event FileReceived(dn)
  Delegate Sub dMsg(str As String)
  Delegate Sub ThreadedNone()
  Private Sub msg(str As String)
    If lst.InvokeRequired Then
      lst.Invoke(New dMsg(AddressOf msg), {str})
    Else
      lst.Items.Insert(0, str)
    End If
  End Sub
  Private Sub DataReaded(x As List(Of Byte))
    Received.AddRange(x)
    If SIS.VLT.XMessage.IsMessageComplete(Received) Then
      Dim xStr As SIS.VLT.XMessage = SIS.VLT.XMessage.FromByteArray(Received.ToArray)
      Received.Clear()
      Select Case xStr.Element.Name
        Case "TextMessage"
          msg(xStr.Element.FirstAttribute.Value.ToString)
        Case "ServerStopped"
          ts.Close()
          msg("Disconnected")
          RaiseEvent Stopped()
      End Select
    End If
  End Sub
  Private Sub FileReaded(x As List(Of Byte))
    msg("File Received: " & dn.SaveAsPath)
    RaiseEvent FileReceived(dn)
  End Sub

  Public Async Sub StartReading()
    Dim Err As Boolean = False
    Try
      msg("Started Reading")
      Using stream As NetworkStream = ts.GetStream
        Dim buffer(ts.ReceiveBufferSize - 1) As Byte
        ReadingMode = True
        Dim read As Integer = 1
        While read > 0
          Dim tmp As New List(Of Byte)
          Reading = True
          read = Await stream.ReadAsync(buffer, 0, buffer.Length)
          Reading = False
          tmp.AddRange(buffer.Take(read))
          If Not FileMode Then
            Dim x As dByte = AddressOf DataReaded
            x.BeginInvoke(tmp, Nothing, Nothing)
          Else
            Dim FileEnd As Boolean = False
            If tmp.Count = 42 Then
              If tmp(25) = 195 AndAlso tmp(26) = 177 AndAlso tmp(35) = 195 AndAlso tmp(36) = 177 Then
                FileEnd = True
              End If
            End If
            If Not FileEnd Then
              My.Computer.FileSystem.WriteAllBytes(dn.SaveAsPath, tmp.ToArray, True)
            Else
              FileMode = False
              Dim x As dByte = AddressOf FileReaded
              x.BeginInvoke(tmp, Nothing, Nothing)
            End If
          End If
        End While
      End Using
    Catch ocex As OperationCanceledException
      msg(ocex.Message)
      Err = True
    Catch odex As ObjectDisposedException
      msg(odex.Message)
      Err = True
    Catch ioex As IOException
      msg(ioex.Message)
      Err = True
    Catch ex As SocketException
      msg(ex.Message)
      Err = True
    Finally
      msg("Left Reading")
    End Try
    ReadingMode = False
    If Err Then
      msg("Disconnected")
    End If
  End Sub

  Public Sub Connect()
    Try
      ts = New TcpClient
      ts.Connect(ServerIP, 8801)
      If ts.Connected Then
        msg("Connected")
        StartReading()
        RaiseEvent Started()
      End If
    Catch odex As ObjectDisposedException
      msg(odex.Message)
    Catch ex As Exception
      msg(ex.Message)
    End Try
    'StartReadMode()
  End Sub
  'Public Sub StartReadMode()
  '  If ts.Connected Then
  '    timc = New TimerCallback(AddressOf StartReading)
  '    xt = New System.Threading.Timer(timc, Nothing, 200, Timeout.Infinite)
  '  Else
  '    msg("Not Connected")
  '  End If
  'End Sub
  Private timc As TimerCallback = Nothing
  Private xt As System.Threading.Timer = Nothing
  Public Sub Send(x As SIS.VLT.SelectedForDownload, Optional cmd As String = "File")
    dn = x
    Dim str As String = SIS.VLT.SelectedForDownload.GetString(x)
    Send(str, cmd)
  End Sub

  Public Sub Send(str As String, Optional cmd As String = "TextMessage")
    If ts IsNot Nothing AndAlso ts.Connected Then
      If cmd = "File" Then
        FileMode = True
        If My.Computer.FileSystem.FileExists(dn.SaveAsPath) Then
          Try
            My.Computer.FileSystem.DeleteFile(dn.SaveAsPath)
          Catch ex As Exception
            FileMode = False
            MsgBox("File already exists and cannot be overwritten, Please close the file first.")
            msg("Error: " & dn.SaveAsPath)
            RaiseEvent FileReceived(dn)
            Exit Sub
          End Try
        End If
        msg("File Requested: " & dn.FileName)
      Else
        FileMode = False
      End If
      Dim stream As NetworkStream = ts.GetStream
      Dim message As New SIS.VLT.XMessage(<<%= cmd %> value=<%= str %>/>)
      Dim buffer() As Byte = message.ToByteArray
      Try
        stream.Write(buffer, 0, buffer.Length)
      Catch ioex As System.IO.IOException
      Catch odex As ObjectDisposedException
      Catch ex As Exception
        msg(ex.Message)
      End Try
    End If
  End Sub
  Sub New(x As ListBox, y As IPAddress)
    lst = x
    ServerIP = y
    timc = New TimerCallback(AddressOf Connect)
    xt = New System.Threading.Timer(timc, Nothing, 500, Timeout.Infinite)
  End Sub
  Private Function GetLocalIP() As IPAddress
    For Each adapter In NetworkInformation.NetworkInterface.GetAllNetworkInterfaces
      If adapter.OperationalStatus = NetworkInformation.OperationalStatus.Up AndAlso
                adapter.Supports(NetworkInformation.NetworkInterfaceComponent.IPv4) AndAlso
                adapter.NetworkInterfaceType <> NetworkInformation.NetworkInterfaceType.Loopback Then
        Dim props As NetworkInformation.IPInterfaceProperties = adapter.GetIPProperties
        For Each address In props.UnicastAddresses
          If address.Address.AddressFamily = AddressFamily.InterNetwork Then Return address.Address
        Next
      End If
    Next
    Return IPAddress.None
  End Function
End Class