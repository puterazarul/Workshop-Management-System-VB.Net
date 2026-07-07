Imports System.Data.OleDb
Public Class CarStatusForm
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If txtSearchPlate.Text.Trim() = "" Then
            MessageBox.Show("Please enter your Plate Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\UserDB.accdb;"
        Using conn As New OleDbConnection(connString)
            Dim sql As String = "SELECT Name, Phone, PlateNo, CarType, BookingDate, Session, Service, Price 
                             FROM tblBooking WHERE PlateNo = ?"
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("?", txtSearchPlate.Text.Trim())
                Try
                    conn.Open()
                    Using rdr As OleDbDataReader = cmd.ExecuteReader()
                        If rdr.Read() Then
                            lblName.Text = rdr("Name").ToString()

                            lblPlate.Text = rdr("PlateNo").ToString()
                            lblCar.Text = rdr("CarType").ToString()
                            lblDate.Text = rdr("BookingDate").ToString()

                            lblService.Text = rdr("Service").ToString()
                            lblPrice.Text = rdr("Price").ToString()
                        Else
                            MessageBox.Show("No active booking found for this plate number.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
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
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MessageBox.Show("Error loading bookings: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub


    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=Workshop.accdb;")
    Sub DisplayData()

        Dim da As New OleDbDataAdapter("SELECT * FROM Inventory", con)
        Dim dt As New DataTable

        da.Fill(dt)

        DataGridView1.DataSource = dt


    End Sub


End Class