<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelPelanggan = New System.Windows.Forms.Label()
        Me.LabelKeluar = New System.Windows.Forms.Label()
        Me.LabelTransaksi = New System.Windows.Forms.Label()
        Me.LabelLaporan = New System.Windows.Forms.Label()
        Me.LabelKamar = New System.Windows.Forms.Label()
        Me.LabelPengeluaran = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewTransaksi = New System.Windows.Forms.DataGridView()
        Me.btnHapusTransaksi = New System.Windows.Forms.Button()
        Me.btnUpdateTransaksi = New System.Windows.Forms.Button()
        Me.txtJumlahTamu = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTambahTransaksi = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalHarga = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCariTransaksi = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.dtpCheckOut = New System.Windows.Forms.DateTimePicker()
        Me.dtpTanggalPesan = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxNamaPelanggan = New System.Windows.Forms.ComboBox()
        Me.ComboBoxNamaKamar = New System.Windows.Forms.ComboBox()
        Me.dtpCariTransaksi = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cb1.My.Resources.Resources.Logos
        Me.PictureBox1.Location = New System.Drawing.Point(0, 5)
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
        Me.GroupBox1.Location = New System.Drawing.Point(-3, -6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(816, 55)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        '
        'DataGridViewTransaksi
        '
        Me.DataGridViewTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTransaksi.Location = New System.Drawing.Point(41, 378)
        Me.DataGridViewTransaksi.Name = "DataGridViewTransaksi"
        Me.DataGridViewTransaksi.Size = New System.Drawing.Size(737, 132)
        Me.DataGridViewTransaksi.TabIndex = 55
        '
        'btnHapusTransaksi
        '
        Me.btnHapusTransaksi.BackColor = System.Drawing.Color.SpringGreen
        Me.btnHapusTransaksi.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapusTransaksi.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnHapusTransaksi.Location = New System.Drawing.Point(491, 242)
        Me.btnHapusTransaksi.Name = "btnHapusTransaksi"
        Me.btnHapusTransaksi.Size = New System.Drawing.Size(117, 35)
        Me.btnHapusTransaksi.TabIndex = 54
        Me.btnHapusTransaksi.Text = "Delete"
        Me.btnHapusTransaksi.UseVisualStyleBackColor = False
        '
        'btnUpdateTransaksi
        '
        Me.btnUpdateTransaksi.BackColor = System.Drawing.Color.SpringGreen
        Me.btnUpdateTransaksi.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateTransaksi.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUpdateTransaksi.Location = New System.Drawing.Point(337, 242)
        Me.btnUpdateTransaksi.Name = "btnUpdateTransaksi"
        Me.btnUpdateTransaksi.Size = New System.Drawing.Size(117, 35)
        Me.btnUpdateTransaksi.TabIndex = 52
        Me.btnUpdateTransaksi.Text = "Update"
        Me.btnUpdateTransaksi.UseVisualStyleBackColor = False
        '
        'txtJumlahTamu
        '
        Me.txtJumlahTamu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlahTamu.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtJumlahTamu.Location = New System.Drawing.Point(644, 175)
        Me.txtJumlahTamu.Multiline = True
        Me.txtJumlahTamu.Name = "txtJumlahTamu"
        Me.txtJumlahTamu.Size = New System.Drawing.Size(144, 30)
        Me.txtJumlahTamu.TabIndex = 51
        Me.txtJumlahTamu.Text = "Enter Tamu"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(641, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 20)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Jumlah Tamu"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(335, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 20)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Tanggal Check Out"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(488, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 20)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Tanggal Check In"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(335, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Nama Pelanggan"
        '
        'btnTambahTransaksi
        '
        Me.btnTambahTransaksi.BackColor = System.Drawing.Color.SpringGreen
        Me.btnTambahTransaksi.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahTransaksi.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTambahTransaksi.Location = New System.Drawing.Point(37, 259)
        Me.btnTambahTransaksi.Name = "btnTambahTransaksi"
        Me.btnTambahTransaksi.Size = New System.Drawing.Size(126, 40)
        Me.btnTambahTransaksi.TabIndex = 43
        Me.btnTambahTransaksi.Text = "Create"
        Me.btnTambahTransaksi.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(279, 23)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Isi kolom pengisian disamping terlebih dahulu"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Constantia", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 103)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Manajemen Transaksi"
        '
        'txtTotalHarga
        '
        Me.txtTotalHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalHarga.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtTotalHarga.Location = New System.Drawing.Point(642, 105)
        Me.txtTotalHarga.Multiline = True
        Me.txtTotalHarga.Name = "txtTotalHarga"
        Me.txtTotalHarga.Size = New System.Drawing.Size(144, 30)
        Me.txtTotalHarga.TabIndex = 58
        Me.txtTotalHarga.Text = "Enter Harga"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(639, 82)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 20)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Total Harga"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(488, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 20)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Nama Kamar"
        '
        'btnCariTransaksi
        '
        Me.btnCariTransaksi.BackColor = System.Drawing.Color.SpringGreen
        Me.btnCariTransaksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCariTransaksi.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCariTransaksi.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCariTransaksi.Location = New System.Drawing.Point(661, 337)
        Me.btnCariTransaksi.Name = "btnCariTransaksi"
        Me.btnCariTransaksi.Size = New System.Drawing.Size(117, 35)
        Me.btnCariTransaksi.TabIndex = 98
        Me.btnCariTransaksi.Text = "Cari"
        Me.btnCariTransaksi.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClear.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnClear.Location = New System.Drawing.Point(679, 521)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(99, 34)
        Me.BtnClear.TabIndex = 101
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(641, 219)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 20)
        Me.Label8.TabIndex = 102
        Me.Label8.Text = "Tanggal Pesan"
        '
        'dtpCheckIn
        '
        Me.dtpCheckIn.Location = New System.Drawing.Point(491, 175)
        Me.dtpCheckIn.Name = "dtpCheckIn"
        Me.dtpCheckIn.Size = New System.Drawing.Size(144, 20)
        Me.dtpCheckIn.TabIndex = 104
        '
        'dtpCheckOut
        '
        Me.dtpCheckOut.Location = New System.Drawing.Point(338, 176)
        Me.dtpCheckOut.Name = "dtpCheckOut"
        Me.dtpCheckOut.Size = New System.Drawing.Size(147, 20)
        Me.dtpCheckOut.TabIndex = 105
        '
        'dtpTanggalPesan
        '
        Me.dtpTanggalPesan.Location = New System.Drawing.Point(644, 242)
        Me.dtpTanggalPesan.Name = "dtpTanggalPesan"
        Me.dtpTanggalPesan.Size = New System.Drawing.Size(144, 20)
        Me.dtpTanggalPesan.TabIndex = 106
        '
        'ComboBoxNamaPelanggan
        '
        Me.ComboBoxNamaPelanggan.FormattingEnabled = True
        Me.ComboBoxNamaPelanggan.Location = New System.Drawing.Point(338, 107)
        Me.ComboBoxNamaPelanggan.Name = "ComboBoxNamaPelanggan"
        Me.ComboBoxNamaPelanggan.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxNamaPelanggan.TabIndex = 107
        '
        'ComboBoxNamaKamar
        '
        Me.ComboBoxNamaKamar.FormattingEnabled = True
        Me.ComboBoxNamaKamar.Location = New System.Drawing.Point(491, 105)
        Me.ComboBoxNamaKamar.Name = "ComboBoxNamaKamar"
        Me.ComboBoxNamaKamar.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxNamaKamar.TabIndex = 108
        '
        'dtpCariTransaksi
        '
        Me.dtpCariTransaksi.Location = New System.Drawing.Point(511, 342)
        Me.dtpCariTransaksi.Name = "dtpCariTransaksi"
        Me.dtpCariTransaksi.Size = New System.Drawing.Size(144, 20)
        Me.dtpCariTransaksi.TabIndex = 109
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 567)
        Me.Controls.Add(Me.dtpCariTransaksi)
        Me.Controls.Add(Me.ComboBoxNamaKamar)
        Me.Controls.Add(Me.ComboBoxNamaPelanggan)
        Me.Controls.Add(Me.dtpTanggalPesan)
        Me.Controls.Add(Me.dtpCheckOut)
        Me.Controls.Add(Me.dtpCheckIn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.btnCariTransaksi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTotalHarga)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridViewTransaksi)
        Me.Controls.Add(Me.btnHapusTransaksi)
        Me.Controls.Add(Me.btnUpdateTransaksi)
        Me.Controls.Add(Me.txtJumlahTamu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnTambahTransaksi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormTransaksi"
        Me.Text = "Form4"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridViewTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelPelanggan As Label
    Friend WithEvents LabelKeluar As Label
    Friend WithEvents LabelTransaksi As Label
    Friend WithEvents LabelLaporan As Label
    Friend WithEvents LabelKamar As Label
    Friend WithEvents LabelPengeluaran As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridViewTransaksi As DataGridView
    Friend WithEvents btnHapusTransaksi As Button
    Friend WithEvents btnUpdateTransaksi As Button
    Friend WithEvents txtJumlahTamu As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTambahTransaksi As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalHarga As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCariTransaksi As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpCheckIn As DateTimePicker
    Friend WithEvents dtpCheckOut As DateTimePicker
    Friend WithEvents dtpTanggalPesan As DateTimePicker
    Friend WithEvents ComboBoxNamaPelanggan As ComboBox
    Friend WithEvents ComboBoxNamaKamar As ComboBox
    Friend WithEvents dtpCariTransaksi As DateTimePicker
End Class
