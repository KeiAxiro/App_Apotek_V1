Public Class UserControl_Admin_KelolaUser

    Private Sub UserControl_Admin_KelolaUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Kondisi_Awal()
    End Sub

    Sub Kondisi_Awal()
        Call Show_Grid_KelolaUser()
    End Sub

    Private Sub Show_Grid_KelolaUser()
        Call Koneksi()
        Dim GetDataUser As String = "SELECT * FROM Tbl_User"
        Sda = New SqlClient.SqlDataAdapter(GetDataUser, Conn)
        Ds = New DataSet
        Sda.Fill(Ds, "Tbl_User")
        DataGridView_KelolaUser.DataSource = Ds.Tables("Tbl_User")
    End Sub

    Private Sub SplitContainer_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer_Admin_KelolaUser.Paint
        Dim Pen As New Pen(Color.FromArgb(255, 0, 165, 0), 10)
        Dim SplitSize As Point = SplitContainer_Admin_KelolaUser.Size
        Dim CenterSplitContainer As Integer = SplitSize.X / 2
        Dim Gap As Integer = 10
        Using Pen
            e.Graphics.DrawLine(Pen, New Point(CenterSplitContainer, Gap), New Point(CenterSplitContainer, SplitSize.Y - Gap * 4))
        End Using
    End Sub

    Private Sub Panel_Input_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Nama.Paint, Panel_Telepon.Paint, Panel_Alamat.Paint, Panel_Username.Paint, Panel_Password.Paint
        Dim Pen As New Pen(Color.FromArgb(165, 0, 0, 0), 2)
        Dim TextBoxSize As Point = TextBox_Nama.Size
        Dim TextBoxLocation As Point = TextBox_Nama.Location
        Dim XPos As Integer = TextBoxLocation.X

        Using Pen
            e.Graphics.DrawLine(Pen, New Point(XPos, TextBox_Nama.Bottom), New Point(TextBoxSize.X + XPos, TextBox_Nama.Bottom))
        End Using

    End Sub

    Private Sub DataGridView_KelolaUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_KelolaUser.CellClick
        If e.RowIndex >= 0 Then
            MsgBox("Kamu Klik: " & e.RowIndex)
        End If
    End Sub

End Class
