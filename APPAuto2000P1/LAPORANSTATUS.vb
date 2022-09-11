Imports System.Data.Odbc
Public Class LAPORANSTATUS


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
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub



    Sub seleksidata()

        Try
            Call koneksi()
            Dim str As String
            str = "select * from tbl_master_stnkbpkb where Status = '" & ComboBox1.Text & "' "
            cmd = New OdbcCommand(str, MysqlConn)
            reader = cmd.ExecuteReader

            table = New DataTable()
            table.Load(reader)
            ' reader.Read()
            If (table.Rows.Count > 0) Then
                CRV2.SelectionFormula = "Totext({tbl_master_stnkbpkb.Status})= '" & ComboBox1.Text & "'"
                CRV2.ReportSource = "LAPORANSTNKBPKBSTATUS.rpt"
                CRV2.RefreshReport()
            Else
                MsgBox("Tidak Ada Data pada Status ini!", vbInformation, "Maaf")

            End If
            Exit Sub

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Then
            MessageBox.Show("Pilih Status Dulu")
            'ElseIf ComboBox1.Text = "Semua" Then
            '    CRV2.ReportSource = "LaporanBarangAll.rpt"
            '    CRV2.RefreshReport()
        Else

            seleksidata()
        End If
    End Sub

    Private Sub LAPORANSTATUS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Belum Diajukan")
        ComboBox1.Items.Add("Pengajuan")
        ComboBox1.Items.Add("STNK Selesai")
        ComboBox1.Items.Add("BPKB Selesai")
        ComboBox1.Items.Add("Penyerahan STNK")
        ComboBox1.Items.Add("Penyerahan BPKB")
    End Sub
End Class