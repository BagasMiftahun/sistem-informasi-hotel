Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles

Public Class FormPengeluaran
    'NAVBAR EVENT UNTUK DIARAHKAN KE TAMPILAN

    'START
    Private Sub LabelKeluar_Click(sender As Object, e As EventArgs) Handles LabelKeluar.Click
        ' Buka kembali FormLogin sebagai tampilan login
        Dim formLogin As New FormLogin()
        formLogin.Show()
        Me.Close()
    End Sub
    Private Sub LabelPelanggan_Click(sender As Object, e As EventArgs) Handles LabelKamar.Click
        ' Buka kembali FormKamar sebagai tampilan Kamar
        Dim formKamar As New FormKamar()
        formKamar.Show()
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
    Private Sub FormPengeluaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanDataPengeluaran()
    End Sub

    ' Event klik tombol Tambah Pengeluaran
    Private Sub BtnTambahPengeluaran_Click(sender As Object, e As EventArgs) Handles BtnTambahPengeluaran.Click
        ' Validasi input data
        If String.IsNullOrEmpty(txtKeteranganPengeluaran.Text) Then
            MessageBox.Show("Nama Pengeluaran harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Buat objek koneksi database
        Using connection As New SqlConnection(connectionString)
            ' Buat perintah SQL untuk insert data Pengeluaran
            Dim query As String = "INSERT INTO Pengeluaran (Keterangan, Jumlah) VALUES (@Keterangan, @Jumlah)"

            ' Buat objek perintah SQL dengan parameter
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Keterangan", txtKeteranganPengeluaran.Text)
            command.Parameters.AddWithValue("@Jumlah", txtJumlahPengeluaran.Text)

            ' Buka koneksi database
            connection.Open()

            ' Jalankan perintah SQL
            command.ExecuteNonQuery()

            ' Tampilkan data Kamar terbaru di DataGridView
            TampilkanDataPengeluaran()

            ' Kosongkan input data setelah berhasil tambah Kamar
            KosongkanInputData()
        End Using
    End Sub

    ' Event klik tombol Ubah Kamar
    Private Sub BtnUbahPengeluaran_Click(sender As Object, e As EventArgs) Handles BtnUpdatePengeluaran.Click
        ' Validasi pemilihan data pada DataGridView
        If DataGridViewPengeluaran.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data Pengeluaran terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Ambil ID Kamar dari data terpilih
        Dim idPengeluaran As Integer = CInt(DataGridViewPengeluaran.SelectedRows(0).Cells("IdPengeluaran").Value)

        ' Buat objek koneksi database
        Using connection As New SqlConnection(connectionString)
            ' Buat perintah SQL untuk update data Pengeluaran
            Dim query As String = "UPDATE Pengeluaran SET Keterangan = @Keterangan, Jumlah = @Jumlah WHERE IdPengeluaran = @IdPengeluaran"

            ' Buat objek perintah SQL dengan parameter
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Keterangan", txtKeteranganPengeluaran.Text)
            command.Parameters.AddWithValue("@Jumlah", txtJumlahPengeluaran.Text)
            command.Parameters.AddWithValue("@IdPengeluaran", idPengeluaran)

            ' Buka koneksi database
            connection.Open()

            ' Jalankan perintah SQL
            command.ExecuteNonQuery()

            ' Tampilkan data Kamar terbaru di DataGridView
            TampilkanDataPengeluaran()

            ' Kosongkan input data setelah berhasil ubah Kamar
            KosongkanInputData()
        End Using
    End Sub

    ' Event klik tombol Hapus Kamar
    Private Sub BtnHapusPengeluaran_Click(sender As Object, e As EventArgs) Handles BtnHapusPengeluaran.Click
        ' Validasi pemilihan data pada DataGridView
        If DataGridViewPengeluaran.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data Pengeluaran terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Tampilkan dialog konfirmasi hapus data
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data Pengeluaran ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Jika user mengonfirmasi hapus data
        If result = DialogResult.Yes Then
            ' Ambil ID Pengeluaran dari data terpilih
            Dim idPengeluaran As Integer = CInt(DataGridViewPengeluaran.SelectedRows(0).Cells("IdPengeluaran").Value)

            ' Buat objek koneksi database
            Using connection As New SqlConnection(connectionString)
                ' Buat perintah SQL untuk delete data Pengeluaran
                Dim query As String = "DELETE FROM Pengeluaran WHERE IdPengeluaran = @IdPengeluaran"

                ' Buat objek perintah SQL dengan parameter
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@IdPengeluaran", idPengeluaran)

                ' Buka koneksi database
                connection.Open()

                ' Jalankan perintah SQL
                command.ExecuteNonQuery()

                ' Tampilkan data Pengeluaran terbaru di DataGridView
                TampilkanDataPengeluaran()

                ' Kosongkan input data setelah berhasil hapus Pengeluaran
                KosongkanInputData()
            End Using
        End If
    End Sub

    ' Event klik tombol Cari Pengeluaran
    Private Sub BtnCariPengeluaran_Click(sender As Object, e As EventArgs) Handles BtnCariPengeluaran.Click
        ' Baca nama Pengeluaran yang ingin dicari
        Dim Keterangan As String = txtCariPengeluaran.Text.Trim()

        ' Jika nama Pengeluaran tidak kosong
        If Not String.IsNullOrEmpty(Keterangan) Then
            ' Buat objek koneksi database
            Using connection As New SqlConnection(connectionString)
                ' Buat perintah SQL untuk mencari Pengeluaran berdasarkan nama
                Dim query As String = "SELECT * FROM Pengeluaran WHERE Keterangan LIKE '%' + @Keterangan + '%'"

                ' Buat objek perintah SQL dengan parameter
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Keterangan", Keterangan)

                ' Buat objek SqlDataAdapter untuk menampung hasil query
                Dim adapter As New SqlDataAdapter(command)

                ' Buat objek DataTable untuk menampung data Kamar
                Dim table As New DataTable()

                ' Buka koneksi database
                connection.Open()

                ' Isi data Pengeluaran ke objek DataTable
                adapter.Fill(table)

                ' Tampilkan data Pengeluaran di DataGridView
                DataGridViewPengeluaran.DataSource = table
            End Using
        Else
            ' Jika nama Pengeluaran kosong, tampilkan semua data Pengeluaran
            TampilkanDataPengeluaran()
        End If
    End Sub

    ' Event klik data pada DataGridView
    Private Sub DataGridViewPengeluaran_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPengeluaran.CellClick
        ' Ambil data dari DataGridView dan isi ke TextBox
        If DataGridViewPengeluaran.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridViewPengeluaran.SelectedRows(0)
            txtKeteranganPengeluaran.Text = selectedRow.Cells("Keterangan").Value.ToString()
            txtJumlahPengeluaran.Text = selectedRow.Cells("Jumlah").Value.ToString()
        End If
    End Sub

    ' Method untuk menampilkan data Pengeluaran di DataGridView
    Private Sub TampilkanDataPengeluaran()
        ' Buat objek koneksi database
        Using connection As New SqlConnection(connectionString)
            ' Buat perintah SQL untuk select semua data Pengeluaran
            Dim query As String = "SELECT * FROM Pengeluaran"

            ' Buat objek perintah SQL
            Dim command As New SqlCommand(query, connection)

            ' Buat objek SqlDataAdapter untuk menampung hasil query
            Dim adapter As New SqlDataAdapter(command)

            ' Buat objek DataTable untuk menampung data Pengeluaran
            Dim table As New DataTable()

            ' Buka koneksi database
            connection.Open()

            ' Isi data Pengeluaran ke objek DataTable
            adapter.Fill(table)

            ' Tampilkan data Pengeluaran di DataGridView
            DataGridViewPengeluaran.DataSource = table
        End Using
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        KosongkanInputData()
    End Sub

    ' Method untuk mengosongkan input data
    Private Sub KosongkanInputData()
        txtKeteranganPengeluaran.Text = ""
        txtJumlahPengeluaran.Text = ""
    End Sub

End Class