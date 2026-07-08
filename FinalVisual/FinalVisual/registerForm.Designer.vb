<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registerForm
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
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.txtRegUsername = New System.Windows.Forms.TextBox()
        Me.txtRegPassword = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPlate = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.cmbCarType = New System.Windows.Forms.ComboBox()
        Me.rbStaff = New System.Windows.Forms.RadioButton()
        Me.rbCustomer = New System.Windows.Forms.RadioButton()
        Me.txtSecurityAnswer = New System.Windows.Forms.TextBox()
        Me.lblSec = New System.Windows.Forms.Label()
        Me.cmbSecurityQuestion = New System.Windows.Forms.ComboBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRegister
        '
        Me.lblRegister.AutoSize = True
        Me.lblRegister.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegister.Location = New System.Drawing.Point(321, 4)
        Me.lblRegister.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(178, 21)
        Me.lblRegister.TabIndex = 0
        Me.lblRegister.Text = "Register New Account"
        '
        'txtRegUsername
        '
        Me.txtRegUsername.Location = New System.Drawing.Point(385, 29)
        Me.txtRegUsername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRegUsername.Name = "txtRegUsername"
        Me.txtRegUsername.Size = New System.Drawing.Size(106, 20)
        Me.txtRegUsername.TabIndex = 1
        '
        'txtRegPassword
        '
        Me.txtRegPassword.Location = New System.Drawing.Point(385, 57)
        Me.txtRegPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRegPassword.Name = "txtRegPassword"
        Me.txtRegPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRegPassword.Size = New System.Drawing.Size(106, 20)
        Me.txtRegPassword.TabIndex = 2
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(320, 36)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(59, 13)
        Me.lblUser.TabIndex = 3
        Me.lblUser.Text = "Username"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPass.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(322, 61)
        Me.lblPass.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(57, 13)
        Me.lblPass.TabIndex = 4
        Me.lblPass.Text = "Password"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtPlate)
        Me.Panel1.Controls.Add(Me.txtPhone)
        Me.Panel1.Controls.Add(Me.cmbCarType)
        Me.Panel1.Controls.Add(Me.rbStaff)
        Me.Panel1.Controls.Add(Me.rbCustomer)
        Me.Panel1.Controls.Add(Me.txtSecurityAnswer)
        Me.Panel1.Controls.Add(Me.lblSec)
        Me.Panel1.Controls.Add(Me.cmbSecurityQuestion)
        Me.Panel1.Controls.Add(Me.lblUser)
        Me.Panel1.Controls.Add(Me.lblPass)
        Me.Panel1.Controls.Add(Me.btnRegister)
        Me.Panel1.Controls.Add(Me.txtRegUsername)
        Me.Panel1.Controls.Add(Me.txtRegPassword)
        Me.Panel1.Controls.Add(Me.lblRegister)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(28, 28)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 298)
        Me.Panel1.TabIndex = 5
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(14, 17)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(56, 19)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(355, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Car"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(298, 156)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Plate Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(292, 88)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Phone Number"
        '
        'txtPlate
        '
        Me.txtPlate.Location = New System.Drawing.Point(385, 149)
        Me.txtPlate.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPlate.Name = "txtPlate"
        Me.txtPlate.Size = New System.Drawing.Size(92, 20)
        Me.txtPlate.TabIndex = 12
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(385, 84)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(106, 20)
        Me.txtPhone.TabIndex = 11
        '
        'cmbCarType
        '
        Me.cmbCarType.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCarType.FormattingEnabled = True
        Me.cmbCarType.Items.AddRange(New Object() {"IRIZ", "PREVE/SUPRIMA", "PERSONA", "SAGA", "S70", "X50", "X70", "X90", "ALZA", "ARUZ", "ATIVA", "AXIA", "BEZZA", "MYVI"})
        Me.cmbCarType.Location = New System.Drawing.Point(385, 122)
        Me.cmbCarType.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCarType.Name = "cmbCarType"
        Me.cmbCarType.Size = New System.Drawing.Size(92, 20)
        Me.cmbCarType.TabIndex = 10
        '
        'rbStaff
        '
        Me.rbStaff.AutoSize = True
        Me.rbStaff.Location = New System.Drawing.Point(365, 254)
        Me.rbStaff.Margin = New System.Windows.Forms.Padding(2)
        Me.rbStaff.Name = "rbStaff"
        Me.rbStaff.Size = New System.Drawing.Size(47, 17)
        Me.rbStaff.TabIndex = 9
        Me.rbStaff.TabStop = True
        Me.rbStaff.Text = "Staff"
        Me.rbStaff.UseVisualStyleBackColor = True
        '
        'rbCustomer
        '
        Me.rbCustomer.AutoSize = True
        Me.rbCustomer.BackColor = System.Drawing.Color.White
        Me.rbCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbCustomer.Location = New System.Drawing.Point(430, 254)
        Me.rbCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.rbCustomer.Name = "rbCustomer"
        Me.rbCustomer.Size = New System.Drawing.Size(68, 17)
        Me.rbCustomer.TabIndex = 8
        Me.rbCustomer.TabStop = True
        Me.rbCustomer.Text = "Customer"
        Me.rbCustomer.UseVisualStyleBackColor = False
        '
        'txtSecurityAnswer
        '
        Me.txtSecurityAnswer.Location = New System.Drawing.Point(385, 213)
        Me.txtSecurityAnswer.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSecurityAnswer.Name = "txtSecurityAnswer"
        Me.txtSecurityAnswer.Size = New System.Drawing.Size(76, 20)
        Me.txtSecurityAnswer.TabIndex = 7
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec.Location = New System.Drawing.Point(281, 192)
        Me.lblSec.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(98, 13)
        Me.lblSec.TabIndex = 6
        Me.lblSec.Text = "Security Question"
        '
        'cmbSecurityQuestion
        '
        Me.cmbSecurityQuestion.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSecurityQuestion.FormattingEnabled = True
        Me.cmbSecurityQuestion.Items.AddRange(New Object() {"What is your first pet's name ", "What is your first car", "What is your mother's name ", "What is your grandmother's name", "Who is your bestfriend"})
        Me.cmbSecurityQuestion.Location = New System.Drawing.Point(385, 189)
        Me.cmbSecurityQuestion.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbSecurityQuestion.Name = "cmbSecurityQuestion"
        Me.cmbSecurityQuestion.Size = New System.Drawing.Size(105, 20)
        Me.cmbSecurityQuestion.TabIndex = 5
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(284, 245)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(76, 33)
        Me.btnRegister.TabIndex = 2
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FinalVisual.My.Resources.Resources._1_Car_Service_Workshop_Review
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(276, 295)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'registerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "registerForm"
        Me.Text = "registerForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents rbStaff As RadioButton
    Friend WithEvents btnBack As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPlate As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents cmbCarType As ComboBox
    Friend WithEvents rbCustomer As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
