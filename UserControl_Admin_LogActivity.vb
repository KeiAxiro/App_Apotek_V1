Public Class UserControl_Admin_LogActivity

    Private Sub UserControl_Admin_LogActivity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Show_Grid_LogActivity()
    End Sub
    Private Sub Button_Admin_LogActivity_Load_Click(sender As Object, e As EventArgs) Handles Button_Admin_LogActivity_Load.Click
        Call Show_Grid_LogActivity()
    End Sub

    Private Sub Show_Grid_LogActivity()
        Call Koneksi()
        Dim GetDataLog As String = "SELECT Id_Log,Tbl_User.Username,Waktu,Aktivitas FROM Tbl_Log INNER JOIN Tbl_User On Tbl_Log.Id_User = Tbl_User.Id_User ORDER BY Waktu"
        Sda = New SqlClient.SqlDataAdapter(GetDataLog, Conn)
        Ds = New DataSet
        Sda.Fill(Ds, "Tbl_Log")
        DataGridView_Admin_LogActivity.DataSource = Ds.Tables("Tbl_Log")
    End Sub

    Private Sub DateTimePicker_Admin_LogActivity_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_Admin_LogActivity.ValueChanged

    End Sub
End Class
