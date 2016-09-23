<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportePremios
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
        Me.VwPremiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bdSIGAP_DataSet = New SIGAP.bdSIGAP_DataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.VwPremiosTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.VwPremiosTableAdapter()
        CType(Me.VwPremiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VwPremiosBindingSource
        '
        Me.VwPremiosBindingSource.DataMember = "VwPremios"
        Me.VwPremiosBindingSource.DataSource = Me.bdSIGAP_DataSet
        '
        'bdSIGAP_DataSet
        '
        Me.bdSIGAP_DataSet.DataSetName = "bdSIGAP_DataSet"
        Me.bdSIGAP_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DS_Premios"
        ReportDataSource1.Value = Me.VwPremiosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SIGAP.rpPremios.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(9, 7)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowBackButton = False
        Me.ReportViewer1.Size = New System.Drawing.Size(328, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'VwPremiosTableAdapter
        '
        Me.VwPremiosTableAdapter.ClearBeforeFill = True
        '
        'frmReportePremios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 262)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReportePremios"
        Me.Text = "frmReportePremios"
        CType(Me.VwPremiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VwPremiosBindingSource As BindingSource
    Friend WithEvents bdSIGAP_DataSet As bdSIGAP_DataSet
    Friend WithEvents VwPremiosTableAdapter As bdSIGAP_DataSetTableAdapters.VwPremiosTableAdapter
End Class
