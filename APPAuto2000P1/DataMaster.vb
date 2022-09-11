Imports System.Data.Odbc

Public Class DataMaster
    Private WithEvents DocToPrint As New Printing.PrintDocument
    Public NumEtiqsPorFila As Integer

    Const dsn_odbc = "Driver={MySQL ODBC 3.51 Driver};database=dbauto_2000;server=localhost;uid=root"
    Dim MysqlConn As OdbcConnection
    Dim cmd As OdbcCommand
    Dim da As OdbcDataAdapter
    Dim reader As OdbcDataReader
    Dim dbDataSet As DataSet
    Dim table As DataTable

    
    Sub koneksi()
        MysqlConn = New OdbcConnection(dsn_odbc)
    End Sub



    'Private Sub btnsimpangambar_Click(sender As Object, e As EventArgs) Handles btnsimpangambar.Click
    '    Dim SD As New SaveFileDialog
    '    SD.Filter = "PNG File|*.png" '
    '    If SD.ShowDialog() = DialogResult.OK Then
    '        Try
    '            PictureBox1.Image.Save(SD.FileName, Imaging.ImageFormat.Png)
    '        Catch ex As Exception

    '        End Try
    '    End If
    'End Sub

    'Private Sub BtnGenerate_Click(sender As Object, e As EventArgs) Handles BtnGenerate.Click
    '    Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
    '    Generator.IncludeLabel = True  ' pengaturan label di scanner
    '    Generator.CustomLabel = txt_no_rangka.Text ' pengaturan label di scanner
    '    Try
    '        PictureBox1.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code39, txt_no_rangka.Text))
    '    Catch ex As Exception

    '    End Try
    'End Sub
    Sub bersih2()
        txt_type.Text = ""
        cb_jenis.Text = ""
        cb_model.Text = ""
        txt_no_mesin.Text = ""
        txt_nama_pemilik.Text = ""
        txt_tahun_buat.Text = ""
        cb_cabang_pemilik.Text = ""
        txtstatus.Text = ""
    End Sub
    Sub bersih()
        txt_no_rangka.Text = ""
        txt_type.Text = ""
        cb_jenis.Text = ""
        cb_model.Text = ""
        txt_no_mesin.Text = ""
        txt_nama_pemilik.Text = ""
        txt_tahun_buat.Text = ""
        cb_cabang_pemilik.Text = ""
        txtstatus.Text = ""

    End Sub
    Sub validasi_data()
        koneksi()
        MysqlConn.Open()
        cmd = New OdbcCommand("Select No_Rangka from tbl_master_stnkbpkb where No_Rangka = '" & txt_no_rangka.Text & "'", MysqlConn)
        reader = cmd.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            MsgBox("Maaf Nomor Rangka Sudah Ada dan Tidak Boleh Sama!", vbInformation, "Maaf")
            txt_no_rangka.Focus()
            Exit Sub
        Else
            simpan_data_master()
        End If
    End Sub

    Sub simpan_data_master()
        koneksi()
        If txt_no_rangka.Text = "" Then
            MsgBox("Nomor Rangka Masih Kosong", vbInformation, "Maaf")
            txt_no_rangka.Focus()
        ElseIf txt_type.Text = "" Then
            MsgBox("Type Masih Kosong", vbInformation, "Maaf")
            txt_type.Focus()
        ElseIf cb_jenis.Text = "" Then
            MsgBox("Jenis Masih Kosong", vbInformation, "Maaf")
            cb_jenis.Focus()
        ElseIf cb_model.Text = "" Then
            MsgBox("Model Masih Kosong", vbInformation, "Maaf")
            cb_model.Focus()
        ElseIf txt_no_mesin.Text = "" Then
            MsgBox("Nomor Mesin Masih Kosong", vbInformation, "Maaf")
            txt_no_mesin.Focus()
        ElseIf txt_nama_pemilik.Text = "" Then
            MsgBox("Nama Pemilik Masih Kosong", vbInformation, "Maaf")
            txt_nama_pemilik.Focus()
        ElseIf txt_tahun_buat.Text = "" Then
            MsgBox("Tahun Buat Masih Kosong", vbInformation, "Maaf")
            txt_tahun_buat.Focus()
        ElseIf cb_cabang_pemilik.Text = "" Then
            MsgBox("Cabang Pemilik Masih Kosong", vbInformation, "Maaf")
            cb_cabang_pemilik.Focus()
        Else
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "insert into tbl_master_stnkbpkb (No_Rangka,Type,Jenis,Model,No_Mesin,Tahun_Buat,Nama_Pemilik,Cabang_Pemilik,Status)  values ('" & txt_no_rangka.Text & "','" & txt_type.Text & "','" & cb_jenis.Text & "','" & cb_model.Text & "','" & txt_no_mesin.Text & "','" & txt_tahun_buat.Text & "','" & txt_nama_pemilik.Text & "','" & cb_cabang_pemilik.Text & "','" & txtstatus.Text & "')"
                cmd = New OdbcCommand(Query, MysqlConn)
                reader = cmd.ExecuteReader
                MessageBox.Show("Data Saved")
                MysqlConn.Close()
            Catch ex As Exception
            End Try
            refresh_table()
          
            '  btn_ubah.Enabled = True
            '   btn_hapus.Enabled = True
            '   btn_simpan.Enabled = False
            '   btn_tambah.Enabled = True

           
        End If
    End Sub
    Private Sub refresh_table()
        koneksi()
        Dim SDA As New OdbcDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from tbl_master_stnkbpkb"
            cmd = New OdbcCommand(Query, MysqlConn)
            SDA.SelectCommand = cmd
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DGVMaster.DataSource = bSource
            SDA.Update(dbDataSet)
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub btn_tambah_Click(sender As Object, e As EventArgs)

        Call bersih()
        PictureBox1.Visible = False
    End Sub
    Public Sub HanyaAngka(e As KeyPressEventArgs)
        Dim tombol As Integer = Asc(e.KeyChar)
        If Not (((tombol >= 48) And (tombol <= 57)) Or (tombol = 8) Or (tombol = 47)) Then
            e.Handled = True
        End If
    End Sub
    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        Dim tombol As Integer = Asc(e.KeyChar)
        If Not (((tombol >= 65) And (tombol <= 90)) Or ((tombol >= 97) And (tombol <= 122)) Or (tombol = 8) Or (tombol = 32) Or (tombol = 46)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub DataMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_table()
        btn_simpan.Visible = False
        btn_ubah.Visible = False
        btn_hapus.Visible = False
        PictureBox1.Visible = False
        btn_cetak.Visible = False
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        txtstatus.Text = "Belum Diajukan"
        validasi_data()


        Call bersih()
    End Sub
    Sub validasi_data2()
        koneksi()
        MysqlConn.Open()
        cmd = New OdbcCommand("Select No_Rangka from tbl_master_stnkbpkb where No_Rangka = '" & txt_no_rangka.Text & "'", MysqlConn)
        reader = cmd.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            ubah_data_master()
        Else
            MsgBox("Nomor Rangka Tidak Tersedia atau Tidak Boleh Diubah", vbInformation, "Maaf")
            txt_no_rangka.Focus()
            Exit Sub
        End If
    End Sub

    Sub ubah_data_master()
        koneksi()
        If txt_no_rangka.Text = "" Then
            MsgBox("Nomor Rangka Masih Kosong", vbInformation, "Maaf")
            txt_no_rangka.Focus()
        ElseIf txt_type.Text = "" Then
            MsgBox("Type Masih Kosong", vbInformation, "Maaf")
            txt_type.Focus()
        ElseIf cb_jenis.Text = "" Then
            MsgBox("Jenis Masih Kosong", vbInformation, "Maaf")
            cb_jenis.Focus()
        ElseIf cb_model.Text = "" Then
            MsgBox("Model Masih Kosong", vbInformation, "Maaf")
            cb_model.Focus()
        ElseIf txt_no_mesin.Text = "" Then
            MsgBox("Nomor Mesin Masih Kosong", vbInformation, "Maaf")
            txt_no_mesin.Focus()
        ElseIf txt_nama_pemilik.Text = "" Then
            MsgBox("Nama Pemilik Masih Kosong", vbInformation, "Maaf")
            txt_nama_pemilik.Focus()
        ElseIf txt_tahun_buat.Text = "" Then
            MsgBox("Tahun Buat Masih Kosong", vbInformation, "Maaf")
            txt_tahun_buat.Focus()
        ElseIf cb_cabang_pemilik.Text = "" Then
            MsgBox("Cabang Pemilik Masih Kosong", vbInformation, "Maaf")
            cb_cabang_pemilik.Focus()
        Else
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "update tbl_master_stnkbpkb set No_Rangka='" & txt_no_rangka.Text & "',Type='" & txt_type.Text & "',Jenis='" & cb_jenis.Text & "',model='" & cb_model.Text & "',no_mesin='" & txt_no_mesin.Text & "',Tahun_Buat='" & txt_tahun_buat.Text & "',Nama_Pemilik='" & txt_nama_pemilik.Text & "',Cabang_Pemilik='" & cb_cabang_pemilik.Text & "' where No_Rangka='" & txt_no_rangka.Text & "'"
                cmd = New OdbcCommand(Query, MysqlConn)
                reader = cmd.ExecuteReader
                MessageBox.Show("Data Update")
                MysqlConn.Close()
            Catch ex As Exception

            End Try
            refresh_table()


        End If
    End Sub
    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        validasi_data2()

    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        koneksi()
        If txt_no_rangka.Text = "" Then
            MsgBox("Nomor Rangka Masih Kosong", vbInformation, "Maaf")
            txt_no_rangka.Focus()
        Else
            If MsgBox("Ingin menghapus data ini?", MsgBoxStyle.YesNo, "Peringatan") = MsgBoxResult.Yes Then
                Try
                    MysqlConn.Open()
                    Dim Query As String
                    Query = "Delete from tbl_master_stnkbpkb where No_Rangka='" & txt_no_rangka.Text & "'"
                    cmd = New OdbcCommand(Query, MysqlConn)
                    reader = cmd.ExecuteReader
                    MessageBox.Show("Data Deleted")
                    MysqlConn.Close()
                    refresh_table()
                    bersih()
                Catch ex As Exception
                End Try
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btn_cetak_Click(sender As Object, e As EventArgs)
        Dim frm As Form = DirectCast(ppd, Form)
        frm.WindowState = FormWindowState.Maximized
        frm.Icon = Me.Icon

        ppd.PrintPreviewControl.Zoom = 0.75
        ppd.Document = DocToPrint
        '  ppd.Document.DefaultPageSettings.Landscape = CBool(chOrientacion.Checked)
        DirectCast((CetakBarcode.ppd.Controls(1)), ToolStrip).Items.RemoveAt(0)
        ppd.ShowDialog()
    End Sub

    Private Sub docToPrint_PrintPage(ByVal sender As Object, _
  ByVal e As System.Drawing.Printing.PrintPageEventArgs) _
      Handles DocToPrint.PrintPage
        On Error Resume Next
        Dim i As Integer
        Dim vSepPrev As Integer = 290
        Dim vMargSup As Integer = 9


        Dim font12 = New Font("Times New Roman", 12, FontStyle.Bold)

        For i = 1 To 1


            '            e.Graphics.DrawImage(pic.Image, 10, 10)
            e.Graphics.DrawImage(PictureBox1.Image, vSepPrev, vMargSup)
            vSepPrev = vSepPrev + 130

            e.Graphics.DrawString("Type   : ", font12, Brushes.Black, New Rectangle(80, 200, 80, 80))
            e.Graphics.DrawString(txt_type.Text, font12, Brushes.Black, New Rectangle(140, 200, 80, 80))

            e.Graphics.DrawString("Model : ", font12, Brushes.Black, New Rectangle(80, 230, 80, 80))
            e.Graphics.DrawString(cb_model.Text, font12, Brushes.Black, New Rectangle(140, 230, 80, 80))




        Next

    End Sub

    Private Sub txt_no_rangka_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_no_rangka.KeyPress
        HanyaAngka(e)
        ' HanyaHuruf(e)
    End Sub

    Private Sub txt_no_rangka_TextChanged(sender As Object, e As EventArgs) Handles txt_no_rangka.TextChanged
        koneksi()
        Try
            MysqlConn.Open()


            Dim Query As String

            Query = "SELECT  No_Rangka,Type,Jenis,Model,No_Mesin,Tahun_Buat,Nama_Pemilik,Cabang_Pemilik FROM tbl_master_stnkbpkb  WHERE No_Rangka ='" & txt_no_rangka.Text & "'"
            cmd = New OdbcCommand(Query, MysqlConn)
            reader = cmd.ExecuteReader
            If reader.Read Then
                PictureBox1.Visible = True
                btn_cetak.Visible = True
                btn_simpan.Visible = False
                btn_ubah.Visible = True
                btn_hapus.Visible = True
                txt_type.Text = reader(1).ToString
                cb_jenis.Text = reader(2).ToString

                cb_model.Text = reader(3).ToString
                txt_no_mesin.Text = reader(4).ToString
                txt_tahun_buat.Text = reader(5).ToString

                txt_nama_pemilik.Text = reader(6).ToString
                cb_cabang_pemilik.Text = reader(7).ToString
                txtstatus.Text = reader(8).ToString
                If reader(8).ToString = "" Then
                    txtstatus.Text = "Belum Di Ajukan"
                End If


            Else


                txt_no_rangka.Focus()
                bersih2()
                btn_simpan.Visible = True
                btn_ubah.Visible = False
                btn_hapus.Visible = False
                If txt_no_rangka.Text = "" Then
                    PictureBox1.Visible = False
                    btn_cetak.Visible = False
                    btn_simpan.Visible = False
                Else
                    btn_cetak.Visible = True
                    PictureBox1.Visible = True
                    btn_simpan.Visible = True
                End If
            End If



            Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder

            Generator.IncludeLabel = True  ' pengaturan label di scanner
            Generator.CustomLabel = txt_no_rangka.Text ' pengaturan label di scanner
            Try
                PictureBox1.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code39, txt_no_rangka.Text))
            Catch ex As Exception

            End Try

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ppd_Load(sender As Object, e As EventArgs) Handles ppd.Load

    End Sub

    Private Sub txt_type_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_type.KeyPress
        'HanyaAngka(e)
        HanyaHuruf(e)
    End Sub

    Private Sub cb_jenis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_jenis.KeyPress
        'HanyaAngka(e)
        HanyaHuruf(e)
    End Sub

    Private Sub cb_model_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_model.KeyPress
        '  HanyaAngka(e)
        HanyaHuruf(e)
    End Sub




    Private Sub txtstatus_TextChanged(sender As Object, e As EventArgs) Handles txtstatus.TextChanged
        ' HanyaAngka(e)
        HanyaHuruf(e)
    End Sub

    Private Sub btn_bersih_Click(sender As Object, e As EventArgs) Handles btn_bersih.Click
        bersih()
        btn_cetak.Visible = False

    End Sub



    Private Sub txt_tahun_buat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_tahun_buat.KeyPress
        HanyaAngka(e)
        '  HanyaHuruf(e)
    End Sub

    Private Sub txt_nama_pemilik_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nama_pemilik.KeyPress
        ' HanyaAngka(e)
        HanyaHuruf(e)
    End Sub

    Private Sub cb_cabang_pemilik_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_cabang_pemilik.KeyPress
        '  HanyaAngka(e)
        HanyaHuruf(e)
    End Sub

    Private Sub txt_no_mesin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_no_mesin.KeyPress

    End Sub

    Private Sub txt_type_TextChanged(sender As Object, e As EventArgs) Handles txt_type.TextChanged
        cb_jenis.Focus()
    End Sub
End Class