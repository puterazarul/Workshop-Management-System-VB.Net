Imports System.Data.OleDb
Public Class CarStatusForm
    Private Sub LoadCustomerBookings()
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\UserDB.accdb;"

        ' Filter by the [Name] column to match the currently logged-in user
        Dim sql As String = "SELECT [ID], [Name], [Phone], [PlateNo], [CarType], [BookingDate], [Session], [Service], [Price] " &
                        "FROM tblBooking WHERE [Name] = ? ORDER BY [ID] ASC"

        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand(sql, conn)

                ' Pass the current user's name into the positional parameter (?)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("?", SessionData.CurrentUsername)

                Try
                    conn.Open()
                    Dim dt As New DataTable()
                    Using rdr As OleDbDataReader = cmd.ExecuteReader()
                        dt.Load(rdr)
                    End Using

                    ' Bind the filtered data rows to the interface grid layout
                    dgvBookings.DataSource = dt
                    dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                Catch ex As Exception
                    MessageBox.Show("Error loading your personal bookings: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub CarStatusForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomerBookings()
    End Sub

    Private Sub mnuHome_Click(sender As Object, e As EventArgs) Handles mnuHome.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub mnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        custMenuForm.Show()
        Me.Hide()
    End Sub

End Class