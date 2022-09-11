<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataMaster2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataMaster2))
        Me.cb_cabang_pemilik = New System.Windows.Forms.ComboBox()
        Me.txt_nama_pemilik = New System.Windows.Forms.TextBox()
        Me.txt_tahun_buat = New System.Windows.Forms.TextBox()
        Me.txt_no_mesin = New System.Windows.Forms.TextBox()
        Me.ppd = New System.Windows.Forms.PrintPreviewDialog()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.cb_model = New System.Windows.Forms.ComboBox()
        Me.cb_jenis = New System.Windows.Forms.ComboBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_no_rangka = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_cetak = New System.Windows.Forms.Button()
        Me.btn_bersih = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.DGVMaster = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cb_posisi = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cb_cabang_pemilik
        '
        Me.cb_cabang_pemilik.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_cabang_pemilik.FormattingEnabled = True
        Me.cb_cabang_pemilik.Items.AddRange(New Object() {"TSO-Yos Sudarso (T002)", "TSO-BP Sunter (T004)", "TSO-Muara Karang (T008)", "TSO-Pluit (T009)", "TSO-CAO Sunter (T010)", "TSO-Kapuk (T012)", "TSO-BSD (T050)", "TSO-Daan Mogot (T052)", "TSO-BP BSD (T053)", "TSO-Puri Kembangan (T055)", "TSO-Bintaro (T058)", "TSO-Tangerang (T061)", "TSO-Serang (T062)", "TSO-Cikupa (T063)", "TSO-Alam Sutera (T064)", "TSO-BSD City (T066)", "TSO-Pasar Kemis (T067)", "TSO-Bekasi Timur (T100)", "TSO-Kramat Jati (T102)", "TSO-Kalimalang (T103)", "TSO-Kelapa Gading (T105)", "TSO-Bekasi Barat (T110)", "TSO-Cikarang (T111)", "TSO-Jatiasih (T120)", "TSO-Juanda (T151)", "TSO-Sudirman (T152)", "TSO-Garuda (T153)", "TSO-Cempaka Putih (T155)", "TSO-Jayakarta (T156)", "TSO-Pramuka (T158)", "TSO-Salemba (T160)", "TSO-Jakarta GSO (T162)", "TSO-Samanhudi (T165)", "TSO-Tebet (T205)", "TSO-Cilandak (T207)", "TSO-Radio Dalam (T209)", "TSO-Ciledug (T211)", "TSO-Tebet Sahardjo (T212)", "TSO-Lenteng Agung (T213)", "TSO-Krida (T215)", "TSO-Permata Hijau (T216)", "TSO-Bandung Asia Afrika (T250)", "TSO-Bandung Soekarno Hatta (T251)", "TSO-Bandung Pasteur (T252)", "TSO-BP Bandung Cibiru (T257)", "TSO-Bandung Setiabudi (T258)", "TSO-Bandung Cibiru (T259)", "TSO-Bogor Siliwangi (T260)", "TSO-Cirebon (T261)", "TSO-Karawang (T262)", "TSO-Cibinong (T264)", "TSO-BP Bogor Yasmin (T266)", "TSO-Indramayu (T269)", "TSO-Bandung Suci (T272)", "TSO-Purwakarta (T273)", "TSO-Rancaekek (T274)", "TSO-Sukabumi (T278)", "TSO-Dramaga Bogor (T279)", "TSO-Jatiwangi Majalengka (T281)", "TSO-Surabaya HR Mohammad (T450)", "TSO-Surabaya Basuki Rachmat (T452)", "TSO-Surabaya Waru (T453)", "TSO-Surabaya Pecindilan (T455)", "TSO-Surabaya Achmad Yani (T456)", "TSO-Surabaya Jemursari (T459)", "TSO-Surabaya Kertajaya (T461)", "TSO-Surabaya Kenjeran (T464)", "TSO-Tuban (T465)", "TSO-Surabaya Wiyung (T466)", "TSO-Malang (T470)", "TSO-Kediri Hasanudin (T471)", "TSO-Madiun (T472)", "TSO-Jember (T473)", "TSO-Probolinggo (T474)", "TSO-Malang Sukun (T477)", "TSO-Banyuwangi" & Global.Microsoft.VisualBasic.ChrW(9) & "T479", "TSO-Kediri Suharmaji (T480)", "TSO-MANYAR GRESIK (T483)", "TSO-Tulungagung (T484)", "TSO-Denpasar (T540)", "TSO-Sanur (T541)", "TSO-Gianyar (T545)", "TSO-Medan Sisingamangaraja (T560)", "TSO-Medan Gatot Subroto (T562)", "TSO-Medan Amplas (T566)", "TSO-Medan Krakatau (T568)", "TSO-Binjai (T569)", "TSO-Medan Pancing (T570)", "TSO-Medan Marelan (T571)", "TSO-Tanjung Morawa (T574)", "TSO-Padang (T580)", "TSO-Padang By Pass (T581)", "TSO-Bukit Tinggi (T584)", "TSO-Palembang Plaju (T600)", "TSO-Palembang Veteran (T601)", "TSO-Palembang Tanjung Api-api (T602)", "TSO-Tanjung Karang Raja Basa (T660)", "TSO-Tanjung Karang Raden Intan (T661)", "TSO-Lampung Way Halim (T663)", "TSO-Tulang Bawang (T664)", "TSO-Balikpapan Sudirman (T700)", "TSO-Balikpapan MT. Haryono (T701)", "TSO-Samarinda (T703)", "TSO-Bontang (T704)", "TSO-Tenggarong (T712)", "TSO-Supadio Pontianak (T720)", "TSO-Banjarmasin (T730)"})
        Me.cb_cabang_pemilik.Location = New System.Drawing.Point(162, 433)
        Me.cb_cabang_pemilik.Name = "cb_cabang_pemilik"
        Me.cb_cabang_pemilik.Size = New System.Drawing.Size(258, 27)
        Me.cb_cabang_pemilik.TabIndex = 64
        '
        'txt_nama_pemilik
        '
        Me.txt_nama_pemilik.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nama_pemilik.Location = New System.Drawing.Point(162, 398)
        Me.txt_nama_pemilik.MaxLength = 25
        Me.txt_nama_pemilik.Name = "txt_nama_pemilik"
        Me.txt_nama_pemilik.Size = New System.Drawing.Size(258, 26)
        Me.txt_nama_pemilik.TabIndex = 63
        '
        'txt_tahun_buat
        '
        Me.txt_tahun_buat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tahun_buat.Location = New System.Drawing.Point(162, 363)
        Me.txt_tahun_buat.MaxLength = 4
        Me.txt_tahun_buat.Name = "txt_tahun_buat"
        Me.txt_tahun_buat.Size = New System.Drawing.Size(73, 26)
        Me.txt_tahun_buat.TabIndex = 62
        '
        'txt_no_mesin
        '
        Me.txt_no_mesin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_no_mesin.Location = New System.Drawing.Point(162, 328)
        Me.txt_no_mesin.MaxLength = 10
        Me.txt_no_mesin.Name = "txt_no_mesin"
        Me.txt_no_mesin.Size = New System.Drawing.Size(137, 26)
        Me.txt_no_mesin.TabIndex = 61
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
        'txtstatus
        '
        Me.txtstatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstatus.Location = New System.Drawing.Point(338, 95)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(175, 26)
        Me.txtstatus.TabIndex = 59
        Me.txtstatus.Visible = False
        '
        'cb_model
        '
        Me.cb_model.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_model.FormattingEnabled = True
        Me.cb_model.Items.AddRange(New Object() {"JEEP", "MINIBUS", "ST. WAGON", "SEDAN", "DEREK", "CARRIER", "FORK LIFT", "MOBIL JENAZAH", "MOBIL AMBULAN", "MOBIL PEMADAM KEBAKARAN", "BUS GANDENG", "MICRO BUS", "BUS", "LIGHT TRUCK", "DUMP TRUCK", "BOX", "TRAILER", "DOUBLE CABIN", "TANGKI", "TRUCK", "DELIVER VAN", "PICK UP"})
        Me.cb_model.Location = New System.Drawing.Point(162, 290)
        Me.cb_model.Name = "cb_model"
        Me.cb_model.Size = New System.Drawing.Size(322, 27)
        Me.cb_model.TabIndex = 57
        '
        'cb_jenis
        '
        Me.cb_jenis.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_jenis.FormattingEnabled = True
        Me.cb_jenis.Items.AddRange(New Object() {"MOBIL PENUMPANG", "KENDARAAN KHUSUS", "MOBIL BUS", "MOBIL BARANG"})
        Me.cb_jenis.Location = New System.Drawing.Point(162, 255)
        Me.cb_jenis.Name = "cb_jenis"
        Me.cb_jenis.Size = New System.Drawing.Size(223, 27)
        Me.cb_jenis.TabIndex = 56
        '
        'txt_type
        '
        Me.txt_type.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_type.Location = New System.Drawing.Point(162, 218)
        Me.txt_type.MaxLength = 20
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(223, 26)
        Me.txt_type.TabIndex = 52
        '
        'txt_no_rangka
        '
        Me.txt_no_rangka.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_no_rangka.Location = New System.Drawing.Point(162, 180)
        Me.txt_no_rangka.MaxLength = 17
        Me.txt_no_rangka.Name = "txt_no_rangka"
        Me.txt_no_rangka.Size = New System.Drawing.Size(223, 26)
        Me.txt_no_rangka.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(39, 436)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 19)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Cabang Pemilik"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(39, 401)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 19)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Nama Pemilik"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(39, 366)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 19)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Tahun Buat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 19)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "No Mesin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 19)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Model"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 19)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Jenis"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 19)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 19)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "No Rangka"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox1.Location = New System.Drawing.Point(29, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(276, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'btn_cetak
        '
        Me.btn_cetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cetak.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cetak.Location = New System.Drawing.Point(334, 45)
        Me.btn_cetak.Name = "btn_cetak"
        Me.btn_cetak.Size = New System.Drawing.Size(179, 35)
        Me.btn_cetak.TabIndex = 65
        Me.btn_cetak.Text = "Print"
        Me.btn_cetak.UseVisualStyleBackColor = True
        '
        'btn_bersih
        '
        Me.btn_bersih.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_bersih.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bersih.Location = New System.Drawing.Point(43, 469)
        Me.btn_bersih.Name = "btn_bersih"
        Me.btn_bersih.Size = New System.Drawing.Size(86, 37)
        Me.btn_bersih.TabIndex = 66
        Me.btn_bersih.Text = "Bersih"
        Me.btn_bersih.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.Location = New System.Drawing.Point(135, 469)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(86, 37)
        Me.btn_simpan.TabIndex = 67
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_ubah
        '
        Me.btn_ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ubah.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ubah.Location = New System.Drawing.Point(227, 469)
        Me.btn_ubah.Name = "btn_ubah"
        Me.btn_ubah.Size = New System.Drawing.Size(86, 37)
        Me.btn_ubah.TabIndex = 68
        Me.btn_ubah.Text = "Ubah"
        Me.btn_ubah.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_hapus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hapus.Location = New System.Drawing.Point(319, 469)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(86, 37)
        Me.btn_hapus.TabIndex = 69
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_keluar
        '
        Me.btn_keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_keluar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Location = New System.Drawing.Point(411, 469)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(86, 37)
        Me.btn_keluar.TabIndex = 70
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'DGVMaster
        '
        Me.DGVMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMaster.Location = New System.Drawing.Point(339, 127)
        Me.DGVMaster.Name = "DGVMaster"
        Me.DGVMaster.Size = New System.Drawing.Size(54, 27)
        Me.DGVMaster.TabIndex = 71
        Me.DGVMaster.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox2.Location = New System.Drawing.Point(29, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(276, 137)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 73
        Me.PictureBox2.TabStop = False
        '
        'cb_posisi
        '
        Me.cb_posisi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_posisi.FormattingEnabled = True
        Me.cb_posisi.Items.AddRange(New Object() {"Atas Kanan", "Atas Kiri", "Tengah Kanan", "Tengah Kiri", "Bawah Kanan", "Bawah Kiri"})
        Me.cb_posisi.Location = New System.Drawing.Point(384, 12)
        Me.cb_posisi.Name = "cb_posisi"
        Me.cb_posisi.Size = New System.Drawing.Size(129, 27)
        Me.cb_posisi.TabIndex = 74
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(330, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 19)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Posisi "
        '
        'DataMaster2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 515)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cb_posisi)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DGVMaster)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_ubah)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.btn_bersih)
        Me.Controls.Add(Me.btn_cetak)
        Me.Controls.Add(Me.cb_cabang_pemilik)
        Me.Controls.Add(Me.txt_nama_pemilik)
        Me.Controls.Add(Me.txt_tahun_buat)
        Me.Controls.Add(Me.txt_no_mesin)
        Me.Controls.Add(Me.txtstatus)
        Me.Controls.Add(Me.cb_model)
        Me.Controls.Add(Me.cb_jenis)
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
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DataMaster2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Master"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cb_cabang_pemilik As System.Windows.Forms.ComboBox
    Friend WithEvents txt_nama_pemilik As System.Windows.Forms.TextBox
    Friend WithEvents txt_tahun_buat As System.Windows.Forms.TextBox
    Friend WithEvents txt_no_mesin As System.Windows.Forms.TextBox
    Friend WithEvents ppd As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents txtstatus As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cb_model As System.Windows.Forms.ComboBox
    Friend WithEvents cb_jenis As System.Windows.Forms.ComboBox
    Friend WithEvents txt_type As System.Windows.Forms.TextBox
    Friend WithEvents txt_no_rangka As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_cetak As System.Windows.Forms.Button
    Friend WithEvents btn_bersih As System.Windows.Forms.Button
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents btn_ubah As System.Windows.Forms.Button
    Friend WithEvents btn_hapus As System.Windows.Forms.Button
    Friend WithEvents btn_keluar As System.Windows.Forms.Button
    Friend WithEvents DGVMaster As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents cb_posisi As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
