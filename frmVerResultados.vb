Public Class frmVerResultados
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub frmVerResultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_CarrerasCaballos' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasCaballosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_CarrerasCaballos)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Carreras' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Carreras)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_DetalleRemates' table. You can move, or remove it, as needed.
        ' Me.Tb_DetalleRematesTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_DetalleRemates)
        CargarRemates()

    End Sub

    Private Function CargarRemates()
        Me.Tb_DetalleRematesTableAdapter.FillByGetDataByResultado(Me.BdSIGAP_DataSet.tb_DetalleRemates, cbCarrera.SelectedValue)

    End Function





    Private Sub cbCarrera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCarrera.SelectedIndexChanged
        CargarRemates()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub rbPuesta_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
End Class