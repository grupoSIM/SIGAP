<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarrera
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TbJornadasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdSIGAP_DataSet = New SIGAP.bdSIGAP_DataSet()
        Me.TbCarrerasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_CarrerasTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CarrerasTableAdapter()
        Me.Tb_JornadasTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_JornadasTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdJornadaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.NroCarreraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetrosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcentajeCasaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcentajeUltimoRemateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCarreraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbJornadasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCarrerasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdJornadaDataGridViewTextBoxColumn, Me.NroCarreraDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.MetrosDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.PorcentajeCasaDataGridViewTextBoxColumn, Me.PorcentajeUltimoRemateDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn, Me.TipoCarreraDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TbCarrerasBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(848, 253)
        Me.DataGridView1.TabIndex = 0
        '
        'TbJornadasBindingSource
        '
        Me.TbJornadasBindingSource.DataMember = "tb_Jornadas"
        Me.TbJornadasBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'BdSIGAP_DataSet
        '
        Me.BdSIGAP_DataSet.DataSetName = "bdSIGAP_DataSet"
        Me.BdSIGAP_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbCarrerasBindingSource
        '
        Me.TbCarrerasBindingSource.DataMember = "tb_Carreras"
        Me.TbCarrerasBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'Tb_CarrerasTableAdapter
        '
        Me.Tb_CarrerasTableAdapter.ClearBeforeFill = True
        '
        'Tb_JornadasTableAdapter
        '
        Me.Tb_JornadasTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'IdJornadaDataGridViewTextBoxColumn
        '
        Me.IdJornadaDataGridViewTextBoxColumn.DataPropertyName = "IdJornada"
        Me.IdJornadaDataGridViewTextBoxColumn.DataSource = Me.TbJornadasBindingSource
        Me.IdJornadaDataGridViewTextBoxColumn.DisplayMember = "Descripcion"
        Me.IdJornadaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.IdJornadaDataGridViewTextBoxColumn.HeaderText = "Jornada"
        Me.IdJornadaDataGridViewTextBoxColumn.Name = "IdJornadaDataGridViewTextBoxColumn"
        Me.IdJornadaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdJornadaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdJornadaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IdJornadaDataGridViewTextBoxColumn.ValueMember = "Id"
        Me.IdJornadaDataGridViewTextBoxColumn.Width = 150
        '
        'NroCarreraDataGridViewTextBoxColumn
        '
        Me.NroCarreraDataGridViewTextBoxColumn.DataPropertyName = "NroCarrera"
        Me.NroCarreraDataGridViewTextBoxColumn.HeaderText = "Nro Carrera"
        Me.NroCarreraDataGridViewTextBoxColumn.Name = "NroCarreraDataGridViewTextBoxColumn"
        Me.NroCarreraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MetrosDataGridViewTextBoxColumn
        '
        Me.MetrosDataGridViewTextBoxColumn.DataPropertyName = "Metros"
        Me.MetrosDataGridViewTextBoxColumn.HeaderText = "Metros"
        Me.MetrosDataGridViewTextBoxColumn.Name = "MetrosDataGridViewTextBoxColumn"
        Me.MetrosDataGridViewTextBoxColumn.ReadOnly = True
        Me.MetrosDataGridViewTextBoxColumn.Width = 50
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PorcentajeCasaDataGridViewTextBoxColumn
        '
        Me.PorcentajeCasaDataGridViewTextBoxColumn.DataPropertyName = "PorcentajeCasa"
        Me.PorcentajeCasaDataGridViewTextBoxColumn.HeaderText = "% Casa"
        Me.PorcentajeCasaDataGridViewTextBoxColumn.Name = "PorcentajeCasaDataGridViewTextBoxColumn"
        Me.PorcentajeCasaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PorcentajeUltimoRemateDataGridViewTextBoxColumn
        '
        Me.PorcentajeUltimoRemateDataGridViewTextBoxColumn.DataPropertyName = "PorcentajeUltimoRemate"
        Me.PorcentajeUltimoRemateDataGridViewTextBoxColumn.HeaderText = "PorcentajeUltimoRemate"
        Me.PorcentajeUltimoRemateDataGridViewTextBoxColumn.Name = "PorcentajeUltimoRemateDataGridViewTextBoxColumn"
        Me.PorcentajeUltimoRemateDataGridViewTextBoxColumn.Visible = False
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        Me.ObservacionesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoCarreraDataGridViewTextBoxColumn
        '
        Me.TipoCarreraDataGridViewTextBoxColumn.DataPropertyName = "TipoCarrera"
        Me.TipoCarreraDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoCarreraDataGridViewTextBoxColumn.Name = "TipoCarreraDataGridViewTextBoxColumn"
        Me.TipoCarreraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmCarrera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 308)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmCarrera"
        Me.Text = "Carreras"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbJornadasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbCarrerasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BdSIGAP_DataSet As bdSIGAP_DataSet
    Friend WithEvents TbCarrerasBindingSource As BindingSource
    Friend WithEvents Tb_CarrerasTableAdapter As bdSIGAP_DataSetTableAdapters.tb_CarrerasTableAdapter
    Friend WithEvents TbJornadasBindingSource As BindingSource
    Friend WithEvents Tb_JornadasTableAdapter As bdSIGAP_DataSetTableAdapters.tb_JornadasTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdJornadaDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents NroCarreraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MetrosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PorcentajeCasaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PorcentajeUltimoRemateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoCarreraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
