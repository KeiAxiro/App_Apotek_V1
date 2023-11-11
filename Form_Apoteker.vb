Public Class Form_Apoteker
    Private Sub Button_Apoteker_Logout_Click(sender As Object, e As EventArgs) Handles Button_Apoteker_Logout.Click
        Form_Login.Show()
        Me.Hide()
    End Sub
    Private Sub Form_Apoteker_Dispose(sender As Object, e As EventArgs) Handles MyBase.Disposed, MyBase.Closed
        Form_Login.Show()
    End Sub

    Private Sub Panel_Input_Paint(sender As Object, e As PaintEventArgs) Handles Panel_KodeObat.Paint, Panel_NamaObat.Paint, Panel_Jumlah.Paint, Panel_HargaPerUnit.Paint
        Dim Pen As New Pen(Color.FromArgb(165, 0, 0, 0), 2)
        Dim TextBoxLocation As Point = TextBox_KodeObat.Location
        Dim PSize As Point = Panel_KodeObat.Size
        Dim TextBoxSize As Point = TextBox_KodeObat.Size
        Dim XPos As Integer = TextBoxLocation.X

        Using Pen
            e.Graphics.DrawLine(Pen, New Point(XPos, TextBox_KodeObat.Bottom), New Point(PSize.X - XPos, TextBox_KodeObat.Bottom))
        End Using
    End Sub
End Class