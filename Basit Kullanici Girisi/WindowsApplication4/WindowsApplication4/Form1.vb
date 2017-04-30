Public Class Form1
    Dim hak As Integer

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim kadi, sifre As String
        Dim i As Integer
        kadi = TextBox1.Text
        sifre = TextBox2.Text
        If hak >= 3 Then
            Label3.Text = "Hakkınız Doldu"
            Button1.Enabled = False
        Else
        If kadi = "admin" And sifre = "12345" Then
                Me.Hide()
                Form2.Show()
            Else
                Label3.Text = "Hatalı Giriş"
                hak += 1
            End If
        End If


    End Sub
End Class
