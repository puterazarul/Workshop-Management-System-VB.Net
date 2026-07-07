Imports System.Data.OleDb

Public Class Form4


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchBooking()
    End Sub

    Private Sub SearchBooking()

        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\UserDB.accdb;"
        Dim conn As New OleDbConnection(connString)

        Dim cmd As New OleDbCommand("SELECT * FROM tblBooking WHERE PlateNo=@plate", conn)
        cmd.Parameters.AddWithValue("@plate", txtSearchPlate.Text)

        conn.Open()

        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        If reader.Read() Then

            DisplayBooking(reader)

        Else

            ClearBooking()
            MsgBox("No record found!")

        End If

        conn.Close()

    End Sub


    Private Sub DisplayBooking(reader As OleDbDataReader)

        lblName.Text = reader("Name").ToString()
        lblPhone.Text = reader("Phone").ToString()
        lblPlate.Text = reader("PlateNo").ToString()
        lblCarType.Text = reader("CarType").ToString()
        lblDate.Text = reader("BookingDate").ToString()
        lblSession.Text = reader("Session").ToString()
        lblService.Text = reader("Service").ToString()
        lblPrice.Text = "RM " & reader("Price").ToString()

    End Sub

    Private Sub ClearBooking()

        lblName.Text = "-"
        lblPhone.Text = "-"
        lblPlate.Text = "-"
        lblCarType.Text = "-"
        lblDate.Text = "-"
        lblSession.Text = "-"
        lblService.Text = "-"
        lblPrice.Text = "-"

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles Button3.Click
        menuForm.Show()
        Me.Close()
    End Sub

    Private Sub txtSearchPlate_TextChanged(sender As Object, e As EventArgs) Handles txtSearchPlate.TextChanged

    End Sub

End Class