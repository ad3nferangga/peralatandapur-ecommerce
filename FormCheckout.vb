Imports MySql.Data.MySqlClient

Public Class FormCheckout
    Public conn As New MySqlConnection
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public cmd As MySqlCommand
    Public query As String

    Private Sub FormCheckout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            query = "SELECT ID, Nama_Barang, Jumlah, Harga FROM checkout"
            da = New MySqlDataAdapter(query, conn)
            ds = New DataSet()
            da.Fill(ds, "checkout")
            tabelCheckout.DataSource = ds.Tables("checkout")
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub HitungTotalHarga()
        Dim totalHarga As Decimal = 0

        For Each row As DataGridViewRow In tabelCheckout.Rows
            If Not row.IsNewRow Then
                totalHarga += Convert.ToDecimal(row.Cells("Harga").Value)
            End If
        Next

        txtTotalHarga.Text = totalHarga.ToString("N2")
    End Sub
    Private Sub Clear()
        TextBoxID.Clear()
        TextBoxNamapembeli.Clear()
        TextBoxNoTelp.Clear()
        RichTextBox1.Clear()

    End Sub
    Private Sub btnTambahAlamat_Click(sender As Object, e As EventArgs) Handles btnTambahAlamat.Click
        FormAlamat.Show()
    End Sub

    Public Property Alamat As String
        Get
            Return RichTextBox1.Text
        End Get
        Set(value As String)
            RichTextBox1.Text = value
        End Set
    End Property

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormKeranjang.Show()
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormDashboard.Show()
        Close()
    End Sub

    Private Sub btnPesan_Click(sender As Object, e As EventArgs) Handles btnPesan.Click
        Dim namaPembeli As String = TextBoxNamapembeli.Text
        Dim noTelp As String = TextBoxNoTelp.Text
        Dim alamat As String = RichTextBox1.Text

        Try
            Koneksi()
            cmd = New MySqlCommand()
            cmd.Connection = conn
            Dim transaction As MySqlTransaction = conn.BeginTransaction()

            Try
                For Each row As DataGridViewRow In tabelCheckout.Rows
                    If Not row.IsNewRow Then
                        Dim id As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Dim namaBarang As String = row.Cells("Nama_Barang").Value.ToString()
                        Dim jumlah As Integer = Convert.ToInt32(row.Cells("Jumlah").Value)
                        Dim harga As Decimal = Convert.ToDecimal(row.Cells("Harga").Value)

                        ' Calculate the total price for each item
                        Dim totalHargaBarang As Decimal = harga * jumlah

                        ' Insert data into pesanan table
                        cmd.CommandText = "INSERT INTO pesanan (Nama_pembeli, Nama_Barang, Jumlah, Alamat, Harga) " &
                                      "VALUES (@Nama_pembeli, @Nama_Barang, @Jumlah, @Alamat, @Harga)"
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@Nama_pembeli", namaPembeli)
                        cmd.Parameters.AddWithValue("@Nama_Barang", namaBarang)
                        cmd.Parameters.AddWithValue("@Jumlah", jumlah)
                        cmd.Parameters.AddWithValue("@Alamat", alamat)
                        cmd.Parameters.AddWithValue("@Harga", totalHargaBarang)
                        cmd.ExecuteNonQuery()

                        cmd.CommandText = "INSERT INTO lihatpesanan (Nama_Barang, Jumlah, Harga, Status) " &
                                      "VALUES (@Nama_Barang, @Jumlah, @Harga, 'sedang di proses')"
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@Nama_Barang", namaBarang)
                        cmd.Parameters.AddWithValue("@Jumlah", jumlah)
                        cmd.Parameters.AddWithValue("@Harga", totalHargaBarang)
                        cmd.ExecuteNonQuery()
                    End If
                Next

                ' Remove data from checkout table after transferring
                cmd.CommandText = "DELETE FROM checkout"
                cmd.Parameters.Clear()
                cmd.ExecuteNonQuery()

                ' Commit the transaction
                transaction.Commit()
                MessageBox.Show("Pesanan berhasil dibuat dan data dipindahkan!")

            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("Gagal memindahkan data: " & ex.Message)
            End Try

        Catch ex As Exception
            MessageBox.Show("Gagal menghubungkan database: " & ex.Message)
        Finally
            conn.Close()
        End Try

        Clear()
        TampilData()
    End Sub




    Private Sub tabelCheckout_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles tabelCheckout.CellFormatting
        If e.RowIndex >= 0 Then
            If tabelCheckout.Columns(e.ColumnIndex).Name = "Harga" Then
                If IsNumeric(e.Value) Then
                    e.Value = Convert.ToDecimal(e.Value).ToString("N2")
                    e.FormattingApplied = True
                End If
            End If
        End If
    End Sub

End Class
