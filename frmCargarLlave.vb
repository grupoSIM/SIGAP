﻿Public Class frmCargarLlave

    Public ref1 As Integer
    Public ref2 As Integer
    Public cuentaCab1 As Integer = 0
    Public cuentaCab2 As Integer = 0

    Private Sub frmCargarLlave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Caballos' table. You can move, or remove it, as needed.
        Me.Tb_CaballosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Caballos)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_CarrerasCaballos' table. You can move, or remove it, as needed.
        'Me.Tb_CarrerasCaballosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_CarrerasCaballos)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Carreras' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Carreras)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Jornadas' table. You can move, or remove it, as needed.
        Me.Tb_JornadasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Jornadas)

        CargarCaballos1()
        CargarCaballos2()


    End Sub
    Private Function LimpiarCaballos1()
        Dim ctrlsEjec As Integer = Controls.Count - 1

        For Each txt As TextBox In Controls.OfType(Of TextBox)
            txt.Visible = False
        Next

    End Function

    Private Function LimpiarCaballos2()
        Dim ctrlsEjec As Integer = Controls.Count - 1

        For Each txt As TextBox In Controls.OfType(Of TextBox)
            txt.Visible = False
            ' MsgBox(txt.Name, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)

        Next

    End Function

    Private Sub cbCarrera1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCarrera1.SelectedIndexChanged
        If (cbCarrera1.SelectedValue) Then
            LimpiarCaballos1()
            LimpiarCaballos2()
            CargarCaballos1()
            CargarCaballos2()
        End If

    End Sub

    Private Function CargarCaballos1()

        Dim dtCarrerasCaballos1 = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(cbCarrera1.SelectedValue)
        Dim i As Integer = 1
        Dim caballo As DataRow

        'txNombre.Text = cbCarrera1.Text & "-" & cbCarrera2.Text

        For Each row As DataRow In dtCarrerasCaballos1.Rows

            caballo = BdSIGAP_DataSet.tb_Caballos.FindById(row("IdCaballo"))

            Me.Controls("txCar1Nro" & i).Visible = True
            Me.Controls("txCar1Cab" & i).Visible = True

            Me.Controls("txCar1Nro" & i).Text = row("Orden")
            Me.Controls("txCar1Cab" & i).Text = caballo("CaballoNombre")

            'MsgBox(caballo("CaballoNombre"), MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            i = i + 1

        Next
        ref1 = cbCarrera1.SelectedValue

        'MessageBox.Show(ref1, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)


    End Function

    Private Function CargarCaballos2()

        Dim dtCarrerasCaballos2 = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(cbCarrera2.SelectedValue)
        Dim y As Integer = 1
        Dim caballo2 As DataRow

        'txNombre.Text = cbCarrera1.Text & "-" & cbCarrera2.Text

        For Each row2 As DataRow In dtCarrerasCaballos2.Rows

            caballo2 = BdSIGAP_DataSet.tb_Caballos.FindById(row2("IdCaballo"))

            Me.Controls("txCar2Nro" & y).Visible = True
            Me.Controls("txCar2Cab" & y).Visible = True

            Me.Controls("txCar2Nro" & y).Text = row2("Orden")
            Me.Controls("txCar2Cab" & y).Text = caballo2("CaballoNombre")

            'MsgBox(caballo("CaballoNombre"), MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            y = y + 1

        Next

    End Function

    Private Function RecuperarPorcentaje()
        Dim i As Integer = 1
        Dim porCaballos As Integer = 0
        Dim cont As Integer = 0

        Dim dtCarrerasCaballos1 As DataTable = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(cbCarrera1.SelectedValue)
        Dim dtCarrerasCaballos2 As DataTable = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(cbCarrera2.SelectedValue)

        For Each row As DataRow In dtCarrerasCaballos1.Rows
            Dim y As Integer = 1
            For Each row2 As DataRow In dtCarrerasCaballos2.Rows
                cont += 1
                y = y + 1
            Next
            i = i + 1
        Next
        If cont > 10 Then
            cont = 10
            porCaballos = Tb_PorcentajesCasaTableAdapter.GetPorcentajeByCantidadCaballos(cont)
        End If

        If cont > 1 Then
            porCaballos = Tb_PorcentajesCasaTableAdapter.GetPorcentajeByCantidadCaballos(cont)
        End If

        Return porCaballos
    End Function

    Private Function CreaCarrera(ByVal car1 As Integer, ByVal car2 As Integer)
        ' MessageBox.Show("crecarrera ref 1" & ref1, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Dim idCarreraNueva As Integer

        'nProcentajeCasa.Value = RecuperarPorcentaje()
        'txNombre.Text = "Llave:" & cbCarrera1.Text & "-" & cbCarrera2.Text

        '#1 CARGAR CARRERA'
        Dim filaCarrera As DataRowView
        filaCarrera = TbCarrerasBindingSource.AddNew()

        filaCarrera("IdJornada") = cbJornada.SelectedValue
        filaCarrera("NroCarrera") = nCarrera.Value
        filaCarrera("Nombre") = txNombre.Text
        filaCarrera("Metros") = 0
        filaCarrera("Estado") = 0
        filaCarrera("PorcentajeCasa") = nProcentajeCasa.Value
        filaCarrera("PorcentajeUltimoRemate") = nProcentajeCasa.Value
        filaCarrera("TipoCarrera") = "Llave"

        Me.Validate()
        Me.TbCarrerasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdSIGAP_DataSet)
        idCarreraNueva = Tb_CarrerasTableAdapter.maxId()

        'MessageBox.Show("Se ha creado la carrera" & car1, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)


        Return car1
    End Function

    Private Function CreaCaballos(ByVal car1 As Integer, ByVal car2 As Integer)
        'MessageBox.Show("cre cab ref 1" & ref1, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        '#2 CARGAR CARRERA - CABALLO'
        Dim filaCaballo As DataRowView
        Dim dtCarrerasCaballos1 As DataTable = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(ref1)
        Dim dtCarrerasCaballos2 As DataTable = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(car2)
        Dim i As Integer = 1
        Dim cab As String = ""
        ' Dim idCaballoNuevo As Integer

        For Each row As DataRow In dtCarrerasCaballos1.Rows
            ' MessageBox.Show(Me.Controls("txCar1Cab" & i).Text, "SiGAp", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            Dim y As Integer = 1


            For Each row2 As DataRow In dtCarrerasCaballos2.Rows

                filaCaballo = TbCaballosBindingSource.AddNew()
                filaCaballo("CaballoNombre") = Me.Controls("txCar1Cab" & i).Text & "-" & Me.Controls("txCar2Cab" & y).Text
                filaCaballo("EsLlave") = True

                Me.Validate()
                Me.TbCaballosBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BdSIGAP_DataSet)

                'idCaballoNuevo = Tb_CaballosTableAdapter.MaxId()
                cab = Me.Controls("txCar1Cab" & i).Text & "-" & Me.Controls("txCar2Cab" & y).Text
                y = y + 1


            Next

            i = i + 1
        Next
        Return car1
        ' MessageBox.Show("Se ha creado el caballo: " & cab, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Function

    Private Sub CreaCaballosCarrera(ByVal car1 As Integer, ByVal car2 As Integer)
        Dim filaCaballoCarrera As DataRowView
        Dim dtCarrerasCaballos1 As DataTable = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(car1)
        Dim dtCarrerasCaballos2 As DataTable = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(car2)
        Dim i As Integer = 1

        For Each row As DataRow In dtCarrerasCaballos1.Rows
            ' MessageBox.Show(Me.Controls("txCar1Cab" & i).Text, "SiGAp", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            Dim y As Integer = 1
            For Each row2 As DataRow In dtCarrerasCaballos2.Rows

                filaCaballoCarrera = Tb_CarrerasCaballosBindingSource.AddNew()
                'MessageBox.Show(Tb_CarrerasTableAdapter.maxId(), "SiGAp", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)

                filaCaballoCarrera("IdCaballo") = Tb_CaballosTableAdapter.GetIdByNombre(Me.Controls("txCar1Cab" & i).Text & "-" & Me.Controls("txCar2Cab" & y).Text)
                filaCaballoCarrera("IdCarrera") = Tb_CarrerasTableAdapter.maxId()
                filaCaballoCarrera("Orden") = Me.Controls("txCar1Nro" & i).Text & Me.Controls("txCar2Nro" & y).Text

                Me.Validate()
                Me.Tb_CarrerasCaballosBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BdSIGAP_DataSet)

                'MessageBox.Show("Se ha creado la carreraCAballo", "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                y = y + 1
            Next

            i = i + 1
        Next



    End Sub

    Private Sub cbCarrera2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCarrera2.SelectedIndexChanged
        If (cbCarrera2.SelectedValue) Then
            LimpiarCaballos1()
            LimpiarCaballos2()
            CargarCaballos1()
            CargarCaballos2()
        End If

    End Sub

    Private Sub btCreaCarrera_Click(sender As Object, e As EventArgs) Handles btCreaCarrera.Click
        Dim idCarrera1 As Integer

        nProcentajeCasa.Value = RecuperarPorcentaje()
        txNombre.Text = "Llave:" & cbCarrera1.Text & "-" & cbCarrera2.Text

        idCarrera1 = CreaCarrera(ref1, cbCarrera2.SelectedValue)
        cbCarrera1.SelectedValue = idCarrera1

        idCarrera1 = CreaCaballos(idCarrera1, cbCarrera2.SelectedValue)
        cbCarrera1.SelectedValue = idCarrera1
        CreaCaballosCarrera(idCarrera1, cbCarrera2.SelectedValue)

        MessageBox.Show("Se ha creado la llave", "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

    End Sub


    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class