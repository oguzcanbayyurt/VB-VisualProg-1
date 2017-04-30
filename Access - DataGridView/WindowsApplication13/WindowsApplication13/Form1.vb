Imports System.Data
Imports System.Data.OleDb
Public Class Form1
    Dim sorgu As String = "select * from kayit"
    Dim baglanti As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=veri.accdb")
    Private Sub listele(sorgu)
        Dim komut As New OleDbDataAdapter(sorgu, baglanti)
        Dim ds As New DataSet
        komut.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        listele(sorgu)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        sorgu = "select * from kayit where tur like '%" & TextBox1.Text & "%'"
        listele(sorgu)
    End Sub
End Class
