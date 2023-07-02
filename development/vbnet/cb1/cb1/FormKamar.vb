Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles

Public Class FormKamar
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
    Private Sub FormKamar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanDataKamar()
    End Sub

    ' Event klik tombol Tambah Kamar
    Private Sub BtnTambahKamar_Click(sender As Object, e As EventArgs) Handles BtnTambahKamar.Click
        ' Validasi input data
        If String.IsNullOrEmpty(txtNamaKamar.Text) Then
            MessageBox.Show("Nama Kamar harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Buat objek koneksi database
        Using connection As New SqlConnection(connectionString)
            ' Buat perintah SQL untuk insert data Kamar
            Dim query As String = "INSERT INTO Kamar (NamaKamar, Harga, Status) VALUES (@NamaKamar, @Harga, @Status)"

            ' Buat objek perintah SQL dengan parameter
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@NamaKamar", txtNamaKamar.Text)
            command.Parameters.AddWithValue("@Harga", txtHargaKamar.Text)
            command.Parameters.AddWithValue("@Status", ComboBoxStatus.SelectedItem.ToString)

            ' Buka koneksi database
            connection.Open()

            ' Jalankan perintah SQL
            command.ExecuteNonQuery()

            ' Tampilkan data Kamar terbaru di DataGridView
            TampilkanDataKamar()

            ' Kosongkan input data setelah berhasil tambah Kamar
            KosongkanInputData()
        End Using
    End Sub

    ' Event klik tombol Ubah Kamar
    Private Sub BtnUbahKamar_Click(sender As Object, e As EventArgs) Handles BtnUpdateKamar.Click
        ' Validasi pemilihan data pada DataGridView
        If DataGridViewKamar.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data Kamar terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Ambil ID Kamar dari data terpilih
        Dim idKamar As Integer = CInt(DataGridViewKamar.SelectedRows(0).Cells("IdKamar").Value)

        ' Buat objek koneksi database
        Using connection As New SqlConnection(connectionString)
            ' Buat perintah SQL untuk update data Kamar
            Dim query As String = "UPDATE Kamar SET NamaKamar = @NamaKamar, Harga = @Harga, Status = @Status WHERE IdKamar = @IdKamar"

            ' Buat objek perintah SQL dengan parameter
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@NamaKamar", txtNamaKamar.Text)
            command.Parameters.AddWithValue("@Harga", txtHargaKamar.Text)
            command.Parameters.AddWithValue("@Status", ComboBoxStatus.SelectedItem.ToString)
            command.Parameters.AddWithValue("@IdKamar", idKamar)

            ' Buka koneksi database
            connection.Open()

            ' Jalankan perintah SQL
            command.ExecuteNonQuery()

            ' Tampilkan data Kamar terbaru di DataGridView
            TampilkanDataKamar()

            ' Kosongkan input data setelah berhasil ubah Kamar
            KosongkanInputData()
        End Using
    End Sub

    ' Event klik tombol Hapus Kamar
    Private Sub BtnHapusKamar_Click(sender As Object, e As EventArgs) Handles BtnHapusKamar.Click
        ' Validasi pemilihan data pada DataGridView
        If DataGridViewKamar.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data Kamar terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Tampilkan dialog konfirmasi hapus data
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data Kamar ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Jika user mengonfirmasi hapus data
        If result = DialogResult.Yes Then
            ' Ambil ID Kamar dari data terpilih
            Dim idKamar As Integer = CInt(DataGridViewKamar.SelectedRows(0).Cells("IdKamar").Value)

            ' Buat objek koneksi database
            Using connection As New SqlConnection(connectionString)
                ' Buat perintah SQL untuk delete data Kamar
                Dim query As String = "DELETE FROM Kamar WHERE IdKamar = @IdKamar"

                ' Buat objek perintah SQL dengan parameter
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@IdKamar", idKamar)

                ' Buka koneksi database
                connection.Open()

                ' Jalankan perintah SQL
                command.ExecuteNonQuery()

                ' Tampilkan data Kamar terbaru di DataGridView
                TampilkanDataKamar()

                ' Kosongkan input data setelah berhasil hapus Kamar
                KosongkanInputData()
            End Using
        End If
    End Sub

    ' Event klik tombol Cari Kamar
    Private Sub BtnCariKamar_Click(sender As Object, e As EventArgs) Handles BtnCariKamar.Click
        ' Baca nama Kamar yang ingin dicari
        Dim namaKamar As String = txtCariKamar.Text.Trim()

        ' Jika nama Kamar tidak kosong
        If Not String.IsNullOrEmpty(namaKamar) Then
            ' Buat objek koneksi database
            Using connection As New SqlConnection(connectionString)
                ' Buat perintah SQL untuk mencari Kamar berdasarkan nama
                Dim query As String = "SELECT * FROM Kamar WHERE NamaKamar LIKE '%' + @NamaKamar + '%'"

                ' Buat objek perintah SQL dengan parameter
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@NamaKamar", namaKamar)

                ' Buat objek SqlDataAdapter untuk menampung hasil query
                Dim adapter As New SqlDataAdapter(command)

                ' Buat objek DataTable untuk menampung data Kamar
                Dim table As New DataTable()

                ' Buka koneksi database
                connection.Open()

                ' Isi data Kamar ke objek DataTable
                adapter.Fill(table)

                ' Tampilkan data Kamar di DataGridView
                DataGridViewKamar.DataSource = table
            End Using
        Else
            ' Jika nama Kamar kosong, tampilkan semua data Kamar
            TampilkanDataKamar()
        End If
    End Sub

    ' Event klik data pada DataGridView
    Private Sub DataGridViewKamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewKamar.CellClick
        ' Ambil data dari DataGridView dan isi ke TextBox
        If DataGridViewKamar.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridViewKamar.SelectedRows(0)
            txtNamaKamar.Text = selectedRow.Cells("NamaKamar").Value.ToString()
            txtHargaKamar.Text = selectedRow.Cells("Harga").Value.ToString()
            ComboBoxStatus.SelectedItem = selectedRow.Cells("Status").Value.ToString()
        End If
    End Sub

    ' Method untuk menampilkan data Kamar di DataGridView
    Private Sub TampilkanDataKamar()
        ' Buat objek koneksi database
        Using connection As New SqlConnection(connectionString)
            ' Buat perintah SQL untuk select semua data Kamar
            Dim query As String = "SELECT * FROM Kamar"

            ' Buat objek perintah SQL
            Dim command As New SqlCommand(query, connection)

            ' Buat objek SqlDataAdapter untuk menampung hasil query
            Dim adapter As New SqlDataAdapter(command)

            ' Buat objek DataTable untuk menampung data Kamar
            Dim table As New DataTable()

            ' Buka koneksi database
            connection.Open()

            ' Isi data Kamar ke objek DataTable
            adapter.Fill(table)

            ' Tampilkan data Kamar di DataGridView
            DataGridViewKamar.DataSource = table
        End Using
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        KosongkanInputData()
    End Sub

    ' Method untuk mengosongkan input data
    Private Sub KosongkanInputData()
        txtNamaKamar.Text = ""
        txtHargaKamar.Text = ""
        ComboBoxStatus.SelectedItem = ""
    End Sub


End Class