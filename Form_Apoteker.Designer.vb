<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Apoteker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel_Apoteker_Kanan = New System.Windows.Forms.Panel()
        Me.Label_IdObat = New System.Windows.Forms.Label()
        Me.SplitContainer_KelolaResep = New System.Windows.Forms.SplitContainer()
        Me.Button_KelolaResep_Hapus = New System.Windows.Forms.Button()
        Me.Button_KelolaResep_Edit = New System.Windows.Forms.Button()
        Me.Panel_NamaPasien = New System.Windows.Forms.Panel()
        Me.Label_NamaPasien = New System.Windows.Forms.Label()
        Me.TextBox_NamaPasien = New System.Windows.Forms.TextBox()
        Me.Panel_TanggalResep = New System.Windows.Forms.Panel()
        Me.DateTimePicker_TanggalResep = New System.Windows.Forms.DateTimePicker()
        Me.Label_TanggalResep = New System.Windows.Forms.Label()
        Me.Panel_NoResep = New System.Windows.Forms.Panel()
        Me.Label_NoResep = New System.Windows.Forms.Label()
        Me.TextBox_NoResep = New System.Windows.Forms.TextBox()
        Me.Panel_KelolaResep_Cari = New System.Windows.Forms.Panel()
        Me.TextBox_KelolaResep_Cari = New System.Windows.Forms.TextBox()
        Me.Label_KelolaResep_Cari = New System.Windows.Forms.Label()
        Me.Panel_Quantity = New System.Windows.Forms.Panel()
        Me.Label_Quantity = New System.Windows.Forms.Label()
        Me.TextBox_Quantity = New System.Windows.Forms.TextBox()
        Me.Panel_NamaObat = New System.Windows.Forms.Panel()
        Me.Label_NamaObat = New System.Windows.Forms.Label()
        Me.TextBox_NamaObat = New System.Windows.Forms.TextBox()
        Me.Panel_NamaDokter = New System.Windows.Forms.Panel()
        Me.Label_NamaDokter = New System.Windows.Forms.Label()
        Me.TextBox_NamaDokter = New System.Windows.Forms.TextBox()
        Me.Label_KelolaObat = New System.Windows.Forms.Label()
        Me.DataGridView_KelolaResep = New System.Windows.Forms.DataGridView()
        Me.SplitContainer_Login = New System.Windows.Forms.SplitContainer()
        Me.Panel_Apoteker_Kiri = New System.Windows.Forms.Panel()
        Me.Label_Apoteker_KelolaResep = New System.Windows.Forms.Label()
        Me.Label_Apoteker = New System.Windows.Forms.Label()
        Me.Button_Apoteker_Logout = New System.Windows.Forms.Button()
        Me.PictureBox_Apoteker_Logo = New System.Windows.Forms.PictureBox()
        Me.Panel_Apoteker_Kanan.SuspendLayout()
        CType(Me.SplitContainer_KelolaResep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_KelolaResep.Panel1.SuspendLayout()
        Me.SplitContainer_KelolaResep.Panel2.SuspendLayout()
        Me.SplitContainer_KelolaResep.SuspendLayout()
        Me.Panel_NamaPasien.SuspendLayout()
        Me.Panel_TanggalResep.SuspendLayout()
        Me.Panel_NoResep.SuspendLayout()
        Me.Panel_KelolaResep_Cari.SuspendLayout()
        Me.Panel_Quantity.SuspendLayout()
        Me.Panel_NamaObat.SuspendLayout()
        Me.Panel_NamaDokter.SuspendLayout()
        CType(Me.DataGridView_KelolaResep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer_Login, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Login.Panel1.SuspendLayout()
        Me.SplitContainer_Login.Panel2.SuspendLayout()
        Me.SplitContainer_Login.SuspendLayout()
        Me.Panel_Apoteker_Kiri.SuspendLayout()
        CType(Me.PictureBox_Apoteker_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Apoteker_Kanan
        '
        Me.Panel_Apoteker_Kanan.Controls.Add(Me.Label_IdObat)
        Me.Panel_Apoteker_Kanan.Controls.Add(Me.SplitContainer_KelolaResep)
        Me.Panel_Apoteker_Kanan.Controls.Add(Me.Label_KelolaObat)
        Me.Panel_Apoteker_Kanan.Controls.Add(Me.DataGridView_KelolaResep)
        Me.Panel_Apoteker_Kanan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Apoteker_Kanan.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Apoteker_Kanan.Name = "Panel_Apoteker_Kanan"
        Me.Panel_Apoteker_Kanan.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel_Apoteker_Kanan.Size = New System.Drawing.Size(707, 411)
        Me.Panel_Apoteker_Kanan.TabIndex = 0
        '
        'Label_IdObat
        '
        Me.Label_IdObat.AutoSize = True
        Me.Label_IdObat.Location = New System.Drawing.Point(158, 13)
        Me.Label_IdObat.Name = "Label_IdObat"
        Me.Label_IdObat.Size = New System.Drawing.Size(42, 13)
        Me.Label_IdObat.TabIndex = 8
        Me.Label_IdObat.Text = "Id Obat"
        '
        'SplitContainer_KelolaResep
        '
        Me.SplitContainer_KelolaResep.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer_KelolaResep.IsSplitterFixed = True
        Me.SplitContainer_KelolaResep.Location = New System.Drawing.Point(5, 40)
        Me.SplitContainer_KelolaResep.Name = "SplitContainer_KelolaResep"
        '
        'SplitContainer_KelolaResep.Panel1
        '
        Me.SplitContainer_KelolaResep.Panel1.Controls.Add(Me.Button_KelolaResep_Hapus)
        Me.SplitContainer_KelolaResep.Panel1.Controls.Add(Me.Button_KelolaResep_Edit)
        Me.SplitContainer_KelolaResep.Panel1.Controls.Add(Me.Panel_NamaPasien)
        Me.SplitContainer_KelolaResep.Panel1.Controls.Add(Me.Panel_TanggalResep)
        Me.SplitContainer_KelolaResep.Panel1.Controls.Add(Me.Panel_NoResep)
        '
        'SplitContainer_KelolaResep.Panel2
        '
        Me.SplitContainer_KelolaResep.Panel2.Controls.Add(Me.Panel_KelolaResep_Cari)
        Me.SplitContainer_KelolaResep.Panel2.Controls.Add(Me.Panel_Quantity)
        Me.SplitContainer_KelolaResep.Panel2.Controls.Add(Me.Panel_NamaObat)
        Me.SplitContainer_KelolaResep.Panel2.Controls.Add(Me.Panel_NamaDokter)
        Me.SplitContainer_KelolaResep.Size = New System.Drawing.Size(697, 217)
        Me.SplitContainer_KelolaResep.SplitterDistance = 341
        Me.SplitContainer_KelolaResep.SplitterWidth = 7
        Me.SplitContainer_KelolaResep.TabIndex = 5
        '
        'Button_KelolaResep_Hapus
        '
        Me.Button_KelolaResep_Hapus.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_KelolaResep_Hapus.Location = New System.Drawing.Point(171, 182)
        Me.Button_KelolaResep_Hapus.Name = "Button_KelolaResep_Hapus"
        Me.Button_KelolaResep_Hapus.Size = New System.Drawing.Size(79, 30)
        Me.Button_KelolaResep_Hapus.TabIndex = 9
        Me.Button_KelolaResep_Hapus.Text = "Hapus"
        Me.Button_KelolaResep_Hapus.UseVisualStyleBackColor = True
        '
        'Button_KelolaResep_Edit
        '
        Me.Button_KelolaResep_Edit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_KelolaResep_Edit.Location = New System.Drawing.Point(86, 182)
        Me.Button_KelolaResep_Edit.Name = "Button_KelolaResep_Edit"
        Me.Button_KelolaResep_Edit.Size = New System.Drawing.Size(79, 30)
        Me.Button_KelolaResep_Edit.TabIndex = 8
        Me.Button_KelolaResep_Edit.Text = "Edit"
        Me.Button_KelolaResep_Edit.UseVisualStyleBackColor = True
        '
        'Panel_NamaPasien
        '
        Me.Panel_NamaPasien.Controls.Add(Me.Label_NamaPasien)
        Me.Panel_NamaPasien.Controls.Add(Me.TextBox_NamaPasien)
        Me.Panel_NamaPasien.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_NamaPasien.Location = New System.Drawing.Point(0, 120)
        Me.Panel_NamaPasien.Name = "Panel_NamaPasien"
        Me.Panel_NamaPasien.Size = New System.Drawing.Size(341, 60)
        Me.Panel_NamaPasien.TabIndex = 2
        '
        'Label_NamaPasien
        '
        Me.Label_NamaPasien.AutoSize = True
        Me.Label_NamaPasien.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_NamaPasien.Location = New System.Drawing.Point(20, 0)
        Me.Label_NamaPasien.Name = "Label_NamaPasien"
        Me.Label_NamaPasien.Size = New System.Drawing.Size(100, 19)
        Me.Label_NamaPasien.TabIndex = 2
        Me.Label_NamaPasien.Text = "Nama Pasien"
        '
        'TextBox_NamaPasien
        '
        Me.TextBox_NamaPasien.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_NamaPasien.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_NamaPasien.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_NamaPasien.Location = New System.Drawing.Point(18, 30)
        Me.TextBox_NamaPasien.Name = "TextBox_NamaPasien"
        Me.TextBox_NamaPasien.Size = New System.Drawing.Size(307, 20)
        Me.TextBox_NamaPasien.TabIndex = 1
        '
        'Panel_TanggalResep
        '
        Me.Panel_TanggalResep.Controls.Add(Me.DateTimePicker_TanggalResep)
        Me.Panel_TanggalResep.Controls.Add(Me.Label_TanggalResep)
        Me.Panel_TanggalResep.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_TanggalResep.Location = New System.Drawing.Point(0, 60)
        Me.Panel_TanggalResep.Name = "Panel_TanggalResep"
        Me.Panel_TanggalResep.Size = New System.Drawing.Size(341, 60)
        Me.Panel_TanggalResep.TabIndex = 1
        '
        'DateTimePicker_TanggalResep
        '
        Me.DateTimePicker_TanggalResep.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker_TanggalResep.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker_TanggalResep.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_TanggalResep.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_TanggalResep.Location = New System.Drawing.Point(18, 27)
        Me.DateTimePicker_TanggalResep.Name = "DateTimePicker_TanggalResep"
        Me.DateTimePicker_TanggalResep.Size = New System.Drawing.Size(307, 26)
        Me.DateTimePicker_TanggalResep.TabIndex = 3
        Me.DateTimePicker_TanggalResep.Value = New Date(2023, 11, 14, 0, 0, 0, 0)
        '
        'Label_TanggalResep
        '
        Me.Label_TanggalResep.AutoSize = True
        Me.Label_TanggalResep.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TanggalResep.Location = New System.Drawing.Point(20, 0)
        Me.Label_TanggalResep.Name = "Label_TanggalResep"
        Me.Label_TanggalResep.Size = New System.Drawing.Size(113, 19)
        Me.Label_TanggalResep.TabIndex = 2
        Me.Label_TanggalResep.Text = "Tanggal Resep"
        '
        'Panel_NoResep
        '
        Me.Panel_NoResep.Controls.Add(Me.Label_NoResep)
        Me.Panel_NoResep.Controls.Add(Me.TextBox_NoResep)
        Me.Panel_NoResep.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_NoResep.Location = New System.Drawing.Point(0, 0)
        Me.Panel_NoResep.Name = "Panel_NoResep"
        Me.Panel_NoResep.Size = New System.Drawing.Size(341, 60)
        Me.Panel_NoResep.TabIndex = 0
        '
        'Label_NoResep
        '
        Me.Label_NoResep.AutoSize = True
        Me.Label_NoResep.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_NoResep.Location = New System.Drawing.Point(20, 0)
        Me.Label_NoResep.Name = "Label_NoResep"
        Me.Label_NoResep.Size = New System.Drawing.Size(76, 19)
        Me.Label_NoResep.TabIndex = 2
        Me.Label_NoResep.Text = "No Resep"
        '
        'TextBox_NoResep
        '
        Me.TextBox_NoResep.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_NoResep.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_NoResep.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_NoResep.Location = New System.Drawing.Point(18, 30)
        Me.TextBox_NoResep.Name = "TextBox_NoResep"
        Me.TextBox_NoResep.Size = New System.Drawing.Size(307, 20)
        Me.TextBox_NoResep.TabIndex = 1
        '
        'Panel_KelolaResep_Cari
        '
        Me.Panel_KelolaResep_Cari.Controls.Add(Me.TextBox_KelolaResep_Cari)
        Me.Panel_KelolaResep_Cari.Controls.Add(Me.Label_KelolaResep_Cari)
        Me.Panel_KelolaResep_Cari.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_KelolaResep_Cari.Location = New System.Drawing.Point(0, 180)
        Me.Panel_KelolaResep_Cari.Name = "Panel_KelolaResep_Cari"
        Me.Panel_KelolaResep_Cari.Size = New System.Drawing.Size(349, 37)
        Me.Panel_KelolaResep_Cari.TabIndex = 6
        '
        'TextBox_KelolaResep_Cari
        '
        Me.TextBox_KelolaResep_Cari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_KelolaResep_Cari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_KelolaResep_Cari.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_KelolaResep_Cari.Location = New System.Drawing.Point(57, 5)
        Me.TextBox_KelolaResep_Cari.Name = "TextBox_KelolaResep_Cari"
        Me.TextBox_KelolaResep_Cari.Size = New System.Drawing.Size(276, 27)
        Me.TextBox_KelolaResep_Cari.TabIndex = 1
        '
        'Label_KelolaResep_Cari
        '
        Me.Label_KelolaResep_Cari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_KelolaResep_Cari.AutoSize = True
        Me.Label_KelolaResep_Cari.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_KelolaResep_Cari.Location = New System.Drawing.Point(14, 8)
        Me.Label_KelolaResep_Cari.Name = "Label_KelolaResep_Cari"
        Me.Label_KelolaResep_Cari.Size = New System.Drawing.Size(37, 19)
        Me.Label_KelolaResep_Cari.TabIndex = 2
        Me.Label_KelolaResep_Cari.Text = "Cari"
        '
        'Panel_Quantity
        '
        Me.Panel_Quantity.Controls.Add(Me.Label_Quantity)
        Me.Panel_Quantity.Controls.Add(Me.TextBox_Quantity)
        Me.Panel_Quantity.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Quantity.Location = New System.Drawing.Point(0, 120)
        Me.Panel_Quantity.Name = "Panel_Quantity"
        Me.Panel_Quantity.Size = New System.Drawing.Size(349, 60)
        Me.Panel_Quantity.TabIndex = 5
        '
        'Label_Quantity
        '
        Me.Label_Quantity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Quantity.AutoSize = True
        Me.Label_Quantity.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Quantity.Location = New System.Drawing.Point(18, 3)
        Me.Label_Quantity.Name = "Label_Quantity"
        Me.Label_Quantity.Size = New System.Drawing.Size(69, 19)
        Me.Label_Quantity.TabIndex = 2
        Me.Label_Quantity.Text = "Quantity"
        '
        'TextBox_Quantity
        '
        Me.TextBox_Quantity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Quantity.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Quantity.Location = New System.Drawing.Point(18, 30)
        Me.TextBox_Quantity.Name = "TextBox_Quantity"
        Me.TextBox_Quantity.Size = New System.Drawing.Size(310, 20)
        Me.TextBox_Quantity.TabIndex = 1
        '
        'Panel_NamaObat
        '
        Me.Panel_NamaObat.Controls.Add(Me.Label_NamaObat)
        Me.Panel_NamaObat.Controls.Add(Me.TextBox_NamaObat)
        Me.Panel_NamaObat.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_NamaObat.Location = New System.Drawing.Point(0, 60)
        Me.Panel_NamaObat.Name = "Panel_NamaObat"
        Me.Panel_NamaObat.Size = New System.Drawing.Size(349, 60)
        Me.Panel_NamaObat.TabIndex = 4
        '
        'Label_NamaObat
        '
        Me.Label_NamaObat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_NamaObat.AutoSize = True
        Me.Label_NamaObat.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_NamaObat.Location = New System.Drawing.Point(18, 0)
        Me.Label_NamaObat.Name = "Label_NamaObat"
        Me.Label_NamaObat.Size = New System.Drawing.Size(89, 19)
        Me.Label_NamaObat.TabIndex = 2
        Me.Label_NamaObat.Text = "Nama Obat"
        '
        'TextBox_NamaObat
        '
        Me.TextBox_NamaObat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_NamaObat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_NamaObat.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_NamaObat.Location = New System.Drawing.Point(18, 30)
        Me.TextBox_NamaObat.Name = "TextBox_NamaObat"
        Me.TextBox_NamaObat.Size = New System.Drawing.Size(310, 20)
        Me.TextBox_NamaObat.TabIndex = 1
        '
        'Panel_NamaDokter
        '
        Me.Panel_NamaDokter.Controls.Add(Me.Label_NamaDokter)
        Me.Panel_NamaDokter.Controls.Add(Me.TextBox_NamaDokter)
        Me.Panel_NamaDokter.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_NamaDokter.Location = New System.Drawing.Point(0, 0)
        Me.Panel_NamaDokter.Name = "Panel_NamaDokter"
        Me.Panel_NamaDokter.Size = New System.Drawing.Size(349, 60)
        Me.Panel_NamaDokter.TabIndex = 3
        '
        'Label_NamaDokter
        '
        Me.Label_NamaDokter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_NamaDokter.AutoSize = True
        Me.Label_NamaDokter.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_NamaDokter.Location = New System.Drawing.Point(18, 0)
        Me.Label_NamaDokter.Name = "Label_NamaDokter"
        Me.Label_NamaDokter.Size = New System.Drawing.Size(102, 19)
        Me.Label_NamaDokter.TabIndex = 2
        Me.Label_NamaDokter.Text = "Nama Dokter"
        '
        'TextBox_NamaDokter
        '
        Me.TextBox_NamaDokter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_NamaDokter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_NamaDokter.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_NamaDokter.Location = New System.Drawing.Point(18, 30)
        Me.TextBox_NamaDokter.Name = "TextBox_NamaDokter"
        Me.TextBox_NamaDokter.Size = New System.Drawing.Size(315, 20)
        Me.TextBox_NamaDokter.TabIndex = 1
        '
        'Label_KelolaObat
        '
        Me.Label_KelolaObat.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_KelolaObat.Font = New System.Drawing.Font("Tahoma", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_KelolaObat.Location = New System.Drawing.Point(5, 5)
        Me.Label_KelolaObat.Name = "Label_KelolaObat"
        Me.Label_KelolaObat.Size = New System.Drawing.Size(697, 35)
        Me.Label_KelolaObat.TabIndex = 6
        Me.Label_KelolaObat.Text = "Kelola Resep"
        '
        'DataGridView_KelolaResep
        '
        Me.DataGridView_KelolaResep.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_KelolaResep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_KelolaResep.Location = New System.Drawing.Point(23, 261)
        Me.DataGridView_KelolaResep.Name = "DataGridView_KelolaResep"
        Me.DataGridView_KelolaResep.Size = New System.Drawing.Size(667, 147)
        Me.DataGridView_KelolaResep.TabIndex = 7
        '
        'SplitContainer_Login
        '
        Me.SplitContainer_Login.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_Login.IsSplitterFixed = True
        Me.SplitContainer_Login.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer_Login.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer_Login.Name = "SplitContainer_Login"
        '
        'SplitContainer_Login.Panel1
        '
        Me.SplitContainer_Login.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.SplitContainer_Login.Panel1.Controls.Add(Me.Panel_Apoteker_Kiri)
        '
        'SplitContainer_Login.Panel2
        '
        Me.SplitContainer_Login.Panel2.Controls.Add(Me.Panel_Apoteker_Kanan)
        Me.SplitContainer_Login.Size = New System.Drawing.Size(984, 411)
        Me.SplitContainer_Login.SplitterDistance = 276
        Me.SplitContainer_Login.SplitterWidth = 1
        Me.SplitContainer_Login.TabIndex = 2
        '
        'Panel_Apoteker_Kiri
        '
        Me.Panel_Apoteker_Kiri.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel_Apoteker_Kiri.Controls.Add(Me.Label_Apoteker_KelolaResep)
        Me.Panel_Apoteker_Kiri.Controls.Add(Me.Label_Apoteker)
        Me.Panel_Apoteker_Kiri.Controls.Add(Me.Button_Apoteker_Logout)
        Me.Panel_Apoteker_Kiri.Controls.Add(Me.PictureBox_Apoteker_Logo)
        Me.Panel_Apoteker_Kiri.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Apoteker_Kiri.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Apoteker_Kiri.Name = "Panel_Apoteker_Kiri"
        Me.Panel_Apoteker_Kiri.Size = New System.Drawing.Size(276, 411)
        Me.Panel_Apoteker_Kiri.TabIndex = 0
        '
        'Label_Apoteker_KelolaResep
        '
        Me.Label_Apoteker_KelolaResep.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Apoteker_KelolaResep.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Apoteker_KelolaResep.ForeColor = System.Drawing.SystemColors.Control
        Me.Label_Apoteker_KelolaResep.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label_Apoteker_KelolaResep.Location = New System.Drawing.Point(0, 250)
        Me.Label_Apoteker_KelolaResep.Name = "Label_Apoteker_KelolaResep"
        Me.Label_Apoteker_KelolaResep.Size = New System.Drawing.Size(276, 88)
        Me.Label_Apoteker_KelolaResep.TabIndex = 3
        Me.Label_Apoteker_KelolaResep.Text = "KELOLA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RESEP"
        Me.Label_Apoteker_KelolaResep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_Apoteker
        '
        Me.Label_Apoteker.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Apoteker.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Apoteker.ForeColor = System.Drawing.SystemColors.Control
        Me.Label_Apoteker.Location = New System.Drawing.Point(0, 0)
        Me.Label_Apoteker.Name = "Label_Apoteker"
        Me.Label_Apoteker.Size = New System.Drawing.Size(276, 94)
        Me.Label_Apoteker.TabIndex = 2
        Me.Label_Apoteker.Text = "APOTEKER"
        Me.Label_Apoteker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_Apoteker_Logout
        '
        Me.Button_Apoteker_Logout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Apoteker_Logout.BackColor = System.Drawing.Color.Olive
        Me.Button_Apoteker_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Apoteker_Logout.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Apoteker_Logout.Location = New System.Drawing.Point(50, 341)
        Me.Button_Apoteker_Logout.Name = "Button_Apoteker_Logout"
        Me.Button_Apoteker_Logout.Size = New System.Drawing.Size(181, 28)
        Me.Button_Apoteker_Logout.TabIndex = 1
        Me.Button_Apoteker_Logout.Text = "Logout"
        Me.Button_Apoteker_Logout.UseVisualStyleBackColor = False
        '
        'PictureBox_Apoteker_Logo
        '
        Me.PictureBox_Apoteker_Logo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox_Apoteker_Logo.Image = Global.App_Apotek_V1.My.Resources.Resources.Ryo_Yamada
        Me.PictureBox_Apoteker_Logo.InitialImage = Nothing
        Me.PictureBox_Apoteker_Logo.Location = New System.Drawing.Point(63, 97)
        Me.PictureBox_Apoteker_Logo.Name = "PictureBox_Apoteker_Logo"
        Me.PictureBox_Apoteker_Logo.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox_Apoteker_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Apoteker_Logo.TabIndex = 0
        Me.PictureBox_Apoteker_Logo.TabStop = False
        '
        'Form_Apoteker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 411)
        Me.Controls.Add(Me.SplitContainer_Login)
        Me.Name = "Form_Apoteker"
        Me.Text = "From Kelola Resep | Apoteker"
        Me.Panel_Apoteker_Kanan.ResumeLayout(False)
        Me.Panel_Apoteker_Kanan.PerformLayout()
        Me.SplitContainer_KelolaResep.Panel1.ResumeLayout(False)
        Me.SplitContainer_KelolaResep.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_KelolaResep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_KelolaResep.ResumeLayout(False)
        Me.Panel_NamaPasien.ResumeLayout(False)
        Me.Panel_NamaPasien.PerformLayout()
        Me.Panel_TanggalResep.ResumeLayout(False)
        Me.Panel_TanggalResep.PerformLayout()
        Me.Panel_NoResep.ResumeLayout(False)
        Me.Panel_NoResep.PerformLayout()
        Me.Panel_KelolaResep_Cari.ResumeLayout(False)
        Me.Panel_KelolaResep_Cari.PerformLayout()
        Me.Panel_Quantity.ResumeLayout(False)
        Me.Panel_Quantity.PerformLayout()
        Me.Panel_NamaObat.ResumeLayout(False)
        Me.Panel_NamaObat.PerformLayout()
        Me.Panel_NamaDokter.ResumeLayout(False)
        Me.Panel_NamaDokter.PerformLayout()
        CType(Me.DataGridView_KelolaResep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Login.Panel1.ResumeLayout(False)
        Me.SplitContainer_Login.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_Login, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Login.ResumeLayout(False)
        Me.Panel_Apoteker_Kiri.ResumeLayout(False)
        CType(Me.PictureBox_Apoteker_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Apoteker_Kanan As Panel
    Friend WithEvents SplitContainer_Login As SplitContainer
    Friend WithEvents Panel_Apoteker_Kiri As Panel
    Friend WithEvents Button_Apoteker_Logout As Button
    Friend WithEvents PictureBox_Apoteker_Logo As PictureBox
    Friend WithEvents SplitContainer_KelolaResep As SplitContainer
    Friend WithEvents Panel_TanggalResep As Panel
    Friend WithEvents DateTimePicker_TanggalResep As DateTimePicker
    Friend WithEvents Label_TanggalResep As Label
    Friend WithEvents Panel_NamaPasien As Panel
    Friend WithEvents Label_NamaPasien As Label
    Friend WithEvents TextBox_NamaPasien As TextBox
    Friend WithEvents Panel_NoResep As Panel
    Friend WithEvents Label_NoResep As Label
    Friend WithEvents TextBox_NoResep As TextBox
    Friend WithEvents Button_KelolaResep_Hapus As Button
    Friend WithEvents Button_KelolaResep_Edit As Button
    Friend WithEvents Panel_KelolaResep_Cari As Panel
    Friend WithEvents TextBox_KelolaResep_Cari As TextBox
    Friend WithEvents Label_KelolaResep_Cari As Label
    Friend WithEvents Panel_Quantity As Panel
    Friend WithEvents Panel_NamaObat As Panel
    Friend WithEvents Label_NamaObat As Label
    Friend WithEvents TextBox_NamaObat As TextBox
    Friend WithEvents Panel_NamaDokter As Panel
    Friend WithEvents Label_NamaDokter As Label
    Friend WithEvents TextBox_NamaDokter As TextBox
    Friend WithEvents Label_KelolaObat As Label
    Friend WithEvents DataGridView_KelolaResep As DataGridView
    Friend WithEvents Label_Apoteker As Label
    Friend WithEvents Label_Apoteker_KelolaResep As Label
    Friend WithEvents Label_Quantity As Label
    Friend WithEvents TextBox_Quantity As TextBox
    Friend WithEvents Label_IdObat As Label
End Class
