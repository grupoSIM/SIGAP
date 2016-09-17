Public Class frmRemate
    Private Sub frmRemate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_CarrerasCaballos' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasCaballosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_CarrerasCaballos)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Caballos' table. You can move, or remove it, as needed.
        Me.Tb_CaballosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Caballos)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Carreras' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Carreras)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_DetalleRemates' table. You can move, or remove it, as needed.
        Me.Tb_DetalleRematesTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_DetalleRemates)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_DetalleRemates' table. You can move, or remove it, as needed.
        'Me.Tb_DetalleRematesTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_DetalleRemates)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_CarrerasCaballos' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasCaballosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_CarrerasCaballos)

        CargarRemates()
        CargarDetallesRemates()

    End Sub

    Private Function CargarDetallesRemates()
        Dim fila As Integer = 0
        Dim caballo As DataRow
        Dim filaNueva As DataRowView
        Dim dtCarrerasCaballos = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(cmbCarrera.SelectedValue)

        Me.BdSIGAP_DataSet.tb_DetalleRemates.Clear()

        For Each row As DataRow In dtCarrerasCaballos.Rows
            caballo = BdSIGAP_DataSet.tb_Caballos.FindById(row("IdCaballo"))
            'filaNueva = BdSIGAP_DataSet.tb_DetalleRemates.NewRow
            'filaNueva = DataGridView1.Rows.Add()

            filaNueva = TbDetalleRematesBindingSource.AddNew()
            filaNueva("IdCarreraCaballo") = row("Id")
            DataGridView1.Rows(fila).Cells("Caballo").Value = caballo("CaballoNombre")
            fila = fila + 1
            'MsgBox(caballo("CaballoNombre"), MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        Next
        'MsgBox(, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)



    End Function

    Private Function CargarRemates()
        Dim carrera As DataRow

        carrera = BdSIGAP_DataSet.tb_Carreras.FindById(cmbCarrera.SelectedValue)
        txtPorcentajeCasa.Text = carrera("PorcentajeUltimoRemate")

    End Function

    Private Sub cmbCarrera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCarrera.SelectedIndexChanged

        CargarRemates()
        CargarDetallesRemates()

    End Sub

End Class