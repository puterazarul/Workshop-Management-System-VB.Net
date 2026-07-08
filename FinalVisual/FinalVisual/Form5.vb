Imports System.Data.OleDb
Public Class Form5
    Public Sub LoadBookingGridData()
        ' 1. Use your correct connection string path
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\UserDB.accdb;"

        ' 2. Completely reset the grid connection to prevent old data caching
        dgvBooking.DataSource = Nothing

        ' 3. Select all relevant registration columns
        Dim sql As String = "SELECT [PartID], [PartName], [Quantity], [Price] ,[Status] FROM tblInventory ORDER BY [PartID] ASC"

        Try
            Using conn As New OleDbConnection(connString)
                ' Using an OleDbDataAdapter fills data tables cleanly without manual loops
                Dim da As New OleDbDataAdapter(sql, conn)
                Dim dt As New DataTable()

                ' Fetch data from Access and bind it to the visual DataGridView
                da.Fill(dt)
                dgvBooking.DataSource = dt
            End Using

        Catch ex As Exception
            MessageBox.Show("Failed to pull updated entries: " & ex.Message, "Sync Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdateStock_Click(sender As Object, e As EventArgs) Handles btnUpdateStock.Click
        ' 1. Define your connection string directly here
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=UserDB.accdb;"

        ' 2. Use a Parameterized SQL Update query
        Dim sql As String = "UPDATE tblInventory SET [Quantity] = [Quantity] + ?, [Status] = ? WHERE [PartID] = ?"
        Try
            Dim autoStatus As String = "Out of Stock"
            If CInt(txtQuantity.Text) >= 1 Then
                autoStatus = "Available"
            End If
            ' 4. Execute the parameterized query
            Using localCon As New OleDbConnection(connString)
                Using cmd As New OleDbCommand(sql, localCon)

                    ' Clear old values and map parameters in EXACT left-to-right order to match the 3 question marks:
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("?", CInt(txtQuantity.Text)) ' 1st ? -> Adds to [Quantity]
                    cmd.Parameters.AddWithValue("?", autoStatus)            ' 2nd ? -> Changes [Status]
                    cmd.Parameters.AddWithValue("?", txtPartID.Text)         ' 3rd ? -> Matches WHERE [PartID]

                    localCon.Open()
                    Dim rows As Integer = cmd.ExecuteNonQuery()
                    localCon.Close()

                    ' 5. Process the result and refresh the data display grid
                    If rows > 0 Then
                        MessageBox.Show("Stock and Status Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadBookingGridData() ' Dynamically refreshes your screen grid with the new values!
                        ClearData()           ' Wipes out your text inputs
                    Else
                        MessageBox.Show("Part ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub ClearData()

        txtPartID.Clear()
        txtPartName.Clear()
        txtQuantity.Clear()
        txtPrice.Clear()


        txtPartID.Focus()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ClearData()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        menuForm.Show()
        Me.Close()
    End Sub

    Private Sub mnuHome_Click(sender As Object, e As EventArgs) Handles mnuHome.Click
        custMenuForm.Show()
        Me.Hide()
    End Sub

    Private Sub GridForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBookingGridData()
    End Sub


End Class