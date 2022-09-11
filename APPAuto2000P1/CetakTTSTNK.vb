Public Class CetakTTSTNK

    Private Sub TANDATERIMASTNK1_InitReport(sender As Object, e As EventArgs) Handles TANDATERIMASTNK1.InitReport

    End Sub

    Private Sub CetakTTSTNK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CRVNotaSTNK.ReportSource = "TANDATERIMASTNK.rpt"
        CRVNotaSTNK.RefreshReport()
    End Sub
End Class