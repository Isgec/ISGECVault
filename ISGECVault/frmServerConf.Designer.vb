<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServerConf
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
    Me.Grid1 = New System.Windows.Forms.DataGridView()
    Me.VltConfBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.cmdUpdate = New System.Windows.Forms.DataGridViewButtonColumn()
    Me.ConfIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.FileLimitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.SizeLimitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.OriginalAllowedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.PDFAllowedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.OriginalWhenNoPDFDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.BaaNLiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.JoomlaLiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.VaultLiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.ISGECVaultServerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.AutodeskVaultServerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.OnIsgecRevBasisDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.VltConfBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Grid1
    '
    Me.Grid1.AllowUserToAddRows = False
    Me.Grid1.AllowUserToDeleteRows = False
    Me.Grid1.AutoGenerateColumns = False
    Me.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.Grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cmdUpdate, Me.ConfIDDataGridViewTextBoxColumn, Me.ActiveDataGridViewCheckBoxColumn, Me.FileLimitDataGridViewTextBoxColumn, Me.SizeLimitDataGridViewTextBoxColumn, Me.OriginalAllowedDataGridViewCheckBoxColumn, Me.PDFAllowedDataGridViewCheckBoxColumn, Me.OriginalWhenNoPDFDataGridViewCheckBoxColumn, Me.BaaNLiveDataGridViewCheckBoxColumn, Me.JoomlaLiveDataGridViewCheckBoxColumn, Me.VaultLiveDataGridViewCheckBoxColumn, Me.ISGECVaultServerDataGridViewTextBoxColumn, Me.AutodeskVaultServerDataGridViewTextBoxColumn, Me.OnIsgecRevBasisDataGridViewCheckBoxColumn})
    Me.Grid1.DataSource = Me.VltConfBindingSource
    Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Grid1.Location = New System.Drawing.Point(0, 0)
    Me.Grid1.Name = "Grid1"
    Me.Grid1.Size = New System.Drawing.Size(830, 166)
    Me.Grid1.TabIndex = 1
    '
    'VltConfBindingSource
    '
    Me.VltConfBindingSource.DataSource = GetType(ISGECVault.SIS.VLT.vltConf)
    '
    'cmdUpdate
    '
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDark
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonFace
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDark
    Me.cmdUpdate.DefaultCellStyle = DataGridViewCellStyle1
    Me.cmdUpdate.HeaderText = "Update"
    Me.cmdUpdate.Name = "cmdUpdate"
    Me.cmdUpdate.ReadOnly = True
    Me.cmdUpdate.Text = "Update"
    Me.cmdUpdate.UseColumnTextForButtonValue = True
    Me.cmdUpdate.Width = 50
    '
    'ConfIDDataGridViewTextBoxColumn
    '
    Me.ConfIDDataGridViewTextBoxColumn.DataPropertyName = "ConfID"
    Me.ConfIDDataGridViewTextBoxColumn.HeaderText = "ConfID"
    Me.ConfIDDataGridViewTextBoxColumn.Name = "ConfIDDataGridViewTextBoxColumn"
    '
    'ActiveDataGridViewCheckBoxColumn
    '
    Me.ActiveDataGridViewCheckBoxColumn.DataPropertyName = "Active"
    Me.ActiveDataGridViewCheckBoxColumn.HeaderText = "Active"
    Me.ActiveDataGridViewCheckBoxColumn.Name = "ActiveDataGridViewCheckBoxColumn"
    '
    'FileLimitDataGridViewTextBoxColumn
    '
    Me.FileLimitDataGridViewTextBoxColumn.DataPropertyName = "FileLimit"
    Me.FileLimitDataGridViewTextBoxColumn.HeaderText = "FileLimit"
    Me.FileLimitDataGridViewTextBoxColumn.Name = "FileLimitDataGridViewTextBoxColumn"
    '
    'SizeLimitDataGridViewTextBoxColumn
    '
    Me.SizeLimitDataGridViewTextBoxColumn.DataPropertyName = "SizeLimit"
    Me.SizeLimitDataGridViewTextBoxColumn.HeaderText = "SizeLimit"
    Me.SizeLimitDataGridViewTextBoxColumn.Name = "SizeLimitDataGridViewTextBoxColumn"
    '
    'OriginalAllowedDataGridViewCheckBoxColumn
    '
    Me.OriginalAllowedDataGridViewCheckBoxColumn.DataPropertyName = "OriginalAllowed"
    Me.OriginalAllowedDataGridViewCheckBoxColumn.HeaderText = "OriginalAllowed"
    Me.OriginalAllowedDataGridViewCheckBoxColumn.Name = "OriginalAllowedDataGridViewCheckBoxColumn"
    '
    'PDFAllowedDataGridViewCheckBoxColumn
    '
    Me.PDFAllowedDataGridViewCheckBoxColumn.DataPropertyName = "PDFAllowed"
    Me.PDFAllowedDataGridViewCheckBoxColumn.HeaderText = "PDFAllowed"
    Me.PDFAllowedDataGridViewCheckBoxColumn.Name = "PDFAllowedDataGridViewCheckBoxColumn"
    '
    'OriginalWhenNoPDFDataGridViewCheckBoxColumn
    '
    Me.OriginalWhenNoPDFDataGridViewCheckBoxColumn.DataPropertyName = "OriginalWhenNoPDF"
    Me.OriginalWhenNoPDFDataGridViewCheckBoxColumn.HeaderText = "OriginalWhenNoPDF"
    Me.OriginalWhenNoPDFDataGridViewCheckBoxColumn.Name = "OriginalWhenNoPDFDataGridViewCheckBoxColumn"
    '
    'BaaNLiveDataGridViewCheckBoxColumn
    '
    Me.BaaNLiveDataGridViewCheckBoxColumn.DataPropertyName = "BaaNLive"
    Me.BaaNLiveDataGridViewCheckBoxColumn.HeaderText = "BaaNLive"
    Me.BaaNLiveDataGridViewCheckBoxColumn.Name = "BaaNLiveDataGridViewCheckBoxColumn"
    '
    'JoomlaLiveDataGridViewCheckBoxColumn
    '
    Me.JoomlaLiveDataGridViewCheckBoxColumn.DataPropertyName = "JoomlaLive"
    Me.JoomlaLiveDataGridViewCheckBoxColumn.HeaderText = "JoomlaLive"
    Me.JoomlaLiveDataGridViewCheckBoxColumn.Name = "JoomlaLiveDataGridViewCheckBoxColumn"
    '
    'VaultLiveDataGridViewCheckBoxColumn
    '
    Me.VaultLiveDataGridViewCheckBoxColumn.DataPropertyName = "VaultLive"
    Me.VaultLiveDataGridViewCheckBoxColumn.HeaderText = "VaultLive"
    Me.VaultLiveDataGridViewCheckBoxColumn.Name = "VaultLiveDataGridViewCheckBoxColumn"
    '
    'ISGECVaultServerDataGridViewTextBoxColumn
    '
    Me.ISGECVaultServerDataGridViewTextBoxColumn.DataPropertyName = "ISGECVaultServer"
    Me.ISGECVaultServerDataGridViewTextBoxColumn.HeaderText = "ISGECVaultServer"
    Me.ISGECVaultServerDataGridViewTextBoxColumn.Name = "ISGECVaultServerDataGridViewTextBoxColumn"
    '
    'AutodeskVaultServerDataGridViewTextBoxColumn
    '
    Me.AutodeskVaultServerDataGridViewTextBoxColumn.DataPropertyName = "AutodeskVaultServer"
    Me.AutodeskVaultServerDataGridViewTextBoxColumn.HeaderText = "AutodeskVaultServer"
    Me.AutodeskVaultServerDataGridViewTextBoxColumn.Name = "AutodeskVaultServerDataGridViewTextBoxColumn"
    '
    'OnIsgecRevBasisDataGridViewCheckBoxColumn
    '
    Me.OnIsgecRevBasisDataGridViewCheckBoxColumn.DataPropertyName = "OnIsgecRevBasis"
    Me.OnIsgecRevBasisDataGridViewCheckBoxColumn.HeaderText = "OnIsgecRevBasis"
    Me.OnIsgecRevBasisDataGridViewCheckBoxColumn.Name = "OnIsgecRevBasisDataGridViewCheckBoxColumn"
    '
    'frmServerConf
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(830, 166)
    Me.Controls.Add(Me.Grid1)
    Me.Name = "frmServerConf"
    Me.Text = "Server Configuration"
    CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.VltConfBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Grid1 As DataGridView
  Friend WithEvents VltConfBindingSource As BindingSource
  Friend WithEvents cmdUpdate As DataGridViewButtonColumn
  Friend WithEvents ConfIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents ActiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
  Friend WithEvents FileLimitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents SizeLimitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents OriginalAllowedDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
  Friend WithEvents PDFAllowedDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
  Friend WithEvents OriginalWhenNoPDFDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
  Friend WithEvents BaaNLiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
  Friend WithEvents JoomlaLiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
  Friend WithEvents VaultLiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
  Friend WithEvents ISGECVaultServerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents AutodeskVaultServerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
  Friend WithEvents OnIsgecRevBasisDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
