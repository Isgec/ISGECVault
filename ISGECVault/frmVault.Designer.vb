<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVault
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVault))
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.splitTree = New System.Windows.Forms.SplitContainer()
    Me.Tree1 = New System.Windows.Forms.TreeView()
    Me.Img1 = New System.Windows.Forms.ImageList(Me.components)
    Me.SplitGrid = New System.Windows.Forms.SplitContainer()
    Me.Grid1 = New System.Windows.Forms.DataGridView()
    Me.RowIcon = New System.Windows.Forms.DataGridViewImageColumn()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CreateDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CreateUserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FileSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cMnu = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.cmnuDownload = New System.Windows.Forms.ToolStripMenuItem()
    Me.DBS = New System.Windows.Forms.BindingSource(Me.components)
    CType(Me.splitTree, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.splitTree.Panel1.SuspendLayout()
    Me.splitTree.Panel2.SuspendLayout()
    Me.splitTree.SuspendLayout()
    CType(Me.SplitGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitGrid.Panel1.SuspendLayout()
    Me.SplitGrid.SuspendLayout()
    CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.cMnu.SuspendLayout()
    CType(Me.DBS, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'splitTree
    '
    Me.splitTree.Dock = System.Windows.Forms.DockStyle.Fill
    Me.splitTree.Location = New System.Drawing.Point(0, 0)
    Me.splitTree.Name = "splitTree"
    '
    'splitTree.Panel1
    '
    Me.splitTree.Panel1.Controls.Add(Me.Tree1)
    '
    'splitTree.Panel2
    '
    Me.splitTree.Panel2.Controls.Add(Me.SplitGrid)
    Me.splitTree.Size = New System.Drawing.Size(916, 509)
    Me.splitTree.SplitterDistance = 305
    Me.splitTree.SplitterWidth = 8
    Me.splitTree.TabIndex = 0
    '
    'Tree1
    '
    Me.Tree1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Tree1.ImageIndex = 1
    Me.Tree1.ImageList = Me.Img1
    Me.Tree1.Location = New System.Drawing.Point(0, 0)
    Me.Tree1.Name = "Tree1"
    Me.Tree1.SelectedImageIndex = 0
    Me.Tree1.Size = New System.Drawing.Size(305, 509)
    Me.Tree1.TabIndex = 0
    '
    'Img1
    '
    Me.Img1.ImageStream = CType(resources.GetObject("Img1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.Img1.TransparentColor = System.Drawing.Color.Transparent
    Me.Img1.Images.SetKeyName(0, "mansion.png")
    Me.Img1.Images.SetKeyName(1, "folder_modernist.png")
    Me.Img1.Images.SetKeyName(2, "folder_modernist_opened.png")
    Me.Img1.Images.SetKeyName(3, "folder_classic.png")
    Me.Img1.Images.SetKeyName(4, "folder_classic_opened.png")
    Me.Img1.Images.SetKeyName(5, "web-management.png")
    Me.Img1.Images.SetKeyName(6, "conveyor-belt1.png")
    Me.Img1.Images.SetKeyName(7, "conveyor-belt2.png")
    Me.Img1.Images.SetKeyName(8, "manufacture1.png")
    Me.Img1.Images.SetKeyName(9, "manufacture.png")
    Me.Img1.Images.SetKeyName(10, "conveyor-belt.png")
    Me.Img1.Images.SetKeyName(11, "conveyor-belt0.png")
    '
    'SplitGrid
    '
    Me.SplitGrid.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitGrid.Location = New System.Drawing.Point(0, 0)
    Me.SplitGrid.Name = "SplitGrid"
    Me.SplitGrid.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'SplitGrid.Panel1
    '
    Me.SplitGrid.Panel1.Controls.Add(Me.Grid1)
    Me.SplitGrid.Size = New System.Drawing.Size(603, 509)
    Me.SplitGrid.SplitterDistance = 332
    Me.SplitGrid.SplitterWidth = 8
    Me.SplitGrid.TabIndex = 0
    '
    'Grid1
    '
    Me.Grid1.AllowUserToAddRows = False
    Me.Grid1.AllowUserToDeleteRows = False
    Me.Grid1.AutoGenerateColumns = False
    Me.Grid1.BackgroundColor = System.Drawing.Color.White
    Me.Grid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.Grid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.Grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RowIcon, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn2, Me.CreateDateDataGridViewTextBoxColumn, Me.CreateUserNameDataGridViewTextBoxColumn, Me.FileSizeDataGridViewTextBoxColumn})
    Me.Grid1.ContextMenuStrip = Me.cMnu
    Me.Grid1.DataSource = Me.DBS
    Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Grid1.Location = New System.Drawing.Point(0, 0)
    Me.Grid1.Name = "Grid1"
    Me.Grid1.ReadOnly = True
    Me.Grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.Grid1.Size = New System.Drawing.Size(603, 332)
    Me.Grid1.TabIndex = 0
    '
    'RowIcon
    '
    Me.RowIcon.DataPropertyName = "RowIcon"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle2.NullValue = CType(resources.GetObject("DataGridViewCellStyle2.NullValue"), Object)
    DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(2)
    Me.RowIcon.DefaultCellStyle = DataGridViewCellStyle2
    Me.RowIcon.HeaderText = "Type"
    Me.RowIcon.Image = CType(resources.GetObject("RowIcon.Image"), System.Drawing.Image)
    Me.RowIcon.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
    Me.RowIcon.Name = "RowIcon"
    Me.RowIcon.ReadOnly = True
    Me.RowIcon.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.RowIcon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.RowIcon.Width = 50
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.DataPropertyName = "Description"
    Me.DataGridViewTextBoxColumn1.HeaderText = "Description"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewTextBoxColumn1.Width = 250
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.DataPropertyName = "ISGEC_Rev"
    Me.DataGridViewTextBoxColumn3.HeaderText = "Rev"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    Me.DataGridViewTextBoxColumn3.ReadOnly = True
    Me.DataGridViewTextBoxColumn3.Width = 50
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.DataPropertyName = "ISGEC_Ttl"
    Me.DataGridViewTextBoxColumn4.HeaderText = "Title"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    Me.DataGridViewTextBoxColumn4.ReadOnly = True
    Me.DataGridViewTextBoxColumn4.Width = 300
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.DataPropertyName = "LifeCycleStateName"
    Me.DataGridViewTextBoxColumn2.HeaderText = "Status"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.ReadOnly = True
    '
    'CreateDateDataGridViewTextBoxColumn
    '
    Me.CreateDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate"
    Me.CreateDateDataGridViewTextBoxColumn.HeaderText = "Date"
    Me.CreateDateDataGridViewTextBoxColumn.Name = "CreateDateDataGridViewTextBoxColumn"
    Me.CreateDateDataGridViewTextBoxColumn.ReadOnly = True
    '
    'CreateUserNameDataGridViewTextBoxColumn
    '
    Me.CreateUserNameDataGridViewTextBoxColumn.DataPropertyName = "CreateUserName"
    Me.CreateUserNameDataGridViewTextBoxColumn.HeaderText = "User"
    Me.CreateUserNameDataGridViewTextBoxColumn.Name = "CreateUserNameDataGridViewTextBoxColumn"
    Me.CreateUserNameDataGridViewTextBoxColumn.ReadOnly = True
    '
    'FileSizeDataGridViewTextBoxColumn
    '
    Me.FileSizeDataGridViewTextBoxColumn.DataPropertyName = "FileSize"
    Me.FileSizeDataGridViewTextBoxColumn.HeaderText = "Size"
    Me.FileSizeDataGridViewTextBoxColumn.Name = "FileSizeDataGridViewTextBoxColumn"
    Me.FileSizeDataGridViewTextBoxColumn.ReadOnly = True
    '
    'cMnu
    '
    Me.cMnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuDownload})
    Me.cMnu.Name = "cMnu"
    Me.cMnu.Size = New System.Drawing.Size(129, 26)
    '
    'cmnuDownload
    '
    Me.cmnuDownload.Name = "cmnuDownload"
    Me.cmnuDownload.Size = New System.Drawing.Size(128, 22)
    Me.cmnuDownload.Text = "Download"
    '
    'DBS
    '
    Me.DBS.DataSource = GetType(ISGECVault.SIS.VLT.vltFolder)
    '
    'frmVault
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(916, 509)
    Me.Controls.Add(Me.splitTree)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmVault"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Vault"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.splitTree.Panel1.ResumeLayout(False)
    Me.splitTree.Panel2.ResumeLayout(False)
    CType(Me.splitTree, System.ComponentModel.ISupportInitialize).EndInit()
    Me.splitTree.ResumeLayout(False)
    Me.SplitGrid.Panel1.ResumeLayout(False)
    CType(Me.SplitGrid, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitGrid.ResumeLayout(False)
    CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.cMnu.ResumeLayout(False)
    CType(Me.DBS, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents splitTree As SplitContainer
  Friend WithEvents SplitGrid As SplitContainer
  Friend WithEvents Tree1 As TreeView
  Friend WithEvents Grid1 As DataGridView
  Friend WithEvents DBS As BindingSource
  Friend WithEvents cMnu As ContextMenuStrip
  Friend WithEvents cmnuDownload As ToolStripMenuItem
  Friend WithEvents Img1 As ImageList
  Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents ISGECRevDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents ISGECTtlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents LifeCycleStateNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents RowIcon As DataGridViewImageColumn
  Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
  Friend WithEvents CreateDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents CreateUserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents FileSizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
