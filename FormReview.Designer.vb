<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReview))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxJumlah = New System.Windows.Forms.TextBox()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.btnKirimreview = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxHarga = New System.Windows.Forms.TextBox()
        Me.tabelreview = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxNamaPembeli = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabelreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.DarkOrange
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(12, 495)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 26)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Back"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(-237, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(819, 31)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Review Barang"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(40, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Jumlah"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(40, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 17)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Barang"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(40, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 17)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "ID"
        '
        'TextBoxJumlah
        '
        Me.TextBoxJumlah.AllowDrop = True
        Me.TextBoxJumlah.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.TextBoxJumlah.Location = New System.Drawing.Point(190, 211)
        Me.TextBoxJumlah.Name = "TextBoxJumlah"
        Me.TextBoxJumlah.Size = New System.Drawing.Size(210, 24)
        Me.TextBoxJumlah.TabIndex = 73
        '
        'TextBoxID
        '
        Me.TextBoxID.Enabled = False
        Me.TextBoxID.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.TextBoxID.Location = New System.Drawing.Point(190, 103)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(210, 24)
        Me.TextBoxID.TabIndex = 72
        '
        'TextBoxNama
        '
        Me.TextBoxNama.AllowDrop = True
        Me.TextBoxNama.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.TextBoxNama.Location = New System.Drawing.Point(190, 170)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(210, 24)
        Me.TextBoxNama.TabIndex = 71
        '
        'btnKirimreview
        '
        Me.btnKirimreview.BackColor = System.Drawing.Color.Transparent
        Me.btnKirimreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKirimreview.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKirimreview.ForeColor = System.Drawing.Color.DarkOrange
        Me.btnKirimreview.Location = New System.Drawing.Point(43, 430)
        Me.btnKirimreview.Name = "btnKirimreview"
        Me.btnKirimreview.Size = New System.Drawing.Size(357, 34)
        Me.btnKirimreview.TabIndex = 70
        Me.btnKirimreview.Text = "Kirim Review"
        Me.btnKirimreview.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(43, 356)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(357, 57)
        Me.RichTextBox1.TabIndex = 69
        Me.RichTextBox1.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(43, 336)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 17)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Berikan Review Anda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(40, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Harga"
        '
        'TextBoxHarga
        '
        Me.TextBoxHarga.AllowDrop = True
        Me.TextBoxHarga.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.TextBoxHarga.Location = New System.Drawing.Point(190, 251)
        Me.TextBoxHarga.Name = "TextBoxHarga"
        Me.TextBoxHarga.Size = New System.Drawing.Size(210, 24)
        Me.TextBoxHarga.TabIndex = 77
        '
        'tabelreview
        '
        Me.tabelreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelreview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.tabelreview.Location = New System.Drawing.Point(437, 103)
        Me.tabelreview.Name = "tabelreview"
        Me.tabelreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabelreview.Size = New System.Drawing.Size(452, 310)
        Me.tabelreview.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(40, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 17)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Nama Pembeli"
        '
        'TextBoxNamaPembeli
        '
        Me.TextBoxNamaPembeli.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.TextBoxNamaPembeli.Location = New System.Drawing.Point(190, 133)
        Me.TextBoxNamaPembeli.Name = "TextBoxNamaPembeli"
        Me.TextBoxNamaPembeli.Size = New System.Drawing.Size(210, 24)
        Me.TextBoxNamaPembeli.TabIndex = 80
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(190, 296)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(210, 20)
        Me.DateTimePicker1.TabIndex = 82
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(40, 299)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 17)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Tanggal"
        '
        'FormReview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 533)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxNamaPembeli)
        Me.Controls.Add(Me.tabelreview)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxHarga)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBoxJumlah)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.btnKirimreview)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormReview"
        Me.Text = "FormReview"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabelreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxJumlah As TextBox
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents btnKirimreview As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxHarga As TextBox
    Friend WithEvents tabelreview As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxNamaPembeli As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
End Class
