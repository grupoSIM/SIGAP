Imports System
Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms
Imports SIGAP.bdSIGAP_DataSet
Imports SIGAP.bdSIGAP_DataSetTableAdapters

Public Class ControladorImpresion
    Implements IDisposable
    Private m_currentPageIndex As Integer
    Private m_streams As IList(Of Stream)

    ' Routine to provide to the report renderer, in order to
    ' save an image for each page of the report.
    Private Function CreateStream(ByVal name As String, ByVal fileNameExtension As String, ByVal encoding As Encoding, ByVal mimeType As String, ByVal willSeek As Boolean) As Stream
        Dim stream As Stream = New MemoryStream()
        m_streams.Add(stream)
        Return stream
    End Function

    ' Export the given report as an EMF (Enhanced Metafile) file.
    Private Sub Export(ByVal report As LocalReport)
        Dim deviceInfo As String = "<DeviceInfo>" &
            "<OutputFormat>EMF</OutputFormat>" &
            "<PageWidth>3in</PageWidth>" &
            "<PageHeight>11in</PageHeight>" &
            "<MarginTop>0.10in</MarginTop>" &
            "<MarginLeft>0in</MarginLeft>" &
            "<MarginRight>0in</MarginRight>" &
            "<MarginBottom>0.10in</MarginBottom>" &
            "</DeviceInfo>"

        Dim warnings As Warning()
        m_streams = New List(Of Stream)()
        report.Render("Image", deviceInfo, AddressOf CreateStream, warnings)
        For Each stream As Stream In m_streams
            stream.Position = 0
        Next
    End Sub

    ' Handler for PrintPageEvents
    Private Sub PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim pageImage As New Metafile(m_streams(m_currentPageIndex))

        ' Adjust rectangular area with printer margins.
        Dim adjustedRect As New Rectangle(ev.PageBounds.Left - CInt(ev.PageSettings.HardMarginX),
                                          ev.PageBounds.Top - CInt(ev.PageSettings.HardMarginY),
                                          ev.PageBounds.Width,
                                          ev.PageBounds.Height)

        ' Draw a white background for the report
        ev.Graphics.FillRectangle(Brushes.White, adjustedRect)

        ' Draw the report content
        ev.Graphics.DrawImage(pageImage, adjustedRect)

        ' Prepare for the next page. Make sure we haven't hit the end.
        m_currentPageIndex += 1
        ev.HasMorePages = (m_currentPageIndex < m_streams.Count)
    End Sub

    Private Sub Print()
        If m_streams Is Nothing OrElse m_streams.Count = 0 Then
            Throw New Exception("Error: no stream to print.")
        End If
        Dim printDoc As New PrintDocument()
        printDoc.PrintController = New StandardPrintController()
        printDoc.PrinterSettings.DefaultPageSettings.Margins.Bottom = 0
        printDoc.PrinterSettings.DefaultPageSettings.Margins.Left = 0
        printDoc.PrinterSettings.DefaultPageSettings.Margins.Right = 0
        printDoc.PrinterSettings.DefaultPageSettings.Margins.Top = 0
        If Not printDoc.PrinterSettings.IsValid Then
            Throw New Exception("Error: cannot find the default printer.")
        Else
            AddHandler printDoc.PrintPage, AddressOf PrintPage
            m_currentPageIndex = 0
            printDoc.Print()
        End If
    End Sub

    ' export the report to an .emf file, and print it.
    Public Sub ImprimirDevoluciones(IdCarrera As Int32)

        Dim report As New LocalReport()
        Dim dataSet As New bdSIGAP_DataSet
        Dim dataTable As New Object

        Dim TableAdapter As New bdSIGAP_DataSetTableAdapters.VwDevolucionesTableAdapter ' <-- Cambiar VwDevolucionesTableAdapter por el nombre q corresponda

        TableAdapter.FillByIdCarrera(dataSet.VwDevoluciones, IdCarrera) ' <-- Cambiar VwDevoluciones por el nombre q corresponda
        dataTable = dataSet.VwDevoluciones ' <-- Cambiar VwDevoluciones por el nombre q corresponda
        report.ReportPath = "rpDevoluciones.rdlc" ' <-- Cambiar por el nombre del reporte q corresponda ( debe estar en el copiado a la carpeta debug)
        report.DataSources.Add(New ReportDataSource("DataSet1", dataTable)) ' <-- Cambiar "DataSet1" por el nombre del DataSet q espera el reporte

        Export(report)
        Print()
    End Sub

    Public Sub ImprimirPremios(IdCarrera As Int32)
        Dim report As New LocalReport()
        Dim dataSet As New bdSIGAP_DataSet
        Dim dataTable As New Object

        Dim TableAdapter As New bdSIGAP_DataSetTableAdapters.VwPremiosTableAdapter ' <-- Cambiar VwPremiosTableAdapter por el nombre q corresponda

        TableAdapter.FillByIdCarrera(dataSet.VwPremios, IdCarrera) ' <-- Cambiar VwPremios por el nombre q corresponda
        dataTable = dataSet.VwPremios ' <-- Cambiar VwPremios por el nombre q corresponda
        report.ReportPath = "rpPremios.rdlc" ' <-- Cambiar por el nombre del reporte q corresponda ( debe estar en el copiado a la carpeta debug)
        report.DataSources.Add(New ReportDataSource("DS_Premios", dataTable)) ' <-- Cambiar "DS_Premios" por el nombre del DataSet q espera el reporte

        Export(report)
        Print()
    End Sub

    Public Sub ImprimirCajaPalco(IdCarrera As Int32)
        Dim report As New LocalReport()
        Dim dataSet As New bdSIGAP_DataSet
        Dim dataTable As New Object

        Dim TableAdapter As New bdSIGAP_DataSetTableAdapters.VwCajaPalcoTableAdapter ' <-- Cambiar VwCajaPalcoTableAdapter por el nombre q corresponda

        TableAdapter.FillByIdCarrera(dataSet.VwCajaPalco, IdCarrera) ' <-- Cambiar VwPremios por el nombre q corresponda
        dataTable = dataSet.VwCajaPalco ' <-- Cambiar VwCajaPalco por el nombre q corresponda
        report.ReportPath = "rpCajaPalco.rdlc" ' <-- Cambiar por el nombre del reporte q corresponda ( debe estar en el copiado a la carpeta debug)
        report.DataSources.Add(New ReportDataSource("DataSet1", dataTable)) ' <-- Cambiar "DataSet1" por el nombre del DataSet q espera el reporte

        Export(report)
        Print()
    End Sub

    Public Sub ImprimirTicket(IdDetalleRemate As Int32)
        Dim report As New LocalReport()
        Dim dataSet As New bdSIGAP_DataSet
        Dim dataTable As New Object

        Dim TableAdapter As New bdSIGAP_DataSetTableAdapters.VwTicketTableAdapter ' <-- Cambiar VwCajaPalcoTableAdapter por el nombre q corresponda

        TableAdapter.FillByIdDetalleRemate(dataSet.VwTicket, IdDetalleRemate) ' <-- Cambiar VwPremios por el nombre q corresponda
        dataTable = dataSet.VwTicket ' <-- Cambiar VwCajaPalco por el nombre q corresponda
        report.ReportPath = "rpTicket.rdlc" ' <-- Cambiar por el nombre del reporte q corresponda ( debe estar en el copiado a la carpeta debug)
        report.DataSources.Add(New ReportDataSource("DataSet1", dataTable)) ' <-- Cambiar "DataSet1" por el nombre del DataSet q espera el reporte

        Export(report)
        Print()
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        If m_streams IsNot Nothing Then
            For Each stream As Stream In m_streams
                stream.Close()
            Next
            m_streams = Nothing
        End If
    End Sub

End Class