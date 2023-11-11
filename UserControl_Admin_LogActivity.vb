Imports System.Data.SqlClient

Public Class UserControl_Admin_LogActivity

    Private Sub UserControl_Admin_LogActivity_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Me.Load, Me.ControlAdded
        Call Show_Grid_LogActivity()
    End Sub
    Private Sub Button_Admin_LogActivity_Load_Click(sender As Object, e As EventArgs) Handles Button_Admin_LogActivity_Load.Click
        Call Show_Grid_LogActivity()
    End Sub

    Private Sub Show_Grid_LogActivity()
        Call Koneksi()

        Dim DatePicker = Format(DateTimePicker_Admin_LogActivity.Value.Date, "yyyy-MM-dd 00:00:00").ToString

        Dim GetDataLog As String = "SELECT Id_Log,Tbl_User.Username,Waktu,Aktivitas FROM Tbl_Log INNER JOIN Tbl_User On Tbl_Log.Id_User = Tbl_User.Id_User WHERE Waktu > @P_Waktu ORDER BY Waktu DESC"
        Cmd = New SqlClient.SqlCommand(GetDataLog, Conn)
        Sda = New SqlClient.SqlDataAdapter(Cmd)
        Cmd.Parameters.AddWithValue("@P_Waktu", DatePicker)
        Ds = New DataSet
        Sda.Fill(Ds, "Tbl_Log")

        DataGridView_Admin_LogActivity.DataSource = Ds.Tables("Tbl_Log")

    End Sub
End Class
