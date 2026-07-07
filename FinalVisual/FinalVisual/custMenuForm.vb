Public Class custMenuForm

    Private Sub custMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the PictureBox as the parent container of the label
        lblDateTime.Parent = PictureBox1

        ' Force the background to be transparent relative to the picture box
        lblDateTime.BackColor = Color.Transparent
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = $"Welcome Back! | {DateTime.Now.ToString("dddd, MMMM d, yyyy - h:mm:ss tt")}"
    End Sub




End Class