Imports System.Data.Odbc
Public Class Login
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
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
  
    Sub lgn2()
        Try
            If txt_user_id.Text = "" Or txt_password.Text = "" Then
                MsgBox("Username atau Password Belum lengkap", vbInformation, "Maaf")
            Else
                koneksi()
                MysqlConn.Open()
                Dim Query As String
                Query = "select * from tbl_login where user_id='" & txt_user_id.Text & "' and password='" & txt_password.Text & "'"
                cmd = New OdbcCommand(Query, MysqlConn)
                reader = cmd.ExecuteReader
                reader.Read()
                If reader.HasRows Then
                    Me.Hide()
                    FormMenuUtama.Show()
                Else
                    MsgBox("User ID atay Password anda Salah", vbInformation, "Maaf")

                End If
            End If
            MysqlConn.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub login2_Click(sender As Object, e As EventArgs) Handles login2.Click
        lgn2()
    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()

    End Sub
End Class
