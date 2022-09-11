Public Class MenuUtama2

    Private Sub KELUARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KELUARToolStripMenuItem.Click
        Close()
        Login.Close()
    End Sub

    Private Sub MasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterToolStripMenuItem.Click
        DataMaster.Show()
        DataMaster.MdiParent = Me
    End Sub

    Private Sub STNKDANBPKBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STNKDANBPKBToolStripMenuItem.Click
        PengajuanStnkBpkb.Show()
        PengajuanStnkBpkb.MdiParent = Me
    End Sub

    Private Sub STNKSELESAIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STNKSELESAIToolStripMenuItem.Click
        stnk_selesai.Show()
        stnk_selesai.MdiParent = Me
    End Sub

    Private Sub BPKBSELESAIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BPKBSELESAIToolStripMenuItem.Click
        bpkb_selesai.Show()
        bpkb_selesai.MdiParent = Me
    End Sub

    Private Sub STNKDANBPKBToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles STNKDANBPKBToolStripMenuItem1.Click
        Penyerahan_Stnk_Bpkb.Show()
        Penyerahan_Stnk_Bpkb.MdiParent = Me
    End Sub
End Class