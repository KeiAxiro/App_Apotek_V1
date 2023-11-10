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

        Button_KelolaUser_Hapus.Text = "Hapus"

        DataGridView_KelolaUser.Enabled = True
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

        Label_Admin_Id_User.Text = ""
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
            If IdValue <> "" Then
                Srd = Cmd.ExecuteReader

                Srd.Read()
                If Srd.HasRows AndAlso Not Srd.Item("Tipe_User").Equals("RESET") Then
                    Label_Admin_Id_User.Text = IdValue
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
        If Button_KelolaUser_Tambah.Text.ToLower = "tambah" Then
            Button_KelolaUser_Tambah.Text = "Simpan"
            Call Kondisi_Input(True)
            DataGridView_KelolaUser.Enabled = False
            Call Clear_Input()
        ElseIf Button_KelolaUser_Tambah.Text.ToLower = "simpan" Then
            If ComboBox_TipeUser.Text <> "" AndAlso TextBox_Nama.Text <> "" AndAlso TextBox_Telepon.Text <> "" AndAlso TextBox_Alamat.Text <> "" AndAlso TextBox_Username.Text <> "" Then
                Button_KelolaUser_Tambah.Text = "Tambah"
                Call Tambah_User()
                Call Kondisi_Awal()
            Else
                MsgBox("Masukan Input Dengan Benar!")
            End If
        End If
    End Sub
    Private Sub Tambah_User()
        Call Koneksi()
        Dim InsertDataUser As String = "INSERT INTO Tbl_User(Tipe_User,Nama_User,Alamat,Telepon,Username,Password) Values(@P_Tipe_User,@P_Nama_User,@P_Alamat,@P_Telepon,@P_Username,@P_Password)"
        Cmd = New SqlClient.SqlCommand(InsertDataUser, Conn)
        'Parameter
        Cmd.Parameters.AddWithValue("@P_Tipe_User", ComboBox_TipeUser.Text)
        Cmd.Parameters.AddWithValue("@P_Nama_User", TextBox_Nama.Text)
        Cmd.Parameters.AddWithValue("@P_Alamat", TextBox_Alamat.Text)
        Cmd.Parameters.AddWithValue("@P_Telepon", TextBox_Telepon.Text)
        Cmd.Parameters.AddWithValue("@P_Username", TextBox_Username.Text)
        Cmd.Parameters.AddWithValue("@P_Password", TextBox_Password.Text)

        Cmd.ExecuteNonQuery()

    End Sub

    Private Sub Button_KelolaUser_Edit_Click(sender As Object, e As EventArgs) Handles Button_KelolaUser_Edit.Click
        If Button_KelolaUser_Edit.Text.ToLower = "edit" Then

            Button_KelolaUser_Edit.Text = "Simpan"
            Call Kondisi_Input(True)
        ElseIf Button_KelolaUser_Edit.Text.ToLower = "simpan" Then
            Call Edit_User()
            Call Kondisi_Awal()
        End If
    End Sub

    Private Sub Edit_User()
        Call Koneksi()
        Dim UpdateDataUser As String = "UPDATE Tbl_User Set Tipe_User = @P_Tipe_User,Nama_User = @P_Nama_User,Alamat = @P_Alamat,Telepon = @P_Telepon,Username = @P_Username,Password = @P_Password WHERE Id_User = @P_Id_User"
        Cmd = New SqlClient.SqlCommand(UpdateDataUser, Conn)

        Cmd.Parameters.AddWithValue("@P_Tipe_User", ComboBox_TipeUser.Text)
        Cmd.Parameters.AddWithValue("@P_Nama_User", TextBox_Nama.Text)
        Cmd.Parameters.AddWithValue("@P_Alamat", TextBox_Alamat.Text)
        Cmd.Parameters.AddWithValue("@P_Telepon", TextBox_Telepon.Text)
        Cmd.Parameters.AddWithValue("@P_Username", TextBox_Username.Text)
        Cmd.Parameters.AddWithValue("@P_Password", TextBox_Password.Text)

        Cmd.Parameters.AddWithValue("@P_Id_User", Label_Admin_Id_User.Text.ToString)

        Cmd.ExecuteNonQuery()
    End Sub

    Private Sub Button_KelolaUser_Hapus_Click(sender As Object, e As EventArgs) Handles Button_KelolaUser_Hapus.Click
        If Label_Admin_Id_User.Text <> "" Then
            Call Hapus_user()
            Call Kondisi_Awal()
        End If
    End Sub
    Private Sub Hapus_user()
        Call Koneksi()
        Dim DeleteUser As String = "DELETE FROM Tbl_User WHERE Id_User = @P_Id_User"
        Cmd = New SqlClient.SqlCommand(DeleteUser, Conn)
        Cmd.Parameters.AddWithValue("@P_Id_User", Label_Admin_Id_User.Text.ToString)

        Cmd.ExecuteNonQuery()

    End Sub
End Class
