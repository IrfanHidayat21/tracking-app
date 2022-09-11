Public Class CetakTTBPKB

    Private Sub CetakTTBPKB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CRVNotaBPKB.ReportSource = "TANDATERIMABPKB.rpt"
        CRVNotaBPKB.RefreshReport()
    End Sub
End Class