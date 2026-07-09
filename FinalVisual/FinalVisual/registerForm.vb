Imports System.Data.OleDb
Public Class registerForm

    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\UserDB.accdb;"
    ' --- REQUIREMENT CHECK: SUB-FUNCTIONS (Function) ---

    ''' <summary>
    ''' Function: Queries the selected table and returns True if a username is already taken.
    ''' </summary>
    Private Function UsernameExists(username As String, tableName As String) As Boolean
        Dim query As String = $"SELECT COUNT(*) FROM [{tableName}] WHERE [Username] = ?"

        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("?", username)
                Try
                    conn.Open()
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0 ' Returns true if username exists
                Catch ex As Exception
                    MessageBox.Show("Database validation error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return True ' Fail-safe to prevent registering if DB drops
                End Try
            End Using
        End Using
    End Function


    ' --- REQUIREMENT CHECK: SUB PROCEDURES (Sub) ---

    ''' <summary>
    ''' Sub Procedure: Handles building the SQL command dynamically and executing the registration.
    ''' </summary>
    Private Sub ExecuteUserRegistration(tableName As String, username As String, password As String, question As String, answer As String, phone As String, car As String, plate As String)
        Dim insertQuery As String = ""

        ' Determine query structure depending on table criteria
        If tableName = "tblCustomer" Then
            insertQuery = "INSERT INTO tblCustomer ([Username], [Password], [SecurityQuestion], [SecurityAnswer], [PhoneNumber], [Car], [PlateNumber]) VALUES (?,?,?,?,?,?,?)"
        Else
            insertQuery = "INSERT INTO tblStaff ([Username], [Password], [SecurityQuestion], [SecurityAnswer]) VALUES (?,?,?,?)"
        End If

        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand(insertQuery, conn)
                ' Add core parameters required by both tables
                cmd.Parameters.AddWithValue("?", username)
                cmd.Parameters.AddWithValue("?", password)
                cmd.Parameters.AddWithValue("?", question)
                cmd.Parameters.AddWithValue("?", answer)

                ' Add customer-only structural fields if chosen
                If tableName = "tblCustomer" Then
                    cmd.Parameters.AddWithValue("?", phone)
                    cmd.Parameters.AddWithValue("?", car)
                    cmd.Parameters.AddWithValue("?", plate)
                End If

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loginForm.Show()
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show("Registration failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
    ' --- BUTTON EVENTS ---

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim tableName As String = ""

        ' 1. Determine which table to use
        If rbCustomer.Checked Then
            tableName = "tblCustomer"
        ElseIf rbStaff.Checked Then
            tableName = "tblStaff"
        Else
            MessageBox.Show("Please select Customer or Staff.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 2. Basic input validation
        If txtRegUsername.Text.Trim() = "" OrElse
           txtRegPassword.Text.Trim() = "" OrElse
           cmbSecurityQuestion.SelectedIndex = -1 OrElse
           txtSecurityAnswer.Text.Trim() = "" Then
            MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim username As String = txtRegUsername.Text.Trim()

        ' 3. REQUIREMENT CHECK: Use a Sub-Function to check for existing username
        If UsernameExists(username, tableName) Then
            MessageBox.Show("Username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' 4. REQUIREMENT CHECK: Use a Sub Procedure to insert the new user record
        Dim password As String = txtRegPassword.Text.Trim()
        Dim question As String = cmbSecurityQuestion.SelectedItem.ToString()
        Dim answer As String = txtSecurityAnswer.Text.Trim().ToLower()
        Dim phone As String = txtPhone.Text.Trim()
        Dim car As String = cmbCarType.Text.Trim()
        Dim plate As String = txtPlate.Text.Trim()

        ExecuteUserRegistration(tableName, username, password, question, answer, phone, car, plate)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        loginForm.Show()
        Me.Close()
    End Sub

End Class