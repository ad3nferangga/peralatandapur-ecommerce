Imports MySql.Data.MySqlClient

Public Class FormJual
    Public conn As New MySqlConnection
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public cmd As MySqlCommand
    Public query As String

    Private Sub FormJual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            tabelstok.DataSource = ds.Tables("produk")
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
        TextBoxStok.Clear()
        TextBoxHargaJual.Clear()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If TextBoxNama.Text = "" Or TextBoxStok.Text = "" Or TextBoxHargaJual.Text = "" Then
            MessageBox.Show("Harap isi semua data.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not IsNumeric(TextBoxStok.Text) Or Not IsNumeric(TextBoxHargaJual.Text) Then
            MessageBox.Show("Harap masukkan nilai angka untuk Stok dan Harga Jual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Koneksi()
            query = "INSERT INTO produk (Nama_Barang, Kategori, Stok, Harga_Jual) VALUES (@nama, @kategori, @stok, @harga_jual)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nama", TextBoxNama.Text)
            cmd.Parameters.AddWithValue("@kategori", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@stok", Convert.ToInt32(TextBoxStok.Text))
            cmd.Parameters.AddWithValue("@harga_jual", Convert.ToDecimal(TextBoxHargaJual.Text))

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Clear()
        Catch ex As Exception
            MessageBox.Show("Gagal menambah data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ButtonUbah_Click(sender As Object, e As EventArgs) Handles ButtonUbah.Click
        If TextBoxID.Text = "" Or TextBoxNama.Text = "" Or TextBoxStok.Text = "" Or TextBoxHargaJual.Text = "" Then
            MessageBox.Show("Harap isi semua data.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not IsNumeric(TextBoxStok.Text) Or Not IsNumeric(TextBoxHargaJual.Text) Then
            MessageBox.Show("Harap masukkan nilai angka untuk Stok dan Harga Jual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Koneksi()
            query = "UPDATE produk SET Nama_Barang=@nama, Kategori=@kategori, Stok=@stok, Harga_Jual=@harga_jual WHERE ID=@id"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", TextBoxID.Text)
            cmd.Parameters.AddWithValue("@nama", TextBoxNama.Text)
            cmd.Parameters.AddWithValue("@kategori", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@stok", Convert.ToInt32(TextBoxStok.Text))
            cmd.Parameters.AddWithValue("@harga_jual", Convert.ToDecimal(TextBoxHargaJual.Text))
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diubah.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Clear()
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        If TextBoxID.Text = "" Then
            MessageBox.Show("Harap pilih data yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Koneksi()
            query = "DELETE FROM produk WHERE ID=@id"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", TextBoxID.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Clear()
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub tabelstok_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelstok.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = tabelstok.Rows(e.RowIndex)

            TextBoxID.Text = If(IsDBNull(row.Cells("ID").Value), "", row.Cells("ID").Value.ToString())
            TextBoxNama.Text = If(IsDBNull(row.Cells("Nama_Barang").Value), "", row.Cells("Nama_Barang").Value.ToString())
            ComboBox1.Text = If(IsDBNull(row.Cells("Kategori").Value), "", row.Cells("Kategori").Value.ToString())
            TextBoxStok.Text = If(IsDBNull(row.Cells("Stok").Value), "0", row.Cells("Stok").Value.ToString())
            TextBoxHargaJual.Text = If(IsDBNull(row.Cells("Harga_Jual").Value), "0", row.Cells("Harga_Jual").Value.ToString())
        End If
    End Sub

    Private Sub ButtonKosongkan_Click(sender As Object, e As EventArgs) Handles ButtonKosongkan.Click
        Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormPenjual.Show()
        Close()
    End Sub
End Class
