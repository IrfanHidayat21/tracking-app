Imports System.Data.Odbc
Public Class stnk_selesai
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

    Private Sub stnk_selesai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_simpan.Hide()
        txt_no_rangka.Focus()
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        ubah()
        bersih()
        btn_simpan.Hide()
    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Sub bersih()
        txt_no_rangka.Text = ""
        DTPSTNK.Value = Today
        DateTimePicker2.Value = Now
    End Sub
    Private Sub btn_bersih_Click(sender As Object, e As EventArgs)
        Call bersih()
    End Sub

    Private Sub txt_no_rangka_TextChanged(sender As Object, e As EventArgs) Handles txt_no_rangka.TextChanged
        koneksi()
        Try
            MysqlConn.Open()

            Dim Query As String
            Query = "SELECT  No_Rangka,Type,Jenis,Model,No_Mesin,Tahun_Buat,Nama_Pemilik,Cabang_Pemilik,Status FROM tbl_master_stnkbpkb  WHERE No_Rangka ='" & txt_no_rangka.Text & "'"
            cmd = New OdbcCommand(Query, MysqlConn)
            reader = cmd.ExecuteReader
            If reader.Read Then
                ' txt_cabang.Text = reader(7).ToString

                If reader(8).ToString = "Pengajuan" Then
                    Label3.Text = "STNK SELESAI"
                    btn_simpan.Visible = True
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

    Sub ubah()

        koneksi()
        MysqlConn.Open()
        cmd = New OdbcCommand("Select No_Rangka from tbl_master_stnkbpkb where No_Rangka = '" & txt_no_rangka.Text & "'", MysqlConn)
        reader = cmd.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            ubah_data()
        Else
            MsgBox("Nomor Rangka Tidak Tersedia atau Tidak Boleh Diubah", vbInformation, "Maaf")
            txt_no_rangka.Focus()
            Exit Sub
        End If

    End Sub
    Sub ubah_data()
        koneksi()
        If txt_no_rangka.Text = "" Then
            MsgBox("Nomor Rangka Masih Kosong", vbInformation, "Maaf")
            txt_no_rangka.Focus()
        Else
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "update tbl_master_stnkbpkb set No_Rangka='" & txt_no_rangka.Text & "' ,Status='" & Label3.Text & "',Tgl_STNK_jadi='" & Format(DTPSTNK.Value, "yyyy-MM-dd  H:mm :") & "' where No_Rangka='" & txt_no_rangka.Text & "'"
                cmd = New OdbcCommand(Query, MysqlConn)
                reader = cmd.ExecuteReader
                MessageBox.Show("Data Update")
                MysqlConn.Close()
            Catch ex As Exception

            End Try



        End If
    End Sub
  
End Class