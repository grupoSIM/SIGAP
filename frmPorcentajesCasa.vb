Public Class frmPorcentajesCasa
    Private Sub frmPorcentajesCasa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Eventos' table. You can move, or remove it, as needed.
        Me.Tb_EventosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Eventos)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_PorcentajesCasa' table. You can move, or remove it, as needed.
        Me.Tb_PorcentajesCasaTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_PorcentajesCasa)

    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Me.Validate()
        Me.TbPorcentajesCasaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdSIGAP_DataSet)
    End Sub
End Class