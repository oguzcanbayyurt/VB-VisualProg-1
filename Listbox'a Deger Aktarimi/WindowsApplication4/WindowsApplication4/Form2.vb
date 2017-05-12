Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim kisiler(9) As Label
        kisiler(0) = Label1
        kisiler(1) = Label2
        kisiler(2) = Label3
        kisiler(3) = Label4
        kisiler(4) = Label5
        kisiler(5) = Label6
        kisiler(6) = Label7
        kisiler(7) = Label8
        kisiler(8) = Label9
        kisiler(9) = Label10
        For i = 0 To Form1.ListBox1.Items.Count - 1
            kisiler(i).Text = Form1.ListBox1.Items.Item(i)
        Next
    End Sub
End Class