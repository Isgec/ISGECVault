<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUser))
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
    Me.Grid1 = New System.Windows.Forms.DataGridView()
    Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
    Me.Grid2 = New System.Windows.Forms.DataGridView()
    Me.AuthSave = New System.Windows.Forms.DataGridViewImageColumn()
    Me.F_Selected = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.ImgLst1 = New System.Windows.Forms.ImageList(Me.components)
    Me.BSVltUser = New System.Windows.Forms.BindingSource(Me.components)
    Me.F_VaultID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.F_VaultDB = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.BSVaults = New System.Windows.Forms.BindingSource(Me.components)
    Me.BSUserVaults = New System.Windows.Forms.BindingSource(Me.components)
    Me.cmdSave = New System.Windows.Forms.DataGridViewImageColumn()
    Me.F_LoginID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.F_IsAdmin = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.F_FileLimit = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.F_SizeLimit = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.F_OriginalAllowed = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.F_PDFAllowed = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.F_OriginalWhenNoPDF = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.F_OnlyLatestRev = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.F_ISGECVaultServer = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.F_SelectedPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.F_PW = New System.Windows.Forms.DataGridViewTextBoxColumn()
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer2.Panel2.SuspendLayout()
    Me.SplitContainer2.SuspendLayout()
    CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BSVltUser, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BSVaults, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BSUserVaults, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.SplitContainer1.Panel1.Controls.Add(Me.Grid1)
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
    Me.SplitContainer1.Size = New System.Drawing.Size(846, 464)
    Me.SplitContainer1.SplitterDistance = 266
    Me.SplitContainer1.TabIndex = 0
    '
    'Grid1
    '
    Me.Grid1.AutoGenerateColumns = False
    Me.Grid1.BackgroundColor = System.Drawing.SystemColors.Window
    Me.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.Grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cmdSave, Me.F_LoginID, Me.F_IsAdmin, Me.F_FileLimit, Me.F_SizeLimit, Me.F_OriginalAllowed, Me.F_PDFAllowed, Me.F_OriginalWhenNoPDF, Me.F_OnlyLatestRev, Me.F_ISGECVaultServer, Me.F_SelectedPath, Me.F_PW})
    Me.Grid1.DataSource = Me.BSVltUser
    Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Grid1.Location = New System.Drawing.Point(0, 0)
    Me.Grid1.MultiSelect = False
    Me.Grid1.Name = "Grid1"
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.Grid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.Grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.Grid1.Size = New System.Drawing.Size(846, 266)
    Me.Grid1.TabIndex = 0
    '
    'SplitContainer2
    '
    Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
    Me.SplitContainer2.Name = "SplitContainer2"
    '
    'SplitContainer2.Panel2
    '
    Me.SplitContainer2.Panel2.Controls.Add(Me.Grid2)
    Me.SplitContainer2.Size = New System.Drawing.Size(846, 194)
    Me.SplitContainer2.SplitterDistance = 496
    Me.SplitContainer2.TabIndex = 1
    '
    'Grid2
    '
    Me.Grid2.AllowUserToAddRows = False
    Me.Grid2.AllowUserToDeleteRows = False
    Me.Grid2.AutoGenerateColumns = False
    Me.Grid2.BackgroundColor = System.Drawing.SystemColors.Window
    Me.Grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.Grid2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AuthSave, Me.F_Selected, Me.F_VaultID, Me.F_VaultDB})
    Me.Grid2.DataSource = Me.BSVaults
    Me.Grid2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Grid2.Location = New System.Drawing.Point(0, 0)
    Me.Grid2.MultiSelect = False
    Me.Grid2.Name = "Grid2"
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
    DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.Grid2.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
    Me.Grid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.Grid2.Size = New System.Drawing.Size(346, 194)
    Me.Grid2.TabIndex = 1
    '
    'AuthSave
    '
    Me.AuthSave.HeaderText = "Save"
    Me.AuthSave.Image = CType(resources.GetObject("AuthSave.Image"), System.Drawing.Image)
    Me.AuthSave.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
    Me.AuthSave.Name = "AuthSave"
    Me.AuthSave.ReadOnly = True
    Me.AuthSave.Width = 50
    '
    'F_Selected
    '
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
    DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle5.NullValue = False
    DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
    Me.F_Selected.DefaultCellStyle = DataGridViewCellStyle5
    Me.F_Selected.HeaderText = "Selected"
    Me.F_Selected.Name = "F_Selected"
    Me.F_Selected.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.F_Selected.Width = 50
    '
    'ImgLst1
    '
    Me.ImgLst1.ImageStream = CType(resources.GetObject("ImgLst1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.ImgLst1.TransparentColor = System.Drawing.Color.Transparent
    Me.ImgLst1.Images.SetKeyName(0, "save.png")
    Me.ImgLst1.Images.SetKeyName(1, "pencil-2.png")
    Me.ImgLst1.Images.SetKeyName(2, "Knob Valid Green.png")
    '
    'BSVltUser
    '
    Me.BSVltUser.DataSource = GetType(ISGECVault.SIS.VLT.vltUser)
    '
    'F_VaultID
    '
    Me.F_VaultID.DataPropertyName = "VaultID"
    Me.F_VaultID.HeaderText = "VaultID"
    Me.F_VaultID.Name = "F_VaultID"
    Me.F_VaultID.ReadOnly = True
    Me.F_VaultID.Width = 50
    '
    'F_VaultDB
    '
    Me.F_VaultDB.DataPropertyName = "VaultDB"
    Me.F_VaultDB.HeaderText = "VaultDB"
    Me.F_VaultDB.Name = "F_VaultDB"
    Me.F_VaultDB.ReadOnly = True
    '
    'BSVaults
    '
    Me.BSVaults.DataSource = GetType(ISGECVault.SIS.VLT.Vaults)
    '
    'BSUserVaults
    '
    Me.BSUserVaults.DataSource = GetType(ISGECVault.SIS.VLT.Vaults)
    '
    'cmdSave
    '
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle1.NullValue = "Nothing"
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
    Me.cmdSave.DefaultCellStyle = DataGridViewCellStyle1
    Me.cmdSave.Frozen = True
    Me.cmdSave.HeaderText = "Save"
    Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
    Me.cmdSave.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
    Me.cmdSave.Name = "cmdSave"
    Me.cmdSave.ReadOnly = True
    Me.cmdSave.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.cmdSave.Width = 50
    '
    'F_LoginID
    '
    Me.F_LoginID.DataPropertyName = "LoginID"
    Me.F_LoginID.Frozen = True
    Me.F_LoginID.HeaderText = "LoginID"
    Me.F_LoginID.MaxInputLength = 8
    Me.F_LoginID.Name = "F_LoginID"
    '
    'F_IsAdmin
    '
    Me.F_IsAdmin.DataPropertyName = "IsAdmin"
    Me.F_IsAdmin.Frozen = True
    Me.F_IsAdmin.HeaderText = "IsAdmin"
    Me.F_IsAdmin.Name = "F_IsAdmin"
    '
    'F_FileLimit
    '
    Me.F_FileLimit.DataPropertyName = "FileLimit"
    DataGridViewCellStyle2.Format = "N0"
    DataGridViewCellStyle2.NullValue = Nothing
    Me.F_FileLimit.DefaultCellStyle = DataGridViewCellStyle2
    Me.F_FileLimit.Frozen = True
    Me.F_FileLimit.HeaderText = "FileLimit"
    Me.F_FileLimit.MaxInputLength = 5
    Me.F_FileLimit.Name = "F_FileLimit"
    '
    'F_SizeLimit
    '
    Me.F_SizeLimit.DataPropertyName = "SizeLimit"
    DataGridViewCellStyle3.Format = "N0"
    DataGridViewCellStyle3.NullValue = Nothing
    Me.F_SizeLimit.DefaultCellStyle = DataGridViewCellStyle3
    Me.F_SizeLimit.Frozen = True
    Me.F_SizeLimit.HeaderText = "SizeLimit [MB]"
    Me.F_SizeLimit.MaxInputLength = 5
    Me.F_SizeLimit.Name = "F_SizeLimit"
    '
    'F_OriginalAllowed
    '
    Me.F_OriginalAllowed.DataPropertyName = "OriginalAllowed"
    Me.F_OriginalAllowed.Frozen = True
    Me.F_OriginalAllowed.HeaderText = "OriginalAllowed"
    Me.F_OriginalAllowed.Name = "F_OriginalAllowed"
    '
    'F_PDFAllowed
    '
    Me.F_PDFAllowed.DataPropertyName = "PDFAllowed"
    Me.F_PDFAllowed.Frozen = True
    Me.F_PDFAllowed.HeaderText = "PDFAllowed"
    Me.F_PDFAllowed.Name = "F_PDFAllowed"
    '
    'F_OriginalWhenNoPDF
    '
    Me.F_OriginalWhenNoPDF.DataPropertyName = "OriginalWhenNoPDF"
    Me.F_OriginalWhenNoPDF.Frozen = True
    Me.F_OriginalWhenNoPDF.HeaderText = "OriginalWhenNoPDF"
    Me.F_OriginalWhenNoPDF.Name = "F_OriginalWhenNoPDF"
    '
    'F_OnlyLatestRev
    '
    Me.F_OnlyLatestRev.DataPropertyName = "OnlyLatestRev"
    Me.F_OnlyLatestRev.Frozen = True
    Me.F_OnlyLatestRev.HeaderText = "OnlyLatestRev"
    Me.F_OnlyLatestRev.Name = "F_OnlyLatestRev"
    '
    'F_ISGECVaultServer
    '
    Me.F_ISGECVaultServer.DataPropertyName = "ISGECVaultServer"
    Me.F_ISGECVaultServer.Frozen = True
    Me.F_ISGECVaultServer.HeaderText = "ISGECVaultServer"
    Me.F_ISGECVaultServer.MaxInputLength = 50
    Me.F_ISGECVaultServer.Name = "F_ISGECVaultServer"
    '
    'F_SelectedPath
    '
    Me.F_SelectedPath.DataPropertyName = "SelectedPath"
    Me.F_SelectedPath.Frozen = True
    Me.F_SelectedPath.HeaderText = "SelectedPath"
    Me.F_SelectedPath.MaxInputLength = 500
    Me.F_SelectedPath.Name = "F_SelectedPath"
    '
    'F_PW
    '
    Me.F_PW.DataPropertyName = "PW"
    Me.F_PW.HeaderText = "PW"
    Me.F_PW.MaxInputLength = 20
    Me.F_PW.Name = "F_PW"
    '
    'frmUser
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(846, 464)
    Me.Controls.Add(Me.SplitContainer1)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmUser"
    Me.ShowInTaskbar = False
    Me.Text = "Users"
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer1.ResumeLayout(False)
    CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer2.Panel2.ResumeLayout(False)
    CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer2.ResumeLayout(False)
    CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BSVltUser, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BSVaults, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BSUserVaults, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents SplitContainer1 As SplitContainer
  Friend WithEvents BSVltUser As BindingSource
  Friend WithEvents Grid1 As DataGridView
  Friend WithEvents ImgLst1 As ImageList
  Friend WithEvents SplitContainer2 As SplitContainer
  Friend WithEvents BSVaults As BindingSource
  Friend WithEvents BSUserVaults As BindingSource
  Friend WithEvents Grid2 As DataGridView
  Friend WithEvents AuthSave As DataGridViewImageColumn
  Friend WithEvents F_Selected As DataGridViewCheckBoxColumn
  Friend WithEvents F_VaultID As DataGridViewTextBoxColumn
  Friend WithEvents F_VaultDB As DataGridViewTextBoxColumn
  Friend WithEvents cmdSave As DataGridViewImageColumn
  Friend WithEvents F_LoginID As DataGridViewTextBoxColumn
  Friend WithEvents F_IsAdmin As DataGridViewCheckBoxColumn
  Friend WithEvents F_FileLimit As DataGridViewTextBoxColumn
  Friend WithEvents F_SizeLimit As DataGridViewTextBoxColumn
  Friend WithEvents F_OriginalAllowed As DataGridViewCheckBoxColumn
  Friend WithEvents F_PDFAllowed As DataGridViewCheckBoxColumn
  Friend WithEvents F_OriginalWhenNoPDF As DataGridViewCheckBoxColumn
  Friend WithEvents F_OnlyLatestRev As DataGridViewCheckBoxColumn
  Friend WithEvents F_ISGECVaultServer As DataGridViewTextBoxColumn
  Friend WithEvents F_SelectedPath As DataGridViewTextBoxColumn
  Friend WithEvents F_PW As DataGridViewTextBoxColumn
End Class
