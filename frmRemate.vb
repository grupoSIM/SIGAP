Imports System.Drawing.Color
Imports System.Threading

Public Class frmRemate
    Private Sub frmRemate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Palcos' table. You can move, or remove it, as needed.
        Me.Tb_PalcosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Palcos)
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

        If txYunta.Text <> "" Then
            cmbCarrera.SelectedValue = txYunta.Text
        End If
        CargarRemates()
        CargarDetallesRemates()

    End Sub

    Private Function CargarRemates()
        Dim jornada As DataRow
        Dim carrera = Tb_CarrerasTableAdapter.GetDataById(cmbCarrera.SelectedValue)

        jornada = BdSIGAP_DataSet.tb_Jornadas.FindById(carrera.Rows(0).Item("IdJornada"))

        txtJornada.Text = jornada("Descripcion")
        txtFecha.Text = jornada("Fecha")
        If (Tb_RematesTableAdapter.MaxNroRemateByCarrera(cmbCarrera.SelectedValue)) Then
            txtRemate.Text = Tb_RematesTableAdapter.MaxNroRemateByCarrera(cmbCarrera.SelectedValue) + 1
        Else
            txtRemate.Text = 1
        End If
        txtPorcentajeCasa.Text = carrera.Rows(0).Item("PorcentajeUltimoRemate")

    End Function


    Private Function CargarDetallesRemates()
        Dim fila As Integer = 0
        Dim caballo As DataRow
        Dim dtCarrerasCaballos = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(cmbCarrera.SelectedValue)
        Dim i As Integer = 0
        Dim nuevoControl As Control
        Dim ctrlsEjec As Integer = Controls.Count - 1
        Dim ctrl As Control
        Dim palco As DataRow

        palco = BdSIGAP_DataSet.tb_Palcos.FindById(cmbPalco.SelectedValue)
        Dim rematador = Tb_RematadoresTableAdapter.GetDataById(palco("IdRematador"))

        For n As Integer = ctrlsEjec To 0 Step -1
            ctrl = Controls(n)
            If (ctrl.Tag IsNot Nothing) Then
                Controls.Remove(ctrl)
                ctrl.Dispose()
            End If
        Next

        For Each row As DataRow In dtCarrerasCaballos.Rows
            caballo = BdSIGAP_DataSet.tb_Caballos.FindById(row("IdCaballo"))

            ' Creación de TextBox de orden de caballos
            nuevoControl = New TextBox
            With nuevoControl
                .Name = "txtNumero" & i
                .Location = New Point(8, (100 + (25 * (i + 1))))
                .Size() = New Size(55, 20)
                .TabIndex = 21 + (i * 7)
                .TabStop = False
                .Text = row("Orden")
                .Tag = "Numero"
            End With
            AddHandler nuevoControl.KeyPress, AddressOf txtNumero_KeyPress
            Controls.Add(nuevoControl)

            ' Creación de TextBox de nombre de caballos
            nuevoControl = New TextBox
            With nuevoControl
                .Name = "txtCaballo" & i
                .Location = New Point(69, (100 + (25 * (i + 1))))
                .Size() = New Size(170, 20)
                .TabIndex = 22 + (i * 7)
                .TabStop = False
                .Text = caballo("CaballoNombre")
                .Tag = "Caballo"
            End With
            Controls.Add(nuevoControl)

            ' Creación de TextBox de apostadores
            nuevoControl = New TextBox
            With nuevoControl
                .Name = "txtApostador" & i
                .Location = New Point(245, (100 + (25 * (i + 1))))
                .Size() = New Size(92, 20)
                .TabIndex = 23 + (i * 7)
                .Tag = "Apostador"
            End With
            If (rematador.Rows(0).Item("SinNombre")) Then
                nuevoControl.TabStop = False
            Else
                nuevoControl.TabStop = True
            End If
            AddHandler nuevoControl.KeyPress, AddressOf txtApostador_KeyPress
            Controls.Add(nuevoControl)

            ' Creación de TextBox de apuestas
            nuevoControl = New TextBox
            With nuevoControl
                .Name = "txtApuesta" & i
                .Location = New Point(342, (100 + (25 * (i + 1))))
                .Size() = New Size(92, 20)
                .TabIndex = 24 + (i * 7)
                .TabStop = True
                .Tag = "Apuesta"
            End With
            AddHandler nuevoControl.KeyPress, AddressOf txtApuesta_KeyPress
            AddHandler nuevoControl.TextChanged, AddressOf txtapuesta_TextChanged
            AddHandler nuevoControl.Leave, AddressOf txtApuesta_Leave
            Controls.Add(nuevoControl)

            ' Creación de CheckBox de Incluidos
            nuevoControl = New CheckBox
            With nuevoControl
                .Name = "chbIncluido" & i
                .Location = New Point(441, (103 + (25 * (i + 1))))
                .Size() = New Size(15, 14)
                .TabIndex = 25 + (i * 7)
                .TabStop = False
                .Tag = "Incluido"
            End With
            AddHandler nuevoControl.Click, AddressOf chbIncluido_Click
            Controls.Add(nuevoControl)

            ' Creación de ComboBox de Luz
            nuevoControl = New ComboBox
            With nuevoControl
                .Name = "cmbLuz" & i
                .Location = New Point(473, (100 + (25 * (i + 1))))
                .Size() = New Size(81, 20)
                .TabIndex = 26 + (i * 7)
                .TabStop = False
                .Tag = "Luz"
            End With
            Controls.Add(nuevoControl)

            ' Creación de RadioButton de Filas
            nuevoControl = New RadioButton
            With nuevoControl
                .Name = "radFila" & i
                .Location = New Point(566, (104 + (25 * (i + 1))))
                .Size() = New Size(14, 13)
                .TabIndex = 27 + (i * 7)
                .TabStop = False
                .Tag = "Fila"
            End With
            Controls.Add(nuevoControl)

            i += 1
        Next

        For Each txt As TextBox In Controls.OfType(Of TextBox)
            If (txt.Tag <> "Caballo") Then Continue For
            txt.ReadOnly = True
        Next

        For Each txt As TextBox In Controls.OfType(Of TextBox)
            If (txt.Tag <> "Apuesta") Then Continue For
            txt.TextAlign = HorizontalAlignment.Right
        Next

        For Each cmb As ComboBox In Controls.OfType(Of ComboBox)
            If (cmb.Tag <> "Luz") Then Continue For
            cmb.Items.Add("Da")
            cmb.Items.Add("Recibe")
        Next

        SelectNextControl(btnGuardar, True, True, True, True)

    End Function

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (e.KeyChar <> Chr(13)) Then
            ' Controlar que ingrese un número
            If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
                e.Handled = True
            End If
        Else
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtApostador_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (e.KeyChar = Chr(13)) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtApuesta_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (e.KeyChar <> Chr(13)) Then
            ' Controlar que ingrese un número
            If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
                e.Handled = True
            End If
        Else
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtapuesta_TextChanged(sender As Object, e As EventArgs)
        If (DirectCast(sender, TextBox).Text <> "") Then
            DirectCast(sender, TextBox).Text = FormatNumber(DirectCast(sender, TextBox).Text, 0)
            DirectCast(sender, TextBox).Select(DirectCast(sender, TextBox).TextLength, 0)
        End If
    End Sub

    Private Sub txtapuesta_Leave(sender As Object, e As EventArgs)
        Dim nombre As String = DirectCast(sender, TextBox).Name
        If (DirectCast(sender, TextBox).Text <> "") Then
            For Each chb As CheckBox In Me.Controls.OfType(Of CheckBox)
                If (chb.Tag <> "Incluido") Then Continue For
                If (chb.Name = ("chbIncluido" & nombre.Substring(10))) Then chb.Checked = True
            Next
        Else
            For Each chb As CheckBox In Me.Controls.OfType(Of CheckBox)
                If (chb.Tag <> "Incluido") Then Continue For
                If (chb.Name = ("chbIncluido" & nombre.Substring(10))) Then chb.Checked = False
            Next
        End If
    End Sub

    Private Sub chbIncluido_click(sender As Object, e As EventArgs)
        Dim nombre As String = DirectCast(sender, CheckBox).Name
        If (DirectCast(sender, CheckBox).CheckState = False) Then
            Controls("txtApuesta" & nombre.Substring(11)).Text = ""
        End If
        Controls("txtApuesta" & nombre.Substring(11)).Focus()
    End Sub

    Private Sub cmbCarrera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCarrera.SelectedIndexChanged

        If (cmbCarrera.SelectedValue) Then
            CargarRemates()
            CargarDetallesRemates()
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim totalApuestas As Integer = 0
        Dim dtCarrerasCaballos = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(cmbCarrera.SelectedValue)
        Dim carrera = Tb_CarrerasTableAdapter.GetDataById(cmbCarrera.SelectedValue)
        Dim i As Integer = 0
        Dim premio As Decimal
        Dim incluidos As Integer = 0

        For Each chb As CheckBox In Controls.OfType(Of CheckBox)
            If (chb.Tag <> "Incluido") Then Continue For
            If (chb.Checked) Then
                incluidos += 1
            End If
        Next

        If (incluidos > 1) Then
            For Each txt As TextBox In Controls.OfType(Of TextBox)
                If (txt.Tag <> "Apuesta") Then Continue For
                If (txt.Text <> "") Then totalApuestas += txt.Text
            Next

            txtPorcentajeCasa.Text = Tb_PorcentajesCasaTableAdapter.GetDataByCantCaballos(incluidos).Rows(0).Item("Porcentaje")

            premio = (totalApuestas * ((100 - txtPorcentajeCasa.Text) / 100))
            premio = Decimal.Round(premio / 10, 0) * 10

            carrera.Rows(0).Item("PorcentajeUltimoRemate") = txtPorcentajeCasa.Text
            Tb_CarrerasTableAdapter.Update(carrera)

            Tb_RematesTableAdapter.Insert(cmbCarrera.SelectedValue, cmbPalco.SelectedValue, txtPorcentajeCasa.Text, premio, 1, totalApuestas, premio, txtRemate.Text)

            For Each row As DataRow In dtCarrerasCaballos.Rows
                If (DirectCast(Controls("chbIncluido" & i), CheckBox).Checked) Then
                    Tb_DetalleRematesTableAdapter.Insert(Tb_RematesTableAdapter.MaxId(), row("Id"), Controls("txtNumero" & i).Text, Controls("txtApostador" & i).Text, Controls("txtApuesta" & i).Text, DirectCast(Controls("cmbLuz" & i), ComboBox).SelectedIndex, DirectCast(Controls("radFila" & i), RadioButton).Checked, premio, DirectCast(Controls("chbIncluido" & i), CheckBox).Checked, "")
                End If
                i += 1
            Next

            CargarRemates()
            CargarDetallesRemates()
        Else
            MsgBox("Se deben incluir al menos dos apuestas para guardar el remate.", vbExclamation + vbOKOnly)
        End If


        SelectNextControl(btnGuardar, True, True, True, True)
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim totalApuestas As Integer = 0
        Dim dtCarrerasCaballos = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(cmbCarrera.SelectedValue)
        Dim carrera = Tb_CarrerasTableAdapter.GetDataById(cmbCarrera.SelectedValue)
        Dim i As Integer = 0
        Dim premio As Decimal
        Dim incluidos As Integer = 0

        For Each chb As CheckBox In Controls.OfType(Of CheckBox)
            If (chb.Tag <> "Incluido") Then Continue For
            If (chb.Checked) Then
                incluidos += 1
            End If
        Next

        If (incluidos > 1) Then
            For Each txt As TextBox In Controls.OfType(Of TextBox)
                If (txt.Tag <> "Apuesta") Then Continue For
                If (txt.Text <> "") Then totalApuestas += txt.Text
            Next

            premio = (totalApuestas * ((100 - txtPorcentajeCasa.Text) / 100))
            premio = Decimal.Round(premio / 10, 0) * 10

            carrera.Rows(0).Item("PorcentajeUltimoRemate") = txtPorcentajeCasa.Text
            Tb_CarrerasTableAdapter.Update(carrera)

            Tb_RematesTableAdapter.Insert(cmbCarrera.SelectedValue, cmbPalco.SelectedValue, txtPorcentajeCasa.Text, premio, 1, totalApuestas, premio, txtRemate.Text)

            For Each row As DataRow In dtCarrerasCaballos.Rows
                If (DirectCast(Controls("chbIncluido" & i), CheckBox).Checked) Then
                    Tb_DetalleRematesTableAdapter.Insert(Tb_RematesTableAdapter.MaxId(), row("Id"), Controls("txtNumero" & i).Text, Controls("txtApostador" & i).Text, Controls("txtApuesta" & i).Text, DirectCast(Controls("cmbLuz" & i), ComboBox).SelectedIndex, DirectCast(Controls("radFila" & i), RadioButton).Checked, premio, DirectCast(Controls("chbIncluido" & i), CheckBox).Checked, "")
                End If
                i += 1
            Next

            Dim detalles = Tb_DetalleRematesTableAdapter.GetDataByRemate(Tb_RematesTableAdapter.MaxId())
            Dim ctrlImpre As New ControladorImpresion

            For Each row As DataRow In detalles.Rows

                ctrlImpre.ImprimirTicket(row("Id"))

            Next

            CargarRemates()
            CargarDetallesRemates()
        Else
            MsgBox("Se deben incluir al menos dos apuestas para guardar el remate.", vbExclamation + vbOKOnly)
        End If

        SelectNextControl(btnGuardar, True, True, True, True)

    End Sub

    Private Sub txtPorcentajeCasa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPorcentajeCasa.KeyPress
        If (e.KeyChar <> Chr(13)) Then
            ' Controlar que ingrese un número
            If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
                e.Handled = True
            End If
        Else
            SendKeys.Send("{TAB}")
        End If
    End Sub

End Class