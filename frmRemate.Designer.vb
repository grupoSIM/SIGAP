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
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbDetalleRematesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCarrerasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_CaballosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_CarrerasCaballosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.cmbCarrera.FormattingEnabled = True
        Me.cmbCarrera.Location = New System.Drawing.Point(6, 65)
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
        Me.txtRemate.Location = New System.Drawing.Point(226, 66)
        Me.txtRemate.Name = "txtRemate"
        Me.txtRemate.Size = New System.Drawing.Size(100, 20)
        Me.txtRemate.TabIndex = 2
        '
        'txtPorcentajeCasa
        '
        Me.txtPorcentajeCasa.Location = New System.Drawing.Point(439, 65)
        Me.txtPorcentajeCasa.Name = "txtPorcentajeCasa"
        Me.txtPorcentajeCasa.Size = New System.Drawing.Size(100, 20)
        Me.txtPorcentajeCasa.TabIndex = 3
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(480, 334)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtJornada
        '
        Me.txtJornada.Enabled = False
        Me.txtJornada.Location = New System.Drawing.Point(126, 27)
        Me.txtJornada.Name = "txtJornada"
        Me.txtJornada.ReadOnly = True
        Me.txtJornada.Size = New System.Drawing.Size(100, 20)
        Me.txtJornada.TabIndex = 0
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(328, 27)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 0
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
        'frmRemate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 362)
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
End Class
