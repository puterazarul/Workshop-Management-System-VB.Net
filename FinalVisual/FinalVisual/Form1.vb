Public Class Form1
    Private Sub mnuMenuExit_Click(sender As Object, e As EventArgs) Handles mnuMenuExit.Click
        Application.Exit()
    End Sub

    Private Sub STAFFLOGINToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles STAFFLOGINToolStripMenuItem1.Click
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        book1.Show()
        Me.Hide()
    End Sub

    Private Sub mnuMenuAbout_Click(sender As Object, e As EventArgs) Handles mnuMenuAbout.Click
        aboutForm.Show()
        Me.Hide()
    End Sub
End Class
