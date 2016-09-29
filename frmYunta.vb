Public Class frmYunta
    Public altoYunta As Integer = 100

    Private Sub frmYunta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Jornadas' table. You can move, or remove it, as needed.
        Me.Tb_JornadasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Jornadas)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Carreras' table. You can move, or remove it, as needed.
        Me.Tb_CarrerasTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Carreras)
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.tb_Caballos' table. You can move, or remove it, as needed.
        Me.Tb_CaballosTableAdapter.Fill(Me.BdSIGAP_DataSet.tb_Caballos)
        CargarCaballos()

    End Sub

    Private Sub cbCarrera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCarrera.SelectedIndexChanged
        If (cbCarrera.SelectedValue) Then
            CargarCaballos()
        End If
    End Sub

    Private Function CargarCaballos()

        Dim dtCarrerasCaballos = Tb_CarrerasCaballosTableAdapter.GetDataByCarrera(cbCarrera.SelectedValue)
        Dim i As Integer = 1
        Dim caballo As DataRow
        Dim nuevoControl As Control
        Dim alto As Integer = 100
        Dim ctrlsEjec As Integer = Controls.Count - 1
        Dim ctrl As Control

        For n As Integer = ctrlsEjec To 1 Step -1
            ctrl = Controls(n)
            If (ctrl.Tag IsNot Nothing) Then
                Controls.Remove(ctrl)
                ctrl.Dispose()
            End If
        Next

        For Each row As DataRow In dtCarrerasCaballos.Rows
            caballo = BdSIGAP_DataSet.tb_Caballos.FindById(row("IdCaballo"))
            'MsgBox(cabs("CaballoNombre"), MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)

            'Crea elckeck box de caballo
            Dim ubicacion As Point
            ubicacion = New Point(35, alto)

            nuevoControl = New CheckBox
            With nuevoControl
                .Name = "ckCaballo" & i
                .Size() = New Size(200, 20)
                .Text = caballo("CaballoNombre")
                .Location = ubicacion
                .Tag = "Caballo"
            End With
            Controls.Add(nuevoControl)


            ' Creación de TextBox de orden de caballos
            nuevoControl = New TextBox
            With nuevoControl
                .Name = "txtNumero" & i
                .Location = New Point(240, alto)
                .Size() = New Size(40, 20)
                .Text = row("Orden")
                .Tag = "Numero"
            End With
            Controls.Add(nuevoControl)

            'MessageBox.Show(nuevocontrol.Name, "SiGAp", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            i += 1
            alto = alto + 20
        Next

        For Each chk As CheckBox In Controls.OfType(Of CheckBox)
            chk.Visible = True
        Next

        For Each txt As TextBox In Controls.OfType(Of TextBox)
            txt.Visible = True
        Next

    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nuevoControl As Control
        Dim i As Integer = 1
        Dim nombrecillo As String
        nombrecillo = " "
        Dim num As String = ""
        'Dim alto As Integer = 90
        Dim ubicacion As Point
        ubicacion = New Point(35, altoYunta)


        For Each chk As CheckBox In Controls.OfType(Of CheckBox)
            If chk.Checked = True Then
                nombrecillo = nombrecillo & chk.Text & "/"
                num = num & Me.Controls("txtNumero" & i).Text
            End If
            i += 1
        Next

        nuevoControl = New TextBox
        With nuevoControl
            .Name = "txtNum" & i
            .Location = New Point(400, altoYunta)
            .Size() = New Size(40, 20)
            .Text = num
            '.Tag = "Numero"
            .Visible = True
        End With
        Controls.Add(nuevoControl)

        nuevoControl = New TextBox
        With nuevoControl
            .Name = "txtCaballo" & i
            .Location = New Point(450, altoYunta)
            .Size() = New Size(300, 20)
            .Text = nombrecillo
            '.Tag = "Numero"
            .Visible = True
        End With
        Controls.Add(nuevoControl)

        altoYunta = altoYunta + 20


        For Each chk As CheckBox In Controls.OfType(Of CheckBox)
            If chk.Checked = True Then
                chk.Checked = False
            End If
            i += 1
        Next

    End Sub
End Class