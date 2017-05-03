Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim sayilar(9), a, toplam As Integer
        toplam = 0
        For a = 0 To 9
            sayilar(a) = InputBox("Sayı Giriniz", a + 1 & ". Sayı", 55)
            toplam = toplam + sayilar(a)
        Next
        MsgBox(toplam / sayilar.Length(), MsgBoxStyle.OkOnly, "Ortalama")
    End Sub
End Class
