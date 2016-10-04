﻿Public Class frmModiRemate
    Private Sub frmModificarRemate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Palcos' table. You can move, or remove it, as needed.
        Me.Tb_PalcosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Palcos)

        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Carreras' table. You can move, or remove it, as needed.
        'Me.Tb_CarrerasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Carreras)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Jornadas' table. You can move, or remove it, as needed.
        Me.Tb_JornadasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Jornadas)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_DetalleRemates' table. You can move, or remove it, as needed.
        'Me.Tb_DetalleRematesTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_DetalleRemates)

        Dim carreras = Tb_CarrerasTableAdapter.GetDataByJornada(cbJornada.SelectedValue)
        cbCarrera.DataSource = carreras

        If txRemate.Text <> "" Then
            CargarRemate(txRemate.Text)
            CargarDetalleRemate(txRemate.Text)
        Else
            Me.Tb_DetalleRematesTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_DetalleRemates)
        End If


    End Sub

    Private Function CargarRemate(ByVal NroRemate As Integer)
        Dim IdRemate = Me.Tb_RematesTableAdapter.GetIdByCarreraYNroRemate(cbCarrera.SelectedValue, NroRemate)
        Dim remate = Me.Tb_RematesTableAdapter.GetDataByIdRemate(IdRemate)

        Me.cbPalco.SelectedValue = remate.Rows(0).Item("IdPalco")
        Me.txTotalApuestas.Text = remate.Rows(0).Item("TotalApuestas")
        Me.txPorcCasa.Text = remate.Rows(0).Item("PorcentajeCasa")
        Me.txPremio.Text = remate.Rows(0).Item("Premio")

    End Function
    Private Function CargarDetalleRemate(ByVal NroRemate As Integer)
        Dim IdRemate = Me.Tb_RematesTableAdapter.GetIdByCarreraYNroRemate(cbCarrera.SelectedValue, NroRemate)
        MessageBox.Show("IdRemate" & IdRemate, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Me.Tb_DetalleRematesTableAdapter.FillByRemate(Me.BdSIGAP_DataSet.tb_DetalleRemates, IdRemate)
    End Function

    Private Sub cbJornada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJornada.SelectedIndexChanged
        Dim carreras = Tb_CarrerasTableAdapter.GetDataByJornada(cbJornada.SelectedValue)
        cbCarrera.DataSource = carreras
    End Sub

    Private Sub txRemate_TextChanged(sender As Object, e As EventArgs) Handles txRemate.TextChanged
        'MessageBox.Show("entra en el chnge ", "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        CargarRemate(txRemate.Text)
        CargarDetalleRemate(txRemate.Text)
    End Sub

    Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click
        Me.TbDetalleRematesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdSIGAP_DataSet)
    End Sub





    Private Function RecuperarPorcentaje()
        Dim porCaballos As Integer = 0
        Dim cont As Integer
        Dim i As Integer = 0

        For DetalleRemate As Integer = 1 To Me.DataGridView.RowCount - 1
            If Me.DataGridView.Rows(i).Cells("Incluido").Value = True Then
                cont += 1
                MessageBox.Show(cont, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
            i += 1
        Next
        If cont > 1 Then
            porCaballos = Tb_PorcentajesCasaTableAdapter.GetPorcentajeByCantidadCaballos(cont)
        End If
        Return porCaballos
    End Function

    Private Function RecuperarTotalApuesta()
        Dim totalApuesta As Integer = 0
        Dim i As Integer = 0

        For DetalleRemate As Integer = 1 To Me.DataGridView.RowCount - 1
            If Me.DataGridView.Rows(i).Cells("Incluido").Value = True Then
                totalApuesta = totalApuesta + Me.DataGridView.Rows(i).Cells("ImporteApuesta").Value
                'MessageBox.Show(cont, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
            i += 1
        Next
        Return totalApuesta
    End Function

    Private Sub DataGridView1_Cellc(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellEndEdit
        'Controlo los porcentajes
        Me.txPorcCasa.Text = RecuperarPorcentaje()

        Me.txTotalApuestas.Text = RecuperarTotalApuesta()
        'Me.cbPalco.SelectedValue = remate.Rows(0).Item("IdPalco")


        'Me.txPremio.Text = remate.Rows(0).Item("Premio")

    End Sub

End Class