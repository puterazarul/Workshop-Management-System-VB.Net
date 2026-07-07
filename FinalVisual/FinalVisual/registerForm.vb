Imports System.Data.OleDb
Public Class registerForm

    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\UserDB.accdb;"

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim tableName As String = ""

        If rbCustomer.Checked Then
            tableName = "tblCustomer"
        ElseIf rbStaff.Checked Then
            tableName = "tblStaff"
        Else
            MessageBox.Show("Please select Customer or Staff.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Basic validation
        If txtRegUsername.Text.Trim() = "" OrElse
       txtRegPassword.Text.Trim() = "" OrElse
       cmbSecurityQuestion.SelectedIndex = -1 OrElse
       txtSecurityAnswer.Text.Trim() = "" Then
            MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Using conn As New OleDbConnection(connString)
            ' 1. Check if username exists in the selected table
            Dim checkQuery As String = "SELECT COUNT(*) FROM [" & tableName & "] WHERE [Username] = ?"
            Using checkCmd As New OleDbCommand(checkQuery, conn)
                checkCmd.Parameters.AddWithValue("?", txtRegUsername.Text.Trim())
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

            ' 2. Insert new user into the correct table
            Dim insertQuery As String
            If tableName = "tblCustomer" Then
                insertQuery = "INSERT INTO tblCustomer ([Username], [Password], [SecurityQuestion], [SecurityAnswer], [PhoneNumber], [Car], [PlateNumber]) VALUES (?,?,?,?,?,?,?)"
            Else
                insertQuery = "INSERT INTO tblStaff ([Username], [Password], [SecurityQuestion], [SecurityAnswer]) VALUES (?,?,?,?)"
            End If

            Using insertCmd As New OleDbCommand(insertQuery, conn)
                insertCmd.Parameters.AddWithValue("?", txtRegUsername.Text.Trim())
                insertCmd.Parameters.AddWithValue("?", txtRegPassword.Text.Trim())
                insertCmd.Parameters.AddWithValue("?", cmbSecurityQuestion.SelectedItem.ToString())
                insertCmd.Parameters.AddWithValue("?", txtSecurityAnswer.Text.Trim().ToLower())

                If tableName = "tblCustomer" Then
                    insertCmd.Parameters.AddWithValue("?", txtPhone.Text.Trim())
                    insertCmd.Parameters.AddWithValue("?", cmbCarType.Text.Trim())
                    insertCmd.Parameters.AddWithValue("?", txtPlate.Text.Trim())
                End If

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


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub txtCustFullName_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class