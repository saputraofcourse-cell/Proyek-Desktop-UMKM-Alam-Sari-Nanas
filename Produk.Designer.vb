<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Produk
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Produk))
        Me.dgv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnTambah = New Guna.UI2.WinForms.Guna2Button()
        Me.txtPencarian = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnKembaliproduk = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHapus = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBatal = New Guna.UI2.WinForms.Guna2Button()
        Me.txtNama = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtHarga = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtStok = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbKategori = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv.ColumnHeadersHeight = 4
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv.EnableHeadersVisualStyles = False
        Me.dgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv.Location = New System.Drawing.Point(370, 622)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowTemplate.Height = 28
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(1340, 387)
        Me.dgv.TabIndex = 7
        Me.dgv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgv.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv.ThemeStyle.HeaderStyle.Height = 4
        Me.dgv.ThemeStyle.ReadOnly = False
        Me.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgv.ThemeStyle.RowsStyle.Height = 28
        Me.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnTambah
        '
        Me.btnTambah.CheckedState.Parent = Me.btnTambah
        Me.btnTambah.CustomImages.Parent = Me.btnTambah
        Me.btnTambah.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTambah.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.HoverState.Parent = Me.btnTambah
        Me.btnTambah.Location = New System.Drawing.Point(655, 502)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.ShadowDecoration.Parent = Me.btnTambah
        Me.btnTambah.Size = New System.Drawing.Size(166, 45)
        Me.btnTambah.TabIndex = 6
        Me.btnTambah.Text = "Tambah "
        '
        'txtPencarian
        '
        Me.txtPencarian.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPencarian.DefaultText = ""
        Me.txtPencarian.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPencarian.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPencarian.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPencarian.DisabledState.Parent = Me.txtPencarian
        Me.txtPencarian.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPencarian.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPencarian.FocusedState.Parent = Me.txtPencarian
        Me.txtPencarian.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPencarian.HoverState.Parent = Me.txtPencarian
        Me.txtPencarian.Location = New System.Drawing.Point(370, 583)
        Me.txtPencarian.Margin = New System.Windows.Forms.Padding(15, 14, 15, 14)
        Me.txtPencarian.Name = "txtPencarian"
        Me.txtPencarian.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPencarian.PlaceholderText = ""
        Me.txtPencarian.SelectedText = ""
        Me.txtPencarian.ShadowDecoration.Parent = Me.txtPencarian
        Me.txtPencarian.Size = New System.Drawing.Size(1340, 31)
        Me.txtPencarian.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(762, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(555, 38)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Stok Data Produk Serba Nanas Alam Sari"
        '
        'btnKembaliproduk
        '
        Me.btnKembaliproduk.CheckedState.Parent = Me.btnKembaliproduk
        Me.btnKembaliproduk.CustomImages.Parent = Me.btnKembaliproduk
        Me.btnKembaliproduk.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnKembaliproduk.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnKembaliproduk.ForeColor = System.Drawing.Color.White
        Me.btnKembaliproduk.HoverState.Parent = Me.btnKembaliproduk
        Me.btnKembaliproduk.Location = New System.Drawing.Point(12, 12)
        Me.btnKembaliproduk.Name = "btnKembaliproduk"
        Me.btnKembaliproduk.ShadowDecoration.Parent = Me.btnKembaliproduk
        Me.btnKembaliproduk.Size = New System.Drawing.Size(308, 48)
        Me.btnKembaliproduk.TabIndex = 32
        Me.btnKembaliproduk.Text = "Kembali"
        '
        'btnEdit
        '
        Me.btnEdit.CheckedState.Parent = Me.btnEdit
        Me.btnEdit.CustomImages.Parent = Me.btnEdit
        Me.btnEdit.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.HoverState.Parent = Me.btnEdit
        Me.btnEdit.Location = New System.Drawing.Point(872, 502)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ShadowDecoration.Parent = Me.btnEdit
        Me.btnEdit.Size = New System.Drawing.Size(166, 45)
        Me.btnEdit.TabIndex = 33
        Me.btnEdit.Text = "Edit"
        '
        'btnHapus
        '
        Me.btnHapus.CheckedState.Parent = Me.btnHapus
        Me.btnHapus.CustomImages.Parent = Me.btnHapus
        Me.btnHapus.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.HoverState.Parent = Me.btnHapus
        Me.btnHapus.Location = New System.Drawing.Point(1291, 502)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.ShadowDecoration.Parent = Me.btnHapus
        Me.btnHapus.Size = New System.Drawing.Size(166, 45)
        Me.btnHapus.TabIndex = 34
        Me.btnHapus.Text = "Hapus"
        '
        'btnBatal
        '
        Me.btnBatal.CheckedState.Parent = Me.btnBatal
        Me.btnBatal.CustomImages.Parent = Me.btnBatal
        Me.btnBatal.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.HoverState.Parent = Me.btnBatal
        Me.btnBatal.Location = New System.Drawing.Point(1080, 502)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.ShadowDecoration.Parent = Me.btnBatal
        Me.btnBatal.Size = New System.Drawing.Size(166, 45)
        Me.btnBatal.TabIndex = 35
        Me.btnBatal.Text = "Batal"
        '
        'txtNama
        '
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
        Me.txtNama.Location = New System.Drawing.Point(984, 263)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(15, 14, 15, 14)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNama.PlaceholderText = ""
        Me.txtNama.SelectedText = ""
        Me.txtNama.ShadowDecoration.Parent = Me.txtNama
        Me.txtNama.Size = New System.Drawing.Size(386, 47)
        Me.txtNama.TabIndex = 37
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
        Me.txtHarga.Location = New System.Drawing.Point(984, 363)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(15, 14, 15, 14)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHarga.PlaceholderText = ""
        Me.txtHarga.SelectedText = ""
        Me.txtHarga.ShadowDecoration.Parent = Me.txtHarga
        Me.txtHarga.Size = New System.Drawing.Size(262, 47)
        Me.txtHarga.TabIndex = 39
        '
        'txtStok
        '
        Me.txtStok.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStok.DefaultText = ""
        Me.txtStok.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStok.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStok.DisabledState.Parent = Me.txtStok
        Me.txtStok.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStok.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStok.FocusedState.Parent = Me.txtStok
        Me.txtStok.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStok.HoverState.Parent = Me.txtStok
        Me.txtStok.Location = New System.Drawing.Point(984, 418)
        Me.txtStok.Margin = New System.Windows.Forms.Padding(15, 14, 15, 14)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStok.PlaceholderText = ""
        Me.txtStok.SelectedText = ""
        Me.txtStok.ShadowDecoration.Parent = Me.txtStok
        Me.txtStok.Size = New System.Drawing.Size(213, 47)
        Me.txtStok.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(802, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 32)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Kode"
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
        Me.txtKode.Location = New System.Drawing.Point(984, 200)
        Me.txtKode.Margin = New System.Windows.Forms.Padding(15, 14, 15, 14)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKode.PlaceholderText = ""
        Me.txtKode.SelectedText = ""
        Me.txtKode.ShadowDecoration.Parent = Me.txtKode
        Me.txtKode.Size = New System.Drawing.Size(120, 47)
        Me.txtKode.TabIndex = 46
        '
        'cmbKategori
        '
        Me.cmbKategori.FormattingEnabled = True
        Me.cmbKategori.Items.AddRange(New Object() {"Makanan", "Minuman"})
        Me.cmbKategori.Location = New System.Drawing.Point(984, 324)
        Me.cmbKategori.Name = "cmbKategori"
        Me.cmbKategori.Size = New System.Drawing.Size(262, 28)
        Me.cmbKategori.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(802, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 32)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Nama"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(802, 378)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 32)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Harga"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(802, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 32)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Kategori"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(802, 433)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 32)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Stok"
        '
        'Produk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.desainformproduk
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1152)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbKategori)
        Me.Controls.Add(Me.txtKode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtStok)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnKembaliproduk)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtPencarian)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Produk"
        Me.Text = "Produk"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnTambah As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtPencarian As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnKembaliproduk As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHapus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBatal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtNama As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtHarga As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtStok As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbKategori As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
