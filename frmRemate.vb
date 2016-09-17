Public Class frmRemate
    Private Sub frmRemate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet2.tb_Remates' table. You can move, or remove it, as needed.
        Me.Tb_RematesTableAdapter.Fill(Me.BdSIGAP_DataSet2.tb_Remates)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet2.tb_Carreras' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasTableAdapter.Fill(Me.BdSIGAP_DataSet2.tb_Carreras)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet2.tb_Jornadas' table. You can move, or remove it, as needed.
        Me.Tb_JornadasTableAdapter2.Fill(Me.BdSIGAP_DataSet2.tb_Jornadas)

    End Sub

    Private Sub Tb_JornadasBindingSource2BindingNavigator1SaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tb_JornadasBindingSource2.EndEdit()
        Me.TableAdapterManager2.UpdateAll(Me.BdSIGAP_DataSet2)

    End Sub
End Class