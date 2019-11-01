﻿Imports System.ComponentModel

Public Class frmISGECVault
  Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
    Application.Exit()
  End Sub

  Private Sub mnuLogin_Click(sender As Object, e As EventArgs) Handles mnuLogin.Click
    Dim tmp As New frmLogin
    tmp.MdiParent = Me
    tmp.StartPosition = FormStartPosition.CenterParent
    tmp.Show()
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
    'If SIS.VLT.modMain.frmSvr Is Nothing Then
    '  SIS.VLT.modMain.frmSvr = New frmVaultServer
    '  With SIS.VLT.modMain.frmSvr
    '    .MdiParent = Me
    '    .StartPosition = FormStartPosition.CenterParent
    '  End With
    'End If
    'SIS.VLT.modMain.frmSvr.Show()
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
End Class