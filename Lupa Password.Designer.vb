<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LupaPassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LupaPassword))
        Me.btnKembali = New Guna.UI2.WinForms.Guna2Button()
        Me.btnVerifikasi = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBatal = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReset = New Guna.UI2.WinForms.Guna2Button()
        Me.grpResetPassword = New System.Windows.Forms.GroupBox()
        Me.txtPasswordBaru = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtKonfirmasi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grpVerifikasi = New System.Windows.Forms.GroupBox()
        Me.txtJawaban = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPertanyaan = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCekAkun = New Guna.UI2.WinForms.Guna2Button()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpResetPassword.SuspendLayout()
        Me.grpVerifikasi.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnKembali
        '
        Me.btnKembali.CheckedState.Parent = Me.btnKembali
        Me.btnKembali.CustomImages.Parent = Me.btnKembali
        Me.btnKembali.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnKembali.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnKembali.ForeColor = System.Drawing.Color.White
        Me.btnKembali.HoverState.Parent = Me.btnKembali
        Me.btnKembali.Location = New System.Drawing.Point(12, 12)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.ShadowDecoration.Parent = Me.btnKembali
        Me.btnKembali.Size = New System.Drawing.Size(308, 47)
        Me.btnKembali.TabIndex = 28
        Me.btnKembali.Text = "Kembali"
        '
        'btnVerifikasi
        '
        Me.btnVerifikasi.CheckedState.Parent = Me.btnVerifikasi
        Me.btnVerifikasi.CustomImages.Parent = Me.btnVerifikasi
        Me.btnVerifikasi.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnVerifikasi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnVerifikasi.ForeColor = System.Drawing.Color.White
        Me.btnVerifikasi.HoverState.Parent = Me.btnVerifikasi
        Me.btnVerifikasi.Location = New System.Drawing.Point(51, 212)
        Me.btnVerifikasi.Name = "btnVerifikasi"
        Me.btnVerifikasi.ShadowDecoration.Parent = Me.btnVerifikasi
        Me.btnVerifikasi.Size = New System.Drawing.Size(153, 45)
        Me.btnVerifikasi.TabIndex = 27
        Me.btnVerifikasi.Text = "Verifikasi"
        '
        'btnBatal
        '
        Me.btnBatal.CheckedState.Parent = Me.btnBatal
        Me.btnBatal.CustomImages.Parent = Me.btnBatal
        Me.btnBatal.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.HoverState.Parent = Me.btnBatal
        Me.btnBatal.Location = New System.Drawing.Point(953, 875)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.ShadowDecoration.Parent = Me.btnBatal
        Me.btnBatal.Size = New System.Drawing.Size(153, 45)
        Me.btnBatal.TabIndex = 26
        Me.btnBatal.Text = "Batal"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReset.CheckedState.Parent = Me.btnReset
        Me.btnReset.CustomImages.Parent = Me.btnReset
        Me.btnReset.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.HoverState.Parent = Me.btnReset
        Me.btnReset.Location = New System.Drawing.Point(779, 875)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.ShadowDecoration.Parent = Me.btnReset
        Me.btnReset.Size = New System.Drawing.Size(153, 45)
        Me.btnReset.TabIndex = 25
        Me.btnReset.Text = "Reset Password"
        '
        'grpResetPassword
        '
        Me.grpResetPassword.BackColor = System.Drawing.Color.Transparent
        Me.grpResetPassword.Controls.Add(Me.txtPasswordBaru)
        Me.grpResetPassword.Controls.Add(Me.txtKonfirmasi)
        Me.grpResetPassword.Controls.Add(Me.Label4)
        Me.grpResetPassword.Controls.Add(Me.Label5)
        Me.grpResetPassword.Location = New System.Drawing.Point(639, 617)
        Me.grpResetPassword.Name = "grpResetPassword"
        Me.grpResetPassword.Size = New System.Drawing.Size(610, 237)
        Me.grpResetPassword.TabIndex = 24
        Me.grpResetPassword.TabStop = False
        '
        'txtPasswordBaru
        '
        Me.txtPasswordBaru.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPasswordBaru.DefaultText = ""
        Me.txtPasswordBaru.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPasswordBaru.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPasswordBaru.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPasswordBaru.DisabledState.Parent = Me.txtPasswordBaru
        Me.txtPasswordBaru.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPasswordBaru.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPasswordBaru.FocusedState.Parent = Me.txtPasswordBaru
        Me.txtPasswordBaru.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPasswordBaru.HoverState.Parent = Me.txtPasswordBaru
        Me.txtPasswordBaru.Location = New System.Drawing.Point(51, 65)
        Me.txtPasswordBaru.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtPasswordBaru.Name = "txtPasswordBaru"
        Me.txtPasswordBaru.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPasswordBaru.PlaceholderText = ""
        Me.txtPasswordBaru.SelectedText = ""
        Me.txtPasswordBaru.ShadowDecoration.Parent = Me.txtPasswordBaru
        Me.txtPasswordBaru.Size = New System.Drawing.Size(508, 45)
        Me.txtPasswordBaru.TabIndex = 4
        '
        'txtKonfirmasi
        '
        Me.txtKonfirmasi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKonfirmasi.DefaultText = ""
        Me.txtKonfirmasi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtKonfirmasi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtKonfirmasi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtKonfirmasi.DisabledState.Parent = Me.txtKonfirmasi
        Me.txtKonfirmasi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtKonfirmasi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtKonfirmasi.FocusedState.Parent = Me.txtKonfirmasi
        Me.txtKonfirmasi.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtKonfirmasi.HoverState.Parent = Me.txtKonfirmasi
        Me.txtKonfirmasi.Location = New System.Drawing.Point(51, 168)
        Me.txtKonfirmasi.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtKonfirmasi.Name = "txtKonfirmasi"
        Me.txtKonfirmasi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKonfirmasi.PlaceholderText = ""
        Me.txtKonfirmasi.SelectedText = ""
        Me.txtKonfirmasi.ShadowDecoration.Parent = Me.txtKonfirmasi
        Me.txtKonfirmasi.Size = New System.Drawing.Size(508, 45)
        Me.txtKonfirmasi.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password Baru"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(264, 32)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Konfirmasi Password"
        '
        'grpVerifikasi
        '
        Me.grpVerifikasi.BackColor = System.Drawing.Color.Transparent
        Me.grpVerifikasi.Controls.Add(Me.txtJawaban)
        Me.grpVerifikasi.Controls.Add(Me.btnVerifikasi)
        Me.grpVerifikasi.Controls.Add(Me.lblPertanyaan)
        Me.grpVerifikasi.Controls.Add(Me.Label3)
        Me.grpVerifikasi.Location = New System.Drawing.Point(639, 315)
        Me.grpVerifikasi.Name = "grpVerifikasi"
        Me.grpVerifikasi.Size = New System.Drawing.Size(610, 283)
        Me.grpVerifikasi.TabIndex = 23
        Me.grpVerifikasi.TabStop = False
        '
        'txtJawaban
        '
        Me.txtJawaban.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJawaban.DefaultText = ""
        Me.txtJawaban.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtJawaban.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtJawaban.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtJawaban.DisabledState.Parent = Me.txtJawaban
        Me.txtJawaban.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtJawaban.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtJawaban.FocusedState.Parent = Me.txtJawaban
        Me.txtJawaban.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtJawaban.HoverState.Parent = Me.txtJawaban
        Me.txtJawaban.Location = New System.Drawing.Point(51, 154)
        Me.txtJawaban.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtJawaban.Name = "txtJawaban"
        Me.txtJawaban.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJawaban.PlaceholderText = ""
        Me.txtJawaban.SelectedText = ""
        Me.txtJawaban.ShadowDecoration.Parent = Me.txtJawaban
        Me.txtJawaban.Size = New System.Drawing.Size(508, 45)
        Me.txtJawaban.TabIndex = 6
        '
        'lblPertanyaan
        '
        Me.lblPertanyaan.AutoSize = True
        Me.lblPertanyaan.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPertanyaan.Location = New System.Drawing.Point(45, 42)
        Me.lblPertanyaan.Name = "lblPertanyaan"
        Me.lblPertanyaan.Size = New System.Drawing.Size(276, 32)
        Me.lblPertanyaan.TabIndex = 3
        Me.lblPertanyaan.Text = "Pertanyaan Keamanan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 32)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Jawaban"
        '
        'btnCekAkun
        '
        Me.btnCekAkun.CheckedState.Parent = Me.btnCekAkun
        Me.btnCekAkun.CustomImages.Parent = Me.btnCekAkun
        Me.btnCekAkun.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnCekAkun.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCekAkun.ForeColor = System.Drawing.Color.White
        Me.btnCekAkun.HoverState.Parent = Me.btnCekAkun
        Me.btnCekAkun.Location = New System.Drawing.Point(690, 250)
        Me.btnCekAkun.Name = "btnCekAkun"
        Me.btnCekAkun.ShadowDecoration.Parent = Me.btnCekAkun
        Me.btnCekAkun.Size = New System.Drawing.Size(153, 45)
        Me.btnCekAkun.TabIndex = 22
        Me.btnCekAkun.Text = "Cek Akun"
        '
        'txtUsername
        '
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.Parent = Me.txtUsername
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.FocusedState.Parent = Me.txtUsername
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.HoverState.Parent = Me.txtUsername
        Me.txtUsername.Location = New System.Drawing.Point(690, 193)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderText = ""
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.ShadowDecoration.Parent = Me.txtUsername
        Me.txtUsername.Size = New System.Drawing.Size(508, 45)
        Me.txtUsername.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(684, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 32)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Username "
        '
        'LupaPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.dashboardddd
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1152)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.grpResetPassword)
        Me.Controls.Add(Me.grpVerifikasi)
        Me.Controls.Add(Me.btnCekAkun)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LupaPassword"
        Me.Text = "Lupa Password"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpResetPassword.ResumeLayout(False)
        Me.grpResetPassword.PerformLayout()
        Me.grpVerifikasi.ResumeLayout(False)
        Me.grpVerifikasi.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnKembali As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnVerifikasi As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBatal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents grpResetPassword As System.Windows.Forms.GroupBox
    Friend WithEvents txtPasswordBaru As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtKonfirmasi As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grpVerifikasi As System.Windows.Forms.GroupBox
    Friend WithEvents txtJawaban As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPertanyaan As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCekAkun As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
