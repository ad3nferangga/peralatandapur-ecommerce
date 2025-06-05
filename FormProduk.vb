Imports MySql.Data.MySqlClient

Public Class FormProduk
    Public conn As New MySqlConnection
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public cmd As MySqlCommand
    Public query As String

    Private Sub FormProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        TampilData()
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
            query = "SELECT ID, Nama_Barang, Kategori, Stok, Harga_Jual FROM produk"
            da = New MySqlDataAdapter(query, conn)
            ds = New DataSet()
            da.Fill(ds, "produk")
            tabelproduk.DataSource = ds.Tables("produk")
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Clear()
        TextBoxID.Clear()
        TextBoxNama.Clear()
        ComboBox1.SelectedIndex = -1
        TextBoxHarga.Clear()
        NumericUpDown1.Value = 1
    End Sub

    Private Sub btnMasukKeranjang_Click(sender As Object, e As EventArgs) Handles btnMasukKeranjang.Click
        If TextBoxID.Text = "" Or TextBoxNama.Text = "" Or NumericUpDown1.Value <= 0 Then
            MessageBox.Show("Pilih barang dan masukkan jumlah yang valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Koneksi()
            ' 1. Periksa stok yang tersedia
            query = "SELECT Stok FROM produk WHERE ID = @id"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", TextBoxID.Text)
            Dim stokTersedia As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            Dim jumlahBeli As Integer = Convert.ToInt32(NumericUpDown1.Value)

            If stokTersedia < jumlahBeli Then
                MessageBox.Show("Stok tidak mencukupi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            query = "UPDATE produk SET Stok = Stok - @jumlah WHERE ID = @id"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@jumlah", jumlahBeli)
            cmd.Parameters.AddWithValue("@id", TextBoxID.Text)
            cmd.ExecuteNonQuery()

            query = "INSERT INTO keranjang (ID, Nama_Barang, Kategori, Jumlah, Harga) VALUES (@id_produk, @nama, @kategori, @jumlah, @harga)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id_produk", TextBoxID.Text)
            cmd.Parameters.AddWithValue("@nama", TextBoxNama.Text)
            cmd.Parameters.AddWithValue("@kategori", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@jumlah", jumlahBeli)
            cmd.Parameters.AddWithValue("@harga", Convert.ToDecimal(TextBoxHarga.Text) * jumlahBeli) ' Total harga
            cmd.ExecuteNonQuery()

            MessageBox.Show("Barang berhasil dimasukkan ke keranjang.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TampilData()
            Clear()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnKosongkan_Click(sender As Object, e As EventArgs) Handles btnKosongkan.Click
        Clear()
    End Sub

    Private Sub tabelproduk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelproduk.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = tabelproduk.Rows(e.RowIndex)

            TextBoxID.Text = If(IsDBNull(row.Cells("ID").Value), "", row.Cells("ID").Value.ToString())
            TextBoxNama.Text = If(IsDBNull(row.Cells("Nama_Barang").Value), "", row.Cells("Nama_Barang").Value.ToString())
            ComboBox1.Text = If(IsDBNull(row.Cells("Kategori").Value), "", row.Cells("Kategori").Value.ToString())
            TextBoxHarga.Text = If(IsDBNull(row.Cells("Harga_Jual").Value), "", row.Cells("Harga_Jual").Value.ToString())
        End If

        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = tabelproduk.Rows(e.RowIndex)
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi error saat memilih data: " & ex.Message)
        End Try

    End Sub

    Private Sub tabelproduk_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles tabelproduk.CellFormatting
        If e.RowIndex >= 0 Then
            If tabelproduk.Columns(e.ColumnIndex).Name = "Harga_Jual" Then
                If IsNumeric(e.Value) Then
                    e.Value = Convert.ToDecimal(e.Value).ToString("N2")
                    e.FormattingApplied = True
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormDashboard.Show()
        Close()
    End Sub
End Class
