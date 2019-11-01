Imports System.Xml
Imports System.Xml.Serialization

Namespace SIS.VLT
  Public Class VLTSettings
    Public Property ServerIP As String = "192.9.200.119"
    Public Property LoginID As String = "0340"
    Public Property SelectedPath As String = "C:\Temp"
    Public Property BaaNLive As Boolean = True
    Public Property JoomlaLive As Boolean = True
    Public Property VaultLive As Boolean = True
    Public Shared Function Serialize(vlt As SIS.VLT.VLTSettings) As SIS.VLT.VLTSettings
      Dim oSrz As XmlSerializer = New XmlSerializer(vlt.GetType)
      Dim oSW As IO.StreamWriter = New IO.StreamWriter(SIS.VLT.StartupPath & "\VLTSettings.xml")
      oSrz.Serialize(oSW, vlt)
      oSW.Close()
      Return vlt
    End Function
    Public Shared Function DeSerialize() As SIS.VLT.VLTSettings
      Dim vlt As New SIS.VLT.VLTSettings
      If IO.File.Exists(SIS.VLT.StartupPath & "\VLTSettings.xml") Then
        Dim oFS As IO.FileStream = New IO.FileStream(SIS.VLT.StartupPath & "\VLTSettings.xml", IO.FileMode.Open)
        Dim oSrz As XmlSerializer = New XmlSerializer(vlt.GetType)
        vlt = CType(oSrz.Deserialize(oFS), SIS.VLT.VLTSettings)
        oFS.Close()
      Else
        vlt = Serialize(vlt)
      End If
      Return vlt
    End Function
  End Class

End Namespace
