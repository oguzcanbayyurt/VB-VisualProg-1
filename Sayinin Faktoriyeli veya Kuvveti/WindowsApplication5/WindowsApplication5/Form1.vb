Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim a, toplam As Integer
        toplam = 1
        For a = 1 To TextBox1.Text
            toplam = a * toplam
        Next
        MsgBox(toplam)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim kuvvet, toplam As Integer
        kuvvet = InputBox("Hangi Sayının")
        toplam = TextBox1.Text ^ kuvvet
        MsgBox(toplam)
    End Sub
End Class
