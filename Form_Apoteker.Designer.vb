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
        Me.SplitContainer_Admin_KelolaObat = New System.Windows.Forms.SplitContainer()
        Me.Panel_Expired = New System.Windows.Forms.Panel()
        Me.DateTimePicker_ExpiredDate = New System.Windows.Forms.DateTimePicker()
        Me.Label_ExpiredDate = New System.Windows.Forms.Label()
        Me.Panel_NamaObat = New System.Windows.Forms.Panel()
        Me.Label_NamaObat = New System.Windows.Forms.Label()
        Me.TextBox_NamaObat = New System.Windows.Forms.TextBox()
        Me.Panel_KodeObat = New System.Windows.Forms.Panel()
        Me.Label_KodeObat = New System.Windows.Forms.Label()
        Me.TextBox_KodeObat = New System.Windows.Forms.TextBox()
        Me.Button_KelolaObat_Hapus = New System.Windows.Forms.Button()
        Me.Button_KelolaObat_Edit = New System.Windows.Forms.Button()
        Me.Button_KelolaObat_Tambah = New System.Windows.Forms.Button()
        Me.Panel_KelolaObat_Cari = New System.Windows.Forms.Panel()
        Me.TextBox_KelolaObat_Cari = New System.Windows.Forms.TextBox()
        Me.Label_KelolaObat_Cari = New System.Windows.Forms.Label()
        Me.Panel_Kosong = New System.Windows.Forms.Panel()
        Me.Panel_HargaPerUnit = New System.Windows.Forms.Panel()
        Me.Label_HargaPerUnit = New System.Windows.Forms.Label()
        Me.TextBox_Username = New System.Windows.Forms.TextBox()
        Me.Panel_Jumlah = New System.Windows.Forms.Panel()
        Me.Label_Jumlah = New System.Windows.Forms.Label()
        Me.TextBox_Alamat = New System.Windows.Forms.TextBox()
        Me.Label_KelolaObat = New System.Windows.Forms.Label()
        Me.DataGridView_KelolaObat = New System.Windows.Forms.DataGridView()
        Me.SplitContainer_Login = New System.Windows.Forms.SplitContainer()
        Me.Panel_Apoteker_Kiri = New System.Windows.Forms.Panel()
        Me.Label_Apoteker_KelolaResep = New System.Windows.Forms.Label()
        Me.Label_Apoteker = New System.Windows.Forms.Label()
        Me.Button_Apoteker_Logout = New System.Windows.Forms.Button()
        Me.PictureBox_Apoteker_Logo = New System.Windows.Forms.PictureBox()
        Me.Panel_Apoteker_Kanan.SuspendLayout()
        CType(Me.SplitContainer_Admin_KelolaObat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Admin_KelolaObat.Panel1.SuspendLayout()
        Me.SplitContainer_Admin_KelolaObat.Panel2.SuspendLayout()
        Me.SplitContainer_Admin_KelolaObat.SuspendLayout()
        Me.Panel_Expired.SuspendLayout()
        Me.Panel_NamaObat.SuspendLayout()
        Me.Panel_KodeObat.SuspendLayout()
        Me.Panel_KelolaObat_Cari.SuspendLayout()
        Me.Panel_HargaPerUnit.SuspendLayout()
        Me.Panel_Jumlah.SuspendLayout()
        CType(Me.DataGridView_KelolaObat, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel_Apoteker_Kanan.Controls.Add(Me.SplitContainer_Admin_KelolaObat)
        Me.Panel_Apoteker_Kanan.Controls.Add(Me.Label_KelolaObat)
        Me.Panel_Apoteker_Kanan.Controls.Add(Me.DataGridView_KelolaObat)
        Me.Panel_Apoteker_Kanan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Apoteker_Kanan.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Apoteker_Kanan.Name = "Panel_Apoteker_Kanan"
        Me.Panel_Apoteker_Kanan.Size = New System.Drawing.Size(707, 411)
        Me.Panel_Apoteker_Kanan.TabIndex = 0
        '
        'SplitContainer_Admin_KelolaObat
        '
        Me.SplitContainer_Admin_KelolaObat.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer_Admin_KelolaObat.IsSplitterFixed = True
        Me.SplitContainer_Admin_KelolaObat.Location = New System.Drawing.Point(0, 35)
        Me.SplitContainer_Admin_KelolaObat.Name = "SplitContainer_Admin_KelolaObat"
        '
        'SplitContainer_Admin_KelolaObat.Panel1
        '
        Me.SplitContainer_Admin_KelolaObat.Panel1.Controls.Add(Me.Panel_Expired)
        Me.SplitContainer_Admin_KelolaObat.Panel1.Controls.Add(Me.Panel_NamaObat)
        Me.SplitContainer_Admin_KelolaObat.Panel1.Controls.Add(Me.Panel_KodeObat)
        Me.SplitContainer_Admin_KelolaObat.Panel1.Controls.Add(Me.Button_KelolaObat_Hapus)
        Me.SplitContainer_Admin_KelolaObat.Panel1.Controls.Add(Me.Button_KelolaObat_Edit)
        Me.SplitContainer_Admin_KelolaObat.Panel1.Controls.Add(Me.Button_KelolaObat_Tambah)
        '
        'SplitContainer_Admin_KelolaObat.Panel2
        '
        Me.SplitContainer_Admin_KelolaObat.Panel2.Controls.Add(Me.Panel_KelolaObat_Cari)
        Me.SplitContainer_Admin_KelolaObat.Panel2.Controls.Add(Me.Panel_Kosong)
        Me.SplitContainer_Admin_KelolaObat.Panel2.Controls.Add(Me.Panel_HargaPerUnit)
        Me.SplitContainer_Admin_KelolaObat.Panel2.Controls.Add(Me.Panel_Jumlah)
        Me.SplitContainer_Admin_KelolaObat.Size = New System.Drawing.Size(707, 217)
        Me.SplitContainer_Admin_KelolaObat.SplitterDistance = 349
        Me.SplitContainer_Admin_KelolaObat.SplitterWidth = 7
        Me.SplitContainer_Admin_KelolaObat.TabIndex = 5
        '
        'Panel_Expired
        '
        Me.Panel_Expired.Controls.Add(Me.DateTimePicker_ExpiredDate)
        Me.Panel_Expired.Controls.Add(Me.Label_ExpiredDate)
        Me.Panel_Expired.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Expired.Location = New System.Drawing.Point(0, 120)
        Me.Panel_Expired.Name = "Panel_Expired"
        Me.Panel_Expired.Size = New System.Drawing.Size(349, 60)
        Me.Panel_Expired.TabIndex = 2
        '
        'DateTimePicker_ExpiredDate
        '
        Me.DateTimePicker_ExpiredDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker_ExpiredDate.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker_ExpiredDate.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_ExpiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_ExpiredDate.Location = New System.Drawing.Point(18, 30)
        Me.DateTimePicker_ExpiredDate.Name = "DateTimePicker_ExpiredDate"
        Me.DateTimePicker_ExpiredDate.Size = New System.Drawing.Size(315, 26)
        Me.DateTimePicker_ExpiredDate.TabIndex = 3
        Me.DateTimePicker_ExpiredDate.Value = New Date(2023, 11, 14, 0, 0, 0, 0)
        '
        'Label_ExpiredDate
        '
        Me.Label_ExpiredDate.AutoSize = True
        Me.Label_ExpiredDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ExpiredDate.Location = New System.Drawing.Point(20, 0)
        Me.Label_ExpiredDate.Name = "Label_ExpiredDate"
        Me.Label_ExpiredDate.Size = New System.Drawing.Size(99, 19)
        Me.Label_ExpiredDate.TabIndex = 2
        Me.Label_ExpiredDate.Text = "Expired Date"
        '
        'Panel_NamaObat
        '
        Me.Panel_NamaObat.Controls.Add(Me.Label_NamaObat)
        Me.Panel_NamaObat.Controls.Add(Me.TextBox_NamaObat)
        Me.Panel_NamaObat.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_NamaObat.Location = New System.Drawing.Point(0, 60)
        Me.Panel_NamaObat.Name = "Panel_NamaObat"
        Me.Panel_NamaObat.Size = New System.Drawing.Size(349, 60)
        Me.Panel_NamaObat.TabIndex = 1
        '
        'Label_NamaObat
        '
        Me.Label_NamaObat.AutoSize = True
        Me.Label_NamaObat.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_NamaObat.Location = New System.Drawing.Point(20, 0)
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
        Me.TextBox_NamaObat.Size = New System.Drawing.Size(315, 20)
        Me.TextBox_NamaObat.TabIndex = 1
        '
        'Panel_KodeObat
        '
        Me.Panel_KodeObat.Controls.Add(Me.Label_KodeObat)
        Me.Panel_KodeObat.Controls.Add(Me.TextBox_KodeObat)
        Me.Panel_KodeObat.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_KodeObat.Location = New System.Drawing.Point(0, 0)
        Me.Panel_KodeObat.Name = "Panel_KodeObat"
        Me.Panel_KodeObat.Size = New System.Drawing.Size(349, 60)
        Me.Panel_KodeObat.TabIndex = 0
        '
        'Label_KodeObat
        '
        Me.Label_KodeObat.AutoSize = True
        Me.Label_KodeObat.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_KodeObat.Location = New System.Drawing.Point(20, 0)
        Me.Label_KodeObat.Name = "Label_KodeObat"
        Me.Label_KodeObat.Size = New System.Drawing.Size(83, 19)
        Me.Label_KodeObat.TabIndex = 2
        Me.Label_KodeObat.Text = "Kode Obat"
        '
        'TextBox_KodeObat
        '
        Me.TextBox_KodeObat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_KodeObat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_KodeObat.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_KodeObat.Location = New System.Drawing.Point(18, 30)
        Me.TextBox_KodeObat.Name = "TextBox_KodeObat"
        Me.TextBox_KodeObat.Size = New System.Drawing.Size(315, 20)
        Me.TextBox_KodeObat.TabIndex = 1
        '
        'Button_KelolaObat_Hapus
        '
        Me.Button_KelolaObat_Hapus.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_KelolaObat_Hapus.Location = New System.Drawing.Point(188, 182)
        Me.Button_KelolaObat_Hapus.Name = "Button_KelolaObat_Hapus"
        Me.Button_KelolaObat_Hapus.Size = New System.Drawing.Size(79, 30)
        Me.Button_KelolaObat_Hapus.TabIndex = 9
        Me.Button_KelolaObat_Hapus.Text = "Hapus"
        Me.Button_KelolaObat_Hapus.UseVisualStyleBackColor = True
        '
        'Button_KelolaObat_Edit
        '
        Me.Button_KelolaObat_Edit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_KelolaObat_Edit.Location = New System.Drawing.Point(103, 182)
        Me.Button_KelolaObat_Edit.Name = "Button_KelolaObat_Edit"
        Me.Button_KelolaObat_Edit.Size = New System.Drawing.Size(79, 30)
        Me.Button_KelolaObat_Edit.TabIndex = 8
        Me.Button_KelolaObat_Edit.Text = "Edit"
        Me.Button_KelolaObat_Edit.UseVisualStyleBackColor = True
        '
        'Button_KelolaObat_Tambah
        '
        Me.Button_KelolaObat_Tambah.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_KelolaObat_Tambah.Location = New System.Drawing.Point(18, 182)
        Me.Button_KelolaObat_Tambah.Name = "Button_KelolaObat_Tambah"
        Me.Button_KelolaObat_Tambah.Size = New System.Drawing.Size(79, 30)
        Me.Button_KelolaObat_Tambah.TabIndex = 7
        Me.Button_KelolaObat_Tambah.Text = "Tambah"
        Me.Button_KelolaObat_Tambah.UseVisualStyleBackColor = True
        '
        'Panel_KelolaObat_Cari
        '
        Me.Panel_KelolaObat_Cari.Controls.Add(Me.TextBox_KelolaObat_Cari)
        Me.Panel_KelolaObat_Cari.Controls.Add(Me.Label_KelolaObat_Cari)
        Me.Panel_KelolaObat_Cari.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_KelolaObat_Cari.Location = New System.Drawing.Point(0, 180)
        Me.Panel_KelolaObat_Cari.Name = "Panel_KelolaObat_Cari"
        Me.Panel_KelolaObat_Cari.Size = New System.Drawing.Size(351, 37)
        Me.Panel_KelolaObat_Cari.TabIndex = 6
        '
        'TextBox_KelolaObat_Cari
        '
        Me.TextBox_KelolaObat_Cari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_KelolaObat_Cari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_KelolaObat_Cari.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_KelolaObat_Cari.Location = New System.Drawing.Point(57, 5)
        Me.TextBox_KelolaObat_Cari.Name = "TextBox_KelolaObat_Cari"
        Me.TextBox_KelolaObat_Cari.Size = New System.Drawing.Size(278, 27)
        Me.TextBox_KelolaObat_Cari.TabIndex = 1
        '
        'Label_KelolaObat_Cari
        '
        Me.Label_KelolaObat_Cari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_KelolaObat_Cari.AutoSize = True
        Me.Label_KelolaObat_Cari.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_KelolaObat_Cari.Location = New System.Drawing.Point(14, 8)
        Me.Label_KelolaObat_Cari.Name = "Label_KelolaObat_Cari"
        Me.Label_KelolaObat_Cari.Size = New System.Drawing.Size(37, 19)
        Me.Label_KelolaObat_Cari.TabIndex = 2
        Me.Label_KelolaObat_Cari.Text = "Cari"
        '
        'Panel_Kosong
        '
        Me.Panel_Kosong.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Kosong.Location = New System.Drawing.Point(0, 120)
        Me.Panel_Kosong.Name = "Panel_Kosong"
        Me.Panel_Kosong.Size = New System.Drawing.Size(351, 60)
        Me.Panel_Kosong.TabIndex = 5
        '
        'Panel_HargaPerUnit
        '
        Me.Panel_HargaPerUnit.Controls.Add(Me.Label_HargaPerUnit)
        Me.Panel_HargaPerUnit.Controls.Add(Me.TextBox_Username)
        Me.Panel_HargaPerUnit.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_HargaPerUnit.Location = New System.Drawing.Point(0, 60)
        Me.Panel_HargaPerUnit.Name = "Panel_HargaPerUnit"
        Me.Panel_HargaPerUnit.Size = New System.Drawing.Size(351, 60)
        Me.Panel_HargaPerUnit.TabIndex = 4
        '
        'Label_HargaPerUnit
        '
        Me.Label_HargaPerUnit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_HargaPerUnit.AutoSize = True
        Me.Label_HargaPerUnit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_HargaPerUnit.Location = New System.Drawing.Point(18, 3)
        Me.Label_HargaPerUnit.Name = "Label_HargaPerUnit"
        Me.Label_HargaPerUnit.Size = New System.Drawing.Size(113, 19)
        Me.Label_HargaPerUnit.TabIndex = 2
        Me.Label_HargaPerUnit.Text = "Harga Per Unit"
        '
        'TextBox_Username
        '
        Me.TextBox_Username.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Username.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Username.Location = New System.Drawing.Point(18, 30)
        Me.TextBox_Username.Name = "TextBox_Username"
        Me.TextBox_Username.Size = New System.Drawing.Size(317, 20)
        Me.TextBox_Username.TabIndex = 1
        '
        'Panel_Jumlah
        '
        Me.Panel_Jumlah.Controls.Add(Me.Label_Jumlah)
        Me.Panel_Jumlah.Controls.Add(Me.TextBox_Alamat)
        Me.Panel_Jumlah.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Jumlah.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Jumlah.Name = "Panel_Jumlah"
        Me.Panel_Jumlah.Size = New System.Drawing.Size(351, 60)
        Me.Panel_Jumlah.TabIndex = 3
        '
        'Label_Jumlah
        '
        Me.Label_Jumlah.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Jumlah.AutoSize = True
        Me.Label_Jumlah.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Jumlah.Location = New System.Drawing.Point(18, 0)
        Me.Label_Jumlah.Name = "Label_Jumlah"
        Me.Label_Jumlah.Size = New System.Drawing.Size(60, 19)
        Me.Label_Jumlah.TabIndex = 2
        Me.Label_Jumlah.Text = "Jumlah"
        '
        'TextBox_Alamat
        '
        Me.TextBox_Alamat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Alamat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Alamat.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Alamat.Location = New System.Drawing.Point(18, 30)
        Me.TextBox_Alamat.Name = "TextBox_Alamat"
        Me.TextBox_Alamat.Size = New System.Drawing.Size(317, 20)
        Me.TextBox_Alamat.TabIndex = 1
        '
        'Label_KelolaObat
        '
        Me.Label_KelolaObat.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_KelolaObat.Font = New System.Drawing.Font("Tahoma", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_KelolaObat.Location = New System.Drawing.Point(0, 0)
        Me.Label_KelolaObat.Name = "Label_KelolaObat"
        Me.Label_KelolaObat.Size = New System.Drawing.Size(707, 35)
        Me.Label_KelolaObat.TabIndex = 6
        Me.Label_KelolaObat.Text = "Kelola Resep"
        '
        'DataGridView_KelolaObat
        '
        Me.DataGridView_KelolaObat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_KelolaObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_KelolaObat.Location = New System.Drawing.Point(18, 256)
        Me.DataGridView_KelolaObat.Name = "DataGridView_KelolaObat"
        Me.DataGridView_KelolaObat.Size = New System.Drawing.Size(677, 149)
        Me.DataGridView_KelolaObat.TabIndex = 7
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
        Me.Label_Apoteker_KelolaResep.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Apoteker_KelolaResep.ForeColor = System.Drawing.SystemColors.Control
        Me.Label_Apoteker_KelolaResep.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label_Apoteker_KelolaResep.Location = New System.Drawing.Point(0, 250)
        Me.Label_Apoteker_KelolaResep.Name = "Label_Apoteker_KelolaResep"
        Me.Label_Apoteker_KelolaResep.Size = New System.Drawing.Size(220, 88)
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
        Me.SplitContainer_Admin_KelolaObat.Panel1.ResumeLayout(False)
        Me.SplitContainer_Admin_KelolaObat.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_Admin_KelolaObat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Admin_KelolaObat.ResumeLayout(False)
        Me.Panel_Expired.ResumeLayout(False)
        Me.Panel_Expired.PerformLayout()
        Me.Panel_NamaObat.ResumeLayout(False)
        Me.Panel_NamaObat.PerformLayout()
        Me.Panel_KodeObat.ResumeLayout(False)
        Me.Panel_KodeObat.PerformLayout()
        Me.Panel_KelolaObat_Cari.ResumeLayout(False)
        Me.Panel_KelolaObat_Cari.PerformLayout()
        Me.Panel_HargaPerUnit.ResumeLayout(False)
        Me.Panel_HargaPerUnit.PerformLayout()
        Me.Panel_Jumlah.ResumeLayout(False)
        Me.Panel_Jumlah.PerformLayout()
        CType(Me.DataGridView_KelolaObat, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SplitContainer_Admin_KelolaObat As SplitContainer
    Friend WithEvents Panel_Expired As Panel
    Friend WithEvents DateTimePicker_ExpiredDate As DateTimePicker
    Friend WithEvents Label_ExpiredDate As Label
    Friend WithEvents Panel_NamaObat As Panel
    Friend WithEvents Label_NamaObat As Label
    Friend WithEvents TextBox_NamaObat As TextBox
    Friend WithEvents Panel_KodeObat As Panel
    Friend WithEvents Label_KodeObat As Label
    Friend WithEvents TextBox_KodeObat As TextBox
    Friend WithEvents Button_KelolaObat_Hapus As Button
    Friend WithEvents Button_KelolaObat_Edit As Button
    Friend WithEvents Button_KelolaObat_Tambah As Button
    Friend WithEvents Panel_KelolaObat_Cari As Panel
    Friend WithEvents TextBox_KelolaObat_Cari As TextBox
    Friend WithEvents Label_KelolaObat_Cari As Label
    Friend WithEvents Panel_Kosong As Panel
    Friend WithEvents Panel_HargaPerUnit As Panel
    Friend WithEvents Label_HargaPerUnit As Label
    Friend WithEvents TextBox_Username As TextBox
    Friend WithEvents Panel_Jumlah As Panel
    Friend WithEvents Label_Jumlah As Label
    Friend WithEvents TextBox_Alamat As TextBox
    Friend WithEvents Label_KelolaObat As Label
    Friend WithEvents DataGridView_KelolaObat As DataGridView
    Friend WithEvents Label_Apoteker As Label
    Friend WithEvents Label_Apoteker_KelolaResep As Label
End Class
