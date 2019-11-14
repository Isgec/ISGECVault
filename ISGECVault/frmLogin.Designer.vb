<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.cmdCancel = New System.Windows.Forms.Button()
    Me.cmdOK = New System.Windows.Forms.Button()
    Me.F_Password = New System.Windows.Forms.TextBox()
    Me.F_LoginID = New System.Windows.Forms.TextBox()
    Me.lblErr = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(17, 23)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(47, 13)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Login ID"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(11, 56)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(53, 13)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "Password"
    '
    'cmdCancel
    '
    Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.cmdCancel.Location = New System.Drawing.Point(226, 95)
    Me.cmdCancel.Name = "cmdCancel"
    Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
    Me.cmdCancel.TabIndex = 5
    Me.cmdCancel.Text = "Cancel"
    Me.cmdCancel.UseVisualStyleBackColor = True
    '
    'cmdOK
    '
    Me.cmdOK.Location = New System.Drawing.Point(132, 95)
    Me.cmdOK.Name = "cmdOK"
    Me.cmdOK.Size = New System.Drawing.Size(75, 23)
    Me.cmdOK.TabIndex = 4
    Me.cmdOK.Text = "Login"
    Me.cmdOK.UseVisualStyleBackColor = True
    '
    'F_Password
    '
    Me.F_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.F_Password.Location = New System.Drawing.Point(76, 53)
    Me.F_Password.MaxLength = 20
    Me.F_Password.Name = "F_Password"
    Me.F_Password.Size = New System.Drawing.Size(225, 20)
    Me.F_Password.TabIndex = 3
    Me.F_Password.UseSystemPasswordChar = True
    '
    'F_LoginID
    '
    Me.F_LoginID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.F_LoginID.Location = New System.Drawing.Point(76, 20)
    Me.F_LoginID.MaxLength = 8
    Me.F_LoginID.Name = "F_LoginID"
    Me.F_LoginID.Size = New System.Drawing.Size(225, 20)
    Me.F_LoginID.TabIndex = 2
    '
    'lblErr
    '
    Me.lblErr.AutoSize = True
    Me.lblErr.ForeColor = System.Drawing.Color.Red
    Me.lblErr.Location = New System.Drawing.Point(12, 153)
    Me.lblErr.Name = "lblErr"
    Me.lblErr.Size = New System.Drawing.Size(0, 13)
    Me.lblErr.TabIndex = 6
    '
    'frmLogin
    '
    Me.AcceptButton = Me.cmdOK
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.cmdCancel
    Me.ClientSize = New System.Drawing.Size(323, 143)
    Me.Controls.Add(Me.lblErr)
    Me.Controls.Add(Me.F_LoginID)
    Me.Controls.Add(Me.F_Password)
    Me.Controls.Add(Me.cmdOK)
    Me.Controls.Add(Me.cmdCancel)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmLogin"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Login"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label2 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents cmdCancel As Button
  Friend WithEvents cmdOK As Button
  Friend WithEvents F_Password As TextBox
  Friend WithEvents F_LoginID As TextBox
  Friend WithEvents lblErr As Label
End Class
