Public Class frmCajaPalco
    Private Sub frmCajaPalco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'bdSIGAP_DataSet.VwCajaPalco' table. You can move, or remove it, as needed.
        'Me.VwCajaPalcoTableAdapter.Fill(Me.bdSIGAP_DataSet.VwCajaPalco)
        Me.VwCajaPalcoTableAdapter.FillByIdCarrera(Me.bdSIGAP_DataSet.VwCajaPalco, 26) '<-- CAMBIAR 26 POR EL PARAMETRO

        Dim setup = Me.ReportViewer1.GetPageSettings()
        setup.Margins = New System.Drawing.Printing.Margins(1, 1, 1, 1)
        Me.ReportViewer1.SetPageSettings(setup)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class