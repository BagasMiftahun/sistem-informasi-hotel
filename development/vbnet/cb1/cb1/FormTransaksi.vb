Imports System.Data.SqlClient

Public Class FormTransaksi

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
    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataNamaPelanggan()
        LoadDataNamaKamar()
        TampilkanDataTransaksi()
    End Sub


    Private Sub LoadDataNamaPelanggan()
        ComboBoxNamaPelanggan.Items.Clear()

        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "SELECT IdPelanggan, NamaPelanggan FROM Pelanggan"
                Dim command As New SqlCommand(query, connection)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim idPelanggan As Integer = reader.GetInt32(0)
                    Dim namaPelanggan As String = reader.GetString(1)
                    ComboBoxNamaPelanggan.Items.Add(New KeyValuePair(Of Integer, String)(idPelanggan, namaPelanggan))
                End While

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat mengambil data nama pelanggan: " & ex.Message)
        End Try
    End Sub


    Private Sub LoadDataNamaKamar()
        ComboBoxNamaKamar.Items.Clear()

        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "SELECT IdKamar, NamaKamar FROM Kamar"
                Dim command As New SqlCommand(query, connection)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim idKamar As Integer = reader.GetInt32(0)
                    Dim namaKamar As String = reader.GetString(1)
                    ComboBoxNamaKamar.Items.Add(New KeyValuePair(Of Integer, String)(idKamar, namaKamar))
                End While

                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat mengambil data nama kamar: " & ex.Message)
        End Try
    End Sub

    ' Event klik tombol Tambah Transaksi
    Private Sub BtnTambahTransaksi_Click(sender As Object, e As EventArgs) Handles btnTambahTransaksi.Click
        ' Validasi input data
        If String.IsNullOrEmpty(ComboBoxNamaPelanggan.Text) Then
            MessageBox.Show("Nama Pelanggan harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim selectedPelanggan As KeyValuePair(Of Integer, String) = DirectCast(ComboBoxNamaPelanggan.SelectedItem, KeyValuePair(Of Integer, String))
        Dim idPelanggan As Integer = selectedPelanggan.Key

        Dim selectedKamar As KeyValuePair(Of Integer, String) = DirectCast(ComboBoxNamaKamar.SelectedItem, KeyValuePair(Of Integer, String))
        Dim idKamar As Integer = selectedKamar.Key

        ' Buat objek koneksi database
        Using connection As New SqlConnection(connectionString)
            ' Buat perintah SQL untuk insert data Transaksi
            Dim query As String = "INSERT INTO Transaksi (IdPelanggan, IdKamar,TanggalPesan, TanggalCheckIn, TanggalCheckOut, JumlahTamu, TotalHarga) VALUES (@NamaPelanggan, @NamaKamar, @TanggalPesan, @TanggalCheckIn, @TanggalCheckOut, @JumlahTamu, @TotalHarga)"

            ' Buat objek perintah SQL dengan parameter
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@NamaPelanggan", idPelanggan)
            command.Parameters.AddWithValue("@NamaKamar", idKamar)
            command.Parameters.AddWithValue("@TanggalPesan", dtpTanggalPesan.Value)
            command.Parameters.AddWithValue("@TanggalCheckIn", dtpCheckIn.Value)
            command.Parameters.AddWithValue("@TanggalCheckOut", dtpCheckOut.Value)
            command.Parameters.AddWithValue("@JumlahTamu", txtJumlahTamu.Text)
            command.Parameters.AddWithValue("@TotalHarga", txtTotalHarga.Text)
            ' Buka koneksi database
            connection.Open()

            ' Jalankan perintah SQL
            command.ExecuteNonQuery()

            ' Tampilkan data Transaksi terbaru di DataGridView
            TampilkanDataTransaksi()

            ' Kosongkan input data setelah berhasil tambah Transaksi
            KosongkanInputData()
        End Using
    End Sub

    ' Event klik tombol Ubah Transaksi
    Private Sub BtnUbahTransaksi_Click(sender As Object, e As EventArgs) Handles btnUpdateTransaksi.Click
        ' Validasi pemilihan data pada DataGridView
        If DataGridViewTransaksi.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data Transaksi terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim selectedPelanggan As KeyValuePair(Of Integer, String) = DirectCast(ComboBoxNamaPelanggan.SelectedItem, KeyValuePair(Of Integer, String))
        Dim idPelanggan As Integer = selectedPelanggan.Key

        Dim selectedKamar As KeyValuePair(Of Integer, String) = DirectCast(ComboBoxNamaKamar.SelectedItem, KeyValuePair(Of Integer, String))
        Dim idKamar As Integer = selectedKamar.Key

        ' Ambil ID Transaksi dari data terpilih
        Dim idTransaksi As Integer = CInt(DataGridViewTransaksi.SelectedRows(0).Cells("IdTransaksi").Value)

        ' Buat objek koneksi database
        Using connection As New SqlConnection(connectionString)
            ' Buat perintah SQL untuk update data Transaksi
            Dim query As String = "UPDATE Transaksi SET IdPelanggan = @NamaPelanggan, IdKamar = @NamaKamar, TanggalPesan = @TanggalPesan, TanggalCheckIn = @TanggalCheckIn, TanggalCheckOut = @TanggalCheckOut, JumlahTamu = @JumlahTamu, TotalHarga = @TotalHarga WHERE IdTransaksi = @IdTransaksi"

            ' Buat objek perintah SQL dengan parameter
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@NamaPelanggan", idPelanggan)
            command.Parameters.AddWithValue("@NamaKamar", idKamar)
            command.Parameters.AddWithValue("@TanggalPesan", dtpTanggalPesan.Value)
            command.Parameters.AddWithValue("@TanggalCheckIn", dtpCheckIn.Value)
            command.Parameters.AddWithValue("@TanggalCheckOut", dtpCheckOut.Value)
            command.Parameters.AddWithValue("@JumlahTamu", txtJumlahTamu.Text)
            command.Parameters.AddWithValue("@TotalHarga", txtTotalHarga.Text)
            command.Parameters.AddWithValue("@IdTransaksi", idTransaksi)

            ' Buka koneksi database
            connection.Open()

            ' Jalankan perintah SQL
            command.ExecuteNonQuery()

            ' Tampilkan data Transaksi terbaru di DataGridView
            TampilkanDataTransaksi()

            ' Kosongkan input data setelah berhasil ubah Transaksi
            KosongkanInputData()
        End Using
    End Sub

    ' Event klik tombol Hapus Transaksi
    Private Sub BtnHapusTransaksi_Click(sender As Object, e As EventArgs) Handles BtnHapusTransaksi.Click
        ' Validasi pemilihan data pada DataGridView
        If DataGridViewTransaksi.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data Transaksi terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Tampilkan dialog konfirmasi hapus data
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data Transaksi ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Jika user mengonfirmasi hapus data
        If result = DialogResult.Yes Then
            ' Ambil ID Transaksi dari data terpilih
            Dim idTransaksi As Integer = CInt(DataGridViewTransaksi.SelectedRows(0).Cells("IdTransaksi").Value)

            ' Buat objek koneksi database
            Using connection As New SqlConnection(connectionString)
                ' Buat perintah SQL untuk delete data Transaksi
                Dim query As String = "DELETE FROM Transaksi WHERE IdTransaksi = @IdTransaksi"

                ' Buat objek perintah SQL dengan parameter
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@IdTransaksi", idTransaksi)

                ' Buka koneksi database
                connection.Open()

                ' Jalankan perintah SQL
                command.ExecuteNonQuery()

                ' Tampilkan data Transaksi terbaru di DataGridView
                TampilkanDataTransaksi()

                ' Kosongkan input data setelah berhasil hapus Transaksi
                KosongkanInputData()
            End Using
        End If
    End Sub

    ' Event klik tombol Cari Transaksi
    Private Sub BtnCariTransaksi_Click(sender As Object, e As EventArgs) Handles btnCariTransaksi.Click
        ' Baca nama Transaksi yang ingin dicari
        Dim tanggalPesan As Date = dtpCariTransaksi.Value
        ' Jika nama Transaksi tidak kosong
        If Not String.IsNullOrEmpty(tanggalPesan) Then
            ' Buat objek koneksi database
            Using connection As New SqlConnection(connectionString)
                ' Buat perintah SQL untuk mencari Transaksi berdasarkan nama
                Dim query As String = "SELECT * FROM Transaksi WHERE TanggalPesan = @TanggalPesan"

                ' Buat objek perintah SQL dengan parameter
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@TanggalPesan", tanggalPesan)

                ' Buat objek SqlDataAdapter untuk menampung hasil query
                Dim adapter As New SqlDataAdapter(command)

                ' Buat objek DataTable untuk menampung data pelanggan
                Dim dataSet As New DataSet()

                ' Buka koneksi database
                connection.Open()

                ' Isi data Transaksi ke objek DataTable
                adapter.Fill(dataSet, "Transaksi")

                ' Tampilkan data Transaksi di DataGridView
                DataGridViewTransaksi.DataSource = dataSet.Tables("Transaksi")
            End Using
        Else
            ' Jika nama Transaksi kosong, tampilkan semua data Transaksi
            TampilkanDataTransaksi()
        End If
    End Sub

    ' Event klik data pada DataGridView
    Private Sub DataGridViewTransaksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewTransaksi.CellClick
        ' Ambil data dari DataGridView dan isi ke TextBox
        If DataGridViewTransaksi.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridViewTransaksi.SelectedRows(0)
            ComboBoxNamaPelanggan.SelectedItem = selectedRow.Cells("IdPelanggan").Value.ToString()
            ComboBoxNamaKamar.SelectedItem = selectedRow.Cells("IdKamar").Value.ToString()
            dtpTanggalPesan.Value = selectedRow.Cells("TanggalPesan").Value.ToString()
            dtpCheckIn.Value = selectedRow.Cells("TanggalCheckIn").Value.ToString()
            dtpCheckOut.Value = selectedRow.Cells("TanggalCheckOut").Value.ToString()
            txtJumlahTamu.Text = selectedRow.Cells("JumlahTamu").Value.ToString()
            txtTotalHarga.Text = selectedRow.Cells("TotalHarga").Value.ToString()
        End If
    End Sub

    ' Method untuk menampilkan data pelanggan di DataGridView
    Private Sub TampilkanDataTransaksi()
        ' Buat objek koneksi database
        Using connection As New SqlConnection(connectionString)
            ' Buat perintah SQL untuk select semua data Transaksi
            Dim query As String = "SELECT * FROM Transaksi"

            ' Buat objek perintah SQL
            Dim command As New SqlCommand(query, connection)

            ' Buat objek SqlDataAdapter untuk menampung hasil query
            Dim adapter As New SqlDataAdapter(command)

            ' Buat objek DataTable untuk menampung data Transaksi
            Dim table As New DataTable()

            ' Buka koneksi database
            connection.Open()

            ' Isi data Transaksi ke objek DataTable
            adapter.Fill(table)

            ' Tampilkan data Transaksi di DataGridView
            DataGridViewTransaksi.DataSource = table
        End Using
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        KosongkanInputData()
    End Sub

    ' Method untuk mengosongkan input data
    Private Sub KosongkanInputData()
        txtJumlahTamu.Text = ""
        txtTotalHarga.Text = ""
    End Sub
End Class