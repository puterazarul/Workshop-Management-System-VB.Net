Imports System.Data.OleDb
Public Class forgetPassword
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\UserDB.accdb;"
    Private Sub btnFindUser_Click(sender As Object, e As EventArgs) Handles btnFindUser.Click
        Dim query As String = "SELECT [SecurityQuestion] FROM tblUsers WHERE [Username] = @user"

        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@user", txtForgotUsername.Text.Trim())
                Try
                    conn.Open()
                    Dim question = cmd.ExecuteScalar()

                    If question IsNot Nothing Then
                        lblQuestion.Text = question.ToString()
                    Else
                        MessageBox.Show("Username not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        Dim verifyQuery As String = "SELECT [SecurityAnswer] FROM tblUsers WHERE [Username] = @user"

        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand(verifyQuery, conn)
                cmd.Parameters.AddWithValue("@user", txtForgotUsername.Text.Trim())
                Try
                    conn.Open()
                    Dim dbAnswer As String = cmd.ExecuteScalar()?.ToString()

                    If dbAnswer IsNot Nothing AndAlso dbAnswer.Equals(txtAnswer.Text.Trim(), StringComparison.OrdinalIgnoreCase) Then
                        ' Answer matches, update password
                        Dim updateQuery As String = "UPDATE tblUsers SET [Password] = @newPass WHERE [Username] = @user"
                        Using updateCmd As New OleDbCommand(updateQuery, conn)
                            updateCmd.Parameters.AddWithValue("@newPass", txtNewPassword.Text.Trim())
                            updateCmd.Parameters.AddWithValue("@user", txtForgotUsername.Text.Trim())
                            updateCmd.ExecuteNonQuery()

                            MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            loginForm.Show()
                            Me.Close()
                        End Using
                    Else
                        MessageBox.Show("Incorrect answer to the security question.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Class