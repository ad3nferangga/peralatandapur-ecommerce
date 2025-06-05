Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class FormLaporan
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As New MySqlDataAdapter

    Dim connectionString As String = "Server=localhost;Database=peralatandapur;User Id=root;Password=;"

    ' Inisialisasi koneksi saat form dimuat
    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection(connectionString)
        LoadData() ' Panggil fungsi LoadData saat form dimuat
    End Sub

    ' Fungsi untuk memuat data ke dalam DataGridView
    Private Sub LoadData()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim query As String = "SELECT ID, Nama_Barang, Terjual, Total, Tanggal FROM laporan"
            Dim tbl As New DataTable()
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(tbl)

            ' Menampilkan data di DataGridView
            DataGridView1.DataSource = tbl

            ' Hitung total setelah data dimuat
            CalculateTotalFromDataGrid()
        Catch ex As Exception
            MsgBox("Gagal memuat data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Fungsi untuk memuat data berdasarkan filter ke dalam DataGridView
    Private Sub LoadFilteredData()
        Dim filter As String = GetFilter()
        Dim query As String = "SELECT ID, Nama_Barang, Terjual, Total, Tanggal FROM laporan" & filter

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim tbl As New DataTable()
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(tbl)

            DataGridView1.DataSource = tbl

            ' Hitung total setelah data difilter
            CalculateTotalFromDataGrid()
        Catch ex As Exception
            MsgBox("Gagal memuat data: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Fungsi untuk mendapatkan filter SQL berdasarkan pilihan user
    Private Function GetFilter() As String
        Dim filter As String = ""

        If RadioButton1.Checked Then
            ' Filter berdasarkan tanggal
            Dim selectedDate As String = DateTimePickerTanggal.Value.ToString("yyyy-MM-dd")
            filter = " WHERE DATE(tanggal) = '" & selectedDate & "'"
        ElseIf RadioButton2.Checked Then
            ' Filter berdasarkan bulan dan tahun
            Dim selectedMonth As String = (ComboBoxBulan.SelectedIndex + 1).ToString("D2")
            Dim selectedYear As String = DateTimePickerBulanTahun.Value.ToString("yyyy")
            filter = " WHERE DATE_FORMAT(tanggal, '%Y-%m') = '" & selectedYear & "-" & selectedMonth & "'"
        ElseIf RadioButton3.Checked Then
            ' Filter berdasarkan tahun
            Dim selectedYear As String = DateTimePickerTahun.Value.ToString("yyyy")
            filter = " WHERE DATE_FORMAT(tanggal, '%Y') = '" & selectedYear & "'"
        End If

        Return filter
    End Function

    ' Fungsi untuk menghitung total keseluruhan dari kolom "Total" di DataGridView
    Private Sub CalculateTotalFromDataGrid()
        Dim totalKeseluruhan As Decimal = 0

        ' Iterasi melalui semua baris di DataGridView
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim value As Object = row.Cells("Total").Value
                If IsNumeric(value) Then
                    totalKeseluruhan += Convert.ToDecimal(value)
                End If
            End If
        Next

        ' Menampilkan total di label
        LabelTotalKeseluruhan.Text = "Rp " & totalKeseluruhan.ToString("N2")
    End Sub

    ' Event handler untuk RadioButton
    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) _
        Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged
        If CType(sender, RadioButton).Checked Then
            LoadFilteredData()
        End If
    End Sub

    ' Event handler untuk tombol cetak laporan
    Private Sub Buttonlihat_Click(sender As Object, e As EventArgs) Handles Buttonlihat.Click
        Dim filter As String = GetFilter()
        Dim query As String = "SELECT ID, Nama_Barang, Terjual, Total, Tanggal FROM laporan" & filter

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim tbl As New DataTable()
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(tbl)

            Dim cetakForm As New Cetak
            cetakForm.ReportViewer1.LocalReport.ReportPath = "D:\Semester 3\Basis data\PeralatanDapur\PeralatanDapur\Report1.rdlc"
            cetakForm.ReportViewer1.LocalReport.DataSources.Clear()
            cetakForm.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", tbl))

            cetakForm.ReportViewer1.RefreshReport()
            cetakForm.ShowDialog()
        Catch ex As Exception
            MsgBox("Gagal mencetak laporan: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Event handler untuk tombol kembali
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormPenjual.Show()
        Close()
    End Sub
End Class
