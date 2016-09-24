<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteDevoluciones
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.bdSIGAP_DataSet = New SIGAP.bdSIGAP_DataSet()
        Me.VwDevolucionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwDevolucionesTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.VwDevolucionesTableAdapter()
        CType(Me.bdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwDevolucionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.VwDevolucionesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SIGAP.rpDevoluciones.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(355, 321)
        Me.ReportViewer1.TabIndex = 0
        '
        'bdSIGAP_DataSet
        '
        Me.bdSIGAP_DataSet.DataSetName = "bdSIGAP_DataSet"
        Me.bdSIGAP_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwDevolucionesBindingSource
        '
        Me.VwDevolucionesBindingSource.DataMember = "VwDevoluciones"
        Me.VwDevolucionesBindingSource.DataSource = Me.bdSIGAP_DataSet
        '
        'VwDevolucionesTableAdapter
        '
        Me.VwDevolucionesTableAdapter.ClearBeforeFill = True
        '
        'frmReporteDevoluciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 328)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteDevoluciones"
        Me.Text = "Reporte Devoluciones"
        CType(Me.bdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwDevolucionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VwDevolucionesBindingSource As BindingSource
    Friend WithEvents bdSIGAP_DataSet As bdSIGAP_DataSet
    Friend WithEvents VwDevolucionesTableAdapter As bdSIGAP_DataSetTableAdapters.VwDevolucionesTableAdapter
End Class
