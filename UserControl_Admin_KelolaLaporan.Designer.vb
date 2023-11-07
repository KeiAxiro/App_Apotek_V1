<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControl_Admin_KelolaLaporan
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button_Load = New System.Windows.Forms.Button()
        Me.TableLayoutPanel_Admin_KelolaLaporan = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Chart_Admin_kelolaLaporan = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button_Admin_KelolaLaporan = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel_Admin_KelolaLaporan.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart_Admin_kelolaLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(780, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kelola Laporan"
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(780, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Laporan Penjualan"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 33)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dari Tgl."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(310, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 33)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Sampai Tgl."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_Load
        '
        Me.Button_Load.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button_Load.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Load.Location = New System.Drawing.Point(624, 3)
        Me.Button_Load.Name = "Button_Load"
        Me.Button_Load.Size = New System.Drawing.Size(153, 27)
        Me.Button_Load.TabIndex = 4
        Me.Button_Load.Text = "Load"
        Me.Button_Load.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel_Admin_KelolaLaporan
        '
        Me.TableLayoutPanel_Admin_KelolaLaporan.ColumnCount = 5
        Me.TableLayoutPanel_Admin_KelolaLaporan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9984!))
        Me.TableLayoutPanel_Admin_KelolaLaporan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9984!))
        Me.TableLayoutPanel_Admin_KelolaLaporan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9984!))
        Me.TableLayoutPanel_Admin_KelolaLaporan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0024!))
        Me.TableLayoutPanel_Admin_KelolaLaporan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0024!))
        Me.TableLayoutPanel_Admin_KelolaLaporan.Controls.Add(Me.Button_Load, 4, 0)
        Me.TableLayoutPanel_Admin_KelolaLaporan.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel_Admin_KelolaLaporan.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel_Admin_KelolaLaporan.Controls.Add(Me.DateTimePicker1, 1, 0)
        Me.TableLayoutPanel_Admin_KelolaLaporan.Controls.Add(Me.DateTimePicker2, 3, 0)
        Me.TableLayoutPanel_Admin_KelolaLaporan.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel_Admin_KelolaLaporan.Location = New System.Drawing.Point(10, 76)
        Me.TableLayoutPanel_Admin_KelolaLaporan.Name = "TableLayoutPanel_Admin_KelolaLaporan"
        Me.TableLayoutPanel_Admin_KelolaLaporan.RowCount = 1
        Me.TableLayoutPanel_Admin_KelolaLaporan.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_Admin_KelolaLaporan.Size = New System.Drawing.Size(780, 33)
        Me.TableLayoutPanel_Admin_KelolaLaporan.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(10, 109)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(780, 162)
        Me.DataGridView1.TabIndex = 6
        '
        'Chart_Admin_kelolaLaporan
        '
        Me.Chart_Admin_kelolaLaporan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart_Admin_kelolaLaporan.BorderlineColor = System.Drawing.Color.Violet
        ChartArea1.Name = "ChartArea1"
        Me.Chart_Admin_kelolaLaporan.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart_Admin_kelolaLaporan.Legends.Add(Legend1)
        Me.Chart_Admin_kelolaLaporan.Location = New System.Drawing.Point(10, 277)
        Me.Chart_Admin_kelolaLaporan.Name = "Chart_Admin_kelolaLaporan"
        Me.Chart_Admin_kelolaLaporan.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Chart_Admin_kelolaLaporan.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.Navy, System.Drawing.Color.Aqua}
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart_Admin_kelolaLaporan.Series.Add(Series1)
        Me.Chart_Admin_kelolaLaporan.Size = New System.Drawing.Size(618, 160)
        Me.Chart_Admin_kelolaLaporan.TabIndex = 7
        Me.Chart_Admin_kelolaLaporan.Text = "Chart_Admin_KelolaLaporan"
        '
        'Button_Admin_KelolaLaporan
        '
        Me.Button_Admin_KelolaLaporan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Admin_KelolaLaporan.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Admin_KelolaLaporan.Location = New System.Drawing.Point(634, 341)
        Me.Button_Admin_KelolaLaporan.Name = "Button_Admin_KelolaLaporan"
        Me.Button_Admin_KelolaLaporan.Size = New System.Drawing.Size(153, 27)
        Me.Button_Admin_KelolaLaporan.TabIndex = 8
        Me.Button_Admin_KelolaLaporan.Text = "Generate"
        Me.Button_Admin_KelolaLaporan.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DateTimePicker1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(158, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(149, 26)
        Me.DateTimePicker1.TabIndex = 5
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(468, 3)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(150, 26)
        Me.DateTimePicker2.TabIndex = 6
        '
        'UserControl_Admin_KelolaLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button_Admin_KelolaLaporan)
        Me.Controls.Add(Me.Chart_Admin_kelolaLaporan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TableLayoutPanel_Admin_KelolaLaporan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "UserControl_Admin_KelolaLaporan"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel_Admin_KelolaLaporan.ResumeLayout(False)
        Me.TableLayoutPanel_Admin_KelolaLaporan.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart_Admin_kelolaLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_Load As Button
    Friend WithEvents TableLayoutPanel_Admin_KelolaLaporan As TableLayoutPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Chart_Admin_kelolaLaporan As DataVisualization.Charting.Chart
    Friend WithEvents Button_Admin_KelolaLaporan As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
End Class
