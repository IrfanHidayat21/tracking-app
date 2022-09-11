Public Class FormMenuUtama

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

    Private Sub STNKBPKBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STNKBPKBToolStripMenuItem.Click
        LAPORANALL.Show()
        LAPORANALL.MdiParent = Me
    End Sub

    Private Sub BERDASARKANSTATUSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BERDASARKANSTATUSToolStripMenuItem.Click
        LAPORANSTATUS.Show()
        LAPORANSTATUS.MdiParent = Me
    End Sub

    Private Sub DATAMASTERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATAMASTERToolStripMenuItem.Click
        DataMaster2.Show()
        DataMaster2.MdiParent = Me
    End Sub

    Private Sub CEKDATAToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CEKDATAToolStripMenuItem1.Click
        Form_Cek_Status.Show()
        Form_Cek_Status.MdiParent = Me
    End Sub

    
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Close()
        Login.Close()
    End Sub
End Class