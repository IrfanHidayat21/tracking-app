<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bpkb_selesai
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
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DTPBPKB = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_no_rangka = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_bersih = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(294, 70)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(105, 26)
        Me.DateTimePicker2.TabIndex = 47
        '
        'DTPBPKB
        '
        Me.DTPBPKB.Enabled = False
        Me.DTPBPKB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPBPKB.Location = New System.Drawing.Point(151, 38)
        Me.DTPBPKB.Name = "DTPBPKB"
        Me.DTPBPKB.Size = New System.Drawing.Size(248, 26)
        Me.DTPBPKB.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 38)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Tanggal dan Waktu " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BPKB Selesai"
        '
        'txt_no_rangka
        '
        Me.txt_no_rangka.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_no_rangka.Location = New System.Drawing.Point(151, 6)
        Me.txt_no_rangka.MaxLength = 17
        Me.txt_no_rangka.Name = "txt_no_rangka"
        Me.txt_no_rangka.Size = New System.Drawing.Size(248, 26)
        Me.txt_no_rangka.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "No Rangka"
        '
        'btn_simpan
        '
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.Location = New System.Drawing.Point(16, 102)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(86, 37)
        Me.btn_simpan.TabIndex = 40
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Label 3"
        Me.Label3.Visible = False
        '
        'btn_bersih
        '
        Me.btn_bersih.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_bersih.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.btn_bersih.Location = New System.Drawing.Point(306, 103)
        Me.btn_bersih.Name = "btn_bersih"
        Me.btn_bersih.Size = New System.Drawing.Size(93, 37)
        Me.btn_bersih.TabIndex = 53
        Me.btn_bersih.Text = "Bersih"
        Me.btn_bersih.UseVisualStyleBackColor = True
        '
        'bpkb_selesai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 152)
        Me.Controls.Add(Me.btn_bersih)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DTPBPKB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_no_rangka)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_simpan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(433, 186)
        Me.MinimumSize = New System.Drawing.Size(433, 186)
        Me.Name = "bpkb_selesai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BPKB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPBPKB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_no_rangka As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_bersih As System.Windows.Forms.Button
End Class
