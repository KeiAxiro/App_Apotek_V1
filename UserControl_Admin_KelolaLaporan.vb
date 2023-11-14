Imports System.Data.SqlClient

Public Class UserControl_Admin_KelolaLaporan
    Private Sub UserControl_Admin_KelolaLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Kondisi_Awal()
    End Sub
    Private Sub Show_Grid_Laporan()
        Call Koneksi()
        Dim GetDataLaporan As String = "SELECT Tgl_Transaksi,Total_Bayar FROM Tbl_Transaksi"
        Cmd = New SqlCommand(GetDataLaporan, Conn)
        Sda = New SqlDataAdapter(Cmd)
        Ds = New DataSet
        Sda.Fill(Ds, "Tbl_Transaksi")

        DataGridView_Admin_KelolaLaporan.DataSource = Ds.Tables("Tbl_Transaksi")
    End Sub

    Private Sub Kondisi_Awal()
        Call Show_Grid_Laporan()
    End Sub

    Private Sub Kondisi_Awal_Input()

    End Sub

    Private Sub Button_Load_Click(sender As Object, e As EventArgs) Handles Button_KelolaLaporan_Load.Click
        Call Show_Grid_Laporan()
    End Sub
End Class
