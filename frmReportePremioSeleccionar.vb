Public Class frmReportePremioSeleccionar
    Private Sub frmReportePremioSeleccionar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Carreras' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Carreras)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmReportePremios.Show()
    End Sub
End Class