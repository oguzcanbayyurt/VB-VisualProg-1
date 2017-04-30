Public Class Form2

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim a, toplam As Integer
        For a = 1 To TextBox1.Text
            toplam = toplam * a
        Next
        MsgBox(toplam)
    End Sub
End Class