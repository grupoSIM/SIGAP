Public Class frmReportePremios
    Private Sub frmReportePremios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'bdSIGAP_DataSet.VwPremios' table. You can move, or remove it, as needed.
        Me.VwPremiosTableAdapter.Fill(Me.bdSIGAP_DataSet.VwPremios)
        'Me.VwPremiosTableAdapter.FillByIdCarrera(bdSIGAP_DataSet.VwPremios, 26)

        Me.ReportViewer1.RefreshReport
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class