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


        CargarRemates()
        CargarDetallesRemates()

    End Sub



    Private Function CargarDetallesRemates()
        Dim fila As Integer = 0
        Dim caballo As DataRow
        Dim dtCarrerasCaballos = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(cmbCarrera.SelectedValue)
        Dim i As Integer = 0
        Dim nuevoControl As Control
        Dim ctrlsEjec As Integer = Controls.Count - 1
        Dim ctrl As Control

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
                .TabStop = True
                .Tag = "Apostador"
            End With
            AddHandler nuevoControl.KeyPress, AddressOf txtApostador_KeyPress
            Controls.Add(nuevoControl)

            ' Creación de TextBox de apuestas
            nuevoControl = New TextBox
            With nuevoControl
                .Name = "txtApuesta" & i
                .Location = New Point(342, (100 + (25 * (i + 1))))
                .Size() = New Size(92, 20)
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
                .TabStop = False
                .Tag = "Incluido"
            End With
            Controls.Add(nuevoControl)

            ' Creación de ComboBox de Luz
            nuevoControl = New ComboBox
            With nuevoControl
                .Name = "cmbLuz" & i
                .Location = New Point(473, (100 + (25 * (i + 1))))
                .Size() = New Size(81, 20)
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

    Private Function CargarRemates()
        Dim jornada As DataRow
        Dim carrera As DataRow

        carrera = BdSIGAP_DataSet.tb_Carreras.FindById(cmbCarrera.SelectedValue)
        jornada = BdSIGAP_DataSet.tb_Jornadas.FindById(carrera("IdJornada"))

        txtJornada.Text = jornada("Descripcion")
        txtFecha.Text = jornada("Fecha")
        If (Tb_RematesTableAdapter.MaxNroRemateByCarrera(cmbCarrera.SelectedValue)) Then
            txtRemate.Text = Tb_RematesTableAdapter.MaxNroRemateByCarrera(cmbCarrera.SelectedValue) + 1
        Else
            txtRemate.Text = 1
        End If
        txtPorcentajeCasa.Text = carrera("PorcentajeUltimoRemate")

    End Function

    Private Sub cmbCarrera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCarrera.SelectedIndexChanged

        If (cmbCarrera.SelectedValue) Then
            CargarRemates()
            CargarDetallesRemates()
        End If

    End Sub



    ' INICIO Codigo de Impresion
    Private Declare Function GetTickCount Lib "kernel32" () As Integer
    Private Sub Imprimir(id)
        'MsgBox(id, MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        txtId.Text = id
        Form1.Show()

        Dim retraso As Integer
        retraso = 100 + GetTickCount
        While retraso >= GetTickCount
            Application.DoEvents()
        End While
        Form1.Close()
        ' FIN Codigo de Impresion
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim totalApuestas As Integer = 0
        Dim dtCarrerasCaballos = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(cmbCarrera.SelectedValue)
        Dim carrera = Tb_CarrerasTableAdapter.GetDataById(cmbCarrera.SelectedValue)
        Dim i As Integer = 0
        Dim premio As Decimal

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

        CargarRemates()
        CargarDetallesRemates()

        SelectNextControl(btnGuardar, True, True, True, True)
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim totalApuestas As Integer = 0
        Dim dtCarrerasCaballos = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(cmbCarrera.SelectedValue)
        Dim carrera = Tb_CarrerasTableAdapter.GetDataById(cmbCarrera.SelectedValue)
        Dim i As Integer = 0
        Dim premio As Decimal

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

            'Imprimir(row("Id"))
            ctrlImpre.ImprimirTicket(row("Id"))

        Next

        CargarRemates()
        CargarDetallesRemates()

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

    'Private Sub txtNumero0_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar <> Chr(13)) Then
    '        ' Controlar que ingrese un número
    '        If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
    '            e.Handled = True
    '        End If
    '    Else
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtNumero1_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar <> Chr(13)) Then
    '        ' Controlar que ingrese un número
    '        If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
    '            e.Handled = True
    '        End If
    '    Else
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtNumero2_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar <> Chr(13)) Then
    '        ' Controlar que ingrese un número
    '        If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
    '            e.Handled = True
    '        End If
    '    Else
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtNumero3_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar <> Chr(13)) Then
    '        ' Controlar que ingrese un número
    '        If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
    '            e.Handled = True
    '        End If
    '    Else
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtNumero4_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar <> Chr(13)) Then
    '        ' Controlar que ingrese un número
    '        If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
    '            e.Handled = True
    '        End If
    '    Else
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtNumero5_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar <> Chr(13)) Then
    '        ' Controlar que ingrese un número
    '        If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
    '            e.Handled = True
    '        End If
    '    Else
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtNumero6_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar <> Chr(13)) Then
    '        ' Controlar que ingrese un número
    '        If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
    '            e.Handled = True
    '        End If
    '    Else
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtNumero7_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar <> Chr(13)) Then
    '        ' Controlar que ingrese un número
    '        If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
    '            e.Handled = True
    '        End If
    '    Else
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtNumero8_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar <> Chr(13)) Then
    '        ' Controlar que ingrese un número
    '        If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
    '            e.Handled = True
    '        End If
    '    Else
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtNumero9_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar <> Chr(13)) Then
    '        ' Controlar que ingrese un número
    '        If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
    '            e.Handled = True
    '        End If
    '    Else
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtapuesta0_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar <> Chr(13)) Then
    '        ' Controlar que ingrese un número
    '        If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
    '            e.Handled = True
    '        End If
    '    Else
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtapuesta1_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar <> Chr(13)) Then
    '        ' Controlar que ingrese un número
    '        If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
    '            e.Handled = True
    '        End If
    '    Else
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtapuesta2_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar <> Chr(13)) Then
    '        ' Controlar que ingrese un número
    '        If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
    '            e.Handled = True
    '        End If
    '    Else
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtapuesta3_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar <> Chr(13)) Then
    '        ' Controlar que ingrese un número
    '        If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
    '            e.Handled = True
    '        End If
    '    Else
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtapuesta4_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar <> Chr(13)) Then
    '        ' Controlar que ingrese un número
    '        If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
    '            e.Handled = True
    '        End If
    '    Else
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtapuesta5_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar <> Chr(13)) Then
    '        ' Controlar que ingrese un número
    '        If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
    '            e.Handled = True
    '        End If
    '    Else
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtapuesta6_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar <> Chr(13)) Then
    '        ' Controlar que ingrese un número
    '        If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
    '            e.Handled = True
    '        End If
    '    Else
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtapuesta7_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar <> Chr(13)) Then
    '        ' Controlar que ingrese un número
    '        If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
    '            e.Handled = True
    '        End If
    '    Else
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtapuesta8_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar <> Chr(13)) Then
    '        ' Controlar que ingrese un número
    '        If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
    '            e.Handled = True
    '        End If
    '    Else
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtapuesta9_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar <> Chr(13)) Then
    '        ' Controlar que ingrese un número
    '        If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
    '            e.Handled = True
    '        End If
    '    Else
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtapuesta0_TextChanged(sender As Object, e As EventArgs)
    '    If (txtapuesta0.Text <> "") Then
    '        txtapuesta0.Text = FormatNumber(txtapuesta0.Text, 0)
    '        txtapuesta0.Select(txtapuesta0.TextLength, 0)
    '    End If
    'End Sub

    'Private Sub txtapuesta1_TextChanged(sender As Object, e As EventArgs)
    '    If (txtapuesta1.Text <> "") Then
    '        txtapuesta1.Text = FormatNumber(txtapuesta1.Text, 0)
    '        txtapuesta1.Select(txtapuesta1.TextLength, 0)
    '    End If
    'End Sub

    'Private Sub txtapuesta2_TextChanged(sender As Object, e As EventArgs)
    '    If (txtapuesta2.Text <> "") Then
    '        txtapuesta2.Text = FormatNumber(txtapuesta2.Text, 0)
    '        txtapuesta2.Select(txtapuesta2.TextLength, 0)
    '    End If
    'End Sub

    'Private Sub txtapuesta3_TextChanged(sender As Object, e As EventArgs)
    '    If (txtapuesta3.Text <> "") Then
    '        txtapuesta3.Text = FormatNumber(txtapuesta3.Text, 0)
    '        txtapuesta3.Select(txtapuesta3.TextLength, 0)
    '    End If
    'End Sub

    'Private Sub txtapuesta4_TextChanged(sender As Object, e As EventArgs)
    '    If (txtapuesta4.Text <> "") Then
    '        txtapuesta4.Text = FormatNumber(txtapuesta4.Text, 0)
    '        txtapuesta4.Select(txtapuesta4.TextLength, 0)
    '    End If
    'End Sub

    'Private Sub txtapuesta5_TextChanged(sender As Object, e As EventArgs)
    '    If (txtapuesta5.Text <> "") Then
    '        txtapuesta5.Text = FormatNumber(txtapuesta5.Text, 0)
    '        txtapuesta5.Select(txtapuesta5.TextLength, 0)
    '    End If
    'End Sub

    'Private Sub txtapuesta6_TextChanged(sender As Object, e As EventArgs)
    '    If (txtapuesta6.Text <> "") Then
    '        txtapuesta6.Text = FormatNumber(txtapuesta6.Text, 0)
    '        txtapuesta6.Select(txtapuesta6.TextLength, 0)
    '    End If
    'End Sub

    'Private Sub txtapuesta7_TextChanged(sender As Object, e As EventArgs)
    '    If (txtapuesta7.Text <> "") Then
    '        txtapuesta7.Text = FormatNumber(txtapuesta7.Text, 0)
    '        txtapuesta7.Select(txtapuesta7.TextLength, 0)
    '    End If
    'End Sub

    'Private Sub txtapuesta8_TextChanged(sender As Object, e As EventArgs)
    '    If (txtapuesta8.Text <> "") Then
    '        txtapuesta8.Text = FormatNumber(txtapuesta8.Text, 0)
    '        txtapuesta8.Select(txtapuesta8.TextLength, 0)
    '    End If
    'End Sub

    'Private Sub txtapuesta9_TextChanged(sender As Object, e As EventArgs)
    '    If (txtapuesta9.Text <> "") Then
    '        txtapuesta9.Text = FormatNumber(txtapuesta9.Text, 0)
    '        txtapuesta9.Select(txtapuesta9.TextLength, 0)
    '    End If
    'End Sub

    'Private Sub txtApostador0_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar = Chr(13)) Then
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtApostador1_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar = Chr(13)) Then
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtApostador2_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar = Chr(13)) Then
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtApostador3_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar = Chr(13)) Then
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtApostador4_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar = Chr(13)) Then
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtApostador5_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar = Chr(13)) Then
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtApostador6_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar = Chr(13)) Then
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtApostador7_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar = Chr(13)) Then
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtApostador8_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar = Chr(13)) Then
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub

    'Private Sub txtApostador9_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If (e.KeyChar = Chr(13)) Then
    '        SelectNextControl(ActiveControl, True, True, True, True)
    '    End If
    'End Sub
End Class