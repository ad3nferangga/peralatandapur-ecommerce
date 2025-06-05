<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLaporan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLaporan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LabelTotalKeseluruhan = New System.Windows.Forms.Label()
        Me.Buttonlihat = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBoxBulan = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerBulanTahun = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerTahun = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerTanggal = New System.Windows.Forms.DateTimePicker()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(331, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(586, 31)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Laporan Penjualan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(236, 200)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.DataGridView1.Size = New System.Drawing.Size(770, 236)
        Me.DataGridView1.TabIndex = 30
        '
        'LabelTotalKeseluruhan
        '
        Me.LabelTotalKeseluruhan.AutoSize = True
        Me.LabelTotalKeseluruhan.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalKeseluruhan.Location = New System.Drawing.Point(818, 447)
        Me.LabelTotalKeseluruhan.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTotalKeseluruhan.Name = "LabelTotalKeseluruhan"
        Me.LabelTotalKeseluruhan.Size = New System.Drawing.Size(65, 23)
        Me.LabelTotalKeseluruhan.TabIndex = 34
        Me.LabelTotalKeseluruhan.Text = "Total"
        '
        'Buttonlihat
        '
        Me.Buttonlihat.BackColor = System.Drawing.Color.Transparent
        Me.Buttonlihat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttonlihat.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonlihat.ForeColor = System.Drawing.Color.Orange
        Me.Buttonlihat.Location = New System.Drawing.Point(242, 112)
        Me.Buttonlihat.Name = "Buttonlihat"
        Me.Buttonlihat.Size = New System.Drawing.Size(185, 26)
        Me.Buttonlihat.TabIndex = 55
        Me.Buttonlihat.Text = "Cetak"
        Me.Buttonlihat.UseVisualStyleBackColor = False
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
        Me.Button2.Location = New System.Drawing.Point(56, 468)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 33)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 152)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 163)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(213, 529)
        Me.Panel1.TabIndex = 57
        '
        'ComboBoxBulan
        '
        Me.ComboBoxBulan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxBulan.FormattingEnabled = True
        Me.ComboBoxBulan.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        Me.ComboBoxBulan.Location = New System.Drawing.Point(336, 39)
        Me.ComboBoxBulan.Name = "ComboBoxBulan"
        Me.ComboBoxBulan.Size = New System.Drawing.Size(121, 27)
        Me.ComboBoxBulan.TabIndex = 65
        '
        'DateTimePickerBulanTahun
        '
        Me.DateTimePickerBulanTahun.CustomFormat = "yyyy"
        Me.DateTimePickerBulanTahun.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerBulanTahun.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerBulanTahun.Location = New System.Drawing.Point(528, 40)
        Me.DateTimePickerBulanTahun.Name = "DateTimePickerBulanTahun"
        Me.DateTimePickerBulanTahun.ShowUpDown = True
        Me.DateTimePickerBulanTahun.Size = New System.Drawing.Size(117, 26)
        Me.DateTimePickerBulanTahun.TabIndex = 64
        '
        'DateTimePickerTahun
        '
        Me.DateTimePickerTahun.CustomFormat = "yyyy"
        Me.DateTimePickerTahun.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerTahun.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerTahun.Location = New System.Drawing.Point(336, 70)
        Me.DateTimePickerTahun.Name = "DateTimePickerTahun"
        Me.DateTimePickerTahun.ShowUpDown = True
        Me.DateTimePickerTahun.Size = New System.Drawing.Size(121, 26)
        Me.DateTimePickerTahun.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(477, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 19)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Tahun"
        '
        'DateTimePickerTanggal
        '
        Me.DateTimePickerTanggal.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePickerTanggal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerTanggal.Location = New System.Drawing.Point(336, 11)
        Me.DateTimePickerTanggal.Name = "DateTimePickerTanggal"
        Me.DateTimePickerTanggal.Size = New System.Drawing.Size(121, 26)
        Me.DateTimePickerTanggal.TabIndex = 61
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.Color.White
        Me.RadioButton3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RadioButton3.Location = New System.Drawing.Point(242, 70)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(63, 23)
        Me.RadioButton3.TabIndex = 60
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Tahun"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.White
        Me.RadioButton2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RadioButton2.Location = New System.Drawing.Point(242, 39)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(61, 23)
        Me.RadioButton2.TabIndex = 59
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Bulan"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.White
        Me.RadioButton1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RadioButton1.Location = New System.Drawing.Point(242, 11)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(73, 23)
        Me.RadioButton1.TabIndex = 58
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Tanggal"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(477, 443)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(336, 31)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Total Keseluruhan Penjualan:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1025, 513)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxBulan)
        Me.Controls.Add(Me.DateTimePickerBulanTahun)
        Me.Controls.Add(Me.DateTimePickerTahun)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePickerTanggal)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Buttonlihat)
        Me.Controls.Add(Me.LabelTotalKeseluruhan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormLaporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLaporan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LabelTotalKeseluruhan As Label
    Friend WithEvents Buttonlihat As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBoxBulan As ComboBox
    Friend WithEvents DateTimePickerBulanTahun As DateTimePicker
    Friend WithEvents DateTimePickerTahun As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePickerTanggal As DateTimePicker
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label3 As Label
End Class
