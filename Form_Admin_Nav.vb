Public Class Form_Admin_Nav
    Private Sub Form_Admin_Nav_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChangePanel(New UserControl_Admin_LogActivity())
    End Sub

    Private Sub Form_Admin_Nav_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed, Me.Closed, Me.Deactivate
        Form_Login.Show()
    End Sub

    Sub ChangePanel(ByVal NewPanel As UserControl)
        Panel_Admin_Kanan.Controls.Clear()

        NewPanel.Dock = DockStyle.Fill
        Panel_Admin_Kanan.Controls.Add(NewPanel)
        NewPanel.BringToFront()
        NewPanel.Focus()

    End Sub

    Private Sub Button_Admin_KelolaUser_Click(sender As Object, e As EventArgs) Handles Button_Admin_KelolaUser.Click
        ChangePanel(New UserControl_Admin_KelolaUser)
    End Sub
    Private Sub Button_Admin_KelolaObat_Click(sender As Object, e As EventArgs) Handles Button_Admin_KelolaObat.Click
        ChangePanel(New UserControl_Admin_KelolaObat)
    End Sub
    Private Sub Button_Admin_KelolaLaporan_Click(sender As Object, e As EventArgs) Handles Button_Admin_KelolaLaporan.Click
        ChangePanel(New UserControl_Admin_KelolaLaporan)
    End Sub
    Private Sub Button_Admin_Logout_Click(sender As Object, e As EventArgs) Handles Button_Admin_Logout.Click
        Form_Login.Show()
        Me.Hide()
    End Sub
End Class