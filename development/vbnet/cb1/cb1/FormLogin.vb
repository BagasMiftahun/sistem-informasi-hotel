Public Class FormLogin
    ' Event klik tombol "Masuk"
    Private Sub ButtonMasuk_Click(sender As Object, e As EventArgs) Handles ButtonMasuk.Click
        ' Buka FormHome sebagai tampilan home
        Dim formHome As New FormPelanggan()
        formHome.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Application.Exit()
    End Sub
End Class
