Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.IO
Imports System.Web.Script.Serialization

Namespace SIS.VLT
  Public Class clsVault
    Implements IDisposable
    Public Property frmUI As frmVault
      Get
        Return Frm1
      End Get
      Set(value As frmVault)
        Frm1 = value
        If Frm1 IsNot Nothing Then
          Tree1 = Frm1.Tree1
          Grid1 = Frm1.Grid1
          hGrid1 = Frm1.hGrid1
          txtSearch = Frm1.F_txtSearch
          cmdSearch = Frm1.cmdSearch
          cmdStop = Frm1.cmdStop
          lblSearch = Frm1.lblSearch
          Pic1 = Frm1.pic1
        End If
      End Set
    End Property
    Private Frm1 As frmVault = Nothing
    Private WithEvents Tree1 As TreeView = Nothing
    Private WithEvents Grid1 As DataGridView = Nothing
    Private WithEvents hGrid1 As DataGridView = Nothing
    Private WithEvents txtSearch As TextBox = Nothing
    Private WithEvents cmdSearch As Button = Nothing
    Private WithEvents cmdStop As Button = Nothing
    Private WithEvents lblSearch As Label = Nothing
    Private WithEvents Pic1 As PictureBox = Nothing

    Public Property VaultDB As String = ""
    Private DownloadMenuClicked As Boolean = False
    Private OpenOriginal As Boolean = False
    Public ReadOnly Property ERPCompany As String
      Get
        Dim mRet As String = "200"
        Select Case VaultDB
          Case "BOILER"
            mRet = 200
          Case Else
            mRet = 200
        End Select
        Return mRet
      End Get
    End Property
    Public Property Vault As SIS.VLT.Vaults = Nothing
    Private Root As Long = 1
    Public Sub Load()
      frmUI.Text = VaultDB
      frmUI.Show()
      LoadRoot()
      LoadData(Root)
    End Sub
    Private Sub LoadRoot()
      Tree1.Nodes.Clear()
      Dim ND As New TreeNode
      ND.Text = "Projects"
      ND.Name = Root
      ND.ImageIndex = 10
      ND.SelectedImageIndex = 11
      Tree1.Nodes.Add(ND)
    End Sub
    Private Sub LoadData(ParentID As Long)
      Pic1.Visible = True
      Dim Parent() As TreeNode = Tree1.Nodes.Find(ParentID, True)
      Dim Pnd As TreeNode = Nothing
      If Parent.Count > 0 Then
        Dim flds As List(Of SIS.VLT.vltFolder) = SIS.VLT.vltFolder.FolderList(VaultDB, ParentID)
        Pnd = Parent(0)
        Pnd.Nodes.Clear()
        For Each x As SIS.VLT.vltFolder In flds
          If x.ItemType = "Folder" Then
            Dim nd As New TreeNode
            nd.Text = x.FolderName
            nd.Name = x.FolderID
            nd.Tag = x
            If Pnd.Level = 0 Then
              nd.ImageIndex = 8
              nd.SelectedImageIndex = 9
            Else
              nd.ImageIndex = 3
              nd.SelectedImageIndex = 4
            End If
            Pnd.Nodes.Add(nd)
          End If
        Next
        Pnd.Expand()
        'Add Files
        Dim Files As List(Of SIS.VLT.vltFolder) = SIS.VLT.vltFolder.FilesInFolder(VaultDB, ParentID, User.OnlyLatestRev)
        flds.AddRange(Files)
        Dim bs As New BindingSource
        bs.DataSource = flds
        Grid1.DataSource = bs
      End If
      Pic1.Visible = False
    End Sub

    Sub New()
      'dummy
    End Sub
#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
      If Not disposedValue Then
        If disposing Then
          ' TODO: dispose managed state (managed objects).
          txtSearch = Nothing
          cmdSearch = Nothing
          cmdStop = Nothing
          lblSearch = Nothing
          Pic1 = Nothing
          Tree1.Dispose()
          Tree1 = Nothing
          Grid1.Dispose()
          Grid1 = Nothing
          hGrid1.Dispose()
          hGrid1 = Nothing
          frmUI.Close()
          frmUI.Dispose()
          frmUI = Nothing
          Vault = Nothing

        End If

        ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
        ' TODO: set large fields to null.
      End If
      disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
      ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
      Dispose(True)
      ' TODO: uncomment the following line if Finalize() is overridden above.
      ' GC.SuppressFinalize(Me)
    End Sub

#End Region
    Private Sub Tree1_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles Tree1.NodeMouseDoubleClick
      If Searching Then Exit Sub
      If e.Node.Level = 0 Then
        LoadRoot()
        LoadData(Root)
      Else
        Dim nd As TreeNode = e.Node
        Dim v As SIS.VLT.vltFolder = nd.Tag
        LoadData(v.FolderID)
      End If
    End Sub
    Public Sub hDownloadMenu_Click(sender As Object, e As EventArgs)
      DownloadMenuClicked = True
      hGrid1_DoubleClick(Nothing, Nothing)
    End Sub
    Public Sub hOpenOriginal_Click(sender As Object, e As EventArgs)
      OpenOriginal = True
      hGrid1_DoubleClick(Nothing, Nothing)
    End Sub
    Public Sub DownloadMenu_Click(sender As Object, e As EventArgs)
      DownloadMenuClicked = True
      Grid1_DoubleClick(Nothing, Nothing)
    End Sub
    Public Sub OpenOriginal_Click(sender As Object, e As EventArgs)
      OpenOriginal = True
      Grid1_DoubleClick(Nothing, Nothing)
    End Sub

    Public Sub hGrid1_DoubleClick(sender As Object, e As EventArgs) Handles hGrid1.DoubleClick
      If Searching Then Exit Sub
      Pic1.Visible = True
      Dim selected As New List(Of SIS.VLT.SelectedForDownload)
      If hGrid1.SelectedRows.Count > 0 Then
        For Each x As DataGridViewRow In hGrid1.SelectedRows
          Dim t As SIS.VLT.vltFolder = x.DataBoundItem
          Dim y As New SIS.VLT.SelectedForDownload
          With y
            y.FileName = t.FileName ' x.Cells("FileName").Value
            y.FileMasterID = t.FileMasterID ' x.Cells("FileMasterID").Value
            y.ResourceId = t.ResourceId ' x.Cells("ResourceId").Value
            y.ResourceVersion = t.ResourceVersion ' x.Cells("ResourceVersion").Value
            y.FileSize = t.FileSize ' x.Cells("FileSize").Value
            y.Extension = t.Extension ' x.Cells("Extension").Value
            y.VaultDB = VaultDB
            y.VaultBasePath = Vault.FileStorePath
            Dim ediAFile As SIS.EDI.ediAFile = SIS.EDI.ediAFile.ediAFileGetByHandleIndex("DOCUMENTMASTERPDF_" & ERPCompany, IO.Path.GetFileNameWithoutExtension(t.FileName) & "_" & t.ISGEC_Rev)
            If ediAFile IsNot Nothing Then
              y.IsgecVaultKey = ediAFile.t_dcid
              Dim tmp As SIS.EDI.ediALib = SIS.EDI.ediALib.ediALibGetByID(ediAFile.t_lbcd)
              y.IsgecVaultFilePath = "\\192.9.200.146\" & tmp.t_path & "\" & ediAFile.t_dcid
              y.PDFAvailable = True
            End If
          End With
          selected.Add(y)
        Next
      End If
      Pic1.Visible = False
      If selected.Count > 0 Then
        If DownloadMenuClicked Then
          DownloadMenuClicked = False
          SIS.VLT.DownloadFiles(selected, Frm1)
        Else
          If OpenOriginal Then
            OpenOriginal = False
            selected(0).Original = True
            SIS.VLT.OpenVaultFile(selected, Frm1)
          Else
            SIS.VLT.OpenVaultFile(selected, Frm1)
          End If
        End If
      End If
    End Sub

    Public Sub Grid1_DoubleClick(sender As Object, e As EventArgs) Handles Grid1.DoubleClick
      If Searching Then Exit Sub
      Pic1.Visible = True
      Dim selected As New List(Of SIS.VLT.SelectedForDownload)
      If Grid1.SelectedRows.Count > 0 Then
        If Grid1.SelectedRows.Count = 1 Then
          Dim gFld As SIS.VLT.vltFolder = Grid1.SelectedRows(0).DataBoundItem
          Dim sND As TreeNode = Nothing
          If gFld.ItemType = "Folder" Then

            If Tree1.SelectedNode Is Nothing Then
              sND = Tree1.Nodes(0)
            Else
              sND = Tree1.SelectedNode
            End If
            For Each x As TreeNode In sND.Nodes
              If CType(x.Tag, SIS.VLT.vltFolder).FolderID = gFld.FolderID Then
                Dim et As New TreeNodeMouseClickEventArgs(x, MouseButtons.Left, 2, 0, 0)
                Tree1_NodeMouseDoubleClick(Tree1, et)
                Tree1.SelectedNode = x
                Exit For
              End If
            Next
            Exit Sub
          End If
        End If
        For Each x As DataGridViewRow In Grid1.SelectedRows
          Dim t As SIS.VLT.vltFolder = x.DataBoundItem
          If t.ItemType = "Folder" Then Continue For
          Dim y As New SIS.VLT.SelectedForDownload
          With y
            y.FileName = t.FileName ' x.Cells("FileName").Value
            y.FileMasterID = t.FileMasterID ' x.Cells("FileMasterID").Value
            y.ResourceId = t.ResourceId ' x.Cells("ResourceId").Value
            y.ResourceVersion = t.ResourceVersion ' x.Cells("ResourceVersion").Value
            y.FileSize = t.FileSize ' x.Cells("FileSize").Value
            y.Extension = t.Extension ' x.Cells("Extension").Value
            y.VaultDB = VaultDB
            y.VaultBasePath = Vault.FileStorePath
            Dim ediAFile As SIS.EDI.ediAFile = SIS.EDI.ediAFile.ediAFileGetByHandleIndex("DOCUMENTMASTERPDF_" & ERPCompany, IO.Path.GetFileNameWithoutExtension(t.FileName) & "_" & t.ISGEC_Rev)
            If ediAFile IsNot Nothing Then
              y.IsgecVaultKey = ediAFile.t_dcid
              Dim tmp As SIS.EDI.ediALib = SIS.EDI.ediALib.ediALibGetByID(ediAFile.t_lbcd)
              y.IsgecVaultFilePath = "\\192.9.200.146\" & tmp.t_path & "\" & ediAFile.t_dcid
              y.PDFAvailable = True
            End If
          End With
          selected.Add(y)
        Next
      End If
      Pic1.Visible = False
      If selected.Count > 0 Then
        If DownloadMenuClicked Then
          DownloadMenuClicked = False
          SIS.VLT.DownloadFiles(selected, Frm1)
        Else
          If OpenOriginal Then
            OpenOriginal = False
            selected(0).Original = True
            SIS.VLT.OpenVaultFile(selected, Frm1)
          Else
            SIS.VLT.OpenVaultFile(selected, Frm1)
          End If
        End If
      End If
    End Sub
    Private WithEvents xSearch As SIS.VLT.vltSearch = Nothing
    Delegate Sub ThreadedSearch(VaultDB As String, searchStr As String, Latest As Boolean, grid As DataGridView)
    Delegate Sub NoPara()
    Delegate Sub WithStr(str As String)
    Private Searching As Boolean = False
    Private Sub LoadSearchData(VaultDB As String, searchStr As String, Latest As Boolean, Grid As DataGridView)
      xSearch = New SIS.VLT.vltSearch
      With xSearch
        .VaultDB = VaultDB
        .searchStr = searchStr
        .Latest = Latest
        .Grid1 = Grid
      End With
      xSearch.StartSearch()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
      If txtSearch.Text = "" Then Exit Sub
      cmdSearch.Enabled = False
      cmdStop.Enabled = True
      lblSearch.Text = ""
      Pic1.Visible = True
      Searching = True
      Dim dSearch As ThreadedSearch = New ThreadedSearch(AddressOf LoadSearchData)
      dSearch.BeginInvoke(VaultDB, txtSearch.Text, User.OnlyLatestRev, Grid1, Nothing, Nothing)
    End Sub

    Private Sub xSearch_Completed() Handles xSearch.Completed
      If cmdSearch.InvokeRequired Then
        cmdSearch.Invoke(New NoPara(AddressOf xSearch_Completed))
      Else
        cmdSearch.Enabled = True
        cmdStop.Enabled = False
        lblSearch.Text = "Completed"
        xSearch = Nothing
        Searching = False
        Pic1.Visible = False
      End If
    End Sub

    Private Sub xSearch_Cancelled() Handles xSearch.Cancelled
      If cmdSearch.InvokeRequired Then
        cmdSearch.Invoke(New NoPara(AddressOf xSearch_Cancelled))
      Else
        cmdSearch.Enabled = True
        cmdStop.Enabled = False
        lblSearch.Text = "Cancelled"
        xSearch = Nothing
        Searching = False
        Pic1.Visible = False
      End If
    End Sub

    Private Sub xSearch_SearchProgress(str As String) Handles xSearch.SearchProgress
      If lblSearch.InvokeRequired Then
        lblSearch.Invoke(New WithStr(AddressOf xSearch_SearchProgress), {str})
      Else
        lblSearch.Text = str
      End If
    End Sub

    Private Sub cmdStop_Click(sender As Object, e As EventArgs) Handles cmdStop.Click
      If xSearch IsNot Nothing Then
        xSearch.StopIt = True
      End If
    End Sub

    Private Sub Grid1_Click(sender As Object, e As EventArgs) Handles Grid1.Click
      If Not User.OnlyLatestRev Then
        If Grid1.SelectedRows.Count = 1 Then
          Dim x As SIS.VLT.vltFolder = Grid1.SelectedRows(0).DataBoundItem
          If x.ItemType = "File" Then
            Dim Files As List(Of SIS.VLT.vltFolder) = SIS.VLT.vltFolder.FileRevisions(VaultDB, x.FileMasterID, x.FileIterationId)
            Dim bs As New BindingSource
            bs.DataSource = Files
            hGrid1.DataSource = bs
          End If
        End If
      End If
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
      If e.KeyValue = 13 Then
        cmdSearch_Click(Nothing, Nothing)
        e.Handled = True
      End If
    End Sub
  End Class
  Public Class vltSearch
    Implements IDisposable

    Public Property StopIt As Boolean = False
    Public Property VaultDB As String = ""
    Public Property searchStr As String = ""
    Public Property Latest As Boolean = True
    Public Property Grid1 As DataGridView = Nothing
    Public Event Completed()
    Public Event Cancelled()
    Public Event SearchProgress(str As String)
    Public Sub StartSearch()
      RaiseEvent SearchProgress("Searching...")

      Dim mRet As New List(Of SIS.VLT.vltFolder)
      Dim Sql As String = ""

      Sql &= " declare @rev int, @ttl int "
      Sql &= " select @rev=PropertyDefID from PropertyDef where FriendlyName = 'ISGEC_LATESTREVISION' "
      Sql &= " select @ttl=PropertyDefID from PropertyDef where FriendlyName = 'ISGEC_DRAWINGTITLE' "
      Sql &= "  "
      Sql &= " SELECT   "
      Sql &= "  fi.FileIterationId,   "
      Sql &= "  e.CreateDate,   "
      Sql &= "  e.CreateUserID,   "
      Sql &= "  uf.UserGroupName AS CreateUserName,   "
      Sql &= "  fm.FileMasterID,   "
      Sql &= "  i.IterationNumber,   "
      Sql &= "  fi.FileName,   "
      Sql &= "  fr.ResourceId,   "
      Sql &= "  fr.Version AS ResourceVersion,   "
      Sql &= "  fr.Extension,   "
      Sql &= "  fr.FileSize,   "
      Sql &= "  fm.CheckedOut,   "
      Sql &= "  fm.FolderId,   "
      Sql &= "  fi.CheckoutDate,   "
      Sql &= "  fi.LifeCycleStateName, "
      Sql &= "  (select isnull(value,'') from Property where entityid=fi.FileIterationId and PropertyDefID=@rev) as ISGEC_Rev,  "
      Sql &= "  (select isnull(value,'') from Property where entityid=fi.FileIterationId and PropertyDefID=@ttl) as ISGEC_Ttl   "
      Sql &= " FROM  dbo.FileIteration AS fi   "
      Sql &= "  INNER JOIN dbo.Iteration AS i ON fi.FileIterationId = i.IterationID   "
      Sql &= "  INNER JOIN dbo.FileResource AS fr ON fr.ResourceId = fi.ResourceId   "
      Sql &= "  INNER JOIN dbo.Entity AS e ON i.IterationID = e.EntityId   "
      Sql &= "  INNER JOIN dbo.v_User AS uf ON uf.UserGroupID = e.CreateUserID   "
      Sql &= "  INNER JOIN dbo.Master AS m ON m.MasterID = i.MasterID   "
      Sql &= "  INNER JOIN dbo.FileMaster AS fm ON fm.FileMasterID = m.MasterID   "
      Sql &= "  WHERE LOWER(fi.FileName) Like '%" & searchStr & "%'"
      Sql &= "  AND (fi.FileIterationId  "
      If Latest Then
        Sql &= "   = (SELECT max(FileIterationId) "
        Sql &= "      FROM FileIteration AS aa "
        Sql &= "      WHERE (LifeCycleStateName = 'Released') AND (FileName = fi.FileName))) "
      Else
        Sql &= "   IN (SELECT FileIterationId "
        Sql &= "      FROM FileIteration AS aa "
        Sql &= "      WHERE (LifeCycleStateName = 'Released') AND (FileName = fi.FileName))) "
      End If
      Sql &= "  Order By fi.FileIterationID DESC "

      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetVaultConnectionString(VaultDB))
        Con.Open()
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Dim rd As SqlDataReader = Cmd.ExecuteReader
          While rd.Read
            Dim tmp As SIS.VLT.vltFolder = New SIS.VLT.vltFolder(rd)
            tmp.ItemType = "File"
            mRet.Add(tmp)
            RaiseEvent SearchProgress("Loading " & mRet.LongCount)
            If StopIt Then Exit While
          End While
          rd.Close()
        End Using
      End Using
      Dim bs As New BindingSource
      bs.DataSource = mRet
      setGrid(bs)
      If StopIt Then
        RaiseEvent Cancelled()
      Else
        RaiseEvent Completed()
      End If
    End Sub
    Delegate Sub d(b As BindingSource)
    Private Sub setGrid(b As BindingSource)
      If Grid1.InvokeRequired Then
        Grid1.Invoke(New d(AddressOf setGrid), b)
      Else
        Grid1.DataSource = b
      End If
    End Sub
#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
      If Not disposedValue Then
        If disposing Then
          ' TODO: dispose managed state (managed objects).
          Grid1 = Nothing
        End If

        ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
        ' TODO: set large fields to null.
      End If
      disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
      ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
      Dispose(True)
      ' TODO: uncomment the following line if Finalize() is overridden above.
      ' GC.SuppressFinalize(Me)
    End Sub
#End Region
  End Class
End Namespace
