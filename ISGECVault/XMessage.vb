Namespace SIS.VLT
  Public Class XMessage
    Const SOH As Byte = 1
    Const EOF As Byte = 4
    Public Property Element As XElement
    Public Shared Function IsMessageComplete(data As IEnumerable(Of Byte)) As Boolean
      Dim length As Integer = data.Count
      If length > 5 Then
        If data(0) = SOH AndAlso data(length - 1) = EOF Then
          Dim l As Integer = BitConverter.ToInt32(data.ToArray, 1)
          Return (l = length - 6)
        End If
      End If
      Return False
    End Function
    Public Shared Function FromByteArray(data() As Byte) As XMessage
      Return New XMessage(XElement.Parse(System.Text.Encoding.UTF8.GetString(data, 5, data.Length - 6)))
    End Function
    Public Function ToByteArray() As Byte()
      Dim result As New List(Of Byte)
      Dim data() As Byte = System.Text.Encoding.UTF8.GetBytes(Element.ToString)
      result.Add(SOH)
      result.AddRange(BitConverter.GetBytes(data.Length))
      result.AddRange(data)
      result.Add(EOF)
      Return result.ToArray
    End Function
    Public Sub New(xml As XElement)
      Element = xml
    End Sub
  End Class

End Namespace
