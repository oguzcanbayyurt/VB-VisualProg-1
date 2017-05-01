Public Class Form1
    Dim ort As Double
    Dim randomsayi As New Random
    Dim i, say(9), toplam As Integer

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        toplam = 0
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        For i = 0 To 9
            say(i) = Convert.ToInt32(randomsayi.Next(140, 220))
            ListBox1.Items.Add(say(i))
            toplam = toplam + say(i)
        Next
        ort = toplam / 10
        Label3.Text = ort
        For i = 0 To 9
            If (ort < say(i)) Then
                ListBox2.Items.Add(say(i))
            End If
            Label1.Text = ListBox2.Items.Count
            If (ort > say(i)) Then
                ListBox3.Items.Add(say(i))
            End If
            Label2.Text = ListBox3.Items.Count
        Next
    End Sub
End Class
