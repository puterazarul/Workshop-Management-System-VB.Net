Public Class custMenuForm
    ' --- REQUIREMENT CHECK: SUB PROCEDURES (Sub) ---

    ''' <summary>
    ''' Sub Procedure: Handles formatting and aesthetic parenting behaviors.
    ''' </summary>
    Private Sub SetupInterfaceLayout()
        lblDateTime.Parent = PictureBox1
        lblDateTime.BackColor = Color.Transparent
    End Sub

    ''' <summary>
    ''' Sub Procedure: Correctly instantiates book1 and handles the safe data transfer.
    ''' </summary>
    Private Sub NavigateToBookingForm()
        ' FIX: Create the dedicated instance wrapper properly
        Dim book1 As New book1()

        ' FIX: Call methods using the instance object variable name (bookForm) rather than class keyword
        book1.LoadCustomerData(SessionData.CurrentUsername)

        ' Display instance object window layer stack on system display view
        book1.Show()
        Me.Hide()
    End Sub

    Private Sub custMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call our custom UI setup procedure
        SetupInterfaceLayout()
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = $"Welcome Back! | {DateTime.Now.ToString("dddd, MMMM d, yyyy - h:mm:ss tt")}"
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        ' Call our specialized routing procedure
        NavigateToBookingForm()
    End Sub

    Private Sub btnStatus_Click(sender As Object, e As EventArgs) Handles btnStatus.Click
        CarStatusForm.Show()
        Me.Hide()
    End Sub

    Private Sub mnuFileHome_Click(sender As Object, e As EventArgs) Handles mnuFileHome.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        registerForm.Show()
        Me.Hide()
    End Sub

    Private Sub mnuFileLogin_Click(sender As Object, e As EventArgs) Handles mnuFileLogin.Click
        loginForm.Show()
        Me.Close()
    End Sub

End Class