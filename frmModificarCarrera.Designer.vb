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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModificarCarrera))
        Me.cbJornada = New System.Windows.Forms.ComboBox()
        Me.TbJornadasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdSIGAP_DataSet = New SIGAP.bdSIGAP_DataSet()
        Me.Tb_JornadasTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_JornadasTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCarrera = New System.Windows.Forms.ComboBox()
        Me.TbCarrerasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_CarrerasTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CarrerasTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nNumero = New System.Windows.Forms.NumericUpDown()
        Me.txMetros = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txNombre = New System.Windows.Forms.TextBox()
        Me.txObservacion = New System.Windows.Forms.TextBox()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.txPorcCasa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCarreraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCaballoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TbCaballosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NoTomaNuevosRematesDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PosicionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LuzDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TbCarrerasCaballosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tb_CarrerasCaballosTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CarrerasCaballosTableAdapter()
        Me.Tb_CaballosTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CaballosTableAdapter()
        Me.btModificar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New SIGAP.bdSIGAP_DataSetTableAdapters.TableAdapterManager()
        Me.Tb_DetalleRematesTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_DetalleRematesTableAdapter()
        CType(Me.TbJornadasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCarrerasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCaballosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCarrerasCaballosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbJornada
        '
        Me.cbJornada.DataSource = Me.TbJornadasBindingSource
        Me.cbJornada.DisplayMember = "Descripcion"
        Me.cbJornada.FormattingEnabled = True
        Me.cbJornada.Location = New System.Drawing.Point(80, 38)
        Me.cbJornada.Name = "cbJornada"
        Me.cbJornada.Size = New System.Drawing.Size(221, 21)
        Me.cbJornada.TabIndex = 0
        Me.cbJornada.ValueMember = "Id"
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
        'Tb_JornadasTableAdapter
        '
        Me.Tb_JornadasTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Jornada:"
        '
        'cbCarrera
        '
        Me.cbCarrera.DataSource = Me.TbCarrerasBindingSource
        Me.cbCarrera.DisplayMember = "Nombre"
        Me.cbCarrera.FormattingEnabled = True
        Me.cbCarrera.Location = New System.Drawing.Point(80, 65)
        Me.cbCarrera.Name = "cbCarrera"
        Me.cbCarrera.Size = New System.Drawing.Size(221, 21)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Carrera:"
        '
        'nNumero
        '
        Me.nNumero.Location = New System.Drawing.Point(80, 93)
        Me.nNumero.Name = "nNumero"
        Me.nNumero.Size = New System.Drawing.Size(120, 20)
        Me.nNumero.TabIndex = 5
        '
        'txMetros
        '
        Me.txMetros.Location = New System.Drawing.Point(80, 149)
        Me.txMetros.Name = "txMetros"
        Me.txMetros.Size = New System.Drawing.Size(120, 20)
        Me.txMetros.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Metros:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Carrera Nro:"
        '
        'txNombre
        '
        Me.txNombre.Location = New System.Drawing.Point(307, 65)
        Me.txNombre.Name = "txNombre"
        Me.txNombre.Size = New System.Drawing.Size(271, 20)
        Me.txNombre.TabIndex = 9
        '
        'txObservacion
        '
        Me.txObservacion.Location = New System.Drawing.Point(307, 149)
        Me.txObservacion.Multiline = True
        Me.txObservacion.Name = "txObservacion"
        Me.txObservacion.Size = New System.Drawing.Size(271, 71)
        Me.txObservacion.TabIndex = 10
        '
        'cbEstado
        '
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"0", "1"})
        Me.cbEstado.Location = New System.Drawing.Point(80, 121)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(121, 21)
        Me.cbEstado.TabIndex = 11
        '
        'cbTipo
        '
        Me.cbTipo.AutoCompleteCustomSource.AddRange(New String() {"Normal", "Llave"})
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Items.AddRange(New Object() {"Normal", "Llave"})
        Me.cbTipo.Location = New System.Drawing.Point(307, 121)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(121, 21)
        Me.cbTipo.TabIndex = 12
        '
        'txPorcCasa
        '
        Me.txPorcCasa.Location = New System.Drawing.Point(307, 93)
        Me.txPorcCasa.Name = "txPorcCasa"
        Me.txPorcCasa.Size = New System.Drawing.Size(121, 20)
        Me.txPorcCasa.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Estado:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(270, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Tipo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(259, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "% Caja:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(220, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Observaciones:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdCarreraDataGridViewTextBoxColumn, Me.OrdenDataGridViewTextBoxColumn, Me.IdCaballoDataGridViewTextBoxColumn, Me.NoTomaNuevosRematesDataGridViewCheckBoxColumn, Me.PosicionDataGridViewTextBoxColumn, Me.LuzDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.TbCarrerasCaballosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(33, 280)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(545, 305)
        Me.DataGridView1.TabIndex = 18
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'IdCarreraDataGridViewTextBoxColumn
        '
        Me.IdCarreraDataGridViewTextBoxColumn.DataPropertyName = "IdCarrera"
        Me.IdCarreraDataGridViewTextBoxColumn.HeaderText = "Carrera"
        Me.IdCarreraDataGridViewTextBoxColumn.Name = "IdCarreraDataGridViewTextBoxColumn"
        Me.IdCarreraDataGridViewTextBoxColumn.Visible = False
        Me.IdCarreraDataGridViewTextBoxColumn.Width = 150
        '
        'OrdenDataGridViewTextBoxColumn
        '
        Me.OrdenDataGridViewTextBoxColumn.DataPropertyName = "Orden"
        Me.OrdenDataGridViewTextBoxColumn.HeaderText = "Orden"
        Me.OrdenDataGridViewTextBoxColumn.Name = "OrdenDataGridViewTextBoxColumn"
        Me.OrdenDataGridViewTextBoxColumn.Width = 50
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
        Me.LuzDataGridViewCheckBoxColumn.HeaderText = "Luz"
        Me.LuzDataGridViewCheckBoxColumn.Name = "LuzDataGridViewCheckBoxColumn"
        '
        'TbCarrerasCaballosBindingSource
        '
        Me.TbCarrerasCaballosBindingSource.DataMember = "tb_CarrerasCaballos"
        Me.TbCarrerasCaballosBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.TbCarrerasCaballosBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(33, 252)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(255, 25)
        Me.BindingNavigator1.TabIndex = 19
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tb_CarrerasCaballosTableAdapter
        '
        Me.Tb_CarrerasCaballosTableAdapter.ClearBeforeFill = True
        '
        'Tb_CaballosTableAdapter
        '
        Me.Tb_CaballosTableAdapter.ClearBeforeFill = True
        '
        'btModificar
        '
        Me.btModificar.Location = New System.Drawing.Point(375, 599)
        Me.btModificar.Name = "btModificar"
        Me.btModificar.Size = New System.Drawing.Size(100, 23)
        Me.btModificar.TabIndex = 20
        Me.btModificar.Text = "Modificar"
        Me.btModificar.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Location = New System.Drawing.Point(477, 599)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(100, 23)
        Me.btCancelar.TabIndex = 21
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_CaballosTableAdapter = Me.Tb_CaballosTableAdapter
        Me.TableAdapterManager.tb_CarrerasCaballosTableAdapter = Me.Tb_CarrerasCaballosTableAdapter
        Me.TableAdapterManager.tb_CarrerasTableAdapter = Me.Tb_CarrerasTableAdapter
        Me.TableAdapterManager.tb_DetalleRematesTableAdapter = Nothing
        Me.TableAdapterManager.tb_HipodromosTableAdapter = Nothing
        Me.TableAdapterManager.tb_JornadasTableAdapter = Me.Tb_JornadasTableAdapter
        Me.TableAdapterManager.tb_PalcosTableAdapter = Nothing
        Me.TableAdapterManager.tb_RematadoresTableAdapter = Nothing
        Me.TableAdapterManager.tb_RematesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SIGAP.bdSIGAP_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tb_DetalleRematesTableAdapter
        '
        Me.Tb_DetalleRematesTableAdapter.ClearBeforeFill = True
        '
        'frmModificarCarrera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 634)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btModificar)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txPorcCasa)
        Me.Controls.Add(Me.cbTipo)
        Me.Controls.Add(Me.cbEstado)
        Me.Controls.Add(Me.txObservacion)
        Me.Controls.Add(Me.txNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txMetros)
        Me.Controls.Add(Me.nNumero)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbCarrera)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbJornada)
        Me.Name = "frmModificarCarrera"
        Me.Text = "Modificar Carrera"
        CType(Me.TbJornadasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbCarrerasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbCaballosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbCarrerasCaballosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbJornada As ComboBox
    Friend WithEvents BdSIGAP_DataSet As bdSIGAP_DataSet
    Friend WithEvents TbJornadasBindingSource As BindingSource
    Friend WithEvents Tb_JornadasTableAdapter As bdSIGAP_DataSetTableAdapters.tb_JornadasTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents cbCarrera As ComboBox
    Friend WithEvents TbCarrerasBindingSource As BindingSource
    Friend WithEvents Tb_CarrerasTableAdapter As bdSIGAP_DataSetTableAdapters.tb_CarrerasTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents nNumero As NumericUpDown
    Friend WithEvents txMetros As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txNombre As TextBox
    Friend WithEvents txObservacion As TextBox
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents cbTipo As ComboBox
    Friend WithEvents txPorcCasa As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TbCarrerasCaballosBindingSource As BindingSource
    Friend WithEvents Tb_CarrerasCaballosTableAdapter As bdSIGAP_DataSetTableAdapters.tb_CarrerasCaballosTableAdapter
    Friend WithEvents TbCaballosBindingSource As BindingSource
    Friend WithEvents Tb_CaballosTableAdapter As bdSIGAP_DataSetTableAdapters.tb_CaballosTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCarreraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrdenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCaballoDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents NoTomaNuevosRematesDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PosicionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LuzDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents btModificar As Button
    Friend WithEvents btCancelar As Button
    Friend WithEvents TableAdapterManager As bdSIGAP_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_DetalleRematesTableAdapter As bdSIGAP_DataSetTableAdapters.tb_DetalleRematesTableAdapter
End Class
