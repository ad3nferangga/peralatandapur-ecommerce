Imports MySql.Data.MySqlClient

Public Class Form2
    Public conn As New MySqlConnection("server=localhost;user=root;password=;database=peralatandapur")
    Public cmd As MySqlCommand

    ' Membuat Akun Pembeli
    Private Sub btnakunpembeli_Click(sender As Object, e As EventArgs) Handles btnakunpembeli.Click
        ' Validasi input
        If TextBox2.Text = "" Or TextBox1.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conn.Open()
            Dim query As String = "INSERT INTO users (full_name, email, username, password, role) VALUES (@name, @email, @username, @password, 'Pembeli')"
            cmd = New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@name", TextBox2.Text)
            cmd.Parameters.AddWithValue("@email", TextBox1.Text)
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text) ' Langsung menyimpan password

            cmd.ExecuteNonQuery()
            MessageBox.Show("Akun Pembeli berhasil dibuat!")
            Me.Hide()
            Form1.Show()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Membuat Akun Penjual
    Private Sub btnakunpenjual_Click(sender As Object, e As EventArgs) Handles btnakunpenjual.Click
        ' Validasi input
        If TextBox2.Text = "" Or TextBox1.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conn.Open()
            Dim query As String = "INSERT INTO users (full_name, email, username, password, role) VALUES (@name, @email, @username, @password, 'Penjual')"
            cmd = New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@name", TextBox2.Text)
            cmd.Parameters.AddWithValue("@email", TextBox1.Text)
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text) ' Langsung menyimpan password

            cmd.ExecuteNonQuery()
            MessageBox.Show("Akun Penjual berhasil dibuat!")
            Me.Hide()
            Form1.Show()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Kembali ke Form Login
    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class
