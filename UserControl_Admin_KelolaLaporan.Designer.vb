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
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button_KelolaLaporan_Load = New System.Windows.Forms.Button()
        Me.TableLayoutPanel_Admin_KelolaLaporan = New System.Windows.Forms.TableLayoutPanel()
        Me.DateTimePicker_KelolaLaporan_Dari = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_KelolaLaporan_Sampai = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView_Admin_KelolaLaporan = New System.Windows.Forms.DataGridView()
        Me.Chart_Admin_kelolaLaporan = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button_KelolaLaporan_Generate = New System.Windows.Forms.Button()
        Me.TableLayoutPanel_Admin_KelolaLaporan.SuspendLayout()
        CType(Me.DataGridView_Admin_KelolaLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(667, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kelola Laporan"
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 39)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(667, 26)
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
        Me.Label3.Size = New System.Drawing.Size(133, 33)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dari Tgl."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(266, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 33)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Sampai Tgl."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_KelolaLaporan_Load
        '
        Me.Button_KelolaLaporan_Load.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button_KelolaLaporan_Load.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_KelolaLaporan_Load.Location = New System.Drawing.Point(535, 3)
        Me.Button_KelolaLaporan_Load.Name = "Button_KelolaLaporan_Load"
        Me.Button_KelolaLaporan_Load.Size = New System.Drawing.Size(129, 27)
        Me.Button_KelolaLaporan_Load.TabIndex = 4
        Me.Button_KelolaLaporan_Load.Text = "Load"
        Me.Button_KelolaLaporan_Load.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel_Admin_KelolaLaporan
        '
        Me.TableLayoutPanel_Admin_KelolaLaporan.ColumnCount = 5
        Me.TableLayoutPanel_Admin_KelolaLaporan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9984!))
        Me.TableLayoutPanel_Admin_KelolaLaporan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9984!))
        Me.TableLayoutPanel_Admin_KelolaLaporan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9984!))
        Me.TableLayoutPanel_Admin_KelolaLaporan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0024!))
        Me.TableLayoutPanel_Admin_KelolaLaporan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0024!))
        Me.TableLayoutPanel_Admin_KelolaLaporan.Controls.Add(Me.Button_KelolaLaporan_Load, 4, 0)
        Me.TableLayoutPanel_Admin_KelolaLaporan.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel_Admin_KelolaLaporan.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel_Admin_KelolaLaporan.Controls.Add(Me.DateTimePicker_KelolaLaporan_Dari, 1, 0)
        Me.TableLayoutPanel_Admin_KelolaLaporan.Controls.Add(Me.DateTimePicker_KelolaLaporan_Sampai, 3, 0)
        Me.TableLayoutPanel_Admin_KelolaLaporan.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel_Admin_KelolaLaporan.Location = New System.Drawing.Point(10, 65)
        Me.TableLayoutPanel_Admin_KelolaLaporan.Name = "TableLayoutPanel_Admin_KelolaLaporan"
        Me.TableLayoutPanel_Admin_KelolaLaporan.RowCount = 1
        Me.TableLayoutPanel_Admin_KelolaLaporan.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_Admin_KelolaLaporan.Size = New System.Drawing.Size(667, 33)
        Me.TableLayoutPanel_Admin_KelolaLaporan.TabIndex = 5
        '
        'DateTimePicker_KelolaLaporan_Dari
        '
        Me.DateTimePicker_KelolaLaporan_Dari.CalendarFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_KelolaLaporan_Dari.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker_KelolaLaporan_Dari.Dock = System.Windows.Forms.DockStyle.Top
        Me.DateTimePicker_KelolaLaporan_Dari.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_KelolaLaporan_Dari.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_KelolaLaporan_Dari.Location = New System.Drawing.Point(136, 3)
        Me.DateTimePicker_KelolaLaporan_Dari.Name = "DateTimePicker_KelolaLaporan_Dari"
        Me.DateTimePicker_KelolaLaporan_Dari.Size = New System.Drawing.Size(127, 26)
        Me.DateTimePicker_KelolaLaporan_Dari.TabIndex = 5
        '
        'DateTimePicker_KelolaLaporan_Sampai
        '
        Me.DateTimePicker_KelolaLaporan_Sampai.CalendarFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_KelolaLaporan_Sampai.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker_KelolaLaporan_Sampai.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker_KelolaLaporan_Sampai.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_KelolaLaporan_Sampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_KelolaLaporan_Sampai.Location = New System.Drawing.Point(402, 3)
        Me.DateTimePicker_KelolaLaporan_Sampai.Name = "DateTimePicker_KelolaLaporan_Sampai"
        Me.DateTimePicker_KelolaLaporan_Sampai.Size = New System.Drawing.Size(127, 26)
        Me.DateTimePicker_KelolaLaporan_Sampai.TabIndex = 6
        '
        'DataGridView_Admin_KelolaLaporan
        '
        Me.DataGridView_Admin_KelolaLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Admin_KelolaLaporan.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView_Admin_KelolaLaporan.Location = New System.Drawing.Point(10, 98)
        Me.DataGridView_Admin_KelolaLaporan.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridView_Admin_KelolaLaporan.Name = "DataGridView_Admin_KelolaLaporan"
        Me.DataGridView_Admin_KelolaLaporan.Size = New System.Drawing.Size(667, 141)
        Me.DataGridView_Admin_KelolaLaporan.TabIndex = 6
        '
        'Chart_Admin_kelolaLaporan
        '
        Me.Chart_Admin_kelolaLaporan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart_Admin_kelolaLaporan.BorderlineColor = System.Drawing.Color.Violet
        ChartArea1.Name = "ChartArea1"
        Me.Chart_Admin_kelolaLaporan.ChartAreas.Add(ChartArea1)
        Me.Chart_Admin_kelolaLaporan.Location = New System.Drawing.Point(10, 242)
        Me.Chart_Admin_kelolaLaporan.Name = "Chart_Admin_kelolaLaporan"
        Me.Chart_Admin_kelolaLaporan.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Chart_Admin_kelolaLaporan.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.Navy, System.Drawing.Color.Aqua}
        Series1.ChartArea = "ChartArea1"
        Series1.Name = "Tgl_Transaksi_x_Total_Bayar"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Date]
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Me.Chart_Admin_kelolaLaporan.Series.Add(Series1)
        Me.Chart_Admin_kelolaLaporan.Size = New System.Drawing.Size(569, 200)
        Me.Chart_Admin_kelolaLaporan.TabIndex = 7
        Me.Chart_Admin_kelolaLaporan.Text = "Chart_Admin_KelolaLaporan"
        '
        'Button_KelolaLaporan_Generate
        '
        Me.Button_KelolaLaporan_Generate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_KelolaLaporan_Generate.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_KelolaLaporan_Generate.Location = New System.Drawing.Point(585, 341)
        Me.Button_KelolaLaporan_Generate.Name = "Button_KelolaLaporan_Generate"
        Me.Button_KelolaLaporan_Generate.Size = New System.Drawing.Size(89, 27)
        Me.Button_KelolaLaporan_Generate.TabIndex = 8
        Me.Button_KelolaLaporan_Generate.Text = "Generate"
        Me.Button_KelolaLaporan_Generate.UseVisualStyleBackColor = True
        '
        'UserControl_Admin_KelolaLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button_KelolaLaporan_Generate)
        Me.Controls.Add(Me.Chart_Admin_kelolaLaporan)
        Me.Controls.Add(Me.DataGridView_Admin_KelolaLaporan)
        Me.Controls.Add(Me.TableLayoutPanel_Admin_KelolaLaporan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "UserControl_Admin_KelolaLaporan"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(687, 450)
        Me.TableLayoutPanel_Admin_KelolaLaporan.ResumeLayout(False)
        Me.TableLayoutPanel_Admin_KelolaLaporan.PerformLayout()
        CType(Me.DataGridView_Admin_KelolaLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart_Admin_kelolaLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_KelolaLaporan_Load As Button
    Friend WithEvents TableLayoutPanel_Admin_KelolaLaporan As TableLayoutPanel
    Friend WithEvents DataGridView_Admin_KelolaLaporan As DataGridView
    Friend WithEvents Chart_Admin_kelolaLaporan As DataVisualization.Charting.Chart
    Friend WithEvents Button_KelolaLaporan_Generate As Button
    Friend WithEvents DateTimePicker_KelolaLaporan_Dari As DateTimePicker
    Friend WithEvents DateTimePicker_KelolaLaporan_Sampai As DateTimePicker
End Class
