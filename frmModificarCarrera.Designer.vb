<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarCarrera
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
        Me.BdSIGAP_DataSet = New SIGAP.bdSIGAP_DataSet()
        Me.Tb_JornadasTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_JornadasTableAdapter()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.Tb_CarrerasCaballosTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CarrerasCaballosTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbJornada = New System.Windows.Forms.ComboBox()
        Me.nProcentajeCasa = New System.Windows.Forms.NumericUpDown()
        Me.txNombre = New System.Windows.Forms.TextBox()
        Me.nCarrera = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txMetros = New System.Windows.Forms.TextBox()
        Me.cbCarrera = New System.Windows.Forms.ComboBox()
        Me.Tb_CarrerasTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CarrerasTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tb_CaballosTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CaballosTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Tb_CarrerasTableAdapter1 = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CarrerasTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Tb_PorcentajesCasaTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_PorcentajesCasaTableAdapter()
        Me.TbJornadasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbCarrerasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCarreraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCaballoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TbCaballosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NoTomaNuevosRematesDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PosicionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LuzDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.OrdenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbCarrerasCaballosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New SIGAP.bdSIGAP_DataSetTableAdapters.TableAdapterManager()
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nProcentajeCasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nCarrera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TbJornadasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCarrerasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCaballosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCarrerasCaballosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BdSIGAP_DataSet
        '
        Me.BdSIGAP_DataSet.DataSetName = "bdSIGAP_DataSet"
        Me.BdSIGAP_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_JornadasTableAdapter
        '
        Me.Tb_JornadasTableAdapter.ClearBeforeFill = True
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AutoGenerateColumns = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdCarreraDataGridViewTextBoxColumn, Me.IdCaballoDataGridViewTextBoxColumn, Me.NoTomaNuevosRematesDataGridViewCheckBoxColumn, Me.PosicionDataGridViewTextBoxColumn, Me.LuzDataGridViewCheckBoxColumn, Me.OrdenDataGridViewTextBoxColumn})
        Me.DataGridView.DataSource = Me.TbCarrerasCaballosBindingSource
        Me.DataGridView.Location = New System.Drawing.Point(12, 162)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(744, 313)
        Me.DataGridView.TabIndex = 13
        '
        'Tb_CarrerasCaballosTableAdapter
        '
        Me.Tb_CarrerasCaballosTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(268, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Porcentaje Casa:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Carrera N°:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tipo:"
        '
        'cbTipo
        '
        Me.cbTipo.AutoCompleteCustomSource.AddRange(New String() {"Normal", "Llave"})
        Me.cbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Items.AddRange(New Object() {"Normal", "Llave"})
        Me.cbTipo.Location = New System.Drawing.Point(75, 99)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(121, 21)
        Me.cbTipo.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Jornada:"
        '
        'cbJornada
        '
        Me.cbJornada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbJornada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbJornada.DataSource = Me.TbJornadasBindingSource
        Me.cbJornada.DisplayMember = "Descripcion"
        Me.cbJornada.DropDownWidth = 333
        Me.cbJornada.FormattingEnabled = True
        Me.cbJornada.Location = New System.Drawing.Point(75, 19)
        Me.cbJornada.Name = "cbJornada"
        Me.cbJornada.Size = New System.Drawing.Size(407, 21)
        Me.cbJornada.TabIndex = 0
        Me.cbJornada.ValueMember = "Id"
        '
        'nProcentajeCasa
        '
        Me.nProcentajeCasa.Location = New System.Drawing.Point(362, 73)
        Me.nProcentajeCasa.Name = "nProcentajeCasa"
        Me.nProcentajeCasa.Size = New System.Drawing.Size(120, 20)
        Me.nProcentajeCasa.TabIndex = 13
        '
        'txNombre
        '
        Me.txNombre.Location = New System.Drawing.Point(377, 46)
        Me.txNombre.Name = "txNombre"
        Me.txNombre.Size = New System.Drawing.Size(300, 20)
        Me.txNombre.TabIndex = 14
        '
        'nCarrera
        '
        Me.nCarrera.Location = New System.Drawing.Point(75, 73)
        Me.nCarrera.Maximum = New Decimal(New Integer() {276447232, 23283, 0, 0})
        Me.nCarrera.Name = "nCarrera"
        Me.nCarrera.Size = New System.Drawing.Size(120, 20)
        Me.nCarrera.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(314, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Metros:"
        '
        'txMetros
        '
        Me.txMetros.Location = New System.Drawing.Point(365, 102)
        Me.txMetros.Name = "txMetros"
        Me.txMetros.Size = New System.Drawing.Size(117, 20)
        Me.txMetros.TabIndex = 18
        Me.txMetros.Text = "0"
        '
        'cbCarrera
        '
        Me.cbCarrera.DataSource = Me.TbCarrerasBindingSource
        Me.cbCarrera.DisplayMember = "Nombre"
        Me.cbCarrera.FormattingEnabled = True
        Me.cbCarrera.Location = New System.Drawing.Point(75, 46)
        Me.cbCarrera.Name = "cbCarrera"
        Me.cbCarrera.Size = New System.Drawing.Size(300, 21)
        Me.cbCarrera.TabIndex = 14
        Me.cbCarrera.ValueMember = "Id"
        '
        'Tb_CarrerasTableAdapter
        '
        Me.Tb_CarrerasTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Carrera:"
        '
        'Tb_CaballosTableAdapter
        '
        Me.Tb_CaballosTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(705, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Modificar Carrera"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Tb_CarrerasTableAdapter1
        '
        Me.Tb_CarrerasTableAdapter1.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nProcentajeCasa)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txMetros)
        Me.GroupBox1.Controls.Add(Me.cbJornada)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txNombre)
        Me.GroupBox1.Controls.Add(Me.cbCarrera)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbTipo)
        Me.GroupBox1.Controls.Add(Me.nCarrera)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(687, 130)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(705, 52)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Tb_PorcentajesCasaTableAdapter
        '
        Me.Tb_PorcentajesCasaTableAdapter.ClearBeforeFill = True
        '
        'TbJornadasBindingSource
        '
        Me.TbJornadasBindingSource.DataMember = "tb_Jornadas"
        Me.TbJornadasBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'TbCarrerasBindingSource
        '
        Me.TbCarrerasBindingSource.DataMember = "tb_Carreras"
        Me.TbCarrerasBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Width = 50
        '
        'IdCarreraDataGridViewTextBoxColumn
        '
        Me.IdCarreraDataGridViewTextBoxColumn.DataPropertyName = "IdCarrera"
        Me.IdCarreraDataGridViewTextBoxColumn.HeaderText = "Id Carrera"
        Me.IdCarreraDataGridViewTextBoxColumn.Name = "IdCarreraDataGridViewTextBoxColumn"
        '
        'IdCaballoDataGridViewTextBoxColumn
        '
        Me.IdCaballoDataGridViewTextBoxColumn.DataPropertyName = "IdCaballo"
        Me.IdCaballoDataGridViewTextBoxColumn.DataSource = Me.TbCaballosBindingSource
        Me.IdCaballoDataGridViewTextBoxColumn.DisplayMember = "CaballoNombre"
        Me.IdCaballoDataGridViewTextBoxColumn.HeaderText = "Caballo"
        Me.IdCaballoDataGridViewTextBoxColumn.Name = "IdCaballoDataGridViewTextBoxColumn"
        Me.IdCaballoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdCaballoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IdCaballoDataGridViewTextBoxColumn.ValueMember = "Id"
        Me.IdCaballoDataGridViewTextBoxColumn.Width = 150
        '
        'TbCaballosBindingSource
        '
        Me.TbCaballosBindingSource.DataMember = "tb_Caballos"
        Me.TbCaballosBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'NoTomaNuevosRematesDataGridViewCheckBoxColumn
        '
        Me.NoTomaNuevosRematesDataGridViewCheckBoxColumn.DataPropertyName = "NoTomaNuevosRemates"
        Me.NoTomaNuevosRematesDataGridViewCheckBoxColumn.HeaderText = "No Toma Nuevos Remates"
        Me.NoTomaNuevosRematesDataGridViewCheckBoxColumn.Name = "NoTomaNuevosRematesDataGridViewCheckBoxColumn"
        '
        'PosicionDataGridViewTextBoxColumn
        '
        Me.PosicionDataGridViewTextBoxColumn.DataPropertyName = "Posicion"
        Me.PosicionDataGridViewTextBoxColumn.HeaderText = "Posición"
        Me.PosicionDataGridViewTextBoxColumn.Name = "PosicionDataGridViewTextBoxColumn"
        '
        'LuzDataGridViewCheckBoxColumn
        '
        Me.LuzDataGridViewCheckBoxColumn.DataPropertyName = "Luz"
        Me.LuzDataGridViewCheckBoxColumn.HeaderText = "Ganó con Luz?"
        Me.LuzDataGridViewCheckBoxColumn.Name = "LuzDataGridViewCheckBoxColumn"
        '
        'OrdenDataGridViewTextBoxColumn
        '
        Me.OrdenDataGridViewTextBoxColumn.DataPropertyName = "Orden"
        Me.OrdenDataGridViewTextBoxColumn.HeaderText = "Orden"
        Me.OrdenDataGridViewTextBoxColumn.Name = "OrdenDataGridViewTextBoxColumn"
        '
        'TbCarrerasCaballosBindingSource
        '
        Me.TbCarrerasCaballosBindingSource.DataMember = "tb_CarrerasCaballos"
        Me.TbCarrerasCaballosBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tb_CaballosTableAdapter = Nothing
        Me.TableAdapterManager.tb_CarrerasCaballosTableAdapter = Nothing
        Me.TableAdapterManager.tb_CarrerasTableAdapter = Nothing
        Me.TableAdapterManager.tb_DetalleRematesTableAdapter = Nothing
        Me.TableAdapterManager.tb_EventosTableAdapter = Nothing
        Me.TableAdapterManager.tb_HipodromosTableAdapter = Nothing
        Me.TableAdapterManager.tb_JornadasTableAdapter = Nothing
        Me.TableAdapterManager.tb_PalcosTableAdapter = Nothing
        Me.TableAdapterManager.tb_PorcentajesCasaTableAdapter = Nothing
        Me.TableAdapterManager.tb_RematadoresTableAdapter = Nothing
        Me.TableAdapterManager.tb_RematesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SIGAP.bdSIGAP_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmModificarCarrera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 487)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView)
        Me.Name = "frmModificarCarrera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Carrera"
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nProcentajeCasa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nCarrera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TbJornadasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbCarrerasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbCaballosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbCarrerasCaballosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BdSIGAP_DataSet As bdSIGAP_DataSet
    Friend WithEvents TbJornadasBindingSource As BindingSource
    Friend WithEvents Tb_JornadasTableAdapter As bdSIGAP_DataSetTableAdapters.tb_JornadasTableAdapter
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents TbCarrerasCaballosBindingSource As BindingSource
    Friend WithEvents Tb_CarrerasCaballosTableAdapter As bdSIGAP_DataSetTableAdapters.tb_CarrerasCaballosTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbTipo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbJornada As ComboBox
    Friend WithEvents nProcentajeCasa As NumericUpDown
    Friend WithEvents txNombre As TextBox
    Friend WithEvents nCarrera As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents txMetros As TextBox
    Friend WithEvents cbCarrera As ComboBox
    Friend WithEvents TbCarrerasBindingSource As BindingSource
    Friend WithEvents Tb_CarrerasTableAdapter As bdSIGAP_DataSetTableAdapters.tb_CarrerasTableAdapter
    Friend WithEvents Label7 As Label
    Friend WithEvents TbCaballosBindingSource As BindingSource
    Friend WithEvents Tb_CaballosTableAdapter As bdSIGAP_DataSetTableAdapters.tb_CaballosTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents TableAdapterManager As bdSIGAP_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_CarrerasTableAdapter1 As bdSIGAP_DataSetTableAdapters.tb_CarrerasTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCarreraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCaballoDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents NoTomaNuevosRematesDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PosicionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LuzDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents OrdenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Tb_PorcentajesCasaTableAdapter As bdSIGAP_DataSetTableAdapters.tb_PorcentajesCasaTableAdapter
End Class
