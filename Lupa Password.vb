Imports System.Data.OleDb

Public Class LupaPassword

    Dim strPertanyaan As String = ""
    Dim strJawabanDB As String = ""
    Dim strIdUser As String = ""
    Dim sudahVerifikasi As Boolean = False

    Private Sub FrmLupaPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpVerifikasi.Enabled = False
        grpResetPassword.Enabled = False
        btnVerifikasi.Enabled = False
        btnReset.Enabled = False
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Login.Show()
        Me.Hide()
    End Sub

    ' -------------------------------------------------------
    ' CEK AKUN
    ' -------------------------------------------------------
    Private Sub btnCekAkun_Click(sender As Object, e As EventArgs) Handles btnCekAkun.Click
        If txtUsername.Text.Trim() = "" Then
            MessageBox.Show("Username tidak boleh kosong!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As New OleDbConnection(Module1.connStr)
                conn.Open()
                Using cmd As New OleDbCommand(
                    "SELECT Id_User, Pertanyaan, Jawaban FROM [User] WHERE UserName = ?", conn)
                    cmd.Parameters.AddWithValue("?", txtUsername.Text.Trim())

                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            strIdUser = reader("Id_User").ToString()
                            strPertanyaan = If(IsDBNull(reader("Pertanyaan")) OrElse
                                              reader("Pertanyaan").ToString().Trim() = "",
                                              "Kapan Alam Sari Nanas didirikan?",
                                              reader("Pertanyaan").ToString())
                            strJawabanDB = If(IsDBNull(reader("Jawaban")), "",
                                             reader("Jawaban").ToString().Trim())

                            lblPertanyaan.Text = strPertanyaan
                            txtJawaban.Clear()
                            sudahVerifikasi = False

                            grpVerifikasi.Enabled = True
                            btnVerifikasi.Enabled = True
                            grpResetPassword.Enabled = False
                            btnReset.Enabled = False

                            MessageBox.Show("Akun ditemukan! Silakan jawab pertanyaan keamanan.",
                                            "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            BersihkanForm()
                            MessageBox.Show("Username '" & txtUsername.Text.Trim() & "' tidak ditemukan!",
                                            "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error koneksi database: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' -------------------------------------------------------
    ' VERIFIKASI JAWABAN
    ' -------------------------------------------------------
    Private Sub btnVerifikasi_Click(sender As Object, e As EventArgs) Handles btnVerifikasi.Click
        If strIdUser = "" Then
            MessageBox.Show("Lakukan Cek Akun terlebih dahulu!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtJawaban.Text.Trim() = "" Then
            MessageBox.Show("Jawaban tidak boleh kosong!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.Compare(txtJawaban.Text.Trim(), strJawabanDB,
                          StringComparison.OrdinalIgnoreCase) = 0 Then
            sudahVerifikasi = True
            grpResetPassword.Enabled = True
            btnReset.Enabled = True
            txtPasswordBaru.Clear()
            txtKonfirmasi.Clear()
            MessageBox.Show("Verifikasi berhasil! Silakan masukkan password baru.",
                            "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            sudahVerifikasi = False
            MessageBox.Show("Jawaban salah! Silakan coba lagi.",
                            "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' -------------------------------------------------------
    ' RESET PASSWORD
    ' -------------------------------------------------------
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If Not sudahVerifikasi Then
            MessageBox.Show("Harap verifikasi jawaban keamanan terlebih dahulu!",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtPasswordBaru.Text = "" Then
            MessageBox.Show("Password baru tidak boleh kosong!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtPasswordBaru.Text <> txtKonfirmasi.Text Then
            MessageBox.Show("Password baru dan konfirmasi tidak cocok!",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Using conn As New OleDbConnection(Module1.connStr)
                conn.Open()
                Using cmd As New OleDbCommand(
                    "UPDATE [User] SET [Password] = ? WHERE Id_User = ?", conn)
                    cmd.Parameters.AddWithValue("?", txtPasswordBaru.Text)
                    cmd.Parameters.AddWithValue("?", strIdUser)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Password berhasil direset! Silakan login dengan password baru.",
                            "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BersihkanForm()
            Login.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Error update database: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        BersihkanForm()
    End Sub

    Private Sub BersihkanForm()
        txtUsername.Clear()
        txtJawaban.Clear()
        txtPasswordBaru.Clear()
        txtKonfirmasi.Clear()
        lblPertanyaan.Text = ""
        strIdUser = ""
        strPertanyaan = ""
        strJawabanDB = ""
        sudahVerifikasi = False
        grpVerifikasi.Enabled = False
        grpResetPassword.Enabled = False
        btnVerifikasi.Enabled = False
        btnReset.Enabled = False
    End Sub

End Class