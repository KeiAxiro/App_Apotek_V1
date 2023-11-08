<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_Admin_LogActivity
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView_Admin_LogActivity = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker_Admin_LogActivity = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_Admin_LogActivity_Load = New System.Windows.Forms.Button()
        CType(Me.DataGridView_Admin_LogActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(831, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Log Activity"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView_Admin_LogActivity
        '
        Me.DataGridView_Admin_LogActivity.AllowUserToDeleteRows = False
        Me.DataGridView_Admin_LogActivity.AllowUserToOrderColumns = True
        Me.DataGridView_Admin_LogActivity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Admin_LogActivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_Admin_LogActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Admin_LogActivity.Location = New System.Drawing.Point(18, 41)
        Me.DataGridView_Admin_LogActivity.Name = "DataGridView_Admin_LogActivity"
        Me.DataGridView_Admin_LogActivity.Size = New System.Drawing.Size(796, 333)
        Me.DataGridView_Admin_LogActivity.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(170, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tampilkan Per"
        '
        'DateTimePicker_Admin_LogActivity
        '
        Me.DateTimePicker_Admin_LogActivity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateTimePicker_Admin_LogActivity.Location = New System.Drawing.Point(306, 23)
        Me.DateTimePicker_Admin_LogActivity.Name = "DateTimePicker_Admin_LogActivity"
        Me.DateTimePicker_Admin_LogActivity.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker_Admin_LogActivity.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Button_Admin_LogActivity_Load)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DateTimePicker_Admin_LogActivity)
        Me.Panel1.Location = New System.Drawing.Point(18, 380)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 63)
        Me.Panel1.TabIndex = 4
        '
        'Button_Admin_LogActivity_Load
        '
        Me.Button_Admin_LogActivity_Load.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button_Admin_LogActivity_Load.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Admin_LogActivity_Load.Location = New System.Drawing.Point(534, 18)
        Me.Button_Admin_LogActivity_Load.Name = "Button_Admin_LogActivity_Load"
        Me.Button_Admin_LogActivity_Load.Size = New System.Drawing.Size(96, 30)
        Me.Button_Admin_LogActivity_Load.TabIndex = 4
        Me.Button_Admin_LogActivity_Load.Text = "Load"
        Me.Button_Admin_LogActivity_Load.UseVisualStyleBackColor = True
        '
        'UserControl_Admin_LogActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView_Admin_LogActivity)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UserControl_Admin_LogActivity"
        Me.Size = New System.Drawing.Size(831, 446)
        CType(Me.DataGridView_Admin_LogActivity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView_Admin_LogActivity As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker_Admin_LogActivity As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_Admin_LogActivity_Load As Button
End Class
