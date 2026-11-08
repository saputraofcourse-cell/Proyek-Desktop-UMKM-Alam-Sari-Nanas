<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaksi))
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBayar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtKembalian = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.btnSimpanCetak = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBatal2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblStok = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnTambah = New Guna.UI2.WinForms.Guna2Button()
        Me.txtHarga = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtJumlahproduk = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnHapus = New Guna.UI2.WinForms.Guna2Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtKode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSub = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbNama = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIDtransaksi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtKasir = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIDkasir = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dtTransaksi = New System.Windows.Forms.DateTimePicker()
        Me.btnKembalitransaksi = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Britannic Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(677, 556)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 16)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Bayar"
        '
        'txtBayar
        '
        Me.txtBayar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBayar.DefaultText = ""
        Me.txtBayar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBayar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBayar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBayar.DisabledState.Parent = Me.txtBayar
        Me.txtBayar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBayar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBayar.FocusedState.Parent = Me.txtBayar
        Me.txtBayar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBayar.HoverState.Parent = Me.txtBayar
        Me.txtBayar.Location = New System.Drawing.Point(799, 549)
        Me.txtBayar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBayar.PlaceholderText = ""
        Me.txtBayar.SelectedText = ""
        Me.txtBayar.ShadowDecoration.Parent = Me.txtBayar
        Me.txtBayar.Size = New System.Drawing.Size(102, 21)
        Me.txtBayar.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Britannic Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(677, 585)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 16)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Kembalian"
        '
        'txtKembalian
        '
        Me.txtKembalian.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKembalian.DefaultText = ""
        Me.txtKembalian.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtKembalian.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtKembalian.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtKembalian.DisabledState.Parent = Me.txtKembalian
        Me.txtKembalian.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtKembalian.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtKembalian.FocusedState.Parent = Me.txtKembalian
        Me.txtKembalian.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtKembalian.HoverState.Parent = Me.txtKembalian
        Me.txtKembalian.Location = New System.Drawing.Point(799, 578)
        Me.txtKembalian.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtKembalian.Name = "txtKembalian"
        Me.txtKembalian.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKembalian.PlaceholderText = ""
        Me.txtKembalian.SelectedText = ""
        Me.txtKembalian.ShadowDecoration.Parent = Me.txtKembalian
        Me.txtKembalian.Size = New System.Drawing.Size(102, 21)
        Me.txtKembalian.TabIndex = 29
        '
        'dgv1
        '
        Me.dgv1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(259, 366)
        Me.dgv1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.RowTemplate.Height = 28
        Me.dgv1.Size = New System.Drawing.Size(765, 122)
        Me.dgv1.TabIndex = 26
        '
        'btnSimpanCetak
        '
        Me.btnSimpanCetak.CheckedState.Parent = Me.btnSimpanCetak
        Me.btnSimpanCetak.CustomImages.Parent = Me.btnSimpanCetak
        Me.btnSimpanCetak.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSimpanCetak.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSimpanCetak.ForeColor = System.Drawing.Color.White
        Me.btnSimpanCetak.HoverState.Parent = Me.btnSimpanCetak
        Me.btnSimpanCetak.Location = New System.Drawing.Point(680, 620)
        Me.btnSimpanCetak.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSimpanCetak.Name = "btnSimpanCetak"
        Me.btnSimpanCetak.ShadowDecoration.Parent = Me.btnSimpanCetak
        Me.btnSimpanCetak.Size = New System.Drawing.Size(113, 24)
        Me.btnSimpanCetak.TabIndex = 32
        Me.btnSimpanCetak.Text = "Simpan"
        '
        'btnBatal2
        '
        Me.btnBatal2.CheckedState.Parent = Me.btnBatal2
        Me.btnBatal2.CustomImages.Parent = Me.btnBatal2
        Me.btnBatal2.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnBatal2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBatal2.ForeColor = System.Drawing.Color.White
        Me.btnBatal2.HoverState.Parent = Me.btnBatal2
        Me.btnBatal2.Location = New System.Drawing.Point(819, 620)
        Me.btnBatal2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBatal2.Name = "btnBatal2"
        Me.btnBatal2.ShadowDecoration.Parent = Me.btnBatal2
        Me.btnBatal2.Size = New System.Drawing.Size(113, 24)
        Me.btnBatal2.TabIndex = 1
        Me.btnBatal2.Text = "Batal"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Britannic Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(677, 526)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 16)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Total Harga"
        '
        'txtTotal
        '
        Me.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotal.DefaultText = ""
        Me.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotal.DisabledState.Parent = Me.txtTotal
        Me.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotal.FocusedState.Parent = Me.txtTotal
        Me.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotal.HoverState.Parent = Me.txtTotal
        Me.txtTotal.Location = New System.Drawing.Point(799, 519)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotal.PlaceholderText = ""
        Me.txtTotal.SelectedText = ""
        Me.txtTotal.ShadowDecoration.Parent = Me.txtTotal
        Me.txtTotal.Size = New System.Drawing.Size(133, 21)
        Me.txtTotal.TabIndex = 23
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Guna2Panel1)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.btnTambah)
        Me.GroupBox2.Controls.Add(Me.txtHarga)
        Me.GroupBox2.Controls.Add(Me.txtJumlahproduk)
        Me.GroupBox2.Controls.Add(Me.btnEdit)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.btnHapus)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtKode)
        Me.GroupBox2.Controls.Add(Me.txtSub)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmbNama)
        Me.GroupBox2.Location = New System.Drawing.Point(639, 82)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(328, 266)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.lblStok)
        Me.Guna2Panel1.Location = New System.Drawing.Point(124, 95)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(59, 21)
        Me.Guna2Panel1.TabIndex = 34
        '
        'lblStok
        '
        Me.lblStok.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblStok.AutoSize = True
        Me.lblStok.BackColor = System.Drawing.Color.Transparent
        Me.lblStok.Font = New System.Drawing.Font("Britannic Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStok.Location = New System.Drawing.Point(2, 4)
        Me.lblStok.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStok.Name = "lblStok"
        Me.lblStok.Size = New System.Drawing.Size(0, 16)
        Me.lblStok.TabIndex = 32
        Me.lblStok.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Britannic Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 103)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 16)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Sisa Stok"
        '
        'btnTambah
        '
        Me.btnTambah.CheckedState.Parent = Me.btnTambah
        Me.btnTambah.CustomImages.Parent = Me.btnTambah
        Me.btnTambah.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTambah.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.HoverState.Parent = Me.btnTambah
        Me.btnTambah.Location = New System.Drawing.Point(21, 229)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.ShadowDecoration.Parent = Me.btnTambah
        Me.btnTambah.Size = New System.Drawing.Size(77, 24)
        Me.btnTambah.TabIndex = 16
        Me.btnTambah.Text = "Tambah"
        '
        'txtHarga
        '
        Me.txtHarga.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHarga.DefaultText = ""
        Me.txtHarga.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtHarga.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtHarga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtHarga.DisabledState.Parent = Me.txtHarga
        Me.txtHarga.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtHarga.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHarga.FocusedState.Parent = Me.txtHarga
        Me.txtHarga.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHarga.HoverState.Parent = Me.txtHarga
        Me.txtHarga.Location = New System.Drawing.Point(124, 129)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHarga.PlaceholderText = ""
        Me.txtHarga.SelectedText = ""
        Me.txtHarga.ShadowDecoration.Parent = Me.txtHarga
        Me.txtHarga.Size = New System.Drawing.Size(102, 21)
        Me.txtHarga.TabIndex = 10
        '
        'txtJumlahproduk
        '
        Me.txtJumlahproduk.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJumlahproduk.DefaultText = ""
        Me.txtJumlahproduk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtJumlahproduk.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtJumlahproduk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtJumlahproduk.DisabledState.Parent = Me.txtJumlahproduk
        Me.txtJumlahproduk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtJumlahproduk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtJumlahproduk.FocusedState.Parent = Me.txtJumlahproduk
        Me.txtJumlahproduk.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtJumlahproduk.HoverState.Parent = Me.txtJumlahproduk
        Me.txtJumlahproduk.Location = New System.Drawing.Point(124, 159)
        Me.txtJumlahproduk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtJumlahproduk.Name = "txtJumlahproduk"
        Me.txtJumlahproduk.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJumlahproduk.PlaceholderText = ""
        Me.txtJumlahproduk.SelectedText = ""
        Me.txtJumlahproduk.ShadowDecoration.Parent = Me.txtJumlahproduk
        Me.txtJumlahproduk.Size = New System.Drawing.Size(102, 21)
        Me.txtJumlahproduk.TabIndex = 9
        '
        'btnEdit
        '
        Me.btnEdit.CheckedState.Parent = Me.btnEdit
        Me.btnEdit.CustomImages.Parent = Me.btnEdit
        Me.btnEdit.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.HoverState.Parent = Me.btnEdit
        Me.btnEdit.Location = New System.Drawing.Point(124, 229)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ShadowDecoration.Parent = Me.btnEdit
        Me.btnEdit.Size = New System.Drawing.Size(77, 24)
        Me.btnEdit.TabIndex = 17
        Me.btnEdit.Text = "Edit"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Britannic Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 61)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 16)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Nama Produk"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Britannic Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 194)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Sub Total"
        '
        'btnHapus
        '
        Me.btnHapus.CheckedState.Parent = Me.btnHapus
        Me.btnHapus.CustomImages.Parent = Me.btnHapus
        Me.btnHapus.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.HoverState.Parent = Me.btnHapus
        Me.btnHapus.Location = New System.Drawing.Point(225, 229)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.ShadowDecoration.Parent = Me.btnHapus
        Me.btnHapus.Size = New System.Drawing.Size(77, 24)
        Me.btnHapus.TabIndex = 18
        Me.btnHapus.Text = "Hapus"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Britannic Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 164)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Jumlah Produk"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Britannic Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 26)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Kode Produk"
        '
        'txtKode
        '
        Me.txtKode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKode.DefaultText = ""
        Me.txtKode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtKode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtKode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtKode.DisabledState.Parent = Me.txtKode
        Me.txtKode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtKode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtKode.FocusedState.Parent = Me.txtKode
        Me.txtKode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtKode.HoverState.Parent = Me.txtKode
        Me.txtKode.Location = New System.Drawing.Point(124, 21)
        Me.txtKode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKode.PlaceholderText = ""
        Me.txtKode.SelectedText = ""
        Me.txtKode.ShadowDecoration.Parent = Me.txtKode
        Me.txtKode.Size = New System.Drawing.Size(59, 21)
        Me.txtKode.TabIndex = 12
        '
        'txtSub
        '
        Me.txtSub.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSub.DefaultText = ""
        Me.txtSub.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSub.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSub.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSub.DisabledState.Parent = Me.txtSub
        Me.txtSub.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSub.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSub.FocusedState.Parent = Me.txtSub
        Me.txtSub.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSub.HoverState.Parent = Me.txtSub
        Me.txtSub.Location = New System.Drawing.Point(124, 188)
        Me.txtSub.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSub.Name = "txtSub"
        Me.txtSub.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSub.PlaceholderText = ""
        Me.txtSub.SelectedText = ""
        Me.txtSub.ShadowDecoration.Parent = Me.txtSub
        Me.txtSub.Size = New System.Drawing.Size(146, 21)
        Me.txtSub.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 136)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Harga Produk"
        '
        'cmbNama
        '
        Me.cmbNama.BackColor = System.Drawing.Color.Transparent
        Me.cmbNama.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbNama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNama.FocusedColor = System.Drawing.Color.Empty
        Me.cmbNama.FocusedState.Parent = Me.cmbNama
        Me.cmbNama.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbNama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbNama.FormattingEnabled = True
        Me.cmbNama.HoverState.Parent = Me.cmbNama
        Me.cmbNama.ItemHeight = 30
        Me.cmbNama.ItemsAppearance.Parent = Me.cmbNama
        Me.cmbNama.Location = New System.Drawing.Point(124, 51)
        Me.cmbNama.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbNama.Name = "cmbNama"
        Me.cmbNama.ShadowDecoration.Parent = Me.cmbNama
        Me.cmbNama.Size = New System.Drawing.Size(201, 36)
        Me.cmbNama.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtIDtransaksi)
        Me.GroupBox1.Controls.Add(Me.txtKasir)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtIDkasir)
        Me.GroupBox1.Controls.Add(Me.dtTransaksi)
        Me.GroupBox1.Location = New System.Drawing.Point(297, 82)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(328, 168)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'txtIDtransaksi
        '
        Me.txtIDtransaksi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIDtransaksi.DefaultText = ""
        Me.txtIDtransaksi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtIDtransaksi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtIDtransaksi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIDtransaksi.DisabledState.Parent = Me.txtIDtransaksi
        Me.txtIDtransaksi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIDtransaksi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIDtransaksi.FocusedState.Parent = Me.txtIDtransaksi
        Me.txtIDtransaksi.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIDtransaksi.HoverState.Parent = Me.txtIDtransaksi
        Me.txtIDtransaksi.Location = New System.Drawing.Point(125, 59)
        Me.txtIDtransaksi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtIDtransaksi.Name = "txtIDtransaksi"
        Me.txtIDtransaksi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIDtransaksi.PlaceholderText = ""
        Me.txtIDtransaksi.SelectedText = ""
        Me.txtIDtransaksi.ShadowDecoration.Parent = Me.txtIDtransaksi
        Me.txtIDtransaksi.Size = New System.Drawing.Size(102, 21)
        Me.txtIDtransaksi.TabIndex = 6
        '
        'txtKasir
        '
        Me.txtKasir.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKasir.DefaultText = ""
        Me.txtKasir.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtKasir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtKasir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtKasir.DisabledState.Parent = Me.txtKasir
        Me.txtKasir.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtKasir.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtKasir.FocusedState.Parent = Me.txtKasir
        Me.txtKasir.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtKasir.HoverState.Parent = Me.txtKasir
        Me.txtKasir.Location = New System.Drawing.Point(125, 125)
        Me.txtKasir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtKasir.Name = "txtKasir"
        Me.txtKasir.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKasir.PlaceholderText = ""
        Me.txtKasir.SelectedText = ""
        Me.txtKasir.ShadowDecoration.Parent = Me.txtKasir
        Me.txtKasir.Size = New System.Drawing.Size(200, 21)
        Me.txtKasir.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 102)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 131)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kasir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Transaksi"
        '
        'txtIDkasir
        '
        Me.txtIDkasir.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIDkasir.DefaultText = ""
        Me.txtIDkasir.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtIDkasir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtIDkasir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIDkasir.DisabledState.Parent = Me.txtIDkasir
        Me.txtIDkasir.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIDkasir.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIDkasir.FocusedState.Parent = Me.txtIDkasir
        Me.txtIDkasir.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIDkasir.HoverState.Parent = Me.txtIDkasir
        Me.txtIDkasir.Location = New System.Drawing.Point(125, 95)
        Me.txtIDkasir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtIDkasir.Name = "txtIDkasir"
        Me.txtIDkasir.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIDkasir.PlaceholderText = ""
        Me.txtIDkasir.SelectedText = ""
        Me.txtIDkasir.ShadowDecoration.Parent = Me.txtIDkasir
        Me.txtIDkasir.Size = New System.Drawing.Size(102, 21)
        Me.txtIDkasir.TabIndex = 9
        '
        'dtTransaksi
        '
        Me.dtTransaksi.Font = New System.Drawing.Font("Segoe UI Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTransaksi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTransaksi.Location = New System.Drawing.Point(125, 25)
        Me.dtTransaksi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtTransaksi.Name = "dtTransaksi"
        Me.dtTransaksi.Size = New System.Drawing.Size(148, 22)
        Me.dtTransaksi.TabIndex = 5
        '
        'btnKembalitransaksi
        '
        Me.btnKembalitransaksi.CheckedState.Parent = Me.btnKembalitransaksi
        Me.btnKembalitransaksi.CustomImages.Parent = Me.btnKembalitransaksi
        Me.btnKembalitransaksi.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnKembalitransaksi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnKembalitransaksi.ForeColor = System.Drawing.Color.White
        Me.btnKembalitransaksi.HoverState.Parent = Me.btnKembalitransaksi
        Me.btnKembalitransaksi.Location = New System.Drawing.Point(8, 8)
        Me.btnKembalitransaksi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnKembalitransaksi.Name = "btnKembalitransaksi"
        Me.btnKembalitransaksi.ShadowDecoration.Parent = Me.btnKembalitransaksi
        Me.btnKembalitransaksi.Size = New System.Drawing.Size(206, 32)
        Me.btnKembalitransaksi.TabIndex = 31
        Me.btnKembalitransaksi.Text = "Kembali"
        '
        'Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.rev2formtransaksi
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1161, 684)
        Me.Controls.Add(Me.btnBatal2)
        Me.Controls.Add(Me.btnSimpanCetak)
        Me.Controls.Add(Me.btnKembalitransaksi)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtBayar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtKembalian)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Transaksi"
        Me.Text = "Transaksi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtBayar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtKembalian As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnBatal2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTambah As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHapus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtKode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtHarga As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSub As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtJumlahproduk As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIDtransaksi As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtKasir As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIDkasir As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtTransaksi As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnKembalitransaksi As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSimpanCetak As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbNama As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblStok As System.Windows.Forms.Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class
