Public Class UserControl_Admin_KelolaObat
    Private Sub UserControl_Admin_KelolaObat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Show_Grid_Obat()
    End Sub
    Private Sub SplitContainer_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer_Admin_KelolaObat.Paint
        Dim Pen As New Pen(Color.FromArgb(255, 0, 165, 0), 10)
        Dim SplitSize As Point = SplitContainer_Admin_KelolaObat.Size
    Dim CenterSplitContainer As Integer = SplitSize.X / 2
    Dim Gap As Integer = 10

        Using Pen
            e.Graphics.DrawLine(Pen, New Point(CenterSplitContainer, Gap), New Point(CenterSplitContainer, SplitSize.Y - Gap * 4))
        End Using
    End Sub
    Private Sub Panel_KodeObat_Paint(sender As Object, e As PaintEventArgs) Handles Panel_KodeObat.Paint, Panel_NamaObat.Paint, Panel_Jumlah.Paint, Panel_HargaPerUnit.Paint
        Dim Pen As New Pen(Color.FromArgb(165, 0, 0, 0), 2)

        Dim TextBoxSize As Point = TextBox_KodeObat.Size
        Dim TextBoxLocation As Point = TextBox_KodeObat.Location
        Dim XPos As Integer = TextBoxLocation.X

        Using Pen
            e.Graphics.DrawLine(Pen, New Point(XPos, TextBox_KodeObat.Bottom), New Point(TextBoxSize.X + XPos, TextBox_KodeObat.Bottom))
        End Using
    End Sub

    Private Sub Show_Grid_Obat()
        Call Koneksi()
        Dim GetdataObat As String = "SELECT * FROM Tbl_Obat"
        Sda = New SqlClient.SqlDataAdapter(GetdataObat, Conn)
        Ds = New DataSet
        Sda.Fill(Ds, "Tbl_Obat")
        DataGridView_KelolaObat.DataSource = Ds.Tables("Tbl_Obat")
    End Sub

End Class
