Imports ISGECVault

Public Class frmLog
  Private WithEvents xPage As lgPage = Nothing
  Private Updating As Boolean = False
  Private Sub F_PageNo_TextChanged(sender As Object, e As EventArgs) Handles F_PageNo.TextChanged
    If Not Updating Then
      Dim tmp As Integer = 1
      Try
        tmp = F_PageNo.Text
      Catch ex As Exception
        tmp = 1
      End Try
      xPage.PageNo = tmp - 1
    End If
  End Sub

  Private Sub F_RecordsPerPage_TextChanged(sender As Object, e As EventArgs) Handles F_RecordsPerPage.TextChanged
    If Not Updating Then
      Dim tmp As Integer = 10
      Try
        tmp = F_RecordsPerPage.Text
      Catch ex As Exception
        tmp = 10
      End Try
      xPage.RecordsPerPage = tmp
    End If
  End Sub

  Private Sub frmLog_Load(sender As Object, e As EventArgs) Handles Me.Load
    xPage = New lgPage
    xPage_LoadPage(xPage)
  End Sub

  Private Sub xPage_DataArrived(x As lgPage) Handles xPage.DataArrived
    If x.PageNo = 0 Then
      cmdFirst.Enabled = False
      cmdPrev.Enabled = False
    Else
      cmdFirst.Enabled = True
      cmdPrev.Enabled = True
    End If
    If x.PageNo = x.TotalPages Then
      cmdLast.Enabled = False
      cmdNext.Enabled = False
    Else
      cmdLast.Enabled = True
      cmdNext.Enabled = True
    End If
    Updating = True
    F_PageNo.Text = x.PageNo + 1
    F_TotalPages.Text = x.TotalPages + 1
    F_RecordsPerPage.Text = x.RecordsPerPage
    Updating = False
  End Sub

  Private Sub xPage_LoadPage(x As lgPage) Handles xPage.LoadPage
    If chkSearch.Checked Then
      BSLog.DataSource = SIS.VLT.vltLog.vltLogSelectList(x.PageNo * x.RecordsPerPage, x.RecordsPerPage, "", True, F_txtSearch.Text, "", "", "")
      x.TotalRecords = SIS.VLT.vltLog.vltLogSelectCount()
    Else
      BSLog.DataSource = SIS.VLT.vltLog.vltLogSelectList(x.PageNo * x.RecordsPerPage, x.RecordsPerPage, "", False, "", "", "", "")
      x.TotalRecords = SIS.VLT.vltLog.vltLogSelectCount()
    End If
  End Sub

  Private Sub cmdFirst_Click(sender As Object, e As EventArgs) Handles cmdFirst.Click
    F_PageNo.Text = 1
  End Sub

  Private Sub cmdPrev_Click(sender As Object, e As EventArgs) Handles cmdPrev.Click
    F_PageNo.Text = CInt(F_PageNo.Text) - 1
  End Sub

  Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
    F_PageNo.Text = CInt(F_PageNo.Text) + 1
  End Sub

  Private Sub cmdLast_Click(sender As Object, e As EventArgs) Handles cmdLast.Click
    F_PageNo.Text = xPage.TotalPages + 1
  End Sub

  Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
    If F_txtSearch.Text <> "" Then
      chkSearch.Checked = True
      xPage_LoadPage(xPage)
    End If
  End Sub

  Private Sub chkSearch_CheckedChanged(sender As Object, e As EventArgs) Handles chkSearch.CheckedChanged
    If chkSearch.Checked = False Then
      If xPage.PageNo <> 0 Then
        xPage.PageNo = 0
      Else
        xPage_LoadPage(xPage)
      End If
    End If
  End Sub
End Class
Public Class lgPage
  Public Event DataArrived(x As lgPage)
  Public Event LoadPage(x As lgPage)
  Private _PageNo As Integer = 0
  Public Property PageNo As Int64
    Get
      Return _PageNo
    End Get
    Set(value As Int64)
      If value >= 0 AndAlso value <= TotalPages Then
        If value <> _PageNo Then
          _PageNo = value
          RaiseEvent LoadPage(Me)
        End If
      End If
    End Set
  End Property
  Private _RecordsPerPage As Integer = 10
  Public Property RecordsPerPage As Integer
    Get
      Return _RecordsPerPage
    End Get
    Set(value As Integer)
      If value >= 1 AndAlso value <= 1000 Then
        If value <> _RecordsPerPage Then
          _RecordsPerPage = value
          _PageNo = 0
          RaiseEvent LoadPage(Me)
        End If
      End If
    End Set
  End Property
  Private _TotalRecords As Int64 = 0
  Public Property TotalRecords As Int64
    Get
      Return _TotalRecords
    End Get
    Set(value As Int64)
      _TotalRecords = value
      RaiseEvent DataArrived(Me)
    End Set
  End Property
  Public ReadOnly Property TotalPages As Int64
    Get
      Return Convert.ToInt64(TotalRecords / RecordsPerPage)
    End Get
  End Property


End Class