<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCajaPalco
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.bdSIGAP_DataSet = New SIGAP.bdSIGAP_DataSet()
        Me.VwCajaPalcoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwCajaPalcoTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.VwCajaPalcoTableAdapter()
        CType(Me.bdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCajaPalcoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.VwCajaPalcoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SIGAP.rpCajaPalco.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-2, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(328, 359)
        Me.ReportViewer1.TabIndex = 0
        '
        'bdSIGAP_DataSet
        '
        Me.bdSIGAP_DataSet.DataSetName = "bdSIGAP_DataSet"
        Me.bdSIGAP_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwCajaPalcoBindingSource
        '
        Me.VwCajaPalcoBindingSource.DataMember = "VwCajaPalco"
        Me.VwCajaPalcoBindingSource.DataSource = Me.bdSIGAP_DataSet
        '
        'VwCajaPalcoTableAdapter
        '
        Me.VwCajaPalcoTableAdapter.ClearBeforeFill = True
        '
        'frmCajaPalco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 357)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmCajaPalco"
        Me.Text = "frmCajaPalco"
        CType(Me.bdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCajaPalcoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VwCajaPalcoBindingSource As BindingSource
    Friend WithEvents bdSIGAP_DataSet As bdSIGAP_DataSet
    Friend WithEvents VwCajaPalcoTableAdapter As bdSIGAP_DataSetTableAdapters.VwCajaPalcoTableAdapter
End Class
