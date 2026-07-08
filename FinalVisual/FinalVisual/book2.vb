Imports System.Data.OleDb

Public Class book2

    ' These variables hold the customer data coming from book1
    Public CustomerName As String = ""
    Public CustomerPhone As String = ""
    Public CustomerPlate As String = ""
    Public CustomerCarType As String = ""

    ' 2. THIS IS THE MISSING LINK: It copies the data into your labels when book2 opens
    Private Sub book2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = Me.CustomerName
        lblPhone.Text = Me.CustomerPhone
        lblPlate.Text = Me.CustomerPlate
        lblCarType.Text = Me.CustomerCarType
    End Sub

    Public Property SelectedCar As String
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\UserDB.accdb;"
    Private Sub CalculatePrice()

        Dim total As Integer = 0

        Select Case SelectedCar
            Case "IRIZ", "MYVI", "AXIA"
                ' hb service prices
                If chkOil.Checked Then total += 150
                If chkAlign.Checked Then total += 40
                If chkCarwash.Checked Then total += 15
                If chkBrake.Checked Then total += 200
                If chkCoolant.Checked Then total += 100
                If chkGas.Checked Then total += 10
                If chkOBD.Checked Then total += 50
                If chkTint.Checked Then total += 100

            Case "X70", "X90", "ARUZ", "ALZA", "X50", "X50"
                ' suv/mpv service prices
                If chkOil.Checked Then total += 200
                If chkAlign.Checked Then total += 40
                If chkCarwash.Checked Then total += 25
                If chkBrake.Checked Then total += 400
                If chkCoolant.Checked Then total += 100
                If chkGas.Checked Then total += 10
                If chkOBD.Checked Then total += 50
                If chkTint.Checked Then total += 180

            Case Else
                ' Sedan service prices
                If chkOil.Checked Then total += 200
                If chkAlign.Checked Then total += 40
                If chkCarwash.Checked Then total += 20
                If chkBrake.Checked Then total += 400
                If chkCoolant.Checked Then total += 100
                If chkGas.Checked Then total += 10
                If chkOBD.Checked Then total += 50
                If chkTint.Checked Then total += 150

        End Select

        txtTotalPrice.Text = "RM " & total.ToString("N2")

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

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        CalculatePrice()
    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        SaveBooking()
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

End Class