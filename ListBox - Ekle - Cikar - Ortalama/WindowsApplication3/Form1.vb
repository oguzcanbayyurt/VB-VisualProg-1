Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim kacsayivar, a, toplam
        kacsayivar = ListBox1.Items.Count
        toplam = 0
        For a = 0 To kacsayivar - 1
            toplam = toplam + ListBox1.Items(a)
        Next
        toplam = toplam / kacsayivar
        MsgBox("Toplam Girilen Sayı " & kacsayivar & " Ortalaması = " & toplam)
    End Sub
End Class
