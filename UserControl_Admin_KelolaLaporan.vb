Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class UserControl_Admin_KelolaLaporan
    Private Sub UserControl_Admin_KelolaLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Kondisi_Awal()
    End Sub
    Private Sub Kondisi_Awal()
        Call Show_Grid_Laporan_All()
    End Sub
    Private Sub Show_Grid_Laporan_All()
        Call Koneksi()
        Dim GetDataLaporan As String = "SELECT Tgl_Transaksi,Total_Bayar FROM Tbl_Transaksi"
        Cmd = New SqlCommand(GetDataLaporan, Conn)
        Sda = New SqlDataAdapter(Cmd)
        Ds = New DataSet
        Sda.Fill(Ds, "Tbl_Transaksi")

        DataGridView_Admin_KelolaLaporan.DataSource = Ds.Tables("Tbl_Transaksi")
    End Sub

    Private Sub Show_Grid_Laporan_Tgl()
        Call Koneksi()
        Dim GetDataLaporan As String = "SELECT Tgl_Transaksi,Total_Bayar FROM Tbl_Transaksi WHERE Tgl_Transaksi >= @P_DatePickerDari AND Tgl_Transaksi <= @P_DatePickerSampai ORDER BY Tgl_Transaksi"
        Cmd = New SqlCommand(GetDataLaporan, Conn)
        Cmd.Parameters.AddWithValue("@P_DatePickerDari", DateTimePicker_KelolaLaporan_Dari.Value.Date)
        Cmd.Parameters.AddWithValue("@P_DatePickerSampai", DateTimePicker_KelolaLaporan_Sampai.Value.Date)
        Sda = New SqlDataAdapter(Cmd)
        Ds = New DataSet
        Sda.Fill(Ds, "Tbl_Transaksi")

        DataGridView_Admin_KelolaLaporan.DataSource = Ds.Tables("Tbl_Transaksi")
    End Sub

    Private Sub Generate_Chart_Laporan_Transaksi()
        Call Koneksi()

        Dim ChartKT As Chart = Chart_Admin_kelolaLaporan
        ChartKT.Series.Clear()
        Dim SeriesKT As New Series("Tgl_Transaksi_x_Total_Bayar")
        Dim GetDataLaporanSum As String = "SELECT Tgl_Transaksi,SUM(Total_Bayar) AS Total_Bayar FROM Tbl_Transaksi WHERE Tgl_Transaksi >= @P_DatePickerDari AND Tgl_Transaksi <= @P_DatePickerSampai GROUP BY Tgl_Transaksi ORDER BY Tgl_Transaksi"

        Cmd = New SqlCommand(GetDataLaporanSum, Conn)
        Cmd.Parameters.AddWithValue("@P_DatePickerDari", DateTimePicker_KelolaLaporan_Dari.Value.Date)
        Cmd.Parameters.AddWithValue("@P_DatePickerSampai", DateTimePicker_KelolaLaporan_Sampai.Value.Date)
        Sda = New SqlDataAdapter(Cmd)
        Ds = New DataSet
        Sda.Fill(Ds)


        For Each row As DataRow In Ds.Tables(0).Rows
            Dim tgl_t As Date = CDate(row("Tgl_Transaksi"))
            Dim total_bayar As Double = CDbl(row("Total_Bayar"))

            SeriesKT.Points.AddXY(tgl_t, total_bayar)
        Next

        ChartKT.Series.Add(SeriesKT)
        ChartKT.Series("Tgl_Transaksi_x_Total_Bayar").ChartType = SeriesChartType.Column
        ChartKT.ChartAreas(0).AxisX.Title = "Tanggal"
        ChartKT.ChartAreas(0).AxisY.Title = "Total Bayar"

    End Sub

    Private Sub Button_Load_Click(sender As Object, e As EventArgs) Handles Button_KelolaLaporan_Load.Click
        Call Show_Grid_Laporan_Tgl()

    End Sub

    Private Sub Button_KelolaLaporan_Generate_Click(sender As Object, e As EventArgs) Handles Button_KelolaLaporan_Generate.Click
        Call Generate_Chart_Laporan_Transaksi()
    End Sub
End Class
