Public Class Form_Login

    'Login
    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        Call Login()
    End Sub
    Private Sub TextBox_KeyPress_Enter(sender As Object, e As KeyPressEventArgs) Handles TextBox_Login_Username.KeyPress, TextBox_Login_Password.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Login()
        End If
    End Sub
    Private Sub Login()
        Call Koneksi()
        Dim GetUserData As String = "SELECT * FROM Tbl_User WHERE Username = @P_Username AND Password = @P_Password"
        Dim Username_TextValue As String = TextBox_Login_Username.Text
        Dim Password_TextValue As String = TextBox_Login_Password.Text

        Cmd = New SqlClient.SqlCommand(GetUserData, Conn)
        Cmd.Parameters.AddWithValue("@P_Username", Username_TextValue)
        Cmd.Parameters.AddWithValue("@P_Password", Password_TextValue)
        Srd = Cmd.ExecuteReader
        Srd.Read()
        If Srd.HasRows Then
            Dim Get_TipeUser As String = Srd.Item("Tipe_User").ToString
            If Get_TipeUser.ToLower = "admin" Then
                Form_Admin_Nav.Show()
                Form_Admin_Nav.ChangePanel(New UserControl_Admin_LogActivity)
            ElseIf Get_TipeUser.ToLower = "kasir" Then
                Form_Kasir.Show()
            ElseIf Get_TipeUser.ToLower = "apoteker" Then
                Form_Apoteker.Show()

            End If
            Call Write_Log("Login", Srd.Item("Id_User"))
            Me.Hide()
        Else
            MsgBox("Username dan Password Salah!")
        End If
    End Sub
    Private Sub Button_Reset_Click(sender As Object, e As EventArgs) Handles Button_Reset.Click
        TextBox_Login_Username.Clear()
        TextBox_Login_Password.Clear()
        Call Write_Log("Reset", 1002)
    End Sub

    'Paint
    Private Sub Panel_Login_Kanan_Input_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Login_Kanan_Input.Paint
        Dim Pen As New Pen(Color.FromArgb(255, 0, 165, 0), 20)
        Dim PSize As Point = Panel_Login_Kanan_Input.Size
        Dim Gap As Integer = 25
        Using Pen
            e.Graphics.DrawLine(Pen, New Point(0, Gap), New Point(0, PSize.Y - Gap)) 'Left
            e.Graphics.DrawLine(Pen, New Point(PSize.X, Gap), New Point(PSize.X, PSize.Y - Gap)) 'Right
        End Using
    End Sub

    Private Sub Panel_Login_TextBox_Input_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Login_Username.Paint, Panel_Login_Password.Paint
        Dim Pen As New Pen(Color.FromArgb(165, 0, 0, 0), 5)
        Dim PSize As Point = Panel_Login_Username.Size
        Using Pen
            e.Graphics.DrawLine(Pen, New Point(0, PSize.Y), New Point(PSize.X, PSize.Y))
        End Using
    End Sub

End Class
