Public Class frmCargarLlave
    Private Sub frmCargarLlave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Caballos' table. You can move, or remove it, as needed.
        Me.Tb_CaballosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Caballos)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_CarrerasCaballos' table. You can move, or remove it, as needed.
        ' Me.Tb_CarrerasCaballosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_CarrerasCaballos)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Carreras' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Carreras)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Jornadas' table. You can move, or remove it, as needed.
        Me.Tb_JornadasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Jornadas)

        CargarCaballos1()
        CargarCaballos2()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub cbCarrera1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCarrera1.SelectedIndexChanged
        CargarCaballos1()
        CargarCaballos2()
    End Sub

    Private Function CargarCaballos1()

        Dim dtCarrerasCaballos = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(cbCarrera1.SelectedValue)
        Dim i As Integer = 1
        Dim caballo As DataRow

        For Each row As DataRow In dtCarrerasCaballos.Rows

            caballo = BdSIGAP_DataSet.tb_Caballos.FindById(row("IdCaballo"))

            Me.Controls("txCar1Nro" & i).Visible = True
            Me.Controls("txCar1Cab" & i).Visible = True

            Me.Controls("txCar1Nro" & i).Text = row("Orden")
            Me.Controls("txCar1Cab" & i).Text = caballo("CaballoNombre")

            'MsgBox(caballo("CaballoNombre"), MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            i = i + 1
        Next

    End Function

    Private Function CargarCaballos2()

        Dim dtCarrerasCaballos = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(cbCarrera1.SelectedValue)
        Dim i As Integer = 1
        Dim caballo As DataRow

        For Each row As DataRow In dtCarrerasCaballos.Rows

            caballo = BdSIGAP_DataSet.tb_Caballos.FindById(row("IdCaballo"))

            Me.Controls("txCar2Nro" & i).Visible = True
            Me.Controls("txCar2Cab" & i).Visible = True

            Me.Controls("txCar2Nro" & i).Text = row("Orden")
            Me.Controls("txCar2Cab" & i).Text = caballo("CaballoNombre")

            'MsgBox(caballo("CaballoNombre"), MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            i = i + 1
        Next





    End Function

    Private Sub TextBox30_TextChanged(sender As Object, e As EventArgs) Handles txCar2Nro3.TextChanged

    End Sub

    Private Sub TextBox28_TextChanged(sender As Object, e As EventArgs) Handles txCar2Nro4.TextChanged

    End Sub
End Class