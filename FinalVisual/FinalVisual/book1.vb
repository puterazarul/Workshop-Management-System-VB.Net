Imports System.Data.OleDb
Public Class book1
    Public Sub LoadCustomerData(username As String)
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\UserDB.accdb;"
        Using conn As New OleDbConnection(connString)
            Dim sql As String = "SELECT Username, Car, PhoneNumber , PlateNumber FROM tblCustomer WHERE [Username] = ?"

            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("?", username)
                conn.Open()
                Using rdr As OleDbDataReader = cmd.ExecuteReader()
                    If rdr.Read() Then
                        ' Match your actual column names
                        txtName.Text = rdr("Username").ToString()   ' Customer name
                        txtPhone.Text = rdr("PhoneNumber").ToString()      ' Phone number
                        cmbCarType.Text = rdr("Car").ToString()              ' Car
                        txtPlate.Text = rdr("PlateNumber").ToString()     ' Plate number
                    End If
                End Using
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
        book2.lblName.Text = txtName.Text
        book2.lblPhone.Text = txtPhone.Text
        book2.lblPlate.Text = txtPlate.Text
        book2.lblCarType.Text = cmbCarType.Text

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