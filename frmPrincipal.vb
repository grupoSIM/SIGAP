Public Class frmPrincipal
    Private Sub HipódromoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HipódromoToolStripMenuItem.Click
        frmHipodromo.Show()
    End Sub

    Private Sub JornadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JornadasToolStripMenuItem.Click
        frmJornada.Show()
    End Sub

    Private Sub CargarRematesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarRematesToolStripMenuItem.Click
        frmRemate.Show()
    End Sub

    Private Sub CargarCarreraCaballosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarCarreraCaballosToolStripMenuItem.Click
        frmCarreraCaballo.Show()
    End Sub

    Private Sub CarrerasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarrerasToolStripMenuItem.Click
        frmCaballo.Show()
    End Sub

    Private Sub PalcosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PalcosToolStripMenuItem.Click
        frmPalco.Show()
    End Sub
End Class