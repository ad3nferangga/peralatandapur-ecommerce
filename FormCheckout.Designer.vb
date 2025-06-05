<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCheckout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCheckout))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabelCheckout = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalHarga = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnPesan = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxNoTelp = New System.Windows.Forms.TextBox()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.TextBoxNamapembeli = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnTambahAlamat = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabelCheckout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(12, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 17)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Alamat Pengiriman"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(79, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 31)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Checkout"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabelCheckout
        '
        Me.tabelCheckout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelCheckout.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.tabelCheckout.Enabled = False
        Me.tabelCheckout.Location = New System.Drawing.Point(402, 108)
        Me.tabelCheckout.Name = "tabelCheckout"
        Me.tabelCheckout.RowHeadersVisible = False
        Me.tabelCheckout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabelCheckout.Size = New System.Drawing.Size(408, 243)
        Me.tabelCheckout.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(399, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 17)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Produk Dipesan"
        '
        'txtTotalHarga
        '
        Me.txtTotalHarga.Location = New System.Drawing.Point(520, 377)
        Me.txtTotalHarga.Name = "txtTotalHarga"
        Me.txtTotalHarga.ReadOnly = True
        Me.txtTotalHarga.Size = New System.Drawing.Size(129, 20)
        Me.txtTotalHarga.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(405, 379)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 17)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Total Harga :"
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
        Me.Button2.Location = New System.Drawing.Point(12, 423)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 26)
        Me.Button2.TabIndex = 57
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnPesan
        '
        Me.btnPesan.BackColor = System.Drawing.Color.Transparent
        Me.btnPesan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesan.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesan.ForeColor = System.Drawing.Color.DarkOrange
        Me.btnPesan.Location = New System.Drawing.Point(15, 329)
        Me.btnPesan.Name = "btnPesan"
        Me.btnPesan.Size = New System.Drawing.Size(354, 34)
        Me.btnPesan.TabIndex = 58
        Me.btnPesan.Text = "Buat Pesanan"
        Me.btnPesan.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(18, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 17)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "No. Telp"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(18, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 17)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Nama Pembeli"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(18, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 17)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "ID"
        '
        'TextBoxNoTelp
        '
        Me.TextBoxNoTelp.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.TextBoxNoTelp.Location = New System.Drawing.Point(159, 181)
        Me.TextBoxNoTelp.Name = "TextBoxNoTelp"
        Me.TextBoxNoTelp.Size = New System.Drawing.Size(210, 24)
        Me.TextBoxNoTelp.TabIndex = 61
        '
        'TextBoxID
        '
        Me.TextBoxID.Enabled = False
        Me.TextBoxID.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.TextBoxID.Location = New System.Drawing.Point(159, 105)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(210, 24)
        Me.TextBoxID.TabIndex = 60
        '
        'TextBoxNamapembeli
        '
        Me.TextBoxNamapembeli.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.TextBoxNamapembeli.Location = New System.Drawing.Point(159, 137)
        Me.TextBoxNamapembeli.Name = "TextBoxNamapembeli"
        Me.TextBoxNamapembeli.Size = New System.Drawing.Size(210, 24)
        Me.TextBoxNamapembeli.TabIndex = 59
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.DarkOrange
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(654, 423)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 26)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "Back To Dashboard"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnTambahAlamat
        '
        Me.btnTambahAlamat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTambahAlamat.FlatAppearance.BorderSize = 0
        Me.btnTambahAlamat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnTambahAlamat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnTambahAlamat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambahAlamat.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahAlamat.ForeColor = System.Drawing.Color.DarkOrange
        Me.btnTambahAlamat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambahAlamat.Location = New System.Drawing.Point(328, 260)
        Me.btnTambahAlamat.Name = "btnTambahAlamat"
        Me.btnTambahAlamat.Size = New System.Drawing.Size(68, 25)
        Me.btnTambahAlamat.TabIndex = 71
        Me.btnTambahAlamat.Text = "Pilih"
        Me.btnTambahAlamat.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Enabled = False
        Me.RichTextBox1.Location = New System.Drawing.Point(15, 242)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(307, 68)
        Me.RichTextBox1.TabIndex = 72
        Me.RichTextBox1.Text = ""
        '
        'FormCheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 461)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.btnTambahAlamat)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBoxNoTelp)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.TextBoxNamapembeli)
        Me.Controls.Add(Me.btnPesan)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtTotalHarga)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tabelCheckout)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "FormCheckout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCheckout"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabelCheckout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tabelCheckout As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotalHarga As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnPesan As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxNoTelp As TextBox
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents TextBoxNamapembeli As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnTambahAlamat As Button
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
