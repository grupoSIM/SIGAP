Public Class frmCarreraCaballo

    Public varNumero As Integer

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub frmCarreraCaballo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Carreras' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Carreras)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Caballos' table. You can move, or remove it, as needed.
        Me.Tb_CaballosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Caballos)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Jornadas' table. You can move, or remove it, as needed.
        Me.Tb_JornadasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Jornadas)

        varNumero = 3 'esta variable debe cargarse en el load del form' 


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJornada.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles agregarCaballo.Click
        frmCaballo.Show()
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim varNombreCombo As String
        Dim varNumCombo As String


        varNombreCombo = "cbCaballo"
        varNumCombo = CStr(varNumero)

        varNombreCombo = varNombreCombo & varNumCombo

        If varNumero = 3 Then
            nbCaballo3.Visible = True
            cbCaballo3.Visible = True
        End If
        If varNumero = 4 Then
            nbCaballo4.Visible = True
            cbCaballo4.Visible = True
        End If
        If varNumero = 5 Then
            nbCaballo5.Visible = True
            cbCaballo5.Visible = True
        End If
        If varNumero = 6 Then
            nbCaballo6.Visible = True
            cbCaballo6.Visible = True
        End If
        If varNumero = 7 Then
            nbCaballo7.Visible = True
            cbCaballo7.Visible = True
        End If
        If varNumero = 8 Then
            nbCaballo8.Visible = True
            cbCaballo8.Visible = True
        End If
        If varNumero = 9 Then
            nbCaballo9.Visible = True
            cbCaballo9.Visible = True
        End If
        If varNumero = 10 Then
            nbCaballo10.Visible = True
            cbCaballo10.Visible = True
        End If

        If varNumero < 11 Then
            varNumero = varNumero + 1
        Else
            MessageBox.Show("No se pueden agregar mas Ponys", "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If


    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        Dim varNombreCombo As String
        Dim varNumCombo As String

        varNombreCombo = "cbCaballo"
        varNumCombo = CStr(varNumero)

        varNombreCombo = varNombreCombo & varNumCombo

        If varNumero = 3 Then
            nbCaballo3.Visible = False
            cbCaballo3.Visible = False
        End If
        If varNumero = 4 Then
            nbCaballo4.Visible = False
            cbCaballo4.Visible = False
        End If
        If varNumero = 5 Then
            nbCaballo5.Visible = False
            cbCaballo5.Visible = False
        End If
        If varNumero = 6 Then
            nbCaballo6.Visible = False
            cbCaballo6.Visible = False
        End If
        If varNumero = 7 Then
            nbCaballo7.Visible = False
            cbCaballo7.Visible = False
        End If
        If varNumero = 8 Then
            nbCaballo8.Visible = False
            cbCaballo8.Visible = False
        End If
        If varNumero = 9 Then
            nbCaballo9.Visible = False
            cbCaballo9.Visible = False
        End If
        If varNumero = 10 Then
            nbCaballo10.Visible = False
            cbCaballo10.Visible = False
        End If

        If varNumero < 11 Then
            If varNumero > 2 Then
                varNumero = varNumero - 1
            Else
                MessageBox.Show("No se pueden quitar mas Ponys", "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

        If cbCaballo3.Visible = False Then
            MessageBox.Show("esta deshabilitado", "SiGAp", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        End If


    End Sub

    Private Function RecuperarPorcentaje()
        Dim i As Integer = 1
        Dim porCaballos As Integer = 0
        Dim cont As Integer = 0

        For Each cb As ComboBox In Controls.OfType(Of ComboBox)
            If cb.Visible = True And cb.Name <> "cbJornada" Then
                cont += 1
            End If
        Next

        'MessageBox.Show(cont, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        If cont > 1 Then
            porCaballos = Tb_PorcentajesCasaTableAdapter.GetPorcentajeByCantidadCaballos(cont)
        End If

        Return porCaballos
    End Function

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        '#1 CARGAR CARRERA'
        Dim filaCarrera As DataRowView

        nProcentajeCasa.Value = RecuperarPorcentaje()

        filaCarrera = TbCarrerasBindingSource.AddNew()

        filaCarrera("IdJornada") = cbJornada.SelectedValue
        filaCarrera("NroCarrera") = nCarrera.Value
        filaCarrera("Nombre") = txNombre.Text
        filaCarrera("Metros") = txMetros.Text
        filaCarrera("Estado") = 0
        filaCarrera("PorcentajeCasa") = nProcentajeCasa.Value
        filaCarrera("PorcentajeUltimoRemate") = nProcentajeCasa.Value
        filaCarrera("TipoCarrera") = "Normal"
        filaCarrera("Observaciones") = " "

        Me.Validate()
        Me.TbCarrerasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdSIGAP_DataSet)


        ' MessageBox.Show(nro, "SiGAp", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)'

        '#2 CARGAR CARRERA - CABALLO'
        Dim filaCaballo As DataRowView

        If cbCaballo1.Visible = True Then
            filaCaballo = TbCarrerasCaballosBindingSource.AddNew()
            filaCaballo("IdCarrera") = Tb_CarrerasTableAdapter.maxId()
            filaCaballo("IdCaballo") = cbCaballo1.SelectedValue
            filaCaballo("Orden") = nbCaballo1.Value
        End If
        If cbCaballo2.Visible = True Then
            filaCaballo = TbCarrerasCaballosBindingSource.AddNew()
            filaCaballo("IdCarrera") = Tb_CarrerasTableAdapter.maxId()
            filaCaballo("IdCaballo") = cbCaballo2.SelectedValue
            filaCaballo("Orden") = nbCaballo2.Value
        End If
        If cbCaballo3.Visible = True Then
            filaCaballo = TbCarrerasCaballosBindingSource.AddNew()
            filaCaballo("IdCarrera") = Tb_CarrerasTableAdapter.maxId()
            filaCaballo("IdCaballo") = cbCaballo3.SelectedValue
            filaCaballo("Orden") = nbCaballo3.Value
        End If
        If cbCaballo4.Visible = True Then
            filaCaballo = TbCarrerasCaballosBindingSource.AddNew()
            filaCaballo("IdCarrera") = Tb_CarrerasTableAdapter.maxId()
            filaCaballo("IdCaballo") = cbCaballo4.SelectedValue
            filaCaballo("Orden") = nbCaballo4.Value
        End If
        If cbCaballo5.Visible = True Then
            filaCaballo = TbCarrerasCaballosBindingSource.AddNew()
            filaCaballo("IdCarrera") = Tb_CarrerasTableAdapter.maxId()
            filaCaballo("IdCaballo") = cbCaballo5.SelectedValue
            filaCaballo("Orden") = nbCaballo5.Value
        End If
        If cbCaballo6.Visible = True Then
            filaCaballo = TbCarrerasCaballosBindingSource.AddNew()
            filaCaballo("IdCarrera") = Tb_CarrerasTableAdapter.maxId()
            filaCaballo("IdCaballo") = cbCaballo6.SelectedValue
            filaCaballo("Orden") = nbCaballo6.Value
        End If
        If cbCaballo7.Visible = True Then
            filaCaballo = TbCarrerasCaballosBindingSource.AddNew()
            filaCaballo("IdCarrera") = Tb_CarrerasTableAdapter.maxId()
            filaCaballo("IdCaballo") = cbCaballo7.SelectedValue
            filaCaballo("Orden") = nbCaballo7.Value
        End If
        If cbCaballo8.Visible = True Then
            filaCaballo = TbCarrerasCaballosBindingSource.AddNew()
            filaCaballo("IdCarrera") = Tb_CarrerasTableAdapter.maxId()
            filaCaballo("IdCaballo") = cbCaballo8.SelectedValue
            filaCaballo("Orden") = nbCaballo8.Value
        End If
        If cbCaballo9.Visible = True Then
            filaCaballo = TbCarrerasCaballosBindingSource.AddNew()
            filaCaballo("IdCarrera") = Tb_CarrerasTableAdapter.maxId()
            filaCaballo("IdCaballo") = cbCaballo9.SelectedValue
            filaCaballo("Orden") = nbCaballo9.Value
        End If
        If cbCaballo10.Visible = True Then
            filaCaballo = TbCarrerasCaballosBindingSource.AddNew()
            filaCaballo("IdCarrera") = Tb_CarrerasTableAdapter.maxId()
            filaCaballo("IdCaballo") = cbCaballo10.SelectedValue
            filaCaballo("Orden") = nbCaballo10.Value
        End If

        Me.Validate()
        Me.TbCarrerasCaballosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdSIGAP_DataSet)

        MessageBox.Show("Se ha Creado La Carrera: " & txNombre.Text, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) '

        LimpiarCarrera()


    End Sub
    Private Function LimpiarCarrera()
        nCarrera.Value = 0
        txNombre.Text = ""
        txMetros.Text = "0"
        nProcentajeCasa.Value = 10



    End Function

    Private Sub Label6_Click_1(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class