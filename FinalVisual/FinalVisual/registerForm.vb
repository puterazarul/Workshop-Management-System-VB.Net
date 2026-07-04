Imports System.Data.OleDb
Public Class registerForm
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\UserDB.accdb;"
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtRegUsername.Text.Trim() = "" Or txtRegPassword.Text.Trim() = "" Or cmbSecurityQuestion.SelectedIndex = -1 Or txtSecurityAnswer.Text.Trim() = "" Then
            MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Using conn As New OleDbConnection(connString)
            ' Check if username exists
            Dim checkQuery As String = "SELECT COUNT(*) FROM tblUsers WHERE [Username] = @user"
            Using checkCmd As New OleDbCommand(checkQuery, conn)
                checkCmd.Parameters.AddWithValue("@user", txtRegUsername.Text.Trim())
                Try
                    conn.Open()
                    If Convert.ToInt32(checkCmd.ExecuteScalar()) > 0 Then
                        MessageBox.Show("Username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                    Exit Sub
                End Try
            End Using

            ' Insert new user
            Dim insertQuery As String = "INSERT INTO tblUsers ([Username], [Password], [SecurityQuestion], [SecurityAnswer]) VALUES (@user, @pass, @q, @a)"
            Using insertCmd As New OleDbCommand(insertQuery, conn)
                insertCmd.Parameters.AddWithValue("@user", txtRegUsername.Text.Trim())
                insertCmd.Parameters.AddWithValue("@pass", txtRegPassword.Text.Trim())
                insertCmd.Parameters.AddWithValue("@q", cmbSecurityQuestion.SelectedItem.ToString())
                insertCmd.Parameters.AddWithValue("@a", txtSecurityAnswer.Text.Trim().ToLower())

                Try
                    insertCmd.ExecuteNonQuery()
                    MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loginForm.Show()
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show("Registration failed: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub


End Class