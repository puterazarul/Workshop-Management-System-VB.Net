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

    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        If txtSearchPlate.Text.Trim() = "" Then
            MessageBox.Show("Please enter the Plate Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\UserDB.accdb;"
        Using conn As New OleDbConnection(connString)
            Dim sql As String = "DELETE FROM tblBooking WHERE PlateNo = ?"
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("?", txtSearchPlate.Text.Trim())
                Try
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Job confirmed and booking removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No booking found for that plate number.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                    ClearBooking()

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub JobStatusForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllBookings()
    End Sub

    Private Sub LoadAllBookings()
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\UserDB.accdb;"
        Using conn As New OleDbConnection(connString)
            Dim sql As String = "SELECT ID, Name, Phone, PlateNo, CarType, BookingDate, Session, Service, Price FROM tblBooking"
            Using cmd As New OleDbCommand(sql, conn)
                Try
                    conn.Open()
                    Dim dt As New DataTable()
                    Using rdr As OleDbDataReader = cmd.ExecuteReader()
                        dt.Load(rdr)
                    End Using
                    dgvBooking.DataSource = dt
                Catch ex As Exception
                    MessageBox.Show("Error loading bookings: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub


    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=UserDB.accdb;")
    Sub DisplayData()

        Dim da As New OleDbDataAdapter("SELECT * FROM tblBooking", con)
        Dim dt As New DataTable

        da.Fill(dt)

        dgvBooking.DataSource = dt


    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadAllBookings()
    End Sub


End Class