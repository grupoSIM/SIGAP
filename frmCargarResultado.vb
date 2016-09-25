Public Class frmCargarResultado
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

    Private Function recalcularPremio()
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
            dtDetallesRemates = Tb_DetalleRematesTableAdapter.GetDataByCarrera(cbCarrera.SelectedValue)
            For Each rowDR As DataRow In dtDetallesRemates.Rows
                drCarreraCaballo = dtCarrerasCaballos.Rows.Find(rowDR("IdCarreraCaballo"))
                If (drCarreraCaballo("Posicion") = 0) Then
                    rowR("TotalApuestas") = rowR("TotalApuestas") - rowDR("ImporteApuesta")
                    rowDR("ImportePremio") = 0
                End If
            Next
            premio = (rowR("TotalApuestas") * ((100 - rowR("PorcentajeCasa")) / 100))
            premio = Decimal.Round(premio / 5, 0) * 5
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
        Dim totalGanadores As Integer

        For i As Integer = 0 To DataGridView1.RowCount - 1
            If DataGridView1.Rows(i).Cells(5).Value = 1 Then
                totalGanadores = totalGanadores + 1
            End If
        Next

        'frmVerResultados.Show()
        'frmVerResultados.txResultado.Text = totalGanadores.ToString()
        'frmVerResultados.nResultados.Value = totalGanadores


        MarcarGanadores()
        frmVerResultados.Show()
        frmVerResultados.cbCarrera.SelectedValue = Me.cbCarrera.SelectedValue
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Me.Validate()
        Me.TbCarrerasCaballosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdSIGAP_DataSet)
    End Sub

    Private Sub cbJornada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJornada.SelectedIndexChanged

    End Sub
End Class