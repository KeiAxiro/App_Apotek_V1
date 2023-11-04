Public Class Form1
    Private Sub Panel_Login_Kanan_Input_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Login_Kanan_Input.Paint
        Dim Pen As New Pen(Color.FromArgb(255, 0, 200, 0), 10)
        Dim PSize As Point = Panel_Login_Kanan_Input.Size
        Dim Gap As Integer = 25
        Using Pen
            e.Graphics.DrawLine(Pen, New Point(0, Gap), New Point(0, PSize.Y - Gap)) 'Left
            e.Graphics.DrawLine(Pen, New Point(PSize.X, Gap), New Point(PSize.X, PSize.Y - Gap)) 'Right
        End Using
    End Sub
End Class
