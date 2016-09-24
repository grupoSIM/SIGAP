Public Class frmReporteDevoluciones
    Private Sub frmReporteDevoluciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'bdSIGAP_DataSet.VwDevoluciones' table. You can move, or remove it, as needed.
        'Me.VwDevolucionesTableAdapter.Fill(Me.bdSIGAP_DataSet.VwDevoluciones)

        Dim idCarrera As Integer
        idCarrera = frmReporteDevolucionesSeleccionar.cbCarrera.SelectedValue

        Me.VwDevolucionesTableAdapter.FillByIdCarrera(bdSIGAP_DataSet.VwDevoluciones, idCarrera) ' <-- CAMBIAR EL 26 POR EL PARAMETRO
        Dim setup = Me.ReportViewer1.GetPageSettings()
        setup.Margins = New System.Drawing.Printing.Margins(1, 1, 1, 1)
        Me.ReportViewer1.SetPageSettings(setup)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class