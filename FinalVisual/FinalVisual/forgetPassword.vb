Imports System.Data.OleDb
Public Class forgetPassword
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\UserDB.accdb;"
    ' --- REQUIREMENT CHECK: SUB-FUNCTIONS (Function) ---

    ''' <summary>
    ''' Function: Returns a string containing the question text by checking multiple tables sequentially.
    ''' </summary>
    Private Function CheckUserQuestion(username As String) As String
        Dim tables() As String = {"tblCustomer", "tblStaff"}

        For Each table In tables
            Dim sql As String = $"SELECT [SecurityQuestion] FROM [{table}] WHERE [Username] = ?"
            Using conn As New OleDbConnection(connString)
                Using cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("?", username)
                    Try
                        conn.Open()
                        Dim result As Object = cmd.ExecuteScalar()
                        If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                            Return result.ToString() ' Returns the question out of the function immediately
                        End If
                    Catch ex As Exception
                        Throw ex
                    End Try
                End Using
            End Using
        Next
        Return ""
    End Function

    ''' <summary>
    ''' Function: Determines which target table a user belongs to and returns the table name string.
    ''' </summary>
    Private Function FindUserTable(username As String) As String
        Dim tables() As String = {"tblCustomer", "tblStaff"}

        For Each table In tables
            Dim sql As String = $"SELECT COUNT(*) FROM [{table}] WHERE [Username] = ?"
            Using conn As New OleDbConnection(connString)
                Using cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("?", username)
                    Try
                        conn.Open()
                        Dim count As Integer = CInt(cmd.ExecuteScalar())
                        If count > 0 Then
                            Return table ' Returns the matching string description name out of the function
                        End If
                    Catch ex As Exception
                        Throw ex
                    End Try
                End Using
            End Using
        Next
        Return ""
    End Function

    ' --- REQUIREMENT CHECK: SUB PROCEDURES (Sub) ---

    ''' <summary>
    ''' Sub Procedure: Coordinates calling lookup functions and modifying UI controls.
    ''' </summary>
    Private Sub GetAndDisplaySecurityQuestion(username As String)
        Try
            ' Call our custom data-retrieval Function
            Dim question As String = CheckUserQuestion(username)

            If Not String.IsNullOrEmpty(question) Then
                lblQuestion.Text = question
            Else
                MessageBox.Show("Username not found in Customer or Staff tables.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error retrieving question: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Sub Procedure: Validates conditions and executes the database update sequence.
    ''' </summary>
    Private Sub ProcessPasswordReset(username As String, newPass As String, answer As String)
        Try
            Dim foundTable As String = ""
            Dim dbAnswer As String = ""
            Dim dbPassword As String = ""

            ' 1. Use a Function to find which table this user belongs to
            foundTable = FindUserTable(username)

            If String.IsNullOrEmpty(foundTable) Then
                MessageBox.Show("Username not found in Customer or Staff tables.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' 2. Use a Sub Procedure to fetch their credential records from that specific table
            GetSecurityCredentials(username, foundTable, dbAnswer, dbPassword)

            ' 3. Process the security comparisons and criteria verification
            If dbAnswer.Equals(answer, StringComparison.OrdinalIgnoreCase) Then

                If dbPassword.Equals(newPass, StringComparison.OrdinalIgnoreCase) Then
                    MessageBox.Show("New password cannot be the same as the old password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                ' Call our specialized database updater sub procedure
                UpdateUserPassword(username, newPass, foundTable)

                MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loginForm.Show()
                Me.Close()
            Else
                MessageBox.Show("Incorrect answer to the security question.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error processing reset: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Sub Procedure: Passes answers back ByRef and processes multiple internal parameters.
    ''' </summary>
    Private Sub GetSecurityCredentials(username As String, tableName As String, ByRef outAnswer As String, ByRef outPassword As String)
        Dim sql As String = $"SELECT [SecurityAnswer], [Password] FROM [{tableName}] WHERE [Username] = ?"

        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("?", username)
                Try
                    conn.Open()
                    Using rdr As OleDbDataReader = cmd.ExecuteReader()
                        If rdr.Read() Then
                            outAnswer = rdr("SecurityAnswer").ToString()
                            outPassword = rdr("Password").ToString()
                        End If
                    End Using
                Catch ex As Exception
                    Throw ex
                End Try
            End Using
        End Using
    End Sub

    ''' <summary>
    ''' Sub Procedure: Commits the final data modification change directly to the database.
    ''' </summary>
    Private Sub UpdateUserPassword(username As String, newPassword As String, tableName As String)
        Dim sql As String = $"UPDATE [{tableName}] SET [Password] = ? WHERE [Username] = ?"

        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("?", newPassword)
                cmd.Parameters.AddWithValue("?", username)
                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    Throw ex
                End Try
            End Using
        End Using
    End Sub



    ' --- BUTTON

    Private Sub btnFindUser_Click(sender As Object, e As EventArgs) Handles btnFindUser.Click
        Dim username As String = txtForgotUsername.Text.Trim()

        If String.IsNullOrEmpty(username) Then
            MessageBox.Show("Please enter a username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Calls a Sub Procedure to search and show data on the UI
        GetAndDisplaySecurityQuestion(username)
    End Sub

    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        Dim username As String = txtForgotUsername.Text.Trim()
        Dim newPass As String = txtNewPassword.Text.Trim()
        Dim answer As String = txtAnswer.Text.Trim()

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(newPass) OrElse String.IsNullOrEmpty(answer) Then
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Calls a Sub Procedure to handle checking and processing the reset logic
        ProcessPasswordReset(username, newPass, answer)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        loginForm.Show()
        Me.Close()
    End Sub

End Class