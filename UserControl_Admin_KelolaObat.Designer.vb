<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControl_Admin_KelolaObat
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView_KelolaObat = New System.Windows.Forms.DataGridView()
        Me.Label_Jumlah = New System.Windows.Forms.Label()
        Me.Panel_Expired = New System.Windows.Forms.Panel()
        Me.DateTimePicker_ExpiredDate = New System.Windows.Forms.DateTimePicker()
        Me.Label_ExpiredDate = New System.Windows.Forms.Label()
        Me.Panel_Jumlah = New System.Windows.Forms.Panel()
        Me.TextBox_Jumlah = New System.Windows.Forms.TextBox()
        Me.TextBox_Harga = New System.Windows.Forms.TextBox()
        Me.Panel_NamaObat = New System.Windows.Forms.Panel()
        Me.Label_NamaObat = New System.Windows.Forms.Label()
        Me.TextBox_NamaObat = New System.Windows.Forms.TextBox()
        Me.Label_HargaPerUnit = New System.Windows.Forms.Label()
        Me.Panel_HargaPerUnit = New System.Windows.Forms.Panel()
        Me.Panel_KodeObat = New System.Windows.Forms.Panel()
        Me.Label_KodeObat = New System.Windows.Forms.Label()
        Me.TextBox_KodeObat = New System.Windows.Forms.TextBox()
        Me.Button_KelolaObat_Hapus = New System.Windows.Forms.Button()
        Me.Button_KelolaObat_Edit = New System.Windows.Forms.Button()
        Me.Panel_Kosong = New System.Windows.Forms.Panel()
        Me.Label_KelolaObat_Cari = New System.Windows.Forms.Label()
        Me.Button_KelolaObat_Tambah = New System.Windows.Forms.Button()
        Me.Panel_KelolaObat_Cari = New System.Windows.Forms.Panel()
        Me.TextBox_KelolaObat_Cari = New System.Windows.Forms.TextBox()
        Me.SplitContainer_Admin_KelolaObat = New System.Windows.Forms.SplitContainer()
        Me.Label_KelolaObat = New System.Windows.Forms.Label()
        CType(Me.DataGridView_KelolaObat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Expired.SuspendLayout()
        Me.Panel_Jumlah.SuspendLayout()
        Me.Panel_NamaObat.SuspendLayout()
        Me.Panel_HargaPerUnit.SuspendLayout()
        Me.Panel_KodeObat.SuspendLayout()
        Me.Panel_KelolaObat_Cari.SuspendLayout()
        CType(Me.SplitContainer_Admin_KelolaObat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Admin_KelolaObat.Panel1.SuspendLayout()
        Me.SplitContainer_Admin_KelolaObat.Panel2.SuspendLayout()
        Me.SplitContainer_Admin_KelolaObat.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView_KelolaObat
        '
        Me.DataGridView_KelolaObat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_KelolaObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_KelolaObat.Location = New System.Drawing.Point(18, 256)
        Me.DataGridView_KelolaObat.Name = "DataGridView_KelolaObat"
        Me.DataGridView_KelolaObat.Size = New System.Drawing.Size(687, 206)
        Me.DataGridView_KelolaObat.TabIndex = 4
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
        'Panel_Expired
        '
        Me.Panel_Expired.Controls.Add(Me.DateTimePicker_ExpiredDate)
        Me.Panel_Expired.Controls.Add(Me.Label_ExpiredDate)
        Me.Panel_Expired.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Expired.Location = New System.Drawing.Point(0, 120)
        Me.Panel_Expired.Name = "Panel_Expired"
        Me.Panel_Expired.Size = New System.Drawing.Size(357, 60)
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
        Me.DateTimePicker_ExpiredDate.Size = New System.Drawing.Size(323, 26)
        Me.DateTimePicker_ExpiredDate.TabIndex = 3
        Me.DateTimePicker_ExpiredDate.Value = New Date(2023, 11, 7, 7, 48, 35, 0)
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
        'Panel_Jumlah
        '
        Me.Panel_Jumlah.Controls.Add(Me.Label_Jumlah)
        Me.Panel_Jumlah.Controls.Add(Me.TextBox_Jumlah)
        Me.Panel_Jumlah.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Jumlah.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Jumlah.Name = "Panel_Jumlah"
        Me.Panel_Jumlah.Size = New System.Drawing.Size(357, 60)
        Me.Panel_Jumlah.TabIndex = 3
        '
        'TextBox_Jumlah
        '
        Me.TextBox_Jumlah.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Jumlah.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Jumlah.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Jumlah.Location = New System.Drawing.Point(18, 30)
        Me.TextBox_Jumlah.Name = "TextBox_Jumlah"
        Me.TextBox_Jumlah.Size = New System.Drawing.Size(323, 20)
        Me.TextBox_Jumlah.TabIndex = 1
        '
        'TextBox_Harga
        '
        Me.TextBox_Harga.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Harga.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Harga.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Harga.Location = New System.Drawing.Point(18, 30)
        Me.TextBox_Harga.Name = "TextBox_Harga"
        Me.TextBox_Harga.Size = New System.Drawing.Size(323, 20)
        Me.TextBox_Harga.TabIndex = 1
        '
        'Panel_NamaObat
        '
        Me.Panel_NamaObat.Controls.Add(Me.Label_NamaObat)
        Me.Panel_NamaObat.Controls.Add(Me.TextBox_NamaObat)
        Me.Panel_NamaObat.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_NamaObat.Location = New System.Drawing.Point(0, 60)
        Me.Panel_NamaObat.Name = "Panel_NamaObat"
        Me.Panel_NamaObat.Size = New System.Drawing.Size(357, 60)
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
        Me.TextBox_NamaObat.Size = New System.Drawing.Size(323, 20)
        Me.TextBox_NamaObat.TabIndex = 1
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
        'Panel_HargaPerUnit
        '
        Me.Panel_HargaPerUnit.Controls.Add(Me.Label_HargaPerUnit)
        Me.Panel_HargaPerUnit.Controls.Add(Me.TextBox_Harga)
        Me.Panel_HargaPerUnit.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_HargaPerUnit.Location = New System.Drawing.Point(0, 60)
        Me.Panel_HargaPerUnit.Name = "Panel_HargaPerUnit"
        Me.Panel_HargaPerUnit.Size = New System.Drawing.Size(357, 60)
        Me.Panel_HargaPerUnit.TabIndex = 4
        '
        'Panel_KodeObat
        '
        Me.Panel_KodeObat.Controls.Add(Me.Label_KodeObat)
        Me.Panel_KodeObat.Controls.Add(Me.TextBox_KodeObat)
        Me.Panel_KodeObat.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_KodeObat.Location = New System.Drawing.Point(0, 0)
        Me.Panel_KodeObat.Name = "Panel_KodeObat"
        Me.Panel_KodeObat.Size = New System.Drawing.Size(357, 60)
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
        Me.TextBox_KodeObat.Size = New System.Drawing.Size(323, 20)
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
        'Panel_Kosong
        '
        Me.Panel_Kosong.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Kosong.Location = New System.Drawing.Point(0, 120)
        Me.Panel_Kosong.Name = "Panel_Kosong"
        Me.Panel_Kosong.Size = New System.Drawing.Size(357, 60)
        Me.Panel_Kosong.TabIndex = 5
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
        Me.Panel_KelolaObat_Cari.Size = New System.Drawing.Size(357, 37)
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
        Me.TextBox_KelolaObat_Cari.Size = New System.Drawing.Size(284, 27)
        Me.TextBox_KelolaObat_Cari.TabIndex = 1
        '
        'SplitContainer_Admin_KelolaObat
        '
        Me.SplitContainer_Admin_KelolaObat.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer_Admin_KelolaObat.IsSplitterFixed = True
        Me.SplitContainer_Admin_KelolaObat.Location = New System.Drawing.Point(0, 38)
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
        Me.SplitContainer_Admin_KelolaObat.Size = New System.Drawing.Size(721, 217)
        Me.SplitContainer_Admin_KelolaObat.SplitterDistance = 357
        Me.SplitContainer_Admin_KelolaObat.SplitterWidth = 7
        Me.SplitContainer_Admin_KelolaObat.TabIndex = 2
        '
        'Label_KelolaObat
        '
        Me.Label_KelolaObat.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_KelolaObat.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_KelolaObat.Location = New System.Drawing.Point(0, 0)
        Me.Label_KelolaObat.Name = "Label_KelolaObat"
        Me.Label_KelolaObat.Size = New System.Drawing.Size(721, 38)
        Me.Label_KelolaObat.TabIndex = 3
        Me.Label_KelolaObat.Text = "Kelola Obat"
        Me.Label_KelolaObat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserControl_Admin_KelolaObat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView_KelolaObat)
        Me.Controls.Add(Me.SplitContainer_Admin_KelolaObat)
        Me.Controls.Add(Me.Label_KelolaObat)
        Me.Name = "UserControl_Admin_KelolaObat"
        Me.Size = New System.Drawing.Size(721, 465)
        CType(Me.DataGridView_KelolaObat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Expired.ResumeLayout(False)
        Me.Panel_Expired.PerformLayout()
        Me.Panel_Jumlah.ResumeLayout(False)
        Me.Panel_Jumlah.PerformLayout()
        Me.Panel_NamaObat.ResumeLayout(False)
        Me.Panel_NamaObat.PerformLayout()
        Me.Panel_HargaPerUnit.ResumeLayout(False)
        Me.Panel_HargaPerUnit.PerformLayout()
        Me.Panel_KodeObat.ResumeLayout(False)
        Me.Panel_KodeObat.PerformLayout()
        Me.Panel_KelolaObat_Cari.ResumeLayout(False)
        Me.Panel_KelolaObat_Cari.PerformLayout()
        Me.SplitContainer_Admin_KelolaObat.Panel1.ResumeLayout(False)
        Me.SplitContainer_Admin_KelolaObat.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_Admin_KelolaObat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Admin_KelolaObat.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView_KelolaObat As DataGridView
    Friend WithEvents Label_Jumlah As Label
    Friend WithEvents Panel_Expired As Panel
    Friend WithEvents Label_ExpiredDate As Label
    Friend WithEvents Panel_Jumlah As Panel
    Friend WithEvents TextBox_Jumlah As TextBox
    Friend WithEvents TextBox_Harga As TextBox
    Friend WithEvents Panel_NamaObat As Panel
    Friend WithEvents Label_NamaObat As Label
    Friend WithEvents TextBox_NamaObat As TextBox
    Friend WithEvents Label_HargaPerUnit As Label
    Friend WithEvents Panel_HargaPerUnit As Panel
    Friend WithEvents Panel_KodeObat As Panel
    Friend WithEvents Label_KodeObat As Label
    Friend WithEvents Button_KelolaObat_Hapus As Button
    Friend WithEvents Button_KelolaObat_Edit As Button
    Friend WithEvents Panel_Kosong As Panel
    Friend WithEvents Label_KelolaObat_Cari As Label
    Friend WithEvents Button_KelolaObat_Tambah As Button
    Friend WithEvents Panel_KelolaObat_Cari As Panel
    Friend WithEvents TextBox_KelolaObat_Cari As TextBox
    Friend WithEvents SplitContainer_Admin_KelolaObat As SplitContainer
    Friend WithEvents Label_KelolaObat As Label
    Friend WithEvents TextBox_KodeObat As TextBox
    Friend WithEvents DateTimePicker_ExpiredDate As DateTimePicker
End Class
