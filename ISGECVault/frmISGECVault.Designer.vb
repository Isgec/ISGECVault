<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmISGECVault
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmISGECVault))
    Me.mnuISGECVault = New System.Windows.Forms.MenuStrip()
    Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuLogin = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuChangePassword = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuVaults = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuAdmin = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuUserAuthorization = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuLogViewer = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuStartServer = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuWindows = New System.Windows.Forms.ToolStripMenuItem()
    Me.stsISGECVault = New System.Windows.Forms.StatusStrip()
    Me.stsLoginID = New System.Windows.Forms.ToolStripStatusLabel()
    Me.tlbISGECVault = New System.Windows.Forms.ToolStrip()
    Me.mnuISGECVault.SuspendLayout()
    Me.stsISGECVault.SuspendLayout()
    Me.SuspendLayout()
    '
    'mnuISGECVault
    '
    Me.mnuISGECVault.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuVaults, Me.mnuAdmin, Me.mnuWindows})
    Me.mnuISGECVault.Location = New System.Drawing.Point(0, 0)
    Me.mnuISGECVault.MdiWindowListItem = Me.mnuWindows
    Me.mnuISGECVault.Name = "mnuISGECVault"
    Me.mnuISGECVault.Size = New System.Drawing.Size(887, 24)
    Me.mnuISGECVault.TabIndex = 1
    Me.mnuISGECVault.Text = "MenuStrip1"
    '
    'mnuFile
    '
    Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLogin, Me.mnuLogout, Me.mnuExit})
    Me.mnuFile.Name = "mnuFile"
    Me.mnuFile.Size = New System.Drawing.Size(37, 20)
    Me.mnuFile.Text = "&File"
    '
    'mnuLogin
    '
    Me.mnuLogin.Name = "mnuLogin"
    Me.mnuLogin.Size = New System.Drawing.Size(152, 22)
    Me.mnuLogin.Text = "&Login"
    '
    'mnuLogout
    '
    Me.mnuLogout.Enabled = False
    Me.mnuLogout.Name = "mnuLogout"
    Me.mnuLogout.Size = New System.Drawing.Size(152, 22)
    Me.mnuLogout.Text = "L&ogout"
    '
    'mnuExit
    '
    Me.mnuExit.Name = "mnuExit"
    Me.mnuExit.Size = New System.Drawing.Size(152, 22)
    Me.mnuExit.Text = "E&xit"
    '
    'mnuEdit
    '
    Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuChangePassword})
    Me.mnuEdit.Name = "mnuEdit"
    Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
    Me.mnuEdit.Text = "&Edit"
    Me.mnuEdit.Visible = False
    '
    'mnuChangePassword
    '
    Me.mnuChangePassword.Name = "mnuChangePassword"
    Me.mnuChangePassword.Size = New System.Drawing.Size(168, 22)
    Me.mnuChangePassword.Text = "Change Password"
    '
    'mnuVaults
    '
    Me.mnuVaults.Name = "mnuVaults"
    Me.mnuVaults.Size = New System.Drawing.Size(50, 20)
    Me.mnuVaults.Text = "&Vaults"
    Me.mnuVaults.Visible = False
    '
    'mnuAdmin
    '
    Me.mnuAdmin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUserAuthorization, Me.mnuLogViewer, Me.mnuStartServer})
    Me.mnuAdmin.Name = "mnuAdmin"
    Me.mnuAdmin.Size = New System.Drawing.Size(55, 20)
    Me.mnuAdmin.Text = "&Admin"
    Me.mnuAdmin.Visible = False
    '
    'mnuUserAuthorization
    '
    Me.mnuUserAuthorization.Name = "mnuUserAuthorization"
    Me.mnuUserAuthorization.Size = New System.Drawing.Size(183, 22)
    Me.mnuUserAuthorization.Text = "&User Authorization"
    '
    'mnuLogViewer
    '
    Me.mnuLogViewer.Name = "mnuLogViewer"
    Me.mnuLogViewer.Size = New System.Drawing.Size(183, 22)
    Me.mnuLogViewer.Text = "Log Viewer"
    '
    'mnuStartServer
    '
    Me.mnuStartServer.Name = "mnuStartServer"
    Me.mnuStartServer.Size = New System.Drawing.Size(183, 22)
    Me.mnuStartServer.Text = "Server Configuration"
    '
    'mnuWindows
    '
    Me.mnuWindows.Name = "mnuWindows"
    Me.mnuWindows.Size = New System.Drawing.Size(68, 20)
    Me.mnuWindows.Text = "&Windows"
    Me.mnuWindows.Visible = False
    '
    'stsISGECVault
    '
    Me.stsISGECVault.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsLoginID})
    Me.stsISGECVault.Location = New System.Drawing.Point(0, 428)
    Me.stsISGECVault.Name = "stsISGECVault"
    Me.stsISGECVault.Size = New System.Drawing.Size(887, 22)
    Me.stsISGECVault.TabIndex = 2
    Me.stsISGECVault.Text = "StatusStrip1"
    '
    'stsLoginID
    '
    Me.stsLoginID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
    Me.stsLoginID.Name = "stsLoginID"
    Me.stsLoginID.Size = New System.Drawing.Size(0, 17)
    '
    'tlbISGECVault
    '
    Me.tlbISGECVault.Location = New System.Drawing.Point(0, 24)
    Me.tlbISGECVault.Name = "tlbISGECVault"
    Me.tlbISGECVault.Size = New System.Drawing.Size(887, 25)
    Me.tlbISGECVault.TabIndex = 3
    Me.tlbISGECVault.Text = "ToolStrip1"
    '
    'frmISGECVault
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(887, 450)
    Me.Controls.Add(Me.tlbISGECVault)
    Me.Controls.Add(Me.stsISGECVault)
    Me.Controls.Add(Me.mnuISGECVault)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.IsMdiContainer = True
    Me.MainMenuStrip = Me.mnuISGECVault
    Me.Name = "frmISGECVault"
    Me.Text = "ISGEC Vault"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.mnuISGECVault.ResumeLayout(False)
    Me.mnuISGECVault.PerformLayout()
    Me.stsISGECVault.ResumeLayout(False)
    Me.stsISGECVault.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents mnuISGECVault As MenuStrip
  Friend WithEvents stsISGECVault As StatusStrip
  Friend WithEvents tlbISGECVault As ToolStrip
  Friend WithEvents mnuFile As ToolStripMenuItem
  Friend WithEvents mnuLogin As ToolStripMenuItem
  Friend WithEvents mnuLogout As ToolStripMenuItem
  Friend WithEvents mnuExit As ToolStripMenuItem
  Friend WithEvents mnuEdit As ToolStripMenuItem
  Friend WithEvents mnuVaults As ToolStripMenuItem
  Friend WithEvents mnuChangePassword As ToolStripMenuItem
  Friend WithEvents mnuAdmin As ToolStripMenuItem
  Friend WithEvents mnuUserAuthorization As ToolStripMenuItem
  Friend WithEvents mnuLogViewer As ToolStripMenuItem
  Friend WithEvents stsLoginID As ToolStripStatusLabel
  Friend WithEvents mnuWindows As ToolStripMenuItem
  Friend WithEvents mnuStartServer As ToolStripMenuItem
End Class
