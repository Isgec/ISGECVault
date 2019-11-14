Public Class frmChangePW
  Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
    msgErr.Text = ""
    If F_NewPW.Text = "" Or F_CnfPW.Text = "" Then
      msgErr.Text = "New password is blank or not confirmed."
      Return
    End If
    If F_NewPW.Text <> F_CnfPW.Text Then
      msgErr.Text = "New password is not confirmed."
      Return
    End If
    If F_OldPW.Text <> SIS.VLT.modMain.User.PW Then
      msgErr.Text = "Old password is wrong."
      Return
    End If
    SIS.VLT.modMain.User.PW = F_NewPW.Text
    SIS.VLT.vltUser.UpdateData(SIS.VLT.modMain.User)
    Me.Dispose()
  End Sub
End Class