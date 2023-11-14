<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Admin_Nav
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
        Me.SplitContainer_Login = New System.Windows.Forms.SplitContainer()
        Me.Panel_Admin_Kiri = New System.Windows.Forms.Panel()
        Me.Button_Admin_Logout = New System.Windows.Forms.Button()
        Me.Button_Admin_KelolaLaporan = New System.Windows.Forms.Button()
        Me.Button_Admin_KelolaUser = New System.Windows.Forms.Button()
        Me.Button_Admin_KelolaObat = New System.Windows.Forms.Button()
        Me.PictureBox_Admin_Logo = New System.Windows.Forms.PictureBox()
        Me.Panel_Admin_Kanan = New System.Windows.Forms.Panel()
        CType(Me.SplitContainer_Login, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Login.Panel1.SuspendLayout()
        Me.SplitContainer_Login.Panel2.SuspendLayout()
        Me.SplitContainer_Login.SuspendLayout()
        Me.Panel_Admin_Kiri.SuspendLayout()
        CType(Me.PictureBox_Admin_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.SplitContainer_Login.Panel1.Controls.Add(Me.Panel_Admin_Kiri)
        '
        'SplitContainer_Login.Panel2
        '
        Me.SplitContainer_Login.Panel2.Controls.Add(Me.Panel_Admin_Kanan)
        Me.SplitContainer_Login.Size = New System.Drawing.Size(984, 411)
        Me.SplitContainer_Login.SplitterDistance = 276
        Me.SplitContainer_Login.SplitterWidth = 1
        Me.SplitContainer_Login.TabIndex = 1
        '
        'Panel_Admin_Kiri
        '
        Me.Panel_Admin_Kiri.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel_Admin_Kiri.Controls.Add(Me.Button_Admin_Logout)
        Me.Panel_Admin_Kiri.Controls.Add(Me.Button_Admin_KelolaLaporan)
        Me.Panel_Admin_Kiri.Controls.Add(Me.Button_Admin_KelolaUser)
        Me.Panel_Admin_Kiri.Controls.Add(Me.Button_Admin_KelolaObat)
        Me.Panel_Admin_Kiri.Controls.Add(Me.PictureBox_Admin_Logo)
        Me.Panel_Admin_Kiri.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Admin_Kiri.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Admin_Kiri.Name = "Panel_Admin_Kiri"
        Me.Panel_Admin_Kiri.Size = New System.Drawing.Size(276, 411)
        Me.Panel_Admin_Kiri.TabIndex = 0
        '
        'Button_Admin_Logout
        '
        Me.Button_Admin_Logout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Admin_Logout.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_Admin_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Admin_Logout.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Admin_Logout.Location = New System.Drawing.Point(5, 360)
        Me.Button_Admin_Logout.Name = "Button_Admin_Logout"
        Me.Button_Admin_Logout.Size = New System.Drawing.Size(266, 45)
        Me.Button_Admin_Logout.TabIndex = 1
        Me.Button_Admin_Logout.Text = "Logout"
        Me.Button_Admin_Logout.UseVisualStyleBackColor = False
        '
        'Button_Admin_KelolaLaporan
        '
        Me.Button_Admin_KelolaLaporan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Admin_KelolaLaporan.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_Admin_KelolaLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Admin_KelolaLaporan.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Admin_KelolaLaporan.Location = New System.Drawing.Point(5, 309)
        Me.Button_Admin_KelolaLaporan.Name = "Button_Admin_KelolaLaporan"
        Me.Button_Admin_KelolaLaporan.Size = New System.Drawing.Size(266, 45)
        Me.Button_Admin_KelolaLaporan.TabIndex = 1
        Me.Button_Admin_KelolaLaporan.Text = "Kelola Laporan"
        Me.Button_Admin_KelolaLaporan.UseVisualStyleBackColor = False
        '
        'Button_Admin_KelolaUser
        '
        Me.Button_Admin_KelolaUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Admin_KelolaUser.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_Admin_KelolaUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Admin_KelolaUser.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Admin_KelolaUser.Location = New System.Drawing.Point(5, 207)
        Me.Button_Admin_KelolaUser.Name = "Button_Admin_KelolaUser"
        Me.Button_Admin_KelolaUser.Size = New System.Drawing.Size(266, 45)
        Me.Button_Admin_KelolaUser.TabIndex = 1
        Me.Button_Admin_KelolaUser.Text = "Kelola User"
        Me.Button_Admin_KelolaUser.UseVisualStyleBackColor = False
        '
        'Button_Admin_KelolaObat
        '
        Me.Button_Admin_KelolaObat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Admin_KelolaObat.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_Admin_KelolaObat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Admin_KelolaObat.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Admin_KelolaObat.Location = New System.Drawing.Point(5, 258)
        Me.Button_Admin_KelolaObat.Name = "Button_Admin_KelolaObat"
        Me.Button_Admin_KelolaObat.Size = New System.Drawing.Size(266, 45)
        Me.Button_Admin_KelolaObat.TabIndex = 1
        Me.Button_Admin_KelolaObat.Text = "Kelola Obat"
        Me.Button_Admin_KelolaObat.UseVisualStyleBackColor = False
        '
        'PictureBox_Admin_Logo
        '
        Me.PictureBox_Admin_Logo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox_Admin_Logo.Image = Global.App_Apotek_V1.My.Resources.Resources.Ryo_Yamada
        Me.PictureBox_Admin_Logo.InitialImage = Nothing
        Me.PictureBox_Admin_Logo.Location = New System.Drawing.Point(63, 40)
        Me.PictureBox_Admin_Logo.Name = "PictureBox_Admin_Logo"
        Me.PictureBox_Admin_Logo.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox_Admin_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Admin_Logo.TabIndex = 0
        Me.PictureBox_Admin_Logo.TabStop = False
        '
        'Panel_Admin_Kanan
        '
        Me.Panel_Admin_Kanan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Admin_Kanan.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Admin_Kanan.Name = "Panel_Admin_Kanan"
        Me.Panel_Admin_Kanan.Size = New System.Drawing.Size(707, 411)
        Me.Panel_Admin_Kanan.TabIndex = 0
        '
        'Form_Admin_Nav
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 411)
        Me.Controls.Add(Me.SplitContainer_Login)
        Me.Name = "Form_Admin_Nav"
        Me.Text = "Form Navigasi Admin"
        Me.SplitContainer_Login.Panel1.ResumeLayout(False)
        Me.SplitContainer_Login.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_Login, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Login.ResumeLayout(False)
        Me.Panel_Admin_Kiri.ResumeLayout(False)
        CType(Me.PictureBox_Admin_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer_Login As SplitContainer
    Friend WithEvents Panel_Admin_Kiri As Panel
    Friend WithEvents PictureBox_Admin_Logo As PictureBox
    Friend WithEvents Panel_Admin_Kanan As Panel
    Friend WithEvents Button_Admin_KelolaObat As Button
    Friend WithEvents Button_Admin_KelolaLaporan As Button
    Friend WithEvents Button_Admin_KelolaUser As Button
    Friend WithEvents Button_Admin_Logout As Button

End Class
