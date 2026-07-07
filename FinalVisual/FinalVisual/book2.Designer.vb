<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class book2
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCarType = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblPlate = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbSession = New System.Windows.Forms.ComboBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkTint = New System.Windows.Forms.CheckBox()
        Me.chkOBD = New System.Windows.Forms.CheckBox()
        Me.chkGas = New System.Windows.Forms.CheckBox()
        Me.chkCoolant = New System.Windows.Forms.CheckBox()
        Me.chkBrake = New System.Windows.Forms.CheckBox()
        Me.chkCarwash = New System.Windows.Forms.CheckBox()
        Me.chkAlign = New System.Windows.Forms.CheckBox()
        Me.chkOil = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.lblCarType)
        Me.GroupBox1.Controls.Add(Me.lblPhone)
        Me.GroupBox1.Controls.Add(Me.lblPlate)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.btnCalculate)
        Me.GroupBox1.Controls.Add(Me.btnBack)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnConfirm)
        Me.GroupBox1.Controls.Add(Me.txtTotalPrice)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbSession)
        Me.GroupBox1.Controls.Add(Me.dtpDate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkTint)
        Me.GroupBox1.Controls.Add(Me.chkOBD)
        Me.GroupBox1.Controls.Add(Me.chkGas)
        Me.GroupBox1.Controls.Add(Me.chkCoolant)
        Me.GroupBox1.Controls.Add(Me.chkBrake)
        Me.GroupBox1.Controls.Add(Me.chkCarwash)
        Me.GroupBox1.Controls.Add(Me.chkAlign)
        Me.GroupBox1.Controls.Add(Me.chkOil)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(265, 48)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(489, 430)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Service"
        '
        'lblCarType
        '
        Me.lblCarType.AutoSize = True
        Me.lblCarType.Location = New System.Drawing.Point(385, 327)
        Me.lblCarType.Name = "lblCarType"
        Me.lblCarType.Size = New System.Drawing.Size(0, 17)
        Me.lblCarType.TabIndex = 22
        Me.lblCarType.Visible = False
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(382, 306)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(0, 17)
        Me.lblPhone.TabIndex = 21
        Me.lblPhone.Visible = False
        '
        'lblPlate
        '
        Me.lblPlate.AutoSize = True
        Me.lblPlate.Location = New System.Drawing.Point(372, 289)
        Me.lblPlate.Name = "lblPlate"
        Me.lblPlate.Size = New System.Drawing.Size(0, 17)
        Me.lblPlate.TabIndex = 20
        Me.lblPlate.Visible = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(369, 267)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 17)
        Me.lblName.TabIndex = 19
        Me.lblName.Visible = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Orange
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Black
        Me.btnCalculate.Location = New System.Drawing.Point(124, 374)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(120, 49)
        Me.btnCalculate.TabIndex = 18
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Gray
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(243, 374)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(120, 49)
        Me.btnBack.TabIndex = 17
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(361, 373)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 49)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(5, 374)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(120, 49)
        Me.btnConfirm.TabIndex = 15
        Me.btnConfirm.Text = "Confirm Booking"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPrice.Location = New System.Drawing.Point(243, 313)
        Me.txtTotalPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(132, 32)
        Me.txtTotalPrice.TabIndex = 14
        Me.txtTotalPrice.Text = "RM 0.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(85, 321)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Total Price   : "
        '
        'cmbSession
        '
        Me.cmbSession.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSession.FormattingEnabled = True
        Me.cmbSession.Items.AddRange(New Object() {"PAGI", "PETANG", "NIGHT"})
        Me.cmbSession.Location = New System.Drawing.Point(243, 122)
        Me.cmbSession.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSession.Name = "cmbSession"
        Me.cmbSession.Size = New System.Drawing.Size(133, 33)
        Me.cmbSession.TabIndex = 12
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(243, 80)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(131, 32)
        Me.dtpDate.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 122)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Select Session :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(84, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(314, 37)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "CAR SERVICE BOOKING"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 86)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Select Date      :"
        '
        'chkTint
        '
        Me.chkTint.AutoSize = True
        Me.chkTint.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTint.Location = New System.Drawing.Point(269, 262)
        Me.chkTint.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTint.Name = "chkTint"
        Me.chkTint.Size = New System.Drawing.Size(69, 29)
        Me.chkTint.TabIndex = 7
        Me.chkTint.Text = "Tint"
        Me.chkTint.UseVisualStyleBackColor = True
        '
        'chkOBD
        '
        Me.chkOBD.AutoSize = True
        Me.chkOBD.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOBD.Location = New System.Drawing.Point(269, 234)
        Me.chkOBD.Margin = New System.Windows.Forms.Padding(4)
        Me.chkOBD.Name = "chkOBD"
        Me.chkOBD.Size = New System.Drawing.Size(151, 29)
        Me.chkOBD.TabIndex = 6
        Me.chkOBD.Text = "OBD Scanner"
        Me.chkOBD.UseVisualStyleBackColor = True
        '
        'chkGas
        '
        Me.chkGas.AutoSize = True
        Me.chkGas.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGas.Location = New System.Drawing.Point(269, 206)
        Me.chkGas.Margin = New System.Windows.Forms.Padding(4)
        Me.chkGas.Name = "chkGas"
        Me.chkGas.Size = New System.Drawing.Size(115, 29)
        Me.chkGas.TabIndex = 5
        Me.chkGas.Text = "Gas Refill"
        Me.chkGas.UseVisualStyleBackColor = True
        '
        'chkCoolant
        '
        Me.chkCoolant.AutoSize = True
        Me.chkCoolant.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCoolant.Location = New System.Drawing.Point(269, 177)
        Me.chkCoolant.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCoolant.Name = "chkCoolant"
        Me.chkCoolant.Size = New System.Drawing.Size(155, 29)
        Me.chkCoolant.TabIndex = 4
        Me.chkCoolant.Text = "Coolant Flush"
        Me.chkCoolant.UseVisualStyleBackColor = True
        '
        'chkBrake
        '
        Me.chkBrake.AutoSize = True
        Me.chkBrake.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBrake.Location = New System.Drawing.Point(64, 262)
        Me.chkBrake.Margin = New System.Windows.Forms.Padding(4)
        Me.chkBrake.Name = "chkBrake"
        Me.chkBrake.Size = New System.Drawing.Size(132, 29)
        Me.chkBrake.TabIndex = 3
        Me.chkBrake.Text = "Brake Pads"
        Me.chkBrake.UseVisualStyleBackColor = True
        '
        'chkCarwash
        '
        Me.chkCarwash.AutoSize = True
        Me.chkCarwash.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCarwash.Location = New System.Drawing.Point(64, 234)
        Me.chkCarwash.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCarwash.Name = "chkCarwash"
        Me.chkCarwash.Size = New System.Drawing.Size(109, 29)
        Me.chkCarwash.TabIndex = 2
        Me.chkCarwash.Text = "Carwash"
        Me.chkCarwash.UseVisualStyleBackColor = True
        '
        'chkAlign
        '
        Me.chkAlign.AutoSize = True
        Me.chkAlign.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlign.Location = New System.Drawing.Point(64, 206)
        Me.chkAlign.Margin = New System.Windows.Forms.Padding(4)
        Me.chkAlign.Name = "chkAlign"
        Me.chkAlign.Size = New System.Drawing.Size(127, 29)
        Me.chkAlign.TabIndex = 1
        Me.chkAlign.Text = "Alignment"
        Me.chkAlign.UseVisualStyleBackColor = True
        '
        'chkOil
        '
        Me.chkOil.AutoSize = True
        Me.chkOil.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOil.Location = New System.Drawing.Point(64, 177)
        Me.chkOil.Margin = New System.Windows.Forms.Padding(4)
        Me.chkOil.Name = "chkOil"
        Me.chkOil.Size = New System.Drawing.Size(130, 29)
        Me.chkOil.TabIndex = 0
        Me.chkOil.Text = "Oil Change"
        Me.chkOil.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FinalVisual.My.Resources.Resources.WhatsApp_Image_2026_06_29_at_2_16_09_AM
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1071, 549)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.FinalVisual.My.Resources.Resources.WhatsApp_Image_2026_06_29_at_2_16_09_AM
        Me.PictureBox2.Location = New System.Drawing.Point(-4, 162)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1071, 549)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'book2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "book2"
        Me.Text = "book2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkTint As CheckBox
    Friend WithEvents chkOBD As CheckBox
    Friend WithEvents chkGas As CheckBox
    Friend WithEvents chkCoolant As CheckBox
    Friend WithEvents chkBrake As CheckBox
    Friend WithEvents chkCarwash As CheckBox
    Friend WithEvents chkAlign As CheckBox
    Friend WithEvents chkOil As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbSession As ComboBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblCarType As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblPlate As Label
    Friend WithEvents lblName As Label
End Class
