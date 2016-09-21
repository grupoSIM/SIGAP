Public Class frmModificarCarrera
    Private Sub frmModificarCarrera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Caballos' table. You can move, or remove it, as needed.
        Me.Tb_CaballosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Caballos)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_CarrerasCaballos' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasCaballosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_CarrerasCaballos)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Carreras' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Carreras)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Jornadas' table. You can move, or remove it, as needed.
        Me.Tb_JornadasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Jornadas)

        CargarDatosCarrera()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCarrera.SelectedIndexChanged
        CargarDatosCarrera()
    End Sub

    Private Function CargarDatosCarrera()
        Dim carrera As DataRow
        carrera = BdSIGAP_DataSet.tb_Carreras.FindById(cbCarrera.SelectedValue)

        Me.txNombre.Text = carrera("Nombre")
        Me.nNumero.Value = carrera("NroCarrera")
        Me.txPorcCasa.Text = carrera("PorcentajeCasa")
        Me.cbEstado.SelectedValue = carrera("Estado")
        Me.cbTipo.SelectedValue = carrera("TipoCarrera")
        Me.txMetros.Text = carrera("Metros")
        Me.txObservacion.Text = carrera("Observaciones")


        Me.Tb_CarrerasCaballosTableAdapter.FillByCarrera(Me.BdSIGAP_DataSet.tb_CarrerasCaballos, cbCarrera.SelectedValue)

    End Function

    Private Function CambioPorcCasa()
        'busco todos los remates de esa carrera caballo y los sobreescribo,
        'tener en cuenta que si era x ejemplo el 20 para 4 cab y se cambió
        'a 15 pero en un remate entraron 3 debe soobrescribirse pero 
        'teniendo en cta los parámetros

        Dim importeJugado As Decimal


        Dim dtDetalleRemates = Tb_DetalleRematesTableAdapter.GetDataByCarrera(cbCarrera.SelectedValue)

        'OJO HAY Q VALIDAR LA CANTIDAD DE CABALLOS Y COMPARAR CONTRA LOS PARAMETROS

        '#recorro los remates y  lso modifico

        '#recorro los detalles remates y  los modifico
        For Each row As DataRow In dtDetalleRemates.Rows
            'MsgBox(row("IdCarreraCaballo") & " " & row("NroCaballo") & " " & row("Apostador") & " " & row("ImportePremio"), MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)

            '#busco los remates los detalles remates del mismo remate
            Dim dtRematesSeleccionados = Tb_DetalleRematesTableAdapter.GetDataByRematesIncluidos(row("IdRemate"))

            importeJugado = 0
            For Each rowSel As DataRow In dtRematesSeleccionados.Rows
                importeJugado = importeJugado + rowSel("ImporteApuesta")
                'MsgBox(rowSel("ImporteApuesta") & " " & importeJugado, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Next
            For Each rowSelCam As DataRow In dtRematesSeleccionados.Rows
                rowSelCam("ImportePremio") = (importeJugado * ((100 - Me.txPorcCasa.Text) / 100))
                Tb_DetalleRematesTableAdapter.Update(dtRematesSeleccionados)
            Next

        Next
    End Function

    Private Function CambioCaballoIncluido()
        'busco todos los remates de esa carrera caballo y los sobreescribo,
        'tener en cuenta que al sacar un caballo se debe restar el importe del remate 
        'para ese caballo y  recalcular el importe premio



    End Function

    Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click
        Me.Validate()

        CambioCaballoIncluido()
        CambioPorcCasa()

        Me.TbCarrerasBindingSource.EndEdit()
        Me.TbCarrerasCaballosBindingSource.EndEdit()


        Me.TableAdapterManager.UpdateAll(Me.BdSIGAP_DataSet)

        'Me.Close()
        MsgBox("listorti ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)

    End Sub


End Class