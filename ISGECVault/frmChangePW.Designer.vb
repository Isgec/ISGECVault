<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePW
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangePW))
    Me.cmdOK = New System.Windows.Forms.Button()
    Me.cmdCancel = New System.Windows.Forms.Button()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.F_OldPW = New System.Windows.Forms.TextBox()
    Me.F_NewPW = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.F_CnfPW = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.msgErr = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'cmdOK
    '
    Me.cmdOK.Location = New System.Drawing.Point(186, 125)
    Me.cmdOK.Name = "cmdOK"
    Me.cmdOK.Size = New System.Drawing.Size(75, 23)
    Me.cmdOK.TabIndex = 5
    Me.cmdOK.Text = "OK"
    Me.cmdOK.UseVisualStyleBackColor = True
    '
    'cmdCancel
    '
    Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.cmdCancel.Location = New System.Drawing.Point(90, 125)
    Me.cmdCancel.Name = "cmdCancel"
    Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
    Me.cmdCancel.TabIndex = 4
    Me.cmdCancel.Text = "Cancel"
    Me.cmdCancel.UseVisualStyleBackColor = True
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 20)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(72, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Old Password"
    '
    'F_OldPW
    '
    Me.F_OldPW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.F_OldPW.Location = New System.Drawing.Point(90, 17)
    Me.F_OldPW.MaxLength = 20
    Me.F_OldPW.Name = "F_OldPW"
    Me.F_OldPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.F_OldPW.Size = New System.Drawing.Size(171, 20)
    Me.F_OldPW.TabIndex = 1
    Me.F_OldPW.UseSystemPasswordChar = True
    '
    'F_NewPW
    '
    Me.F_NewPW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.F_NewPW.Location = New System.Drawing.Point(90, 52)
    Me.F_NewPW.MaxLength = 20
    Me.F_NewPW.Name = "F_NewPW"
    Me.F_NewPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.F_NewPW.Size = New System.Drawing.Size(171, 20)
    Me.F_NewPW.TabIndex = 2
    Me.F_NewPW.UseSystemPasswordChar = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 55)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(78, 13)
    Me.Label1.TabIndex = 4
    Me.Label1.Text = "New Password"
    '
    'F_CnfPW
    '
    Me.F_CnfPW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.F_CnfPW.Location = New System.Drawing.Point(90, 88)
    Me.F_CnfPW.MaxLength = 20
    Me.F_CnfPW.Name = "F_CnfPW"
    Me.F_CnfPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.F_CnfPW.Size = New System.Drawing.Size(171, 20)
    Me.F_CnfPW.TabIndex = 3
    Me.F_CnfPW.UseSystemPasswordChar = True
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(42, 91)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(42, 13)
    Me.Label3.TabIndex = 6
    Me.Label3.Text = "Confirm"
    '
    'msgErr
    '
    Me.msgErr.AutoSize = True
    Me.msgErr.ForeColor = System.Drawing.Color.Red
    Me.msgErr.Location = New System.Drawing.Point(12, 156)
    Me.msgErr.Name = "msgErr"
    Me.msgErr.Size = New System.Drawing.Size(0, 13)
    Me.msgErr.TabIndex = 8
    '
    'frmChangePW
    '
    Me.AcceptButton = Me.cmdOK
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.cmdCancel
    Me.ClientSize = New System.Drawing.Size(330, 178)
    Me.Controls.Add(Me.msgErr)
    Me.Controls.Add(Me.F_CnfPW)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.F_NewPW)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.F_OldPW)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.cmdCancel)
    Me.Controls.Add(Me.cmdOK)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmChangePW"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Change Password"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents cmdOK As Button
  Friend WithEvents cmdCancel As Button
  Friend WithEvents Label2 As Label
  Friend WithEvents F_OldPW As TextBox
  Friend WithEvents F_NewPW As TextBox
  Friend WithEvents Label1 As Label
  Friend WithEvents F_CnfPW As TextBox
  Friend WithEvents Label3 As Label
  Friend WithEvents msgErr As Label
End Class
