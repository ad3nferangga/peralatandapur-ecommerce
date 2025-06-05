Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class FormLihatReview
    Public conn As New MySqlConnection
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public cmd As MySqlCommand
    Public query As String
    Private Sub FormLihatReview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            query = "SELECT ID,Nama_Pembeli, Nama_Barang, Jumlah, Harga, Review FROM lihatreview"
            da = New MySqlDataAdapter(query, conn)
            ds = New DataSet()
            da.Fill(ds, "lihatreview")
            tabelLihatreview.DataSource = ds.Tables("lihatreview")
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub tabelLihatreview_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelLihatreview.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = tabelLihatreview.Rows(e.RowIndex)

            RichTextBox1.Text = If(IsDBNull(row.Cells("Review").Value), "", row.Cells("Review").Value.ToString())
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormPenjual.Show()
        Close()
    End Sub
End Class