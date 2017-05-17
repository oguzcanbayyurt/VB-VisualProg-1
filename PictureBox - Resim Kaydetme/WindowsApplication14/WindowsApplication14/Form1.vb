Imports System.IO
Public Class Form1

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        PictureBox1.Image.Save(System.IO.Path.Combine(My.Application.Info.DirectoryPath.ToString & "/uye_resimleri/", "deneme.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg)
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.ImageLocation = OpenFileDialog1.FileName
        System.IO.Path.GetFileName("c:/")
    End Sub
End Class
