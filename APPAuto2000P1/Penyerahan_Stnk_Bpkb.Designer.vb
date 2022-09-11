<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penyerahan_Stnk_Bpkb
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
        Me.txt_cabang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTPpenyerahanstnk = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_bersih = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.txt_no_rangka = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTPpenyerahanbpkb = New System.Windows.Forms.DateTimePicker()
        Me.btn_simpan2 = New System.Windows.Forms.Button()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_cabang
        '
        Me.txt_cabang.Enabled = False
        Me.txt_cabang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cabang.Location = New System.Drawing.Point(204, 108)
        Me.txt_cabang.Name = "txt_cabang"
        Me.txt_cabang.Size = New System.Drawing.Size(248, 26)
        Me.txt_cabang.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 19)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Cabang Pemilik"
        '
        'DTPpenyerahanstnk
        '
        Me.DTPpenyerahanstnk.Enabled = False
        Me.DTPpenyerahanstnk.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPpenyerahanstnk.Location = New System.Drawing.Point(204, 44)
        Me.DTPpenyerahanstnk.Name = "DTPpenyerahanstnk"
        Me.DTPpenyerahanstnk.Size = New System.Drawing.Size(248, 26)
        Me.DTPpenyerahanstnk.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 19)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Tanggal Penyerahan STNK"
        '
        'btn_bersih
        '
        Me.btn_bersih.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_bersih.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bersih.Location = New System.Drawing.Point(366, 140)
        Me.btn_bersih.Name = "btn_bersih"
        Me.btn_bersih.Size = New System.Drawing.Size(86, 55)
        Me.btn_bersih.TabIndex = 59
        Me.btn_bersih.Text = "Bersih"
        Me.btn_bersih.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.Location = New System.Drawing.Point(15, 140)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(100, 55)
        Me.btn_simpan.TabIndex = 58
        Me.btn_simpan.Text = "Penyerahan STNK"
        Me.btn_simpan.UseVisualStyleBackColor = True
        Me.btn_simpan.Visible = False
        '
        'txt_no_rangka
        '
        Me.txt_no_rangka.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_no_rangka.Location = New System.Drawing.Point(204, 12)
        Me.txt_no_rangka.MaxLength = 17
        Me.txt_no_rangka.Name = "txt_no_rangka"
        Me.txt_no_rangka.Size = New System.Drawing.Size(248, 26)
        Me.txt_no_rangka.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 19)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "No Rangka"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 19)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Tanggal Penyerahan BPKB"
        '
        'DTPpenyerahanbpkb
        '
        Me.DTPpenyerahanbpkb.Enabled = False
        Me.DTPpenyerahanbpkb.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPpenyerahanbpkb.Location = New System.Drawing.Point(204, 76)
        Me.DTPpenyerahanbpkb.Name = "DTPpenyerahanbpkb"
        Me.DTPpenyerahanbpkb.Size = New System.Drawing.Size(248, 26)
        Me.DTPpenyerahanbpkb.TabIndex = 67
        '
        'btn_simpan2
        '
        Me.btn_simpan2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan2.Location = New System.Drawing.Point(121, 140)
        Me.btn_simpan2.Name = "btn_simpan2"
        Me.btn_simpan2.Size = New System.Drawing.Size(100, 55)
        Me.btn_simpan2.TabIndex = 70
        Me.btn_simpan2.Text = "Penyerahan BPKB"
        Me.btn_simpan2.UseVisualStyleBackColor = True
        Me.btn_simpan2.Visible = False
        '
        'txtstatus
        '
        Me.txtstatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstatus.Location = New System.Drawing.Point(300, 145)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(60, 26)
        Me.txtstatus.TabIndex = 72
        Me.txtstatus.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(248, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 19)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Status"
        Me.Label5.Visible = False
        '
        'Penyerahan_Stnk_Bpkb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 203)
        Me.Controls.Add(Me.txtstatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_simpan2)
        Me.Controls.Add(Me.DTPpenyerahanbpkb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_cabang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DTPpenyerahanstnk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_bersih)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.txt_no_rangka)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(484, 237)
        Me.MinimumSize = New System.Drawing.Size(484, 237)
        Me.Name = "Penyerahan_Stnk_Bpkb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PENYERAHAN STNK-BPKB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_cabang As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTPpenyerahanstnk As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_bersih As System.Windows.Forms.Button
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents txt_no_rangka As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DTPpenyerahanbpkb As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_simpan2 As System.Windows.Forms.Button
    Friend WithEvents txtstatus As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
