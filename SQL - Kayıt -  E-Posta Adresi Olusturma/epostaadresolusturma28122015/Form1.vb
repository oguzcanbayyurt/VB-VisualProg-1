Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    Dim baglanti As New SqlClient.SqlConnection
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim eposta As String
        eposta = TextBox3.Text & "@" & ComboBox1.Text
        eposta = Strings.Replace(eposta, "ş", "s")
        eposta = Strings.Replace(eposta, "ö", "o")
        eposta = Strings.Replace(eposta, "ğ", "g")
        Dim komut As New SqlCommand("Select * from kayittablosu where eposta = '" & eposta & "'", baglanti)
        Dim dr As SqlDataReader
        baglanti.Open()
        dr = komut.ExecuteReader
        If dr.HasRows Then
            Label9.Text = "Bu e-posta adresi kullanılmaktadır."
            Label9.ForeColor = Color.Red
            Button4.Visible = False
            Button2.Visible = False
        Else
            Label9.Text = "Gerçerli e-posta."
            Label9.ForeColor = Color.Green
            Button2.Visible = True
            TextBox3.Enabled = False
            ComboBox1.Enabled = False
            Button4.Visible = True
        End If
        baglanti.Close()
    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        baglanti.ConnectionString = "Data Source=CASPER_NIRVANA\SQLEXPRESS;Initial Catalog=epostakayitlari;Integrated Security=True;Pooling=False"
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim eposta As String
        eposta = TextBox3.Text & "@" & ComboBox1.Text
        eposta = Strings.Replace(eposta, "ş", "s")
        eposta = Strings.Replace(eposta, "ö", "o")
        eposta = Strings.Replace(eposta, "ğ", "g")
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Bütün alanları doldurunuz.")
        Else
            If TextBox4.Text = TextBox5.Text Then
                Dim komut As New SqlCommand("insert into kayittablosu (ad,soyad,eposta,sifre,digereposta) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & eposta & "','" & TextBox4.Text & "','" & TextBox6.Text & "')", baglanti)
                baglanti.Open()
                komut.ExecuteNonQuery()
                baglanti.Close()
                MsgBox("Kayıt Başarılı")
            Else
                MsgBox("Şifreler aynı değil.")
            End If
        End If
    End Sub
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        TextBox3.Enabled = True
        ComboBox1.Enabled = True
    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        ComboBox1.Text = ""
        TextBox3.Enabled = True
        ComboBox1.Enabled = True
    End Sub
End Class
