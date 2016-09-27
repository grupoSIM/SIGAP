Public Class frmReporteCierreCaja
    Private Sub frmReporteCierreCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Carreras' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Carreras)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'frmCajaPalco.Show()

        Dim ctrlImpre As New ControladorImpresion
        ctrlImpre.ImprimirCajaPalco(Me.cbCarrera.SelectedValue)
    End Sub
End Class