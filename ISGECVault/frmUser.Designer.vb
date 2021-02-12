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
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUser))
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
    Me.Grid1 = New System.Windows.Forms.DataGridView()
    Me.BSVltUser = New System.Windows.Forms.BindingSource(Me.components)
    Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
    Me.Grid2 = New System.Windows.Forms.DataGridView()
    Me.AuthSave = New System.Windows.Forms.DataGridViewButtonColumn()
    Me.F_Selected = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.F_VaultID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.F_VaultDB = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.BSVaults = New System.Windows.Forms.BindingSource(Me.components)
    Me.ImgLst1 = New System.Windows.Forms.ImageList(Me.components)
    Me.BSUserVaults = New System.Windows.Forms.BindingSource(Me.components)
    Me.cmdSave = New System.Windows.Forms.DataGridViewButtonColumn()
    Me.F_LoginID = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.F_IsAdmin = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.F_FileLimit = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.F_SizeLimit = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.F_OriginalAllowed = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.F_PDFAllowed = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.F_OriginalWhenNoPDF = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.F_OnlyLatestRev = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.F_WIPAllowed = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.F_ISGECVaultServer = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.F_SelectedPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.F_PW = New System.Windows.Forms.DataGridViewTextBoxColumn()
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BSVltUser, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer2.Panel2.SuspendLayout()
    Me.SplitContainer2.SuspendLayout()
    CType(Me.Grid2, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.SplitContainer1.Size = New System.Drawing.Size(764, 464)
    Me.SplitContainer1.SplitterDistance = 266
    Me.SplitContainer1.TabIndex = 0
    '
    'Grid1
    '
    Me.Grid1.AutoGenerateColumns = False
    Me.Grid1.BackgroundColor = System.Drawing.SystemColors.Window
    Me.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.Grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cmdSave, Me.F_LoginID, Me.F_IsAdmin, Me.F_FileLimit, Me.F_SizeLimit, Me.F_OriginalAllowed, Me.F_PDFAllowed, Me.F_OriginalWhenNoPDF, Me.F_OnlyLatestRev, Me.F_WIPAllowed, Me.F_ISGECVaultServer, Me.F_SelectedPath, Me.F_PW})
    Me.Grid1.DataSource = Me.BSVltUser
    Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Grid1.Location = New System.Drawing.Point(0, 0)
    Me.Grid1.MultiSelect = False
    Me.Grid1.Name = "Grid1"
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
    DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.Grid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
    Me.Grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.Grid1.Size = New System.Drawing.Size(764, 266)
    Me.Grid1.TabIndex = 0
    '
    'BSVltUser
    '
    Me.BSVltUser.DataSource = GetType(ISGECVault.SIS.VLT.vltUser)
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
    Me.SplitContainer2.Size = New System.Drawing.Size(764, 194)
    Me.SplitContainer2.SplitterDistance = 447
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
    DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
    DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.Grid2.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
    Me.Grid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.Grid2.Size = New System.Drawing.Size(313, 194)
    Me.Grid2.TabIndex = 1
    '
    'AuthSave
    '
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonFace
    DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ButtonFace
    DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
    Me.AuthSave.DefaultCellStyle = DataGridViewCellStyle6
    Me.AuthSave.FillWeight = 50.0!
    Me.AuthSave.HeaderText = "Save"
    Me.AuthSave.Name = "AuthSave"
    Me.AuthSave.ReadOnly = True
    Me.AuthSave.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.AuthSave.Text = "Save"
    Me.AuthSave.UseColumnTextForButtonValue = True
    Me.AuthSave.Width = 50
    '
    'F_Selected
    '
    DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
    DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle7.NullValue = False
    DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
    Me.F_Selected.DefaultCellStyle = DataGridViewCellStyle7
    Me.F_Selected.HeaderText = "Selected"
    Me.F_Selected.Name = "F_Selected"
    Me.F_Selected.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.F_Selected.Width = 50
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
    'ImgLst1
    '
    Me.ImgLst1.ImageStream = CType(resources.GetObject("ImgLst1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.ImgLst1.TransparentColor = System.Drawing.Color.Transparent
    Me.ImgLst1.Images.SetKeyName(0, "save.png")
    Me.ImgLst1.Images.SetKeyName(1, "pencil-2.png")
    Me.ImgLst1.Images.SetKeyName(2, "Knob Valid Green.png")
    '
    'BSUserVaults
    '
    Me.BSUserVaults.DataSource = GetType(ISGECVault.SIS.VLT.Vaults)
    '
    'cmdSave
    '
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle1.NullValue = Nothing
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonFace
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
    Me.cmdSave.DefaultCellStyle = DataGridViewCellStyle1
    Me.cmdSave.FillWeight = 60.0!
    Me.cmdSave.Frozen = True
    Me.cmdSave.HeaderText = "Save"
    Me.cmdSave.Name = "cmdSave"
    Me.cmdSave.ReadOnly = True
    Me.cmdSave.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.cmdSave.Text = "Save"
    Me.cmdSave.UseColumnTextForButtonValue = True
    Me.cmdSave.Width = 50
    '
    'F_LoginID
    '
    Me.F_LoginID.DataPropertyName = "LoginID"
    Me.F_LoginID.Frozen = True
    Me.F_LoginID.HeaderText = "Login ID"
    Me.F_LoginID.MaxInputLength = 8
    Me.F_LoginID.Name = "F_LoginID"
    Me.F_LoginID.Width = 50
    '
    'F_IsAdmin
    '
    Me.F_IsAdmin.DataPropertyName = "IsAdmin"
    Me.F_IsAdmin.Frozen = True
    Me.F_IsAdmin.HeaderText = "Is Admin"
    Me.F_IsAdmin.Name = "F_IsAdmin"
    Me.F_IsAdmin.Width = 50
    '
    'F_FileLimit
    '
    Me.F_FileLimit.DataPropertyName = "FileLimit"
    DataGridViewCellStyle2.Format = "N0"
    DataGridViewCellStyle2.NullValue = Nothing
    Me.F_FileLimit.DefaultCellStyle = DataGridViewCellStyle2
    Me.F_FileLimit.Frozen = True
    Me.F_FileLimit.HeaderText = "File Limit"
    Me.F_FileLimit.MaxInputLength = 5
    Me.F_FileLimit.Name = "F_FileLimit"
    Me.F_FileLimit.Width = 50
    '
    'F_SizeLimit
    '
    Me.F_SizeLimit.DataPropertyName = "SizeLimit"
    DataGridViewCellStyle3.Format = "N0"
    DataGridViewCellStyle3.NullValue = Nothing
    Me.F_SizeLimit.DefaultCellStyle = DataGridViewCellStyle3
    Me.F_SizeLimit.Frozen = True
    Me.F_SizeLimit.HeaderText = "Size Limit [MB]"
    Me.F_SizeLimit.MaxInputLength = 5
    Me.F_SizeLimit.Name = "F_SizeLimit"
    Me.F_SizeLimit.Width = 50
    '
    'F_OriginalAllowed
    '
    Me.F_OriginalAllowed.DataPropertyName = "OriginalAllowed"
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle4.NullValue = False
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.F_OriginalAllowed.DefaultCellStyle = DataGridViewCellStyle4
    Me.F_OriginalAllowed.Frozen = True
    Me.F_OriginalAllowed.HeaderText = "Original Allowed"
    Me.F_OriginalAllowed.Name = "F_OriginalAllowed"
    Me.F_OriginalAllowed.Width = 50
    '
    'F_PDFAllowed
    '
    Me.F_PDFAllowed.DataPropertyName = "PDFAllowed"
    Me.F_PDFAllowed.Frozen = True
    Me.F_PDFAllowed.HeaderText = "PDF Allowed"
    Me.F_PDFAllowed.Name = "F_PDFAllowed"
    '
    'F_OriginalWhenNoPDF
    '
    Me.F_OriginalWhenNoPDF.DataPropertyName = "OriginalWhenNoPDF"
    Me.F_OriginalWhenNoPDF.Frozen = True
    Me.F_OriginalWhenNoPDF.HeaderText = "Original When No PDF"
    Me.F_OriginalWhenNoPDF.Name = "F_OriginalWhenNoPDF"
    Me.F_OriginalWhenNoPDF.Width = 60
    '
    'F_OnlyLatestRev
    '
    Me.F_OnlyLatestRev.DataPropertyName = "OnlyLatestRev"
    Me.F_OnlyLatestRev.HeaderText = "Only Latest Rev"
    Me.F_OnlyLatestRev.Name = "F_OnlyLatestRev"
    Me.F_OnlyLatestRev.Width = 60
    '
    'F_WIPAllowed
    '
    Me.F_WIPAllowed.DataPropertyName = "WIPAllowed"
    Me.F_WIPAllowed.HeaderText = "WIP Allowed"
    Me.F_WIPAllowed.Name = "F_WIPAllowed"
    Me.F_WIPAllowed.Width = 60
    '
    'F_ISGECVaultServer
    '
    Me.F_ISGECVaultServer.DataPropertyName = "ISGECVaultServer"
    Me.F_ISGECVaultServer.HeaderText = "ISGEC Vault Server"
    Me.F_ISGECVaultServer.MaxInputLength = 50
    Me.F_ISGECVaultServer.Name = "F_ISGECVaultServer"
    '
    'F_SelectedPath
    '
    Me.F_SelectedPath.DataPropertyName = "SelectedPath"
    Me.F_SelectedPath.HeaderText = "Selected Path"
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
    Me.ClientSize = New System.Drawing.Size(764, 464)
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
    CType(Me.BSVltUser, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer2.Panel2.ResumeLayout(False)
    CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer2.ResumeLayout(False)
    CType(Me.Grid2, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents AuthSave As DataGridViewButtonColumn
  Friend WithEvents F_Selected As DataGridViewCheckBoxColumn
  Friend WithEvents F_VaultID As DataGridViewTextBoxColumn
  Friend WithEvents F_VaultDB As DataGridViewTextBoxColumn
  Friend WithEvents cmdSave As DataGridViewButtonColumn
  Friend WithEvents F_LoginID As DataGridViewTextBoxColumn
  Friend WithEvents F_IsAdmin As DataGridViewCheckBoxColumn
  Friend WithEvents F_FileLimit As DataGridViewTextBoxColumn
  Friend WithEvents F_SizeLimit As DataGridViewTextBoxColumn
  Friend WithEvents F_OriginalAllowed As DataGridViewCheckBoxColumn
  Friend WithEvents F_PDFAllowed As DataGridViewCheckBoxColumn
  Friend WithEvents F_OriginalWhenNoPDF As DataGridViewCheckBoxColumn
  Friend WithEvents F_OnlyLatestRev As DataGridViewCheckBoxColumn
  Friend WithEvents F_WIPAllowed As DataGridViewCheckBoxColumn
  Friend WithEvents F_ISGECVaultServer As DataGridViewTextBoxColumn
  Friend WithEvents F_SelectedPath As DataGridViewTextBoxColumn
  Friend WithEvents F_PW As DataGridViewTextBoxColumn
End Class
