Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim sayac, toplam As Integer
        For sayac = TextBox1.Text To TextBox2.Text
            toplam = toplam + sayac
        Next
        MsgBox(toplam)

    End Sub
End Class
