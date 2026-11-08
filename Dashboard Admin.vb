Public Class Dashboard_Admin
    Private _kembaliKeLogin As Boolean = False

    Private Sub Dashboard_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnTransaksi.Visible = True
        btnProduk.Visible = True
    End Sub

    Private Sub BukaForm(frm As Form)
        frm.Tag = Me
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        BukaForm(New Transaksi())
    End Sub

    Private Sub btnProduk_Click(sender As Object, e As EventArgs) Handles btnProduk.Click
        BukaForm(New Produk())
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim konfirmasi As DialogResult = MessageBox.Show(
            "Apakah Anda yakin ingin kembali ke halaman Login?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)
        If konfirmasi = DialogResult.Yes Then
            Module1.namaUser = ""
            Module1.levelUser = ""
            Module1.idUser = ""
            _kembaliKeLogin = True
            Dim frm As New Login()
            frm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Dashboard_Admin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If _kembaliKeLogin Then Exit Sub
        If e.CloseReason = CloseReason.UserClosing Then
            Dim konfirmasi As DialogResult = MessageBox.Show(
                "Apakah Anda yakin ingin keluar dari aplikasi?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
            If konfirmasi = DialogResult.Yes Then
                Module1.namaUser = ""
                Module1.levelUser = ""
                Module1.idUser = ""
                Application.Exit()
            Else
                e.Cancel = True
            End If
        End If
    End Sub
End Class