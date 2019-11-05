Imports System.Xml
Namespace SIS.VLT
  Module modMain
    Public User As SIS.VLT.vltUser = Nothing
    Public Vaults As New List(Of SIS.VLT.Vaults)
    Public UserVaults As New List(Of SIS.VLT.Vaults)
    Public Property StartupPath As String = ""
    Public Property Settings As SIS.VLT.VLTSettings = Nothing
    Public oFrm As frmISGECVault = Nothing
    Public vltHandler As SIS.VLT.clsVaultHandler = Nothing
    Public iconExtract As getIconFrmReg
    Public iconFolder As getIconFromFile
    Public vltConf As SIS.VLT.vltConf = Nothing

    Sub main()
      '1. Read Local Settings
      StartupPath = Application.StartupPath
      Settings = SIS.VLT.VLTSettings.DeSerialize()
      SIS.SYS.SQLDatabase.DBCommon.BaaNLive = Settings.BaaNLive
      SIS.SYS.SQLDatabase.DBCommon.JoomlaLive = Settings.JoomlaLive
      SIS.SYS.SQLDatabase.DBCommon.VaultLive = Settings.VaultLive
      oFrm = New frmISGECVault
      Application.Run(oFrm)
    End Sub
    Sub ShowLogin()
      Dim tmp As New frmLogin
      tmp.StartPosition = FormStartPosition.CenterParent
      tmp.ShowDialog(oFrm)
    End Sub
    Sub LoginUser(usr As SIS.VLT.vltUser)
      If usr IsNot Nothing Then
        '1. Initialize User Public Variable
        User = usr
        '2. Read Server Configuration, and Update Local settings
        vltConf = SIS.VLT.vltConf.GetVltConf()
        If vltConf IsNot Nothing Then
          With Settings
            .BaaNLive = vltConf.BaaNLive
            .VaultLive = vltConf.VaultLive
            .ServerIP = vltConf.ISGECVaultServer
            SIS.SYS.SQLDatabase.DBCommon.BaaNLive = Settings.BaaNLive
            SIS.SYS.SQLDatabase.DBCommon.JoomlaLive = Settings.JoomlaLive
            SIS.SYS.SQLDatabase.DBCommon.VaultLive = Settings.VaultLive
          End With
        End If
        '3. Read User Settings, Update Local settings
        Settings.ServerIP = User.ISGECVaultServer
        If User.IsAdmin Then
          oFrm.mnuAdmin.Visible = True
        End If
        UserVaults = SIS.VLT.vltUser.VaultList(User.LoginID)
        For Each tmp As SIS.VLT.Vaults In UserVaults
          Dim x As New ToolStripMenuItem
          With x
            .Text = tmp.VaultDB
            .Visible = True
            .Tag = tmp
            AddHandler x.Click, AddressOf oFrm.DDmnuVault_Click
          End With
          oFrm.mnuVaults.DropDownItems.Add(x)
        Next
        oFrm.mnuLogin.Enabled = False
        oFrm.mnuLogout.Enabled = True
        oFrm.stsLoginID.Text = User.LoginID
        oFrm.mnuEdit.Visible = True
        oFrm.mnuVaults.Visible = True
        oFrm.mnuWindows.Visible = True
        vltHandler = New SIS.VLT.clsVaultHandler
        iconExtract = New getIconFrmReg
        iconFolder = New getIconFromFile
      End If
    End Sub
    Sub LogoutUser()
      User = Nothing
      oFrm.mnuAdmin.Visible = False
      For Each x As ToolStripMenuItem In oFrm.mnuVaults.DropDownItems
        RemoveHandler x.Click, AddressOf oFrm.DDmnuVault_Click
      Next
      oFrm.mnuVaults.DropDownItems.Clear()
      oFrm.mnuLogout.Enabled = False
      oFrm.mnuLogin.Enabled = True
      oFrm.mnuEdit.Visible = False
      oFrm.mnuVaults.Visible = False
      oFrm.mnuWindows.Visible = False
      oFrm.stsLoginID.Text = ""
      vltHandler.Dispose()
      vltHandler = Nothing
      iconExtract = Nothing
      iconFolder = Nothing
      vltConf = Nothing
    End Sub
    Sub DownloadFiles(vltFiles As List(Of SIS.VLT.SelectedForDownload), x As frmVault)
      Dim tmp As New frmDownload
      tmp.vltForm = x
      tmp.ToDownload = vltFiles
      tmp.StartPosition = FormStartPosition.CenterScreen
      tmp.ShowDialog(oFrm)
    End Sub
    Private WithEvents LaunchFile As frmDownload
    Sub OpenVaultFile(vltFiles As List(Of SIS.VLT.SelectedForDownload), x As frmVault)
      If LaunchFile Is Nothing Then
        LaunchFile = New frmDownload
        LaunchFile.vltForm = x
        LaunchFile.ToDownload = vltFiles
        LaunchFile.OpenFile()
      End If
    End Sub
    Private Sub LaunchFile_FileOpend(success As Boolean, str As String) Handles LaunchFile.FileOpend
      LaunchFile.CloseForm()
      LaunchFile.Dispose()
      LaunchFile = Nothing
      If Not success Then
        MsgBox(str)
      End If
    End Sub
  End Module

End Namespace
