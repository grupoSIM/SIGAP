Public Class frmReporteCajaJornadaSeleccionar
    Private Sub frmReporteCajaJornadaSeleccionar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Jornadas' table. You can move, or remove it, as needed.
        Me.Tb_JornadasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Jornadas)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ctrlImpre As New ControladorImpresion
        ctrlImpre.ImprimirCajaPalcoJornada(Me.cbJornada.SelectedValue)
    End Sub
End Class