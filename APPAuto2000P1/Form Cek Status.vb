Imports System.Data.Odbc
Public Class Form_Cek_Status
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
    Private Sub Form_Cek_Status_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_table()
    End Sub

    Sub refresh_table()
        koneksi()
        Dim SDA As New OdbcDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Try
            MysqlConn.Open()

            Dim Query As String
            Query = "select No_Rangka,Type,Nama_Pemilik,Status,Tgl_Pengajuan,Tgl_STNK_jadi,Tgl_BPKB_jadi,Tgl_Penyerahan_STNK,Tgl_Penyerahan_BPKB from tbl_master_stnkbpkb"
            cmd = New OdbcCommand(Query, MysqlConn)
            SDA.SelectCommand = cmd
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DGVMaster2.DataSource = bSource
            SDA.Update(dbDataSet)
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    
    ' Format(DTPSTNK.Value, "yyyy-MM-dd  H:mm :")
   
  
    

    
    Private Sub txt_pencarian_TextChanged(sender As Object, e As EventArgs) Handles txt_pencarian.TextChanged
        koneksi()

        Try
            MysqlConn.Open()
            da = New OdbcDataAdapter("select No_Rangka,Type,Nama_Pemilik,Status,Tgl_Pengajuan,Tgl_STNK_jadi,Tgl_BPKB_jadi,Tgl_Penyerahan_STNK,Tgl_Penyerahan_BPKB from tbl_master_stnkbpkb where No_Rangka like '%" + txt_pencarian.Text + "%' OR Type like '%" + txt_pencarian.Text + "%' OR Nama_Pemilik like '%" + txt_pencarian.Text + "%'", MysqlConn)
            dbDataSet = New DataSet
            da.Fill(dbDataSet, 0)
            DGVMaster2.DataSource = dbDataSet.Tables(0)
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

   
    Private Sub cb_status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_status.SelectedIndexChanged
        koneksi()
        If cb_status.Text = "SEMUA" Then
            refresh_table()
        Else
            Try
                MysqlConn.Open()
                da = New OdbcDataAdapter("select No_Rangka,Type,Nama_Pemilik,Status,Tgl_Pengajuan,Tgl_STNK_jadi,Tgl_BPKB_jadi,Tgl_Penyerahan_STNK,Tgl_Penyerahan_BPKB from tbl_master_stnkbpkb where Status like '%" + cb_status.Text + "%'", MysqlConn)
                dbDataSet = New DataSet
                da.Fill(dbDataSet, 0)
                DGVMaster2.DataSource = dbDataSet.Tables(0)
                MysqlConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class