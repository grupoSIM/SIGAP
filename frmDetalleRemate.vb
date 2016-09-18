Public Class frmDetalleRemate
    Private Sub Tb_DetalleRematesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tb_DetalleRematesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tb_DetalleRematesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdSIGAP_DataSet)

    End Sub

    Private Sub frmDetalleRemate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_DetalleRemates' table. You can move, or remove it, as needed.
        Me.Tb_DetalleRematesTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_DetalleRemates)

    End Sub
End Class