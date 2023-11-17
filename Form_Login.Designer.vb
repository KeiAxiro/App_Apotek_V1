<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.SplitContainer_Login = New System.Windows.Forms.SplitContainer()
        Me.Panel_Login_Kiri = New System.Windows.Forms.Panel()
        Me.Label_Login_Judul = New System.Windows.Forms.Label()
        Me.PictureBox_Login_Farmasi = New System.Windows.Forms.PictureBox()
        Me.Panel_Login_Kanan = New System.Windows.Forms.Panel()
        Me.Panel_Login_Kanan_Input = New System.Windows.Forms.Panel()
        Me.Button_Login = New System.Windows.Forms.Button()
        Me.Button_Reset = New System.Windows.Forms.Button()
        Me.Panel_Login_Password = New System.Windows.Forms.Panel()
        Me.TextBox_Login_Password = New System.Windows.Forms.TextBox()
        Me.Label_Login_Password = New System.Windows.Forms.Label()
        Me.Panel_Login_Username = New System.Windows.Forms.Panel()
        Me.TextBox_Login_Username = New System.Windows.Forms.TextBox()
        Me.Label_Login_Username = New System.Windows.Forms.Label()
        Me.Label_Silahkan = New System.Windows.Forms.Label()
        Me.PictureBox_Logo_Farmasi_Plus = New System.Windows.Forms.PictureBox()
        CType(Me.SplitContainer_Login, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Login.Panel1.SuspendLayout()
        Me.SplitContainer_Login.Panel2.SuspendLayout()
        Me.SplitContainer_Login.SuspendLayout()
        Me.Panel_Login_Kiri.SuspendLayout()
        CType(Me.PictureBox_Login_Farmasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Login_Kanan.SuspendLayout()
        Me.Panel_Login_Kanan_Input.SuspendLayout()
        Me.Panel_Login_Password.SuspendLayout()
        Me.Panel_Login_Username.SuspendLayout()
        CType(Me.PictureBox_Logo_Farmasi_Plus, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer_Login.Panel1.Controls.Add(Me.Panel_Login_Kiri)
        '
        'SplitContainer_Login.Panel2
        '
        Me.SplitContainer_Login.Panel2.Controls.Add(Me.Panel_Login_Kanan)
        Me.SplitContainer_Login.Size = New System.Drawing.Size(984, 411)
        Me.SplitContainer_Login.SplitterDistance = 276
        Me.SplitContainer_Login.SplitterWidth = 1
        Me.SplitContainer_Login.TabIndex = 0
        '
        'Panel_Login_Kiri
        '
        Me.Panel_Login_Kiri.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel_Login_Kiri.Controls.Add(Me.Label_Login_Judul)
        Me.Panel_Login_Kiri.Controls.Add(Me.PictureBox_Login_Farmasi)
        Me.Panel_Login_Kiri.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Login_Kiri.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Login_Kiri.Name = "Panel_Login_Kiri"
        Me.Panel_Login_Kiri.Size = New System.Drawing.Size(276, 411)
        Me.Panel_Login_Kiri.TabIndex = 0
        '
        'Label_Login_Judul
        '
        Me.Label_Login_Judul.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_Login_Judul.AutoSize = True
        Me.Label_Login_Judul.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Login_Judul.ForeColor = System.Drawing.SystemColors.Control
        Me.Label_Login_Judul.Location = New System.Drawing.Point(72, 54)
        Me.Label_Login_Judul.Name = "Label_Login_Judul"
        Me.Label_Login_Judul.Size = New System.Drawing.Size(127, 78)
        Me.Label_Login_Judul.TabIndex = 1
        Me.Label_Login_Judul.Text = "APLIKASI" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "APOTEK" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "XYZ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox_Login_Farmasi
        '
        Me.PictureBox_Login_Farmasi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox_Login_Farmasi.Image = Global.App_Apotek_V1.My.Resources.Resources.apotek_portait
        Me.PictureBox_Login_Farmasi.InitialImage = Global.App_Apotek_V1.My.Resources.Resources.Logo_Pharmacie_780x560_removebg_preview
        Me.PictureBox_Login_Farmasi.Location = New System.Drawing.Point(66, 193)
        Me.PictureBox_Login_Farmasi.Name = "PictureBox_Login_Farmasi"
        Me.PictureBox_Login_Farmasi.Size = New System.Drawing.Size(144, 180)
        Me.PictureBox_Login_Farmasi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Login_Farmasi.TabIndex = 0
        Me.PictureBox_Login_Farmasi.TabStop = False
        '
        'Panel_Login_Kanan
        '
        Me.Panel_Login_Kanan.Controls.Add(Me.Panel_Login_Kanan_Input)
        Me.Panel_Login_Kanan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Login_Kanan.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Login_Kanan.Name = "Panel_Login_Kanan"
        Me.Panel_Login_Kanan.Size = New System.Drawing.Size(707, 411)
        Me.Panel_Login_Kanan.TabIndex = 0
        '
        'Panel_Login_Kanan_Input
        '
        Me.Panel_Login_Kanan_Input.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel_Login_Kanan_Input.Controls.Add(Me.Button_Login)
        Me.Panel_Login_Kanan_Input.Controls.Add(Me.Button_Reset)
        Me.Panel_Login_Kanan_Input.Controls.Add(Me.Panel_Login_Password)
        Me.Panel_Login_Kanan_Input.Controls.Add(Me.Panel_Login_Username)
        Me.Panel_Login_Kanan_Input.Controls.Add(Me.Label_Silahkan)
        Me.Panel_Login_Kanan_Input.Controls.Add(Me.PictureBox_Logo_Farmasi_Plus)
        Me.Panel_Login_Kanan_Input.Location = New System.Drawing.Point(102, 30)
        Me.Panel_Login_Kanan_Input.Name = "Panel_Login_Kanan_Input"
        Me.Panel_Login_Kanan_Input.Size = New System.Drawing.Size(500, 350)
        Me.Panel_Login_Kanan_Input.TabIndex = 0
        '
        'Button_Login
        '
        Me.Button_Login.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Login.Location = New System.Drawing.Point(71, 297)
        Me.Button_Login.Name = "Button_Login"
        Me.Button_Login.Size = New System.Drawing.Size(131, 50)
        Me.Button_Login.TabIndex = 2
        Me.Button_Login.Text = "Login"
        Me.Button_Login.UseVisualStyleBackColor = True
        '
        'Button_Reset
        '
        Me.Button_Reset.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Reset.Location = New System.Drawing.Point(300, 297)
        Me.Button_Reset.Name = "Button_Reset"
        Me.Button_Reset.Size = New System.Drawing.Size(131, 50)
        Me.Button_Reset.TabIndex = 2
        Me.Button_Reset.Text = "Reset"
        Me.Button_Reset.UseVisualStyleBackColor = True
        '
        'Panel_Login_Password
        '
        Me.Panel_Login_Password.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Login_Password.Controls.Add(Me.TextBox_Login_Password)
        Me.Panel_Login_Password.Controls.Add(Me.Label_Login_Password)
        Me.Panel_Login_Password.Location = New System.Drawing.Point(71, 215)
        Me.Panel_Login_Password.Name = "Panel_Login_Password"
        Me.Panel_Login_Password.Size = New System.Drawing.Size(360, 58)
        Me.Panel_Login_Password.TabIndex = 1
        '
        'TextBox_Login_Password
        '
        Me.TextBox_Login_Password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Login_Password.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox_Login_Password.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Login_Password.Location = New System.Drawing.Point(0, 32)
        Me.TextBox_Login_Password.Name = "TextBox_Login_Password"
        Me.TextBox_Login_Password.Size = New System.Drawing.Size(360, 23)
        Me.TextBox_Login_Password.TabIndex = 1
        Me.TextBox_Login_Password.Text = "yanti"
        Me.TextBox_Login_Password.UseSystemPasswordChar = True
        '
        'Label_Login_Password
        '
        Me.Label_Login_Password.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Login_Password.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Login_Password.Location = New System.Drawing.Point(0, 0)
        Me.Label_Login_Password.Name = "Label_Login_Password"
        Me.Label_Login_Password.Size = New System.Drawing.Size(360, 32)
        Me.Label_Login_Password.TabIndex = 0
        Me.Label_Login_Password.Text = "Password"
        '
        'Panel_Login_Username
        '
        Me.Panel_Login_Username.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Login_Username.Controls.Add(Me.TextBox_Login_Username)
        Me.Panel_Login_Username.Controls.Add(Me.Label_Login_Username)
        Me.Panel_Login_Username.Location = New System.Drawing.Point(71, 151)
        Me.Panel_Login_Username.Name = "Panel_Login_Username"
        Me.Panel_Login_Username.Size = New System.Drawing.Size(360, 58)
        Me.Panel_Login_Username.TabIndex = 0
        '
        'TextBox_Login_Username
        '
        Me.TextBox_Login_Username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_Login_Username.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox_Login_Username.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Login_Username.Location = New System.Drawing.Point(0, 32)
        Me.TextBox_Login_Username.Name = "TextBox_Login_Username"
        Me.TextBox_Login_Username.Size = New System.Drawing.Size(360, 23)
        Me.TextBox_Login_Username.TabIndex = 0
        Me.TextBox_Login_Username.Text = "yanti"
        '
        'Label_Login_Username
        '
        Me.Label_Login_Username.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_Login_Username.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Login_Username.Location = New System.Drawing.Point(0, 0)
        Me.Label_Login_Username.Name = "Label_Login_Username"
        Me.Label_Login_Username.Size = New System.Drawing.Size(360, 32)
        Me.Label_Login_Username.TabIndex = 0
        Me.Label_Login_Username.Text = "Username"
        '
        'Label_Silahkan
        '
        Me.Label_Silahkan.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label_Silahkan.AutoSize = True
        Me.Label_Silahkan.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Silahkan.Location = New System.Drawing.Point(150, 85)
        Me.Label_Silahkan.Name = "Label_Silahkan"
        Me.Label_Silahkan.Size = New System.Drawing.Size(215, 27)
        Me.Label_Silahkan.TabIndex = 1
        Me.Label_Silahkan.Text = "Silahkan Login Dahulu"
        '
        'PictureBox_Logo_Farmasi_Plus
        '
        Me.PictureBox_Logo_Farmasi_Plus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox_Logo_Farmasi_Plus.Image = Global.App_Apotek_V1.My.Resources.Resources.Logo_Pharmacie_780x560_removebg_preview1
        Me.PictureBox_Logo_Farmasi_Plus.Location = New System.Drawing.Point(220, 0)
        Me.PictureBox_Logo_Farmasi_Plus.Name = "PictureBox_Logo_Farmasi_Plus"
        Me.PictureBox_Logo_Farmasi_Plus.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox_Logo_Farmasi_Plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Logo_Farmasi_Plus.TabIndex = 0
        Me.PictureBox_Logo_Farmasi_Plus.TabStop = False
        '
        'Form_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 411)
        Me.Controls.Add(Me.SplitContainer_Login)
        Me.Name = "Form_Login"
        Me.Text = "Aplikasi Apotek | Login | v1.0"
        Me.SplitContainer_Login.Panel1.ResumeLayout(False)
        Me.SplitContainer_Login.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_Login, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Login.ResumeLayout(False)
        Me.Panel_Login_Kiri.ResumeLayout(False)
        Me.Panel_Login_Kiri.PerformLayout()
        CType(Me.PictureBox_Login_Farmasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Login_Kanan.ResumeLayout(False)
        Me.Panel_Login_Kanan_Input.ResumeLayout(False)
        Me.Panel_Login_Kanan_Input.PerformLayout()
        Me.Panel_Login_Password.ResumeLayout(False)
        Me.Panel_Login_Password.PerformLayout()
        Me.Panel_Login_Username.ResumeLayout(False)
        Me.Panel_Login_Username.PerformLayout()
        CType(Me.PictureBox_Logo_Farmasi_Plus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer_Login As SplitContainer
    Friend WithEvents Panel_Login_Kiri As Panel
    Friend WithEvents PictureBox_Login_Farmasi As PictureBox
    Friend WithEvents Panel_Login_Kanan As Panel
    Friend WithEvents Label_Login_Judul As Label
    Friend WithEvents Panel_Login_Kanan_Input As Panel
    Friend WithEvents PictureBox_Logo_Farmasi_Plus As PictureBox
    Friend WithEvents Panel_Login_Username As Panel
    Friend WithEvents Label_Login_Username As Label
    Friend WithEvents Label_Silahkan As Label
    Friend WithEvents TextBox_Login_Username As TextBox
    Friend WithEvents Panel_Login_Password As Panel
    Friend WithEvents TextBox_Login_Password As TextBox
    Friend WithEvents Label_Login_Password As Label
    Friend WithEvents Button_Login As Button
    Friend WithEvents Button_Reset As Button
End Class
