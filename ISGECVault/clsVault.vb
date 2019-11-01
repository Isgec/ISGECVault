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
        End If
      End Set
    End Property
    Private Frm1 As frmVault = Nothing
    Private WithEvents Tree1 As TreeView = Nothing
    Private WithEvents Grid1 As DataGridView = Nothing
    Public Property VaultDB As String = ""
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
          Tree1.Dispose()
          Tree1 = Nothing
          Grid1.Dispose()
          Grid1 = Nothing
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
      If e.Node.Level = 0 Then
        LoadRoot()
        LoadData(Root)
      Else
        Dim nd As TreeNode = e.Node
        Dim v As SIS.VLT.vltFolder = nd.Tag
        LoadData(v.FolderID)

      End If
    End Sub

    Public Sub Grid1_DoubleClick(sender As Object, e As EventArgs) Handles Grid1.DoubleClick
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
      If selected.Count > 0 Then
        SIS.VLT.DownloadFiles(selected)
      End If
    End Sub
  End Class

End Namespace
