Public Class UserControl_Admin_KelolaUser
    Private Sub SplitContainer_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer_Admin_KelolaUser.Paint
        Dim Pen As New Pen(Color.FromArgb(255, 0, 165, 0), 20)
        Dim SplitSize As Point = SplitContainer_Admin_KelolaUser.Size
        Dim CenterSplitContainer As Integer = SplitSize.X / 2
        Using Pen
            e.Graphics.DrawLine(Pen, New Point(CenterSplitContainer, 0), New Point(CenterSplitContainer, SplitSize.Y))
        End Using
    End Sub

    Private Sub TextBox_Input_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Nama.Paint, Panel_Telepon.Paint, Panel_Alamat.Paint, Panel_Username.Paint, Panel_Password.Paint
        Dim Pen As New Pen(Color.FromArgb(255, 0, 0, 0), 2)
        Dim TextBoxSize As Point = TextBox_Nama.Size
        Dim TextBoxLoc As Point = TextBox_Nama.Location

        Dim Gap As Integer = TextBoxLoc.X

        Dim StartPoint As Point = New Point(Gap, Panel_Nama.Size.Height - 10)
        Dim EndPoint As Point = New Point(Panel_Nama.Width - Gap, Panel_Nama.Size.Height - 10)

        Using Pen
            e.Graphics.DrawLine(Pen, StartPoint, EndPoint)
        End Using
    End Sub


End Class
