Public Class frmHipodromo
    Private Sub frmHipodromo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Hipodromos' table. You can move, or remove it, as needed.
        Me.Tb_HipodromosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Hipodromos)

    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Me.Validate()
        Me.TbHipodromosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdSIGAP_DataSet)
    End Sub
End Class