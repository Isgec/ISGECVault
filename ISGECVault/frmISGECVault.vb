Imports System.ComponentModel

Public Class frmISGECVault
  Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
    Application.Exit()
  End Sub

  Private Sub mnuLogin_Click(sender As Object, e As EventArgs) Handles mnuLogin.Click
    Dim tmp As New frmLogin
    tmp.StartPosition = FormStartPosition.CenterScreen
    tmp.ShowDialog(Me)
  End Sub
  Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
    SIS.VLT.LogoutUser()
  End Sub
  Public Sub DDmnuVault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Dim tsi As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)
    Dim tmp As New frmVault()
    tmp.MdiParent = Me
    SIS.VLT.vltHandler.LoadVault(tsi.Text, tmp, tsi.Tag)
  End Sub

  Private Sub mnuStartServer_Click(sender As Object, e As EventArgs) Handles mnuStartServer.Click
    Dim tmp As New frmServerConf
    With tmp
      .MdiParent = Me
      .StartPosition = FormStartPosition.CenterParent
    End With
    tmp.Show()
  End Sub
  Private Sub frmISGECVault_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    'If SIS.VLT.modMain.frmSvr IsNot Nothing Then
    '  SIS.VLT.modMain.frmSvr.Close()
    '  SIS.VLT.modMain.frmSvr = Nothing
    'End If
    For Each frm As Form In Me.MdiChildren
      Try
        frm.Close()
      Catch ex As Exception
      End Try
    Next

  End Sub

  Private Sub mnuUserAuthorization_Click(sender As Object, e As EventArgs) Handles mnuUserAuthorization.Click
    Dim tmp As New frmUser
    tmp.MdiParent = Me
    tmp.StartPosition = FormStartPosition.CenterParent
    tmp.Show()
  End Sub

  Private Sub mnuLogViewer_Click(sender As Object, e As EventArgs) Handles mnuLogViewer.Click
    Dim tmp As New frmLog
    tmp.MdiParent = Me
    tmp.StartPosition = FormStartPosition.CenterParent
    tmp.Show()
  End Sub

  Private Sub mnuChangePassword_Click(sender As Object, e As EventArgs) Handles mnuChangePassword.Click
    Dim x As New frmChangePW
    x.StartPosition = FormStartPosition.CenterScreen
    x.ShowDialog(Me)
  End Sub

  Private Sub frmISGECVault_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    mnuLogin_Click(Nothing, Nothing)
  End Sub
End Class