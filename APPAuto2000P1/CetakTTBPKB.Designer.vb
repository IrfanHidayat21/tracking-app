<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CetakTTBPKB
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
        Me.CRVNotaBPKB = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TANDATERIMABPKB1 = New APPAuto2000P1.TANDATERIMABPKB()
        Me.SuspendLayout()
        '
        'CRVNotaBPKB
        '
        Me.CRVNotaBPKB.ActiveViewIndex = 0
        Me.CRVNotaBPKB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVNotaBPKB.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVNotaBPKB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVNotaBPKB.Location = New System.Drawing.Point(0, 0)
        Me.CRVNotaBPKB.Name = "CRVNotaBPKB"
        Me.CRVNotaBPKB.ReportSource = Me.TANDATERIMABPKB1
        Me.CRVNotaBPKB.ShowCloseButton = False
        Me.CRVNotaBPKB.ShowGotoPageButton = False
        Me.CRVNotaBPKB.ShowGroupTreeButton = False
        Me.CRVNotaBPKB.ShowLogo = False
        Me.CRVNotaBPKB.ShowParameterPanelButton = False
        Me.CRVNotaBPKB.Size = New System.Drawing.Size(564, 398)
        Me.CRVNotaBPKB.TabIndex = 0
        Me.CRVNotaBPKB.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'CetakTTBPKB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 398)
        Me.Controls.Add(Me.CRVNotaBPKB)
        Me.Name = "CetakTTBPKB"
        Me.Text = "NOTA TANDA TERIMA BPKB"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRVNotaBPKB As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TANDATERIMABPKB1 As APPAuto2000P1.TANDATERIMABPKB
End Class
