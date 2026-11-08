Imports System.Data.OleDb
Imports System.IO

Module Module1

    Public namaUser As String = ""
    Public levelUser As String = ""
    Public idUser As String = ""

    ' =====================================================================
    ' KONEKSI DB - Otomatis cari NusaTech1.mdb dari StartupPath atau lokasi exe
    ' =====================================================================
    Public Function GetConnStr() As String
        ' Cari .mdb di folder Debug (saat run dari IDE)
        Dim path1 As String = Path.Combine(Application.StartupPath, "NusaTech1.mdb")
        If File.Exists(path1) Then
            Return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path1 & ";"
        End If
        ' Fallback ke folder project (2 level ke atas dari bin\Debug)
        Dim path2 As String = Path.Combine(
            Directory.GetParent(Application.StartupPath).Parent.FullName,
            "NusaTech1.mdb")
        If File.Exists(path2) Then
            Return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path2 & ";"
        End If
        ' Gunakan StartupPath sebagai default (tampilkan pesan error nanti)
        Return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path1 & ";"
    End Function

    ' Shortcut property - pakai ini di semua form
    Public ReadOnly Property connStr As String
        Get
            Return GetConnStr()
        End Get
    End Property

    ' Global data untuk struk cetak
    Public gIDTransaksi As String = ""
    Public gKasir As String = ""
    Public gTanggal As String = ""
    Public gTotalHarga As String = ""
    Public gBayar As String = ""
    Public gKembalian As String = ""
    Public gDetailTransaksi As New DataTable()

End Module