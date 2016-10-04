Public Class frmYunta
    Public altoYunta As Integer = 100
    Public contCab As Integer = 1

    Private Sub frmYunta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Jornadas' table. You can move, or remove it, as needed.
        Me.Tb_JornadasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Jornadas)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Carreras' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Carreras)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Caballos' table. You can move, or remove it, as needed.
        Me.Tb_CaballosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Caballos)
        CargarCaballos()

    End Sub

    Private Sub cbCarrera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCarrera.SelectedIndexChanged
        If (cbCarrera.SelectedValue) Then
            CargarCaballos()
        End If
    End Sub

    Private Function CargarCaballos()

        Dim dtCarrerasCaballos = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(cbCarrera.SelectedValue)
        Dim i As Integer = 1
        Dim caballo As DataRow
        Dim nuevoControl As Control
        Dim alto As Integer = 100
        Dim ctrlsEjec As Integer = Controls.Count - 1
        Dim ctrl As Control

        For n As Integer = ctrlsEjec To 1 Step -1
            ctrl = Controls(n)
            If (ctrl.Tag IsNot Nothing) Then
                Controls.Remove(ctrl)
                ctrl.Dispose()
            End If
        Next

        For Each row As DataRow In dtCarrerasCaballos.Rows
            caballo = BdSIGAP_DataSet.tb_Caballos.FindById(row("IdCaballo"))
            'MsgBox(cabs("CaballoNombre"), MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)

            'Crea elckeck box de caballo
            Dim ubicacion As Point
            ubicacion = New Point(35, alto)

            nuevoControl = New CheckBox
            With nuevoControl
                .Name = "ckCaballo" & i
                .Size() = New Size(200, 20)
                .Text = caballo("CaballoNombre")
                .Location = ubicacion
                .Tag = "Caballo"
            End With
            Controls.Add(nuevoControl)


            ' Creación de TextBox de orden de caballos
            nuevoControl = New TextBox
            With nuevoControl
                .Name = "txtNumero" & i
                .Location = New Point(240, alto)
                .Size() = New Size(40, 20)
                .Text = row("Orden")
                .Tag = "Numero"
            End With
            Controls.Add(nuevoControl)

            'MessageBox.Show(nuevocontrol.Name, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            i += 1
            alto = alto + 20
        Next

        For Each chk As CheckBox In Controls.OfType(Of CheckBox)
            chk.Visible = True
        Next

        For Each txt As TextBox In Controls.OfType(Of TextBox)
            txt.Visible = True
        Next

    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        Dim nuevoControl As Control
        Dim i As Integer = 1
        Dim c As Integer = 1
        Dim cb As Integer = 1
        Dim nombrecillo As String
        nombrecillo = " "
        Dim num As String = ""
        Dim ubicacion As Point
        ubicacion = New Point(35, altoYunta)


        For Each chk As CheckBox In Controls.OfType(Of CheckBox)
            If chk.Checked = True Then
                nombrecillo = nombrecillo & chk.Text & "/"
                num = num & Me.Controls("txtNumero" & c).Text
            End If
            c += 1
        Next

        nuevoControl = New TextBox
        With nuevoControl
            .Name = "txtNum" & contCab
            .Location = New Point(400, altoYunta)
            .Size() = New Size(40, 20)
            .Text = num
            '.Tag = "NumeroOrden"
            .Visible = True
        End With
        Controls.Add(nuevoControl)

        nuevoControl = New TextBox
        With nuevoControl
            .Name = "txtCaballo" & contCab
            .Location = New Point(450, altoYunta)
            .Size() = New Size(300, 20)
            .Text = nombrecillo
            '.Tag = "NomCab"
            .Visible = True
        End With
        Controls.Add(nuevoControl)

        altoYunta = altoYunta + 20


        For Each chk As CheckBox In Controls.OfType(Of CheckBox)
            If chk.Checked = True Then
                chk.Checked = False
            End If
            cb += 1
        Next

        contCab += 1
    End Sub
    Private Function CreaCarrera()
        Dim i As Integer = 1
        Dim idCarreraNueva As Integer
        Dim y As Integer = 1
        Dim yuntas As String = ""
        Dim nroYunta As String = "0"


        For Each txt As TextBox In Controls.OfType(Of TextBox)
            If txt.Name = "txtNum" & y Then
                'MessageBox.Show("y=" & y, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                'MessageBox.Show("txtNum" & y, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                yuntas = yuntas & "#" & Me.Controls("txtNum" & y).Text
                nroYunta = nroYunta & Me.Controls("txtNum" & y).Text
                y += 1
            End If
        Next



        '#1 CARGAR CARRERA'
        Dim filaCarrera As DataRowView
        filaCarrera = TbCarrerasBindingSource.AddNew()

        filaCarrera("IdJornada") = cbJornada.SelectedValue
        filaCarrera("NroCarrera") = cbJornada.SelectedValue & nroYunta
        filaCarrera("Nombre") = "Y " & cbCarrera.SelectedValue & yuntas
        filaCarrera("Metros") = "0"
        filaCarrera("Estado") = 0
        filaCarrera("PorcentajeCasa") = RecuperarPorcentaje()
        filaCarrera("PorcentajeUltimoRemate") = RecuperarPorcentaje()
        filaCarrera("TipoCarrera") = "Normal"
        filaCarrera("Observaciones") = " "

        Me.Validate()
        Me.TbCarrerasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdSIGAP_DataSet)

        idCarreraNueva = Tb_CarrerasTableAdapter.maxId()

        Return idCarreraNueva


    End Function

    Private Function CreaCaballos()
        Dim i As Integer
        i = 1
        '2 creo caballo
        Dim filaCaballo As DataRowView

        For Each txt As TextBox In Controls.OfType(Of TextBox)
            'MessageBox.Show(txt.Name, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            'MessageBox.Show("i=" & i, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            If txt.Name = "txtCaballo" & i Then
                filaCaballo = TbCaballosBindingSource.AddNew()
                filaCaballo("CaballoNombre") = Me.Controls("txtCaballo" & i).Text

                Me.Validate()
                Me.TbCaballosBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BdSIGAP_DataSet)
                i += 1
            End If
        Next

    End Function

    Private Sub CreaCaballosCarrera(ByVal idCarrera As Integer)
        Dim filaCaballoCarrera As DataRowView
        Dim i As Integer = 1

        For Each txt As TextBox In Controls.OfType(Of TextBox)
            If txt.Name = "txtCaballo" & i Then
                filaCaballoCarrera = TbCarrerasCaballosBindingSource.AddNew()
                filaCaballoCarrera("IdCaballo") = Tb_CaballosTableAdapter.GetIdByNombre(Me.Controls("txtCaballo" & i).Text)
                filaCaballoCarrera("IdCarrera") = idCarrera
                filaCaballoCarrera("Orden") = Me.Controls("txtNum" & i).Text

                Me.Validate()
                Me.TbCarrerasCaballosBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BdSIGAP_DataSet)

                'MessageBox.Show("Se ha creado la carreraCAballo", "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                i += 1
            End If

        Next

    End Sub

    Private Sub btCrearCarrera_Click(sender As Object, e As EventArgs) Handles btCrearCarrera.Click
        Dim idCarrera As Integer

        idCarrera = CreaCarrera()
        CreaCaballos()
        CreaCaballosCarrera(idCarrera)

    End Sub

    Private Sub btRemates_Click(sender As Object, e As EventArgs) Handles btRemates.Click
        Dim idCarrera As Integer

        idCarrera = CreaCarrera()
        CreaCaballos()
        CreaCaballosCarrera(idCarrera)

        frmRemate.txYunta.Text = idCarrera
        Me.Close()
        frmRemate.Show()
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        contCab = contCab - 1
        altoYunta = altoYunta - 20
        'MessageBox.Show("txtCaballo" & contCab, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Controls.Remove(Controls("txtCaballo" & contCab))
        Controls.Remove(Controls("txtNum" & contCab))

    End Sub

    Private Function RecuperarPorcentaje()
        Dim i As Integer = 1
        Dim porCaballos As Integer
        Dim cont As Integer = 0

        For Each txt As TextBox In Controls.OfType(Of TextBox)
            If txt.Name = "txtCaballo" & i Then
                cont += 1
                i += 1
            End If
        Next
        If i > 1 Then
            porCaballos = Tb_PorcentajesCasaTableAdapter.GetPorcentajeByCantidadCaballos(cont)
        End If
        If i = 1 Then
            porCaballos = 0
        End If
        'MessageBox.Show("cont=" & cont, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        'MessageBox.Show("porCaballos=" & porCaballos, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Return porCaballos
    End Function

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class