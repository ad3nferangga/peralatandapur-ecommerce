Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class FormReview
    Public conn As New MySqlConnection
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public cmd As MySqlCommand
    Public query As String

    Private Sub FormReview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            query = "SELECT ID, Nama_Barang, Jumlah, Harga FROM review"
            da = New MySqlDataAdapter(query, conn)
            ds = New DataSet()
            da.Fill(ds, "review")
            tabelreview.DataSource = ds.Tables("review")
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Clear()
        TextBoxID.Clear()
        TextBoxNama.Clear()
        TextBoxHarga.Clear()
        TextBoxJumlah.Clear()
        TextBoxNamaPembeli.Clear()
        RichTextBox1.Clear()
    End Sub

    ' Menambahkan event CellClick untuk mengisi data ke form
    Private Sub tabelreview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelreview.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = tabelreview.Rows(e.RowIndex)

                ' Memasukkan data ke textbox
                TextBoxID.Text = If(IsDBNull(row.Cells("ID").Value), "", row.Cells("ID").Value.ToString())
                TextBoxNama.Text = If(IsDBNull(row.Cells("Nama_Barang").Value), "", row.Cells("Nama_Barang").Value.ToString())
                TextBoxJumlah.Text = If(IsDBNull(row.Cells("Jumlah").Value), "", row.Cells("Jumlah").Value.ToString())
                TextBoxHarga.Text = If(IsDBNull(row.Cells("Harga").Value), "", row.Cells("Harga").Value.ToString())
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi error saat memilih data: " & ex.Message)
        End Try
    End Sub

    Private Sub btnKirimreview_Click(sender As Object, e As EventArgs) Handles btnKirimreview.Click
        Try
            Koneksi()

            If String.IsNullOrEmpty(TextBoxID.Text) OrElse
               String.IsNullOrEmpty(TextBoxNamaPembeli.Text) OrElse
               String.IsNullOrEmpty(TextBoxNama.Text) OrElse
               String.IsNullOrEmpty(TextBoxJumlah.Text) OrElse
               String.IsNullOrEmpty(TextBoxHarga.Text) OrElse
               String.IsNullOrEmpty(RichTextBox1.Text) Then
                MessageBox.Show("Harap isi semua kolom sebelum mengirim review.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim id As Integer = Convert.ToInt32(TextBoxID.Text)
            Dim namaPembeli As String = TextBoxNamaPembeli.Text
            Dim namaBarang As String = TextBoxNama.Text
            Dim jumlah As Integer = Convert.ToInt32(TextBoxJumlah.Text)
            Dim harga As Decimal = Convert.ToDecimal(TextBoxHarga.Text)
            Dim total As Decimal = jumlah * harga
            Dim tanggal As String = DateTime.Now.ToString("yyyy-MM-dd") ' Format sesuai dengan MySQL DATE
            Dim review As String = RichTextBox1.Text

            Dim transaction As MySqlTransaction = conn.BeginTransaction()

            Try
                query = "INSERT INTO lihatreview (ID, Nama_Pembeli, Nama_Barang, Jumlah, Harga, Review) " &
                    "VALUES (@ID, @Nama_Pembeli, @Nama_Barang, @Jumlah, @Harga, @Review)"
                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", id)
                cmd.Parameters.AddWithValue("@Nama_Pembeli", namaPembeli)
                cmd.Parameters.AddWithValue("@Nama_Barang", namaBarang)
                cmd.Parameters.AddWithValue("@Jumlah", jumlah)
                cmd.Parameters.AddWithValue("@Harga", harga)
                cmd.Parameters.AddWithValue("@Review", review)
                cmd.ExecuteNonQuery()

                query = "INSERT INTO laporan (ID, Nama_Barang, Terjual, Total, Tanggal) " &
                    "VALUES (@ID, @Nama_Barang, @Terjual, @Total, @Tanggal)"
                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", id)
                cmd.Parameters.AddWithValue("@Nama_Barang", namaBarang)
                cmd.Parameters.AddWithValue("@Terjual", jumlah)
                cmd.Parameters.AddWithValue("@Total", total)
                cmd.Parameters.AddWithValue("@Tanggal", tanggal) ' Masukkan tanggal dengan format yang sesuai
                cmd.ExecuteNonQuery()

                query = "DELETE FROM review WHERE ID = @ID"
                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", id)
                cmd.ExecuteNonQuery()

                transaction.Commit()
                MessageBox.Show("Review berhasil Dikirim.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Clear()
                TampilData()
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("Gagal memindahkan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormDashboard.Show()
        Close()
    End Sub
End Class
