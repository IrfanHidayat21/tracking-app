Imports System.Data.Odbc
Public Class LAPORANALL
  

    Const str = "Driver={MySQL ODBC 3.51 Driver};database=dbauto_2000;server=localhost;uid=root"
    Dim MysqlConn As OdbcConnection
    Dim cmd As OdbcCommand
    Dim da As OdbcDataAdapter
    Dim reader As OdbcDataReader
    Dim dbDataSet As DataSet
    Dim table As DataTable
    Sub koneksi()
        MysqlConn = New OdbcConnection(str)
        Try
            MysqlConn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub
    Sub seleksidata2()

        Try
            Call koneksi()
            Dim str As String
            str = "select * from tbl_master_stnkbpkb where Tgl_Pengajuan Between '" & Format(DTPM1.Value, "yyyy-MM-dd") & "' and '" & Format(DTPM2.Value, "yyyy-MM-dd") & "'"
            cmd = New OdbcCommand(str, MysqlConn)
            reader = cmd.ExecuteReader

            table = New DataTable()
            table.Load(reader)
            ' reader.Read()
            If (table.Rows.Count > 0) Then
                CRV1.SelectionFormula = "{tbl_master_stnkbpkb.Tgl_Pengajuan} in date ('" & DTPM1.Value & "') to date ('" & DTPM2.Value & "')"
                CRV1.ReportSource = "LAPORANSTNKBPKBPENGAJUAN.rpt"
                CRV1.RefreshReport()
            Else
                MsgBox("Tidak Ada Pengajuan pada periode ini!", vbInformation, "Maaf")

            End If
            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub seleksidata3()
        'ini LAPORAN penyerahan STNK BPKB'
        Try
            Call koneksi()
            Dim str As String
            str = "select * from tbl_master_stnkbpkb where Tgl_Penyerahan_BPKB Between '" & Format(DTP3.Value, "yyyy-MM-dd") & "' and '" & Format(DTP4.Value, "yyyy-MM-dd") & "'"
            cmd = New OdbcCommand(str, MysqlConn)
            reader = cmd.ExecuteReader() ' Get Data Reader Rows
            'Convert DataReader into DataTable
            'table = New DataTable()
            'table.Load(reader)
            reader.Read()
            If (reader.HasRows) Then
                CRV1.SelectionFormula = "{tbl_master_stnkbpkb.Tgl_Penyerahan_BPKB} in date ('" & DTP3.Value & "') to date ('" & DTP4.Value & "')"
                CRV1.ReportSource = "LAPORANSTNKBPKBPENYERAHAN.rpt"
                CRV1.RefreshReport()
            Else
                MsgBox("Tidak Ada Penyerahan STNK dan BPKB pada periode ini!", vbInformation, "Maaf")
            End If

            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub LAPORANALL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Btn_Cetak_Click(sender As Object, e As EventArgs) Handles Btn_Cetak.Click
        seleksidata2()
    End Sub

    Private Sub Btn_Cetak2_Click(sender As Object, e As EventArgs) Handles Btn_Cetak2.Click
        seleksidata3()
    End Sub


End Class