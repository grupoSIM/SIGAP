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
        Me.BdSIGAP_DataSet = New SIGAP.bdSIGAP_DataSet()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdRemateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCarreraCaballoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroCaballoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Caballo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApostadorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteApuestaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Incluido = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LuzDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FilaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ImportePremioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbDetalleRematesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_DetalleRematesTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_DetalleRematesTableAdapter()
        Me.cmbCarrera = New System.Windows.Forms.ComboBox()
        Me.TbCarrerasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_CarrerasTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CarrerasTableAdapter()
        Me.Tb_CaballosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_CaballosTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CaballosTableAdapter()
        Me.TableAdapterManager = New SIGAP.bdSIGAP_DataSetTableAdapters.TableAdapterManager()
        Me.Tb_CarrerasCaballosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_CarrerasCaballosTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CarrerasCaballosTableAdapter()
        Me.Tb_RematesTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_RematesTableAdapter()
        Me.txtRemate = New System.Windows.Forms.TextBox()
        Me.txtPorcentajeCasa = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtJornada = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Tb_JornadasTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_JornadasTableAdapter()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.TbRematesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tb_PalcosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_PalcosTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_PalcosTableAdapter()
        Me.cmbPalco = New System.Windows.Forms.ComboBox()
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbDetalleRematesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCarrerasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_CaballosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_CarrerasCaballosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbRematesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_PalcosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BdSIGAP_DataSet
        '
        Me.BdSIGAP_DataSet.DataSetName = "bdSIGAP_DataSet"
        Me.BdSIGAP_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(256, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(44, 13)
        Me.lblTitulo.TabIndex = 6
        Me.lblTitulo.Text = "Remate"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdRemateDataGridViewTextBoxColumn, Me.IdCarreraCaballoDataGridViewTextBoxColumn, Me.NroCaballoDataGridViewTextBoxColumn, Me.Caballo, Me.ApostadorDataGridViewTextBoxColumn, Me.ImporteApuestaDataGridViewTextBoxColumn, Me.Incluido, Me.LuzDataGridViewTextBoxColumn, Me.FilaDataGridViewTextBoxColumn, Me.ImportePremioDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TbDetalleRematesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 103)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(595, 225)
        Me.DataGridView1.TabIndex = 4
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'IdRemateDataGridViewTextBoxColumn
        '
        Me.IdRemateDataGridViewTextBoxColumn.DataPropertyName = "IdRemate"
        Me.IdRemateDataGridViewTextBoxColumn.HeaderText = "IdRemate"
        Me.IdRemateDataGridViewTextBoxColumn.Name = "IdRemateDataGridViewTextBoxColumn"
        Me.IdRemateDataGridViewTextBoxColumn.Visible = False
        '
        'IdCarreraCaballoDataGridViewTextBoxColumn
        '
        Me.IdCarreraCaballoDataGridViewTextBoxColumn.DataPropertyName = "IdCarreraCaballo"
        Me.IdCarreraCaballoDataGridViewTextBoxColumn.HeaderText = "IdCarreraCaballo"
        Me.IdCarreraCaballoDataGridViewTextBoxColumn.Name = "IdCarreraCaballoDataGridViewTextBoxColumn"
        Me.IdCarreraCaballoDataGridViewTextBoxColumn.Visible = False
        '
        'NroCaballoDataGridViewTextBoxColumn
        '
        Me.NroCaballoDataGridViewTextBoxColumn.DataPropertyName = "NroCaballo"
        Me.NroCaballoDataGridViewTextBoxColumn.HeaderText = "Número"
        Me.NroCaballoDataGridViewTextBoxColumn.Name = "NroCaballoDataGridViewTextBoxColumn"
        Me.NroCaballoDataGridViewTextBoxColumn.Width = 50
        '
        'Caballo
        '
        Me.Caballo.HeaderText = "Caballo"
        Me.Caballo.Name = "Caballo"
        Me.Caballo.ReadOnly = True
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
        'Incluido
        '
        Me.Incluido.DataPropertyName = "Incluido"
        Me.Incluido.HeaderText = "Incluido"
        Me.Incluido.Name = "Incluido"
        Me.Incluido.Width = 50
        '
        'LuzDataGridViewTextBoxColumn
        '
        Me.LuzDataGridViewTextBoxColumn.DataPropertyName = "Luz"
        Me.LuzDataGridViewTextBoxColumn.HeaderText = "Luz"
        Me.LuzDataGridViewTextBoxColumn.Items.AddRange(New Object() {"Da", "Recibe"})
        Me.LuzDataGridViewTextBoxColumn.Name = "LuzDataGridViewTextBoxColumn"
        Me.LuzDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LuzDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'FilaDataGridViewTextBoxColumn
        '
        Me.FilaDataGridViewTextBoxColumn.DataPropertyName = "Fila"
        Me.FilaDataGridViewTextBoxColumn.HeaderText = "Fila"
        Me.FilaDataGridViewTextBoxColumn.Name = "FilaDataGridViewTextBoxColumn"
        Me.FilaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FilaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FilaDataGridViewTextBoxColumn.Width = 50
        '
        'ImportePremioDataGridViewTextBoxColumn
        '
        Me.ImportePremioDataGridViewTextBoxColumn.DataPropertyName = "ImportePremio"
        Me.ImportePremioDataGridViewTextBoxColumn.HeaderText = "ImportePremio"
        Me.ImportePremioDataGridViewTextBoxColumn.Name = "ImportePremioDataGridViewTextBoxColumn"
        Me.ImportePremioDataGridViewTextBoxColumn.Visible = False
        '
        'TbDetalleRematesBindingSource
        '
        Me.TbDetalleRematesBindingSource.DataMember = "tb_DetalleRemates"
        Me.TbDetalleRematesBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'Tb_DetalleRematesTableAdapter
        '
        Me.Tb_DetalleRematesTableAdapter.ClearBeforeFill = True
        '
        'cmbCarrera
        '
        Me.cmbCarrera.DataSource = Me.TbCarrerasBindingSource
        Me.cmbCarrera.DisplayMember = "NroCarrera"
        Me.cmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarrera.FormattingEnabled = True
        Me.cmbCarrera.Location = New System.Drawing.Point(81, 64)
        Me.cmbCarrera.Name = "cmbCarrera"
        Me.cmbCarrera.Size = New System.Drawing.Size(121, 21)
        Me.cmbCarrera.TabIndex = 1
        Me.cmbCarrera.ValueMember = "Id"
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
        'Tb_CaballosBindingSource
        '
        Me.Tb_CaballosBindingSource.DataMember = "tb_Caballos"
        Me.Tb_CaballosBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'Tb_CaballosTableAdapter
        '
        Me.Tb_CaballosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_CaballosTableAdapter = Me.Tb_CaballosTableAdapter
        Me.TableAdapterManager.tb_CarrerasCaballosTableAdapter = Nothing
        Me.TableAdapterManager.tb_CarrerasTableAdapter = Me.Tb_CarrerasTableAdapter
        Me.TableAdapterManager.tb_DetalleRematesTableAdapter = Me.Tb_DetalleRematesTableAdapter
        Me.TableAdapterManager.tb_HipodromosTableAdapter = Nothing
        Me.TableAdapterManager.tb_JornadasTableAdapter = Nothing
        Me.TableAdapterManager.tb_PalcosTableAdapter = Nothing
        Me.TableAdapterManager.tb_RematadoresTableAdapter = Nothing
        Me.TableAdapterManager.tb_RematesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SIGAP.bdSIGAP_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'Tb_RematesTableAdapter
        '
        Me.Tb_RematesTableAdapter.ClearBeforeFill = True
        '
        'txtRemate
        '
        Me.txtRemate.Enabled = False
        Me.txtRemate.Location = New System.Drawing.Point(308, 64)
        Me.txtRemate.Name = "txtRemate"
        Me.txtRemate.ReadOnly = True
        Me.txtRemate.Size = New System.Drawing.Size(100, 20)
        Me.txtRemate.TabIndex = 2
        '
        'txtPorcentajeCasa
        '
        Me.txtPorcentajeCasa.Location = New System.Drawing.Point(478, 64)
        Me.txtPorcentajeCasa.Name = "txtPorcentajeCasa"
        Me.txtPorcentajeCasa.Size = New System.Drawing.Size(100, 20)
        Me.txtPorcentajeCasa.TabIndex = 3
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(411, 334)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtJornada
        '
        Me.txtJornada.Enabled = False
        Me.txtJornada.Location = New System.Drawing.Point(102, 27)
        Me.txtJornada.Name = "txtJornada"
        Me.txtJornada.ReadOnly = True
        Me.txtJornada.Size = New System.Drawing.Size(100, 20)
        Me.txtJornada.TabIndex = 0
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(276, 27)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 0
        '
        'Tb_JornadasTableAdapter
        '
        Me.Tb_JornadasTableAdapter.ClearBeforeFill = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(497, 334)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(104, 23)
        Me.btnImprimir.TabIndex = 7
        Me.btnImprimir.Text = "Guardar e Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'TbRematesBindingSource
        '
        Me.TbRematesBindingSource.DataMember = "tb_Remates"
        Me.TbRematesBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(408, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Palco"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(233, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Jornada"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Carrera"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(220, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Nro. de Remate"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(414, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Porcentaje"
        '
        'Tb_PalcosBindingSource
        '
        Me.Tb_PalcosBindingSource.DataMember = "tb_Palcos"
        Me.Tb_PalcosBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'Tb_PalcosTableAdapter
        '
        Me.Tb_PalcosTableAdapter.ClearBeforeFill = True
        '
        'cmbPalco
        '
        Me.cmbPalco.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_PalcosBindingSource, "Palco", True))
        Me.cmbPalco.DataSource = Me.Tb_PalcosBindingSource
        Me.cmbPalco.DisplayMember = "Palco"
        Me.cmbPalco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPalco.FormattingEnabled = True
        Me.cmbPalco.Location = New System.Drawing.Point(457, 26)
        Me.cmbPalco.Name = "cmbPalco"
        Me.cmbPalco.Size = New System.Drawing.Size(121, 21)
        Me.cmbPalco.TabIndex = 16
        Me.cmbPalco.ValueMember = "Id"
        '
        'frmRemate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 377)
        Me.Controls.Add(Me.cmbPalco)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtJornada)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtPorcentajeCasa)
        Me.Controls.Add(Me.txtRemate)
        Me.Controls.Add(Me.cmbCarrera)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmRemate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remate"
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbDetalleRematesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbCarrerasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_CaballosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_CarrerasCaballosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbRematesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_PalcosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BdSIGAP_DataSet As bdSIGAP_DataSet
    Friend WithEvents lblTitulo As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TbDetalleRematesBindingSource As BindingSource
    Friend WithEvents Tb_DetalleRematesTableAdapter As bdSIGAP_DataSetTableAdapters.tb_DetalleRematesTableAdapter
    Friend WithEvents cmbCarrera As ComboBox
    Friend WithEvents TbCarrerasBindingSource As BindingSource
    Friend WithEvents Tb_CarrerasTableAdapter As bdSIGAP_DataSetTableAdapters.tb_CarrerasTableAdapter
    Friend WithEvents Tb_CaballosBindingSource As BindingSource
    Friend WithEvents Tb_CaballosTableAdapter As bdSIGAP_DataSetTableAdapters.tb_CaballosTableAdapter
    Friend WithEvents TableAdapterManager As bdSIGAP_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_CarrerasCaballosBindingSource As BindingSource
    Friend WithEvents Tb_CarrerasCaballosTableAdapter As bdSIGAP_DataSetTableAdapters.tb_CarrerasCaballosTableAdapter
    Friend WithEvents Tb_RematesTableAdapter As bdSIGAP_DataSetTableAdapters.tb_RematesTableAdapter
    Friend WithEvents txtRemate As TextBox
    Friend WithEvents txtPorcentajeCasa As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtJornada As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Tb_JornadasTableAdapter As bdSIGAP_DataSetTableAdapters.tb_JornadasTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdRemateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCarreraCaballoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroCaballoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Caballo As DataGridViewTextBoxColumn
    Friend WithEvents ApostadorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteApuestaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Incluido As DataGridViewCheckBoxColumn
    Friend WithEvents LuzDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents FilaDataGridViewTextBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ImportePremioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnImprimir As Button
    Friend WithEvents TbRematesBindingSource As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Tb_PalcosBindingSource As BindingSource
    Friend WithEvents Tb_PalcosTableAdapter As bdSIGAP_DataSetTableAdapters.tb_PalcosTableAdapter
    Friend WithEvents cmbPalco As ComboBox
End Class
