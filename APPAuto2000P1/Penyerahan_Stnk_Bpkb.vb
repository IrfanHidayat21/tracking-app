Imports System.Data.Odbc
Public Class Penyerahan_Stnk_Bpkb
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
    'Sub validasi_data()
    '    koneksi()
    '    MysqlConn.Open()
    '    cmd = New OdbcCommand("Select No_Rangka from tbl_penyerahan_stnkbpkb where No_Rangka = '" & txt_no_rangka.Text & "'", MysqlConn)
    '    reader = cmd.ExecuteReader
    '    reader.Read()
    '    If reader.HasRows Then
    '        MsgBox("Maaf Nomor Rangka Sudah Ada dan Tidak Boleh Sama!", vbInformation, "Maaf")
    '        txt_no_rangka.Focus()
    '        Exit Sub
    '    Else
    '        simpan_data_penyerahan_stnk()
    '    End If
    'End Sub
    'Sub simpan_data_penyerahan_stnk()
    '    koneksi()
    '    If txt_no_rangka.Text = "" Then
    '        MsgBox("Nomor Rangka Masih Kosong", vbInformation, "Maaf")
    '        txt_no_rangka.Focus()

    '    Else
    '        Try
    '            MysqlConn.Open()
    '            Dim Query As String
    '            Query = "insert into tbl_penyerahan_stnkbpkb (No_Rangka,Tgl_penyerahan_stnk,Cabang_Pemilik,status)  values ('" & txt_no_rangka.Text & "','" & Format(DTPpenyerahanstnk.Value, "yyyy-MM-dd") & "','" & txt_cabang.Text & "','" & txtstatus.Text & "')"
    '            cmd = New OdbcCommand(Query, MysqlConn)
    '            reader = cmd.ExecuteReader
    '            MessageBox.Show("Data Saved")
    '            MysqlConn.Close()
    '        Catch ex As Exception
    '        End Try
    '        refresh_table()

    '        '  btn_ubah.Enabled = True
    '        '   btn_hapus.Enabled = True
    '        '   btn_simpan.Enabled = False
    '        '   btn_tambah.Enabled = True


    '    End If
    'End Sub
    'Private Sub refresh_table()
    '    koneksi()
    '    Dim SDA As New OdbcDataAdapter
    '    Dim dbDataSet As New DataTable
    '    Dim bSource As New BindingSource
    '    Try
    '        MysqlConn.Open()
    '        Dim Query As String
    '        Query = "select * from tbl_penyerahan_stnkbpkb"
    '        cmd = New OdbcCommand(Query, MysqlConn)
    '        SDA.SelectCommand = cmd
    '        SDA.Fill(dbDataSet)
    '        bSource.DataSource = dbDataSet
    '        DataGridView1.DataSource = bSource
    '        SDA.Update(dbDataSet)
    '        MysqlConn.Close()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    Finally
    '        MysqlConn.Dispose()
    '    End Try
    'End Sub
    'Private Sub Penyerahan_Stnk_Bpkb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    refresh_table()
    '    btn_simpan2.Enabled = False
    '    DTPpenyerahanbpkb.Enabled = False
    'End Sub

    'Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
    '    validasi_data()
    '    Call bersih()
    'End Sub

    'Sub validasi_data2()
    '    koneksi()
    '    MysqlConn.Open()
    '    cmd = New OdbcCommand("Select No_Rangka from tbl_penyerahan_stnkbpkb where No_Rangka = '" & txt_no_rangka.Text & "'", MysqlConn)
    '    reader = cmd.ExecuteReader
    '    reader.Read()
    '    If reader.HasRows Then
    '        simpan_data_penyerahan_bpkb()
    '    Else
    '        MsgBox("No Rangka Tidak Tersedia atau Tidak Boleh Diubah", vbInformation, "Maaf")
    '        txt_no_rangka.Focus()
    '        Exit Sub
    '    End If
    'End Sub

    'Sub simpan_data_penyerahan_bpkb()
    '    koneksi()
    '    If txt_no_rangka.Text = "" Then
    '        MsgBox("Gunakan Nomor Rangka yang Benar untuk Update", vbInformation, "Maaf")
    '        txt_no_rangka.Focus()

    '    ElseIf txt_cabang.Text = "" Then
    '        MsgBox("Cabang Pemilik Masih Kosong", vbInformation, "Maaf")
    '        txt_cabang.Focus()
    '    Else
    '        Try
    '            MysqlConn.Open()
    '            Dim Query As String
    '            Query = "update tbl_penyerahan_stnkbpkb set No_Rangka='" & txt_no_rangka.Text & "',Tgl_Penyerahan_bpkb='" & Format(DTPpenyerahanbpkb.Value, "yyyy-MM-dd") & "',Cabang_Pemilik='" & txt_cabang.Text & "',status='" & txtstatus.Text & "' where No_Rangka='" & txt_no_rangka.Text & "'"
    '            cmd = New OdbcCommand(Query, MysqlConn)
    '            reader = cmd.ExecuteReader
    '            MessageBox.Show("Data Update")
    '            MysqlConn.Close()
    '        Catch ex As Exception

    '        End Try
    '        refresh_table()


    '    End If
    'End Sub
    'Private Sub btn_simpan2_Click(sender As Object, e As EventArgs) Handles btn_simpan2.Click
    'validasi_data2()
    'btn_simpan.Enabled = True
    'DTPpenyerahanstnk.Enabled = True
    'bersih()
    '  End Sub

   
    'Private Sub btn_bersih_Click(sender As Object, e As EventArgs) Handles btn_bersih.Click
    '    Call bersih()
    'End Sub



    'Private Sub txt_no_rangka_TextChanged(sender As Object, e As EventArgs) Handles txt_no_rangka.TextChanged
    '    koneksi()
    '    DTPpenyerahanbpkb.Enabled = False
    '    btn_simpan2.Enabled = False
    '    Try
    '        MysqlConn.Open()

    '        Dim Query As String
    '        Query = "SELECT  No_Rangka,Type,Jenis,Model,No_Mesin,Tahun_Buat,Nama_Pemilik,Cabang_Pemilik,status FROM tbl_master_stnkbpkb  WHERE No_Rangka ='" & txt_no_rangka.Text & "'"
    '        cmd = New OdbcCommand(Query, MysqlConn)
    '        reader = cmd.ExecuteReader
    '        If reader.Read Then
    '            txt_cabang.Text = reader(7).ToString
    '            If reader(8).ToString = "BPKB Selesai" Then
    '                txtstatus.Text = "Penyerahan STNK"
    '                Call ubah2()


    '            ElseIf reader(8).ToString = "Penyerahan STNK" Then
    '                btn_simpan2.Enabled = True
    '                DTPpenyerahanbpkb.Enabled = True
    '                btn_simpan.Enabled = False
    '                DTPpenyerahanstnk.Enabled = False
    '                txtstatus.Text = "Penyerahan BPKB"
    '                Call ubah2()


    '            Else
    '                MsgBox("Nomor Rangka Masih Kosong", vbInformation, "Maaf")
    '                'btn_simpan.Enabled = False

    '            End If

    '        Else
    '            txt_no_rangka.Focus()
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub


  

    Private Sub txt_no_rangka_TextChanged(sender As Object, e As EventArgs) Handles txt_no_rangka.TextChanged
        koneksi()
        Try
            MysqlConn.Open()

            Dim Query As String
            Query = "SELECT  No_Rangka,Type,Jenis,Model,No_Mesin,Tahun_Buat,Nama_Pemilik,Cabang_Pemilik,Status FROM tbl_master_stnkbpkb  WHERE No_Rangka ='" & txt_no_rangka.Text & "'"
            cmd = New OdbcCommand(Query, MysqlConn)
            reader = cmd.ExecuteReader
            If reader.Read Then
                txt_cabang.Text = reader(7).ToString

                If reader(8).ToString = "STNK SELESAI" Then
                    txtstatus.Text = "Penyerahan STNK"
                    btn_simpan.Visible = True
                    btn_simpan2.Visible = False

                    DTPpenyerahanbpkb.Enabled = False
                    DTPpenyerahanstnk.Enabled = False
                ElseIf reader(8).ToString = "BPKB SELESAI" Then
                    txtstatus.Text = "Penyerahan BPKB"
                    btn_simpan2.Visible = True
                    btn_simpan.Visible = False

                    DTPpenyerahanbpkb.Enabled = False
                    DTPpenyerahanstnk.Enabled = False

                    '            validasi_data2()
                    'Else
                    '    MsgBox("Nomor Rangka Masih Kosong", vbInformation, "Maaf")
                    '    btn_simpan.Enabled = False

                End If

            Else
                txt_no_rangka.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub ubah1()

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
        Else
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "update tbl_master_stnkbpkb set No_Rangka='" & txt_no_rangka.Text & "' ,Status='" & txtstatus.Text & "',Tgl_Penyerahan_STNK='" & Format(DTPpenyerahanstnk.Value, "yyyy-MM-dd  H:mm :") & "' where No_Rangka='" & txt_no_rangka.Text & "'"
                cmd = New OdbcCommand(Query, MysqlConn)
                reader = cmd.ExecuteReader
                MessageBox.Show("Data Update")
                MysqlConn.Close()
            Catch ex As Exception

            End Try



        End If
    End Sub

    Sub bersih()
        txt_no_rangka.Text = ""
        DTPpenyerahanstnk.Value = Today
        DTPpenyerahanbpkb.Value = Today
        txt_cabang.Text = ""
        txtstatus.Text = ""
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        koneksi()
        ubah1()
        '    CetakTTSTNK.CrystalReportViewer1.SelectionFormula = "{tbl_master_stnkbpkb.No_Rangka}='" & (txt_no_rangka.Text) ' & "' "
        'CetakTTSTNK.CrystalReportViewer1.Refresh()
        ' CetakTTSTNK.Show()
        bersih()
        btn_simpan.Hide()

        DTPpenyerahanstnk.Enabled = False
        CetakTTSTNK.ShowDialog()
        txt_no_rangka.Focus()
    End Sub

    Private Sub btn_simpan2_Click(sender As Object, e As EventArgs) Handles btn_simpan2.Click
        ubah2()
        bersih()
        btn_simpan2.Hide()

        DTPpenyerahanbpkb.Enabled = False
        CetakTTBPKB.ShowDialog()
        txt_no_rangka.Focus()
    End Sub

    Sub ubah2()

        koneksi()
        MysqlConn.Open()
        cmd = New OdbcCommand("Select No_Rangka from tbl_master_stnkbpkb where No_Rangka = '" & txt_no_rangka.Text & "'", MysqlConn)
        reader = cmd.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            ubah_data_master2()
        Else
            MsgBox("Nomor Rangka Tidak Tersedia atau Tidak Boleh Diubah", vbInformation, "Maaf")
            txt_no_rangka.Focus()
            Exit Sub
        End If

    End Sub
    Sub ubah_data_master2()
        koneksi()
        If txt_no_rangka.Text = "" Then
            MsgBox("Nomor Rangka Masih Kosong", vbInformation, "Maaf")
            txt_no_rangka.Focus()
        Else
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "update tbl_master_stnkbpkb set No_Rangka='" & txt_no_rangka.Text & "' ,Status='" & txtstatus.Text & "',Tgl_Penyerahan_BPKB='" & Format(DTPpenyerahanbpkb.Value, "yyyy-MM-dd  H:mm :") & "' where No_Rangka='" & txt_no_rangka.Text & "'"
                cmd = New OdbcCommand(Query, MysqlConn)
                reader = cmd.ExecuteReader
                MessageBox.Show("Data Update")
                MysqlConn.Close()
            Catch ex As Exception

            End Try



        End If
    End Sub

    Private Sub Penyerahan_Stnk_Bpkb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        DTPpenyerahanbpkb.Enabled = False
        DTPpenyerahanstnk.Enabled = False
        txt_cabang.Enabled = False
        txt_no_rangka.Focus()
    End Sub

    Private Sub btn_bersih_Click(sender As Object, e As EventArgs) Handles btn_bersih.Click
        bersih()
    End Sub

    Private Sub btn_cetak_bpkb_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DTPpenyerahanbpkb_ValueChanged(sender As Object, e As EventArgs) Handles DTPpenyerahanbpkb.ValueChanged

    End Sub
End Class