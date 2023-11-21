Imports System.Threading
Imports System.Timers

Public Class Form_Kasir
    Private Sub Form_Kasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()

        Call Kondisi_Awal()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label_Waktu_Kasir.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub
    Private Sub Button_Kasir_Logout_Click(sender As Object, e As EventArgs) Handles Button_Kasir_Logout.Click, Me.Disposed, Me.Deactivate
        Me.Hide()
        Form_Login.BringToFront()
        Form_Login.Show()
    End Sub

    Private Sub SplitContainer_KelolaResep_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer_KelolaResep.Paint
        Dim Pen As New Pen(Color.FromArgb(255, 0, 165, 0), 10)
        Dim SplitSize As Point = SplitContainer_KelolaResep.Size
        Dim CenterSplitContainer As Integer = SplitSize.X / 2
        Using Pen
            e.Graphics.DrawLine(Pen, New Point(CenterSplitContainer, 0), New Point(CenterSplitContainer, SplitSize.Y))
        End Using
    End Sub
    Private Sub Panel_Input_Paint(sender As Object, e As PaintEventArgs) Handles Panel_NoResep.Paint, Panel_NamaPasien.Paint, Panel_NamaDokter.Paint, Panel_NamaObat.Paint, Panel_Harga.Paint, Panel_Quantity.Paint
        Dim Pen As New Pen(Color.FromArgb(165, 0, 0, 0), 2)
        Using Pen
            e.Graphics.DrawLine(Pen, New Point(), New Point())
        End Using
    End Sub

    Private Sub Kondisi_Awal()
        Label_Nama_Kasir.Text = Form_Login.TextBox_Login_Username.Text.ToString

    End Sub

    Private Sub Label_Nama_Kasir_Click(sender As Object, e As EventArgs) Handles Label_Nama_Kasir.Click
    End Sub
End Class