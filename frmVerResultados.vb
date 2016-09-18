Public Class frmVerResultados
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub frmVerResultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Carreras' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Carreras)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_DetalleRemates' table. You can move, or remove it, as needed.
        ' Me.Tb_DetalleRematesTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_DetalleRemates)
        CargarRemates()

    End Sub

    Private Function CargarRemates()
        If rbUnGanador.Checked = True Then
            Me.Tb_DetalleRematesTableAdapter.FillByGetDataByResultado(Me.BdSIGAP_DataSet.tb_DetalleRemates)
        End If
        If rbPuesta.Checked = True Then
            For i As Integer = 0 To DataGridView1.RowCount - 1
                DataGridView1.Rows(i).Cells(9).Value = (DataGridView1.Rows(i).Cells(9).Value / Me.nResultados.Value)
            Next
            Me.Tb_DetalleRematesTableAdapter.FillByGetDataByResultadoPuesta(Me.BdSIGAP_DataSet.tb_DetalleRemates)
        End If

    End Function

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbUnGanador.CheckedChanged
        CargarRemates()
    End Sub

    Private Sub rbPuesta_CheckedChanged(sender As Object, e As EventArgs) Handles rbPuesta.CheckedChanged
        CargarRemates()
    End Sub
End Class