Imports MySql.Data.MySqlClient

Public Class FormAlamat
    Public conn As New MySqlConnection
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public cmd As MySqlCommand
    Public query As String

    Private Sub FormAlamat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        TampilData()
        SetPlaceholder()

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
            query = "SELECT ID, Alamat FROM alamatpembeli"
            da = New MySqlDataAdapter(query, conn)
            ds = New DataSet()
            da.Fill(ds, "alamatpembeli")
            tabelalamat.DataSource = ds.Tables("alamatpembeli")
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim alamat As String = TextBox1.Text & ", " & TextBox2.Text & ", " & TextBox3.Text

        MessageBox.Show("Alamat lengkap: " & alamat)

        Try
            Koneksi()
            query = "INSERT INTO alamatpembeli (Alamat) VALUES (@alamat)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@alamat", alamat)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil ditambahkan.")
            TampilData() ' Update tampilan data
        Catch ex As Exception
            MessageBox.Show("Gagal menambahkan data: " & ex.Message)
        Finally
            conn.Close()
        End Try
        Clear()
    End Sub
    Private Sub SetPlaceholder()
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            TextBox1.Text = "Provinsi, Kota, Kecamatan, Kode Pos"
            TextBox1.ForeColor = Color.Gray
        End If

        If String.IsNullOrWhiteSpace(TextBox2.Text) Then
            TextBox2.Text = "Nama jalan, Gedung, No. Rumah"
            TextBox2.ForeColor = Color.Gray
        End If

        If String.IsNullOrWhiteSpace(TextBox3.Text) Then
            TextBox3.Text = "Detail lainnya"
            TextBox3.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        If TextBox1.Text = "Provinsi, Kota, Kecamatan, Kode Pos" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            TextBox1.Text = "Provinsi, Kota, Kecamatan, Kode Pos"
            TextBox1.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        If TextBox2.Text = "Nama jalan, Gedung, No. Rumah" Then
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If String.IsNullOrWhiteSpace(TextBox2.Text) Then
            TextBox2.Text = "Nama jalan, Gedung, No. Rumah"
            TextBox2.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBox3_Enter(sender As Object, e As EventArgs) Handles TextBox3.Enter
        If TextBox3.Text = "Detail lainnya" Then
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles TextBox3.Leave
        If String.IsNullOrWhiteSpace(TextBox3.Text) Then
            TextBox3.Text = "Detail lainnya"
            TextBox3.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub ButtonPilih_Click(sender As Object, e As EventArgs) Handles ButtonPilih.Click
        If tabelalamat.SelectedRows.Count > 0 Then
            Dim alamatTerpilih As String = tabelalamat.SelectedRows(0).Cells("Alamat").Value.ToString()

            For Each form As Form In Application.OpenForms
                If TypeOf form Is FormCheckout Then
                    Dim formCheckout As FormCheckout = CType(form, FormCheckout)
                    formCheckout.Alamat = alamatTerpilih
                    Exit For
                End If
            Next
        Else
            MessageBox.Show("Silakan pilih alamat terlebih dahulu.")
        End If
        Close()
    End Sub
End Class