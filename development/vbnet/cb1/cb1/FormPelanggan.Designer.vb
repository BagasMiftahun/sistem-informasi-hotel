<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPelanggan
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
        Me.btnTambahPelanggan = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoTelepon = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAlamatPelanggan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnHapusPelanggan = New System.Windows.Forms.Button()
        Me.BtnCariPelanggan = New System.Windows.Forms.Button()
        Me.btnUpdatePelanggan = New System.Windows.Forms.Button()
        Me.DataGridViewPelanggan = New System.Windows.Forms.DataGridView()
        Me.LabelTransaksi = New System.Windows.Forms.Label()
        Me.LabelPelanggan = New System.Windows.Forms.Label()
        Me.LabelKamar = New System.Windows.Forms.Label()
        Me.LabelPengeluaran = New System.Windows.Forms.Label()
        Me.LabelLaporan = New System.Windows.Forms.Label()
        Me.LabelKeluar = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.txtNamaPelanggan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCariPelanggan = New System.Windows.Forms.TextBox()
        CType(Me.DataGridViewPelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTambahPelanggan
        '
        Me.btnTambahPelanggan.BackColor = System.Drawing.Color.SpringGreen
        Me.btnTambahPelanggan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTambahPelanggan.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahPelanggan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTambahPelanggan.Location = New System.Drawing.Point(42, 254)
        Me.btnTambahPelanggan.Name = "btnTambahPelanggan"
        Me.btnTambahPelanggan.Size = New System.Drawing.Size(126, 40)
        Me.btnTambahPelanggan.TabIndex = 7
        Me.btnTambahPelanggan.Text = "Create"
        Me.btnTambahPelanggan.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(279, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Isi kolom pengisian disamping terlebih dahulu"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Constantia", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 103)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Manajemen Pelanggan"
        '
        'txtNoTelepon
        '
        Me.txtNoTelepon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoTelepon.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtNoTelepon.Location = New System.Drawing.Point(504, 173)
        Me.txtNoTelepon.Multiline = True
        Me.txtNoTelepon.Name = "txtNoTelepon"
        Me.txtNoTelepon.Size = New System.Drawing.Size(144, 30)
        Me.txtNoTelepon.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(501, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 20)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Telepon"
        '
        'txtAlamatPelanggan
        '
        Me.txtAlamatPelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamatPelanggan.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtAlamatPelanggan.Location = New System.Drawing.Point(504, 117)
        Me.txtAlamatPelanggan.Multiline = True
        Me.txtAlamatPelanggan.Name = "txtAlamatPelanggan"
        Me.txtAlamatPelanggan.Size = New System.Drawing.Size(144, 30)
        Me.txtAlamatPelanggan.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(501, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 20)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Alamat"
        '
        'BtnHapusPelanggan
        '
        Me.BtnHapusPelanggan.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnHapusPelanggan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHapusPelanggan.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapusPelanggan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnHapusPelanggan.Location = New System.Drawing.Point(658, 167)
        Me.BtnHapusPelanggan.Name = "BtnHapusPelanggan"
        Me.BtnHapusPelanggan.Size = New System.Drawing.Size(117, 35)
        Me.BtnHapusPelanggan.TabIndex = 32
        Me.BtnHapusPelanggan.Text = "Delete"
        Me.BtnHapusPelanggan.UseVisualStyleBackColor = False
        '
        'BtnCariPelanggan
        '
        Me.BtnCariPelanggan.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnCariPelanggan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCariPelanggan.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCariPelanggan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCariPelanggan.Location = New System.Drawing.Point(658, 254)
        Me.BtnCariPelanggan.Name = "BtnCariPelanggan"
        Me.BtnCariPelanggan.Size = New System.Drawing.Size(117, 35)
        Me.BtnCariPelanggan.TabIndex = 31
        Me.BtnCariPelanggan.Text = "Cari"
        Me.BtnCariPelanggan.UseVisualStyleBackColor = False
        '
        'btnUpdatePelanggan
        '
        Me.btnUpdatePelanggan.BackColor = System.Drawing.Color.SpringGreen
        Me.btnUpdatePelanggan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdatePelanggan.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdatePelanggan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUpdatePelanggan.Location = New System.Drawing.Point(658, 124)
        Me.btnUpdatePelanggan.Name = "btnUpdatePelanggan"
        Me.btnUpdatePelanggan.Size = New System.Drawing.Size(117, 35)
        Me.btnUpdatePelanggan.TabIndex = 30
        Me.btnUpdatePelanggan.Text = "Update"
        Me.btnUpdatePelanggan.UseVisualStyleBackColor = False
        '
        'DataGridViewPelanggan
        '
        Me.DataGridViewPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPelanggan.Location = New System.Drawing.Point(42, 303)
        Me.DataGridViewPelanggan.Name = "DataGridViewPelanggan"
        Me.DataGridViewPelanggan.Size = New System.Drawing.Size(733, 198)
        Me.DataGridViewPelanggan.TabIndex = 33
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
        Me.GroupBox1.Location = New System.Drawing.Point(2, -7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(816, 55)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
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
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClear.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnClear.Location = New System.Drawing.Point(676, 507)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(99, 34)
        Me.BtnClear.TabIndex = 41
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'txtNamaPelanggan
        '
        Me.txtNamaPelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaPelanggan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNamaPelanggan.Location = New System.Drawing.Point(342, 117)
        Me.txtNamaPelanggan.Multiline = True
        Me.txtNamaPelanggan.Name = "txtNamaPelanggan"
        Me.txtNamaPelanggan.Size = New System.Drawing.Size(144, 30)
        Me.txtNamaPelanggan.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(339, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Nama Pelanggan"
        '
        'txtCariPelanggan
        '
        Me.txtCariPelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariPelanggan.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtCariPelanggan.Location = New System.Drawing.Point(504, 254)
        Me.txtCariPelanggan.Multiline = True
        Me.txtCariPelanggan.Name = "txtCariPelanggan"
        Me.txtCariPelanggan.Size = New System.Drawing.Size(144, 30)
        Me.txtCariPelanggan.TabIndex = 45
        Me.txtCariPelanggan.Text = "Enter Name"
        '
        'FormPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 553)
        Me.Controls.Add(Me.txtCariPelanggan)
        Me.Controls.Add(Me.txtNamaPelanggan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridViewPelanggan)
        Me.Controls.Add(Me.BtnHapusPelanggan)
        Me.Controls.Add(Me.BtnCariPelanggan)
        Me.Controls.Add(Me.btnUpdatePelanggan)
        Me.Controls.Add(Me.txtNoTelepon)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAlamatPelanggan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnTambahPelanggan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPelanggan"
        Me.Text = "Form3"
        CType(Me.DataGridViewPelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTambahPelanggan As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNoTelepon As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAlamatPelanggan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnHapusPelanggan As Button
    Friend WithEvents BtnCariPelanggan As Button
    Friend WithEvents btnUpdatePelanggan As Button
    Friend WithEvents DataGridViewPelanggan As DataGridView
    Friend WithEvents LabelTransaksi As Label
    Friend WithEvents LabelPelanggan As Label
    Friend WithEvents LabelKamar As Label
    Friend WithEvents LabelPengeluaran As Label
    Friend WithEvents LabelLaporan As Label
    Friend WithEvents LabelKeluar As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnClear As Button
    Friend WithEvents txtNamaPelanggan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCariPelanggan As TextBox
End Class
