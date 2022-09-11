<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PengajuanStnkBpkb
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
        Me.txt_no_rangka = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DTPPengajuan = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_bersih = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_cabang = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_no_rangka
        '
        Me.txt_no_rangka.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_no_rangka.Location = New System.Drawing.Point(204, 12)
        Me.txt_no_rangka.MaxLength = 17
        Me.txt_no_rangka.Name = "txt_no_rangka"
        Me.txt_no_rangka.Size = New System.Drawing.Size(248, 26)
        Me.txt_no_rangka.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "No Rangka"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(347, 87)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(105, 26)
        Me.DateTimePicker2.TabIndex = 53
        '
        'DTPPengajuan
        '
        Me.DTPPengajuan.Enabled = False
        Me.DTPPengajuan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPPengajuan.Location = New System.Drawing.Point(204, 55)
        Me.DTPPengajuan.Name = "DTPPengajuan"
        Me.DTPPengajuan.Size = New System.Drawing.Size(248, 26)
        Me.DTPPengajuan.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 38)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Tanggal dan Waktu " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pengajuan STNK dan BPKB"
        '
        'btn_bersih
        '
        Me.btn_bersih.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_bersih.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bersih.Location = New System.Drawing.Point(366, 153)
        Me.btn_bersih.Name = "btn_bersih"
        Me.btn_bersih.Size = New System.Drawing.Size(86, 37)
        Me.btn_bersih.TabIndex = 49
        Me.btn_bersih.Text = "Bersih"
        Me.btn_bersih.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.Location = New System.Drawing.Point(16, 153)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(86, 37)
        Me.btn_simpan.TabIndex = 48
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'txt_status
        '
        Me.txt_status.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_status.Location = New System.Drawing.Point(204, 87)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(60, 26)
        Me.txt_status.TabIndex = 55
        Me.txt_status.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 19)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Status Pengajuan"
        Me.Label2.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 19)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Cabang Pemilik"
        '
        'txt_cabang
        '
        Me.txt_cabang.Enabled = False
        Me.txt_cabang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cabang.Location = New System.Drawing.Point(204, 119)
        Me.txt_cabang.Name = "txt_cabang"
        Me.txt_cabang.Size = New System.Drawing.Size(248, 26)
        Me.txt_cabang.TabIndex = 57
        '
        'PengajuanStnkBpkb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 197)
        Me.Controls.Add(Me.txt_cabang)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_status)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DTPPengajuan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_bersih)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.txt_no_rangka)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(478, 231)
        Me.MinimumSize = New System.Drawing.Size(478, 231)
        Me.Name = "PengajuanStnkBpkb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PENGAJUAN STNK - BPKB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_no_rangka As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPPengajuan As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_bersih As System.Windows.Forms.Button
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents txt_status As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_cabang As System.Windows.Forms.TextBox
End Class
