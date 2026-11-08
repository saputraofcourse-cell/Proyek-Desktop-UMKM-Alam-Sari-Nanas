Imports System.Data.OleDb

Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNama.Text = ""
        txtSandi.Text = ""
        txtNama.Focus()
    End Sub

    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        If txtNama.Text.Trim() = "" Then
            MessageBox.Show("Nama pengguna tidak boleh kosong!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            Exit Sub
        End If

        If txtSandi.Text.Trim() = "" Then
            MessageBox.Show("Kata sandi tidak boleh kosong!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSandi.Focus()
            Exit Sub
        End If

        Try
            Using conn As New OleDbConnection(Module1.connStr)
                conn.Open()
                Dim query As String = "SELECT * FROM [User] WHERE UserName = ? AND Password = ?"
                Using cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("?", txtNama.Text.Trim())
                    cmd.Parameters.AddWithValue("?", txtSandi.Text.Trim())

                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()
                            Module1.namaUser = reader("UserName").ToString()
                            Module1.levelUser = reader("Level").ToString()
                            Module1.idUser = reader("Id_User").ToString()
                            reader.Close()
                        Else
                            reader.Close()
                            MessageBox.Show("Nama pengguna atau kata sandi salah!", "Login Gagal",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtSandi.Text = ""
                            txtSandi.Focus()
                            Exit Sub
                        End If
                    End Using
                End Using
            End Using

            MessageBox.Show("Login berhasil! Selamat datang, " & Module1.namaUser & ".",
                            "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If Module1.levelUser.ToLower() = "owner" Then
                Dim dash As New Dashboard()
                dash.Show()
            ElseIf Module1.levelUser.ToLower() = "admin" Then
                Dim dashAdmin As New Dashboard_Admin()
                dashAdmin.Show()
            Else
                MessageBox.Show("Level pengguna tidak dikenali: " & Module1.levelUser,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan koneksi database:" & vbNewLine & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Dim konfirmasi As DialogResult = MessageBox.Show(
            "Apakah Anda yakin ingin keluar?", "Konfirmasi",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub txtNama_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNama.KeyDown
        If e.KeyCode = Keys.Enter Then txtSandi.Focus()
    End Sub

    Private Sub txtSandi_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSandi.KeyDown
        If e.KeyCode = Keys.Enter Then btnMasuk_Click(sender, e)
    End Sub

    Private Sub lnkLupaPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLupaPassword.LinkClicked
        LupaPassword.Show()
        Me.Hide()
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Dim konfirmasi As DialogResult = MessageBox.Show(
                "Apakah Anda yakin ingin keluar dari aplikasi?",
                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If konfirmasi = DialogResult.Yes Then
                Application.Exit()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

End Class