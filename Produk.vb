Imports System.Data.OleDb

Public Class Produk

    Dim sedangMemilihBaris As Boolean = False
    Dim sedangKembali As Boolean = False

    ' =========================================================
    ' CATATAN PENTING:
    ' Jangan simpan OleDbConnection sebagai field class (Dim conn As New ...).
    ' Gunakan Using block setiap kali agar koneksi pasti ditutup & data tersimpan.
    ' =========================================================

    Private Sub Produk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbKategori.Items.Clear()
        cmbKategori.Items.Add("Makanan")
        cmbKategori.Items.Add("Minuman")
        LoadDataProduk()
        BersihkanInput()
    End Sub

    ' -------------------------------------------------------
    ' LOAD DATA KE DATAGRIDVIEW
    ' -------------------------------------------------------
    Private Sub LoadDataProduk()
        Try
            Using conn As New OleDbConnection(Module1.connStr)
                conn.Open()
                Dim da As New OleDbDataAdapter(
                    "SELECT KodeProduk, Nama_Produk, Kategori, Harga, Stok " &
                    "FROM Produk ORDER BY KodeProduk", conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                dgv.DataSource = Nothing
                dgv.DataSource = dt
                dgv.ReadOnly = True
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                dgv.AllowUserToAddRows = False
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

                dgv.ColumnHeadersVisible = True
                dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                dgv.ColumnHeadersHeight = 30
                dgv.EnableHeadersVisualStyles = False
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumSlateBlue
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                dgv.ColumnHeadersDefaultCellStyle.Font = New Font(dgv.Font, FontStyle.Bold)
                dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                If dgv.Columns.Contains("KodeProduk") Then
                    dgv.Columns("KodeProduk").HeaderText = "Kode Produk"
                    dgv.Columns("KodeProduk").Width = 120
                End If
                If dgv.Columns.Contains("Nama_Produk") Then
                    dgv.Columns("Nama_Produk").HeaderText = "Nama Produk"
                    dgv.Columns("Nama_Produk").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End If
                If dgv.Columns.Contains("Kategori") Then
                    dgv.Columns("Kategori").HeaderText = "Kategori"
                    dgv.Columns("Kategori").Width = 120
                End If
                If dgv.Columns.Contains("Harga") Then
                    dgv.Columns("Harga").HeaderText = "Harga"
                    dgv.Columns("Harga").Width = 120
                    dgv.Columns("Harga").DefaultCellStyle.Format = "N0"
                    dgv.Columns("Harga").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                End If
                If dgv.Columns.Contains("Stok") Then
                    dgv.Columns("Stok").HeaderText = "Stok"
                    dgv.Columns("Stok").Width = 80
                    dgv.Columns("Stok").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -------------------------------------------------------
    ' PILIH BARIS DI DATAGRIDVIEW
    ' -------------------------------------------------------
    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If e.RowIndex < 0 Then Exit Sub
        sedangMemilihBaris = True
        Dim row As DataGridViewRow = dgv.Rows(e.RowIndex)
        txtKode.Text = row.Cells("KodeProduk").Value.ToString()
        txtNama.Text = row.Cells("Nama_Produk").Value.ToString()
        cmbKategori.Text = row.Cells("Kategori").Value.ToString()
        txtHarga.Text = row.Cells("Harga").Value.ToString()
        txtStok.Text = row.Cells("Stok").Value.ToString()
        sedangMemilihBaris = False
    End Sub

    ' -------------------------------------------------------
    ' GENERATE KODE PRODUK OTOMATIS
    ' -------------------------------------------------------
    Private Sub cmbKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKategori.SelectedIndexChanged
        If sedangMemilihBaris Then Exit Sub
        If cmbKategori.SelectedItem Is Nothing Then Exit Sub

        Dim kategoriBaru As String = cmbKategori.SelectedItem.ToString()
        Dim kodeSaatIni As String = txtKode.Text.Trim()

        If String.IsNullOrWhiteSpace(kodeSaatIni) Then
            txtKode.Text = GenerateKodeProduk(kategoriBaru)
            Exit Sub
        End If

        Dim prefixSaatIni As String = kodeSaatIni.Substring(0, 1).ToUpper()
        Dim prefixSeharusnya As String = If(kategoriBaru = "Minuman", "B", "A")

        If prefixSaatIni <> prefixSeharusnya Then
            txtKode.Text = GenerateKodeProduk(kategoriBaru)
        End If
    End Sub

    Private Function GenerateKodeProduk(kategori As String) As String
        Dim prefix As String = If(kategori = "Minuman", "B", "A")
        Dim maxNomor As Integer = 0

        Try
            Using conn As New OleDbConnection(Module1.connStr)
                conn.Open()
                Using cmd As New OleDbCommand(
                    "SELECT KodeProduk FROM Produk WHERE LEFT(KodeProduk, 1) = ?", conn)
                    cmd.Parameters.AddWithValue("?", prefix)
                    Using dr As OleDbDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            Dim kode As String = dr("KodeProduk").ToString()
                            If kode.Length > 1 Then
                                Dim nomor As Integer
                                If Integer.TryParse(kode.Substring(1), nomor) Then
                                    If nomor > maxNomor Then maxNomor = nomor
                                End If
                            End If
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Biarkan maxNomor = 0 kalau gagal
        End Try

        Return prefix & (maxNomor + 1).ToString("000")
    End Function

    ' -------------------------------------------------------
    ' TAMBAH PRODUK BARU
    ' -------------------------------------------------------
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Not ValidasiInput() Then Exit Sub

        Try
            Using conn As New OleDbConnection(Module1.connStr)
                conn.Open()

                ' Cek duplikat kode
                Using cmdCek As New OleDbCommand(
                    "SELECT COUNT(*) FROM Produk WHERE KodeProduk = ?", conn)
                    cmdCek.Parameters.AddWithValue("?", txtKode.Text.Trim())
                    If CInt(cmdCek.ExecuteScalar()) > 0 Then
                        MessageBox.Show("Kode produk sudah ada!", "Peringatan",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtKode.Focus()
                        Exit Sub
                    End If
                End Using

                ' Insert
                Using cmd As New OleDbCommand(
                    "INSERT INTO Produk (KodeProduk, Nama_Produk, Kategori, Harga, Stok) " &
                    "VALUES (?, ?, ?, ?, ?)", conn)
                    cmd.Parameters.AddWithValue("?", txtKode.Text.Trim())
                    cmd.Parameters.AddWithValue("?", txtNama.Text.Trim())
                    cmd.Parameters.AddWithValue("?", cmbKategori.Text)
                    cmd.Parameters.AddWithValue("?", CDec(txtHarga.Text))
                    cmd.Parameters.AddWithValue("?", CInt(txtStok.Text))
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Produk berhasil ditambahkan!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            BersihkanInput()
            LoadDataProduk()

        Catch ex As Exception
            MessageBox.Show("Gagal menambahkan: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -------------------------------------------------------
    ' EDIT / UPDATE PRODUK
    ' -------------------------------------------------------
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If String.IsNullOrWhiteSpace(txtKode.Text) Then
            MessageBox.Show("Pilih produk yang akan diedit!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not ValidasiInput() Then Exit Sub

        Dim konfirm As DialogResult = MessageBox.Show(
            "Simpan perubahan data produk?", "Konfirmasi",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirm = DialogResult.No Then Exit Sub

        Try
            Using conn As New OleDbConnection(Module1.connStr)
                conn.Open()
                Using cmd As New OleDbCommand(
                    "UPDATE Produk SET Nama_Produk=?, Kategori=?, Harga=?, Stok=? " &
                    "WHERE KodeProduk=?", conn)
                    cmd.Parameters.AddWithValue("?", txtNama.Text.Trim())
                    cmd.Parameters.AddWithValue("?", cmbKategori.Text)
                    cmd.Parameters.AddWithValue("?", CDec(txtHarga.Text))
                    cmd.Parameters.AddWithValue("?", CInt(txtStok.Text))
                    cmd.Parameters.AddWithValue("?", txtKode.Text.Trim())

                    Dim affected As Integer = cmd.ExecuteNonQuery()
                    If affected = 0 Then
                        MessageBox.Show("Data tidak ditemukan di database!", "Peringatan",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using
            End Using

            MessageBox.Show("Data produk berhasil diperbarui!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            BersihkanInput()
            LoadDataProduk()

        Catch ex As Exception
            MessageBox.Show("Gagal mengupdate: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -------------------------------------------------------
    ' HAPUS PRODUK
    ' -------------------------------------------------------
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If String.IsNullOrWhiteSpace(txtKode.Text) Then
            MessageBox.Show("Pilih produk yang akan dihapus!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Cek apakah produk ada di transaksi
        Try
            Using conn As New OleDbConnection(Module1.connStr)
                conn.Open()
                Using cmd As New OleDbCommand(
                    "SELECT COUNT(*) FROM Detail_Transaksi WHERE KodeProduk = ?", conn)
                    cmd.Parameters.AddWithValue("?", txtKode.Text.Trim())
                    If CInt(cmd.ExecuteScalar()) > 0 Then
                        MessageBox.Show("Produk tidak bisa dihapus karena masih digunakan dalam transaksi.",
                                        "Tidak Dapat Dihapus", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal cek data transaksi: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        Dim konfirm As DialogResult = MessageBox.Show(
            "Yakin hapus produk ini?" & vbCrLf & txtNama.Text,
            "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If konfirm = DialogResult.No Then Exit Sub

        Try
            Using conn As New OleDbConnection(Module1.connStr)
                conn.Open()
                Using cmd As New OleDbCommand(
                    "DELETE FROM Produk WHERE KodeProduk = ?", conn)
                    cmd.Parameters.AddWithValue("?", txtKode.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Produk berhasil dihapus!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            BersihkanInput()
            LoadDataProduk()

        Catch ex As Exception
            MessageBox.Show("Gagal menghapus: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        BersihkanInput()
        If txtPencarian IsNot Nothing Then txtPencarian.Clear()
        LoadDataProduk()
    End Sub

    ' -------------------------------------------------------
    ' VALIDASI INPUT
    ' -------------------------------------------------------
    Private Function ValidasiInput() As Boolean
        If String.IsNullOrWhiteSpace(txtKode.Text) Then
            MessageBox.Show("Kode produk tidak boleh kosong!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKode.Focus() : Return False
        End If
        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            MessageBox.Show("Nama produk tidak boleh kosong!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus() : Return False
        End If
        If cmbKategori.SelectedIndex = -1 Then
            MessageBox.Show("Pilih kategori produk!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbKategori.Focus() : Return False
        End If
        If Not IsNumeric(txtHarga.Text) OrElse Val(txtHarga.Text) < 0 Then
            MessageBox.Show("Harga harus berupa angka!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtHarga.Focus() : Return False
        End If
        If Not IsNumeric(txtStok.Text) OrElse Val(txtStok.Text) < 0 Then
            MessageBox.Show("Stok harus berupa angka!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStok.Focus() : Return False
        End If
        Return True
    End Function

    Private Sub BersihkanInput()
        txtKode.Clear()
        txtNama.Clear()
        cmbKategori.SelectedIndex = -1
        txtHarga.Clear()
        txtStok.Clear()
        txtKode.Focus()
    End Sub

    Private Sub btnKembaliproduk_Click(sender As Object, e As EventArgs) Handles btnKembaliproduk.Click
        sedangKembali = True
        If Module1.levelUser.ToLower() = "admin" Then
            Dashboard_Admin.Show()
        Else
            Dashboard.Show()
        End If
        Me.Close()
    End Sub

    Private Sub Produk_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing AndAlso Not sedangKembali Then
            If Module1.levelUser.ToLower() = "admin" Then
                Dashboard_Admin.Show()
            Else
                Dashboard.Show()
            End If
        End If
    End Sub

End Class