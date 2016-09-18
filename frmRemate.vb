Public Class frmRemate
    Private Sub frmRemate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Jornadas' table. You can move, or remove it, as needed.
        Me.Tb_JornadasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Jornadas)
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
            filaNueva("NroCaballo") = row("Orden")
            filaNueva("Incluido") = True
            DataGridView1.Rows(fila).Cells("Caballo").Value = caballo("CaballoNombre")
            fila = fila + 1
            'MsgBox(caballo("CaballoNombre"), MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        Next
        'MsgBox(, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)



    End Function

    Private Function CargarRemates()
        Dim jornada As DataRow
        Dim carrera As DataRow

        carrera = BdSIGAP_DataSet.tb_Carreras.FindById(cmbCarrera.SelectedValue)
        jornada = BdSIGAP_DataSet.tb_Jornadas.FindById(carrera("IdJornada"))

        txtJornada.Text = jornada("Descripcion")
        txtFecha.Text = jornada("Fecha")
        txtPorcentajeCasa.Text = carrera("PorcentajeUltimoRemate")

    End Function

    Private Sub cmbCarrera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCarrera.SelectedIndexChanged

        If (cmbCarrera.SelectedValue) Then
            CargarRemates()
            CargarDetallesRemates()
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Dim remateNuevo As DataRowView
        Dim remateNuevo As Integer
        Dim totalApuestas As Integer

        'totalApuestas = DataGridView1.Rows.Cast(Of DataGridViewRow).Sum(Function(r) Val(r.Cells(6).Value))
        For i As Integer = 0 To DataGridView1.RowCount - 1
            If (Not IsDBNull(DataGridView1.Rows(i).Cells(6).Value) And DataGridView1.Rows(i).Cells(7).Value) Then
                totalApuestas += DataGridView1.Rows(i).Cells(6).Value
                'Change the number 2 to your column index number (The first column has a 0 index column)
                'In this example the column index of Price is 2
            End If
        Next

        Tb_RematesTableAdapter.Insert(cmbCarrera.SelectedValue, 1, txtPorcentajeCasa.Text, (totalApuestas * ((100 - txtPorcentajeCasa.Text) / 100)), 1, totalApuestas, vbNull, txtRemate.Text)


        MsgBox(Tb_RematesTableAdapter.MaxId(), MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)

    End Sub
End Class