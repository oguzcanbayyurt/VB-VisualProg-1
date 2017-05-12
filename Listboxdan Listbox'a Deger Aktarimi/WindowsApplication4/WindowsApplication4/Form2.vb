Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim dersler(4) As Label
        dersler(0) = Label1
        dersler(1) = Label2
        dersler(2) = Label3
        dersler(3) = Label4
        dersler(4) = Label5
        For i = 0 To Form1.ListBox2.Items.Count - 1
            dersler(i).text = Form1.ListBox2.Items.Item(i)
        Next
    End Sub
End Class