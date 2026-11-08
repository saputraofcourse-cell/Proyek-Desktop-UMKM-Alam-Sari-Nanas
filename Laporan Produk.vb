
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms

Public Class LaporanProduk

    Private ReadOnly connStr As String =
        "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" &
        Application.StartupPath & "\NusaTech1.mdb"

    Private modeLaporan As String = "Harian"
    Private dtLaporan As New DataTable()
    Private printCurrentRow As Integer = 0
    Private printPeriodeLabel As String = ""

    Private Sub LaporanProduk_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        SetupDGV()
        SetModeHarian()
    End Sub

    Private Sub SetupDGV()
        dgvLaporan.Columns.Clear()
        dgvLaporan.AutoGenerateColumns = False
        dgvLaporan.ReadOnly = True
        dgvLaporan.RowHeadersVisible = False
        dgvLaporan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLaporan.AllowUserToAddRows = False
        dgvLaporan.BackgroundColor = Color.White
        dgvLaporan.GridColor = Color.FromArgb(210, 225, 245)
        dgvLaporan.BorderStyle = BorderStyle.None
        dgvLaporan.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or
                            AnchorStyles.Left Or AnchorStyles.Right

        dgvLaporan.EnableHeadersVisualStyles = False
        dgvLaporan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 102, 179)
        dgvLaporan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvLaporan.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        dgvLaporan.ColumnHeadersHeight = 32
        dgvLaporan.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255)


        Dim colNo As New DataGridViewTextBoxColumn()
        colNo.Name = "colNo"
        colNo.HeaderText = "No"
        colNo.Width = 40
        colNo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dim colKode As New DataGridViewTextBoxColumn()
        colKode.Name = "colKode"
        colKode.HeaderText = "Kode Produk"
        colKode.DataPropertyName = "KodeProduk"
        colKode.Width = 100


        Dim colNama As New DataGridViewTextBoxColumn()
        colNama.Name = "colNama"
        colNama.HeaderText = "Nama Produk"
        colNama.DataPropertyName = "Nama_Produk"
        colNama.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill


        Dim colKategori As New DataGridViewTextBoxColumn()
        colKategori.Name = "colKategori"
        colKategori.HeaderText = "Kategori"
        colKategori.DataPropertyName = "Kategori"
        colKategori.Width = 100


        Dim colHarga As New DataGridViewTextBoxColumn()
        colHarga.Name = "colHarga"
        colHarga.HeaderText = "Harga"
        colHarga.DataPropertyName = "Harga"
        colHarga.Width = 110
        colHarga.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        colHarga.DefaultCellStyle.Format = "'Rp '##,##0"

        Dim colQty As New DataGridViewTextBoxColumn()
        colQty.Name = "colQty"
        colQty.HeaderText = "Qty Terjual"
        colQty.DataPropertyName = "TotalQty"
        colQty.Width = 80
        colQty.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        Dim colPendapatan As New DataGridViewTextBoxColumn()
        colPendapatan.Name = "colPendapatan"
        colPendapatan.HeaderText = "Total Pendapatan"
        colPendapatan.DataPropertyName = "TotalPendapatan"
        colPendapatan.Width = 140
        colPendapatan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        colPendapatan.DefaultCellStyle.Format = "'Rp '##,##0"


        Dim colStok As New DataGridViewTextBoxColumn()
        colStok.Name = "colStok"
        colStok.HeaderText = "Stok Tersedia"
        colStok.DataPropertyName = "Stok"
        colStok.Width = 90
        colStok.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvLaporan.Columns.AddRange(New DataGridViewColumn() {
            colNo, colKode, colNama, colKategori, colHarga, colQty, colPendapatan, colStok})
    End Sub

    Private Sub SetModeHarian()
        modeLaporan = "Harian"
        dtpPeriode.Format = DateTimePickerFormat.Long
        btnHarian.BackColor = Color.FromArgb(0, 102, 179)
        btnHarian.ForeColor = Color.White
        btnBulanan.BackColor = Color.FromArgb(200, 225, 255)
        btnBulanan.ForeColor = Color.FromArgb(0, 70, 140)
    End Sub

    Private Sub SetModeBulanan()
        modeLaporan = "Bulanan"
        dtpPeriode.Format = DateTimePickerFormat.Custom
        dtpPeriode.CustomFormat = "MMMM yyyy"
        btnBulanan.BackColor = Color.FromArgb(0, 102, 179)
        btnBulanan.ForeColor = Color.White
        btnHarian.BackColor = Color.FromArgb(200, 225, 255)
        btnHarian.ForeColor = Color.FromArgb(0, 70, 140)
    End Sub

    Private Sub btnHarian_Click(sender As Object, e As EventArgs) Handles btnHarian.Click
        SetModeHarian()
    End Sub

    Private Sub btnBulanan_Click(sender As Object, e As EventArgs) Handles btnBulanan.Click
        SetModeBulanan()
    End Sub

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        TampilkanLaporan()
    End Sub

    Private Sub TampilkanLaporan()
        Dim conn As New OleDbConnection(connStr)
        Try
            conn.Open()
            Dim cmd As New OleDbCommand()
            cmd.Connection = conn

            If modeLaporan = "Harian" Then
                Dim tglDipilih As Date = dtpPeriode.Value.Date
                Dim tglAwal As Date = tglDipilih
                Dim tglAkhir As Date = tglDipilih.AddDays(1)

                cmd.CommandText =
                    "SELECT p.KodeProduk, p.Nama_Produk, p.Kategori, p.Harga, p.Stok, " & _
                    "       SUM(d.Jumlah_Prod) AS TotalQty, " & _
                    "       SUM(d.SubTotal) AS TotalPendapatan " & _
                    "FROM (Produk AS p " & _
                    "INNER JOIN Detail_Transaksi AS d ON p.KodeProduk = d.KodeProduk) " & _
                    "INNER JOIN Transaksi AS t ON d.Id_Transaksi = t.Id_Transaksi " & _
                    "WHERE t.Tanggal >= ? AND t.Tanggal < ? " & _
                    "GROUP BY p.KodeProduk, p.Nama_Produk, p.Kategori, p.Harga, p.Stok " & _
                    "ORDER BY SUM(d.Jumlah_Prod) DESC"

                cmd.Parameters.AddWithValue("@tglAwal", tglAwal)
                cmd.Parameters.AddWithValue("@tglAkhir", tglAkhir)

                printPeriodeLabel = "Harian : " & tglDipilih.ToString("dd MMMM yyyy")

            ElseIf modeLaporan = "Bulanan" Then
                Dim bulan As Integer = dtpPeriode.Value.Month
                Dim tahun As Integer = dtpPeriode.Value.Year

                cmd.CommandText =
                    "SELECT p.KodeProduk, p.Nama_Produk, p.Kategori, p.Harga, p.Stok, " & _
                    "       SUM(d.Jumlah_Prod) AS TotalQty, " & _
                    "       SUM(d.SubTotal) AS TotalPendapatan " & _
                    "FROM (Produk AS p " & _
                    "INNER JOIN Detail_Transaksi AS d ON p.KodeProduk = d.KodeProduk) " & _
                    "INNER JOIN Transaksi AS t ON d.Id_Transaksi = t.Id_Transaksi " & _
                    "WHERE Month(t.Tanggal) = ? AND Year(t.Tanggal) = ? " & _
                    "GROUP BY p.KodeProduk, p.Nama_Produk, p.Kategori, p.Harga, p.Stok " & _
                    "ORDER BY SUM(d.Jumlah_Prod) DESC"

                cmd.Parameters.AddWithValue("@bln", bulan)
                cmd.Parameters.AddWithValue("@thn", tahun)

                printPeriodeLabel = "Bulanan : " & dtpPeriode.Value.ToString("MMMM yyyy")
            End If

            Dim da As New OleDbDataAdapter(cmd)
            dtLaporan = New DataTable()
            da.Fill(dtLaporan)

            dgvLaporan.DataSource = dtLaporan

            For i As Integer = 0 To dgvLaporan.Rows.Count - 1
                dgvLaporan.Rows(i).Cells("colNo").Value = i + 1
            Next

        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data:" & vbCrLf & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Function FormatRupiah(nilai As Double) As String
        Return "Rp " & nilai.ToString("N0").Replace(",", ".")
    End Function

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If dtLaporan Is Nothing OrElse dtLaporan.Rows.Count = 0 Then
            MessageBox.Show("Tidak ada data. Tampilkan laporan terlebih dahulu.",
                            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        CetakLaporan()
    End Sub

    Private Sub CetakLaporan()
        printCurrentRow = 0

        Dim pd As New PrintDocument()
        pd.DefaultPageSettings.Landscape = True
        pd.DefaultPageSettings.PaperSize = New PaperSize("A4", 1169, 827)
        pd.DefaultPageSettings.Margins = New Printing.Margins(40, 40, 40, 40)

        AddHandler pd.PrintPage, AddressOf PrintLaporanPage

        Dim pp As New PrintPreviewDialog()
        pp.Document = pd
        pp.Text = "Preview Laporan Produk - " & printPeriodeLabel
        pp.WindowState = FormWindowState.Maximized
        pp.ShowDialog()
    End Sub

   
    Private Sub PrintLaporanPage(sender As Object, ev As PrintPageEventArgs)
        Dim g As Graphics = ev.Graphics

        Dim marginKiri As Integer = ev.MarginBounds.Left
        Dim marginAtas As Integer = ev.MarginBounds.Top
        Dim marginKanan As Integer = ev.MarginBounds.Right
        Dim lebarTotal As Integer = ev.MarginBounds.Width
        Dim y As Integer = marginAtas
        Dim tinggiRow As Integer = 24

        Dim fJudul As New Font("Arial", 13, FontStyle.Bold)
        Dim fSub As New Font("Arial", 9, FontStyle.Regular)
        Dim fHeader As New Font("Arial", 8, FontStyle.Bold)
        Dim fData As New Font("Arial", 8, FontStyle.Regular)
        Dim fTotal As New Font("Arial", 8, FontStyle.Bold)
        Dim brush As Brush = Brushes.Black


        Dim sfL As New StringFormat()
        sfL.Alignment = StringAlignment.Near
        sfL.LineAlignment = StringAlignment.Center
        sfL.Trimming = StringTrimming.EllipsisCharacter
        sfL.FormatFlags = StringFormatFlags.NoWrap

        Dim sfLData As New StringFormat()
        sfLData.Alignment = StringAlignment.Near
        sfLData.LineAlignment = StringAlignment.Center
        sfLData.Trimming = StringTrimming.EllipsisCharacter
        sfLData.FormatFlags = StringFormatFlags.NoWrap

        Dim sfR As New StringFormat()
        sfR.Alignment = StringAlignment.Far
        sfR.LineAlignment = StringAlignment.Center

        Dim sfC As New StringFormat()
        sfC.Alignment = StringAlignment.Center
        sfC.LineAlignment = StringAlignment.Center

        ' 
        Dim wNo As Integer = 35
        Dim wKode As Integer = 90
        Dim wKategori As Integer = 95
        Dim wHarga As Integer = 105
        Dim wQty As Integer = 75
        Dim wPendapatan As Integer = 130
        Dim wStok As Integer = 90

        Dim wNama As Integer = lebarTotal - wNo - wKode - wKategori - wHarga - wQty - wPendapatan - wStok


        If printCurrentRow = 0 Then
            Dim sfJudul As New StringFormat()
            sfJudul.Alignment = StringAlignment.Center

            g.DrawString("LAPORAN DATA PRODUK", fJudul, brush,
                         New RectangleF(marginKiri, y, lebarTotal, 25), sfJudul)
            y += 25

            g.DrawString("Alam Sari Nanas  |  Kp. Simpang Desa Tambakmekar, Jalancagak - Subang",
                         fSub, Brushes.DimGray,
                         New RectangleF(marginKiri, y, lebarTotal, 18), sfJudul)
            y += 18

            g.DrawString("Periode : " & printPeriodeLabel,
                         fSub, Brushes.DimGray,
                         New RectangleF(marginKiri, y, lebarTotal, 18), sfJudul)
            y += 18

            g.DrawLine(New Pen(Color.FromArgb(0, 80, 160), 2), marginKiri, y, marginKanan, y)
            y += 8
        End If

        g.FillRectangle(New SolidBrush(Color.FromArgb(0, 102, 179)),
                        marginKiri, y, lebarTotal, tinggiRow)

        Dim xPos As Integer = marginKiri
        g.DrawString("No", fHeader, Brushes.White, New RectangleF(xPos, y, wNo, tinggiRow), sfC)
        xPos += wNo
        g.DrawString("Kode Produk", fHeader, Brushes.White, New RectangleF(xPos, y, wKode, tinggiRow), sfL)
        xPos += wKode
        g.DrawString("Nama Produk", fHeader, Brushes.White, New RectangleF(xPos, y, wNama, tinggiRow), sfL)
        xPos += wNama
        g.DrawString("Kategori", fHeader, Brushes.White, New RectangleF(xPos, y, wKategori, tinggiRow), sfL)
        xPos += wKategori
        g.DrawString("Harga", fHeader, Brushes.White, New RectangleF(xPos, y, wHarga, tinggiRow), sfR)
        xPos += wHarga
        g.DrawString("Qty Terjual", fHeader, Brushes.White, New RectangleF(xPos, y, wQty, tinggiRow), sfC)
        xPos += wQty
        g.DrawString("Total Pendapatan", fHeader, Brushes.White, New RectangleF(xPos, y, wPendapatan, tinggiRow), sfR)
        xPos += wPendapatan
        g.DrawString("Stok Tersedia", fHeader, Brushes.White, New RectangleF(xPos, y, wStok, tinggiRow), sfC)
        y += tinggiRow


        Dim noUrut As Integer = printCurrentRow + 1
        Dim isAlt As Boolean = (printCurrentRow Mod 2 = 1)

        Do While printCurrentRow < dtLaporan.Rows.Count
            If y + tinggiRow + 50 > ev.MarginBounds.Bottom Then
                Exit Do
            End If

            Dim row As DataRow = dtLaporan.Rows(printCurrentRow)

            Dim bgColor As Color = If(isAlt, Color.FromArgb(235, 245, 255), Color.White)
            g.FillRectangle(New SolidBrush(bgColor), marginKiri, y, lebarTotal, tinggiRow)
            g.DrawLine(New Pen(Color.FromArgb(210, 225, 245)),
                       marginKiri, y + tinggiRow - 1, marginKanan, y + tinggiRow - 1)

            xPos = marginKiri

            g.DrawString(noUrut.ToString(), fData, brush,
                         New RectangleF(xPos, y, wNo, tinggiRow), sfC)
            xPos += wNo

            g.DrawString(row("KodeProduk").ToString(), fData, brush,
                         New RectangleF(xPos, y, wKode, tinggiRow), sfLData)
            xPos += wKode

            g.DrawString(row("Nama_Produk").ToString(), fData, brush,
                         New RectangleF(xPos, y, wNama, tinggiRow), sfLData)
            xPos += wNama

            g.DrawString(row("Kategori").ToString(), fData, brush,
                         New RectangleF(xPos, y, wKategori, tinggiRow), sfLData)
            xPos += wKategori

            Dim valHarga As Double = If(IsDBNull(row("Harga")), 0, CDbl(row("Harga")))
            g.DrawString(FormatRupiah(valHarga), fData, brush,
                         New RectangleF(xPos, y, wHarga, tinggiRow), sfR)
            xPos += wHarga

            Dim valQty As Integer = If(IsDBNull(row("TotalQty")), 0, CInt(row("TotalQty")))
            g.DrawString(valQty.ToString(), fData, brush,
                         New RectangleF(xPos, y, wQty, tinggiRow), sfC)
            xPos += wQty

            Dim valPend As Double = If(IsDBNull(row("TotalPendapatan")), 0, CDbl(row("TotalPendapatan")))
            g.DrawString(FormatRupiah(valPend), fData, brush,
                         New RectangleF(xPos, y, wPendapatan, tinggiRow), sfR)
            xPos += wPendapatan

            Dim valStok As Integer = If(IsDBNull(row("Stok")), 0, CInt(row("Stok")))
            g.DrawString(valStok.ToString(), fData, brush,
                         New RectangleF(xPos, y, wStok, tinggiRow), sfC)

            y += tinggiRow
            printCurrentRow += 1
            noUrut += 1
            isAlt = Not isAlt
        Loop


        If printCurrentRow >= dtLaporan.Rows.Count Then
            Dim grandQty As Long = 0
            Dim grandPendapatan As Double = 0

            For Each r As DataRow In dtLaporan.Rows
                If Not IsDBNull(r("TotalQty")) Then grandQty += CLng(r("TotalQty"))
                If Not IsDBNull(r("TotalPendapatan")) Then grandPendapatan += CDbl(r("TotalPendapatan"))
            Next

            y += 3
            g.DrawLine(New Pen(Color.FromArgb(0, 80, 160), 1.5), marginKiri, y, marginKanan, y)
            y += 2

            g.FillRectangle(New SolidBrush(Color.FromArgb(210, 232, 255)),
                            marginKiri, y, lebarTotal, tinggiRow + 2)

            xPos = marginKiri + wNo
            Dim lebarLabel As Integer = wKode + wNama + wKategori + wHarga
            g.DrawString("TOTAL  (" & dtLaporan.Rows.Count.ToString() & " produk)",
                         fTotal, Brushes.DarkBlue,
                         New RectangleF(xPos, y, lebarLabel, tinggiRow + 2), sfL)
            xPos += lebarLabel

            g.DrawString(grandQty.ToString(), fTotal, Brushes.DarkBlue,
                         New RectangleF(xPos, y, wQty, tinggiRow + 2), sfC)
            xPos += wQty

            g.DrawString(FormatRupiah(grandPendapatan), fTotal, Brushes.DarkBlue,
                         New RectangleF(xPos, y, wPendapatan, tinggiRow + 2), sfR)

            y += tinggiRow + 4
            g.DrawLine(New Pen(Color.FromArgb(0, 80, 160), 2), marginKiri, y, marginKanan, y)

            ev.HasMorePages = False
        Else
            ev.HasMorePages = True
        End If
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
        Dashboard.Show()
    End Sub

End Class