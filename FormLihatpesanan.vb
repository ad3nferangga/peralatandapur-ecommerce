Imports MySql.Data.MySqlClient

Public Class FormPesananSaya
    Public conn As New MySqlConnection
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public cmd As MySqlCommand
    Public query As String

    ' Memuat data ketika form dibuka
    Private Sub FormPesananSaya_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi() ' Memanggil fungsi koneksi
        TampilData() ' Menampilkan data
    End Sub

    ' Fungsi untuk menghubungkan ke database
    Private Sub Koneksi()
        Dim strconn As String
        Try
            strconn = "server=localhost;user=root;password=;database=peralatandapur"
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.ConnectionString = strconn
            conn.Open()
        Catch ex As Exception
            MsgBox("Gagal menghubungkan ke database: " & ex.Message)
        End Try
    End Sub

    ' Fungsi untuk menampilkan data dari tabel 'lihatpesanan'
    Private Sub TampilData()
        Try
            Koneksi() ' Memanggil koneksi ke database
            query = "SELECT ID, Nama_Barang, Jumlah, Harga, Status FROM lihatpesanan"
            da = New MySqlDataAdapter(query, conn)
            ds = New DataSet()
            da.Fill(ds, "lihatpesanan")
            tabelLihatpesanan.DataSource = ds.Tables("lihatpesanan") ' Mengisi DataGridView dengan data
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message)
        Finally
            conn.Close() ' Menutup koneksi setelah operasi selesai
        End Try
    End Sub

    ' Event handler untuk tombol kembali ke Dashboard
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormDashboard.Show() ' Menampilkan FormDashboard
        Me.Close() ' Menutup FormPesananSaya
    End Sub
End Class
