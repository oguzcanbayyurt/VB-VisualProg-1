Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim dizi(9), a, toplam As Integer
        For a = 0 To 9
            dizi(a) = InputBox("sayı giriniz", a + 1 & ".sayı")
            toplam = toplam + dizi(a)
        Next
        MsgBox(toplam / 10, MsgBoxStyle.OkOnly, "Ortalama")
    End Sub
End Class
