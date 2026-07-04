<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgetPassword
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnResetPassword = New System.Windows.Forms.Button()
        Me.btnFindUser = New System.Windows.Forms.Button()
        Me.lblNewPass = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.txtForgotUsername = New System.Windows.Forms.TextBox()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnResetPassword)
        Me.Panel1.Controls.Add(Me.btnFindUser)
        Me.Panel1.Controls.Add(Me.lblNewPass)
        Me.Panel1.Controls.Add(Me.lblUser)
        Me.Panel1.Controls.Add(Me.txtNewPassword)
        Me.Panel1.Controls.Add(Me.txtAnswer)
        Me.Panel1.Controls.Add(Me.txtForgotUsername)
        Me.Panel1.Controls.Add(Me.lblQuestion)
        Me.Panel1.Location = New System.Drawing.Point(181, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(416, 328)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Forgot Your Password?"
        '
        'btnResetPassword
        '
        Me.btnResetPassword.Location = New System.Drawing.Point(130, 289)
        Me.btnResetPassword.Name = "btnResetPassword"
        Me.btnResetPassword.Size = New System.Drawing.Size(156, 23)
        Me.btnResetPassword.TabIndex = 7
        Me.btnResetPassword.Text = "Reset Password"
        Me.btnResetPassword.UseVisualStyleBackColor = True
        '
        'btnFindUser
        '
        Me.btnFindUser.Location = New System.Drawing.Point(49, 138)
        Me.btnFindUser.Name = "btnFindUser"
        Me.btnFindUser.Size = New System.Drawing.Size(125, 23)
        Me.btnFindUser.TabIndex = 6
        Me.btnFindUser.Text = "Search User"
        Me.btnFindUser.UseVisualStyleBackColor = True
        '
        'lblNewPass
        '
        Me.lblNewPass.AutoSize = True
        Me.lblNewPass.Location = New System.Drawing.Point(260, 205)
        Me.lblNewPass.Name = "lblNewPass"
        Me.lblNewPass.Size = New System.Drawing.Size(100, 17)
        Me.lblNewPass.TabIndex = 5
        Me.lblNewPass.Text = "New Password"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(46, 64)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(73, 17)
        Me.lblUser.TabIndex = 4
        Me.lblUser.Text = "Username"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(260, 225)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(100, 22)
        Me.txtNewPassword.TabIndex = 3
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(49, 225)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(100, 22)
        Me.txtAnswer.TabIndex = 2
        '
        'txtForgotUsername
        '
        Me.txtForgotUsername.Location = New System.Drawing.Point(49, 84)
        Me.txtForgotUsername.Name = "txtForgotUsername"
        Me.txtForgotUsername.Size = New System.Drawing.Size(100, 22)
        Me.txtForgotUsername.TabIndex = 1
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(46, 205)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(51, 17)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "Label1"
        '
        'forgetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "forgetPassword"
        Me.Text = "forgetPassword"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnResetPassword As Button
    Friend WithEvents btnFindUser As Button
    Friend WithEvents lblNewPass As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents txtForgotUsername As TextBox
    Friend WithEvents lblQuestion As Label
End Class
