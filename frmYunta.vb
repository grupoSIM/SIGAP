Public Class frmYunta

    Public ref1 As Integer

    Private Sub frmYunta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Carreras' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Carreras)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Caballos' table. You can move, or remove it, as needed.
        Me.Tb_CaballosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Caballos)
        'CargarCaballos()
        ref1 = 1
    End Sub

    Private Sub cbCarrera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCarrera.SelectedIndexChanged

        LimpiarCaballos(ref1)

        CargarCaballos()
    End Sub

    Private Function CargarCaballos()

        Dim dtCarrerasCaballos = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(cbCarrera.SelectedValue)
        Dim i As Integer = 1
        Dim cabs As DataRow

        Dim alto As Integer = 60

        For Each row As DataRow In dtCarrerasCaballos.Rows
            cabs = BdSIGAP_DataSet.tb_Caballos.FindById(row("IdCaballo"))
            'MsgBox(cabs("CaballoNombre"), MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)

            'Dim cabaNom As String
            Dim ubicacion As Point

            ubicacion = New Point(25, alto)
            CrearCheck(ubicacion, cabs("CaballoNombre"), i)

            'MsgBox(caballo("CaballoNombre"), MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            i = i + 1
            alto = alto + 20
        Next
        'ref1 = cbCarrera.SelectedValue

        'MessageBox.Show(ref1, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ref1 = cbCarrera.SelectedValue

    End Function


    Private Function CrearCheck(ByVal location As Point, ByVal caballo As String, ByVal nro As Integer)

        Dim nuevocontrol As Control

        nuevocontrol = New CheckBox
        nuevocontrol.Name = "ckCaballo" & nro
        nuevocontrol.Width = 2000
        nuevocontrol.Text = caballo
        nuevocontrol.Location = location
        nuevocontrol.Visible = True

        Me.Controls.Add(nuevocontrol)
        MessageBox.Show(nuevocontrol.Name, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

    End Function


    Private Function LimpiarCaballos(ByVal IdCombo As Integer)

        Dim dtCarrerasCaballos = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(IdCombo)
        Dim i As Integer = 1
        Dim cabs As DataRow

        'Dim alto As Integer = 60

        For Each row As DataRow In dtCarrerasCaballos.Rows

            cabs = BdSIGAP_DataSet.tb_Caballos.FindById(row("IdCaballo"))
            MessageBox.Show(cabs("CaballoNombre"), "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            MessageBox.Show("ckCaballo" & i, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.Controls("ckCaballo" & i).Visible = False
            Me.Controls("ckCaballo" & i).Text = ""
            i = i + 1
        Next
        'ref1 = cbCarrera.SelectedValue

        'MessageBox.Show("limpia", "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)


    End Function







End Class