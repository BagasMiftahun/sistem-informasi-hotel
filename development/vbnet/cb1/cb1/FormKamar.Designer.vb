<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKamar
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelPelanggan = New System.Windows.Forms.Label()
        Me.LabelKeluar = New System.Windows.Forms.Label()
        Me.LabelTransaksi = New System.Windows.Forms.Label()
        Me.LabelLaporan = New System.Windows.Forms.Label()
        Me.LabelKamar = New System.Windows.Forms.Label()
        Me.LabelPengeluaran = New System.Windows.Forms.Label()
        Me.DataGridViewKamar = New System.Windows.Forms.DataGridView()
        Me.BtnHapusKamar = New System.Windows.Forms.Button()
        Me.BtnUpdateKamar = New System.Windows.Forms.Button()
        Me.BtnTambahKamar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHargaKamar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNamaKamar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCariKamar = New System.Windows.Forms.TextBox()
        Me.BtnCariKamar = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.ComboBoxStatus = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(2, -6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(816, 55)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
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
        'DataGridViewKamar
        '
        Me.DataGridViewKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewKamar.Location = New System.Drawing.Point(44, 326)
        Me.DataGridViewKamar.Name = "DataGridViewKamar"
        Me.DataGridViewKamar.Size = New System.Drawing.Size(752, 198)
        Me.DataGridViewKamar.TabIndex = 73
        '
        'BtnHapusKamar
        '
        Me.BtnHapusKamar.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnHapusKamar.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapusKamar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnHapusKamar.Location = New System.Drawing.Point(679, 185)
        Me.BtnHapusKamar.Name = "BtnHapusKamar"
        Me.BtnHapusKamar.Size = New System.Drawing.Size(117, 35)
        Me.BtnHapusKamar.TabIndex = 72
        Me.BtnHapusKamar.Text = "Delete"
        Me.BtnHapusKamar.UseVisualStyleBackColor = False
        '
        'BtnUpdateKamar
        '
        Me.BtnUpdateKamar.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnUpdateKamar.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateKamar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnUpdateKamar.Location = New System.Drawing.Point(679, 131)
        Me.BtnUpdateKamar.Name = "BtnUpdateKamar"
        Me.BtnUpdateKamar.Size = New System.Drawing.Size(117, 35)
        Me.BtnUpdateKamar.TabIndex = 70
        Me.BtnUpdateKamar.Text = "Update"
        Me.BtnUpdateKamar.UseVisualStyleBackColor = False
        '
        'BtnTambahKamar
        '
        Me.BtnTambahKamar.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnTambahKamar.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambahKamar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnTambahKamar.Location = New System.Drawing.Point(44, 251)
        Me.BtnTambahKamar.Name = "BtnTambahKamar"
        Me.BtnTambahKamar.Size = New System.Drawing.Size(126, 40)
        Me.BtnTambahKamar.TabIndex = 61
        Me.BtnTambahKamar.Text = "Create"
        Me.BtnTambahKamar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(279, 23)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Isi kolom pengisian disamping terlebih dahulu"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Constantia", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 103)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Manajemen Kamar"
        '
        'txtHargaKamar
        '
        Me.txtHargaKamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHargaKamar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtHargaKamar.Location = New System.Drawing.Point(380, 191)
        Me.txtHargaKamar.Multiline = True
        Me.txtHargaKamar.Name = "txtHargaKamar"
        Me.txtHargaKamar.Size = New System.Drawing.Size(144, 30)
        Me.txtHargaKamar.TabIndex = 80
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(377, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 20)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Harga"
        '
        'txtNamaKamar
        '
        Me.txtNamaKamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaKamar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtNamaKamar.Location = New System.Drawing.Point(380, 131)
        Me.txtNamaKamar.Multiline = True
        Me.txtNamaKamar.Name = "txtNamaKamar"
        Me.txtNamaKamar.Size = New System.Drawing.Size(144, 30)
        Me.txtNamaKamar.TabIndex = 77
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(526, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 20)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Status"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(377, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Nama Kamar"
        '
        'txtCariKamar
        '
        Me.txtCariKamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariKamar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtCariKamar.Location = New System.Drawing.Point(525, 285)
        Me.txtCariKamar.Multiline = True
        Me.txtCariKamar.Name = "txtCariKamar"
        Me.txtCariKamar.Size = New System.Drawing.Size(144, 30)
        Me.txtCariKamar.TabIndex = 82
        Me.txtCariKamar.Text = "Enter Name"
        '
        'BtnCariKamar
        '
        Me.BtnCariKamar.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnCariKamar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCariKamar.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCariKamar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCariKamar.Location = New System.Drawing.Point(679, 285)
        Me.BtnCariKamar.Name = "BtnCariKamar"
        Me.BtnCariKamar.Size = New System.Drawing.Size(117, 35)
        Me.BtnCariKamar.TabIndex = 81
        Me.BtnCariKamar.Text = "Cari"
        Me.BtnCariKamar.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClear.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnClear.Location = New System.Drawing.Point(697, 563)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(99, 34)
        Me.BtnClear.TabIndex = 83
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'ComboBoxStatus
        '
        Me.ComboBoxStatus.DropDownHeight = 250
        Me.ComboBoxStatus.FormattingEnabled = True
        Me.ComboBoxStatus.IntegralHeight = False
        Me.ComboBoxStatus.Items.AddRange(New Object() {"Kosong", "Terisi", "Maintance"})
        Me.ComboBoxStatus.Location = New System.Drawing.Point(529, 131)
        Me.ComboBoxStatus.Name = "ComboBoxStatus"
        Me.ComboBoxStatus.Size = New System.Drawing.Size(144, 21)
        Me.ComboBoxStatus.TabIndex = 84
        '
        'FormKamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 609)
        Me.Controls.Add(Me.ComboBoxStatus)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.txtCariKamar)
        Me.Controls.Add(Me.BtnCariKamar)
        Me.Controls.Add(Me.txtHargaKamar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNamaKamar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridViewKamar)
        Me.Controls.Add(Me.BtnHapusKamar)
        Me.Controls.Add(Me.BtnUpdateKamar)
        Me.Controls.Add(Me.BtnTambahKamar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormKamar"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelPelanggan As Label
    Friend WithEvents LabelKeluar As Label
    Friend WithEvents LabelTransaksi As Label
    Friend WithEvents LabelLaporan As Label
    Friend WithEvents LabelKamar As Label
    Friend WithEvents LabelPengeluaran As Label
    Friend WithEvents DataGridViewKamar As DataGridView
    Friend WithEvents BtnHapusKamar As Button
    Friend WithEvents BtnUpdateKamar As Button
    Friend WithEvents BtnTambahKamar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHargaKamar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNamaKamar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCariKamar As TextBox
    Friend WithEvents BtnCariKamar As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents ComboBoxStatus As ComboBox
End Class
