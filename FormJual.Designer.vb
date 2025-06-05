<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJual
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormJual))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonKosongkan = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonUbah = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.tabelstok = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxHargaJual = New System.Windows.Forms.TextBox()
        Me.TextBoxStok = New System.Windows.Forms.TextBox()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabelstok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(1, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(213, 491)
        Me.Panel1.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Orange
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(36, 421)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 33)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 119)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 163)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'ButtonKosongkan
        '
        Me.ButtonKosongkan.BackColor = System.Drawing.Color.Transparent
        Me.ButtonKosongkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonKosongkan.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonKosongkan.ForeColor = System.Drawing.Color.DarkOrange
        Me.ButtonKosongkan.Location = New System.Drawing.Point(388, 391)
        Me.ButtonKosongkan.Name = "ButtonKosongkan"
        Me.ButtonKosongkan.Size = New System.Drawing.Size(112, 36)
        Me.ButtonKosongkan.TabIndex = 38
        Me.ButtonKosongkan.Text = "Kosongkan"
        Me.ButtonKosongkan.UseVisualStyleBackColor = False
        '
        'ButtonHapus
        '
        Me.ButtonHapus.BackColor = System.Drawing.Color.Transparent
        Me.ButtonHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHapus.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHapus.ForeColor = System.Drawing.Color.DarkOrange
        Me.ButtonHapus.Location = New System.Drawing.Point(253, 391)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(116, 36)
        Me.ButtonHapus.TabIndex = 37
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = False
        '
        'ButtonUbah
        '
        Me.ButtonUbah.BackColor = System.Drawing.Color.Transparent
        Me.ButtonUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUbah.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUbah.ForeColor = System.Drawing.Color.DarkOrange
        Me.ButtonUbah.Location = New System.Drawing.Point(388, 334)
        Me.ButtonUbah.Name = "ButtonUbah"
        Me.ButtonUbah.Size = New System.Drawing.Size(112, 39)
        Me.ButtonUbah.TabIndex = 36
        Me.ButtonUbah.Text = "Ubah"
        Me.ButtonUbah.UseVisualStyleBackColor = False
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.Color.Transparent
        Me.btntambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntambah.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah.ForeColor = System.Drawing.Color.DarkOrange
        Me.btntambah.Location = New System.Drawing.Point(253, 334)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(116, 39)
        Me.btntambah.TabIndex = 27
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'tabelstok
        '
        Me.tabelstok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelstok.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.tabelstok.EnableHeadersVisualStyles = False
        Me.tabelstok.Location = New System.Drawing.Point(549, 107)
        Me.tabelstok.Name = "tabelstok"
        Me.tabelstok.RowHeadersVisible = False
        Me.tabelstok.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.tabelstok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabelstok.Size = New System.Drawing.Size(464, 323)
        Me.tabelstok.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(223, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(799, 27)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Penjualan"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(228, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(794, 27)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Silahkan masukkan peralatan dapur yang ingin di jual"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(239, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 17)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Harga Jual"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(239, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Stok"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(239, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(239, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 17)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "ID"
        '
        'TextBoxHargaJual
        '
        Me.TextBoxHargaJual.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.TextBoxHargaJual.Location = New System.Drawing.Point(333, 281)
        Me.TextBoxHargaJual.Name = "TextBoxHargaJual"
        Me.TextBoxHargaJual.Size = New System.Drawing.Size(210, 24)
        Me.TextBoxHargaJual.TabIndex = 49
        '
        'TextBoxStok
        '
        Me.TextBoxStok.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.TextBoxStok.Location = New System.Drawing.Point(333, 192)
        Me.TextBoxStok.Name = "TextBoxStok"
        Me.TextBoxStok.Size = New System.Drawing.Size(210, 24)
        Me.TextBoxStok.TabIndex = 48
        '
        'TextBoxID
        '
        Me.TextBoxID.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.TextBoxID.Location = New System.Drawing.Point(333, 107)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(210, 24)
        Me.TextBoxID.TabIndex = 47
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.TextBoxNama.Location = New System.Drawing.Point(333, 150)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(210, 24)
        Me.TextBoxNama.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(239, 235)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 17)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Kategori"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Peralatan Memasak", "Peralatan Memotong", "Peralatan Penyajian", "Lainnya"})
        Me.ComboBox1.Location = New System.Drawing.Point(333, 235)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(210, 21)
        Me.ComboBox1.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(231, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(791, 31)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Penjualan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormJual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 461)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxHargaJual)
        Me.Controls.Add(Me.TextBoxStok)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tabelstok)
        Me.Controls.Add(Me.ButtonKosongkan)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ButtonUbah)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormJual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormJual"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabelstok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonKosongkan As Button
    Friend WithEvents ButtonHapus As Button
    Friend WithEvents ButtonUbah As Button
    Friend WithEvents btntambah As Button
    Friend WithEvents tabelstok As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxHargaJual As TextBox
    Friend WithEvents TextBoxStok As TextBox
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
End Class
