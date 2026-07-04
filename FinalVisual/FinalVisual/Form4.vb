Imports System.Data.OleDb
Public Class Form4


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\UserDB.accdb;"
        Dim conn As New OleDbConnection(connString)
        Dim cmd As New OleDbCommand("SELECT * FROM Booking WHERE PlateNo=@plate", conn)
        cmd.Parameters.AddWithValue("@plate", txtSearchPlate.Text)

        conn.Open()

        Dim reader As OleDbDataReader = cmd.ExecuteReader

        If reader.Read() Then

            lblName.Text = reader("Name").ToString()
            lblPhone.Text = reader("Phone").ToString()
            lblPlate.Text = reader("PlateNo").ToString()
            lblCarType.Text = reader("CarType").ToString()
            lblDate.Text = reader("BookingDate").ToString()
            lblSession.Text = reader("Session").ToString()
            lblService.Text = reader("Service").ToString()
            lblPrice.Text = "RM " & reader("Price").ToString()

        Else

            MsgBox("No record found!")

            lblName.Text = "-"
            lblPhone.Text = "-"
            lblPlate.Text = "-"
            lblCarType.Text = "-"
            lblDate.Text = "-"
            lblSession.Text = "-"
            lblService.Text = "-"
            lblPrice.Text = "-"

        End If

        conn.Close()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles Button3.Click
        menuForm.Show()
        Me.Close()
    End Sub
End Class