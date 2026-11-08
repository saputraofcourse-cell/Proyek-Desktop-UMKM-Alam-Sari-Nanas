<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lnkLupaPassword = New System.Windows.Forms.LinkLabel()
        Me.txtSandi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMasuk = New Guna.UI2.WinForms.Guna2Button()
        Me.txtNama = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnBatal = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.lnkLupaPassword)
        Me.Guna2Panel1.Controls.Add(Me.txtSandi)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.btnMasuk)
        Me.Guna2Panel1.Controls.Add(Me.txtNama)
        Me.Guna2Panel1.Controls.Add(Me.btnBatal)
        Me.Guna2Panel1.Location = New System.Drawing.Point(1124, -3)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(936, 1155)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.LogoAlamSari_removebg_preview
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(202, 189)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(410, 232)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 13
        Me.Guna2PictureBox1.TabStop = False
        '
        'lnkLupaPassword
        '
        Me.lnkLupaPassword.AutoSize = True
        Me.lnkLupaPassword.BackColor = System.Drawing.Color.Transparent
        Me.lnkLupaPassword.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lnkLupaPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkLupaPassword.LinkColor = System.Drawing.Color.Olive
        Me.lnkLupaPassword.Location = New System.Drawing.Point(515, 750)
        Me.lnkLupaPassword.Name = "lnkLupaPassword"
        Me.lnkLupaPassword.Size = New System.Drawing.Size(151, 28)
        Me.lnkLupaPassword.TabIndex = 9
        Me.lnkLupaPassword.TabStop = True
        Me.lnkLupaPassword.Text = "Lupa Password?"
        '
        'txtSandi
        '
        Me.txtSandi.BorderRadius = 8
        Me.txtSandi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSandi.DefaultText = ""
        Me.txtSandi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSandi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSandi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSandi.DisabledState.Parent = Me.txtSandi
        Me.txtSandi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSandi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSandi.FocusedState.Parent = Me.txtSandi
        Me.txtSandi.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSandi.HoverState.Parent = Me.txtSandi
        Me.txtSandi.Location = New System.Drawing.Point(159, 658)
        Me.txtSandi.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtSandi.Name = "txtSandi"
        Me.txtSandi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSandi.PlaceholderText = ""
        Me.txtSandi.SelectedText = ""
        Me.txtSandi.ShadowDecoration.Parent = Me.txtSandi
        Me.txtSandi.Size = New System.Drawing.Size(507, 55)
        Me.txtSandi.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(152, 472)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 38)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(152, 612)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 38)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Kata Sandi"
        '
        'btnMasuk
        '
        Me.btnMasuk.CheckedState.Parent = Me.btnMasuk
        Me.btnMasuk.CustomImages.Parent = Me.btnMasuk
        Me.btnMasuk.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMasuk.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMasuk.ForeColor = System.Drawing.Color.White
        Me.btnMasuk.HoverState.Parent = Me.btnMasuk
        Me.btnMasuk.Location = New System.Drawing.Point(250, 822)
        Me.btnMasuk.Name = "btnMasuk"
        Me.btnMasuk.ShadowDecoration.Parent = Me.btnMasuk
        Me.btnMasuk.Size = New System.Drawing.Size(154, 56)
        Me.btnMasuk.TabIndex = 11
        Me.btnMasuk.Text = "Masuk"
        '
        'txtNama
        '
        Me.txtNama.BorderRadius = 8
        Me.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNama.DefaultText = ""
        Me.txtNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNama.DisabledState.Parent = Me.txtNama
        Me.txtNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNama.FocusedState.Parent = Me.txtNama
        Me.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNama.HoverState.Parent = Me.txtNama
        Me.txtNama.Location = New System.Drawing.Point(159, 529)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNama.PlaceholderText = ""
        Me.txtNama.SelectedText = ""
        Me.txtNama.ShadowDecoration.Parent = Me.txtNama
        Me.txtNama.Size = New System.Drawing.Size(507, 55)
        Me.txtNama.TabIndex = 7
        '
        'btnBatal
        '
        Me.btnBatal.CheckedState.Parent = Me.btnBatal
        Me.btnBatal.CustomImages.Parent = Me.btnBatal
        Me.btnBatal.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.HoverState.Parent = Me.btnBatal
        Me.btnBatal.Location = New System.Drawing.Point(444, 822)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.ShadowDecoration.Parent = Me.btnBatal
        Me.btnBatal.Size = New System.Drawing.Size(154, 56)
        Me.btnBatal.TabIndex = 12
        Me.btnBatal.Text = "Batal"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Desain_Login
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1152)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnMasuk As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtNama As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnBatal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSandi As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lnkLupaPassword As System.Windows.Forms.LinkLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox

End Class
