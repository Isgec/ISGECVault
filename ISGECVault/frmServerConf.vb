Public Class frmServerConf
  Private Sub frmServerConf_Load(sender As Object, e As EventArgs) Handles Me.Load
    VltConfBindingSource.DataSource = SIS.VLT.modMain.vltConf
  End Sub
  Private Sub Grid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid1.CellClick
    If Grid1.Columns("cmdUpdate").Index = e.ColumnIndex Then
      Dim r As DataGridViewRow = Grid1.Rows(e.RowIndex)
      Dim x As SIS.VLT.vltConf = r.DataBoundItem
      If x IsNot Nothing Then
        SIS.VLT.vltConf.UpdateData(x)
      End If
    End If
  End Sub

End Class