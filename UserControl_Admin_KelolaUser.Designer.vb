<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Admin_KelolaUser
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label_KelolaUser = New System.Windows.Forms.Label()
        Me.SplitContainer_Admin_KelolaUser = New System.Windows.Forms.SplitContainer()
        Me.Panel_Telepon = New System.Windows.Forms.Panel()
        Me.Label_Telepon = New System.Windows.Forms.Label()
        Me.TextBox_Telepon = New System.Windows.Forms.TextBox()
        Me.Panel_Nama = New System.Windows.Forms.Panel()
        Me.Label_Nama = New System.Windows.Forms.Label()
        Me.TextBox_Nama = New System.Windows.Forms.TextBox()
        Me.Panel_TipeUser = New System.Windows.Forms.Panel()
        Me.ComboBox_TipeUser = New System.Windows.Forms.ComboBox()
        Me.Label_Tipe_User = New System.Windows.Forms.Label()
        Me.Button_KelolaUser_Hapus = New System.Windows.Forms.Button()
        Me.Button_KelolaUser_Edit = New System.Windows.Forms.Button()
        Me.Button_KelolaUser_Tambah = New System.Windows.Forms.Button()
        Me.Panel_KelolaUser_Cari = New System.Windows.Forms.Panel()
        Me.TextBox_KelolaUser_Cari = New System.Windows.Forms.TextBox()
        Me.Label_KelolaUser_Cari = New System.Windows.Forms.Label()
        Me.Panel_Password = New System.Windows.Forms.Panel()
        Me.Label_Password = New System.Windows.Forms.Label()
        Me.TextBox_Password = New System.Windows.Forms.TextBox()
        Me.Panel_Username = New System.Windows.Forms.Panel()
        Me.Label_Username = New System.Windows.Forms.Label()
        Me.TextBox_Username = New System.Windows.Forms.TextBox()
        Me.Panel_Alamat = New System.Windows.Forms.Panel()
        Me.Label_Alamat = New System.Windows.Forms.Label()
        Me.TextBox_Alamat = New System.Windows.Forms.TextBox()
        Me.DataGridView_KelolaUser = New System.Windows.Forms.DataGridView()
        CType(Me.SplitContainer_Admin_KelolaUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Admin_KelolaUser.Panel1.SuspendLayout()
        Me.SplitContainer_Admin_KelolaUser.Panel2.SuspendLayout()
        Me.SplitContainer_Admin_KelolaUser.SuspendLayout()
        Me.Panel_Telepon.SuspendLayout()
        Me.Panel_Nama.SuspendLayout()
        Me.Panel_TipeUser.SuspendLayout()
        Me.Panel_KelolaUser_Cari.SuspendLayout()
        Me.Panel_Password.SuspendLayout()
        Me.Panel_Username.SuspendLayout()
        Me.Panel_Alamat.SuspendLayout()
        CType(Me.DataGridView_KelolaUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_KelolaUser
        '
        Me.Label_KelolaUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_KelolaUser.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_KelolaUser.Location = New System.Drawing.Point(0, 0)
        Me.Label_KelolaUser.Name = "Label_KelolaUser"
        Me.Label_KelolaUser.Size = New System.Drawing.Size(720, 38)
        Me.Label_KelolaUser.TabIndex = 0
        Me.Label_KelolaUser.Text = "Kelola User"
        Me.Label_KelolaUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer_Admin_KelolaUser
        '
        Me.SplitContainer_Admin_KelolaUser.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer_Admin_KelolaUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer_Admin_KelolaUser.IsSplitterFixed = True
        Me.SplitContainer_Admin_KelolaUser.Location = New System.Drawing.Point(0, 38)
        Me.SplitContainer_Admin_KelolaUser.Name = "SplitContainer_Admin_KelolaUser"
        '
        'SplitContainer_Admin_KelolaUser.Panel1
        '
        Me.SplitContainer_Admin_KelolaUser.Panel1.Controls.Add(Me.Panel_Telepon)
        Me.SplitContainer_Admin_KelolaUser.Panel1.Controls.Add(Me.Panel_Nama)
        Me.SplitContainer_Admin_KelolaUser.Panel1.Controls.Add(Me.Panel_TipeUser)
        Me.SplitContainer_Admin_KelolaUser.Panel1.Controls.Add(Me.Button_KelolaUser_Hapus)
        Me.SplitContainer_Admin_KelolaUser.Panel1.Controls.Add(Me.Button_KelolaUser_Edit)
        Me.SplitContainer_Admin_KelolaUser.Panel1.Controls.Add(Me.Button_KelolaUser_Tambah)
        '
        'SplitContainer_Admin_KelolaUser.Panel2
        '
        Me.SplitContainer_Admin_KelolaUser.Panel2.Controls.Add(Me.Panel_KelolaUser_Cari)
        Me.SplitContainer_Admin_KelolaUser.Panel2.Controls.Add(Me.Panel_Password)
        Me.SplitContainer_Admin_KelolaUser.Panel2.Controls.Add(Me.Panel_Username)
        Me.SplitContainer_Admin_KelolaUser.Panel2.Controls.Add(Me.Panel_Alamat)
        Me.SplitContainer_Admin_KelolaUser.Size = New System.Drawing.Size(720, 217)
        Me.SplitContainer_Admin_KelolaUser.SplitterDistance = 355
        Me.SplitContainer_Admin_KelolaUser.SplitterWidth = 7
        Me.SplitContainer_Admin_KelolaUser.TabIndex = 0
        '
        'Panel_Telepon
        '
        Me.Panel_Telepon.Controls.Add(Me.Label_Telepon)
        Me.Panel_Telepon.Controls.Add(Me.TextBox_Telepon)
        Me.Panel_Telepon.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Telepon.Location = New System.Drawing.Point(0, 120)
        Me.Panel_Telepon.Name = "Panel_Telepon"
        Me.Panel_Telepon.Size = New System.Drawing.Size(355, 60)
        Me.Panel_Telepon.TabIndex = 2
        '
        'Label_Telepon
        '
        Me.Label_Telepon.AutoSize = True
        Me.Label_Telepon.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Telepon.Location = New System.Drawing.Point(20, 0)
        Me.Label_Telepon.Name = "Label_Telepon"
        Me.Label_Telepon.Size = New System.Drawing.Size(66, 19)
        Me.Label_Telepon.TabIndex = 2
        Me.Label_Telepon.Text = "Telepon"
        '
        'TextBox_Telepon
        '
        Me.TextBox_Telepon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Telepon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Telepon.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Telepon.Location = New System.Drawing.Point(18, 30)
        Me.TextBox_Telepon.Name = "TextBox_Telepon"
        Me.TextBox_Telepon.Size = New System.Drawing.Size(321, 20)
        Me.TextBox_Telepon.TabIndex = 1
        '
        'Panel_Nama
        '
        Me.Panel_Nama.Controls.Add(Me.Label_Nama)
        Me.Panel_Nama.Controls.Add(Me.TextBox_Nama)
        Me.Panel_Nama.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Nama.Location = New System.Drawing.Point(0, 60)
        Me.Panel_Nama.Name = "Panel_Nama"
        Me.Panel_Nama.Size = New System.Drawing.Size(355, 60)
        Me.Panel_Nama.TabIndex = 1
        '
        'Label_Nama
        '
        Me.Label_Nama.AutoSize = True
        Me.Label_Nama.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Nama.Location = New System.Drawing.Point(20, 0)
        Me.Label_Nama.Name = "Label_Nama"
        Me.Label_Nama.Size = New System.Drawing.Size(50, 19)
        Me.Label_Nama.TabIndex = 2
        Me.Label_Nama.Text = "Nama"
        '
        'TextBox_Nama
        '
        Me.TextBox_Nama.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Nama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Nama.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Nama.Location = New System.Drawing.Point(18, 30)
        Me.TextBox_Nama.Name = "TextBox_Nama"
        Me.TextBox_Nama.Size = New System.Drawing.Size(322, 20)
        Me.TextBox_Nama.TabIndex = 1
        '
        'Panel_TipeUser
        '
        Me.Panel_TipeUser.Controls.Add(Me.ComboBox_TipeUser)
        Me.Panel_TipeUser.Controls.Add(Me.Label_Tipe_User)
        Me.Panel_TipeUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_TipeUser.Location = New System.Drawing.Point(0, 0)
        Me.Panel_TipeUser.Name = "Panel_TipeUser"
        Me.Panel_TipeUser.Size = New System.Drawing.Size(355, 60)
        Me.Panel_TipeUser.TabIndex = 0
        '
        'ComboBox_TipeUser
        '
        Me.ComboBox_TipeUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_TipeUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_TipeUser.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_TipeUser.FormattingEnabled = True
        Me.ComboBox_TipeUser.Items.AddRange(New Object() {"ADMIN", "APOTEKER", "KASIR"})
        Me.ComboBox_TipeUser.Location = New System.Drawing.Point(18, 25)
        Me.ComboBox_TipeUser.Name = "ComboBox_TipeUser"
        Me.ComboBox_TipeUser.Size = New System.Drawing.Size(322, 27)
        Me.ComboBox_TipeUser.TabIndex = 3
        '
        'Label_Tipe_User
        '
        Me.Label_Tipe_User.AutoSize = True
        Me.Label_Tipe_User.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Tipe_User.Location = New System.Drawing.Point(20, 0)
        Me.Label_Tipe_User.Name = "Label_Tipe_User"
        Me.Label_Tipe_User.Size = New System.Drawing.Size(77, 19)
        Me.Label_Tipe_User.TabIndex = 2
        Me.Label_Tipe_User.Text = "Tipe User"
        '
        'Button_KelolaUser_Hapus
        '
        Me.Button_KelolaUser_Hapus.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_KelolaUser_Hapus.Location = New System.Drawing.Point(188, 182)
        Me.Button_KelolaUser_Hapus.Name = "Button_KelolaUser_Hapus"
        Me.Button_KelolaUser_Hapus.Size = New System.Drawing.Size(79, 30)
        Me.Button_KelolaUser_Hapus.TabIndex = 9
        Me.Button_KelolaUser_Hapus.Text = "Hapus"
        Me.Button_KelolaUser_Hapus.UseVisualStyleBackColor = True
        '
        'Button_KelolaUser_Edit
        '
        Me.Button_KelolaUser_Edit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_KelolaUser_Edit.Location = New System.Drawing.Point(103, 182)
        Me.Button_KelolaUser_Edit.Name = "Button_KelolaUser_Edit"
        Me.Button_KelolaUser_Edit.Size = New System.Drawing.Size(79, 30)
        Me.Button_KelolaUser_Edit.TabIndex = 8
        Me.Button_KelolaUser_Edit.Text = "Edit"
        Me.Button_KelolaUser_Edit.UseVisualStyleBackColor = True
        '
        'Button_KelolaUser_Tambah
        '
        Me.Button_KelolaUser_Tambah.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_KelolaUser_Tambah.Location = New System.Drawing.Point(18, 182)
        Me.Button_KelolaUser_Tambah.Name = "Button_KelolaUser_Tambah"
        Me.Button_KelolaUser_Tambah.Size = New System.Drawing.Size(79, 30)
        Me.Button_KelolaUser_Tambah.TabIndex = 7
        Me.Button_KelolaUser_Tambah.Text = "Tambah"
        Me.Button_KelolaUser_Tambah.UseVisualStyleBackColor = True
        '
        'Panel_KelolaUser_Cari
        '
        Me.Panel_KelolaUser_Cari.Controls.Add(Me.TextBox_KelolaUser_Cari)
        Me.Panel_KelolaUser_Cari.Controls.Add(Me.Label_KelolaUser_Cari)
        Me.Panel_KelolaUser_Cari.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_KelolaUser_Cari.Location = New System.Drawing.Point(0, 180)
        Me.Panel_KelolaUser_Cari.Name = "Panel_KelolaUser_Cari"
        Me.Panel_KelolaUser_Cari.Size = New System.Drawing.Size(358, 37)
        Me.Panel_KelolaUser_Cari.TabIndex = 6
        '
        'TextBox_KelolaUser_Cari
        '
        Me.TextBox_KelolaUser_Cari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_KelolaUser_Cari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_KelolaUser_Cari.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_KelolaUser_Cari.Location = New System.Drawing.Point(57, 5)
        Me.TextBox_KelolaUser_Cari.Name = "TextBox_KelolaUser_Cari"
        Me.TextBox_KelolaUser_Cari.Size = New System.Drawing.Size(284, 27)
        Me.TextBox_KelolaUser_Cari.TabIndex = 1
        '
        'Label_KelolaUser_Cari
        '
        Me.Label_KelolaUser_Cari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_KelolaUser_Cari.AutoSize = True
        Me.Label_KelolaUser_Cari.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_KelolaUser_Cari.Location = New System.Drawing.Point(14, 8)
        Me.Label_KelolaUser_Cari.Name = "Label_KelolaUser_Cari"
        Me.Label_KelolaUser_Cari.Size = New System.Drawing.Size(37, 19)
        Me.Label_KelolaUser_Cari.TabIndex = 2
        Me.Label_KelolaUser_Cari.Text = "Cari"
        '
        'Panel_Password
        '
        Me.Panel_Password.Controls.Add(Me.Label_Password)
        Me.Panel_Password.Controls.Add(Me.TextBox_Password)
        Me.Panel_Password.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Password.Location = New System.Drawing.Point(0, 120)
        Me.Panel_Password.Name = "Panel_Password"
        Me.Panel_Password.Size = New System.Drawing.Size(358, 60)
        Me.Panel_Password.TabIndex = 5
        '
        'Label_Password
        '
        Me.Label_Password.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Password.AutoSize = True
        Me.Label_Password.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Password.Location = New System.Drawing.Point(18, 0)
        Me.Label_Password.Name = "Label_Password"
        Me.Label_Password.Size = New System.Drawing.Size(76, 19)
        Me.Label_Password.TabIndex = 2
        Me.Label_Password.Text = "Password"
        '
        'TextBox_Password
        '
        Me.TextBox_Password.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Password.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Password.Location = New System.Drawing.Point(18, 30)
        Me.TextBox_Password.Name = "TextBox_Password"
        Me.TextBox_Password.Size = New System.Drawing.Size(323, 20)
        Me.TextBox_Password.TabIndex = 1
        '
        'Panel_Username
        '
        Me.Panel_Username.Controls.Add(Me.Label_Username)
        Me.Panel_Username.Controls.Add(Me.TextBox_Username)
        Me.Panel_Username.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Username.Location = New System.Drawing.Point(0, 60)
        Me.Panel_Username.Name = "Panel_Username"
        Me.Panel_Username.Size = New System.Drawing.Size(358, 60)
        Me.Panel_Username.TabIndex = 4
        '
        'Label_Username
        '
        Me.Label_Username.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Username.AutoSize = True
        Me.Label_Username.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Username.Location = New System.Drawing.Point(18, 3)
        Me.Label_Username.Name = "Label_Username"
        Me.Label_Username.Size = New System.Drawing.Size(80, 19)
        Me.Label_Username.TabIndex = 2
        Me.Label_Username.Text = "Username"
        '
        'TextBox_Username
        '
        Me.TextBox_Username.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Username.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Username.Location = New System.Drawing.Point(18, 30)
        Me.TextBox_Username.Name = "TextBox_Username"
        Me.TextBox_Username.Size = New System.Drawing.Size(323, 20)
        Me.TextBox_Username.TabIndex = 1
        '
        'Panel_Alamat
        '
        Me.Panel_Alamat.Controls.Add(Me.Label_Alamat)
        Me.Panel_Alamat.Controls.Add(Me.TextBox_Alamat)
        Me.Panel_Alamat.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Alamat.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Alamat.Name = "Panel_Alamat"
        Me.Panel_Alamat.Size = New System.Drawing.Size(358, 60)
        Me.Panel_Alamat.TabIndex = 3
        '
        'Label_Alamat
        '
        Me.Label_Alamat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Alamat.AutoSize = True
        Me.Label_Alamat.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Alamat.Location = New System.Drawing.Point(18, 0)
        Me.Label_Alamat.Name = "Label_Alamat"
        Me.Label_Alamat.Size = New System.Drawing.Size(59, 19)
        Me.Label_Alamat.TabIndex = 2
        Me.Label_Alamat.Text = "Alamat"
        '
        'TextBox_Alamat
        '
        Me.TextBox_Alamat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Alamat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Alamat.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Alamat.Location = New System.Drawing.Point(18, 30)
        Me.TextBox_Alamat.Name = "TextBox_Alamat"
        Me.TextBox_Alamat.Size = New System.Drawing.Size(323, 20)
        Me.TextBox_Alamat.TabIndex = 1
        '
        'DataGridView_KelolaUser
        '
        Me.DataGridView_KelolaUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_KelolaUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_KelolaUser.Location = New System.Drawing.Point(18, 256)
        Me.DataGridView_KelolaUser.Name = "DataGridView_KelolaUser"
        Me.DataGridView_KelolaUser.Size = New System.Drawing.Size(686, 177)
        Me.DataGridView_KelolaUser.TabIndex = 1
        '
        'UserControl_Admin_KelolaUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView_KelolaUser)
        Me.Controls.Add(Me.SplitContainer_Admin_KelolaUser)
        Me.Controls.Add(Me.Label_KelolaUser)
        Me.Name = "UserControl_Admin_KelolaUser"
        Me.Size = New System.Drawing.Size(720, 441)
        Me.SplitContainer_Admin_KelolaUser.Panel1.ResumeLayout(False)
        Me.SplitContainer_Admin_KelolaUser.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_Admin_KelolaUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Admin_KelolaUser.ResumeLayout(False)
        Me.Panel_Telepon.ResumeLayout(False)
        Me.Panel_Telepon.PerformLayout()
        Me.Panel_Nama.ResumeLayout(False)
        Me.Panel_Nama.PerformLayout()
        Me.Panel_TipeUser.ResumeLayout(False)
        Me.Panel_TipeUser.PerformLayout()
        Me.Panel_KelolaUser_Cari.ResumeLayout(False)
        Me.Panel_KelolaUser_Cari.PerformLayout()
        Me.Panel_Password.ResumeLayout(False)
        Me.Panel_Password.PerformLayout()
        Me.Panel_Username.ResumeLayout(False)
        Me.Panel_Username.PerformLayout()
        Me.Panel_Alamat.ResumeLayout(False)
        Me.Panel_Alamat.PerformLayout()
        CType(Me.DataGridView_KelolaUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label_KelolaUser As Label
    Friend WithEvents SplitContainer_Admin_KelolaUser As SplitContainer
    Friend WithEvents Label_Tipe_User As Label
    Friend WithEvents Label_Telepon As Label
    Friend WithEvents TextBox_Telepon As TextBox
    Friend WithEvents Label_Nama As Label
    Friend WithEvents TextBox_Nama As TextBox
    Friend WithEvents Label_Password As Label
    Friend WithEvents TextBox_Password As TextBox
    Friend WithEvents Label_Username As Label
    Friend WithEvents TextBox_Username As TextBox
    Friend WithEvents Label_Alamat As Label
    Friend WithEvents TextBox_Alamat As TextBox
    Friend WithEvents ComboBox_TipeUser As ComboBox
    Friend WithEvents Button_KelolaUser_Tambah As Button
    Friend WithEvents Button_KelolaUser_Edit As Button
    Friend WithEvents Button_KelolaUser_Hapus As Button
    Friend WithEvents Label_KelolaUser_Cari As Label
    Friend WithEvents TextBox_KelolaUser_Cari As TextBox
    Friend WithEvents DataGridView_KelolaUser As DataGridView
    Friend WithEvents Panel_TipeUser As Panel
    Friend WithEvents Panel_Telepon As Panel
    Friend WithEvents Panel_Nama As Panel
    Friend WithEvents Panel_Password As Panel
    Friend WithEvents Panel_Username As Panel
    Friend WithEvents Panel_Alamat As Panel
    Friend WithEvents Panel_KelolaUser_Cari As Panel
End Class
