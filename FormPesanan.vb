Imports MySql.Data.MySqlClient

Public Class FormPesanan
    Public conn As New MySqlConnection
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public cmd As MySqlCommand
    Public query As String

    Private Sub FormPesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            query = "SELECT ID, Nama_pembeli, Nama_Barang, Jumlah, Alamat, Harga FROM pesanan"
            da = New MySqlDataAdapter(query, conn)
            ds = New DataSet()
            da.Fill(ds, "pesanan")
            tabelpesanan.DataSource = ds.Tables("pesanan")
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormPenjual.Show()
        Close()
    End Sub

    Private Sub Buttonkirim_Click(sender As Object, e As EventArgs) Handles Buttonkirim.Click
        If tabelpesanan.SelectedRows.Count > 0 Then
            Try
                Koneksi()

                For Each row As DataGridViewRow In tabelpesanan.SelectedRows
                    Dim id As Integer = Convert.ToInt32(row.Cells("ID").Value)
                    Dim namaBarang As String = row.Cells("Nama_Barang").Value.ToString()
                    Dim jumlah As Integer = Convert.ToInt32(row.Cells("Jumlah").Value)
                    Dim harga As Decimal = Convert.ToDecimal(row.Cells("Harga").Value)

                    query = "INSERT INTO review (ID, Nama_Barang, Jumlah, Harga) " &
                        "VALUES (@ID, @Nama_Barang, @Jumlah, @Harga)"
                    cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", id)
                    cmd.Parameters.AddWithValue("@Nama_Barang", namaBarang)
                    cmd.Parameters.AddWithValue("@Jumlah", jumlah)
                    cmd.Parameters.AddWithValue("@Harga", harga)
                    cmd.ExecuteNonQuery()

                Next

                For Each row As DataGridViewRow In tabelpesanan.SelectedRows
                    Dim id As Integer = Convert.ToInt32(row.Cells("ID").Value)

                    query = "DELETE FROM pesanan WHERE ID = @ID"
                    cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", id)
                    cmd.ExecuteNonQuery()

                    query = "DELETE FROM lihatpesanan"
                    cmd = New MySqlCommand(query, conn)

                    cmd.ExecuteNonQuery()
                Next

                MessageBox.Show("Brang telah berhasil di kirim!")

                TampilData()


            Catch ex As Exception
                MessageBox.Show("Gagal memindahkan data: " & ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Pilih data yang akan dipindahkan terlebih dahulu.")
        End If
    End Sub

    Private Sub tabelpesanan_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles tabelpesanan.CellFormatting
        If e.RowIndex >= 0 Then
            If tabelpesanan.Columns(e.ColumnIndex).Name = "Harga" Then
                If IsNumeric(e.Value) Then
                    e.Value = Convert.ToDecimal(e.Value).ToString("N2")
                    e.FormattingApplied = True
                End If
            End If
        End If
    End Sub
End Class