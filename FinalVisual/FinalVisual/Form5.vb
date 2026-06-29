Imports System.Data.OleDb
Public Class Form5
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=Workshop.accdb;")
    Sub DisplayData()

        Dim da As New OleDbDataAdapter("SELECT * FROM Inventory", con)
        Dim dt As New DataTable

        da.Fill(dt)

        DataGridView1.DataSource = dt

    End Sub

    Sub ClearData()

        txtPartID.Clear()
        txtPartName.Clear()
        txtQuantity.Clear()
        txtPrice.Clear()
        txtStatus.Clear()

        txtPartID.Focus()

    End Sub

    Private Sub FormInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DisplayData()

    End Sub

    Private Sub btnUpdateStock_Click(sender As Object, e As EventArgs) Handles btnUpdateStock.Click

        Try

            con.Open()

            Dim sql As String = "UPDATE Inventory SET Quantity = Quantity + ? WHERE PartID = ?"

            Dim cmd As New OleDbCommand(sql, con)

            cmd.Parameters.AddWithValue("@qty", CInt(txtQuantity.Text))
            cmd.Parameters.AddWithValue("@id", txtPartID.Text)

            Dim rows As Integer = cmd.ExecuteNonQuery()

            con.Close()

            If rows > 0 Then
                MessageBox.Show("Stock Updated Successfully")
                DisplayData()
                ClearData()
            Else
                MessageBox.Show("Part ID not found.")
            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

            If con.State = ConnectionState.Open Then
                con.Close()
            End If

        End Try

    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ClearData()

    End Sub
End Class