Module SessionData

    ' Store logged-in user details
    Public CurrentUsername As String
        Public CurrentRole As String
        Public CurrentPlate As String

        ' Optional helper methods
        Public Sub ClearSession()
            CurrentUsername = Nothing
            CurrentRole = Nothing
            CurrentPlate = Nothing
        End Sub

        Public Function IsLoggedIn() As Boolean
            Return Not String.IsNullOrEmpty(CurrentUsername)
        End Function




End Module
