Imports MySql.Data.MySqlClient

Public Class FormKeranjang
    Public conn As New MySqlConnection
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public cmd As MySqlCommand
    Public query As String

    ' Event saat form keranjang dibuka
    Private Sub FormKeranjang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        TampilData()
        HitungTotalHarga()
    End Sub
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
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TampilData()
        Try
            Koneksi()
            query = "SELECT ID, Nama_Barang, Kategori, Jumlah, Harga FROM keranjang"
            da = New MySqlDataAdapter(query, conn)
            ds = New DataSet()
            da.Fill(ds, "keranjang")
            tabelkeranjang.DataSource = ds.Tables("keranjang")
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub HitungTotalHarga()
        Dim totalHarga As Decimal = 0

        For Each row As DataGridViewRow In tabelkeranjang.Rows
            If Not row.IsNewRow Then
                totalHarga += Convert.ToDecimal(row.Cells("Harga").Value)
            End If
        Next

        txtTotalHarga.Text = totalHarga.ToString("N2")
    End Sub
    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If tabelkeranjang.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih baris transaksi yang ingin dihapus.")
            Return
        End If

        Dim selectedRow As DataGridViewRow = tabelkeranjang.SelectedRows(0)
        Dim idProduk As Integer
        Dim jumlahBeli As Integer

        Try
            idProduk = Convert.ToInt32(selectedRow.Cells("ID").Value)
            jumlahBeli = Convert.ToInt32(selectedRow.Cells("Jumlah").Value)

            Koneksi()

            query = "UPDATE produk SET Stok = Stok + @jumlah WHERE ID = @id"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@jumlah", jumlahBeli)
            cmd.Parameters.AddWithValue("@id", idProduk)
            cmd.ExecuteNonQuery()

            query = "DELETE FROM keranjang WHERE ID = @id AND Jumlah = @jumlah LIMIT 1"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", idProduk)
            cmd.Parameters.AddWithValue("@jumlah", jumlahBeli)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Transaksi berhasil dihapus dan stok dikembalikan.")

        Catch ex As Exception
            MessageBox.Show("Gagal menghapus transaksi: " & ex.Message)
        Finally
            conn.Close()
        End Try

        TampilData()
        HitungTotalHarga()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        FormDashboard.Show()
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormCheckout.Show()
        Close()
    End Sub

    Private Sub tabelkeranjang_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles tabelkeranjang.CellFormatting
        If e.RowIndex >= 0 Then
            If tabelkeranjang.Columns(e.ColumnIndex).Name = "Harga" Then
                If IsNumeric(e.Value) Then
                    e.Value = Convert.ToDecimal(e.Value).ToString("N2")
                    e.FormattingApplied = True
                End If
            End If
        End If
    End Sub

    Private Sub ButtonCheckout_Click(sender As Object, e As EventArgs) Handles ButtonCheckout.Click
        Try
            If tabelkeranjang.Rows.Count = 0 Then
                MessageBox.Show("Keranjang masih kosong, silahkan pilih barang dari produk.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Koneksi()

            ' 1. Loop untuk setiap baris di tabel keranjang
            For Each row As DataGridViewRow In tabelkeranjang.Rows
                If row.IsNewRow Then Continue For ' Abaikan baris kosong

                Dim idProduk As Integer = Convert.ToInt32(row.Cells("ID").Value)
                Dim namaBarang As String = row.Cells("Nama_Barang").Value.ToString()
                Dim jumlah As Integer = Convert.ToInt32(row.Cells("Jumlah").Value)
                Dim harga As Decimal = Convert.ToDecimal(row.Cells("Harga").Value)

                ' 2. Insert ke tabel checkout
                query = "INSERT INTO checkout (ID, Nama_Barang, Jumlah, Harga) VALUES (@id, @nama, @jumlah, @harga)"
                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", idProduk)
                cmd.Parameters.AddWithValue("@nama", namaBarang)
                cmd.Parameters.AddWithValue("@jumlah", jumlah)
                cmd.Parameters.AddWithValue("@harga", harga)
                cmd.ExecuteNonQuery()
            Next

            ' 3. Hapus semua data dari tabel keranjang
            query = "DELETE FROM keranjang"
            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data berhasil di checkout.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' 4. Refresh tabel keranjang dan hitung total harga
            TampilData()
            HitungTotalHarga()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormDashboard.Show()
        Close()
    End Sub
End Class
