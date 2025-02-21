Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        bukaKoneksi()
        cmd = New MySqlCommand("SELECT * FROM users WHERE username=@username AND password=@password", conn)
        cmd.Parameters.AddWithValue("@username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@password", txtPassword.Text)
        rd = cmd.ExecuteReader()
        If rd.Read() Then
            Me.Hide()
            FormUtama.Show()
        Else
            MessageBox.Show("Username atau password salah!")
        End If
        conn.Close()
    End Sub

    Private Sub btnRegistrasi_Click(sender As Object, e As EventArgs) Handles btnRegistrasi.Click
        bukaKoneksi()
        cmd = New MySqlCommand("INSERT INTO users (username, password) VALUES (@username, @password)", conn)
        cmd.Parameters.AddWithValue("@username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@password", txtPassword.Text)
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Registrasi berhasil!")
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Application.Exit()
    End Sub
End Class
