Module SessionData
    ' Stores the currently logged-in username
    Public CurrentUsername As String = ""

    ' Stores the role of the user ("Customer" or "Staff")
    Public CurrentRole As String = ""

    ' Helper method to clear session (use on logout)
    Public Sub ClearSession()
        CurrentUsername = ""
        CurrentRole = ""
    End Sub

    ' Helper method to check if user is logged in
    Public Function IsLoggedIn() As Boolean
        Return Not String.IsNullOrEmpty(CurrentUsername)
    End Function


End Module
