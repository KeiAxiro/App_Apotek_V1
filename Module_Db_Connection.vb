Imports System.Data.SqlClient

Module Module_Db_Connection
    Public Conn As SqlConnection
    Public Cmd As SqlCommand
    Public Sda As SqlDataAdapter
    Public Srd As SqlDataReader
    Public Ds As DataSet
    Sub Koneksi()
        'Pc Sekolah
        Dim MyDB As String = "Data Source=DESKTOP-IG5QTRU\SQLEXPRESS;User ID=keidjaru;Password=kei;initial catalog=Db_Apotek"
        'Laptop
        'Dim MyDB As String = "Data Source=DESKTOP-34EMTUJ;User ID=keidjaru;Password=kei;initial catalog=Db_Apotek"

        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then
            Try
                Conn.Open()
            Catch ex As Exception
                MsgBox(ex)
                Conn.Close()
            End Try
        End If
    End Sub

    Sub Write_Log(Aktivitas As String, Id_User As Integer)
        Call Koneksi()
        Dim GetDateNow = DateTime.Now
        Dim Insert_Log_Data As String = "INSERT INTO Tbl_Log(Waktu,Aktivitas,Id_User) VALUES(@P_Waktu,@P_Aktivitas,@P_Id_User)"
        Cmd = New SqlCommand(Insert_Log_Data, Conn)
        Cmd.Parameters.AddWithValue("@P_Waktu", Format(GetDateNow, "yyyy-MM-dd hh:mm:ss"))
        Cmd.Parameters.AddWithValue("@P_Aktivitas", Aktivitas)
        Cmd.Parameters.AddWithValue("@P_Id_User", Id_User)

        'MsgBox(Cmd.ExecuteNonQuery)
        Cmd.ExecuteNonQuery()

    End Sub
End Module
