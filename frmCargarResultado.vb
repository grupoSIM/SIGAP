Public Class frmCargarResultado
    Dim ctrlImpre As New ControladorImpresion

    Private Sub frmCargarResultado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Caballos' table. You can move, or remove it, as needed.
        Me.Tb_CaballosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Caballos)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet1.tb_Carreras' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasTableAdapter.Fill(Me.BdSIGAP_DataSet1.tb_Carreras)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet1.tb_Carreras' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasTableAdapter.Fill(Me.BdSIGAP_DataSet1.tb_Carreras)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Jornadas' table. You can move, or remove it, as needed.
        Me.Tb_JornadasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Jornadas)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Carreras' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Carreras)
        Me.Tb_DetalleRematesTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_DetalleRemates)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_CarrerasCaballos' table. You can move, or remove it, as needed.
        ' Me.Tb_CarrerasCaballosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_CarrerasCaballos)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_CarrerasCaballos' table. You can move, or remove it, as needed.
        ' Me.Tb_CarrerasCaballosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_CarrerasCaballos)
        CargarCarreras()


    End Sub

    Private Function CargarCarreras()
        ' Dim fila As Integer = 0
        '  Dim filaCarrera As DataRowView
        ' Dim dtCarreras = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(cbCarrera.SelectedValue)

        ' Me.BdSIGAP_DataSet.tb_CarrerasCaballos.Clear()


        Me.Tb_CarrerasCaballosTableAdapter.FillByCarrera(Me.BdSIGAP_DataSet.tb_CarrerasCaballos, cbCarrera.SelectedValue)



    End Function

    Private Function recalcularPremio(ganadores As Integer, remate As DataRow)
        Dim dtCarrerasCaballos = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(cbCarrera.SelectedValue)
        Dim corrieron As Integer = 0
        Dim nocorrieron As Integer = 0
        Dim dtDetallesRemates As DataTable
        Dim drCarreraCaballo As DataRow
        Dim premio As Decimal
        Dim totalApuestaNuevo As Decimal = 0

        For Each rowCC As DataRow In dtCarrerasCaballos.Rows
            If (rowCC("Posicion") <> 100) Then
                corrieron += 1
            Else
                nocorrieron += 1
            End If
        Next
        dtDetallesRemates = Tb_DetalleRematesTableAdapter.GetDataByRemate(remate("Id"))
        If (nocorrieron > 0) Then
            Dim drPorcentajeCasa As DataRow = Tb_PorcentajesCasaTableAdapter.GetDataByCantCaballos(corrieron).Rows(0)
            remate("PorcentajeCasa") = drPorcentajeCasa("Porcentaje")

            For Each rowDR As DataRow In dtDetallesRemates.Rows
                drCarreraCaballo = dtCarrerasCaballos.Rows.Find(rowDR("IdCarreraCaballo"))
                If (drCarreraCaballo("Posicion") <> 100) Then
                    totalApuestaNuevo += rowDR("ImporteApuesta")
                    'rowDR("ImportePremio") = 0
                End If
            Next
            remate("TotalApuestas") = totalApuestaNuevo
            premio = (remate("TotalApuestas") * ((100 - remate("PorcentajeCasa")) / 100))
            premio = Decimal.Round(premio / 10, 0) * 10
            remate("ImportePremio") = premio
            remate("Premio") = premio
            totalApuestaNuevo = 0
        End If
        For Each rowDR As DataRow In dtDetallesRemates.Rows
            drCarreraCaballo = dtCarrerasCaballos.Rows.Find(rowDR("IdCarreraCaballo"))
            If (drCarreraCaballo("Posicion") <> 100) Then
                If (ganadores > 0) Then
                    If (nocorrieron > 0) Then
                        If (rowDR("ImportePremio") > 0) Then
                            rowDR("ImportePremio") = premio / ganadores
                            Tb_DetalleRematesTableAdapter.Update(rowDR)
                        End If
                    Else
                        rowDR("ImportePremio") = rowDR("ImportePremio") / ganadores
                        Tb_DetalleRematesTableAdapter.Update(rowDR)
                    End If
                End If
            End If
        Next
        Tb_RematesTableAdapter.Update(remate)
        'MsgBox(ganadores)
    End Function

    Private Function recalcularPremioOld()
        Dim dtRemates = Tb_RematesTableAdapter.GetDataByCarrera(cbCarrera.SelectedValue)
        Dim dtCarrerasCaballos = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(cbCarrera.SelectedValue)
        Dim dtDetallesRemates As DataTable
        Dim ganadores As Integer = 0
        Dim corrieron As Integer = 0
        Dim drCarreraCaballo As DataRow
        Dim premio As Decimal

        For Each rowCC As DataRow In dtCarrerasCaballos.Rows
            If (rowCC("Posicion") = 1) Then
                ganadores += 1
            End If
            If (rowCC("Posicion") <> 0) Then
                corrieron += 1
            End If
        Next

        Dim dtPorcentajeCasa = Tb_PorcentajesCasaTableAdapter.GetDataByCantCaballos(corrieron).Rows(0)

        For Each rowR As DataRow In dtRemates.Rows
            rowR("PorcentajeCasa") = dtPorcentajeCasa("Porcentaje")
            dtDetallesRemates = Tb_DetalleRematesTableAdapter.GetDataByRemate(cbCarrera.SelectedValue)
            For Each rowDR As DataRow In dtDetallesRemates.Rows
                drCarreraCaballo = dtCarrerasCaballos.Rows.Find(rowDR("IdCarreraCaballo"))
                If (drCarreraCaballo("Posicion") = 0) Then
                    rowR("TotalApuestas") = rowR("TotalApuestas") - rowDR("ImporteApuesta")
                    rowDR("ImportePremio") = 0
                End If
            Next
            premio = (rowR("TotalApuestas") * ((100 - rowR("PorcentajeCasa")) / 100))
            premio = Decimal.Round(premio / 10, 0) * 10
            rowR("ImportePremio") = premio
            For Each rowDR As DataRow In dtDetallesRemates.Rows
                drCarreraCaballo = dtCarrerasCaballos.Rows.Find(rowDR("IdCarreraCaballo"))
                If (drCarreraCaballo("Posicion") <> 0) Then
                    If (ganadores > 0) Then
                        rowDR("ImportePremio") = premio / ganadores
                    End If
                End If
            Next
        Next


    End Function

    Private Function MarcarGanadores()
        Dim ganadores As Integer = 0
        Dim dtRemates As DataTable = Tb_RematesTableAdapter.GetDataByCarrera(cbCarrera.SelectedValue)
        Dim dtDetallesRemates As DataTable
        Dim drDetalleRemate As DataRow
        Dim posicionGanadora As Integer
        Dim hayFila As Boolean
        Dim posFila As Integer = 0
        Dim ganoLuz As Boolean
        Dim segundoRecibeLuz As Boolean = False

        For Each rowR As DataRow In dtRemates.Rows
            dtDetallesRemates = Tb_DetalleRematesTableAdapter.GetDataByIdRemateOrdenadoPorPosicion(rowR("Id"))
            posicionGanadora = dtDetallesRemates.Rows(0).Item("Posicion")
            hayFila = False
            For Each rowDR As DataRow In dtDetallesRemates.Rows
                If (rowDR.Item("Fila")) Then
                    hayFila = True
                    posFila = rowDR("Posicion")
                End If
                If (rowDR.Item("ApostocLuz") = 0) Then
                    ganoLuz = rowDR("GanocLuz")
                End If
                If (rowDR.Item("Posicion") = 2 And rowDR.Item("ApostocLuz") = 1) Then
                    segundoRecibeLuz = True
                End If
            Next
            For Each rowDR As DataRow In dtDetallesRemates.Rows
                drDetalleRemate = BdSIGAP_DataSet.tb_DetalleRemates.FindById(rowDR("Id"))
                If (hayFila) Then
                    If (rowDR.Item("Posicion") = 1) Then
                        drDetalleRemate.Item("ImportePremio") = rowR("ImportePremio")
                        ganadores += 1
                    Else
                        If (rowDR.Item("Fila")) Then
                            drDetalleRemate.Item("ImportePremio") = 0
                        Else
                            If (posFila <> 1) Then
                                drDetalleRemate.Item("ImportePremio") = rowR("ImportePremio")
                                ganadores += 1
                            Else
                                drDetalleRemate.Item("ImportePremio") = 0
                            End If
                        End If
                    End If
                Else
                    If (rowDR.Item("Posicion") = posicionGanadora) Then
                        If (posicionGanadora = 1) Then
                            If (rowDR.Item("ApostocLuz") = 0) Then
                                If (rowDR.Item("GanocLuz")) Then
                                    drDetalleRemate.Item("ImportePremio") = rowR("ImportePremio")
                                    ganadores += 1
                                Else
                                    If (segundoRecibeLuz) Then
                                        drDetalleRemate.Item("ImportePremio") = 0
                                    Else
                                        drDetalleRemate.Item("ImportePremio") = rowR("ImportePremio")
                                        ganadores += 1
                                    End If
                                End If
                            Else
                                drDetalleRemate.Item("ImportePremio") = rowR("ImportePremio")
                                ganadores += 1
                            End If
                        Else
                            drDetalleRemate.Item("ImportePremio") = rowR("ImportePremio")
                            ganadores += 1
                        End If
                    Else
                        If (posicionGanadora = 1) Then
                            If (rowDR.Item("ApostocLuz") = 1) Then
                                If (rowDR.Item("Posicion") = 2 And ganoLuz = False) Then
                                    drDetalleRemate.Item("ImportePremio") = rowR("ImportePremio")
                                    ganadores += 1
                                Else
                                    drDetalleRemate.Item("ImportePremio") = 0
                                End If
                            Else
                                drDetalleRemate.Item("ImportePremio") = 0
                            End If
                        Else
                            drDetalleRemate.Item("ImportePremio") = 0
                        End If
                    End If
                End If
                Tb_DetalleRematesTableAdapter.Update(drDetalleRemate)
            Next
            recalcularPremio(ganadores, rowR)
            ganadores = 0
            posFila = 0
            segundoRecibeLuz = False
        Next
        MsgBox("Terminó")
    End Function

    Private Function MarcarGanadoresOld()
        Dim dtRemates As DataTable
        Dim dtDetallesRemates As DataTable
        Dim dtCarrerasCaballos = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(cbCarrera.SelectedValue)
        Dim drCarreraCaballo As DataRow
        Dim drCarreraCaballo2 As DataRow

        'Tb_CarrerasCaballosTableAdapter.FillByCarrera(carrerasCaballos, cbCarrera.SelectedValue)

        dtRemates = Tb_RematesTableAdapter.GetDataByCarrera(cbCarrera.SelectedValue)
        For Each rowR As DataRow In dtRemates.Rows
            dtDetallesRemates = Tb_DetalleRematesTableAdapter.GetDataByCarrera(cbCarrera.SelectedValue)
            For Each rowDR As DataRow In dtDetallesRemates.Rows
                drCarreraCaballo = dtCarrerasCaballos.Rows.Find(rowDR("IdCarreraCaballo"))
                If (rowDR("Luz") = "0") Then
                    If (drCarreraCaballo("Posicion") = 1 And drCarreraCaballo("Luz")) Then
                        rowDR("ImportePremio") = rowDR("ImportePremio")
                    Else
                        rowDR("ImportePremio") = 0
                    End If
                Else
                    If (rowDR("Luz") = "1") Then
                        For Each rowDR2 As DataRow In dtDetallesRemates.Rows
                            drCarreraCaballo2 = dtCarrerasCaballos.Rows.Find(rowDR2("IdCarreraCaballo"))
                            If (rowDR2("Luz") = "0" And drCarreraCaballo2("Posicion") = 1 And drCarreraCaballo2("Luz")) Then
                                rowDR("ImportePremio") = 0
                            End If
                            If (drCarreraCaballo2("Posicion") > 2) Then
                                rowDR("ImportePremio") = 0
                            End If
                        Next
                    Else
                        If (drCarreraCaballo("Posicion") <> 1) Then
                            rowDR("ImportePremio") = 0
                        End If
                    End If
                End If
                'MsgBox(drCarreraCaballo("IdCaballo"))
            Next
            Tb_DetalleRematesTableAdapter.Update(dtDetallesRemates)
        Next

    End Function


    Private Sub Tb_CarrerasCaballosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub IdCarreraToolStripTextBox_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbCarrera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCarrera.SelectedIndexChanged
        CargarCarreras()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'lo q hacia al guardar
        Me.Validate()
        Me.TbCarrerasCaballosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdSIGAP_DataSet)


        'frmVerResultados.Show()
        'frmVerResultados.txResultado.Text = totalGanadores.ToString()
        'frmVerResultados.nResultados.Value = totalGanadores


        MarcarGanadores()

        ctrlImpre.ImprimirPremios(cbCarrera.SelectedValue)
        ctrlImpre.ImprimirDevoluciones(cbCarrera.SelectedValue)
        'frmVerResultados.Show()
        'frmVerResultados.cbCarrera.SelectedValue = Me.cbCarrera.SelectedValue
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbJornada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJornada.SelectedIndexChanged

    End Sub

    Private Sub nGanadores_ValueChanged(sender As Object, e As EventArgs)

    End Sub
End Class