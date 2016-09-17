<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRemate
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
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim NroCarreraLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim PorcentajeCasaLabel As System.Windows.Forms.Label
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Tb_DetalleRematesTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_DetalleRematesTableAdapter()
        Me.BdSIGAP_DataSet2 = New SIGAP.bdSIGAP_DataSet()
        Me.Tb_JornadasBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_JornadasTableAdapter2 = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_JornadasTableAdapter()
        Me.TableAdapterManager2 = New SIGAP.bdSIGAP_DataSetTableAdapters.TableAdapterManager()
        Me.DescripcionComboBox = New System.Windows.Forms.ComboBox()
        Me.FechaTextBox = New System.Windows.Forms.TextBox()
        Me.Tb_CarrerasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_CarrerasTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CarrerasTableAdapter()
        Me.NroCarreraComboBox = New System.Windows.Forms.ComboBox()
        Me.Tb_RematesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_RematesTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_RematesTableAdapter()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.PorcentajeCasaTextBox = New System.Windows.Forms.TextBox()
        Me.Tb_DetalleRematesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_DetalleRematesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        DescripcionLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        NroCarreraLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        PorcentajeCasaLabel = New System.Windows.Forms.Label()
        CType(Me.BdSIGAP_DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_JornadasBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_CarrerasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_RematesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_DetalleRematesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_DetalleRematesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(289, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(44, 13)
        Me.lblTitulo.TabIndex = 6
        Me.lblTitulo.Text = "Remate"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(451, 335)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Tb_DetalleRematesTableAdapter
        '
        Me.Tb_DetalleRematesTableAdapter.ClearBeforeFill = True
        '
        'BdSIGAP_DataSet2
        '
        Me.BdSIGAP_DataSet2.DataSetName = "bdSIGAP_DataSet"
        Me.BdSIGAP_DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_JornadasBindingSource2
        '
        Me.Tb_JornadasBindingSource2.DataMember = "tb_Jornadas"
        Me.Tb_JornadasBindingSource2.DataSource = Me.BdSIGAP_DataSet2
        '
        'Tb_JornadasTableAdapter2
        '
        Me.Tb_JornadasTableAdapter2.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.tb_CaballosTableAdapter = Nothing
        Me.TableAdapterManager2.tb_CarrerasCaballosTableAdapter = Nothing
        Me.TableAdapterManager2.tb_CarrerasTableAdapter = Me.Tb_CarrerasTableAdapter
        Me.TableAdapterManager2.tb_DetalleRematesTableAdapter = Me.Tb_DetalleRematesTableAdapter
        Me.TableAdapterManager2.tb_HipodromosTableAdapter = Nothing
        Me.TableAdapterManager2.tb_JornadasTableAdapter = Me.Tb_JornadasTableAdapter2
        Me.TableAdapterManager2.tb_PalcosTableAdapter = Nothing
        Me.TableAdapterManager2.tb_RematadoresTableAdapter = Nothing
        Me.TableAdapterManager2.tb_RematesTableAdapter = Me.Tb_RematesTableAdapter
        Me.TableAdapterManager2.UpdateOrder = SIGAP.bdSIGAP_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(75, 66)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 13
        DescripcionLabel.Text = "Descripcion:"
        '
        'DescripcionComboBox
        '
        Me.DescripcionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_JornadasBindingSource2, "Descripcion", True))
        Me.DescripcionComboBox.DataSource = Me.Tb_JornadasBindingSource2
        Me.DescripcionComboBox.DisplayMember = "Descripcion"
        Me.DescripcionComboBox.FormattingEnabled = True
        Me.DescripcionComboBox.Location = New System.Drawing.Point(147, 63)
        Me.DescripcionComboBox.Name = "DescripcionComboBox"
        Me.DescripcionComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DescripcionComboBox.TabIndex = 14
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(410, 70)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 14
        FechaLabel.Text = "Fecha:"
        '
        'FechaTextBox
        '
        Me.FechaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_JornadasBindingSource2, "Fecha", True))
        Me.FechaTextBox.Location = New System.Drawing.Point(456, 67)
        Me.FechaTextBox.Name = "FechaTextBox"
        Me.FechaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FechaTextBox.TabIndex = 15
        '
        'Tb_CarrerasBindingSource
        '
        Me.Tb_CarrerasBindingSource.DataMember = "tb_Jornadastb_Carreras"
        Me.Tb_CarrerasBindingSource.DataSource = Me.Tb_JornadasBindingSource2
        '
        'Tb_CarrerasTableAdapter
        '
        Me.Tb_CarrerasTableAdapter.ClearBeforeFill = True
        '
        'NroCarreraLabel
        '
        NroCarreraLabel.AutoSize = True
        NroCarreraLabel.Location = New System.Drawing.Point(57, 129)
        NroCarreraLabel.Name = "NroCarreraLabel"
        NroCarreraLabel.Size = New System.Drawing.Size(64, 13)
        NroCarreraLabel.TabIndex = 15
        NroCarreraLabel.Text = "Nro Carrera:"
        '
        'NroCarreraComboBox
        '
        Me.NroCarreraComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_CarrerasBindingSource, "NroCarrera", True))
        Me.NroCarreraComboBox.FormattingEnabled = True
        Me.NroCarreraComboBox.Location = New System.Drawing.Point(127, 126)
        Me.NroCarreraComboBox.Name = "NroCarreraComboBox"
        Me.NroCarreraComboBox.Size = New System.Drawing.Size(121, 21)
        Me.NroCarreraComboBox.TabIndex = 16
        '
        'Tb_RematesBindingSource
        '
        Me.Tb_RematesBindingSource.DataMember = "tb_Carrerastb_Remates"
        Me.Tb_RematesBindingSource.DataSource = Me.Tb_CarrerasBindingSource
        '
        'Tb_RematesTableAdapter
        '
        Me.Tb_RematesTableAdapter.ClearBeforeFill = True
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(343, 134)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 16
        IdLabel.Text = "Id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_RematesBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(368, 131)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 17
        '
        'PorcentajeCasaLabel
        '
        PorcentajeCasaLabel.AutoSize = True
        PorcentajeCasaLabel.Location = New System.Drawing.Point(565, 131)
        PorcentajeCasaLabel.Name = "PorcentajeCasaLabel"
        PorcentajeCasaLabel.Size = New System.Drawing.Size(88, 13)
        PorcentajeCasaLabel.TabIndex = 17
        PorcentajeCasaLabel.Text = "Porcentaje Casa:"
        '
        'PorcentajeCasaTextBox
        '
        Me.PorcentajeCasaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_RematesBindingSource, "PorcentajeCasa", True))
        Me.PorcentajeCasaTextBox.Location = New System.Drawing.Point(659, 128)
        Me.PorcentajeCasaTextBox.Name = "PorcentajeCasaTextBox"
        Me.PorcentajeCasaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PorcentajeCasaTextBox.TabIndex = 18
        '
        'Tb_DetalleRematesBindingSource
        '
        Me.Tb_DetalleRematesBindingSource.DataMember = "tb_Rematestb_DetalleRemates"
        Me.Tb_DetalleRematesBindingSource.DataSource = Me.Tb_RematesBindingSource
        '
        'Tb_DetalleRematesDataGridView
        '
        Me.Tb_DetalleRematesDataGridView.AutoGenerateColumns = False
        Me.Tb_DetalleRematesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tb_DetalleRematesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.Tb_DetalleRematesDataGridView.DataSource = Me.Tb_DetalleRematesBindingSource
        Me.Tb_DetalleRematesDataGridView.Location = New System.Drawing.Point(78, 177)
        Me.Tb_DetalleRematesDataGridView.Name = "Tb_DetalleRematesDataGridView"
        Me.Tb_DetalleRematesDataGridView.Size = New System.Drawing.Size(614, 144)
        Me.Tb_DetalleRematesDataGridView.TabIndex = 18
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdRemate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdRemate"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdCarreraCaballo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IdCarreraCaballo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NroCaballo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NroCaballo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Apostador"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Apostador"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ImporteApuesta"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ImporteApuesta"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Luz"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Luz"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Fila"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fila"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ImportePremio"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ImportePremio"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'frmRemate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 417)
        Me.Controls.Add(Me.Tb_DetalleRematesDataGridView)
        Me.Controls.Add(PorcentajeCasaLabel)
        Me.Controls.Add(Me.PorcentajeCasaTextBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(NroCarreraLabel)
        Me.Controls.Add(Me.NroCarreraComboBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionComboBox)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmRemate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remate"
        CType(Me.BdSIGAP_DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_JornadasBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_CarrerasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_RematesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_DetalleRematesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_DetalleRematesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents BdSIGAP_DataSet As bdSIGAP_DataSet
    Friend WithEvents Tb_JornadasBindingSource As BindingSource
    Friend WithEvents Tb_JornadasTableAdapter As bdSIGAP_DataSetTableAdapters.tb_JornadasTableAdapter
    Friend WithEvents TableAdapterManager As bdSIGAP_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_JornadasBindingNavigator As BindingNavigator
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
    Friend WithEvents Tb_JornadasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tb_JornadasBindingSource1BindingNavigator As BindingNavigator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents Tb_JornadasBindingSource1BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BdSIGAP_DataSet1 As bdSIGAP_DataSet
    Friend WithEvents Tb_JornadasBindingSource1 As BindingSource
    Friend WithEvents Tb_JornadasTableAdapter1 As bdSIGAP_DataSetTableAdapters.tb_JornadasTableAdapter
    Friend WithEvents TableAdapterManager1 As bdSIGAP_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_JornadasBindingSource1BindingNavigator1 As BindingNavigator
    Friend WithEvents ToolStripButton11 As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripButton12 As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton9 As ToolStripButton
    Friend WithEvents ToolStripButton10 As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents Tb_JornadasBindingSource1BindingNavigator1SaveItem As ToolStripButton
    Friend WithEvents Tb_JornadasBindingSource2BindingNavigator As BindingNavigator
    Friend WithEvents ToolStripButton17 As ToolStripButton
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripButton18 As ToolStripButton
    Friend WithEvents ToolStripButton13 As ToolStripButton
    Friend WithEvents ToolStripButton14 As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox3 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripButton15 As ToolStripButton
    Friend WithEvents ToolStripButton16 As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents Tb_JornadasBindingSource2BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tb_DetalleRematesTableAdapter As bdSIGAP_DataSetTableAdapters.tb_DetalleRematesTableAdapter
    Friend WithEvents BdSIGAP_DataSet2 As bdSIGAP_DataSet
    Friend WithEvents Tb_JornadasBindingSource2 As BindingSource
    Friend WithEvents Tb_JornadasTableAdapter2 As bdSIGAP_DataSetTableAdapters.tb_JornadasTableAdapter
    Friend WithEvents TableAdapterManager2 As bdSIGAP_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_CarrerasTableAdapter As bdSIGAP_DataSetTableAdapters.tb_CarrerasTableAdapter
    Friend WithEvents DescripcionComboBox As ComboBox
    Friend WithEvents FechaTextBox As TextBox
    Friend WithEvents Tb_CarrerasBindingSource As BindingSource
    Friend WithEvents Tb_RematesTableAdapter As bdSIGAP_DataSetTableAdapters.tb_RematesTableAdapter
    Friend WithEvents NroCarreraComboBox As ComboBox
    Friend WithEvents Tb_RematesBindingSource As BindingSource
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents PorcentajeCasaTextBox As TextBox
    Friend WithEvents Tb_DetalleRematesBindingSource As BindingSource
    Friend WithEvents Tb_DetalleRematesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
End Class
