<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAlamat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAlamat))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TextBox2 = New System.Windows.Forms.RichTextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.tabelalamat = New System.Windows.Forms.DataGridView()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonPilih = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.tabelalamat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(24, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(395, 40)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Alamat"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(381, 33)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Isi alamat dengan format yang di tentukan"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(17, 109)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(390, 36)
        Me.TextBox1.TabIndex = 67
        Me.TextBox1.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(17, 161)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(390, 49)
        Me.TextBox2.TabIndex = 68
        Me.TextBox2.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(17, 216)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(390, 22)
        Me.TextBox3.TabIndex = 69
        '
        'tabelalamat
        '
        Me.tabelalamat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelalamat.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.tabelalamat.Location = New System.Drawing.Point(12, 411)
        Me.tabelalamat.Name = "tabelalamat"
        Me.tabelalamat.RowHeadersVisible = False
        Me.tabelalamat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabelalamat.Size = New System.Drawing.Size(395, 186)
        Me.tabelalamat.TabIndex = 70
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.Transparent
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.DarkOrange
        Me.btnTambah.Location = New System.Drawing.Point(151, 249)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(134, 26)
        Me.btnTambah.TabIndex = 71
        Me.btnTambah.Text = "Tambah Alamat"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 72
        Me.PictureBox1.TabStop = False
        '
        'ButtonPilih
        '
        Me.ButtonPilih.BackColor = System.Drawing.Color.Transparent
        Me.ButtonPilih.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPilih.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPilih.ForeColor = System.Drawing.Color.DarkOrange
        Me.ButtonPilih.Location = New System.Drawing.Point(304, 614)
        Me.ButtonPilih.Name = "ButtonPilih"
        Me.ButtonPilih.Size = New System.Drawing.Size(103, 26)
        Me.ButtonPilih.TabIndex = 73
        Me.ButtonPilih.Text = "Pilih"
        Me.ButtonPilih.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(398, 33)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Silahkan pilih alamat anda"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormAlamat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 650)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonPilih)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.tabelalamat)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormAlamat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAlamat"
        CType(Me.tabelalamat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As RichTextBox
    Friend WithEvents TextBox2 As RichTextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents tabelalamat As DataGridView
    Friend WithEvents btnTambah As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonPilih As Button
    Friend WithEvents Label2 As Label
End Class
