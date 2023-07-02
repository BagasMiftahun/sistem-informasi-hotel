Imports System.Data.SqlClient

Public Class FormPelanggan


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
    Private Sub FormPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanDataPelanggan()
    End Sub

    ' Event klik tombol Tambah Pelanggan
    Private Sub BtnTambahPelanggan_Click(sender As Object, e As EventArgs) Handles btnTambahPelanggan.Click
        ' Validasi input data
        If String.IsNullOrEmpty(txtNamaPelanggan.Text) Then
            MessageBox.Show("Nama pelanggan harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Buat objek koneksi database
        Using connection As New SqlConnection(connectionString)
            ' Buat perintah SQL untuk insert data pelanggan
            Dim query As String = "INSERT INTO Pelanggan (NamaPelanggan, Alamat, NoTelepon) VALUES (@NamaPelanggan, @Alamat, @NoTelepon)"

            ' Buat objek perintah SQL dengan parameter
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@NamaPelanggan", txtNamaPelanggan.Text)
            command.Parameters.AddWithValue("@Alamat", txtAlamatPelanggan.Text)
            command.Parameters.AddWithValue("@NoTelepon", txtNoTelepon.Text)

            ' Buka koneksi database
            connection.Open()

            ' Jalankan perintah SQL
            command.ExecuteNonQuery()

            ' Tampilkan data pelanggan terbaru di DataGridView
            TampilkanDataPelanggan()

            ' Kosongkan input data setelah berhasil tambah pelanggan
            KosongkanInputData()
        End Using
    End Sub

    ' Event klik tombol Ubah Pelanggan
    Private Sub BtnUbahPelanggan_Click(sender As Object, e As EventArgs) Handles btnUpdatePelanggan.Click
        ' Validasi pemilihan data pada DataGridView
        If DataGridViewPelanggan.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data pelanggan terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Ambil ID pelanggan dari data terpilih
        Dim idPelanggan As Integer = CInt(DataGridViewPelanggan.SelectedRows(0).Cells("IdPelanggan").Value)

        ' Buat objek koneksi database
        Using connection As New SqlConnection(connectionString)
            ' Buat perintah SQL untuk update data pelanggan
            Dim query As String = "UPDATE Pelanggan SET NamaPelanggan = @NamaPelanggan, Alamat = @Alamat, NoTelepon = @NoTelepon WHERE IdPelanggan = @IdPelanggan"

            ' Buat objek perintah SQL dengan parameter
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@NamaPelanggan", txtNamaPelanggan.Text)
            command.Parameters.AddWithValue("@Alamat", txtAlamatPelanggan.Text)
            command.Parameters.AddWithValue("@NoTelepon", txtNoTelepon.Text)
            command.Parameters.AddWithValue("@IdPelanggan", idPelanggan)

            ' Buka koneksi database
            connection.Open()

            ' Jalankan perintah SQL
            command.ExecuteNonQuery()

            ' Tampilkan data pelanggan terbaru di DataGridView
            TampilkanDataPelanggan()

            ' Kosongkan input data setelah berhasil ubah pelanggan
            KosongkanInputData()
        End Using
    End Sub

    ' Event klik tombol Hapus Pelanggan
    Private Sub BtnHapusPelanggan_Click(sender As Object, e As EventArgs) Handles BtnHapusPelanggan.Click
        ' Validasi pemilihan data pada DataGridView
        If DataGridViewPelanggan.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data pelanggan terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Tampilkan dialog konfirmasi hapus data
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data pelanggan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Jika user mengonfirmasi hapus data
        If result = DialogResult.Yes Then
            ' Ambil ID pelanggan dari data terpilih
            Dim idPelanggan As Integer = CInt(DataGridViewPelanggan.SelectedRows(0).Cells("IdPelanggan").Value)

            ' Buat objek koneksi database
            Using connection As New SqlConnection(connectionString)
                ' Buat perintah SQL untuk delete data pelanggan
                Dim query As String = "DELETE FROM Pelanggan WHERE IdPelanggan = @IdPelanggan"

                ' Buat objek perintah SQL dengan parameter
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@IdPelanggan", idPelanggan)

                ' Buka koneksi database
                connection.Open()

                ' Jalankan perintah SQL
                command.ExecuteNonQuery()

                ' Tampilkan data pelanggan terbaru di DataGridView
                TampilkanDataPelanggan()

                ' Kosongkan input data setelah berhasil hapus pelanggan
                KosongkanInputData()
            End Using
        End If
    End Sub

    ' Event klik tombol Cari Pelanggan
    Private Sub BtnCariPelanggan_Click(sender As Object, e As EventArgs) Handles BtnCariPelanggan.Click
        ' Baca nama pelanggan yang ingin dicari
        Dim namaPelanggan As String = TxtCariPelanggan.Text.Trim()

        ' Jika nama pelanggan tidak kosong
        If Not String.IsNullOrEmpty(namaPelanggan) Then
            ' Buat objek koneksi database
            Using connection As New SqlConnection(connectionString)
                ' Buat perintah SQL untuk mencari pelanggan berdasarkan nama
                Dim query As String = "SELECT * FROM Pelanggan WHERE NamaPelanggan LIKE '%' + @NamaPelanggan + '%'"

                ' Buat objek perintah SQL dengan parameter
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@NamaPelanggan", namaPelanggan)

                ' Buat objek SqlDataAdapter untuk menampung hasil query
                Dim adapter As New SqlDataAdapter(command)

                ' Buat objek DataTable untuk menampung data pelanggan
                Dim table As New DataTable()

                ' Buka koneksi database
                connection.Open()

                ' Isi data pelanggan ke objek DataTable
                adapter.Fill(table)

                ' Tampilkan data pelanggan di DataGridView
                DataGridViewPelanggan.DataSource = table
            End Using
        Else
            ' Jika nama pelanggan kosong, tampilkan semua data pelanggan
            TampilkanDataPelanggan()
        End If
    End Sub

    ' Event klik data pada DataGridView
    Private Sub DataGridViewPelanggan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPelanggan.CellClick
        ' Ambil data dari DataGridView dan isi ke TextBox
        If DataGridViewPelanggan.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridViewPelanggan.SelectedRows(0)
            txtNamaPelanggan.Text = selectedRow.Cells("NamaPelanggan").Value.ToString()
            txtAlamatPelanggan.Text = selectedRow.Cells("Alamat").Value.ToString()
            txtNoTelepon.Text = selectedRow.Cells("NoTelepon").Value.ToString()
        End If
    End Sub

    ' Method untuk menampilkan data pelanggan di DataGridView
    Private Sub TampilkanDataPelanggan()
        ' Buat objek koneksi database
        Using connection As New SqlConnection(connectionString)
            ' Buat perintah SQL untuk select semua data pelanggan
            Dim query As String = "SELECT * FROM Pelanggan"

            ' Buat objek perintah SQL
            Dim command As New SqlCommand(query, connection)

            ' Buat objek SqlDataAdapter untuk menampung hasil query
            Dim adapter As New SqlDataAdapter(command)

            ' Buat objek DataTable untuk menampung data pelanggan
            Dim table As New DataTable()

            ' Buka koneksi database
            connection.Open()

            ' Isi data pelanggan ke objek DataTable
            adapter.Fill(table)

            ' Tampilkan data pelanggan di DataGridView
            DataGridViewPelanggan.DataSource = table
        End Using
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        KosongkanInputData()
    End Sub

    ' Method untuk mengosongkan input data
    Private Sub KosongkanInputData()
        txtNamaPelanggan.Text = ""
        txtAlamatPelanggan.Text = ""
        txtNoTelepon.Text = ""
    End Sub


End Class

