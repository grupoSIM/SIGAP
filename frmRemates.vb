Public Class frmRemates
    Private Sub Tb_RematesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tb_RematesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tb_RematesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdSIGAP_DataSet)

    End Sub

    Private Sub frmRemates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Rematadores' table. You can move, or remove it, as needed.
        Me.Tb_RematadoresTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Rematadores)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Palcos' table. You can move, or remove it, as needed.
        Me.Tb_PalcosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Palcos)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Carreras' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Carreras)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Remates' table. You can move, or remove it, as needed.
        Me.Tb_RematesTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Remates)

    End Sub
End Class