Public Class Form1
    Dim salise, saniye, dakika, saat As Integer


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        saat = 0
        dakika = 0
        saniye = 0
        salise = 0
        Label6.Text = 0
        Label7.Text = 0
        Label8.Text = 0
        Label9.Text = 0
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        salise = salise + 1
        If salise = 100 Then
            salise = 0
            saniye = saniye + 1
        End If
        If saniye = 60 Then
            saniye = 0
            dakika = dakika + 1
        End If
        If dakika = 60 Then
            dakika = 0
            saat = dakika + 1
        End If
        If saat = 24 Then
            saat = 0
        End If
        Label6.Text = saat
        Label7.Text = dakika
        Label8.Text = saniye
        Label9.Text = salise

    End Sub
End Class
