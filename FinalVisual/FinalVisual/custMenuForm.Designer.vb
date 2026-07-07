<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class custMenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(custMenuForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSwitch = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.btnStatus = New System.Windows.Forms.Button()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(-2, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(806, 45)
        Me.Panel1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHome})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(806, 36)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuHome
        '
        Me.mnuHome.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileHome, Me.mnuFileSwitch})
        Me.mnuHome.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuHome.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.mnuHome.Name = "mnuHome"
        Me.mnuHome.Size = New System.Drawing.Size(51, 32)
        Me.mnuHome.Text = "///"
        '
        'mnuFileHome
        '
        Me.mnuFileHome.Name = "mnuFileHome"
        Me.mnuFileHome.Size = New System.Drawing.Size(265, 32)
        Me.mnuFileHome.Text = "HOME"
        '
        'mnuFileSwitch
        '
        Me.mnuFileSwitch.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFileLogin})
        Me.mnuFileSwitch.Name = "mnuFileSwitch"
        Me.mnuFileSwitch.Size = New System.Drawing.Size(265, 32)
        Me.mnuFileSwitch.Text = "SWITCH ACCOUNT"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.Size = New System.Drawing.Size(237, 32)
        Me.mnuFileNew.Text = "NEW ACCOUNT"
        '
        'mnuFileLogin
        '
        Me.mnuFileLogin.Name = "mnuFileLogin"
        Me.mnuFileLogin.Size = New System.Drawing.Size(237, 32)
        Me.mnuFileLogin.Text = "LOGIN"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(806, 412)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnBook
        '
        Me.btnBook.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBook.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBook.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBook.Location = New System.Drawing.Point(258, 272)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(250, 54)
        Me.btnBook.TabIndex = 2
        Me.btnBook.Text = "BOOK A SERVICE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBook.UseVisualStyleBackColor = False
        '
        'btnStatus
        '
        Me.btnStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnStatus.Location = New System.Drawing.Point(258, 332)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Size = New System.Drawing.Size(250, 52)
        Me.btnStatus.TabIndex = 3
        Me.btnStatus.Text = "CAR STATUS"
        Me.btnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStatus.UseVisualStyleBackColor = False
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.BackColor = System.Drawing.Color.Transparent
        Me.lblDateTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDateTime.Location = New System.Drawing.Point(170, 60)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(422, 28)
        Me.lblDateTime.TabIndex = 4
        Me.lblDateTime.Text = "WELCOME BACK! | Loading date and time..."
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'custMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.btnStatus)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "custMenuForm"
        Me.Text = "custMenuForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuHome As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBook As Button
    Friend WithEvents btnStatus As Button
    Friend WithEvents lblDateTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents mnuFileHome As ToolStripMenuItem
    Friend WithEvents mnuFileSwitch As ToolStripMenuItem
    Friend WithEvents mnuFileNew As ToolStripMenuItem
    Friend WithEvents mnuFileLogin As ToolStripMenuItem
End Class
