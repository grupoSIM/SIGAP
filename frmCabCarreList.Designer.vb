<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCabCarreList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCabCarreList))
        Me.BdSIGAP_DataSet = New SIGAP.bdSIGAP_DataSet()
        Me.Tb_CarrerasCaballosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_CarrerasCaballosTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CarrerasCaballosTableAdapter()
        Me.TableAdapterManager = New SIGAP.bdSIGAP_DataSetTableAdapters.TableAdapterManager()
        Me.Tb_CarrerasCaballosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tb_CarrerasCaballosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tb_CarrerasCaballosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TbCarrerasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TbCaballosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tb_CarrerasTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CarrerasTableAdapter()
        Me.Tb_CaballosTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CaballosTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_CarrerasCaballosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_CarrerasCaballosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tb_CarrerasCaballosBindingNavigator.SuspendLayout()
        CType(Me.Tb_CarrerasCaballosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCarrerasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCaballosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BdSIGAP_DataSet
        '
        Me.BdSIGAP_DataSet.DataSetName = "bdSIGAP_DataSet"
        Me.BdSIGAP_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_CarrerasCaballosBindingSource
        '
        Me.Tb_CarrerasCaballosBindingSource.DataMember = "tb_CarrerasCaballos"
        Me.Tb_CarrerasCaballosBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'Tb_CarrerasCaballosTableAdapter
        '
        Me.Tb_CarrerasCaballosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_CaballosTableAdapter = Nothing
        Me.TableAdapterManager.tb_CarrerasCaballosTableAdapter = Me.Tb_CarrerasCaballosTableAdapter
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
        'Tb_CarrerasCaballosBindingNavigator
        '
        Me.Tb_CarrerasCaballosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tb_CarrerasCaballosBindingNavigator.BindingSource = Me.Tb_CarrerasCaballosBindingSource
        Me.Tb_CarrerasCaballosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tb_CarrerasCaballosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tb_CarrerasCaballosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tb_CarrerasCaballosBindingNavigatorSaveItem})
        Me.Tb_CarrerasCaballosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tb_CarrerasCaballosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tb_CarrerasCaballosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tb_CarrerasCaballosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tb_CarrerasCaballosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tb_CarrerasCaballosBindingNavigator.Name = "Tb_CarrerasCaballosBindingNavigator"
        Me.Tb_CarrerasCaballosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tb_CarrerasCaballosBindingNavigator.Size = New System.Drawing.Size(880, 25)
        Me.Tb_CarrerasCaballosBindingNavigator.TabIndex = 0
        Me.Tb_CarrerasCaballosBindingNavigator.Text = "BindingNavigator1"
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
        'Tb_CarrerasCaballosBindingNavigatorSaveItem
        '
        Me.Tb_CarrerasCaballosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tb_CarrerasCaballosBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tb_CarrerasCaballosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tb_CarrerasCaballosBindingNavigatorSaveItem.Name = "Tb_CarrerasCaballosBindingNavigatorSaveItem"
        Me.Tb_CarrerasCaballosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tb_CarrerasCaballosBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tb_CarrerasCaballosDataGridView
        '
        Me.Tb_CarrerasCaballosDataGridView.AutoGenerateColumns = False
        Me.Tb_CarrerasCaballosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tb_CarrerasCaballosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn5})
        Me.Tb_CarrerasCaballosDataGridView.DataSource = Me.Tb_CarrerasCaballosBindingSource
        Me.Tb_CarrerasCaballosDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.Tb_CarrerasCaballosDataGridView.Name = "Tb_CarrerasCaballosDataGridView"
        Me.Tb_CarrerasCaballosDataGridView.Size = New System.Drawing.Size(851, 464)
        Me.Tb_CarrerasCaballosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdCarrera"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.TbCarrerasBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdCarrera"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "Id"
        '
        'TbCarrerasBindingSource
        '
        Me.TbCarrerasBindingSource.DataMember = "tb_Carreras"
        Me.TbCarrerasBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdCaballo"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.TbCaballosBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "CaballoNombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IdCaballo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "Id"
        '
        'TbCaballosBindingSource
        '
        Me.TbCaballosBindingSource.DataMember = "tb_Caballos"
        Me.TbCaballosBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "NoTomaNuevosRemates"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "NoTomaNuevosRemates"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Posicion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Posicion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Luz"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Luz"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Orden"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Orden"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Tb_CarrerasTableAdapter
        '
        Me.Tb_CarrerasTableAdapter.ClearBeforeFill = True
        '
        'Tb_CaballosTableAdapter
        '
        Me.Tb_CaballosTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(368, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmCabCarreList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 504)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Tb_CarrerasCaballosDataGridView)
        Me.Controls.Add(Me.Tb_CarrerasCaballosBindingNavigator)
        Me.Name = "frmCabCarreList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carreras Caballos"
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_CarrerasCaballosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_CarrerasCaballosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tb_CarrerasCaballosBindingNavigator.ResumeLayout(False)
        Me.Tb_CarrerasCaballosBindingNavigator.PerformLayout()
        CType(Me.Tb_CarrerasCaballosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbCarrerasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbCaballosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BdSIGAP_DataSet As bdSIGAP_DataSet
    Friend WithEvents Tb_CarrerasCaballosBindingSource As BindingSource
    Friend WithEvents Tb_CarrerasCaballosTableAdapter As bdSIGAP_DataSetTableAdapters.tb_CarrerasCaballosTableAdapter
    Friend WithEvents TableAdapterManager As bdSIGAP_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_CarrerasCaballosBindingNavigator As BindingNavigator
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
    Friend WithEvents Tb_CarrerasCaballosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tb_CarrerasCaballosDataGridView As DataGridView
    Friend WithEvents TbCarrerasBindingSource As BindingSource
    Friend WithEvents Tb_CarrerasTableAdapter As bdSIGAP_DataSetTableAdapters.tb_CarrerasTableAdapter
    Friend WithEvents TbCaballosBindingSource As BindingSource
    Friend WithEvents Tb_CaballosTableAdapter As bdSIGAP_DataSetTableAdapters.tb_CaballosTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
