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
        Dim TextBoxSize As Point = TextBox_NoResep.Size
        Dim PanelSize As Point = Panel_NoResep.Size
        Dim TextBoxLocation As Point = TextBox_NoResep.Location
        Dim XPos As Integer = PanelSize.X - TextBoxSize.X

        Dim StartP As Point = New Point(XPos, TextBox_NoResep.Bottom)
        Dim EndP As Point = New Point(PanelSize.X, TextBox_NoResep.Bottom)
        Using Pen
            e.Graphics.DrawLine(Pen, StartP, EndP)
        End Using
    End Sub

    Private Sub Kondisi_Awal()
        Label_Nama_Kasir.Text = Form_Login.TextBox_Login_Username.Text.ToString
        Clear_Input()
    End Sub

    Private Sub TextBox_Number(sender As Object, e As KeyPressEventArgs) Handles TextBox_Harga.KeyPress, TextBox_Quantity.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Clear_Input()
        ComboBox_TypeResep.ResetText()
        TextBox_NoResep.Clear()
        DateTimePicker_Tgl_Resep.ResetText()
        TextBox_NamaPasien.Clear()
        TextBox_NamaDokter.Clear()
        TextBox_NamaObat.Clear()
        TextBox_Harga.Clear()
        TextBox_Quantity.Clear()
    End Sub

    Private Sub Kondisi_Input_Resep(kondisi As Boolean)

    End Sub
    Private Sub Kondisi_Input_NonResep(kondisi As Boolean)

    End Sub

    Private Sub Label_Nama_Kasir_Click(sender As Object, e As EventArgs) Handles Label_Nama_Kasir.Click
    End Sub
End Class