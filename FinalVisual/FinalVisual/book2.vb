Imports System.Data.OleDb

Public Class book2

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        CalculatePrice()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        SaveBooking()
    End Sub

    '==========================
    ' SUBFUNCTION: Calculate Price
    '==========================
    Private Sub CalculatePrice()

        Dim total As Integer = 0

        If chkOil.Checked Then total += 80
        If chkAlign.Checked Then total += 30
        If chkCarwash.Checked Then total += 10
        If chkBrake.Checked Then total += 50
        If chkCoolant.Checked Then total += 60
        If chkGas.Checked Then total += 40
        If chkOBD.Checked Then total += 100
        If chkTint.Checked Then total += 150

        txtTotalPrice.Text = total.ToString()

    End Sub


    Private Sub SaveBooking()

        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\UserDB.accdb;")

        Dim service As String = ""

        If chkOil.Checked Then service &= "Oil Change, "
        If chkAlign.Checked Then service &= "Alignment, "
        If chkCarwash.Checked Then service &= "Carwash, "
        If chkBrake.Checked Then service &= "Brake Pads, "
        If chkCoolant.Checked Then service &= "Coolant Flush, "
        If chkGas.Checked Then service &= "Gas Refill, "
        If chkOBD.Checked Then service &= "OBD Scanner, "
        If chkTint.Checked Then service &= "Tint, "

        Dim cmd As New OleDbCommand("
INSERT INTO tblBooking
([Name],[Phone],[PlateNo],[CarType],[BookingDate],[Session],[Service],[Price])
VALUES
(@n,@p,@plate,@car,@date,@session,@service,@price)", conn)

        cmd.Parameters.AddWithValue("@n", lblName.Text)
        cmd.Parameters.AddWithValue("@p", lblPhone.Text)
        cmd.Parameters.AddWithValue("@plate", lblPlate.Text)
        cmd.Parameters.AddWithValue("@car", lblCarType.Text)
        cmd.Parameters.AddWithValue("@date", dtpDate.Text)
        cmd.Parameters.AddWithValue("@session", cmbSession.Text)
        cmd.Parameters.AddWithValue("@service", service)
        cmd.Parameters.AddWithValue("@price", txtTotalPrice.Text)

        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()

        MsgBox("Booking Saved Successfully!")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If String.IsNullOrEmpty(SessionData.CurrentUsername) Then
            MessageBox.Show("You must log in first before accessing the user menu.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            custMenuForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class