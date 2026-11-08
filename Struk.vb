Imports System.Drawing.Printing

Public Class Struk

    Private WithEvents pd As New PrintDocument()
    Private printFont As Font
    Private boldFont As Font
    Private titleFont As Font

  
    Private Sub Struk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        printFont = New Font("Courier New", 9)
        boldFont = New Font("Courier New", 9, FontStyle.Bold)
        titleFont = New Font("Courier New", 11, FontStyle.Bold)

        pd.DefaultPageSettings.PaperSize = New PaperSize("Struk", 302, 600)
        pd.DefaultPageSettings.Margins = New Margins(10, 10, 10, 10)

        TampilkanPrintPreview()
    End Sub

    Private Sub TampilkanPrintPreview()
        Dim ppd As New PrintPreviewDialog()
        ppd.Document = pd
        ppd.Width = 750
        ppd.Height = 650
        ppd.Text = "Preview Struk - " & gIDTransaksi
        ppd.ShowDialog()


        Me.Close()
    End Sub

    Private Sub pd_PrintPage(sender As Object, e As PrintPageEventArgs) Handles pd.PrintPage
        Dim g As Graphics = e.Graphics
        Dim y As Single = 15
        Dim x As Single = 10
        Dim lebar As Single = 260

        Dim sf As New StringFormat()
        sf.Alignment = StringAlignment.Center
        Dim sfR As New StringFormat()
        sfR.Alignment = StringAlignment.Far


        g.DrawString("Alam Sari Nanas", titleFont, Brushes.Black,
                     New RectangleF(x, y, lebar, 22), sf)
        y += 22
        g.DrawString("Kp. Simpang Desa Tambakmekar", printFont, Brushes.Black,
                     New RectangleF(x, y, lebar, 16), sf)
        y += 16
        g.DrawString("Jalancagak - Subang", printFont, Brushes.Black,
                     New RectangleF(x, y, lebar, 16), sf)
        y += 16
        g.DrawString("HP: 0858-4669-4337", printFont, Brushes.Black,
                     New RectangleF(x, y, lebar, 16), sf)
        y += 18

        GarisLurus(g, x, y, lebar) : y += 8

        g.DrawString("ID Transaksi : " & gIDTransaksi, printFont, Brushes.Black, x, y) : y += 16
        g.DrawString("Kasir        : " & gKasir, printFont, Brushes.Black, x, y) : y += 16
        g.DrawString("Tanggal      : " & gTanggal, printFont, Brushes.Black, x, y) : y += 16

        GarisLurus(g, x, y, lebar) : y += 8

        Dim xNama As Single = x
        Dim xQty As Single = x + 140
        Dim xHarga As Single = x + 175

        g.DrawString("Nama Produk", boldFont, Brushes.Black, xNama, y)
        g.DrawString("Qty", boldFont, Brushes.Black, xQty, y)
        g.DrawString("Sub Total", boldFont, Brushes.Black, xHarga, y)
        y += 16

        GarisLurus(g, x, y, lebar) : y += 6


        For Each row As DataRow In gDetailTransaksi.Rows
            Dim nama As String = row("NamaProduk").ToString()
            Dim qty As String = row("Jumlah").ToString()
            Dim subTot As String = "Rp " & FormatAngka(row("SubTotal").ToString())

            If nama.Length > 18 Then nama = nama.Substring(0, 18)

            g.DrawString(nama, printFont, Brushes.Black, xNama, y)
            g.DrawString(qty, printFont, Brushes.Black, xQty, y)
            g.DrawString(subTot, printFont, Brushes.Black, xHarga, y)
            y += 16
        Next

        y += 4
        GarisLurus(g, x, y, lebar) : y += 8


        g.DrawString("TOTAL     :", boldFont, Brushes.Black, x, y)
        g.DrawString("Rp " & FormatAngka(gTotalHarga), boldFont, Brushes.Black,
                     New RectangleF(x, y, lebar, 18), sfR)
        y += 18

        g.DrawString("Bayar     :", printFont, Brushes.Black, x, y)
        g.DrawString("Rp " & FormatAngka(gBayar), printFont, Brushes.Black,
                     New RectangleF(x, y, lebar, 16), sfR)
        y += 16

        g.DrawString("Kembalian :", printFont, Brushes.Black, x, y)
        g.DrawString("Rp " & FormatAngka(gKembalian), printFont, Brushes.Black,
                     New RectangleF(x, y, lebar, 16), sfR)
        y += 12

        GarisLurus(g, x, y, lebar) : y += 12


        g.DrawString("~ Terima Kasih ~", boldFont, Brushes.Black,
                     New RectangleF(x, y, lebar, 20), sf)
        y += 18
        g.DrawString("Sudah Berbelanja Di Toko Kami", printFont, Brushes.Black,
                     New RectangleF(x, y, lebar, 16), sf)

        e.HasMorePages = False
    End Sub


    Private Sub GarisLurus(g As Graphics, x As Single, y As Single, lebar As Single)
        g.DrawLine(Pens.Black, x, y, x + lebar, y)
    End Sub

    Private Function FormatAngka(nilai As String) As String
        Dim n As Decimal
        Dim bersih As String = nilai.Replace(".", "").Replace(",", "")
        If Decimal.TryParse(bersih, n) Then
            Return n.ToString("N0").Replace(",", ".")
        End If
        Return nilai
    End Function

End Class