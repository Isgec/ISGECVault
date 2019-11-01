<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDownload
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.F_SaveAsPath = New System.Windows.Forms.TextBox()
    Me.cmdSelectFolder = New System.Windows.Forms.Button()
    Me.Grid1 = New System.Windows.Forms.DataGridView()
    Me.cmdDownload = New System.Windows.Forms.Button()
    Me.cmdCancel = New System.Windows.Forms.Button()
    Me.ListBox1 = New System.Windows.Forms.ListBox()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.TotFiles = New System.Windows.Forms.Label()
    Me.dnFiles = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.FBD1 = New System.Windows.Forms.FolderBrowserDialog()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.bs1 = New System.Windows.Forms.BindingSource(Me.components)
    Me.FileName = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.FileSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.VaultKey = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Marked = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.Original = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.PDFAvailable = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bs1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 16)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(113, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Select Folder To Save"
    '
    'F_SaveAsPath
    '
    Me.F_SaveAsPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.F_SaveAsPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.F_SaveAsPath.Location = New System.Drawing.Point(133, 13)
    Me.F_SaveAsPath.Name = "F_SaveAsPath"
    Me.F_SaveAsPath.Size = New System.Drawing.Size(526, 20)
    Me.F_SaveAsPath.TabIndex = 1
    '
    'cmdSelectFolder
    '
    Me.cmdSelectFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdSelectFolder.Location = New System.Drawing.Point(677, 12)
    Me.cmdSelectFolder.Name = "cmdSelectFolder"
    Me.cmdSelectFolder.Size = New System.Drawing.Size(40, 23)
    Me.cmdSelectFolder.TabIndex = 2
    Me.cmdSelectFolder.Text = ". . ."
    Me.cmdSelectFolder.UseVisualStyleBackColor = True
    '
    'Grid1
    '
    Me.Grid1.AllowUserToAddRows = False
    Me.Grid1.AllowUserToDeleteRows = False
    Me.Grid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Grid1.AutoGenerateColumns = False
    Me.Grid1.BackgroundColor = System.Drawing.Color.White
    Me.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.Grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FileName, Me.FileSize, Me.VaultKey, Me.Marked, Me.Original, Me.PDFAvailable})
    Me.Grid1.DataSource = Me.bs1
    Me.Grid1.Location = New System.Drawing.Point(1, 59)
    Me.Grid1.MultiSelect = False
    Me.Grid1.Name = "Grid1"
    Me.Grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.Grid1.Size = New System.Drawing.Size(736, 244)
    Me.Grid1.TabIndex = 3
    '
    'cmdDownload
    '
    Me.cmdDownload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdDownload.Location = New System.Drawing.Point(538, 314)
    Me.cmdDownload.Name = "cmdDownload"
    Me.cmdDownload.Size = New System.Drawing.Size(86, 23)
    Me.cmdDownload.TabIndex = 4
    Me.cmdDownload.Text = "Download"
    Me.cmdDownload.UseVisualStyleBackColor = True
    '
    'cmdCancel
    '
    Me.cmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.cmdCancel.Location = New System.Drawing.Point(635, 314)
    Me.cmdCancel.Name = "cmdCancel"
    Me.cmdCancel.Size = New System.Drawing.Size(82, 23)
    Me.cmdCancel.TabIndex = 5
    Me.cmdCancel.Text = "Close"
    Me.cmdCancel.UseVisualStyleBackColor = True
    '
    'ListBox1
    '
    Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ListBox1.FormattingEnabled = True
    Me.ListBox1.ItemHeight = 15
    Me.ListBox1.Location = New System.Drawing.Point(3, 317)
    Me.ListBox1.Name = "ListBox1"
    Me.ListBox1.Size = New System.Drawing.Size(473, 17)
    Me.ListBox1.TabIndex = 6
    '
    'Button1
    '
    Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Button1.Location = New System.Drawing.Point(486, 315)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(46, 23)
    Me.Button1.TabIndex = 7
    Me.Button1.Text = "dn"
    Me.Button1.UseVisualStyleBackColor = True
    Me.Button1.Visible = False
    '
    'TotFiles
    '
    Me.TotFiles.AutoSize = True
    Me.TotFiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TotFiles.ForeColor = System.Drawing.Color.Red
    Me.TotFiles.Location = New System.Drawing.Point(588, 39)
    Me.TotFiles.Name = "TotFiles"
    Me.TotFiles.Size = New System.Drawing.Size(28, 13)
    Me.TotFiles.TabIndex = 8
    Me.TotFiles.Text = "000"
    '
    'dnFiles
    '
    Me.dnFiles.AutoSize = True
    Me.dnFiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dnFiles.ForeColor = System.Drawing.Color.LimeGreen
    Me.dnFiles.Location = New System.Drawing.Point(543, 39)
    Me.dnFiles.Name = "dnFiles"
    Me.dnFiles.Size = New System.Drawing.Size(14, 13)
    Me.dnFiles.TabIndex = 9
    Me.dnFiles.Text = "0"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(572, 39)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(13, 13)
    Me.Label2.TabIndex = 10
    Me.Label2.Text = "/"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(454, 39)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(69, 13)
    Me.Label3.TabIndex = 11
    Me.Label3.Text = "Downloading"
    '
    'bs1
    '
    Me.bs1.DataSource = GetType(ISGECVault.SIS.VLT.SelectedForDownload)
    '
    'FileName
    '
    Me.FileName.DataPropertyName = "FileName"
    Me.FileName.HeaderText = "FileName"
    Me.FileName.Name = "FileName"
    Me.FileName.ReadOnly = True
    Me.FileName.Width = 250
    '
    'FileSize
    '
    Me.FileSize.DataPropertyName = "FileSize"
    Me.FileSize.HeaderText = "FileSize"
    Me.FileSize.Name = "FileSize"
    Me.FileSize.ReadOnly = True
    '
    'VaultKey
    '
    Me.VaultKey.DataPropertyName = "VaultKey"
    Me.VaultKey.HeaderText = "VaultKey"
    Me.VaultKey.Name = "VaultKey"
    Me.VaultKey.ReadOnly = True
    '
    'Marked
    '
    Me.Marked.DataPropertyName = "Marked"
    Me.Marked.HeaderText = "Selected"
    Me.Marked.Name = "Marked"
    '
    'Original
    '
    Me.Original.DataPropertyName = "Original"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle1.NullValue = False
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.Original.DefaultCellStyle = DataGridViewCellStyle1
    Me.Original.HeaderText = "Download Original"
    Me.Original.Name = "Original"
    Me.Original.Width = 60
    '
    'PDFAvailable
    '
    Me.PDFAvailable.DataPropertyName = "PDFAvailable"
    Me.PDFAvailable.HeaderText = "PDF Available"
    Me.PDFAvailable.Name = "PDFAvailable"
    Me.PDFAvailable.ReadOnly = True
    Me.PDFAvailable.Width = 60
    '
    'frmDownload
    '
    Me.AcceptButton = Me.cmdDownload
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.cmdCancel
    Me.ClientSize = New System.Drawing.Size(739, 344)
    Me.ControlBox = False
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.dnFiles)
    Me.Controls.Add(Me.TotFiles)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.ListBox1)
    Me.Controls.Add(Me.cmdCancel)
    Me.Controls.Add(Me.cmdDownload)
    Me.Controls.Add(Me.Grid1)
    Me.Controls.Add(Me.cmdSelectFolder)
    Me.Controls.Add(Me.F_SaveAsPath)
    Me.Controls.Add(Me.Label1)
    Me.Name = "frmDownload"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Download"
    CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bs1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label1 As Label
  Friend WithEvents F_SaveAsPath As TextBox
  Friend WithEvents cmdSelectFolder As Button
  Friend WithEvents Grid1 As DataGridView
  Friend WithEvents cmdDownload As Button
  Friend WithEvents cmdCancel As Button
  Friend WithEvents bs1 As BindingSource
  Friend WithEvents ListBox1 As ListBox
  Friend WithEvents Button1 As Button
  Friend WithEvents TotFiles As Label
  Friend WithEvents dnFiles As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents FBD1 As FolderBrowserDialog
  Friend WithEvents Label3 As Label
  Friend WithEvents FileName As DataGridViewTextBoxColumn
  Friend WithEvents FileSize As DataGridViewTextBoxColumn
  Friend WithEvents VaultKey As DataGridViewTextBoxColumn
  Friend WithEvents Marked As DataGridViewCheckBoxColumn
  Friend WithEvents Original As DataGridViewCheckBoxColumn
  Friend WithEvents PDFAvailable As DataGridViewCheckBoxColumn
End Class
