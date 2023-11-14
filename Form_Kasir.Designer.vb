<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Kasir
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
        Me.Label_Kasir_KelolaTransaksi = New System.Windows.Forms.Label()
        Me.Button_Kasir_Logout = New System.Windows.Forms.Button()
        Me.Panel_Admin_Kiri = New System.Windows.Forms.Panel()
        Me.Label_Kasir = New System.Windows.Forms.Label()
        Me.PictureBox_Kasir_Logo = New System.Windows.Forms.PictureBox()
        Me.SplitContainer_Login = New System.Windows.Forms.SplitContainer()
        Me.Panel_Admin_Kanan = New System.Windows.Forms.Panel()
        Me.Panel_Admin_Kiri.SuspendLayout()
        CType(Me.PictureBox_Kasir_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer_Login, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Login.Panel1.SuspendLayout()
        Me.SplitContainer_Login.Panel2.SuspendLayout()
        Me.SplitContainer_Login.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_Kasir_KelolaTransaksi
        '
        Me.Label_Kasir_KelolaTransaksi.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Kasir_KelolaTransaksi.ForeColor = System.Drawing.SystemColors.Control
        Me.Label_Kasir_KelolaTransaksi.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label_Kasir_KelolaTransaksi.Location = New System.Drawing.Point(0, 250)
        Me.Label_Kasir_KelolaTransaksi.Name = "Label_Kasir_KelolaTransaksi"
        Me.Label_Kasir_KelolaTransaksi.Size = New System.Drawing.Size(220, 88)
        Me.Label_Kasir_KelolaTransaksi.TabIndex = 3
        Me.Label_Kasir_KelolaTransaksi.Text = "KELOLA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TRANSAKSI"
        Me.Label_Kasir_KelolaTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_Kasir_Logout
        '
        Me.Button_Kasir_Logout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Kasir_Logout.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_Kasir_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Kasir_Logout.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Kasir_Logout.Location = New System.Drawing.Point(50, 341)
        Me.Button_Kasir_Logout.Name = "Button_Kasir_Logout"
        Me.Button_Kasir_Logout.Size = New System.Drawing.Size(181, 28)
        Me.Button_Kasir_Logout.TabIndex = 1
        Me.Button_Kasir_Logout.Text = "Logout"
        Me.Button_Kasir_Logout.UseVisualStyleBackColor = False
        '
        'Panel_Admin_Kiri
        '
        Me.Panel_Admin_Kiri.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel_Admin_Kiri.Controls.Add(Me.Label_Kasir_KelolaTransaksi)
        Me.Panel_Admin_Kiri.Controls.Add(Me.Label_Kasir)
        Me.Panel_Admin_Kiri.Controls.Add(Me.Button_Kasir_Logout)
        Me.Panel_Admin_Kiri.Controls.Add(Me.PictureBox_Kasir_Logo)
        Me.Panel_Admin_Kiri.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Admin_Kiri.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Admin_Kiri.Name = "Panel_Admin_Kiri"
        Me.Panel_Admin_Kiri.Size = New System.Drawing.Size(276, 411)
        Me.Panel_Admin_Kiri.TabIndex = 0
        '
        'Label_Kasir
        '
        Me.Label_Kasir.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Kasir.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Kasir.ForeColor = System.Drawing.SystemColors.Control
        Me.Label_Kasir.Location = New System.Drawing.Point(0, 0)
        Me.Label_Kasir.Name = "Label_Kasir"
        Me.Label_Kasir.Size = New System.Drawing.Size(276, 94)
        Me.Label_Kasir.TabIndex = 2
        Me.Label_Kasir.Text = "KASIR"
        Me.Label_Kasir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox_Kasir_Logo
        '
        Me.PictureBox_Kasir_Logo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox_Kasir_Logo.Image = Global.App_Apotek_V1.My.Resources.Resources.Ryo_Yamada
        Me.PictureBox_Kasir_Logo.InitialImage = Nothing
        Me.PictureBox_Kasir_Logo.Location = New System.Drawing.Point(63, 97)
        Me.PictureBox_Kasir_Logo.Name = "PictureBox_Kasir_Logo"
        Me.PictureBox_Kasir_Logo.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox_Kasir_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Kasir_Logo.TabIndex = 0
        Me.PictureBox_Kasir_Logo.TabStop = False
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
        Me.SplitContainer_Login.TabIndex = 3
        '
        'Panel_Admin_Kanan
        '
        Me.Panel_Admin_Kanan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Admin_Kanan.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Admin_Kanan.Name = "Panel_Admin_Kanan"
        Me.Panel_Admin_Kanan.Size = New System.Drawing.Size(707, 411)
        Me.Panel_Admin_Kanan.TabIndex = 0
        '
        'Form_Kasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 411)
        Me.Controls.Add(Me.SplitContainer_Login)
        Me.Name = "Form_Kasir"
        Me.Text = "Form Kelola Transaksi | Kasir"
        Me.Panel_Admin_Kiri.ResumeLayout(False)
        CType(Me.PictureBox_Kasir_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Login.Panel1.ResumeLayout(False)
        Me.SplitContainer_Login.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_Login, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Login.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label_Kasir_KelolaTransaksi As Label
    Friend WithEvents Button_Kasir_Logout As Button
    Friend WithEvents PictureBox_Kasir_Logo As PictureBox
    Friend WithEvents Panel_Admin_Kiri As Panel
    Friend WithEvents Label_Kasir As Label
    Friend WithEvents SplitContainer_Login As SplitContainer
    Friend WithEvents Panel_Admin_Kanan As Panel
End Class
