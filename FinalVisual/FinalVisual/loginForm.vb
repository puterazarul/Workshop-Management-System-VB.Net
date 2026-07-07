Imports System.Data.OleDb

Public Class loginForm

    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\UserDB.accdb;"


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        LoginUser()
    End Sub


    Private Sub LoginUser()

        SessionData.CurrentUsername = txtUsername.Text.Trim()

        Dim tableName As String = ""

        If rbCustomer.Checked Then
            tableName = "tblCustomer"
            SessionData.CurrentRole = "Customer"

        ElseIf rbStaff.Checked Then
            tableName = "tblStaff"
            SessionData.CurrentRole = "Staff"

        Else
            MessageBox.Show("Please select Customer or Staff.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter both Username and Password.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim query As String = "SELECT COUNT(*) FROM [" & tableName & "] WHERE [Username]=? AND [Password]=?"

        Using conn As New OleDbConnection(connString)

            Using cmd As New OleDbCommand(query, conn)

                cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim())
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim())

                Try

                    conn.Open()

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count > 0 Then

                        MessageBox.Show("Welcome! Login Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        OpenMenu(tableName)

                    Else

                        MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        txtPassword.Clear()
                        txtPassword.Focus()

                    End If

                Catch ex As Exception

                    MessageBox.Show("Database Error: " & ex.Message)

                End Try

            End Using

        End Using

        ClearInput()

    End Sub

    Private Sub OpenMenu(tableName As String)

        If tableName = "tblCustomer" Then

            Dim custForm As New custMenuForm()
            custForm.Show()

        Else

            Dim staffForm As New menuForm()
            staffForm.Show()

        End If

        Me.Close()

    End Sub


    Private Sub ClearInput()

        txtUsername.Clear()
        txtPassword.Clear()

    End Sub


    Private Sub lnkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegister.LinkClicked

        registerForm.Show()
        Me.Close()

    End Sub


    Private Sub lnkForgot_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkForgot.LinkClicked

        forgetPassword.Show()
        Me.Close()

    End Sub


    Private Sub mnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click

        Form1.Show()
        Me.Close()

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

End Class