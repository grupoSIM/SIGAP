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

        'Me.BdSIGAP_DataSet.tb_DetalleRemates.Clear()

        For Each row As DataRow In dtCarrerasCaballos.Rows
            caballo = BdSIGAP_DataSet.tb_Caballos.FindById(row("IdCaballo"))

            Me.Controls("txtNumero" & i).Text = row("Orden")
            Me.Controls("txtNumero" & i).Show()
            Me.Controls("txtCaballo" & i).Text = caballo("CaballoNombre")
            Me.Controls("txtCaballo" & i).Show()
            Me.Controls("txtApostador" & i).Text = ""
            Me.Controls("txtApostador" & i).Show()
            Me.Controls("txtApuesta" & i).Text = ""
            Me.Controls("txtApuesta" & i).Show()
            Me.Controls("chbIncluido" & i).Show()
            Me.Controls("cmbLuz" & i).Show()
            Me.Controls("radFila" & i).Show()

            i = i + 1
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
            txtApostador0.Focus()
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
        Dim i As Integer = 0

        For Each row As DataRow In dtCarrerasCaballos.Rows
            totalApuestas += Me.Controls("txtApuesta" & i).Text
            i += 1
        Next

        Tb_RematesTableAdapter.Insert(cmbCarrera.SelectedValue, cmbPalco.SelectedValue, txtPorcentajeCasa.Text, (totalApuestas * ((100 - txtPorcentajeCasa.Text) / 100)), 1, totalApuestas, vbNull, txtRemate.Text)
        i = 0
        For Each row As DataRow In dtCarrerasCaballos.Rows
            Select Case i
                Case 0
                    Tb_DetalleRematesTableAdapter.Insert(Tb_RematesTableAdapter.MaxId(), row("Id"), txtNumero0.Text, txtApostador0.Text, txtapuesta0.Text, cmbLuz0.SelectedIndex, radFila0.Checked, (totalApuestas * ((100 - txtPorcentajeCasa.Text) / 100)), chbincluido0.Checked, vbNull)
                Case 1
                    Tb_DetalleRematesTableAdapter.Insert(Tb_RematesTableAdapter.MaxId(), row("Id"), txtNumero1.Text, txtApostador1.Text, txtapuesta1.Text, cmbLuz1.SelectedIndex, radFila1.Checked, (totalApuestas * ((100 - txtPorcentajeCasa.Text) / 100)), chbincluido1.Checked, vbNull)
                Case 2
                    Tb_DetalleRematesTableAdapter.Insert(Tb_RematesTableAdapter.MaxId(), row("Id"), txtNumero2.Text, txtApostador2.Text, txtapuesta2.Text, cmbLuz2.SelectedIndex, radFila2.Checked, (totalApuestas * ((100 - txtPorcentajeCasa.Text) / 100)), chbincluido2.Checked, vbNull)
                Case 3
                    Tb_DetalleRematesTableAdapter.Insert(Tb_RematesTableAdapter.MaxId(), row("Id"), txtNumero3.Text, txtApostador3.Text, txtapuesta3.Text, cmbLuz3.SelectedIndex, radFila3.Checked, (totalApuestas * ((100 - txtPorcentajeCasa.Text) / 100)), chbincluido3.Checked, vbNull)
                Case 4
                    Tb_DetalleRematesTableAdapter.Insert(Tb_RematesTableAdapter.MaxId(), row("Id"), txtNumero4.Text, txtApostador4.Text, txtapuesta4.Text, cmbLuz4.SelectedIndex, radFila4.Checked, (totalApuestas * ((100 - txtPorcentajeCasa.Text) / 100)), chbincluido4.Checked, vbNull)
                Case 5
                    Tb_DetalleRematesTableAdapter.Insert(Tb_RematesTableAdapter.MaxId(), row("Id"), txtNumero5.Text, txtApostador5.Text, txtapuesta5.Text, cmbLuz5.SelectedIndex, radFila5.Checked, (totalApuestas * ((100 - txtPorcentajeCasa.Text) / 100)), chbincluido5.Checked, vbNull)
                Case 6
                    Tb_DetalleRematesTableAdapter.Insert(Tb_RematesTableAdapter.MaxId(), row("Id"), txtNumero6.Text, txtApostador6.Text, txtapuesta6.Text, cmbLuz6.SelectedIndex, radFila6.Checked, (totalApuestas * ((100 - txtPorcentajeCasa.Text) / 100)), chbincluido6.Checked, vbNull)
                Case 7
                    Tb_DetalleRematesTableAdapter.Insert(Tb_RematesTableAdapter.MaxId(), row("Id"), txtNumero7.Text, txtApostador7.Text, txtapuesta7.Text, cmbLuz7.SelectedIndex, radFila7.Checked, (totalApuestas * ((100 - txtPorcentajeCasa.Text) / 100)), chbincluido7.Checked, vbNull)
                Case 8
                    Tb_DetalleRematesTableAdapter.Insert(Tb_RematesTableAdapter.MaxId(), row("Id"), txtNumero8.Text, txtApostador8.Text, txtapuesta8.Text, cmbLuz8.SelectedIndex, radFila8.Checked, (totalApuestas * ((100 - txtPorcentajeCasa.Text) / 100)), chbincluido8.Checked, vbNull)
                Case 9
                    Tb_DetalleRematesTableAdapter.Insert(Tb_RematesTableAdapter.MaxId(), row("Id"), txtNumero9.Text, txtApostador9.Text, txtapuesta9.Text, cmbLuz9.SelectedIndex, radFila9.Checked, (totalApuestas * ((100 - txtPorcentajeCasa.Text) / 100)), chbincluido9.Checked, vbNull)
            End Select
            i += 1
        Next

        CargarRemates()
        CargarDetallesRemates()
        txtApostador0.Focus()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim totalApuestas As Integer = 0
        Dim dtCarrerasCaballos = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(cmbCarrera.SelectedValue)
        Dim i As Integer = 0
        Dim detalles As DataTable

        For Each row As DataRow In dtCarrerasCaballos.Rows
            totalApuestas += Me.Controls("txtApuesta" & i).Text
            i += 1
        Next

        Tb_RematesTableAdapter.Insert(cmbCarrera.SelectedValue, cmbPalco.SelectedValue, txtPorcentajeCasa.Text, (totalApuestas * ((100 - txtPorcentajeCasa.Text) / 100)), 1, totalApuestas, vbNull, txtRemate.Text)
        i = 0
        For Each row As DataRow In dtCarrerasCaballos.Rows
            Select Case i
                Case 0
                    Tb_DetalleRematesTableAdapter.Insert(Tb_RematesTableAdapter.MaxId(), row("Id"), txtNumero0.Text, txtApostador0.Text, txtapuesta0.Text, cmbLuz0.SelectedIndex, radFila0.Checked, (totalApuestas * ((100 - txtPorcentajeCasa.Text) / 100)), chbincluido0.Checked, vbNull)
                Case 1
                    Tb_DetalleRematesTableAdapter.Insert(Tb_RematesTableAdapter.MaxId(), row("Id"), txtNumero1.Text, txtApostador1.Text, txtapuesta1.Text, cmbLuz1.SelectedIndex, radFila1.Checked, (totalApuestas * ((100 - txtPorcentajeCasa.Text) / 100)), chbincluido1.Checked, vbNull)
                Case 2
                    Tb_DetalleRematesTableAdapter.Insert(Tb_RematesTableAdapter.MaxId(), row("Id"), txtNumero2.Text, txtApostador2.Text, txtapuesta2.Text, cmbLuz2.SelectedIndex, radFila2.Checked, (totalApuestas * ((100 - txtPorcentajeCasa.Text) / 100)), chbincluido2.Checked, vbNull)
                Case 3
                    Tb_DetalleRematesTableAdapter.Insert(Tb_RematesTableAdapter.MaxId(), row("Id"), txtNumero3.Text, txtApostador3.Text, txtapuesta3.Text, cmbLuz3.SelectedIndex, radFila3.Checked, (totalApuestas * ((100 - txtPorcentajeCasa.Text) / 100)), chbincluido3.Checked, vbNull)
                Case 4
                    Tb_DetalleRematesTableAdapter.Insert(Tb_RematesTableAdapter.MaxId(), row("Id"), txtNumero4.Text, txtApostador4.Text, txtapuesta4.Text, cmbLuz4.SelectedIndex, radFila4.Checked, (totalApuestas * ((100 - txtPorcentajeCasa.Text) / 100)), chbincluido4.Checked, vbNull)
                Case 5
                    Tb_DetalleRematesTableAdapter.Insert(Tb_RematesTableAdapter.MaxId(), row("Id"), txtNumero5.Text, txtApostador5.Text, txtapuesta5.Text, cmbLuz5.SelectedIndex, radFila5.Checked, (totalApuestas * ((100 - txtPorcentajeCasa.Text) / 100)), chbincluido5.Checked, vbNull)
                Case 6
                    Tb_DetalleRematesTableAdapter.Insert(Tb_RematesTableAdapter.MaxId(), row("Id"), txtNumero6.Text, txtApostador6.Text, txtapuesta6.Text, cmbLuz6.SelectedIndex, radFila6.Checked, (totalApuestas * ((100 - txtPorcentajeCasa.Text) / 100)), chbincluido6.Checked, vbNull)
                Case 7
                    Tb_DetalleRematesTableAdapter.Insert(Tb_RematesTableAdapter.MaxId(), row("Id"), txtNumero7.Text, txtApostador7.Text, txtapuesta7.Text, cmbLuz7.SelectedIndex, radFila7.Checked, (totalApuestas * ((100 - txtPorcentajeCasa.Text) / 100)), chbincluido7.Checked, vbNull)
                Case 8
                    Tb_DetalleRematesTableAdapter.Insert(Tb_RematesTableAdapter.MaxId(), row("Id"), txtNumero8.Text, txtApostador8.Text, txtapuesta8.Text, cmbLuz8.SelectedIndex, radFila8.Checked, (totalApuestas * ((100 - txtPorcentajeCasa.Text) / 100)), chbincluido8.Checked, vbNull)
                Case 9
                    Tb_DetalleRematesTableAdapter.Insert(Tb_RematesTableAdapter.MaxId(), row("Id"), txtNumero9.Text, txtApostador9.Text, txtapuesta9.Text, cmbLuz9.SelectedIndex, radFila9.Checked, (totalApuestas * ((100 - txtPorcentajeCasa.Text) / 100)), chbincluido9.Checked, vbNull)
            End Select
            i += 1
        Next

        detalles = Tb_DetalleRematesTableAdapter.GetDataByRemate(Tb_RematesTableAdapter.MaxId())

        For Each row As DataRow In detalles.Rows

            Imprimir(row("Id"))

        Next

        CargarRemates()
        CargarDetallesRemates()
        txtApostador0.Focus()
        'MsgBox(totalApuestas)
    End Sub

    Private Sub txtPorcentajeCasa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPorcentajeCasa.KeyPress
        If (e.KeyChar <> Chr(13)) Then
            ' Controlar que ingrese un número
            If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
                e.Handled = True
            End If
        Else
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtNumero0_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero0.KeyPress
        If (e.KeyChar <> Chr(13)) Then
            ' Controlar que ingrese un número
            If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
                e.Handled = True
            End If
        Else
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtNumero1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero1.KeyPress
        If (e.KeyChar <> Chr(13)) Then
            ' Controlar que ingrese un número
            If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
                e.Handled = True
            End If
        Else
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtNumero2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero2.KeyPress
        If (e.KeyChar <> Chr(13)) Then
            ' Controlar que ingrese un número
            If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
                e.Handled = True
            End If
        Else
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtNumero3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero3.KeyPress
        If (e.KeyChar <> Chr(13)) Then
            ' Controlar que ingrese un número
            If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
                e.Handled = True
            End If
        Else
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtNumero4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero4.KeyPress
        If (e.KeyChar <> Chr(13)) Then
            ' Controlar que ingrese un número
            If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
                e.Handled = True
            End If
        Else
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtNumero5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero5.KeyPress
        If (e.KeyChar <> Chr(13)) Then
            ' Controlar que ingrese un número
            If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
                e.Handled = True
            End If
        Else
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtNumero6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero6.KeyPress
        If (e.KeyChar <> Chr(13)) Then
            ' Controlar que ingrese un número
            If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
                e.Handled = True
            End If
        Else
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtNumero7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero7.KeyPress
        If (e.KeyChar <> Chr(13)) Then
            ' Controlar que ingrese un número
            If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
                e.Handled = True
            End If
        Else
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtNumero8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero8.KeyPress
        If (e.KeyChar <> Chr(13)) Then
            ' Controlar que ingrese un número
            If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
                e.Handled = True
            End If
        Else
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtNumero9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero9.KeyPress
        If (e.KeyChar <> Chr(13)) Then
            ' Controlar que ingrese un número
            If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
                e.Handled = True
            End If
        Else
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtapuesta0_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapuesta0.KeyPress
        If (e.KeyChar <> Chr(13)) Then
            ' Controlar que ingrese un número
            If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
                e.Handled = True
            End If
        Else
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtapuesta1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapuesta1.KeyPress
        If (e.KeyChar <> Chr(13)) Then
            ' Controlar que ingrese un número
            If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
                e.Handled = True
            End If
        Else
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtapuesta2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapuesta2.KeyPress
        If (e.KeyChar <> Chr(13)) Then
            ' Controlar que ingrese un número
            If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
                e.Handled = True
            End If
        Else
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtapuesta3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapuesta3.KeyPress
        If (e.KeyChar <> Chr(13)) Then
            ' Controlar que ingrese un número
            If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
                e.Handled = True
            End If
        Else
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtapuesta4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapuesta4.KeyPress
        If (e.KeyChar <> Chr(13)) Then
            ' Controlar que ingrese un número
            If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
                e.Handled = True
            End If
        Else
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtapuesta5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapuesta5.KeyPress
        If (e.KeyChar <> Chr(13)) Then
            ' Controlar que ingrese un número
            If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
                e.Handled = True
            End If
        Else
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtapuesta6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapuesta6.KeyPress
        If (e.KeyChar <> Chr(13)) Then
            ' Controlar que ingrese un número
            If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
                e.Handled = True
            End If
        Else
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtapuesta7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapuesta7.KeyPress
        If (e.KeyChar <> Chr(13)) Then
            ' Controlar que ingrese un número
            If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
                e.Handled = True
            End If
        Else
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtapuesta8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapuesta8.KeyPress
        If (e.KeyChar <> Chr(13)) Then
            ' Controlar que ingrese un número
            If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
                e.Handled = True
            End If
        Else
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtapuesta9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapuesta9.KeyPress
        If (e.KeyChar <> Chr(13)) Then
            ' Controlar que ingrese un número
            If (Not Char.IsNumber(e.KeyChar) And (e.KeyChar <> Microsoft.VisualBasic.ChrW(8))) Then
                e.Handled = True
            End If
        Else
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtapuesta0_TextChanged(sender As Object, e As EventArgs) Handles txtapuesta0.TextChanged
        If (txtapuesta0.Text <> "") Then
            txtapuesta0.Text = FormatNumber(txtapuesta0.Text, 0)
            txtapuesta0.Select(txtapuesta0.TextLength, 0)
        End If
    End Sub

    Private Sub txtapuesta1_TextChanged(sender As Object, e As EventArgs) Handles txtapuesta1.TextChanged
        If (txtapuesta1.Text <> "") Then
            txtapuesta1.Text = FormatNumber(txtapuesta1.Text, 0)
            txtapuesta1.Select(txtapuesta1.TextLength, 0)
        End If
    End Sub

    Private Sub txtapuesta2_TextChanged(sender As Object, e As EventArgs) Handles txtapuesta2.TextChanged
        If (txtapuesta2.Text <> "") Then
            txtapuesta2.Text = FormatNumber(txtapuesta2.Text, 0)
            txtapuesta2.Select(txtapuesta2.TextLength, 0)
        End If
    End Sub

    Private Sub txtapuesta3_TextChanged(sender As Object, e As EventArgs) Handles txtapuesta3.TextChanged
        If (txtapuesta3.Text <> "") Then
            txtapuesta3.Text = FormatNumber(txtapuesta3.Text, 0)
            txtapuesta3.Select(txtapuesta3.TextLength, 0)
        End If
    End Sub

    Private Sub txtapuesta4_TextChanged(sender As Object, e As EventArgs) Handles txtapuesta4.TextChanged
        If (txtapuesta4.Text <> "") Then
            txtapuesta4.Text = FormatNumber(txtapuesta4.Text, 0)
            txtapuesta4.Select(txtapuesta4.TextLength, 0)
        End If
    End Sub

    Private Sub txtapuesta5_TextChanged(sender As Object, e As EventArgs) Handles txtapuesta5.TextChanged
        If (txtapuesta5.Text <> "") Then
            txtapuesta5.Text = FormatNumber(txtapuesta5.Text, 0)
            txtapuesta5.Select(txtapuesta5.TextLength, 0)
        End If
    End Sub

    Private Sub txtapuesta6_TextChanged(sender As Object, e As EventArgs) Handles txtapuesta6.TextChanged
        If (txtapuesta6.Text <> "") Then
            txtapuesta6.Text = FormatNumber(txtapuesta6.Text, 0)
            txtapuesta6.Select(txtapuesta6.TextLength, 0)
        End If
    End Sub

    Private Sub txtapuesta7_TextChanged(sender As Object, e As EventArgs) Handles txtapuesta7.TextChanged
        If (txtapuesta7.Text <> "") Then
            txtapuesta7.Text = FormatNumber(txtapuesta7.Text, 0)
            txtapuesta7.Select(txtapuesta7.TextLength, 0)
        End If
    End Sub

    Private Sub txtapuesta8_TextChanged(sender As Object, e As EventArgs) Handles txtapuesta8.TextChanged
        If (txtapuesta8.Text <> "") Then
            txtapuesta8.Text = FormatNumber(txtapuesta8.Text, 0)
            txtapuesta8.Select(txtapuesta8.TextLength, 0)
        End If
    End Sub

    Private Sub txtapuesta9_TextChanged(sender As Object, e As EventArgs) Handles txtapuesta9.TextChanged
        If (txtapuesta9.Text <> "") Then
            txtapuesta9.Text = FormatNumber(txtapuesta9.Text, 0)
            txtapuesta9.Select(txtapuesta9.TextLength, 0)
        End If
    End Sub

    Private Sub txtApostador0_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApostador0.KeyPress
        If (e.KeyChar = Chr(13)) Then
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtApostador1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApostador1.KeyPress
        If (e.KeyChar = Chr(13)) Then
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtApostador2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApostador2.KeyPress
        If (e.KeyChar = Chr(13)) Then
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtApostador3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApostador3.KeyPress
        If (e.KeyChar = Chr(13)) Then
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtApostador4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApostador4.KeyPress
        If (e.KeyChar = Chr(13)) Then
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtApostador5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApostador5.KeyPress
        If (e.KeyChar = Chr(13)) Then
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtApostador6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApostador6.KeyPress
        If (e.KeyChar = Chr(13)) Then
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtApostador7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApostador7.KeyPress
        If (e.KeyChar = Chr(13)) Then
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtApostador8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApostador8.KeyPress
        If (e.KeyChar = Chr(13)) Then
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    Private Sub txtApostador9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApostador9.KeyPress
        If (e.KeyChar = Chr(13)) Then
            SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub
End Class