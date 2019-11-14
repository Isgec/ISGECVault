<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLog
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
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
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLog))
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
    Me.F_RecordsPerPage = New System.Windows.Forms.TextBox()
    Me.F_PageNo = New System.Windows.Forms.TextBox()
    Me.cmdNext = New System.Windows.Forms.Button()
    Me.cmdLast = New System.Windows.Forms.Button()
    Me.cmdFirst = New System.Windows.Forms.Button()
    Me.cmdPrev = New System.Windows.Forms.Button()
    Me.F_TotalPages = New System.Windows.Forms.Label()
    Me.F_txtSearch = New System.Windows.Forms.TextBox()
    Me.chkSearch = New System.Windows.Forms.CheckBox()
    Me.cmdSearch = New System.Windows.Forms.Button()
    Me.DataGridView1 = New System.Windows.Forms.DataGridView()
    Me.LogNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.IPAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.LoginIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FileNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.LoggedOnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.BSLog = New System.Windows.Forms.BindingSource(Me.components)
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BSLog, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
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
    Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
    Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
    Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
    Me.SplitContainer1.Panel1.Controls.Add(Me.F_RecordsPerPage)
    Me.SplitContainer1.Panel1.Controls.Add(Me.F_PageNo)
    Me.SplitContainer1.Panel1.Controls.Add(Me.cmdNext)
    Me.SplitContainer1.Panel1.Controls.Add(Me.cmdLast)
    Me.SplitContainer1.Panel1.Controls.Add(Me.cmdFirst)
    Me.SplitContainer1.Panel1.Controls.Add(Me.cmdPrev)
    Me.SplitContainer1.Panel1.Controls.Add(Me.F_TotalPages)
    Me.SplitContainer1.Panel1.Controls.Add(Me.F_txtSearch)
    Me.SplitContainer1.Panel1.Controls.Add(Me.chkSearch)
    Me.SplitContainer1.Panel1.Controls.Add(Me.cmdSearch)
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
    Me.SplitContainer1.Size = New System.Drawing.Size(762, 325)
    Me.SplitContainer1.SplitterDistance = 74
    Me.SplitContainer1.TabIndex = 0
    '
    'F_RecordsPerPage
    '
    Me.F_RecordsPerPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.F_RecordsPerPage.Location = New System.Drawing.Point(307, 47)
    Me.F_RecordsPerPage.MaxLength = 10
    Me.F_RecordsPerPage.Name = "F_RecordsPerPage"
    Me.F_RecordsPerPage.Size = New System.Drawing.Size(50, 20)
    Me.F_RecordsPerPage.TabIndex = 9
    '
    'F_PageNo
    '
    Me.F_PageNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.F_PageNo.Location = New System.Drawing.Point(64, 47)
    Me.F_PageNo.MaxLength = 10
    Me.F_PageNo.Name = "F_PageNo"
    Me.F_PageNo.Size = New System.Drawing.Size(50, 20)
    Me.F_PageNo.TabIndex = 8
    '
    'cmdNext
    '
    Me.cmdNext.Location = New System.Drawing.Point(135, 8)
    Me.cmdNext.Name = "cmdNext"
    Me.cmdNext.Size = New System.Drawing.Size(51, 23)
    Me.cmdNext.TabIndex = 7
    Me.cmdNext.Text = "Next"
    Me.cmdNext.UseVisualStyleBackColor = True
    '
    'cmdLast
    '
    Me.cmdLast.Location = New System.Drawing.Point(193, 8)
    Me.cmdLast.Name = "cmdLast"
    Me.cmdLast.Size = New System.Drawing.Size(51, 23)
    Me.cmdLast.TabIndex = 6
    Me.cmdLast.Text = "Last"
    Me.cmdLast.UseVisualStyleBackColor = True
    '
    'cmdFirst
    '
    Me.cmdFirst.Location = New System.Drawing.Point(12, 8)
    Me.cmdFirst.Name = "cmdFirst"
    Me.cmdFirst.Size = New System.Drawing.Size(51, 23)
    Me.cmdFirst.TabIndex = 5
    Me.cmdFirst.Text = "First"
    Me.cmdFirst.UseVisualStyleBackColor = True
    '
    'cmdPrev
    '
    Me.cmdPrev.Location = New System.Drawing.Point(69, 8)
    Me.cmdPrev.Name = "cmdPrev"
    Me.cmdPrev.Size = New System.Drawing.Size(51, 23)
    Me.cmdPrev.TabIndex = 4
    Me.cmdPrev.Text = "Prev"
    Me.cmdPrev.UseVisualStyleBackColor = True
    '
    'F_TotalPages
    '
    Me.F_TotalPages.AutoSize = True
    Me.F_TotalPages.Location = New System.Drawing.Point(143, 51)
    Me.F_TotalPages.Name = "F_TotalPages"
    Me.F_TotalPages.Size = New System.Drawing.Size(61, 13)
    Me.F_TotalPages.TabIndex = 3
    Me.F_TotalPages.Text = "TotalPages"
    '
    'F_txtSearch
    '
    Me.F_txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.F_txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.F_txtSearch.Location = New System.Drawing.Point(513, 10)
    Me.F_txtSearch.Name = "F_txtSearch"
    Me.F_txtSearch.Size = New System.Drawing.Size(180, 20)
    Me.F_txtSearch.TabIndex = 2
    '
    'chkSearch
    '
    Me.chkSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.chkSearch.AutoSize = True
    Me.chkSearch.Location = New System.Drawing.Point(492, 13)
    Me.chkSearch.Name = "chkSearch"
    Me.chkSearch.Size = New System.Drawing.Size(15, 14)
    Me.chkSearch.TabIndex = 1
    Me.chkSearch.UseVisualStyleBackColor = True
    '
    'cmdSearch
    '
    Me.cmdSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdSearch.Location = New System.Drawing.Point(699, 8)
    Me.cmdSearch.Name = "cmdSearch"
    Me.cmdSearch.Size = New System.Drawing.Size(51, 23)
    Me.cmdSearch.TabIndex = 0
    Me.cmdSearch.Text = "Search"
    Me.cmdSearch.UseVisualStyleBackColor = True
    '
    'DataGridView1
    '
    Me.DataGridView1.AllowUserToAddRows = False
    Me.DataGridView1.AllowUserToDeleteRows = False
    Me.DataGridView1.AllowUserToOrderColumns = True
    Me.DataGridView1.AutoGenerateColumns = False
    Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LogNoDataGridViewTextBoxColumn, Me.IPAddressDataGridViewTextBoxColumn, Me.LoginIDDataGridViewTextBoxColumn, Me.FileNameDataGridViewTextBoxColumn, Me.LoggedOnDataGridViewTextBoxColumn})
    Me.DataGridView1.DataSource = Me.BSLog
    Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
    Me.DataGridView1.Name = "DataGridView1"
    Me.DataGridView1.ReadOnly = True
    Me.DataGridView1.Size = New System.Drawing.Size(762, 247)
    Me.DataGridView1.TabIndex = 0
    '
    'LogNoDataGridViewTextBoxColumn
    '
    Me.LogNoDataGridViewTextBoxColumn.DataPropertyName = "LogNo"
    Me.LogNoDataGridViewTextBoxColumn.HeaderText = "Log No"
    Me.LogNoDataGridViewTextBoxColumn.Name = "LogNoDataGridViewTextBoxColumn"
    Me.LogNoDataGridViewTextBoxColumn.ReadOnly = True
    '
    'IPAddressDataGridViewTextBoxColumn
    '
    Me.IPAddressDataGridViewTextBoxColumn.DataPropertyName = "IP_Address"
    Me.IPAddressDataGridViewTextBoxColumn.HeaderText = "IP Address"
    Me.IPAddressDataGridViewTextBoxColumn.Name = "IPAddressDataGridViewTextBoxColumn"
    Me.IPAddressDataGridViewTextBoxColumn.ReadOnly = True
    Me.IPAddressDataGridViewTextBoxColumn.Width = 150
    '
    'LoginIDDataGridViewTextBoxColumn
    '
    Me.LoginIDDataGridViewTextBoxColumn.DataPropertyName = "LoginID"
    Me.LoginIDDataGridViewTextBoxColumn.HeaderText = "Login ID"
    Me.LoginIDDataGridViewTextBoxColumn.Name = "LoginIDDataGridViewTextBoxColumn"
    Me.LoginIDDataGridViewTextBoxColumn.ReadOnly = True
    '
    'FileNameDataGridViewTextBoxColumn
    '
    Me.FileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName"
    Me.FileNameDataGridViewTextBoxColumn.HeaderText = "File Name"
    Me.FileNameDataGridViewTextBoxColumn.Name = "FileNameDataGridViewTextBoxColumn"
    Me.FileNameDataGridViewTextBoxColumn.ReadOnly = True
    Me.FileNameDataGridViewTextBoxColumn.Width = 250
    '
    'LoggedOnDataGridViewTextBoxColumn
    '
    Me.LoggedOnDataGridViewTextBoxColumn.DataPropertyName = "LoggedOn"
    Me.LoggedOnDataGridViewTextBoxColumn.HeaderText = "Logged On"
    Me.LoggedOnDataGridViewTextBoxColumn.Name = "LoggedOnDataGridViewTextBoxColumn"
    Me.LoggedOnDataGridViewTextBoxColumn.ReadOnly = True
    '
    'BSLog
    '
    Me.BSLog.DataSource = GetType(ISGECVault.SIS.VLT.vltLog)
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(14, 51)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(49, 13)
    Me.Label1.TabIndex = 11
    Me.Label1.Text = "Page No"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(210, 51)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(94, 13)
    Me.Label2.TabIndex = 12
    Me.Label2.Text = "Records Per Page"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(121, 51)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(16, 13)
    Me.Label3.TabIndex = 13
    Me.Label3.Text = "of"
    '
    'frmLog
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(762, 325)
    Me.Controls.Add(Me.SplitContainer1)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmLog"
    Me.Text = "Download Log"
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel1.PerformLayout()
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer1.ResumeLayout(False)
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BSLog, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents SplitContainer1 As SplitContainer
  Friend WithEvents DataGridView1 As DataGridView
  Friend WithEvents LogNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents IPAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents LoginIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents FileNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents LoggedOnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents BSLog As BindingSource
  Friend WithEvents F_TotalPages As Label
  Friend WithEvents F_txtSearch As TextBox
  Friend WithEvents chkSearch As CheckBox
  Friend WithEvents cmdSearch As Button
  Friend WithEvents cmdNext As Button
  Friend WithEvents cmdLast As Button
  Friend WithEvents cmdFirst As Button
  Friend WithEvents cmdPrev As Button
  Friend WithEvents F_PageNo As TextBox
  Friend WithEvents F_RecordsPerPage As TextBox
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
End Class
