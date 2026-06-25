Public Class book1
    Private Sub book1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Paksa Label jadi "anak" kepada PictureBox secara rasmi
        Label1.Parent = PictureBox1

        ' 2. Paksa latar belakang jadi lutsinar tembus gambar
        Label1.BackColor = Color.Transparent

        ' 3. Set koordinat baru (sebab koordinat sekarang dikira dari bucu atas kiri PictureBox)
        ' Sila tukar nombor (20, 150) ini mengikut kesesuaian kedudukan yang anda mahu
        Label1.Location = New Point(20, 150)
    End Sub
    Private Sub book1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit() ' Paksa tutup semua termaksud Form1 yang menyorok tadi
    End Sub

    Private Sub mnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class