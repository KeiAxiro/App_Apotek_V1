Public Class UserControl_Admin_KelolaObat
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
        Dim Psize As Point = Panel_KodeObat.Size
        Dim TextBoxSize As Point = TextBox_KodeObat.Size
        Dim TextBoxLocation As Point = TextBox_KodeObat.Location
        Dim XPos As Integer = TextBoxLocation.X

        Using Pen
            e.Graphics.DrawLine(Pen, New Point(XPos, TextBox_KodeObat.Bottom), New Point(TextBoxSize.X + XPos, TextBox_KodeObat.Bottom))
        End Using
    End Sub

End Class
