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
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_DetalleRemates' table. You can move, or remove it, as needed.
        'Me.Tb_DetalleRematesTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_DetalleRemates)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_CarrerasCaballos' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasCaballosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_CarrerasCaballos)

        CargarRemates()
        CargarDetallesRemates()

    End Sub

    Private Sub frmRemate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        MsgBox("Tecla presionada", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send(Keys.Tab)
        End If
    End Sub

    Private Function CargarDetallesRemates()
        Dim fila As Integer = 0
        Dim caballo As DataRow
        Dim filaNueva As DataRowView
        Dim dtCarrerasCaballos = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(cmbCarrera.SelectedValue)
        Dim i As Integer = 0

        'Me.BdSIGAP_DataSet.tb_DetalleRemates.Clear()

        For Each row As DataRow In dtCarrerasCaballos.Rows
            caballo = BdSIGAP_DataSet.tb_Caballos.FindById(row("IdCaballo"))

            Me.Controls("txtNumero" & i).Text = row("Orden")
            Me.Controls("txtNumero" & i).Visible = True
            Me.Controls("txtCaballo" & i).Text = caballo("CaballoNombre")
            Me.Controls("txtCaballo" & i).Visible = True
            Me.Controls("txtApostador" & i).Visible = True
            Me.Controls("mtxApuesta" & i).Visible = True
            Me.Controls("chbIncluido" & i).Text = True
            Me.Controls("chbIncluido" & i).Visible = True
            Me.Controls("cmbLuz" & i).Visible = True
            Me.Controls("radFila" & i).Visible = True

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
        End If

    End Sub



    ' INICIO Codigo de Impresion
    Private Declare Function GetTickCount Lib "kernel32" () As Integer
    Private Sub Imprimir(id)
        'MsgBox(id, MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        txtId.Text = id
        Form1.Show()

        Dim retraso As Integer
        retraso = 500 + GetTickCount
        While retraso >= GetTickCount
            Application.DoEvents()
        End While
        Form1.Close()
        ' FIN Codigo de Impresion
    End Sub

    Private Sub DataGridView1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnImprimir.Focus()
        End If
    End Sub

End Class