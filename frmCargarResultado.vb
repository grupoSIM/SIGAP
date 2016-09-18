Public Class frmCargarResultado
    Private Sub frmCargarResultado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet1.tb_Carreras' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasTableAdapter.Fill(Me.BdSIGAP_DataSet1.tb_Carreras)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet1.tb_Carreras' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasTableAdapter.Fill(Me.BdSIGAP_DataSet1.tb_Carreras)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Jornadas' table. You can move, or remove it, as needed.
        Me.Tb_JornadasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Jornadas)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Carreras' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Carreras)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_CarrerasCaballos' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasCaballosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_CarrerasCaballos)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_CarrerasCaballos' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasCaballosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_CarrerasCaballos)
        CargarCarreras()

    End Sub

    Private Function CargarCarreras()
        Dim fila As Integer = 0
        Dim filaCarrera As DataRowView
        Dim dtCarreras = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(cbCarrera.SelectedValue)

        Me.BdSIGAP_DataSet.tb_CarrerasCaballos.Clear()

        For Each row As DataRow In dtCarreras.Rows

            filaCarrera = TbCarrerasCaballosBindingSource.AddNew()

            filaCarrera("Id") = row("Id")
            filaCarrera("IdCarrera") = row("IdCarrera")
            filaCarrera("IdCaballo") = row("IdCaballo")
            filaCarrera("NoTomaNuevosRemates") = row("NoTomaNuevosRemates")
            filaCarrera("Posicion") = row("Posicion")
            filaCarrera("Luz") = row("Luz")
            filaCarrera("Orden") = row("Orden")



            fila = fila + 1

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
End Class