﻿Public Class frmJornada
    Private Sub frmJornada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Eventos' table. You can move, or remove it, as needed.
        Me.Tb_EventosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Eventos)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Jornadas' table. You can move, or remove it, as needed.
        Me.Tb_JornadasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Jornadas)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Hipodromos' table. You can move, or remove it, as needed.
        Me.Tb_HipodromosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Hipodromos)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Hipodromos' table. You can move, or remove it, as needed.
        Me.Tb_HipodromosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Hipodromos)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Jornadas' table. You can move, or remove it, as needed.
        Me.Tb_JornadasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Jornadas)

    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Me.Validate()
        Me.TbJornadasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BdSIGAP_DataSet)
    End Sub
End Class