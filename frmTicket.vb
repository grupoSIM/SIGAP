Imports System.ComponentModel

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSIGAP_DataSet.VwTicket' table. You can move, or remove it, as needed.
        'Me.VwTicketTableAdapter.Fill(Me.BdSIGAP_DataSet.VwTicket)
        VwTicketTableAdapter.FillByIdDetalleRemate(BdSIGAP_DataSet.VwTicket)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Imprimir()
    End Sub

    Private Sub Imprimir()
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Bottom = 0
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 0
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = 0
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = 0
        PrintForm1.Print()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Imprimir()
    End Sub
End Class