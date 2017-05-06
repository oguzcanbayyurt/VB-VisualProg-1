Public Class Form1
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or MaskedTextBox1.Text = "" Then
            Label7.Visible = True
            Label7.Text = "Lütfen Tüm Alanları Doldurunuz"
        Else
            Label6.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            Label10.Visible = True
            Dim k As Integer
            Dim yazi As String
            k = Strings.InStr(TextBox3.Text, "@")
            yazi = Strings.LCase(Strings.Left(TextBox1.Text, 1) &
            Strings.Left(TextBox2.Text, 1) & Strings.Left(TextBox3.Text, k - 1) &
            Strings.Right(MaskedTextBox1.Text, 4))
            yazi = Strings.Replace(yazi, "ş", "s")
            yazi = Strings.Replace(yazi, "ö", "o")
            yazi = Strings.Replace(yazi, "ı", "i")
            yazi = Strings.Replace(yazi, "ü", "u")
            yazi = Strings.Replace(yazi, "ç", "c")
            yazi = Strings.Replace(yazi, "ğ", "g")
            Label7.Text = yazi
            Dim a() As String = TextBox3.Text.Split("@")
            Label9.Text = a(1)
            Label10.Text = Strings.Len(yazi) + 1
        End If
    End Sub
End Class
