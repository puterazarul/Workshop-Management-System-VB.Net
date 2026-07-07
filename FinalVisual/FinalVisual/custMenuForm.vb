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

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        ' Create the booking form
        Dim bookForm As New book1()

        ' Pass the logged-in username to load their data
        book1.LoadCustomerData(SessionData.CurrentUsername)

        ' Show booking form and hide menu
        book1.Show()
        Me.Hide()
    End Sub

    Private Sub btnStatus_Click(sender As Object, e As EventArgs) Handles btnStatus.Click
        CarStatusForm.Show()
        Me.Hide()
    End Sub
End Class