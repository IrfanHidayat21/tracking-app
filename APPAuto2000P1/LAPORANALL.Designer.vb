<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LAPORANALL
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
        Me.CRV1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.DTPM2 = New System.Windows.Forms.DateTimePicker()
        Me.DTPM1 = New System.Windows.Forms.DateTimePicker()
        Me.DTP3 = New System.Windows.Forms.DateTimePicker()
        Me.DTP4 = New System.Windows.Forms.DateTimePicker()
        Me.Btn_Cetak = New System.Windows.Forms.Button()
        Me.Btn_Cetak2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CRV1
        '
        Me.CRV1.ActiveViewIndex = -1
        Me.CRV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CRV1.Location = New System.Drawing.Point(0, 105)
        Me.CRV1.Name = "CRV1"
        Me.CRV1.ShowCloseButton = False
        Me.CRV1.ShowGotoPageButton = False
        Me.CRV1.ShowGroupTreeButton = False
        Me.CRV1.ShowLogo = False
        Me.CRV1.ShowParameterPanelButton = False
        Me.CRV1.Size = New System.Drawing.Size(1220, 529)
        Me.CRV1.TabIndex = 0
        Me.CRV1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'DTPM2
        '
        Me.DTPM2.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPM2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPM2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPM2.Location = New System.Drawing.Point(124, 63)
        Me.DTPM2.Name = "DTPM2"
        Me.DTPM2.Size = New System.Drawing.Size(227, 26)
        Me.DTPM2.TabIndex = 10
        '
        'DTPM1
        '
        Me.DTPM1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPM1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPM1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPM1.Location = New System.Drawing.Point(124, 31)
        Me.DTPM1.Name = "DTPM1"
        Me.DTPM1.Size = New System.Drawing.Size(227, 26)
        Me.DTPM1.TabIndex = 4
        '
        'DTP3
        '
        Me.DTP3.CalendarFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP3.Location = New System.Drawing.Point(116, 31)
        Me.DTP3.Name = "DTP3"
        Me.DTP3.Size = New System.Drawing.Size(227, 26)
        Me.DTP3.TabIndex = 10
        '
        'DTP4
        '
        Me.DTP4.CalendarFont = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP4.Location = New System.Drawing.Point(116, 63)
        Me.DTP4.Name = "DTP4"
        Me.DTP4.Size = New System.Drawing.Size(227, 26)
        Me.DTP4.TabIndex = 4
        '
        'Btn_Cetak
        '
        Me.Btn_Cetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cetak.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cetak.Location = New System.Drawing.Point(357, 31)
        Me.Btn_Cetak.Name = "Btn_Cetak"
        Me.Btn_Cetak.Size = New System.Drawing.Size(67, 58)
        Me.Btn_Cetak.TabIndex = 11
        Me.Btn_Cetak.Text = "Cetak"
        Me.Btn_Cetak.UseVisualStyleBackColor = True
        '
        'Btn_Cetak2
        '
        Me.Btn_Cetak2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cetak2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cetak2.Location = New System.Drawing.Point(349, 31)
        Me.Btn_Cetak2.Name = "Btn_Cetak2"
        Me.Btn_Cetak2.Size = New System.Drawing.Size(64, 58)
        Me.Btn_Cetak2.TabIndex = 12
        Me.Btn_Cetak2.Text = "Cetak"
        Me.Btn_Cetak2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DTPM1)
        Me.GroupBox1.Controls.Add(Me.DTPM2)
        Me.GroupBox1.Controls.Add(Me.Btn_Cetak)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 105)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Laporan Pengajuan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 19)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Sampai Tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 19)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Dari Tanggal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.DTP3)
        Me.GroupBox2.Controls.Add(Me.DTP4)
        Me.GroupBox2.Controls.Add(Me.Btn_Cetak2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(428, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(419, 105)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Laporan Penyerahan STNK BPKB"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 19)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Sampai Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Dari Tanggal"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.APPAuto2000P1.My.Resources.Resources.toyota_auto2000
        Me.PictureBox1.Location = New System.Drawing.Point(1038, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'LAPORANALL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1220, 634)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CRV1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "LAPORANALL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRV1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DTPM2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPM1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Btn_Cetak As System.Windows.Forms.Button
    Friend WithEvents Btn_Cetak2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
