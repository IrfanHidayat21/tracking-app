<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CetakTTSTNK
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CRVNotaSTNK = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TANDATERIMASTNK1 = New APPAuto2000P1.TANDATERIMASTNK()
        Me.SuspendLayout()
        '
        'CRVNotaSTNK
        '
        Me.CRVNotaSTNK.ActiveViewIndex = 0
        Me.CRVNotaSTNK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVNotaSTNK.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVNotaSTNK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVNotaSTNK.Location = New System.Drawing.Point(0, 0)
        Me.CRVNotaSTNK.Name = "CRVNotaSTNK"
        Me.CRVNotaSTNK.ReportSource = "C:\Users\WIJAY\Documents\Visual Studio 2013\Projects\APPAuto2000P1\APPAuto2000P1\" & _
    "bin\Debug\TANDATERIMASTNK.rpt"
        Me.CRVNotaSTNK.ShowCloseButton = False
        Me.CRVNotaSTNK.ShowCopyButton = False
        Me.CRVNotaSTNK.ShowGotoPageButton = False
        Me.CRVNotaSTNK.ShowGroupTreeButton = False
        Me.CRVNotaSTNK.ShowLogo = False
        Me.CRVNotaSTNK.ShowParameterPanelButton = False
        Me.CRVNotaSTNK.Size = New System.Drawing.Size(541, 366)
        Me.CRVNotaSTNK.TabIndex = 0
        Me.CRVNotaSTNK.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'TANDATERIMASTNK1
        '
        '
        'CetakTTSTNK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 366)
        Me.Controls.Add(Me.CRVNotaSTNK)
        Me.Name = "CetakTTSTNK"
        Me.Text = "NOTA TANDA TERIMA STNK"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRVNotaSTNK As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TANDATERIMASTNK1 As APPAuto2000P1.TANDATERIMASTNK
End Class
