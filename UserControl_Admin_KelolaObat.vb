Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices

Public Class UserControl_Admin_KelolaObat
    Private Sub UserControl_Admin_KelolaObat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Kondisi_Awal()
    End Sub
    Private Sub SplitContainer_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer_Admin_KelolaObat.Paint
        Dim Pen As New Pen(Color.FromArgb(255, 0, 165, 0), 10)
        Dim SplitSize As Point = SplitContainer_Admin_KelolaObat.Size
        Dim CenterSplitContainer As Integer = SplitSize.X / 2
        Dim Gap As Integer = 10

        Using Pen
            e.Graphics.DrawLine(Pen, New Point(CenterSplitContainer, Gap), New Point(CenterSplitContainer, SplitSize.Y - Gap * 4))
        End Using
    End Sub
    Private Sub Panel_KodeObat_Paint(sender As Object, e As PaintEventArgs) Handles Panel_KodeObat.Paint, Panel_NamaObat.Paint, Panel_Jumlah.Paint, Panel_HargaPerUnit.Paint
        Dim Pen As New Pen(Color.FromArgb(165, 0, 0, 0), 2)

        Dim TextBoxSize As Point = TextBox_KodeObat.Size
        Dim TextBoxLocation As Point = TextBox_KodeObat.Location
        Dim XPos As Integer = TextBoxLocation.X

        Using Pen
            e.Graphics.DrawLine(Pen, New Point(XPos, TextBox_KodeObat.Bottom), New Point(TextBoxSize.X + XPos, TextBox_KodeObat.Bottom))
        End Using
    End Sub

    Private Sub Kondisi_Awal()
        Call Show_Grid_Obat()
        Call Kondisi_Input(False)
        Call Clear_Input()

        Button_KelolaObat_Tambah.Enabled = True
        Button_KelolaObat_Edit.Enabled = False
        Button_KelolaObat_Hapus.Enabled = False

        Button_KelolaObat_Tambah.Text = "Tambah"
        Button_KelolaObat_Edit.Text = "Edit"
        Button_KelolaObat_Hapus.Text = "Hapus"
    End Sub

    Private Sub Kondisi_Input(Kondisi As Boolean)
        TextBox_KodeObat.Enabled = Kondisi
        TextBox_NamaObat.Enabled = Kondisi
        DateTimePicker_ExpiredDate.Enabled = Kondisi
        TextBox_Jumlah.Enabled = Kondisi
        TextBox_Harga.Enabled = Kondisi
    End Sub

    Private Sub Clear_Input()
        TextBox_KodeObat.Clear()
        TextBox_NamaObat.Clear()
        DateTimePicker_ExpiredDate.Value = DateTimePicker.MinimumDateTime
        TextBox_Jumlah.Clear()
        TextBox_Harga.Clear()
        TextBox_KelolaObat_Cari.Clear()
    End Sub

    Private Sub Show_Grid_Obat()
        Call Koneksi()
        Dim GetdataObat As String = "SELECT * FROM Tbl_Obat"
        Sda = New SqlClient.SqlDataAdapter(GetdataObat, Conn)
        Ds = New DataSet
        Sda.Fill(Ds, "Tbl_Obat")
        DataGridView_KelolaObat.DataSource = Ds.Tables("Tbl_Obat")
    End Sub
    Private Sub DataGridView_KelolaObat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_KelolaObat.CellClick
        If e.RowIndex >= 0 Then
            Dim SelectedRow As DataGridViewRow = DataGridView_KelolaObat.Rows(e.RowIndex)
            Dim IdValue As String = SelectedRow.Cells(0).Value.ToString

            Call Koneksi()
            Dim GetDataObat As String = "SELECT * FROM Tbl_Obat WHERE Id_Obat = @P_Id_Obat"
            Cmd = New SqlCommand(GetDataObat, Conn)
            Cmd.Parameters.AddWithValue("@P_Id_Obat", IdValue)

            If IdValue <> "" Then
                Srd = Cmd.ExecuteReader
                Srd.Read()

                If Srd.HasRows Then
                    Label_Id_Obat.Text = Srd.Item("Id_Obat")
                    TextBox_KodeObat.Text = Srd.Item("Kode_Obat")
                    TextBox_NamaObat.Text = Srd.Item("Nama_Obat")
                    DateTimePicker_ExpiredDate.Value = Srd.Item("Expired_Date")
                    TextBox_Jumlah.Text = Srd.Item("Jumlah")
                    TextBox_Harga.Text = Srd.Item("Jumlah")

                    Button_KelolaObat_Tambah.Enabled = True
                    Button_KelolaObat_Edit.Enabled = True
                    Button_KelolaObat_Hapus.Enabled = True
                End If
            Else
                MsgBox("Data Tidak Tersedia!", vbOKOnly, "Error")
                Call Kondisi_Awal()
            End If
        End If
    End Sub

    Private Sub Button_KelolaObat_Tambah_Click(sender As Object, e As EventArgs) Handles Button_KelolaObat_Tambah.Click
        If Button_KelolaObat_Tambah.Text.ToLower = "tambah" Then
            Call Kondisi_Input(True)
            Call Clear_Input()

            TextBox_KodeObat.Focus()

            Button_KelolaObat_Tambah.Text = "Simpan"
            Button_KelolaObat_Hapus.Text = "Cancel"

            Button_KelolaObat_Edit.Enabled = False
            Button_KelolaObat_Hapus.Enabled = True

        ElseIf Button_KelolaObat_Tambah.Text.ToLower = "simpan" Then

            Call Tambah_Obat()
            Call Kondisi_Awal()
        End If
    End Sub

    Private Sub Tambah_Obat()
        Call Koneksi()
        Dim InsertDataObat As String = "INSERT INTO Tbl_Obat(Kode_Obat,Nama_Obat,Expired_Date,Jumlah,Harga) VALUES(@P_Kode_Obat,@P_Nama_Obat,@P_Expired_Date,@P_Jumlah,@P_Harga)"
        Cmd = New SqlClient.SqlCommand(InsertDataObat, Conn)

        Cmd.Parameters.AddWithValue("@P_Kode_Obat", TextBox_KodeObat.Text)
        Cmd.Parameters.AddWithValue("@P_Nama_Obat", TextBox_NamaObat.Text)
        Cmd.Parameters.AddWithValue("@P_Expired_Date", DateTimePicker_ExpiredDate.Value.Date)
        Cmd.Parameters.AddWithValue("@P_Jumlah", TextBox_Jumlah.Text)
        Cmd.Parameters.AddWithValue("@P_Harga", Int(TextBox_Harga.Text))

        Cmd.ExecuteNonQuery()

    End Sub

    Private Sub Button_KelolaObat_Edit_Click(sender As Object, e As EventArgs) Handles Button_KelolaObat_Edit.Click

    End Sub

    Private Sub Button_KelolaObat_Hapus_Click(sender As Object, e As EventArgs) Handles Button_KelolaObat_Hapus.Click
        If Button_KelolaObat_Hapus.Text.ToLower = "hapus" Then

        ElseIf Button_KelolaObat_Hapus.Text.ToLower = "cancel" Then
            Kondisi_Awal()
        End If
    End Sub

End Class
