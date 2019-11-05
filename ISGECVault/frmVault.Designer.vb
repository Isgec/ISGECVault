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
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.splitTree = New System.Windows.Forms.SplitContainer()
    Me.Tree1 = New System.Windows.Forms.TreeView()
    Me.Img1 = New System.Windows.Forms.ImageList(Me.components)
    Me.SplitGrid = New System.Windows.Forms.SplitContainer()
    Me.Grid1 = New System.Windows.Forms.DataGridView()
    Me.RowIcon = New System.Windows.Forms.DataGridViewImageColumn()
    Me.cMnu = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.cmnuDownload = New System.Windows.Forms.ToolStripMenuItem()
    Me.cmnuOpenOriginal = New System.Windows.Forms.ToolStripMenuItem()
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
    Me.lblSearch = New System.Windows.Forms.Label()
    Me.cmdStop = New System.Windows.Forms.Button()
    Me.cmdSearch = New System.Windows.Forms.Button()
    Me.F_txtSearch = New System.Windows.Forms.TextBox()
    Me.hGrid1 = New System.Windows.Forms.DataGridView()
    Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
    Me.hMnu = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.hmnuDownload = New System.Windows.Forms.ToolStripMenuItem()
    Me.hmnuOpenOriginal = New System.Windows.Forms.ToolStripMenuItem()
    Me.pic1 = New System.Windows.Forms.PictureBox()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CreateDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.CreateUserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FileSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DBS = New System.Windows.Forms.BindingSource(Me.components)
    Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    CType(Me.splitTree, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.splitTree.Panel1.SuspendLayout()
    Me.splitTree.Panel2.SuspendLayout()
    Me.splitTree.SuspendLayout()
    CType(Me.SplitGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitGrid.Panel1.SuspendLayout()
    Me.SplitGrid.Panel2.SuspendLayout()
    Me.SplitGrid.SuspendLayout()
    CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.cMnu.SuspendLayout()
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    CType(Me.hGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.hMnu.SuspendLayout()
    CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.Img1.Images.SetKeyName(12, "Knob Search.ico")
    Me.Img1.Images.SetKeyName(13, "Knob Cancel.ico")
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
    '
    'SplitGrid.Panel2
    '
    Me.SplitGrid.Panel2.Controls.Add(Me.SplitContainer1)
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
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.Grid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
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
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle6.NullValue = CType(resources.GetObject("DataGridViewCellStyle6.NullValue"), Object)
    DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(2)
    Me.RowIcon.DefaultCellStyle = DataGridViewCellStyle6
    Me.RowIcon.HeaderText = "Type"
    Me.RowIcon.Image = CType(resources.GetObject("RowIcon.Image"), System.Drawing.Image)
    Me.RowIcon.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
    Me.RowIcon.Name = "RowIcon"
    Me.RowIcon.ReadOnly = True
    Me.RowIcon.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.RowIcon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.RowIcon.Width = 50
    '
    'cMnu
    '
    Me.cMnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuDownload, Me.cmnuOpenOriginal})
    Me.cMnu.Name = "cMnu"
    Me.cMnu.Size = New System.Drawing.Size(149, 48)
    '
    'cmnuDownload
    '
    Me.cmnuDownload.Name = "cmnuDownload"
    Me.cmnuDownload.Size = New System.Drawing.Size(148, 22)
    Me.cmnuDownload.Text = "Download"
    '
    'cmnuOpenOriginal
    '
    Me.cmnuOpenOriginal.Name = "cmnuOpenOriginal"
    Me.cmnuOpenOriginal.Size = New System.Drawing.Size(148, 22)
    Me.cmnuOpenOriginal.Text = "Open Original"
    '
    'SplitContainer1
    '
    Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
    Me.SplitContainer1.Name = "SplitContainer1"
    Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'SplitContainer1.Panel1
    '
    Me.SplitContainer1.Panel1.Controls.Add(Me.pic1)
    Me.SplitContainer1.Panel1.Controls.Add(Me.lblSearch)
    Me.SplitContainer1.Panel1.Controls.Add(Me.cmdStop)
    Me.SplitContainer1.Panel1.Controls.Add(Me.cmdSearch)
    Me.SplitContainer1.Panel1.Controls.Add(Me.F_txtSearch)
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.Controls.Add(Me.hGrid1)
    Me.SplitContainer1.Size = New System.Drawing.Size(603, 169)
    Me.SplitContainer1.SplitterDistance = 38
    Me.SplitContainer1.TabIndex = 0
    '
    'lblSearch
    '
    Me.lblSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblSearch.AutoSize = True
    Me.lblSearch.ForeColor = System.Drawing.Color.Green
    Me.lblSearch.Location = New System.Drawing.Point(203, 13)
    Me.lblSearch.Name = "lblSearch"
    Me.lblSearch.Size = New System.Drawing.Size(41, 13)
    Me.lblSearch.TabIndex = 3
    Me.lblSearch.Text = "Search"
    '
    'cmdStop
    '
    Me.cmdStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdStop.Enabled = False
    Me.cmdStop.ImageIndex = 13
    Me.cmdStop.ImageList = Me.Img1
    Me.cmdStop.Location = New System.Drawing.Point(562, 8)
    Me.cmdStop.Name = "cmdStop"
    Me.cmdStop.Size = New System.Drawing.Size(29, 23)
    Me.cmdStop.TabIndex = 2
    Me.cmdStop.UseVisualStyleBackColor = True
    '
    'cmdSearch
    '
    Me.cmdSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdSearch.ImageIndex = 12
    Me.cmdSearch.ImageList = Me.Img1
    Me.cmdSearch.Location = New System.Drawing.Point(527, 8)
    Me.cmdSearch.Name = "cmdSearch"
    Me.cmdSearch.Size = New System.Drawing.Size(29, 23)
    Me.cmdSearch.TabIndex = 1
    Me.cmdSearch.UseVisualStyleBackColor = True
    '
    'F_txtSearch
    '
    Me.F_txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.F_txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.F_txtSearch.Location = New System.Drawing.Point(276, 10)
    Me.F_txtSearch.Name = "F_txtSearch"
    Me.F_txtSearch.Size = New System.Drawing.Size(246, 20)
    Me.F_txtSearch.TabIndex = 0
    '
    'hGrid1
    '
    Me.hGrid1.AllowUserToAddRows = False
    Me.hGrid1.AllowUserToDeleteRows = False
    Me.hGrid1.AutoGenerateColumns = False
    Me.hGrid1.BackgroundColor = System.Drawing.Color.White
    Me.hGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.hGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.hGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.hGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
    Me.hGrid1.ContextMenuStrip = Me.cMnu
    Me.hGrid1.DataSource = Me.DBS
    Me.hGrid1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.hGrid1.Location = New System.Drawing.Point(0, 0)
    Me.hGrid1.Name = "hGrid1"
    Me.hGrid1.ReadOnly = True
    Me.hGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.hGrid1.Size = New System.Drawing.Size(603, 127)
    Me.hGrid1.TabIndex = 1
    '
    'DataGridViewImageColumn1
    '
    Me.DataGridViewImageColumn1.DataPropertyName = "RowIcon"
    DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle7.NullValue = CType(resources.GetObject("DataGridViewCellStyle7.NullValue"), Object)
    DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(2)
    Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle7
    Me.DataGridViewImageColumn1.HeaderText = "Type"
    Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
    Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
    Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
    Me.DataGridViewImageColumn1.ReadOnly = True
    Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.DataGridViewImageColumn1.Width = 50
    '
    'hMnu
    '
    Me.hMnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.hmnuDownload, Me.hmnuOpenOriginal})
    Me.hMnu.Name = "hMnu"
    Me.hMnu.Size = New System.Drawing.Size(149, 48)
    '
    'hmnuDownload
    '
    Me.hmnuDownload.Name = "hmnuDownload"
    Me.hmnuDownload.Size = New System.Drawing.Size(148, 22)
    Me.hmnuDownload.Text = "Download"
    '
    'hmnuOpenOriginal
    '
    Me.hmnuOpenOriginal.Name = "hmnuOpenOriginal"
    Me.hmnuOpenOriginal.Size = New System.Drawing.Size(148, 22)
    Me.hmnuOpenOriginal.Text = "Open Original"
    '
    'pic1
    '
    Me.pic1.Image = CType(resources.GetObject("pic1.Image"), System.Drawing.Image)
    Me.pic1.Location = New System.Drawing.Point(4, 3)
    Me.pic1.Name = "pic1"
    Me.pic1.Size = New System.Drawing.Size(40, 40)
    Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.pic1.TabIndex = 4
    Me.pic1.TabStop = False
    Me.pic1.Visible = False
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
    'DBS
    '
    Me.DBS.DataSource = GetType(ISGECVault.SIS.VLT.vltFolder)
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.DataPropertyName = "Description"
    Me.DataGridViewTextBoxColumn5.HeaderText = "Description"
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    Me.DataGridViewTextBoxColumn5.ReadOnly = True
    Me.DataGridViewTextBoxColumn5.Width = 250
    '
    'DataGridViewTextBoxColumn6
    '
    Me.DataGridViewTextBoxColumn6.DataPropertyName = "ISGEC_Rev"
    Me.DataGridViewTextBoxColumn6.HeaderText = "Rev"
    Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
    Me.DataGridViewTextBoxColumn6.ReadOnly = True
    Me.DataGridViewTextBoxColumn6.Width = 50
    '
    'DataGridViewTextBoxColumn7
    '
    Me.DataGridViewTextBoxColumn7.DataPropertyName = "ISGEC_Ttl"
    Me.DataGridViewTextBoxColumn7.HeaderText = "Title"
    Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
    Me.DataGridViewTextBoxColumn7.ReadOnly = True
    Me.DataGridViewTextBoxColumn7.Width = 300
    '
    'DataGridViewTextBoxColumn8
    '
    Me.DataGridViewTextBoxColumn8.DataPropertyName = "LifeCycleStateName"
    Me.DataGridViewTextBoxColumn8.HeaderText = "Status"
    Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
    Me.DataGridViewTextBoxColumn8.ReadOnly = True
    '
    'DataGridViewTextBoxColumn9
    '
    Me.DataGridViewTextBoxColumn9.DataPropertyName = "CreateDate"
    Me.DataGridViewTextBoxColumn9.HeaderText = "Date"
    Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
    Me.DataGridViewTextBoxColumn9.ReadOnly = True
    '
    'DataGridViewTextBoxColumn10
    '
    Me.DataGridViewTextBoxColumn10.DataPropertyName = "CreateUserName"
    Me.DataGridViewTextBoxColumn10.HeaderText = "User"
    Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
    Me.DataGridViewTextBoxColumn10.ReadOnly = True
    '
    'DataGridViewTextBoxColumn11
    '
    Me.DataGridViewTextBoxColumn11.DataPropertyName = "FileSize"
    Me.DataGridViewTextBoxColumn11.HeaderText = "Size"
    Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
    Me.DataGridViewTextBoxColumn11.ReadOnly = True
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
    Me.SplitGrid.Panel2.ResumeLayout(False)
    CType(Me.SplitGrid, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitGrid.ResumeLayout(False)
    CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.cMnu.ResumeLayout(False)
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel1.PerformLayout()
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer1.ResumeLayout(False)
    CType(Me.hGrid1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.hMnu.ResumeLayout(False)
    CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents SplitContainer1 As SplitContainer
  Friend WithEvents cmdSearch As Button
  Friend WithEvents F_txtSearch As TextBox
  Friend WithEvents cmdStop As Button
  Friend WithEvents lblSearch As Label
  Friend WithEvents cmnuOpenOriginal As ToolStripMenuItem
  Friend WithEvents hGrid1 As DataGridView
  Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
  Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
  Friend WithEvents hMnu As ContextMenuStrip
  Friend WithEvents hmnuDownload As ToolStripMenuItem
  Friend WithEvents hmnuOpenOriginal As ToolStripMenuItem
  Friend WithEvents pic1 As PictureBox
End Class
