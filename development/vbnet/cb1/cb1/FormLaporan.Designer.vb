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
        Me.txtPengeluaran = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPendapatan = New System.Windows.Forms.TextBox()
        Me.s = New System.Windows.Forms.Label()
        Me.LabelKamar = New System.Windows.Forms.Label()
        Me.LabelPengeluaran = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelTransaksi = New System.Windows.Forms.Label()
        Me.DataGridViewLaporan = New System.Windows.Forms.DataGridView()
        Me.LabelKeluar = New System.Windows.Forms.Label()
        Me.BtnUpdateLaporan = New System.Windows.Forms.Button()
        Me.BtnTambahLaporan = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelPelanggan = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelLaporan = New System.Windows.Forms.Label()
        Me.BtnHapusLaporan = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnCariLaporan = New System.Windows.Forms.Button()
        Me.txtLabaBersih = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.dtpCariLaporan = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridViewLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPengeluaran
        '
        Me.txtPengeluaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPengeluaran.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtPengeluaran.Location = New System.Drawing.Point(366, 199)
        Me.txtPengeluaran.Multiline = True
        Me.txtPengeluaran.Name = "txtPengeluaran"
        Me.txtPengeluaran.Size = New System.Drawing.Size(165, 33)
        Me.txtPengeluaran.TabIndex = 94
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(363, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 20)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Pengeluaran"
        '
        'txtPendapatan
        '
        Me.txtPendapatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPendapatan.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtPendapatan.Location = New System.Drawing.Point(595, 125)
        Me.txtPendapatan.Multiline = True
        Me.txtPendapatan.Name = "txtPendapatan"
        Me.txtPendapatan.Size = New System.Drawing.Size(144, 30)
        Me.txtPendapatan.TabIndex = 92
        Me.txtPendapatan.Text = "Enter Jumlah"
        '
        's
        '
        Me.s.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s.Location = New System.Drawing.Point(592, 102)
        Me.s.Name = "s"
        Me.s.Size = New System.Drawing.Size(128, 20)
        Me.s.TabIndex = 90
        Me.s.Text = "Pendapatan"
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
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(592, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Laba Bersih"
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
        'DataGridViewLaporan
        '
        Me.DataGridViewLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewLaporan.Location = New System.Drawing.Point(30, 344)
        Me.DataGridViewLaporan.Name = "DataGridViewLaporan"
        Me.DataGridViewLaporan.Size = New System.Drawing.Size(758, 168)
        Me.DataGridViewLaporan.TabIndex = 87
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
        'BtnUpdateLaporan
        '
        Me.BtnUpdateLaporan.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnUpdateLaporan.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateLaporan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnUpdateLaporan.Location = New System.Drawing.Point(345, 249)
        Me.BtnUpdateLaporan.Name = "BtnUpdateLaporan"
        Me.BtnUpdateLaporan.Size = New System.Drawing.Size(117, 35)
        Me.BtnUpdateLaporan.TabIndex = 84
        Me.BtnUpdateLaporan.Text = "Update"
        Me.BtnUpdateLaporan.UseVisualStyleBackColor = False
        '
        'BtnTambahLaporan
        '
        Me.BtnTambahLaporan.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnTambahLaporan.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambahLaporan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnTambahLaporan.Location = New System.Drawing.Point(30, 249)
        Me.BtnTambahLaporan.Name = "BtnTambahLaporan"
        Me.BtnTambahLaporan.Size = New System.Drawing.Size(126, 40)
        Me.BtnTambahLaporan.TabIndex = 83
        Me.BtnTambahLaporan.Text = "Create"
        Me.BtnTambahLaporan.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(279, 23)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Isi kolom pengisian disamping terlebih dahulu"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Constantia", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 103)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Laporan Bulanan"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cb1.My.Resources.Resources.Logos
        Me.PictureBox1.Location = New System.Drawing.Point(6, 5)
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
        Me.GroupBox1.Location = New System.Drawing.Point(-3, -5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(816, 55)
        Me.GroupBox1.TabIndex = 88
        Me.GroupBox1.TabStop = False
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
        'BtnHapusLaporan
        '
        Me.BtnHapusLaporan.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnHapusLaporan.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapusLaporan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnHapusLaporan.Location = New System.Drawing.Point(622, 249)
        Me.BtnHapusLaporan.Name = "BtnHapusLaporan"
        Me.BtnHapusLaporan.Size = New System.Drawing.Size(117, 35)
        Me.BtnHapusLaporan.TabIndex = 86
        Me.BtnHapusLaporan.Text = "Delete"
        Me.BtnHapusLaporan.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClear.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnClear.Location = New System.Drawing.Point(689, 518)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(99, 34)
        Me.BtnClear.TabIndex = 103
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'BtnCariLaporan
        '
        Me.BtnCariLaporan.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnCariLaporan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCariLaporan.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCariLaporan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCariLaporan.Location = New System.Drawing.Point(671, 293)
        Me.BtnCariLaporan.Name = "BtnCariLaporan"
        Me.BtnCariLaporan.Size = New System.Drawing.Size(117, 35)
        Me.BtnCariLaporan.TabIndex = 101
        Me.BtnCariLaporan.Text = "Cari"
        Me.BtnCariLaporan.UseVisualStyleBackColor = False
        '
        'txtLabaBersih
        '
        Me.txtLabaBersih.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabaBersih.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtLabaBersih.Location = New System.Drawing.Point(595, 193)
        Me.txtLabaBersih.Multiline = True
        Me.txtLabaBersih.Name = "txtLabaBersih"
        Me.txtLabaBersih.Size = New System.Drawing.Size(144, 30)
        Me.txtLabaBersih.TabIndex = 91
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(363, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 20)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Tanggal"
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Location = New System.Drawing.Point(366, 129)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(165, 20)
        Me.dtpTanggal.TabIndex = 105
        '
        'dtpCariLaporan
        '
        Me.dtpCariLaporan.Location = New System.Drawing.Point(491, 298)
        Me.dtpCariLaporan.Name = "dtpCariLaporan"
        Me.dtpCariLaporan.Size = New System.Drawing.Size(165, 20)
        Me.dtpCariLaporan.TabIndex = 106
        '
        'FormLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 574)
        Me.Controls.Add(Me.dtpCariLaporan)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnCariLaporan)
        Me.Controls.Add(Me.txtPengeluaran)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPendapatan)
        Me.Controls.Add(Me.txtLabaBersih)
        Me.Controls.Add(Me.s)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridViewLaporan)
        Me.Controls.Add(Me.BtnUpdateLaporan)
        Me.Controls.Add(Me.BtnTambahLaporan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnHapusLaporan)
        Me.Name = "FormLaporan"
        Me.Text = "Form5"
        CType(Me.DataGridViewLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPengeluaran As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPendapatan As TextBox
    Friend WithEvents s As Label
    Friend WithEvents LabelKamar As Label
    Friend WithEvents LabelPengeluaran As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelTransaksi As Label
    Friend WithEvents DataGridViewLaporan As DataGridView
    Friend WithEvents LabelKeluar As Label
    Friend WithEvents BtnUpdateLaporan As Button
    Friend WithEvents BtnTambahLaporan As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelPelanggan As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelLaporan As Label
    Friend WithEvents BtnHapusLaporan As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnCariLaporan As Button
    Friend WithEvents txtLabaBersih As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents dtpCariLaporan As DateTimePicker
End Class
