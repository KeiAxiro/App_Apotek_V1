Public Class UserControl_Admin_KelolaUser

    Private Sub UserControl_Admin_KelolaUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Kondisi_Awal()
    End Sub

    Sub Kondisi_Awal()
        Call Show_Grid_KelolaUser()
        Call Kondisi_Input(False)
        Call Clear_Input()

        Button_KelolaUser_Tambah.Enabled = True
        Button_KelolaUser_Edit.Enabled = False
        Button_KelolaUser_Hapus.Enabled = False
    End Sub

    Sub Kondisi_Input(kondisi)
        ComboBox_TipeUser.Enabled = kondisi
        TextBox_Nama.Enabled = kondisi
        TextBox_Telepon.Enabled = kondisi
        TextBox_Alamat.Enabled = kondisi
        TextBox_Username.Enabled = kondisi
        TextBox_Password.Enabled = kondisi
    End Sub

    Sub Clear_Input()
        ComboBox_TipeUser.Text = ""
        TextBox_Nama.Clear()
        TextBox_Telepon.Clear()
        TextBox_Alamat.Clear()
        TextBox_Username.Clear()
        TextBox_Password.Clear()
        TextBox_KelolaUser_Cari.Clear()
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
            Call Koneksi()
            Dim SelectedRow As DataGridViewRow = DataGridView_KelolaUser.Rows(e.RowIndex)
            Dim IdValue As String = SelectedRow.Cells(0).Value.ToString
            Dim GetDataUserFromId As String = "SELECT * FROM Tbl_User WHERE Id_User = @P_Id_User"

            Cmd = New SqlClient.SqlCommand(GetDataUserFromId, Conn)
            Cmd.Parameters.AddWithValue("@P_Id_User", IdValue)
            If Not IdValue = "" Then
                Srd = Cmd.ExecuteReader

                Srd.Read()
                If Srd.HasRows And Not Srd.Item("Username").Equals("") Then
                    ComboBox_TipeUser.Text = Srd.Item("Tipe_User")
                    TextBox_Nama.Text = Srd.Item("Nama_User")
                    TextBox_Alamat.Text = Srd.Item("Alamat")
                    TextBox_Telepon.Text = Srd.Item("Telepon")
                    TextBox_Username.Text = Srd.Item("Username")
                    TextBox_Password.Text = Srd.Item("Password")

                    Button_KelolaUser_Tambah.Enabled = True
                    Button_KelolaUser_Edit.Enabled = True
                    Button_KelolaUser_Hapus.Enabled = True
                Else
                    MsgBox("tambah")
                End If
            Else
                MsgBox("tambah")
            End If
        End If
    End Sub

    Private Sub Button_KelolaUser_Tambah_Click(sender As Object, e As EventArgs) Handles Button_KelolaUser_Tambah.Click

    End Sub
    Private Sub Tambah_User()
        Call Koneksi()
        Call Kondisi_Input(True)
        Call Clear_Input()

    End Sub

    Private Sub Button_KelolaUser_Edit_Click(sender As Object, e As EventArgs) Handles Button_KelolaUser_Edit.Click

    End Sub

    Private Sub Button_KelolaUser_Hapus_Click(sender As Object, e As EventArgs) Handles Button_KelolaUser_Hapus.Click

    End Sub
End Class
