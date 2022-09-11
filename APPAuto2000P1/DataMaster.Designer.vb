<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataMaster))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_no_rangka = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.cb_jenis = New System.Windows.Forms.ComboBox()
        Me.cb_model = New System.Windows.Forms.ComboBox()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ppd = New System.Windows.Forms.PrintPreviewDialog()
        Me.txt_no_mesin = New System.Windows.Forms.TextBox()
        Me.txt_tahun_buat = New System.Windows.Forms.TextBox()
        Me.txt_nama_pemilik = New System.Windows.Forms.TextBox()
        Me.cb_cabang_pemilik = New System.Windows.Forms.ComboBox()
        Me.btn_bersih = New System.Windows.Forms.Button()
        Me.DGVMaster = New System.Windows.Forms.DataGridView()
        Me.btn_cetak = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DGVMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "No Rangka"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Jenis"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Model"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "No Mesin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 19)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Tahun Buat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 19)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Cabang Pemilik"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 19)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Nama Pemilik"
        '
        'txt_no_rangka
        '
        Me.txt_no_rangka.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_no_rangka.Location = New System.Drawing.Point(145, 12)
        Me.txt_no_rangka.Name = "txt_no_rangka"
        Me.txt_no_rangka.Size = New System.Drawing.Size(201, 26)
        Me.txt_no_rangka.TabIndex = 11
        '
        'txt_type
        '
        Me.txt_type.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_type.Location = New System.Drawing.Point(145, 50)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(201, 26)
        Me.txt_type.TabIndex = 12
        '
        'btn_simpan
        '
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.Location = New System.Drawing.Point(118, 300)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(86, 37)
        Me.btn_simpan.TabIndex = 20
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_hapus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hapus.Location = New System.Drawing.Point(302, 300)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(86, 37)
        Me.btn_hapus.TabIndex = 21
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_ubah
        '
        Me.btn_ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ubah.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ubah.Location = New System.Drawing.Point(210, 300)
        Me.btn_ubah.Name = "btn_ubah"
        Me.btn_ubah.Size = New System.Drawing.Size(86, 37)
        Me.btn_ubah.TabIndex = 22
        Me.btn_ubah.Text = "Ubah"
        Me.btn_ubah.UseVisualStyleBackColor = True
        '
        'cb_jenis
        '
        Me.cb_jenis.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_jenis.FormattingEnabled = True
        Me.cb_jenis.Location = New System.Drawing.Point(145, 87)
        Me.cb_jenis.Name = "cb_jenis"
        Me.cb_jenis.Size = New System.Drawing.Size(201, 27)
        Me.cb_jenis.TabIndex = 24
        '
        'cb_model
        '
        Me.cb_model.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_model.FormattingEnabled = True
        Me.cb_model.Location = New System.Drawing.Point(145, 122)
        Me.cb_model.Name = "cb_model"
        Me.cb_model.Size = New System.Drawing.Size(201, 27)
        Me.cb_model.TabIndex = 25
        '
        'txtstatus
        '
        Me.txtstatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstatus.Location = New System.Drawing.Point(406, 160)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(175, 26)
        Me.txtstatus.TabIndex = 33
        Me.txtstatus.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(357, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 19)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "status"
        Me.Label9.Visible = False
        '
        'ppd
        '
        Me.ppd.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ppd.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ppd.ClientSize = New System.Drawing.Size(400, 300)
        Me.ppd.Enabled = True
        Me.ppd.Icon = CType(resources.GetObject("ppd.Icon"), System.Drawing.Icon)
        Me.ppd.Name = "ppd"
        Me.ppd.Visible = False
        '
        'txt_no_mesin
        '
        Me.txt_no_mesin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_no_mesin.Location = New System.Drawing.Point(145, 160)
        Me.txt_no_mesin.Name = "txt_no_mesin"
        Me.txt_no_mesin.Size = New System.Drawing.Size(201, 26)
        Me.txt_no_mesin.TabIndex = 35
        '
        'txt_tahun_buat
        '
        Me.txt_tahun_buat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tahun_buat.Location = New System.Drawing.Point(145, 195)
        Me.txt_tahun_buat.Name = "txt_tahun_buat"
        Me.txt_tahun_buat.Size = New System.Drawing.Size(201, 26)
        Me.txt_tahun_buat.TabIndex = 36
        '
        'txt_nama_pemilik
        '
        Me.txt_nama_pemilik.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nama_pemilik.Location = New System.Drawing.Point(145, 230)
        Me.txt_nama_pemilik.Name = "txt_nama_pemilik"
        Me.txt_nama_pemilik.Size = New System.Drawing.Size(201, 26)
        Me.txt_nama_pemilik.TabIndex = 37
        '
        'cb_cabang_pemilik
        '
        Me.cb_cabang_pemilik.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_cabang_pemilik.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cabang_pemilik.FormattingEnabled = True
        Me.cb_cabang_pemilik.Items.AddRange(New Object() {"TSO-Yos Sudarso (T002)", "TSO-BP Sunter (T004)", "TSO-Muara Karang (T008)", "TSO-Pluit (T009)", "TSO-CAO Sunter (T010)", "TSO-Kapuk (T012)", "TSO-BSD (T050)", "TSO-Daan Mogot (T052)", "TSO-BP BSD (T053)", "TSO-Puri Kembangan (T055)", "TSO-Bintaro (T058)", "TSO-Tangerang (T061)", "TSO-Serang (T062)", "TSO-Cikupa (T063)", "TSO-Alam Sutera (T064)", "TSO-BSD City (T066)", "TSO-Pasar Kemis (T067)", "TSO-Bekasi Timur (T100)", "TSO-Kramat Jati (T102)", "TSO-Kalimalang (T103)", "TSO-Kelapa Gading (T105)", "TSO-Bekasi Barat (T110)", "TSO-Cikarang (T111)", "TSO-Jatiasih (T120)", "TSO-Juanda (T151)", "TSO-Sudirman (T152)", "TSO-Garuda (T153)", "TSO-Cempaka Putih (T155)", "TSO-Jayakarta (T156)", "TSO-Pramuka (T158)", "TSO-Salemba (T160)", "TSO-Jakarta GSO (T162)", "TSO-Samanhudi (T165)", "TSO-Tebet (T205)", "TSO-Cilandak (T207)", "TSO-Radio Dalam (T209)", "TSO-Ciledug (T211)", "TSO-Tebet Sahardjo (T212)", "TSO-Lenteng Agung (T213)", "TSO-Krida (T215)", "TSO-Permata Hijau (T216)", "TSO-Bandung Asia Afrika (T250)", "TSO-Bandung Soekarno Hatta (T251)", "TSO-Bandung Pasteur (T252)", "TSO-BP Bandung Cibiru (T257)", "TSO-Bandung Setiabudi (T258)", "TSO-Bandung Cibiru (T259)", "TSO-Bogor Siliwangi (T260)", "TSO-Cirebon (T261)", "TSO-Karawang (T262)", "TSO-Cibinong (T264)", "TSO-BP Bogor Yasmin (T266)", "TSO-Indramayu (T269)", "TSO-Bandung Suci (T272)", "TSO-Purwakarta (T273)", "TSO-Rancaekek (T274)", "TSO-Sukabumi (T278)", "TSO-Dramaga Bogor (T279)", "TSO-Jatiwangi Majalengka (T281)", "TSO-Surabaya HR Mohammad (T450)", "TSO-Surabaya Basuki Rachmat (T452)", "TSO-Surabaya Waru (T453)", "TSO-Surabaya Pecindilan (T455)", "TSO-Surabaya Achmad Yani (T456)", "TSO-Surabaya Jemursari (T459)", "TSO-Surabaya Kertajaya (T461)", "TSO-Surabaya Kenjeran (T464)", "TSO-Tuban (T465)", "TSO-Surabaya Wiyung (T466)", "TSO-Malang (T470)", "TSO-Kediri Hasanudin (T471)", "TSO-Madiun (T472)", "TSO-Jember (T473)", "TSO-Probolinggo (T474)", "TSO-Malang Sukun (T477)", "TSO-Banyuwangi" & Global.Microsoft.VisualBasic.ChrW(9) & "T479", "TSO-Kediri Suharmaji (T480)", "TSO-MANYAR GRESIK (T483)", "TSO-Tulungagung (T484)", "TSO-Denpasar (T540)", "TSO-Sanur (T541)", "TSO-Gianyar (T545)", "TSO-Medan Sisingamangaraja (T560)", "TSO-Medan Gatot Subroto (T562)", "TSO-Medan Amplas (T566)", "TSO-Medan Krakatau (T568)", "TSO-Binjai (T569)", "TSO-Medan Pancing (T570)", "TSO-Medan Marelan (T571)", "TSO-Tanjung Morawa (T574)", "TSO-Padang (T580)", "TSO-Padang By Pass (T581)", "TSO-Bukit Tinggi (T584)", "TSO-Palembang Plaju (T600)", "TSO-Palembang Veteran (T601)", "TSO-Palembang Tanjung Api-api (T602)", "TSO-Tanjung Karang Raja Basa (T660)", "TSO-Tanjung Karang Raden Intan (T661)", "TSO-Lampung Way Halim (T663)", "TSO-Tulang Bawang (T664)", "TSO-Balikpapan Sudirman (T700)", "TSO-Balikpapan MT. Haryono (T701)", "TSO-Samarinda (T703)", "TSO-Bontang (T704)", "TSO-Supadio Pontianak (T720)", "TSO-Banjarmasin (T730)"})
        Me.cb_cabang_pemilik.Location = New System.Drawing.Point(145, 265)
        Me.cb_cabang_pemilik.Name = "cb_cabang_pemilik"
        Me.cb_cabang_pemilik.Size = New System.Drawing.Size(201, 27)
        Me.cb_cabang_pemilik.TabIndex = 38
        '
        'btn_bersih
        '
        Me.btn_bersih.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_bersih.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bersih.Location = New System.Drawing.Point(25, 300)
        Me.btn_bersih.Name = "btn_bersih"
        Me.btn_bersih.Size = New System.Drawing.Size(86, 37)
        Me.btn_bersih.TabIndex = 39
        Me.btn_bersih.Text = "Bersih"
        Me.btn_bersih.UseVisualStyleBackColor = True
        '
        'DGVMaster
        '
        Me.DGVMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMaster.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGVMaster.Location = New System.Drawing.Point(0, 343)
        Me.DGVMaster.Name = "DGVMaster"
        Me.DGVMaster.Size = New System.Drawing.Size(603, 207)
        Me.DGVMaster.TabIndex = 41
        '
        'btn_cetak
        '
        Me.btn_cetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cetak.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cetak.Location = New System.Drawing.Point(406, 120)
        Me.btn_cetak.Name = "btn_cetak"
        Me.btn_cetak.Size = New System.Drawing.Size(140, 37)
        Me.btn_cetak.TabIndex = 42
        Me.btn_cetak.Text = "Print"
        Me.btn_cetak.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox1.Location = New System.Drawing.Point(361, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'DataMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 550)
        Me.Controls.Add(Me.btn_cetak)
        Me.Controls.Add(Me.DGVMaster)
        Me.Controls.Add(Me.btn_bersih)
        Me.Controls.Add(Me.cb_cabang_pemilik)
        Me.Controls.Add(Me.txt_nama_pemilik)
        Me.Controls.Add(Me.txt_tahun_buat)
        Me.Controls.Add(Me.txt_no_mesin)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtstatus)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cb_model)
        Me.Controls.Add(Me.cb_jenis)
        Me.Controls.Add(Me.btn_ubah)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.txt_no_rangka)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DataMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataMaster"
        CType(Me.DGVMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_no_rangka As System.Windows.Forms.TextBox
    Friend WithEvents txt_type As System.Windows.Forms.TextBox
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents btn_hapus As System.Windows.Forms.Button
    Friend WithEvents btn_ubah As System.Windows.Forms.Button
    Friend WithEvents cb_jenis As System.Windows.Forms.ComboBox
    Friend WithEvents cb_model As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtstatus As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ppd As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents txt_no_mesin As System.Windows.Forms.TextBox
    Friend WithEvents txt_tahun_buat As System.Windows.Forms.TextBox
    Friend WithEvents txt_nama_pemilik As System.Windows.Forms.TextBox
    Friend WithEvents cb_cabang_pemilik As System.Windows.Forms.ComboBox
    Friend WithEvents btn_bersih As System.Windows.Forms.Button
    Friend WithEvents DGVMaster As System.Windows.Forms.DataGridView
    Friend WithEvents btn_cetak As System.Windows.Forms.Button
End Class
