Public Class frmUser
  Private Sub BSVltUser_CurrentItemChanged(sender As Object, e As EventArgs) Handles BSVltUser.CurrentItemChanged
    If Grid1.SelectedRows.Count > 0 Then
      Try
        Dim x As SIS.VLT.vltUser = Grid1.SelectedRows(0).DataBoundItem
        If x IsNot Nothing AndAlso x.LoginID <> "" Then
          Dim y As List(Of SIS.VLT.Vaults) = SIS.VLT.vltUser.VaultList(x.LoginID)
          For i As Integer = 0 To Grid2.Rows.Count - 1
            Grid2.Rows(i).Cells("F_Selected").Value = False
            Grid2.Rows(i).DefaultCellStyle.BackColor = Color.White
            For Each z As SIS.VLT.Vaults In y
              If CType(Grid2.Rows(i).DataBoundItem, SIS.VLT.Vaults).VaultID = z.VaultID Then
                Grid2.Rows(i).Cells("F_Selected").Value = True
                Grid2.Rows(i).DefaultCellStyle.BackColor = Color.GreenYellow
                Exit For
              End If
            Next
          Next
        End If
      Catch ex As Exception
      End Try
    End If
  End Sub
  Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles Me.Load
    BSVaults.DataSource = SIS.VLT.Vaults.VaultList
    BSVltUser.DataSource = SIS.VLT.vltUser.SelectList
  End Sub
  Private Sub Grid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid1.CellClick
    If Grid1.Columns("cmdSave").Index = e.ColumnIndex Then
      Dim r As DataGridViewRow = Grid1.Rows(e.RowIndex)
      Dim x As SIS.VLT.vltUser = r.DataBoundItem
      If x IsNot Nothing Then
        If x.LoginID <> "" Then
          Dim y As SIS.VLT.vltUser = SIS.VLT.vltUser.GetUser(x.LoginID)
          If y IsNot Nothing Then
            SIS.VLT.vltUser.UpdateData(x)
          Else
            SIS.VLT.vltUser.InsertData(x)
            BSVltUser.DataSource = SIS.VLT.vltUser.SelectList
          End If
        End If
      End If
    End If
  End Sub

  Private Sub Grid1_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles Grid1.DefaultValuesNeeded
    With e.Row
      .Cells("cmdSave").Value = ImgLst1.Images(2)
      .Cells("F_FileLimit").Value = SIS.VLT.modMain.vltConf.FileLimit
      .Cells("F_SizeLimit").Value = SIS.VLT.modMain.vltConf.SizeLimit
      .Cells("F_FileLimit").Value = SIS.VLT.modMain.vltConf.FileLimit
      .Cells("F_ISGECVaultServer").Value = SIS.VLT.modMain.vltConf.ISGECVaultServer
    End With
  End Sub

  Private Sub Grid2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid2.CellClick
    If Grid2.Columns("AuthSave").Index = e.ColumnIndex Then
      Dim r As DataGridViewRow = Grid1.SelectedRows(0)
      Dim x As SIS.VLT.vltUser = r.DataBoundItem
      If x IsNot Nothing AndAlso x.LoginID <> "" Then
        Dim y As SIS.VLT.vltUser = SIS.VLT.vltUser.GetUser(x.LoginID)
        If y Is Nothing Then
          SIS.VLT.vltUser.InsertData(x)
          BSVltUser.DataSource = SIS.VLT.vltUser.SelectList
        End If
        Dim vltID As String = Grid2.Rows(e.RowIndex).Cells("F_VaultID").Value
        If Grid2.Rows(e.RowIndex).Cells("F_Selected").Value = True Then
          SIS.VLT.vltUserVault.Insert(x.LoginID, vltID)
          Grid2.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.GreenYellow
        Else
          SIS.VLT.vltUserVault.Delete(x.LoginID, vltID)
          Grid2.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
        End If
      End If
    End If
  End Sub
End Class