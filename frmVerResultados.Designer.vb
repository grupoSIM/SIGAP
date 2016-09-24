<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerResultados
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
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdRemateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCarreraCaballoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroCaballoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApostadorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteApuestaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LuzDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FilaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImportePremioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncluidoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TbDetalleRematesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdSIGAP_DataSet = New SIGAP.bdSIGAP_DataSet()
        Me.BdSIGAPDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_DetalleRematesTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_DetalleRematesTableAdapter()
        Me.cbCarrera = New System.Windows.Forms.ComboBox()
        Me.TbCarrerasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_CarrerasTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CarrerasTableAdapter()
        Me.rbUnGanador = New System.Windows.Forms.RadioButton()
        Me.rbPuesta = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbDetalleRematesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdSIGAPDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCarrerasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdRemateDataGridViewTextBoxColumn, Me.IdCarreraCaballoDataGridViewTextBoxColumn, Me.NroCaballoDataGridViewTextBoxColumn, Me.ApostadorDataGridViewTextBoxColumn, Me.ImporteApuestaDataGridViewTextBoxColumn, Me.LuzDataGridViewTextBoxColumn, Me.FilaDataGridViewTextBoxColumn, Me.ImportePremioDataGridViewTextBoxColumn, Me.IncluidoDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.TbDetalleRematesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(2, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1079, 481)
        Me.DataGridView1.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'IdRemateDataGridViewTextBoxColumn
        '
        Me.IdRemateDataGridViewTextBoxColumn.DataPropertyName = "IdRemate"
        Me.IdRemateDataGridViewTextBoxColumn.HeaderText = "IdRemate"
        Me.IdRemateDataGridViewTextBoxColumn.Name = "IdRemateDataGridViewTextBoxColumn"
        '
        'IdCarreraCaballoDataGridViewTextBoxColumn
        '
        Me.IdCarreraCaballoDataGridViewTextBoxColumn.DataPropertyName = "IdCarreraCaballo"
        Me.IdCarreraCaballoDataGridViewTextBoxColumn.HeaderText = "IdCarreraCaballo"
        Me.IdCarreraCaballoDataGridViewTextBoxColumn.Name = "IdCarreraCaballoDataGridViewTextBoxColumn"
        '
        'NroCaballoDataGridViewTextBoxColumn
        '
        Me.NroCaballoDataGridViewTextBoxColumn.DataPropertyName = "NroCaballo"
        Me.NroCaballoDataGridViewTextBoxColumn.HeaderText = "NroCaballo"
        Me.NroCaballoDataGridViewTextBoxColumn.Name = "NroCaballoDataGridViewTextBoxColumn"
        '
        'ApostadorDataGridViewTextBoxColumn
        '
        Me.ApostadorDataGridViewTextBoxColumn.DataPropertyName = "Apostador"
        Me.ApostadorDataGridViewTextBoxColumn.HeaderText = "Apostador"
        Me.ApostadorDataGridViewTextBoxColumn.Name = "ApostadorDataGridViewTextBoxColumn"
        '
        'ImporteApuestaDataGridViewTextBoxColumn
        '
        Me.ImporteApuestaDataGridViewTextBoxColumn.DataPropertyName = "ImporteApuesta"
        Me.ImporteApuestaDataGridViewTextBoxColumn.HeaderText = "ImporteApuesta"
        Me.ImporteApuestaDataGridViewTextBoxColumn.Name = "ImporteApuestaDataGridViewTextBoxColumn"
        '
        'LuzDataGridViewTextBoxColumn
        '
        Me.LuzDataGridViewTextBoxColumn.DataPropertyName = "Luz"
        Me.LuzDataGridViewTextBoxColumn.HeaderText = "Luz"
        Me.LuzDataGridViewTextBoxColumn.Name = "LuzDataGridViewTextBoxColumn"
        '
        'FilaDataGridViewTextBoxColumn
        '
        Me.FilaDataGridViewTextBoxColumn.DataPropertyName = "Fila"
        Me.FilaDataGridViewTextBoxColumn.HeaderText = "Fila"
        Me.FilaDataGridViewTextBoxColumn.Name = "FilaDataGridViewTextBoxColumn"
        '
        'ImportePremioDataGridViewTextBoxColumn
        '
        Me.ImportePremioDataGridViewTextBoxColumn.DataPropertyName = "ImportePremio"
        Me.ImportePremioDataGridViewTextBoxColumn.HeaderText = "ImportePremio"
        Me.ImportePremioDataGridViewTextBoxColumn.Name = "ImportePremioDataGridViewTextBoxColumn"
        '
        'IncluidoDataGridViewCheckBoxColumn
        '
        Me.IncluidoDataGridViewCheckBoxColumn.DataPropertyName = "Incluido"
        Me.IncluidoDataGridViewCheckBoxColumn.HeaderText = "Incluido"
        Me.IncluidoDataGridViewCheckBoxColumn.Name = "IncluidoDataGridViewCheckBoxColumn"
        '
        'TbDetalleRematesBindingSource
        '
        Me.TbDetalleRematesBindingSource.DataMember = "tb_DetalleRemates"
        Me.TbDetalleRematesBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'BdSIGAP_DataSet
        '
        Me.BdSIGAP_DataSet.DataSetName = "bdSIGAP_DataSet"
        Me.BdSIGAP_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BdSIGAPDataSetBindingSource
        '
        Me.BdSIGAPDataSetBindingSource.DataSource = Me.BdSIGAP_DataSet
        Me.BdSIGAPDataSetBindingSource.Position = 0
        '
        'Tb_DetalleRematesTableAdapter
        '
        Me.Tb_DetalleRematesTableAdapter.ClearBeforeFill = True
        '
        'cbCarrera
        '
        Me.cbCarrera.DataSource = Me.TbCarrerasBindingSource
        Me.cbCarrera.DisplayMember = "Nombre"
        Me.cbCarrera.FormattingEnabled = True
        Me.cbCarrera.Location = New System.Drawing.Point(58, 22)
        Me.cbCarrera.Name = "cbCarrera"
        Me.cbCarrera.Size = New System.Drawing.Size(199, 21)
        Me.cbCarrera.TabIndex = 2
        Me.cbCarrera.ValueMember = "Id"
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
        'rbUnGanador
        '
        Me.rbUnGanador.AutoSize = True
        Me.rbUnGanador.Checked = True
        Me.rbUnGanador.Location = New System.Drawing.Point(394, 14)
        Me.rbUnGanador.Name = "rbUnGanador"
        Me.rbUnGanador.Size = New System.Drawing.Size(75, 17)
        Me.rbUnGanador.TabIndex = 3
        Me.rbUnGanador.TabStop = True
        Me.rbUnGanador.Text = "1 Ganador"
        Me.rbUnGanador.UseVisualStyleBackColor = True
        '
        'rbPuesta
        '
        Me.rbPuesta.AutoSize = True
        Me.rbPuesta.Location = New System.Drawing.Point(476, 15)
        Me.rbPuesta.Name = "rbPuesta"
        Me.rbPuesta.Size = New System.Drawing.Size(58, 17)
        Me.rbPuesta.TabIndex = 4
        Me.rbPuesta.TabStop = True
        Me.rbPuesta.Text = "Puesta"
        Me.rbPuesta.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Carrera: "
        '
        'frmVerResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 570)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbPuesta)
        Me.Controls.Add(Me.rbUnGanador)
        Me.Controls.Add(Me.cbCarrera)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmVerResultados"
        Me.Text = "Ver Resultados"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbDetalleRematesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdSIGAPDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbCarrerasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BdSIGAPDataSetBindingSource As BindingSource
    Friend WithEvents BdSIGAP_DataSet As bdSIGAP_DataSet
    Friend WithEvents TbDetalleRematesBindingSource As BindingSource
    Friend WithEvents Tb_DetalleRematesTableAdapter As bdSIGAP_DataSetTableAdapters.tb_DetalleRematesTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdRemateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCarreraCaballoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroCaballoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApostadorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteApuestaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LuzDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FilaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImportePremioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IncluidoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents cbCarrera As ComboBox
    Friend WithEvents TbCarrerasBindingSource As BindingSource
    Friend WithEvents Tb_CarrerasTableAdapter As bdSIGAP_DataSetTableAdapters.tb_CarrerasTableAdapter
    Friend WithEvents rbUnGanador As RadioButton
    Friend WithEvents rbPuesta As RadioButton
    Friend WithEvents Label1 As Label
End Class
