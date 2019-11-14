Public Class frmLogin
  Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
    Me.Close()
  End Sub
  Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
    'Validate User
    lblErr.Text = ""
    Dim tmpUser As SIS.VLT.vltUser = SIS.VLT.vltUser.GetUser(F_LoginID.Text)
    If tmpUser IsNot Nothing Then
      If tmpUser.PW <> F_Password.Text Then
        lblErr.Text = "Invalid Password"
      Else
        SIS.VLT.Settings.LoginID = F_LoginID.Text
        SIS.VLT.VLTSettings.Serialize(SIS.VLT.Settings)
        SIS.VLT.modMain.LoginUser(tmpUser)
        Me.Close()
      End If
    Else
      lblErr.Text = "Login ID NOT Found."
    End If
  End Sub

  Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
    Me.StartPosition = FormStartPosition.CenterScreen
    F_LoginID.Text = SIS.VLT.Settings.LoginID
    lblErr.Text = ""
    Me.Show()
    F_Password.Select()
  End Sub
End Class