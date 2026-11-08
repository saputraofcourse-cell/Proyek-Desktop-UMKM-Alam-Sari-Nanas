Imports System.Data.OleDb

Public Class Transaksi

    Dim dtKeranjang As New DataTable()
    Dim indexEdit As Integer = -1

    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitKeranjang()
        LoadCmbNama()
        GenerateIDTransaksi()
        txtIDkasir.Text = Module1.idUser
        txtKasir.Text = Module1.namaUser
        dtTransaksi.Value = Now
        dtTransaksi.MaxDate = Now.Date  ' [PERBAIKAN 3] Blokir tanggal masa depan di kalender
        txtKode.ReadOnly = True
        txtHarga.ReadOnly = True
        txtSub.ReadOnly = True
        txtTotal.ReadOnly = True
        txtKembalian.ReadOnly = True
        txtIDtransaksi.ReadOnly = True
        txtIDkasir.ReadOnly = True
        txtKasir.ReadOnly = True
        lblStok.Text = "-"
    End Sub

    Private Sub InitKeranjang()
        dtKeranjang.Columns.Clear()
        dtKeranjang.Columns.Add("KodeProduk", GetType(String))
        dtKeranjang.Columns.Add("NamaProduk", GetType(String))
        dtKeranjang.Columns.Add("Harga", GetType(Decimal))
        dtKeranjang.Columns.Add("Jumlah", GetType(Integer))
        dtKeranjang.Columns.Add("SubTotal", GetType(Decimal))

        dgv1.DataSource = dtKeranjang
        dgv1.Columns("KodeProduk").HeaderText = "Kode Produk"
        dgv1.Columns("NamaProduk").HeaderText = "Nama Produk"
        dgv1.Columns("Harga").HeaderText = "Harga"
        dgv1.Columns("Jumlah").HeaderText = "Jumlah"
        dgv1.Columns("SubTotal").HeaderText = "Sub Total"
        dgv1.ReadOnly = True
        dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv1.AllowUserToAddRows = False
    End Sub

    Private Sub LoadCmbNama()
        Try
            Using conn As New OleDbConnection(Module1.connStr)
                conn.Open()
                Using cmd As New OleDbCommand(
                    "SELECT Nama_Produk FROM Produk ORDER BY Nama_Produk", conn)
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        cmbNama.Items.Clear()
                        While reader.Read()
                            cmbNama.Items.Add(reader("Nama_Produk").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data produk: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GenerateIDTransaksi()
        Try
            Using conn As New OleDbConnection(Module1.connStr)
                conn.Open()
                Dim tgl As String = Format(Now, "yyyyMMdd")
                Dim prefix As String = "TRX-" & tgl & "-"
                Using cmd As New OleDbCommand(
                    "SELECT COUNT(*) FROM Transaksi WHERE Id_Transaksi LIKE '" & prefix & "%'", conn)
                    Dim count As Integer = CInt(cmd.ExecuteScalar()) + 1
                    txtIDtransaksi.Text = prefix & count.ToString("000")
                End Using
            End Using
        Catch ex As Exception
            txtIDtransaksi.Text = "TRX-" & Format(Now, "yyyyMMdd") & "-001"
        End Try
    End Sub

    Private Sub cmbNama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNama.SelectedIndexChanged
        If cmbNama.SelectedIndex = -1 Then Exit Sub
        Try
            Using conn As New OleDbConnection(Module1.connStr)
                conn.Open()
                Using cmd As New OleDbCommand(
                    "SELECT KodeProduk, Harga, Stok FROM Produk WHERE Nama_Produk = ?", conn)
                    cmd.Parameters.AddWithValue("?", cmbNama.SelectedItem.ToString())
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtKode.Text = reader("KodeProduk").ToString()
                            txtHarga.Text = FormatNumber(reader("Harga"), 0)
                            lblStok.Text = reader("Stok").ToString()
                        End If
                    End Using
                End Using
            End Using
            HitungSubTotal()
        Catch ex As Exception
            MessageBox.Show("Gagal ambil data produk: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtJumlahproduk_TextChanged(sender As Object, e As EventArgs) Handles txtJumlahproduk.TextChanged
        HitungSubTotal()
    End Sub

    ' [PERBAIKAN 2] Blokir input huruf pada txtJumlahproduk, hanya izinkan angka dan Backspace
    Private Sub txtJumlahproduk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlahproduk.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = Convert.ToChar(Keys.Back)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub HitungSubTotal()
        Dim harga As Decimal = 0
        Dim jumlah As Integer = 0
        Decimal.TryParse(txtHarga.Text.Replace(",", ""), harga)
        Integer.TryParse(txtJumlahproduk.Text, jumlah)
        txtSub.Text = FormatNumber(harga * jumlah, 0)
    End Sub

    Private Sub HitungTotal()
        Dim total As Decimal = 0
        For Each row As DataRow In dtKeranjang.Rows
            If row.RowState <> DataRowState.Deleted Then
                total += CDec(row("SubTotal"))
            End If
        Next
        txtTotal.Text = FormatNumber(total, 0)
    End Sub

    Private Sub txtBayar_TextChanged(sender As Object, e As EventArgs) Handles txtBayar.TextChanged
        Dim bayar As Decimal = 0
        Dim total As Decimal = 0
        Decimal.TryParse(txtBayar.Text.Replace(",", ""), bayar)
        Decimal.TryParse(txtTotal.Text.Replace(",", ""), total)
        If bayar >= total AndAlso total > 0 Then
            txtKembalian.Text = FormatNumber(bayar - total, 0)
        Else
            txtKembalian.Text = "0"
        End If
    End Sub

    ' [PERBAIKAN 3] Validasi tanggal tidak boleh masa depan saat user mengubah nilai
    Private Sub dtTransaksi_ValueChanged(sender As Object, e As EventArgs) Handles dtTransaksi.ValueChanged
        If dtTransaksi.Value.Date <> Now.Date Then
            MessageBox.Show("Tanggal harus hari ini!",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtTransaksi.Value = Now.Date
        End If
    End Sub

    ' -------------------------------------------------------
    ' TAMBAH ITEM KE KERANJANG
    ' -------------------------------------------------------
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If cmbNama.SelectedIndex = -1 Then
            MessageBox.Show("Pilih nama produk terlebih dahulu!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbNama.Focus()
            Exit Sub
        End If
        If txtJumlahproduk.Text.Trim() = "" OrElse Not IsNumeric(txtJumlahproduk.Text) Then
            MessageBox.Show("Jumlah produk harus diisi dengan angka!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtJumlahproduk.Focus()
            Exit Sub
        End If

        Dim jumlah As Integer = CInt(txtJumlahproduk.Text)
        If jumlah <= 0 Then
            MessageBox.Show("Jumlah produk harus lebih dari 0!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Cek stok dari DB
        Dim stokDB As Integer = 0
        Try
            Using conn As New OleDbConnection(Module1.connStr)
                conn.Open()
                Using cmd As New OleDbCommand(
                    "SELECT Stok FROM Produk WHERE KodeProduk = ?", conn)
                    cmd.Parameters.AddWithValue("?", txtKode.Text)
                    stokDB = CInt(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal cek stok: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        If jumlah > stokDB Then
            MessageBox.Show("Stok tidak mencukupi! Stok tersedia: " & stokDB, "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim harga As Decimal = 0
        Decimal.TryParse(txtHarga.Text.Replace(",", ""), harga)
        Dim subTotal As Decimal = harga * jumlah

        If indexEdit >= 0 Then
            dtKeranjang.Rows(indexEdit)("Jumlah") = jumlah
            dtKeranjang.Rows(indexEdit)("SubTotal") = subTotal
            indexEdit = -1
            btnTambah.Text = "Tambah"
        Else
            Dim duplikat As Boolean = False
            For Each row As DataRow In dtKeranjang.Rows
                If row("KodeProduk").ToString() = txtKode.Text Then
                    row("Jumlah") = CInt(row("Jumlah")) + jumlah
                    row("SubTotal") = CDec(row("Harga")) * CInt(row("Jumlah"))
                    duplikat = True
                    Exit For
                End If
            Next
            If Not duplikat Then
                dtKeranjang.Rows.Add(txtKode.Text, cmbNama.SelectedItem.ToString(),
                                     harga, jumlah, subTotal)
            End If
        End If

        HitungTotal()
        BersihkanInputProduk()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgv1.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih baris yang ingin diedit!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        indexEdit = dgv1.SelectedRows(0).Index
        Dim row As DataRow = dtKeranjang.Rows(indexEdit)
        txtKode.Text = row("KodeProduk").ToString()
        cmbNama.SelectedItem = row("NamaProduk").ToString()
        txtHarga.Text = FormatNumber(CDec(row("Harga")), 0)
        txtJumlahproduk.Text = row("Jumlah").ToString()
        txtSub.Text = FormatNumber(CDec(row("SubTotal")), 0)
        btnTambah.Text = "Update"
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgv1.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih baris yang ingin dihapus!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show(
            "Hapus item ini dari keranjang?", "Konfirmasi",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            dtKeranjang.Rows(dgv1.SelectedRows(0).Index).Delete()
            HitungTotal()
            BersihkanInputProduk()
        End If
    End Sub

    ' -------------------------------------------------------
    ' [PERBAIKAN 1] SIMPAN & CETAK DIGABUNG DALAM SATU TOMBOL
    ' Nama tombol di designer: btnSimpanCetak
    ' -------------------------------------------------------
    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        ' === VALIDASI ===
        If dtKeranjang.Rows.Count = 0 Then
            MessageBox.Show("Keranjang masih kosong! Tambahkan produk terlebih dahulu.",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtBayar.Text.Trim() = "" OrElse Not IsNumeric(txtBayar.Text) Then
            MessageBox.Show("Isi jumlah bayar terlebih dahulu dengan angka yang benar!",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBayar.Focus()
            Exit Sub
        End If

        Dim bayar As Decimal = CDec(txtBayar.Text)
        Dim total As Decimal = 0
        Decimal.TryParse(txtTotal.Text.Replace(",", ""), total)

        If bayar < total Then
            MessageBox.Show("Jumlah bayar kurang dari total harga!" & vbNewLine &
                            "Total: Rp " & total.ToString("N0") & vbNewLine &
                            "Bayar: Rp " & bayar.ToString("N0"),
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBayar.Focus()
            Exit Sub
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show(
            "Simpan & cetak transaksi ini?" & vbNewLine & vbNewLine &
            "ID Transaksi : " & txtIDtransaksi.Text & vbNewLine &
            "Kasir        : " & txtKasir.Text & vbNewLine &
            "Total Harga  : Rp " & total.ToString("N0") & vbNewLine &
            "Bayar        : Rp " & bayar.ToString("N0") & vbNewLine &
            "Kembalian    : Rp " & (bayar - total).ToString("N0"),
            "Konfirmasi Simpan & Cetak", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.No Then Exit Sub

        ' === SIMPAN KE DATABASE ===
        Try
            Using conn As New OleDbConnection(Module1.connStr)
                conn.Open()

                ' 1. Insert header transaksi
                Using cmdTransaksi As New OleDbCommand(
                    "INSERT INTO Transaksi (Id_Transaksi, Tanggal, Id_User, Total_Harga, Bayar, Kembalian) " &
                    "VALUES (?, ?, ?, ?, ?, ?)", conn)
                    cmdTransaksi.Parameters.AddWithValue("?", txtIDtransaksi.Text)
                    cmdTransaksi.Parameters.AddWithValue("?", dtTransaksi.Value.Date)
                    cmdTransaksi.Parameters.AddWithValue("?", txtIDkasir.Text)
                    cmdTransaksi.Parameters.AddWithValue("?", total)
                    cmdTransaksi.Parameters.AddWithValue("?", bayar)
                    cmdTransaksi.Parameters.AddWithValue("?", bayar - total)
                    cmdTransaksi.ExecuteNonQuery()
                End Using

                ' 2. Insert detail & kurangi stok
                Dim noDetail As Integer = 1
                For Each row As DataRow In dtKeranjang.Rows
                    If row.RowState = DataRowState.Deleted Then Continue For

                    Dim idDetail As String = "DTL-" & txtIDtransaksi.Text & "-" & noDetail.ToString()

                    Using cmdDetail As New OleDbCommand(
                        "INSERT INTO Detail_Transaksi " &
                        "(Id_Detail, Id_Transaksi, KodeProduk, Harga_Satuan, Jumlah_Prod, SubTotal) " &
                        "VALUES (?, ?, ?, ?, ?, ?)", conn)
                        cmdDetail.Parameters.AddWithValue("?", idDetail)
                        cmdDetail.Parameters.AddWithValue("?", txtIDtransaksi.Text)
                        cmdDetail.Parameters.AddWithValue("?", row("KodeProduk").ToString())
                        cmdDetail.Parameters.AddWithValue("?", CDec(row("Harga")))
                        cmdDetail.Parameters.AddWithValue("?", CInt(row("Jumlah")))
                        cmdDetail.Parameters.AddWithValue("?", CDec(row("SubTotal")))
                        cmdDetail.ExecuteNonQuery()
                    End Using

                    Using cmdStok As New OleDbCommand(
                        "UPDATE Produk SET Stok = Stok - ? WHERE KodeProduk = ?", conn)
                        cmdStok.Parameters.AddWithValue("?", CInt(row("Jumlah")))
                        cmdStok.Parameters.AddWithValue("?", row("KodeProduk").ToString())
                        cmdStok.ExecuteNonQuery()
                    End Using

                    noDetail += 1
                Next
            End Using ' <-- conn.Close() otomatis dipanggil di sini

            ' === LANGSUNG CETAK STRUK SETELAH SIMPAN BERHASIL ===
            Module1.gIDTransaksi = txtIDtransaksi.Text
            Module1.gKasir = txtKasir.Text
            Module1.gTanggal = dtTransaksi.Value.ToString("dd/MM/yyyy HH:mm")
            Module1.gTotalHarga = total.ToString()
            Module1.gBayar = bayar.ToString()
            Module1.gKembalian = (bayar - total).ToString()

            Module1.gDetailTransaksi = New DataTable()
            Module1.gDetailTransaksi.Columns.Add("NamaProduk", GetType(String))
            Module1.gDetailTransaksi.Columns.Add("Jumlah", GetType(Integer))
            Module1.gDetailTransaksi.Columns.Add("Harga", GetType(Decimal))
            Module1.gDetailTransaksi.Columns.Add("SubTotal", GetType(Decimal))

            For Each row As DataRow In dtKeranjang.Rows
                If row.RowState <> DataRowState.Deleted Then
                    Module1.gDetailTransaksi.Rows.Add(
                        row("NamaProduk").ToString(),
                        CInt(row("Jumlah")),
                        CDec(row("Harga")),
                        CDec(row("SubTotal")))
                End If
            Next

            Dim frmStruk As New Struk()
            frmStruk.ShowDialog()

            ResetForm()

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan transaksi: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBatal2_Click(sender As Object, e As EventArgs) Handles btnBatal2.Click
        Dim konfirmasi As DialogResult = MessageBox.Show(
            "Batalkan transaksi ini? Semua data akan dihapus.", "Konfirmasi",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.Yes Then ResetForm()
    End Sub

    Private Sub btnKembalitransaksi_Click(sender As Object, e As EventArgs) Handles btnKembalitransaksi.Click
        If dtKeranjang.Rows.Count > 0 Then
            Dim konfirmasi As DialogResult = MessageBox.Show(
                "Ada transaksi yang belum disimpan. Yakin ingin kembali?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If konfirmasi = DialogResult.No Then Exit Sub
        End If
        TampilDashboard()
        Me.Close()
    End Sub

    Private Sub Transaksi_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            TampilDashboard()
        End If
    End Sub

    Private Sub TampilDashboard()
        If Me.Tag IsNot Nothing AndAlso TypeOf Me.Tag Is Form Then
            CType(Me.Tag, Form).Show()
        Else
            If Module1.levelUser.ToLower() = "owner" Then
                Dim dashOwner As New Dashboard()
                dashOwner.Show()
            ElseIf Module1.levelUser.ToLower() = "admin" Then
                Dim dashAdmin As New Dashboard_Admin()
                dashAdmin.Show()
            End If
        End If
    End Sub

    Private Sub BersihkanInputProduk()
        cmbNama.SelectedIndex = -1
        txtKode.Text = ""
        txtHarga.Text = ""
        txtJumlahproduk.Text = ""
        txtSub.Text = ""
        lblStok.Text = "-"
        indexEdit = -1
        btnTambah.Text = "Tambah"
    End Sub

    Private Sub ResetForm()
        dtKeranjang.Rows.Clear()
        BersihkanInputProduk()
        txtBayar.Text = ""
        txtKembalian.Text = ""
        txtTotal.Text = ""
        GenerateIDTransaksi()
        dtTransaksi.Value = Now.Date  ' <-- ganti Now menjadi Now.Date
    End Sub
End Class
