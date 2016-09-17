<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCabCarreList
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
        Me.BdSIGAP_DataSet = New SIGAP.bdSIGAP_DataSet()
        Me.TbCarrerasCaballosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_CarrerasCaballosTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CarrerasCaballosTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCarreraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCaballoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoTomaNuevosRematesDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PosicionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LuzDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCarrerasCaballosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdCarreraDataGridViewTextBoxColumn, Me.IdCaballoDataGridViewTextBoxColumn, Me.NoTomaNuevosRematesDataGridViewCheckBoxColumn, Me.PosicionDataGridViewTextBoxColumn, Me.LuzDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.TbCarrerasCaballosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 119)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(725, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'BdSIGAP_DataSet
        '
        Me.BdSIGAP_DataSet.DataSetName = "bdSIGAP_DataSet"
        Me.BdSIGAP_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbCarrerasCaballosBindingSource
        '
        Me.TbCarrerasCaballosBindingSource.DataMember = "tb_CarrerasCaballos"
        Me.TbCarrerasCaballosBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'Tb_CarrerasCaballosTableAdapter
        '
        Me.Tb_CarrerasCaballosTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'IdCarreraDataGridViewTextBoxColumn
        '
        Me.IdCarreraDataGridViewTextBoxColumn.DataPropertyName = "IdCarrera"
        Me.IdCarreraDataGridViewTextBoxColumn.HeaderText = "IdCarrera"
        Me.IdCarreraDataGridViewTextBoxColumn.Name = "IdCarreraDataGridViewTextBoxColumn"
        '
        'IdCaballoDataGridViewTextBoxColumn
        '
        Me.IdCaballoDataGridViewTextBoxColumn.DataPropertyName = "IdCaballo"
        Me.IdCaballoDataGridViewTextBoxColumn.HeaderText = "IdCaballo"
        Me.IdCaballoDataGridViewTextBoxColumn.Name = "IdCaballoDataGridViewTextBoxColumn"
        '
        'NoTomaNuevosRematesDataGridViewCheckBoxColumn
        '
        Me.NoTomaNuevosRematesDataGridViewCheckBoxColumn.DataPropertyName = "NoTomaNuevosRemates"
        Me.NoTomaNuevosRematesDataGridViewCheckBoxColumn.HeaderText = "NoTomaNuevosRemates"
        Me.NoTomaNuevosRematesDataGridViewCheckBoxColumn.Name = "NoTomaNuevosRematesDataGridViewCheckBoxColumn"
        '
        'PosicionDataGridViewTextBoxColumn
        '
        Me.PosicionDataGridViewTextBoxColumn.DataPropertyName = "Posicion"
        Me.PosicionDataGridViewTextBoxColumn.HeaderText = "Posicion"
        Me.PosicionDataGridViewTextBoxColumn.Name = "PosicionDataGridViewTextBoxColumn"
        '
        'LuzDataGridViewCheckBoxColumn
        '
        Me.LuzDataGridViewCheckBoxColumn.DataPropertyName = "Luz"
        Me.LuzDataGridViewCheckBoxColumn.HeaderText = "Luz"
        Me.LuzDataGridViewCheckBoxColumn.Name = "LuzDataGridViewCheckBoxColumn"
        '
        'frmCabCarreList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 324)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmCabCarreList"
        Me.Text = "frmCabCarreList"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbCarrerasCaballosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BdSIGAP_DataSet As bdSIGAP_DataSet
    Friend WithEvents TbCarrerasCaballosBindingSource As BindingSource
    Friend WithEvents Tb_CarrerasCaballosTableAdapter As bdSIGAP_DataSetTableAdapters.tb_CarrerasCaballosTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCarreraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCaballoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoTomaNuevosRematesDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PosicionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LuzDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
