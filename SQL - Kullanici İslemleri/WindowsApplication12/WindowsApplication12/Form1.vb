Imports System.Data
Imports System.Data.SqlClient
Public Class Form
    Dim baglanti As New SqlConnection

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        baglanti.ConnectionString = "Data Source=ADMİN55-PC\SQLEXPRESS;Initial Catalog=veri;Integrated Security=True;Pooling=False"
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim ogretim As String
        If RadioButton1.Checked = True Then
            ogretim = RadioButton1.Text
        Else
            ogretim = RadioButton2.Text
        End If
        Dim komut As New SqlCommand("insert into kayit(ogrenciNo,ad,soyad,adres,kayit_tarihi,ogretim) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox1.Text & "','" & ogretim & "')", baglanti)
        baglanti.Open()
        komut.ExecuteNonQuery()
        baglanti.Close()
        MsgBox("Kayıt Başarılı")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim komut As New SqlCommand("select * from kayit where ogrenciNo='" & TextBox1.Text & "'", baglanti)
        Dim dr As SqlDataReader
        baglanti.Open()
        dr = komut.ExecuteReader
        If dr.HasRows Then
            Do While dr.Read
                TextBox2.Text = dr("ad")
                TextBox3.Text = dr("soyad")
                TextBox4.Text = dr("adres")
                ComboBox1.Text = dr("kayit_tarihi")
                If dr("ogretim") = RadioButton1.Text Then
                    RadioButton1.Checked = True
                Else
                    RadioButton2.Checked = True
                End If
            Loop
        Else
            MsgBox("Kayıt Bulunamadı")
        End If
        baglanti.Close()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim ogretim As String
        If RadioButton1.Checked = True Then
            ogretim = RadioButton1.Text
        Else
            ogretim = RadioButton2.Text
        End If
        Dim komut As New SqlCommand("Update kayit set ad='" & TextBox2.Text & "', soyad='" & TextBox3.Text & "', adres='" & TextBox4.Text & "', kayit_tarihi='" & ComboBox1.Text & "', ogretim='" & ogretim & "' where ogrenciNo='" & TextBox1.Text & "'", baglanti)
        baglanti.Open()
        komut.ExecuteNonQuery()
        baglanti.Close()
        MsgBox("Kayıt Güncellendi")
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim komut As New SqlCommand("delete from kayit where ogrenciNo='" & TextBox1.Text & "'", baglanti)
        baglanti.Open()
        komut.ExecuteNonQuery()
        baglanti.Close()
        MsgBox("Kayıt Silindi")
    End Sub
End Class
