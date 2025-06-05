Imports MySql.Data.MySqlClient

Public Class Form1
    Public conn As New MySqlConnection("server=localhost;user=root;password=;database=peralatandapur")
    Public cmd As MySqlCommand
    Public reader As MySqlDataReader

    ' Proses Login
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' Validasi input
        If username = "" Or password = "" Then
            MessageBox.Show("Username dan password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conn.Open()
            Dim query As String = "SELECT full_name, role FROM users WHERE username = @username AND password = @password"
            cmd = New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)

            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim fullName As String = reader("full_name").ToString()
                Dim role As String = reader("role").ToString()

                MessageBox.Show("Login berhasil. Selamat datang, " & fullName & "!", "Login Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Cek role user dan arahkan ke form sesuai role
                If role = "Pembeli" Then
                    FormDashboard.Show()
                End If

            Else
                MessageBox.Show("Username atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    ' Menuju ke Form Buat Akun
    Private Sub btn_formbuatakun_Click(sender As Object, e As EventArgs) Handles btn_formbuatakun.Click
        Form2.Show()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' Validasi input
        If username = "" Or password = "" Then
            MessageBox.Show("Username dan password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conn.Open()
            Dim query As String = "SELECT full_name, role FROM users WHERE username = @username AND password = @password"
            cmd = New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)

            reader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim fullName As String = reader("full_name").ToString()
                Dim role As String = reader("role").ToString()

                MessageBox.Show("Login berhasil. Selamat datang, " & fullName & "!", "Login Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Cek role user dan arahkan ke form sesuai role
                If role = "Penjual" Then
                    FormPenjual.Show()
                End If

            Else
                MessageBox.Show("Username atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
