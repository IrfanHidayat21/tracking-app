<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Cek_Status
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
        Me.DGVMaster2 = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_pencarian = New System.Windows.Forms.TextBox()
        Me.cb_status = New System.Windows.Forms.ComboBox()
        CType(Me.DGVMaster2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVMaster2
        '
        Me.DGVMaster2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMaster2.Enabled = False
        Me.DGVMaster2.Location = New System.Drawing.Point(12, 55)
        Me.DGVMaster2.Name = "DGVMaster2"
        Me.DGVMaster2.Size = New System.Drawing.Size(943, 363)
        Me.DGVMaster2.TabIndex = 73
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(361, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 19)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "STATUS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 19)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "PENCARIAN"
        '
        'txt_pencarian
        '
        Me.txt_pencarian.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pencarian.Location = New System.Drawing.Point(113, 17)
        Me.txt_pencarian.MaxLength = 17
        Me.txt_pencarian.Name = "txt_pencarian"
        Me.txt_pencarian.Size = New System.Drawing.Size(223, 26)
        Me.txt_pencarian.TabIndex = 77
        '
        'cb_status
        '
        Me.cb_status.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_status.FormattingEnabled = True
        Me.cb_status.Items.AddRange(New Object() {"Belum Diajukan", "Pengajuan", "STNK SELESAI", "BPKB SELESAI", "Penyerahan STNK", "Penyerahan BPKB", "SEMUA"})
        Me.cb_status.Location = New System.Drawing.Point(431, 17)
        Me.cb_status.Name = "cb_status"
        Me.cb_status.Size = New System.Drawing.Size(196, 27)
        Me.cb_status.TabIndex = 78
        '
        'Form_Cek_Status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 430)
        Me.Controls.Add(Me.cb_status)
        Me.Controls.Add(Me.txt_pencarian)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DGVMaster2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_Cek_Status"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cek Data"
        CType(Me.DGVMaster2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVMaster2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_pencarian As System.Windows.Forms.TextBox
    Friend WithEvents cb_status As System.Windows.Forms.ComboBox
End Class
