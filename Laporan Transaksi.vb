
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms

Public Class LaporanTransaksi

    Private ReadOnly connStr As String =
        "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" &
        Application.StartupPath & "\NusaTech1.mdb"

    Private modeLaporan As String = "Harian"


    Private dtLaporan As New DataTable()


    Private strukIdTransaksi As String = ""
    Private strukTanggal As String = ""
    Private strukKasir As String = ""
    Private strukTotal As Double = 0
    Private strukBayar As Double = 0
    Private strukKembalian As Double = 0
    Private strukDetail As New DataTable()


    Private printCurrentRow As Integer = 0
    Private printPeriodeLabel As String = ""

    Private Sub LaporanTransaksi_Load(sender As Object, e As EventArgs) _
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

        dgvLaporan.EnableHeadersVisualStyles = False
        dgvLaporan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 102, 179)
        dgvLaporan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvLaporan.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        dgvLaporan.ColumnHeadersHeight = 32
        dgvLaporan.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255)

        Dim colNo As New DataGridViewTextBoxColumn()
        colNo.Name = "colNo"
        colNo.HeaderText = "No"
        colNo.Width = 45
        colNo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dim colId As New DataGridViewTextBoxColumn()
        colId.Name = "colIdTransaksi"
        colId.HeaderText = "ID Transaksi"
        colId.DataPropertyName = "Id_Transaksi"
        colId.Width = 160

        Dim colTgl As New DataGridViewTextBoxColumn()
        colTgl.Name = "colTanggal"
        colTgl.HeaderText = "Tanggal"
        colTgl.DataPropertyName = "Tanggal"
        colTgl.Width = 150
        colTgl.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"

        Dim colKasir As New DataGridViewTextBoxColumn()
        colKasir.Name = "colKasir"
        colKasir.HeaderText = "Kasir"
        colKasir.DataPropertyName = "Id_User"
        colKasir.Width = 90

        Dim colTotal As New DataGridViewTextBoxColumn()
        colTotal.Name = "colTotal"
        colTotal.HeaderText = "Total Harga"
        colTotal.DataPropertyName = "Total_Harga"
        colTotal.Width = 130
        colTotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        colTotal.DefaultCellStyle.Format = "'Rp '##,##0"

        Dim colBayar As New DataGridViewTextBoxColumn()
        colBayar.Name = "colBayar"
        colBayar.HeaderText = "Bayar"
        colBayar.DataPropertyName = "Bayar"
        colBayar.Width = 120
        colBayar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        colBayar.DefaultCellStyle.Format = "'Rp '##,##0"

        Dim colKembalian As New DataGridViewTextBoxColumn()
        colKembalian.Name = "colKembalian"
        colKembalian.HeaderText = "Kembalian"
        colKembalian.DataPropertyName = "Kembalian"
        colKembalian.Width = 120
        colKembalian.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        colKembalian.DefaultCellStyle.Format = "'Rp '##,##0"

        dgvLaporan.Columns.AddRange(New DataGridViewColumn() {
            colNo, colId, colTgl, colKasir, colTotal, colBayar, colKembalian})
    End Sub

    Private Sub SetModeHarian()
        modeLaporan = "Harian"
        dtpPeriode.Format = DateTimePickerFormat.Long
        Guna2Button1.BackColor = Color.FromArgb(0, 102, 179)
        Guna2Button1.ForeColor = Color.White
        btnBulanan.BackColor = Color.FromArgb(200, 225, 255)
        btnBulanan.ForeColor = Color.FromArgb(0, 70, 140)
    End Sub

    Private Sub SetModeBulanan()
        modeLaporan = "Bulanan"
        dtpPeriode.Format = DateTimePickerFormat.Custom
        dtpPeriode.CustomFormat = "MMMM yyyy"
        btnBulanan.BackColor = Color.FromArgb(0, 102, 179)
        btnBulanan.ForeColor = Color.White
        Guna2Button1.BackColor = Color.FromArgb(200, 225, 255)
        Guna2Button1.ForeColor = Color.FromArgb(0, 70, 140)
    End Sub

    Private Sub btnHarian_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
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
                    "SELECT Id_Transaksi, Tanggal, Id_User, Total_Harga, Bayar, Kembalian " &
                    "FROM Transaksi " &
                    "WHERE Tanggal >= @tglAwal AND Tanggal < @tglAkhir " &
                    "ORDER BY Tanggal DESC"
                cmd.Parameters.AddWithValue("@tglAwal", tglAwal)
                cmd.Parameters.AddWithValue("@tglAkhir", tglAkhir)
                printPeriodeLabel = "Harian : " & tglDipilih.ToString("dd MMMM yyyy")

            ElseIf modeLaporan = "Bulanan" Then
                Dim bulan As Integer = dtpPeriode.Value.Month
                Dim tahun As Integer = dtpPeriode.Value.Year
                cmd.CommandText =
                    "SELECT Id_Transaksi, Tanggal, Id_User, Total_Harga, Bayar, Kembalian " &
                    "FROM Transaksi " &
                    "WHERE Month(Tanggal) = @bln AND Year(Tanggal) = @thn " &
                    "ORDER BY Tanggal DESC"
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


        If dgvLaporan.SelectedRows.Count = 1 Then
            Dim pilihan As DialogResult = MessageBox.Show(
                "Pilih jenis cetak:" & vbCrLf & vbCrLf &
                "  [Yes]  → Cetak LAPORAN semua transaksi" & vbCrLf &
                "  [No]   → Cetak STRUK transaksi yang dipilih",
                "Pilih Jenis Cetak",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question)

            If pilihan = DialogResult.Yes Then
                CetakLaporan()
            ElseIf pilihan = DialogResult.No Then
                Dim idTrx As String = ""
                If dgvLaporan.SelectedRows(0).Cells("colIdTransaksi").Value IsNot Nothing Then
                    idTrx = dgvLaporan.SelectedRows(0).Cells("colIdTransaksi").Value.ToString()
                End If
                If idTrx <> "" Then CetakStruk(idTrx)
            End If
        Else

            CetakLaporan()
        End If
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
        pp.Text = "Preview Laporan Transaksi - " & printPeriodeLabel
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

        Dim fJudul As New Font("Arial", 13, FontStyle.Bold)
        Dim fSub As New Font("Arial", 9, FontStyle.Regular)
        Dim fHeader As New Font("Arial", 8, FontStyle.Bold)
        Dim fData As New Font("Arial", 8, FontStyle.Regular)
        Dim fTotal As New Font("Arial", 8, FontStyle.Bold)
        Dim brush As Brush = Brushes.Black
        Dim tinggiRow As Integer = 20

        Dim wNo As Integer = 35
        Dim wId As Integer = 160
        Dim wTgl As Integer = 130
        Dim wKasir As Integer = 70
        Dim wTotal As Integer = 115
        Dim wBayar As Integer = 110
        Dim wKembalian As Integer = lebarTotal - wNo - wId - wTgl - wKasir - wTotal - wBayar


        Dim sfL As New StringFormat() : sfL.Alignment = StringAlignment.Near : sfL.LineAlignment = StringAlignment.Center
        Dim sfR As New StringFormat() : sfR.Alignment = StringAlignment.Far : sfR.LineAlignment = StringAlignment.Center
        Dim sfC As New StringFormat() : sfC.Alignment = StringAlignment.Center : sfC.LineAlignment = StringAlignment.Center

        If printCurrentRow = 0 Then

            Dim sfJudul As New StringFormat()
            sfJudul.Alignment = StringAlignment.Center
            g.DrawString("LAPORAN TRANSAKSI PENJUALAN", fJudul, brush,
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


        Dim yHeaderTop As Integer = y
        Dim yHeaderBot As Integer = y + tinggiRow
        g.FillRectangle(New SolidBrush(Color.FromArgb(0, 102, 179)),
                        marginKiri, yHeaderTop, lebarTotal, tinggiRow)

        Dim xPos As Integer = marginKiri
        g.DrawString("No", fHeader, Brushes.White, New RectangleF(xPos, yHeaderTop, wNo, tinggiRow), sfC)
        xPos += wNo
        g.DrawString("ID Transaksi", fHeader, Brushes.White, New RectangleF(xPos, yHeaderTop, wId, tinggiRow), sfL)
        xPos += wId
        g.DrawString("Tanggal", fHeader, Brushes.White, New RectangleF(xPos, yHeaderTop, wTgl, tinggiRow), sfL)
        xPos += wTgl
        g.DrawString("Kasir", fHeader, Brushes.White, New RectangleF(xPos, yHeaderTop, wKasir, tinggiRow), sfL)
        xPos += wKasir
        g.DrawString("Total Harga", fHeader, Brushes.White, New RectangleF(xPos, yHeaderTop, wTotal, tinggiRow), sfR)
        xPos += wTotal
        g.DrawString("Bayar", fHeader, Brushes.White, New RectangleF(xPos, yHeaderTop, wBayar, tinggiRow), sfR)
        xPos += wBayar
        g.DrawString("Kembalian", fHeader, Brushes.White, New RectangleF(xPos, yHeaderTop, wKembalian, tinggiRow), sfR)
        y = yHeaderBot

        Dim noUrut As Integer = printCurrentRow + 1
        Dim isAlt As Boolean = False

        Do While printCurrentRow < dtLaporan.Rows.Count

            If y + tinggiRow + 50 > ev.MarginBounds.Bottom Then
                Exit Do
            End If

            Dim row As DataRow = dtLaporan.Rows(printCurrentRow)


            Dim bgColor As Color = If(isAlt, Color.FromArgb(235, 245, 255), Color.White)
            g.FillRectangle(New SolidBrush(bgColor), marginKiri, y, lebarTotal, tinggiRow)


            g.DrawLine(New Pen(Color.FromArgb(210, 225, 245)), marginKiri, y + tinggiRow - 1, marginKanan, y + tinggiRow - 1)

            xPos = marginKiri
            ' No
            g.DrawString(noUrut.ToString(), fData, brush, New RectangleF(xPos, y, wNo, tinggiRow), sfC)
            xPos += wNo

            g.DrawString(row("Id_Transaksi").ToString(), fData, brush, New RectangleF(xPos, y, wId, tinggiRow), sfL)
            xPos += wId

            Dim tglStr As String = ""
            If Not IsDBNull(row("Tanggal")) Then
                tglStr = CDate(row("Tanggal")).ToString("dd/MM/yyyy HH:mm")
            End If
            g.DrawString(tglStr, fData, brush, New RectangleF(xPos, y, wTgl, tinggiRow), sfL)
            xPos += wTgl

            g.DrawString(row("Id_User").ToString(), fData, brush, New RectangleF(xPos, y, wKasir, tinggiRow), sfL)
            xPos += wKasir

            Dim valTotal As Double = If(IsDBNull(row("Total_Harga")), 0, CDbl(row("Total_Harga")))
            g.DrawString(FormatRupiah(valTotal), fData, brush, New RectangleF(xPos, y, wTotal, tinggiRow), sfR)
            xPos += wTotal

            Dim valBayar As Double = If(IsDBNull(row("Bayar")), 0, CDbl(row("Bayar")))
            g.DrawString(FormatRupiah(valBayar), fData, brush, New RectangleF(xPos, y, wBayar, tinggiRow), sfR)
            xPos += wBayar

            Dim valKembalian As Double = If(IsDBNull(row("Kembalian")), 0, CDbl(row("Kembalian")))
            g.DrawString(FormatRupiah(valKembalian), fData, brush, New RectangleF(xPos, y, wKembalian, tinggiRow), sfR)

            y += tinggiRow
            printCurrentRow += 1
            noUrut += 1
            isAlt = Not isAlt
        Loop


        If printCurrentRow >= dtLaporan.Rows.Count Then

            Dim grandTotal As Double = 0
            Dim grandBayar As Double = 0
            Dim grandKembalian As Double = 0

            For Each r As DataRow In dtLaporan.Rows
                If Not IsDBNull(r("Total_Harga")) Then grandTotal += CDbl(r("Total_Harga"))
                If Not IsDBNull(r("Bayar")) Then grandBayar += CDbl(r("Bayar"))
                If Not IsDBNull(r("Kembalian")) Then grandKembalian += CDbl(r("Kembalian"))
            Next

            y += 3
            g.DrawLine(New Pen(Color.FromArgb(0, 80, 160), 1.5), marginKiri, y, marginKanan, y)
            y += 2

            g.FillRectangle(New SolidBrush(Color.FromArgb(210, 232, 255)),
                            marginKiri, y, lebarTotal, tinggiRow + 2)

            xPos = marginKiri
            g.DrawString("", fTotal, brush, New RectangleF(xPos, y, wNo, tinggiRow + 2), sfC)
            xPos += wNo

            Dim lebarLabel As Integer = wId + wTgl + wKasir
            g.DrawString("TOTAL  (" & dtLaporan.Rows.Count.ToString() & " transaksi)",
                         fTotal, Brushes.DarkBlue,
                         New RectangleF(xPos, y, lebarLabel, tinggiRow + 2), sfL)
            xPos += lebarLabel

            g.DrawString(FormatRupiah(grandTotal), fTotal, Brushes.DarkBlue,
                         New RectangleF(xPos, y, wTotal, tinggiRow + 2), sfR)
            xPos += wTotal
            g.DrawString(FormatRupiah(grandBayar), fTotal, Brushes.DarkBlue,
                         New RectangleF(xPos, y, wBayar, tinggiRow + 2), sfR)
            xPos += wBayar
            g.DrawString(FormatRupiah(grandKembalian), fTotal, Brushes.DarkBlue,
                         New RectangleF(xPos, y, wKembalian, tinggiRow + 2), sfR)

            y += tinggiRow + 4
            g.DrawLine(New Pen(Color.FromArgb(0, 80, 160), 2), marginKiri, y, marginKanan, y)

            ev.HasMorePages = False
        Else

            ev.HasMorePages = True
        End If
    End Sub

  
    Private Sub dgvLaporan_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvLaporan.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim idTrx As String = ""
            If dgvLaporan.Rows(e.RowIndex).Cells("colIdTransaksi").Value IsNot Nothing Then
                idTrx = dgvLaporan.Rows(e.RowIndex).Cells("colIdTransaksi").Value.ToString()
            End If
            If idTrx <> "" Then CetakStruk(idTrx)
        End If
    End Sub

    Private Sub CetakStruk(idTrx As String)
        Dim conn As New OleDbConnection(connStr)
        Try
            conn.Open()

            Dim cmdTrx As New OleDbCommand(
                "SELECT Id_Transaksi, Tanggal, Id_User, Total_Harga, Bayar, Kembalian " &
                "FROM Transaksi WHERE Id_Transaksi = @id", conn)
            cmdTrx.Parameters.AddWithValue("@id", idTrx)

            Dim drTrx As OleDbDataReader = cmdTrx.ExecuteReader()
            If drTrx.Read() Then
                strukIdTransaksi = drTrx("Id_Transaksi").ToString()
                strukTanggal = CDate(drTrx("Tanggal")).ToString("dd/MM/yyyy HH:mm")
                strukKasir = drTrx("Id_User").ToString()
                strukTotal = CDbl(drTrx("Total_Harga"))
                strukBayar = CDbl(drTrx("Bayar"))
                strukKembalian = CDbl(drTrx("Kembalian"))
            Else
                MessageBox.Show("Data transaksi tidak ditemukan.",
                                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                drTrx.Close()
                Exit Sub
            End If
            drTrx.Close()

            Dim cmdDetail As New OleDbCommand(
                "SELECT p.Nama_Produk, d.Jumlah_Prod, d.SubTotal " &
                "FROM Detail_Transaksi AS d " &
                "INNER JOIN Produk AS p ON d.KodeProduk = p.KodeProduk " &
                "WHERE d.Id_Transaksi = @id", conn)
            cmdDetail.Parameters.AddWithValue("@id", idTrx)

            Dim daDetail As New OleDbDataAdapter(cmdDetail)
            strukDetail = New DataTable()
            daDetail.Fill(strukDetail)
            conn.Close()

            Dim pd As New PrintDocument()
            pd.DefaultPageSettings.PaperSize = New PaperSize("Receipt", 315, 800)
            AddHandler pd.PrintPage, AddressOf PrintStrukPage

            Dim pp As New PrintPreviewDialog()
            pp.Document = pd
            pp.Text = "Preview Struk - " & strukIdTransaksi
            pp.Width = 500
            pp.Height = 700
            pp.ShowDialog()

        Catch ex As Exception
            If conn.State = ConnectionState.Open Then conn.Close()
            MessageBox.Show("Gagal mencetak struk:" & vbCrLf & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  
    Private Sub PrintStrukPage(sender As Object, ev As PrintPageEventArgs)
        Dim g As Graphics = ev.Graphics
        Dim x As Integer = 15
        Dim y As Integer = 15
        Dim lebar As Integer = 270

        Dim fJudul As New Font("Courier New", 10, FontStyle.Bold)
        Dim fNormal As New Font("Courier New", 9, FontStyle.Regular)
        Dim fBold As New Font("Courier New", 9, FontStyle.Bold)
        Dim brush As Brush = Brushes.Black

        Dim sfCenter As New StringFormat()
        sfCenter.Alignment = StringAlignment.Center
        Dim sfRight As New StringFormat()
        sfRight.Alignment = StringAlignment.Far

        g.DrawString("Alam Sari Nanas", fJudul, brush, New Rectangle(x, y, lebar, 20), sfCenter)
        y += 18
        g.DrawString("Kp. Simpang Desa Tambakmekar", fNormal, brush, New Rectangle(x, y, lebar, 20), sfCenter)
        y += 15
        g.DrawString("Jalancagak - Subang", fNormal, brush, New Rectangle(x, y, lebar, 20), sfCenter)
        y += 15
        g.DrawString("HP: 0858-4669-4337", fNormal, brush, New Rectangle(x, y, lebar, 20), sfCenter)
        y += 18
        g.DrawLine(Pens.Black, x, y, x + lebar, y)
        y += 8

        g.DrawString("ID Transaksi : " & strukIdTransaksi, fNormal, brush, x, y)
        y += 15
        g.DrawString("Kasir        : " & strukKasir, fNormal, brush, x, y)
        y += 15
        g.DrawString("Tanggal      : " & strukTanggal, fNormal, brush, x, y)
        y += 15
        g.DrawLine(Pens.Black, x, y, x + lebar, y)
        y += 8

        g.DrawString("Nama Produk", fBold, brush, x, y)
        g.DrawString("Qty", fBold, brush, New Rectangle(x, y, lebar - 90, 20), sfRight)
        g.DrawString("Sub Total", fBold, brush, New Rectangle(x, y, lebar, 20), sfRight)
        y += 15
        g.DrawLine(Pens.Black, x, y, x + lebar, y)
        y += 6

        For Each row As DataRow In strukDetail.Rows
            Dim nama As String = row("Nama_Produk").ToString()
            Dim qty As Integer = CInt(row("Jumlah_Prod"))
            Dim subTotal As Double = CDbl(row("SubTotal"))
            g.DrawString(nama, fNormal, brush, x, y)
            g.DrawString(qty.ToString(), fNormal, brush, New Rectangle(x, y, lebar - 90, 20), sfRight)
            g.DrawString(FormatRupiah(subTotal), fNormal, brush, New Rectangle(x, y, lebar, 20), sfRight)
            y += 15
        Next

        y += 5
        g.DrawLine(Pens.Black, x, y, x + lebar, y)
        y += 8

        g.DrawString("TOTAL", fBold, brush, x, y)
        g.DrawString(FormatRupiah(strukTotal), fBold, brush, New Rectangle(x, y, lebar, 20), sfRight)
        y += 18
        g.DrawString("Bayar", fNormal, brush, x, y)
        g.DrawString(FormatRupiah(strukBayar), fNormal, brush, New Rectangle(x, y, lebar, 20), sfRight)
        y += 15
        g.DrawString("Kembalian", fNormal, brush, x, y)
        g.DrawString(FormatRupiah(strukKembalian), fNormal, brush, New Rectangle(x, y, lebar, 20), sfRight)
        y += 18

        g.DrawLine(Pens.Black, x, y, x + lebar, y)
        y += 10
        g.DrawString("~ Terima Kasih ~", fBold, brush, New Rectangle(x, y, lebar, 20), sfCenter)
        y += 18
        g.DrawString("Sudah Berbelanja Di Toko Kami", fNormal, brush, New Rectangle(x, y, lebar, 20), sfCenter)

        ev.HasMorePages = False
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
        Dashboard.Show()
    End Sub

End Class
