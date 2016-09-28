Public Class frmReporteDevolucionesSeleccionar
    Private Sub frmReporteDevolucionesSeleccionar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Carreras' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Carreras)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'frmReporteDevoluciones.Show()

        Dim ctrlImpre As New ControladorImpresion
        ctrlImpre.ImprimirDevoluciones(Me.cbCarrera.SelectedValue)
    End Sub


End Class