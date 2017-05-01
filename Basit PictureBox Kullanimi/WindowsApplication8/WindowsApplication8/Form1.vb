Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox2.ImageLocation = "Resources\1.jpg"

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)
        Me.BackColor = Color.Red
    End Sub
End Class
