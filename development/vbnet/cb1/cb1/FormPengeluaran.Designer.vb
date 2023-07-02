<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPengeluaran
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
        Me.txtCariPengeluaran = New System.Windows.Forms.TextBox()
        Me.BtnCariPengeluaran = New System.Windows.Forms.Button()
        Me.txtJumlahPengeluaran = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtKeteranganPengeluaran = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewPengeluaran = New System.Windows.Forms.DataGridView()
        Me.BtnHapusPengeluaran = New System.Windows.Forms.Button()
        Me.BtnUpdatePengeluaran = New System.Windows.Forms.Button()
        Me.BtnTambahPengeluaran = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelPelanggan = New System.Windows.Forms.Label()
        Me.LabelKeluar = New System.Windows.Forms.Label()
        Me.LabelTransaksi = New System.Windows.Forms.Label()
        Me.LabelLaporan = New System.Windows.Forms.Label()
        Me.LabelKamar = New System.Windows.Forms.Label()
        Me.LabelPengeluaran = New System.Windows.Forms.Label()
        Me.BtnClear = New System.Windows.Forms.Button()
        CType(Me.DataGridViewPengeluaran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCariPengeluaran
        '
        Me.txtCariPengeluaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariPengeluaran.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtCariPengeluaran.Location = New System.Drawing.Point(503, 238)
        Me.txtCariPengeluaran.Multiline = True
        Me.txtCariPengeluaran.Name = "txtCariPengeluaran"
        Me.txtCariPengeluaran.Size = New System.Drawing.Size(144, 30)
        Me.txtCariPengeluaran.TabIndex = 97
        Me.txtCariPengeluaran.Text = "Enter Name"
        '
        'BtnCariPengeluaran
        '
        Me.BtnCariPengeluaran.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnCariPengeluaran.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCariPengeluaran.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCariPengeluaran.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCariPengeluaran.Location = New System.Drawing.Point(657, 238)
        Me.BtnCariPengeluaran.Name = "BtnCariPengeluaran"
        Me.BtnCariPengeluaran.Size = New System.Drawing.Size(117, 35)
        Me.BtnCariPengeluaran.TabIndex = 96
        Me.BtnCariPengeluaran.Text = "Cari"
        Me.BtnCariPengeluaran.UseVisualStyleBackColor = False
        '
        'txtJumlahPengeluaran
        '
        Me.txtJumlahPengeluaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlahPengeluaran.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtJumlahPengeluaran.Location = New System.Drawing.Point(494, 122)
        Me.txtJumlahPengeluaran.Multiline = True
        Me.txtJumlahPengeluaran.Name = "txtJumlahPengeluaran"
        Me.txtJumlahPengeluaran.Size = New System.Drawing.Size(144, 30)
        Me.txtJumlahPengeluaran.TabIndex = 95
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(491, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 20)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "Jumlah"
        '
        'txtKeteranganPengeluaran
        '
        Me.txtKeteranganPengeluaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeteranganPengeluaran.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtKeteranganPengeluaran.Location = New System.Drawing.Point(340, 122)
        Me.txtKeteranganPengeluaran.Multiline = True
        Me.txtKeteranganPengeluaran.Name = "txtKeteranganPengeluaran"
        Me.txtKeteranganPengeluaran.Size = New System.Drawing.Size(144, 30)
        Me.txtKeteranganPengeluaran.TabIndex = 93
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(337, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Keterangan"
        '
        'DataGridViewPengeluaran
        '
        Me.DataGridViewPengeluaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPengeluaran.Location = New System.Drawing.Point(22, 288)
        Me.DataGridViewPengeluaran.Name = "DataGridViewPengeluaran"
        Me.DataGridViewPengeluaran.Size = New System.Drawing.Size(752, 198)
        Me.DataGridViewPengeluaran.TabIndex = 90
        '
        'BtnHapusPengeluaran
        '
        Me.BtnHapusPengeluaran.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnHapusPengeluaran.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapusPengeluaran.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnHapusPengeluaran.Location = New System.Drawing.Point(657, 138)
        Me.BtnHapusPengeluaran.Name = "BtnHapusPengeluaran"
        Me.BtnHapusPengeluaran.Size = New System.Drawing.Size(117, 35)
        Me.BtnHapusPengeluaran.TabIndex = 89
        Me.BtnHapusPengeluaran.Text = "Delete"
        Me.BtnHapusPengeluaran.UseVisualStyleBackColor = False
        '
        'BtnUpdatePengeluaran
        '
        Me.BtnUpdatePengeluaran.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnUpdatePengeluaran.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdatePengeluaran.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnUpdatePengeluaran.Location = New System.Drawing.Point(657, 84)
        Me.BtnUpdatePengeluaran.Name = "BtnUpdatePengeluaran"
        Me.BtnUpdatePengeluaran.Size = New System.Drawing.Size(117, 35)
        Me.BtnUpdatePengeluaran.TabIndex = 88
        Me.BtnUpdatePengeluaran.Text = "Update"
        Me.BtnUpdatePengeluaran.UseVisualStyleBackColor = False
        '
        'BtnTambahPengeluaran
        '
        Me.BtnTambahPengeluaran.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnTambahPengeluaran.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambahPengeluaran.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnTambahPengeluaran.Location = New System.Drawing.Point(22, 204)
        Me.BtnTambahPengeluaran.Name = "BtnTambahPengeluaran"
        Me.BtnTambahPengeluaran.Size = New System.Drawing.Size(126, 40)
        Me.BtnTambahPengeluaran.TabIndex = 87
        Me.BtnTambahPengeluaran.Text = "Create"
        Me.BtnTambahPengeluaran.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(279, 23)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Isi kolom pengisian disamping terlebih dahulu"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Constantia", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 103)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Manajemen Pengeluaran"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.LabelPelanggan)
        Me.GroupBox1.Controls.Add(Me.LabelKeluar)
        Me.GroupBox1.Controls.Add(Me.LabelTransaksi)
        Me.GroupBox1.Controls.Add(Me.LabelLaporan)
        Me.GroupBox1.Controls.Add(Me.LabelKamar)
        Me.GroupBox1.Controls.Add(Me.LabelPengeluaran)
        Me.GroupBox1.Location = New System.Drawing.Point(0, -5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(816, 55)
        Me.GroupBox1.TabIndex = 99
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cb1.My.Resources.Resources.Logos
        Me.PictureBox1.Location = New System.Drawing.Point(12, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(118, 50)
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'LabelPelanggan
        '
        Me.LabelPelanggan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelPelanggan.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPelanggan.Location = New System.Drawing.Point(337, 16)
        Me.LabelPelanggan.Name = "LabelPelanggan"
        Me.LabelPelanggan.Size = New System.Drawing.Size(74, 20)
        Me.LabelPelanggan.TabIndex = 35
        Me.LabelPelanggan.Text = "Pelanggan"
        '
        'LabelKeluar
        '
        Me.LabelKeluar.BackColor = System.Drawing.SystemColors.Control
        Me.LabelKeluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelKeluar.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelKeluar.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.LabelKeluar.Location = New System.Drawing.Point(752, 16)
        Me.LabelKeluar.Name = "LabelKeluar"
        Me.LabelKeluar.Size = New System.Drawing.Size(58, 20)
        Me.LabelKeluar.TabIndex = 39
        Me.LabelKeluar.Text = "Keluar"
        '
        'LabelTransaksi
        '
        Me.LabelTransaksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelTransaksi.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTransaksi.Location = New System.Drawing.Point(417, 16)
        Me.LabelTransaksi.Name = "LabelTransaksi"
        Me.LabelTransaksi.Size = New System.Drawing.Size(68, 20)
        Me.LabelTransaksi.TabIndex = 34
        Me.LabelTransaksi.Text = "Transaksi"
        '
        'LabelLaporan
        '
        Me.LabelLaporan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelLaporan.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLaporan.Location = New System.Drawing.Point(642, 16)
        Me.LabelLaporan.Name = "LabelLaporan"
        Me.LabelLaporan.Size = New System.Drawing.Size(116, 20)
        Me.LabelLaporan.TabIndex = 38
        Me.LabelLaporan.Text = "Laporan Bulanan"
        '
        'LabelKamar
        '
        Me.LabelKamar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelKamar.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelKamar.Location = New System.Drawing.Point(491, 16)
        Me.LabelKamar.Name = "LabelKamar"
        Me.LabelKamar.Size = New System.Drawing.Size(58, 20)
        Me.LabelKamar.TabIndex = 36
        Me.LabelKamar.Text = "Kamar"
        '
        'LabelPengeluaran
        '
        Me.LabelPengeluaran.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelPengeluaran.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPengeluaran.Location = New System.Drawing.Point(555, 16)
        Me.LabelPengeluaran.Name = "LabelPengeluaran"
        Me.LabelPengeluaran.Size = New System.Drawing.Size(83, 20)
        Me.LabelPengeluaran.TabIndex = 37
        Me.LabelPengeluaran.Text = "Pengeluaran"
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClear.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnClear.Location = New System.Drawing.Point(675, 492)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(99, 34)
        Me.BtnClear.TabIndex = 100
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'FormPengeluaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 538)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtCariPengeluaran)
        Me.Controls.Add(Me.BtnCariPengeluaran)
        Me.Controls.Add(Me.txtJumlahPengeluaran)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtKeteranganPengeluaran)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridViewPengeluaran)
        Me.Controls.Add(Me.BtnHapusPengeluaran)
        Me.Controls.Add(Me.BtnUpdatePengeluaran)
        Me.Controls.Add(Me.BtnTambahPengeluaran)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPengeluaran"
        Me.Text = "Form1"
        CType(Me.DataGridViewPengeluaran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCariPengeluaran As TextBox
    Friend WithEvents BtnCariPengeluaran As Button
    Friend WithEvents txtJumlahPengeluaran As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtKeteranganPengeluaran As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewPengeluaran As DataGridView
    Friend WithEvents BtnHapusPengeluaran As Button
    Friend WithEvents BtnUpdatePengeluaran As Button
    Friend WithEvents BtnTambahPengeluaran As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelPelanggan As Label
    Friend WithEvents LabelKeluar As Label
    Friend WithEvents LabelTransaksi As Label
    Friend WithEvents LabelLaporan As Label
    Friend WithEvents LabelKamar As Label
    Friend WithEvents LabelPengeluaran As Label
    Friend WithEvents BtnClear As Button
End Class
