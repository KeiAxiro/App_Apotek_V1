Public Class Form_Kasir
    Private Sub Button_Kasir_Logout_Click(sender As Object, e As EventArgs) Handles Button_Kasir_Logout.Click, Me.Disposed, Me.Deactivate
        Form_Login.Show()
        Me.Hide()
    End Sub


End Class