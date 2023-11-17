Imports System.Data.SqlClient

Public Class Form_Apoteker
    Private Sub Form_Apoteker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Kondisi_Awal()
    End Sub

    Private Sub Button_Apoteker_Logout_Click(sender As Object, e As EventArgs) Handles Button_Apoteker_Logout.Click
        Call Kondisi_Awal()
        Form_Login.Show()
        Me.Hide()

    End Sub
    Private Sub Form_Apoteker_Dispose(sender As Object, e As EventArgs) Handles MyBase.Disposed, MyBase.Closed
        Call Kondisi_Awal()
        Form_Login.Show()
    End Sub

    Private Sub Panel_Input_Paint(sender As Object, e As PaintEventArgs) Handles Panel_NoResep.Paint, Panel_NamaPasien.Paint, Panel_NamaDokter.Paint, Panel_NamaObat.Paint, Panel_Quantity.Paint
        Dim Pen As New Pen(Color.FromArgb(165, 0, 0, 0), 2)
        Dim TextBoxLocation As Point = TextBox_NoResep.Location
        Dim PSize As Point = Panel_NoResep.Size
        Dim TextBoxSize As Point = TextBox_NoResep.Size
        Dim XPos As Integer = TextBoxLocation.X

        Using Pen
            e.Graphics.DrawLine(Pen, New Point(XPos, TextBox_NoResep.Bottom), New Point(PSize.X - XPos, TextBox_NoResep.Bottom))
        End Using
    End Sub

    Private Sub Kondisi_Awal()
        Call Show_Grid_KelolaResep()
        Call Kondisi_Input(False)
        Call Clear_Input()

        Button_KelolaResep_Edit.Enabled = False
        Button_KelolaResep_Hapus.Enabled = False

        Button_KelolaResep_Edit.Text = "Edit"
        Button_KelolaResep_Hapus.Text = "Hapus"
    End Sub

    Private Sub Kondisi_Input(kondisi As Boolean)
        TextBox_NoResep.Enabled = kondisi
        DateTimePicker_TanggalResep.Enabled = kondisi
        TextBox_NamaPasien.Enabled = kondisi
        TextBox_NamaDokter.Enabled = kondisi
        TextBox_NamaObat.Enabled = kondisi
        TextBox_Quantity.Enabled = kondisi
    End Sub

    Private Sub Clear_Input()
        Label_IdObat.ResetText()
        TextBox_NoResep.Clear()
        DateTimePicker_TanggalResep.Value = Date.Now
        TextBox_NamaPasien.Clear()
        TextBox_NamaDokter.Clear()
        TextBox_NamaObat.Clear()
        TextBox_Quantity.Clear()
        TextBox_KelolaResep_Cari.Clear()
    End Sub

    Private Sub Show_Grid_KelolaResep()
        Call Koneksi()
        Dim GetDataResep As String = "SELECT * FROM Tbl_Resep"
        Cmd = New SqlClient.SqlCommand(GetDataResep, Conn)
        Sda = New SqlClient.SqlDataAdapter(Cmd)
        Ds = New DataSet

        Sda.Fill(Ds, "Tbl_Resep")

        DataGridView_KelolaResep.DataSource = Ds.Tables("Tbl_Resep")

    End Sub

    Private Sub DataGridView_KelolaResep_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_KelolaResep.CellClick
        If e.RowIndex >= 0 Then
            Call Koneksi()
            Dim SelectedRow As DataGridViewRow = DataGridView_KelolaResep.Rows(e.RowIndex)
            Dim IdValue As String = SelectedRow.Cells(0).Value.ToString
            Dim GetDataResep = "SELECT * FROM Tbl_Resep WHERE Id_Resep = @P_Id_Resep"
            Cmd = New SqlClient.SqlCommand(GetDataResep, Conn)
            Cmd.Parameters.AddWithValue("@P_Id_Resep", IdValue)

            Srd = Cmd.ExecuteReader

            If Srd.HasRows Then
                Srd.Read()
                Label_IdObat.Text = Srd.Item("Id_Resep")
                TextBox_NoResep.Text = Srd.Item("No_Resep")
                DateTimePicker_TanggalResep.Value = Srd.Item("tgl_Resep")
                TextBox_NamaPasien.Text = Srd.Item("Nama_Pasien")
                TextBox_NamaDokter.Text = Srd.Item("Nama_Dokter")
                TextBox_NamaObat.Text = Srd.Item("Nama_ObatDiBeli")
                TextBox_Quantity.Text = Srd.Item("Jumlah_ObatDiBeli")

                Button_KelolaResep_Edit.Enabled = True
                Button_KelolaResep_Hapus.Enabled = True

            Else
                MsgBox("Data Tidak Tersedia!", vbOKOnly, "Warning")
            End If

        End If
    End Sub

    Private Sub Button_KelolaResep_Edit_Click(sender As Object, e As EventArgs) Handles Button_KelolaResep_Edit.Click
        If Button_KelolaResep_Edit.Text.ToLower = "edit" Then
            Button_KelolaResep_Edit.Text = "Simpan"
            Button_KelolaResep_Hapus.Text = "Cancel"

            Call Kondisi_Input(True)
        ElseIf Button_KelolaResep_Edit.Text.ToLower = "simpan" Then
            Call Edit_Resep()
            Call Kondisi_Awal()
        End If
    End Sub

    Private Sub Edit_Resep()
        Call Koneksi()
        Dim EditDataResep As String = "UPDATE Tbl_Resep
    SET 
    Tgl_Resep = @P_Tgl_Resep,
    Nama_Dokter = @P_Nama_Dokter,
    Nama_Pasien = @P_Nama_Pasien,
    Nama_ObatDiBeli = @P_Nama_Obat,
    Jumlah_ObatDiBeli = @P_Jumlah
    WHERE Id_Resep = @P_Id_Resep"

        Cmd = New SqlCommand(EditDataResep, Conn)

        Cmd.Parameters.AddWithValue("@P_Tgl_Resep", DateTimePicker_TanggalResep.Value.Date)
        Cmd.Parameters.AddWithValue("@P_Nama_Dokter", TextBox_NamaDokter.Text)
        Cmd.Parameters.AddWithValue("@P_Nama_Pasien", TextBox_NamaPasien.Text)
        Cmd.Parameters.AddWithValue("@P_Nama_Obat", TextBox_NamaObat.Text)
        Cmd.Parameters.AddWithValue("@P_Jumlah", Convert.ToInt64(TextBox_Quantity.Text))
        Cmd.Parameters.AddWithValue("@P_Id_Resep", Label_IdObat.Text)

        Cmd.ExecuteNonQuery()

    End Sub

    Private Sub Button_KelolaResep_Hapus_Click(sender As Object, e As EventArgs) Handles Button_KelolaResep_Hapus.Click
        If Button_KelolaResep_Hapus.Text.ToLower = "hapus" Then
            Call Hapus_Resep()
            Call Kondisi_Awal()
        ElseIf Button_KelolaResep_Hapus.Text.ToLower = "cancel" Then
            Call Kondisi_Awal()
        End If
    End Sub

    Private Sub Hapus_Resep()
        Call Koneksi()
        Dim DeleteDataResep As String = "DELETE FROM Tbl_Resep WHERE Id_Resep = @P_Id_Resep"
        Cmd = New SqlCommand(DeleteDataResep, Conn)
        Cmd.Parameters.AddWithValue("@P_Id_Resep", Label_IdObat.Text)
        Cmd.ExecuteNonQuery()
    End Sub

    Private Sub TextBox_KelolaResep_Cari_TextChanged(sender As Object, e As EventArgs) Handles TextBox_KelolaResep_Cari.TextChanged
        Call Koneksi()
        Dim GetDataResepFrom As String = "SELECT * FROM Tbl_Resep
    WHERE 
    No_Resep LIKE '%' + @P_Search + '%' OR
    Nama_Pasien LIKE '%' + @P_Search + '%' OR
    Nama_Dokter LIKE '%' + @P_Search + '%' OR
    Nama_ObatDiBeli LIKE '%' + @P_Search + '%'
"
        Cmd = New SqlCommand(GetDataResepFrom, Conn)
        Cmd.Parameters.AddWithValue("@P_Search", TextBox_KelolaResep_Cari.Text)
        Sda = New SqlDataAdapter(Cmd)
        Ds = New DataSet

        Sda.Fill(Ds, "Tbl_Reset")

        DataGridView_KelolaResep.DataSource = Ds.Tables("Tbl_Reset")
    End Sub
End Class