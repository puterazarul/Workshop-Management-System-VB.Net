Imports System.Data.OleDb

Public Class loginForm
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\UserDB.accdb;"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        SessionData.CurrentUsername = txtUsername.Text.Trim()

        ' If you know whether they are Customer or Staff:
        SessionData.CurrentRole = "Customer"

        Dim tableName As String = ""

        If rbCustomer.Checked Then
            tableName = "tblCustomer"
        ElseIf rbStaff.Checked Then
            tableName = "tblStaff"
        Else
            MessageBox.Show("Please select Customer or Staff.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 1. Check if fields are empty or just spaces before checking the database
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter both Username and Password.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 2. Secure SQL query requiring both Username AND Password to match perfectly
        Dim query As String = "SELECT COUNT(*) FROM [" & tableName & "] WHERE [Username] = ? AND [Password] = ?"

        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand(query, conn)

                ' 3. Attach parameters safely
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim())
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim())

                Try
                    conn.Open()

                    ' 4. Execute query and count matching records
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    ' 5. EXPLICIT CONTROL FLOW BLOCK
                    ' The transition code is nested ONLY inside the true success condition.
                    If count > 0 Then
                        MessageBox.Show("Welcome! Login Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        If tableName = "tblCustomer" Then
                            Dim custForm As New custMenuForm()
                            custForm.Show()
                        ElseIf tableName = "tblStaff" Then
                            Dim staffForm As New menuForm()
                            staffForm.Show()
                        End If
                    Else
                        ' Runs if no matching user/password combination was found
                        MessageBox.Show("Invalid Username or Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        ' Reset fields to allow another attempt
                        txtPassword.Clear()
                        txtPassword.Focus()
                    End If

                Catch ex As Exception
                    ' Runs only if the database crashes (e.g. missing tables/fields)
                    MessageBox.Show("Database Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                txtUsername.Clear()
                txtPassword.Clear()
            End Using
        End Using
    End Sub

    Private Sub lnkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegister.LinkClicked
        registerForm.Show()
        Me.Hide()
    End Sub

    Private Sub lnkForgot_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkForgot.LinkClicked
        forgetPassword.Show()
        Me.Hide()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkForgot.LinkClicked
        forgetPassword.Show()
        Me.Close()
    End Sub

    Private Sub lnkNewAcc_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegister.LinkClicked
        registerForm.Show()
        Me.Close()
    End Sub

    Private Sub mnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        Form1.Show()
        Me.Close()
    End Sub




End Class