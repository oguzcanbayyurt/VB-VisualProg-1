Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim a, toplam As Integer
        toplam = 1
        For a = 1 To TextBox1.Text
            toplam = toplam * a
        Next
        Label4.Text = toplam


    End Sub
End Class
