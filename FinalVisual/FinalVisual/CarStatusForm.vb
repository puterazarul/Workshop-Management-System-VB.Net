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

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub lblPlate_Click(sender As Object, e As EventArgs) Handles lblPlate.Click

    End Sub

    Private Sub mnuHome_Click(sender As Object, e As EventArgs) Handles mnuHome.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub mnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        custMenuForm.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class