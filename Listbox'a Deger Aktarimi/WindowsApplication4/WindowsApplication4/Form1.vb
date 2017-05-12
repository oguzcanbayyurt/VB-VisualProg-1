Public Class Form1

    Private Sub ListBox1_DoubleClick(sender As Object, e As System.EventArgs) Handles ListBox1.DoubleClick
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If ListBox1.Items.Count < 10 Then
            ListBox1.Items.Add(TextBox1.Text & MaskedTextBox1.Text)
        Else
            MsgBox("En Fazla 10 kişi kayıt edilebilir.Aktarmak için Aktar butonuna tıklayınız")
            Button2.Visible = True

        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
