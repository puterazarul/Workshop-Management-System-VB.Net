Imports System.Data.OleDb
Public Class book1
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\UserDB.accdb;"
    Public Sub LoadCustomerData(username As String)
        Dim sql As String = "SELECT [Username], [Car], [PhoneNumber], [PlateNumber] FROM tblCustomer WHERE [Username] = ?"

        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("?", username)

                Try
                    conn.Open()
                    Using rdr As OleDbDataReader = cmd.ExecuteReader()
                        If rdr.Read() Then
                            txtName.Text = rdr("Username").ToString()
                            txtPhone.Text = rdr("PhoneNumber").ToString()
                            cmbCarType.Text = rdr("Car").ToString()
                            txtPlate.Text = rdr("PlateNumber").ToString()
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading customer profile: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
    Private Sub SetupFormInterface()
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        Label1.Location = New Point(20, 150)
    End Sub
    Private Sub ProcessServiceNavigation()
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse
           String.IsNullOrWhiteSpace(txtPhone.Text) OrElse
           String.IsNullOrWhiteSpace(cmbCarType.Text) OrElse
           String.IsNullOrWhiteSpace(txtPlate.Text) Then

            MessageBox.Show("Please fill in all details before booking.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim book2Form As New book2()

        book2.CustomerName = txtName.Text.Trim()
        book2.CustomerPhone = txtPhone.Text.Trim()
        book2.CustomerPlate = txtPlate.Text.Trim()
        book2.CustomerCarType = cmbCarType.Text.Trim()
        book2.SelectedCar = cmbCarType.Text

        book2.Show()
        Me.Hide()
    End Sub
    Private Function IsUserLoggedIn() As Boolean
        Return Not String.IsNullOrEmpty(SessionData.CurrentUsername)
    End Function

    Private Sub book1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupFormInterface()
    End Sub
    Private Sub btnService_Click(sender As Object, e As EventArgs) Handles btnService.Click
        ProcessServiceNavigation()
    End Sub
    Private Sub mnuUserMenu_Click(sender As Object, e As EventArgs) Handles mnuUserMenu.Click

        If IsUserLoggedIn() Then
            custMenuForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("You must log in first before accessing the user menu.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub mnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        Form1.Show()
        Me.Hide()
    End Sub
    Private Sub lnklblAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblAccount.LinkClicked
        loginForm.Show()
        Me.Hide()
    End Sub
    Private Sub book1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class