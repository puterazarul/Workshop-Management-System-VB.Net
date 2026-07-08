Imports System.Data.OleDb
Public Class book1
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\UserDB.accdb;"


    ' --- 2. THIS READS PROFILE DATA TO AUTOFILL FORM TEXTBOXES ---
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
                            ' Populate your textboxes from the customer profile record
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

    Private Sub book1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Paksa Label jadi "anak" kepada PictureBox secara rasmi
        Label1.Parent = PictureBox1

        ' 2. Paksa latar belakang jadi lutsinar tembus gambar
        Label1.BackColor = Color.Transparent

        ' 3. Set koordinat baru (sebab koordinat sekarang dikira dari bucu atas kiri PictureBox)
        ' Sila tukar nombor (20, 150) ini mengikut kesesuaian kedudukan yang anda mahu
        Label1.Location = New Point(20, 150)
    End Sub
    Private Sub book1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit() ' Paksa tutup semua termaksud Form1 yang menyorok tadi
    End Sub

    Private Sub mnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub btnService_Click(sender As Object, e As EventArgs) Handles btnService.Click
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse
       String.IsNullOrWhiteSpace(txtPhone.Text) OrElse
       String.IsNullOrWhiteSpace(cmbCarType.Text) OrElse
       String.IsNullOrWhiteSpace(txtPlate.Text) Then

            MessageBox.Show("Please fill in all details before booking.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim book2 As New book2()

        book2.CustomerName = txtName.Text.Trim()
        book2.CustomerPhone = txtPhone.Text.Trim()
        book2.CustomerPlate = txtPlate.Text.Trim()
        book2.CustomerCarType = cmbCarType.Text.Trim()

        book2.SelectedCar = cmbCarType.Text
        book2.Show()
        Me.Hide()
    End Sub

    Private Sub lnklblAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblAccount.LinkClicked
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class