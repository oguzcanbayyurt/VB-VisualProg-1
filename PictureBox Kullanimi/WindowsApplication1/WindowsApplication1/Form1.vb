Public Class Form1

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.BackgroundImage = System.Drawing.Image.FromFile("1.jpg")
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Me.BackgroundImage = System.Drawing.Image.FromFile("2.jpg")
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        Me.BackgroundImage = System.Drawing.Image.FromFile("3.jpg")
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        Me.BackgroundImage = System.Drawing.Image.FromFile("4.jpg")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.BackColor = Button1.BackColor
        Me.BackgroundImage = Nothing
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.BackColor = Button2.BackColor
        Me.BackgroundImage = Nothing
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.BackColor = Button3.BackColor
        Me.BackgroundImage = Nothing
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.BackColor = Button4.BackColor
        Me.BackgroundImage = Nothing
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        PictureBox5.ImageLocation = "1.jpg"
    End Sub
End Class
