<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registerForm
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
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.txtRegUsername = New System.Windows.Forms.TextBox()
        Me.txtRegPassword = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.cmbSecurityQuestion = New System.Windows.Forms.ComboBox()
        Me.lblSec = New System.Windows.Forms.Label()
        Me.txtSecurityAnswer = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRegister
        '
        Me.lblRegister.AutoSize = True
        Me.lblRegister.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegister.Location = New System.Drawing.Point(95, 15)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(223, 28)
        Me.lblRegister.TabIndex = 0
        Me.lblRegister.Text = "Register New Account"
        '
        'txtRegUsername
        '
        Me.txtRegUsername.Location = New System.Drawing.Point(31, 93)
        Me.txtRegUsername.Name = "txtRegUsername"
        Me.txtRegUsername.Size = New System.Drawing.Size(140, 22)
        Me.txtRegUsername.TabIndex = 1
        '
        'txtRegPassword
        '
        Me.txtRegPassword.Location = New System.Drawing.Point(31, 172)
        Me.txtRegPassword.Name = "txtRegPassword"
        Me.txtRegPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRegPassword.Size = New System.Drawing.Size(140, 22)
        Me.txtRegPassword.TabIndex = 2
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(28, 63)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(76, 19)
        Me.lblUser.TabIndex = 3
        Me.lblUser.Text = "Username"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPass.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(28, 142)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(73, 19)
        Me.lblPass.TabIndex = 4
        Me.lblPass.Text = "Password"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.txtSecurityAnswer)
        Me.Panel1.Controls.Add(Me.lblSec)
        Me.Panel1.Controls.Add(Me.cmbSecurityQuestion)
        Me.Panel1.Controls.Add(Me.lblUser)
        Me.Panel1.Controls.Add(Me.lblPass)
        Me.Panel1.Controls.Add(Me.btnRegister)
        Me.Panel1.Controls.Add(Me.txtRegUsername)
        Me.Panel1.Controls.Add(Me.txtRegPassword)
        Me.Panel1.Controls.Add(Me.lblRegister)
        Me.Panel1.Location = New System.Drawing.Point(181, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 367)
        Me.Panel1.TabIndex = 5
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(158, 295)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(102, 41)
        Me.btnRegister.TabIndex = 2
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'cmbSecurityQuestion
        '
        Me.cmbSecurityQuestion.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSecurityQuestion.FormattingEnabled = True
        Me.cmbSecurityQuestion.Items.AddRange(New Object() {"What is your first pet's name ", "What is your first car", "What is your mother's name ", "What is your grandmother's name", "Who is your bestfriend"})
        Me.cmbSecurityQuestion.Location = New System.Drawing.Point(32, 245)
        Me.cmbSecurityQuestion.Name = "cmbSecurityQuestion"
        Me.cmbSecurityQuestion.Size = New System.Drawing.Size(139, 25)
        Me.cmbSecurityQuestion.TabIndex = 5
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec.Location = New System.Drawing.Point(32, 222)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(126, 19)
        Me.lblSec.TabIndex = 6
        Me.lblSec.Text = "Security Question"
        '
        'txtSecurityAnswer
        '
        Me.txtSecurityAnswer.Location = New System.Drawing.Point(212, 245)
        Me.txtSecurityAnswer.Name = "txtSecurityAnswer"
        Me.txtSecurityAnswer.Size = New System.Drawing.Size(100, 22)
        Me.txtSecurityAnswer.TabIndex = 7
        '
        'registerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "registerForm"
        Me.Text = "registerForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblRegister As Label
    Friend WithEvents txtRegUsername As TextBox
    Friend WithEvents txtRegPassword As TextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRegister As Button
    Friend WithEvents lblSec As Label
    Friend WithEvents cmbSecurityQuestion As ComboBox
    Friend WithEvents txtSecurityAnswer As TextBox
End Class
