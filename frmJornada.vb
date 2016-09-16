Public Class frmJornada
    Private Sub frmJornada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Jornadas' table. You can move, or remove it, as needed.
        Me.Tb_JornadasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Jornadas)

    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Me.Validate()
        Me.TbJornadasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdSIGAP_DataSet)
    End Sub
End Class