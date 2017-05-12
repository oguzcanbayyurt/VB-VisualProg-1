Public Class Form1

    Private Sub ListBox1_DoubleClick(sender As Object, e As System.EventArgs) Handles ListBox1.DoubleClick
        ListBox2.Items.Add(ListBox1.SelectedItem)
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub ListBox2_DoubleClick(sender As Object, e As System.EventArgs) Handles ListBox2.DoubleClick
        ListBox1.Items.Add(ListBox2.SelectedItem)
        ListBox2.Items.Remove(ListBox2.SelectedItem)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If ListBox2.Items.Count > 5 Then
            MsgBox("5'den fazla ders seçemezsiniz")
        Else
        Me.Hide()
        Form2.Show()
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
