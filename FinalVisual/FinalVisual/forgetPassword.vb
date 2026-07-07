Imports System.Data.OleDb
Public Class forgetPassword
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\UserDB.accdb;"
    Private Sub btnFindUser_Click(sender As Object, e As EventArgs) Handles btnFindUser.Click
        Dim username As String = txtForgotUsername.Text.Trim()
        If String.IsNullOrEmpty(username) Then
            MessageBox.Show("Please enter a username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim question As Object = Nothing

        Using conn As New OleDbConnection(connString)
            Try
                conn.Open()

                ' First check tblCustomer
                Dim queryCustomer As String = "SELECT [SecurityQuestion] FROM tblCustomer WHERE [Username] = ?"
                Using cmdCust As New OleDbCommand(queryCustomer, conn)
                    cmdCust.Parameters.AddWithValue("?", username)
                    question = cmdCust.ExecuteScalar()
                End Using

                ' If not found in Customer, check Staff
                If question Is Nothing OrElse IsDBNull(question) Then
                    Dim queryStaff As String = "SELECT [SecurityQuestion] FROM tblStaff WHERE [Username] = ?"
                    Using cmdStaff As New OleDbCommand(queryStaff, conn)
                        cmdStaff.Parameters.AddWithValue("?", username)
                        question = cmdStaff.ExecuteScalar()
                    End Using
                End If

                ' Show result
                If question IsNot Nothing AndAlso Not IsDBNull(question) Then
                    lblQuestion.Text = question.ToString()
                Else
                    MessageBox.Show("Username not found in Customer or Staff tables.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        Dim username As String = txtForgotUsername.Text.Trim()
        Dim newPass As String = txtNewPassword.Text.Trim()
        Dim answer As String = txtAnswer.Text.Trim()

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(newPass) OrElse String.IsNullOrEmpty(answer) Then
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim dbAnswer As String = Nothing
        Dim dbPassword As String = Nothing
        Dim foundTable As String = Nothing

        Using conn As New OleDbConnection(connString)
            Try
                conn.Open()

                ' 1) Check Customer table
                Dim queryCustomer As String = "SELECT [SecurityAnswer], [Password] FROM tblCustomer WHERE [Username] = ?"
                Using cmdCust As New OleDbCommand(queryCustomer, conn)
                    cmdCust.Parameters.AddWithValue("?", username)
                    Using rdr As OleDbDataReader = cmdCust.ExecuteReader()
                        If rdr.Read() Then
                            dbAnswer = rdr("SecurityAnswer").ToString()
                            dbPassword = rdr("Password").ToString()
                            foundTable = "tblCustomer"
                        End If
                    End Using
                End Using

                ' 2) If not found in Customer, check Staff
                If foundTable Is Nothing Then
                    Dim queryStaff As String = "SELECT [SecurityAnswer], [Password] FROM tblStaff WHERE [Username] = ?"
                    Using cmdStaff As New OleDbCommand(queryStaff, conn)
                        cmdStaff.Parameters.AddWithValue("?", username)
                        Using rdr As OleDbDataReader = cmdStaff.ExecuteReader()
                            If rdr.Read() Then
                                dbAnswer = rdr("SecurityAnswer").ToString()
                                dbPassword = rdr("Password").ToString()
                                foundTable = "tblStaff"
                            End If
                        End Using
                    End Using
                End If

                ' 3) Verify answer and update password
                If foundTable IsNot Nothing AndAlso dbAnswer.Equals(answer, StringComparison.OrdinalIgnoreCase) Then
                    ' Check if new password is same as old
                    If dbPassword.Equals(newPass, StringComparison.OrdinalIgnoreCase) Then
                        MessageBox.Show("New password cannot be the same as the old password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    Dim updateSql As String = "UPDATE [" & foundTable & "] SET [Password] = ? WHERE [Username] = ?"
                    Using updateCmd As New OleDbCommand(updateSql, conn)
                        updateCmd.Parameters.AddWithValue("?", newPass)
                        updateCmd.Parameters.AddWithValue("?", username)
                        updateCmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loginForm.Show()
                    Me.Close()
                ElseIf foundTable IsNot Nothing Then
                    MessageBox.Show("Incorrect answer to the security question.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Username not found in Customer or Staff tables.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub



    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        loginForm.Show()
        Me.Close()
    End Sub
End Class