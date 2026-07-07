Public Class menuForm
    Private Sub btnJob_Click(sender As Object, e As EventArgs) Handles btnJob.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Form5.Show()
    End Sub

    Private Sub mnuHome_Click(sender As Object, e As EventArgs) Handles mnuHome.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub mnuNewAcc_Click(sender As Object, e As EventArgs) Handles mnuNewAcc.Click
        registerForm.Show()
        Me.Close()
    End Sub

    Private Sub mnuLogin_Click(sender As Object, e As EventArgs) Handles mnuLogin.Click
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub menuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the PictureBox as the parent container of the label
        lblDateTime.Parent = PictureBox1

        ' Force the background to be transparent relative to the picture box
        lblDateTime.BackColor = Color.Transparent
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = $"Welcome Back! | {DateTime.Now.ToString("dddd, MMMM d, yyyy - h:mm:ss tt")}"
    End Sub

End Class