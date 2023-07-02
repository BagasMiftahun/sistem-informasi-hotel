Imports System.Data.SqlClient

Public Class FormLaporan
    'NAVBAR EVENT UNTUK DIARAHKAN KE TAMPILAN

    'START
    Private Sub LabelKeluar_Click(sender As Object, e As EventArgs) Handles LabelKeluar.Click
        ' Buka kembali FormLogin sebagai tampilan login
        Dim formLogin As New FormLogin()
        formLogin.Show()
        Me.Close()
    End Sub
    Private Sub LabelPelanggan_Click(sender As Object, e As EventArgs) Handles LabelPelanggan.Click
        ' Buka kembali FormPelanggan sebagai tampilan pelanggan
        Dim formPelanggan As New FormPelanggan()
        formPelanggan.Show()
        Me.Close()
    End Sub
    Private Sub LabelTransaksi_Click(sender As Object, e As EventArgs) Handles LabelTransaksi.Click
        ' Buka kembali FormTransaksi sebagai tampilan transaksi
        Dim formTransaksi As New FormTransaksi()
        formTransaksi.Show()
        Me.Close()
    End Sub
    Private Sub LabelKamar_Click(sender As Object, e As EventArgs) Handles LabelKamar.Click
        ' Buka kembali FormLogin sebagai tampilan login
        Dim formKamar As New FormKamar()
        formKamar.Show()
        Me.Close()
    End Sub
    Private Sub LabelPengeluaran_Click(sender As Object, e As EventArgs) Handles LabelPengeluaran.Click
        ' Buka kembali FormLogin sebagai tampilan login
        Dim formPengeluaran As New FormPengeluaran()
        formPengeluaran.Show()
        Me.Close()
    End Sub
    Private Sub LabelLaporan_Click(sender As Object, e As EventArgs) Handles LabelLaporan.Click
        ' Buka kembali FormLogin sebagai tampilan login
        Dim formLaporan As New FormLaporan()
        formLaporan.Show()
        Me.Close()
    End Sub
    'END

    ' String koneksi database
    Private connectionString As String = "Data Source=DESKTOP-LU2FUUL;Initial Catalog=HotelDB;Integrated Security=True"

    ' Event load form
    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanDataLaporan()
    End Sub

    ' Event klik tombol Tambah Laporan
    Private Sub BtnTambahLaporan_Click(sender As Object, e As EventArgs)
        ' Validasi input data
        If String.IsNullOrEmpty(dtpTanggal.Value) Then
            MessageBox.Show("Tanggal Laporan harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Buat objek koneksi database
        Using connection As New SqlConnection(connectionString)
            ' Buat perintah SQL untuk insert data Laporan
            Dim query As String = "INSERT INTO LaporanBulanan (Tanggal, Pendapatan, Pengeluaran, LabaBersih) VALUES (@Tanggal, @Pendapatan, @Pengeluaran, @LabaBersih)"

            ' Buat objek perintah SQL dengan parameter
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Tanggal", dtpTanggal.Value)
            command.Parameters.AddWithValue("@Pendapatan", Decimal.Parse(txtPendapatan.Text))
            command.Parameters.AddWithValue("@Pengeluaran", Decimal.Parse(txtPengeluaran.Text))
            command.Parameters.AddWithValue("@LabaBersih", Decimal.Parse(txtLabaBersih.Text))


            ' Buka koneksi database
            connection.Open()

            ' Jalankan perintah SQL
            command.ExecuteNonQuery()

            ' Tampilkan data Kamar terbaru di DataGridView
            TampilkanDataLaporan()

            ' Kosongkan input data setelah berhasil tambah Kamar
            KosongkanInputData()
        End Using
    End Sub

    ' Event klik tombol Ubah Kamar
    Private Sub BtnUbahLaporan_Click(sender As Object, e As EventArgs)
        ' Validasi pemilihan data pada DataGridView
        If DataGridViewLaporan.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data Laporan terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Ambil ID Kamar dari data terpilih
        Dim idLaporan As Integer = CInt(DataGridViewLaporan.SelectedRows(0).Cells("IdLaporan").Value)

        ' Buat objek koneksi database
        Using connection As New SqlConnection(connectionString)
            ' Buat perintah SQL untuk update data Laporan
            Dim query As String = "UPDATE LaporanBulanan SET Tanggal=@Tanggal, Pendapatan=@Pendapatan, Pengeluaran=@Pengeluaran, LabaBersih=@LabaBersih WHERE IdLaporan=@IdLaporan"

            ' Buat objek perintah SQL dengan parameter
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@IdLaporan", DataGridViewLaporan.SelectedRows(0).Cells("IdLaporan").Value)
            command.Parameters.AddWithValue("@Tanggal", dtpTanggal.Value)
            command.Parameters.AddWithValue("@Pendapatan", Decimal.Parse(txtPendapatan.Text))
            command.Parameters.AddWithValue("@Pengeluaran", Decimal.Parse(txtPengeluaran.Text))
            command.Parameters.AddWithValue("@LabaBersih", Decimal.Parse(txtLabaBersih.Text))

            ' Buka koneksi database
            connection.Open()

            ' Jalankan perintah SQL
            command.ExecuteNonQuery()

            ' Tampilkan data Kamar terbaru di DataGridView
            TampilkanDataLaporan()

            ' Kosongkan input data setelah berhasil ubah Kamar
            KosongkanInputData()
        End Using
    End Sub

    ' Event klik tombol Hapus Kamar
    Private Sub BtnHapusLaporan_Click(sender As Object, e As EventArgs)
        ' Validasi pemilihan data pada DataGridView
        If DataGridViewLaporan.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data Laporan terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Tampilkan dialog konfirmasi hapus data
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data Laporan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Jika user mengonfirmasi hapus data
        If result = DialogResult.Yes Then
            ' Ambil ID Laporan dari data terpilih
            Dim idLaporan As Integer = CInt(DataGridViewLaporan.SelectedRows(0).Cells("IdLaporan").Value)

            ' Buat objek koneksi database
            Using connection As New SqlConnection(connectionString)
                ' Buat perintah SQL untuk delete data Laporan
                Dim query As String = "DELETE FROM LaporanBulanan WHERE IdLaporan = @IdLaporan"

                ' Buat objek perintah SQL dengan parameter
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@IdLaporan", idLaporan)

                ' Buka koneksi database
                connection.Open()

                ' Jalankan perintah SQL
                command.ExecuteNonQuery()

                ' Tampilkan data Laporan terbaru di DataGridView
                TampilkanDataLaporan()

                ' Kosongkan input data setelah berhasil hapus Laporan
                KosongkanInputData()
            End Using
        End If
    End Sub

    ' Event klik tombol Cari Laporan
    Private Sub BtnCariLaporan_Click(sender As Object, e As EventArgs) Handles BtnCariLaporan.Click
        ' Baca nama Laporan yang ingin dicari
        Dim tanggalLaporan As Date = dtpCariLaporan.Value

        ' Jika nama Laporan tidak kosong
        If Not String.IsNullOrEmpty(tanggalLaporan) Then
            ' Buat objek koneksi database
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "SELECT * FROM LaporanBulanan WHERE Tanggal = @Tanggal"

                ' Buat objek perintah SQL dengan parameter
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Tanggal", tanggalLaporan)

                ' Buat objek SqlDataAdapter untuk menampung hasil query
                Dim adapter As New SqlDataAdapter(command)

                ' Buat objek DataTable untuk menampung data pelanggan
                Dim dataSet As New DataSet()

                ' Buka koneksi database
                connection.Open()

                ' Isi data Transaksi ke objek DataTable
                adapter.Fill(dataSet, "LaporanBulanan")

                ' Tampilkan data Transaksi di DataGridView
                DataGridViewLaporan.DataSource = dataSet.Tables("LaporanBulanan")
            End Using
        Else
            ' Jika nama Laporan kosong, tampilkan semua data Laporan
            TampilkanDataLaporan()
        End If
    End Sub

    ' Event klik data pada DataGridView
    Private Sub DataGridViewLaporan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewLaporan.CellClick
        ' Ambil data dari DataGridView dan isi ke TextBox
        If DataGridViewLaporan.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridViewLaporan.Rows(e.RowIndex)
            dtpTanggal.Value = DateTime.Parse(row.Cells("Tanggal").Value.ToString())
            txtPendapatan.Text = row.Cells("Pendapatan").Value.ToString()
            txtPengeluaran.Text = row.Cells("Pengeluaran").Value.ToString()
            txtLabaBersih.Text = row.Cells("LabaBersih").Value.ToString()
        End If
    End Sub

    ' Method untuk menampilkan data Laporan di DataGridView
    Private Sub TampilkanDataLaporan()
        ' Buat objek koneksi database
        Using connection As New SqlConnection(connectionString)
            ' Buat perintah SQL untuk select semua data Laporan
            Dim query As String = "SELECT * FROM LaporanBulanan"

            ' Buat objek perintah SQL
            Dim command As New SqlCommand(query, connection)

            ' Buat objek SqlDataAdapter untuk menampung hasil query
            Dim adapter As New SqlDataAdapter(command)

            ' Buat objek DataTable untuk menampung data Laporan
            Dim table As New DataTable()

            ' Buka koneksi database
            connection.Open()

            ' Isi data Laporan ke objek DataTable
            adapter.Fill(table)

            ' Tampilkan data Laporan di DataGridView
            DataGridViewLaporan.DataSource = table
        End Using
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        KosongkanInputData()
    End Sub

    ' Method untuk mengosongkan input data
    Private Sub KosongkanInputData()
        txtPendapatan.Text = ""
        txtPengeluaran.Text = ""
        txtLabaBersih.Text = ""
    End Sub

End Class