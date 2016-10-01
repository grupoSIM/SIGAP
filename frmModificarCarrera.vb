Public Class frmModificarCarrera

    Public ref1 As Integer = 0


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

        CargarCarreras()
    End Sub

    Private Function CargarCarreras()

        Me.Tb_CarrerasCaballosTableAdapter.FillByCarrera(Me.BdSIGAP_DataSet.tb_CarrerasCaballos, cbCarrera.SelectedValue)

            Dim carrera As DataRow
            carrera = BdSIGAP_DataSet.tb_Carreras.FindById(cbCarrera.SelectedValue)
        'MessageBox.Show("SelectedValue " & cbCarrera.SelectedValue, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Me.nCarrera.Text = carrera("NroCarrera")
        Me.txNombre.Text = carrera("Nombre")
        Me.nProcentajeCasa.Value = carrera("PorcentajeCasa")
            Me.txMetros.Text = carrera("Metros")


    End Function



    Private Sub cbCarrera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCarrera.SelectedIndexChanged
        CargarCarreras()
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim carrera As DataRow
        carrera = BdSIGAP_DataSet.tb_Carreras.FindById(cbCarrera.SelectedValue)

        'actualiza, pone los datos a moficar y  continuando los originales

        Me.Validate()

        If IsDBNull(carrera("Observaciones")) Then
            carrera("Observaciones") = "La nada misma"
        End If

        'BdSIGAP_DataSet.Tables("tb_carreras").Rows(cbCarrera.SelectedValue).Item("Nombre") = Me.txNombre.Text

        Me.Tb_CarrerasTableAdapter.Update(
            carrera("IdJornada"),
            Me.nCarrera.Text,
            Me.txNombre.Text,
            Me.txMetros.Text,
            carrera("Estado"),
            Me.nProcentajeCasa.Value,
            carrera("PorcentajeUltimoRemate"),
            carrera("Observaciones"),
            carrera("TipoCarrera"),
            carrera("Id"),
            carrera("IdJornada"),
            carrera("NroCarrera"),
            carrera("Nombre"),
            carrera("Metros"),
            carrera("Estado"),
            carrera("PorcentajeCasa"),
            carrera("PorcentajeUltimoRemate"),
            carrera("Observaciones"),
            carrera("TipoCarrera"))


        Me.TbCarrerasBindingSource.EndEdit()
        Me.TbCarrerasCaballosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdSIGAP_DataSet)
        'MessageBox.Show("Se ha Modificado la Carrera", "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class