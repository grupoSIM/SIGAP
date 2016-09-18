Public Class frmVerResultados
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub frmVerResultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Carreras' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Carreras)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_DetalleRemates' table. You can move, or remove it, as needed.
        Me.Tb_DetalleRematesTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_DetalleRemates)

    End Sub

    Private Function CargarRemates()

        Me.Tb_DetalleRematesTableAdapter.GetDataByResultado()

    End Function

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbUnGanador.CheckedChanged

    End Sub
End Class