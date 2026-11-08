<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanProduk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LaporanProduk))
        Me.dgvLaporan = New System.Windows.Forms.DataGridView()
        Me.btnTampilkan = New Guna.UI2.WinForms.Guna2Button()
        Me.dtpPeriode = New System.Windows.Forms.DateTimePicker()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnBulanan = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHarian = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnKembali = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCetak = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvLaporan
        '
        Me.dgvLaporan.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLaporan.Location = New System.Drawing.Point(400, 588)
        Me.dgvLaporan.Name = "dgvLaporan"
        Me.dgvLaporan.RowTemplate.Height = 28
        Me.dgvLaporan.Size = New System.Drawing.Size(1148, 315)
        Me.dgvLaporan.TabIndex = 33
        '
        'btnTampilkan
        '
        Me.btnTampilkan.CheckedState.Parent = Me.btnTampilkan
        Me.btnTampilkan.CustomImages.Parent = Me.btnTampilkan
        Me.btnTampilkan.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTampilkan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTampilkan.ForeColor = System.Drawing.Color.White
        Me.btnTampilkan.HoverState.Parent = Me.btnTampilkan
        Me.btnTampilkan.Location = New System.Drawing.Point(926, 415)
        Me.btnTampilkan.Name = "btnTampilkan"
        Me.btnTampilkan.ShadowDecoration.Parent = Me.btnTampilkan
        Me.btnTampilkan.Size = New System.Drawing.Size(194, 38)
        Me.btnTampilkan.TabIndex = 32
        Me.btnTampilkan.Text = "Tampilkan"
        '
        'dtpPeriode
        '
        Me.dtpPeriode.Location = New System.Drawing.Point(586, 425)
        Me.dtpPeriode.Name = "dtpPeriode"
        Me.dtpPeriode.Size = New System.Drawing.Size(266, 26)
        Me.dtpPeriode.TabIndex = 31
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(398, 415)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(124, 38)
        Me.lblInfo.TabIndex = 30
        Me.lblInfo.Text = "Periode"
        '
        'btnBulanan
        '
        Me.btnBulanan.CheckedState.Parent = Me.btnBulanan
        Me.btnBulanan.CustomImages.Parent = Me.btnBulanan
        Me.btnBulanan.FillColor = System.Drawing.Color.Orange
        Me.btnBulanan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBulanan.ForeColor = System.Drawing.Color.Black
        Me.btnBulanan.HoverState.Parent = Me.btnBulanan
        Me.btnBulanan.Location = New System.Drawing.Point(604, 298)
        Me.btnBulanan.Name = "btnBulanan"
        Me.btnBulanan.ShadowDecoration.Parent = Me.btnBulanan
        Me.btnBulanan.Size = New System.Drawing.Size(148, 45)
        Me.btnBulanan.TabIndex = 29
        Me.btnBulanan.Text = "Bulanan"
        '
        'btnHarian
        '
        Me.btnHarian.CheckedState.Parent = Me.btnHarian
        Me.btnHarian.CustomImages.Parent = Me.btnHarian
        Me.btnHarian.FillColor = System.Drawing.Color.Orange
        Me.btnHarian.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnHarian.ForeColor = System.Drawing.Color.Black
        Me.btnHarian.HoverState.Parent = Me.btnHarian
        Me.btnHarian.Location = New System.Drawing.Point(402, 298)
        Me.btnHarian.Name = "btnHarian"
        Me.btnHarian.ShadowDecoration.Parent = Me.btnHarian
        Me.btnHarian.Size = New System.Drawing.Size(147, 45)
        Me.btnHarian.TabIndex = 28
        Me.btnHarian.Text = "Harian"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(394, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 38)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Laporan Data Produk"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Orange
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(402, 485)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1146, 72)
        Me.Panel1.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Orange
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Laporan Produk"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(402, 382)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1146, 11)
        Me.Guna2Panel1.TabIndex = 35
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
        Me.btnKembali.Size = New System.Drawing.Size(310, 48)
        Me.btnKembali.TabIndex = 36
        Me.btnKembali.Text = "Kembali"
        '
        'btnCetak
        '
        Me.btnCetak.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCetak.CheckedState.Parent = Me.btnCetak
        Me.btnCetak.CustomImages.Parent = Me.btnCetak
        Me.btnCetak.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCetak.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCetak.ForeColor = System.Drawing.Color.White
        Me.btnCetak.HoverState.Parent = Me.btnCetak
        Me.btnCetak.Location = New System.Drawing.Point(1394, 923)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.ShadowDecoration.Parent = Me.btnCetak
        Me.btnCetak.Size = New System.Drawing.Size(154, 45)
        Me.btnCetak.TabIndex = 37
        Me.btnCetak.Text = "Cetak"
        '
        'LaporanProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.dashboardddd
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1646, 971)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.dgvLaporan)
        Me.Controls.Add(Me.btnTampilkan)
        Me.Controls.Add(Me.dtpPeriode)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnBulanan)
        Me.Controls.Add(Me.btnHarian)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LaporanProduk"
        Me.Text = "Laporan Produk"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvLaporan As System.Windows.Forms.DataGridView
    Friend WithEvents btnTampilkan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dtpPeriode As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents btnBulanan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHarian As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnKembali As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCetak As Guna.UI2.WinForms.Guna2Button
End Class
