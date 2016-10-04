Public Class frmModificarCarrera

    Public ref1 As Integer = 0
    Public IdCarrera As Integer


    Private Sub frmCargarResultado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Caballos' table. You can move, or remove it, as needed.
        Me.Tb_CaballosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Caballos)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_CarrerasCaballos' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasCaballosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_CarrerasCaballos)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Jornadas' table. You can move, or remove it, as needed.
        Me.Tb_JornadasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Jornadas)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Carreras' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Carreras)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_CarrerasCaballos' table. You can move, or remove it, as needed.
        ' Me.Tb_CarrerasCaballosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_CarrerasCaballos)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_CarrerasCaballos' table. You can move, or remove it, as needed.
        ' Me.Tb_CarrerasCaballosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_CarrerasCaballos)

        CargarCarreras(cbCarrera.SelectedValue)
    End Sub

    Private Function CargarCarreras(ByVal IdCarrera As Integer)
        'IdCarrera = cbCarrera.SelectedValue

        Dim jornada As DataRow

        Me.Tb_CarrerasCaballosTableAdapter.FillByCarrera(Me.BdSIGAP_DataSet.tb_CarrerasCaballos, IdCarrera)

        Dim carrera As DataRow
        carrera = BdSIGAP_DataSet.tb_Carreras.FindById(IdCarrera)
        'MessageBox.Show("SelectedValue " & cbCarrera.SelectedValue, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        jornada = BdSIGAP_DataSet.tb_Jornadas.FindById(carrera("IdJornada"))

        Me.cbJornada.SelectedValue = jornada("Id")

        Me.nCarrera.Text = carrera("NroCarrera")
        Me.txNombre.Text = carrera("Nombre")
        Me.nProcentajeCasa.Value = carrera("PorcentajeCasa")
        Me.txMetros.Text = carrera("Metros")
        Me.cbTipo.Text = carrera("TipoCarrera")

    End Function



    Private Sub cbCarrera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCarrera.SelectedIndexChanged
        If (cbCarrera.SelectedValue) Then
            CargarCarreras(cbCarrera.SelectedValue)
        End If

    End Sub

    Private Function RecuperarPorcentaje()
        Dim i As Integer = 1
        Dim porCaballos As Integer = 0
        Dim cont As Integer = 0

        For Renglones As Integer = 1 To DataGridView.RowCount - 1
            If Me.DataGridView.Rows(Renglones).Cells(3).Value = False Then
                'MessageBox.Show(Me.DataGridView.Rows(Renglones).Cells(3).Value, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                cont += 1
            End If
        Next

        'MessageBox.Show(cont, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        If cont > 1 Then
            porCaballos = Tb_PorcentajesCasaTableAdapter.GetPorcentajeByCantidadCaballos(cont)
        End If

        'MessageBox.Show("cont=" & cont, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        'MessageBox.Show("porCaballos=" & porCaballos, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Return porCaballos
    End Function


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim carrera As DataRow
        carrera = BdSIGAP_DataSet.tb_Carreras.FindById(cbCarrera.SelectedValue)
        IdCarrera = cbCarrera.SelectedValue

        nProcentajeCasa.Value = RecuperarPorcentaje()

        'actualiza, pone los datos a moficar y continuando los originales
        Me.Validate()

        If IsDBNull(carrera("Observaciones")) Then
            carrera("Observaciones") = " "
        End If

        Me.Tb_CarrerasTableAdapter.Update(
            carrera("IdJornada"),
            Me.txNombre.Text,
            Me.txMetros.Text,
            carrera("Estado"),
            Me.nProcentajeCasa.Value,
            Me.nProcentajeCasa.Value,
            carrera("Observaciones"),
            carrera("TipoCarrera"),
            Me.nCarrera.Value,
            carrera("Id"),
            carrera("IdJornada"),
            carrera("Nombre"),
            carrera("Metros"),
            carrera("Estado"),
            carrera("PorcentajeCasa"),
            carrera("PorcentajeUltimoRemate"),
            carrera("Observaciones"),
            carrera("TipoCarrera"),
            carrera("NroCarrera"))

        Me.TbCarrerasBindingSource.EndEdit()
        Me.TbCarrerasCaballosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdSIGAP_DataSet)

        MessageBox.Show("Se ha Modificado la Carrera", "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Me.Tb_CarrerasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Carreras)
        Me.cbCarrera.SelectedValue = IdCarrera


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cbJornada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJornada.SelectedIndexChanged
        Dim carreras = Tb_CarrerasTableAdapter.GetDataByJornada(cbJornada.SelectedValue)
        cbCarrera.DataSource = carreras
    End Sub
End Class