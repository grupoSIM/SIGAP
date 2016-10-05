<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmModiRemate
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbJornada = New System.Windows.Forms.ComboBox()
        Me.TbJornadasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdSIGAP_DataSet = New SIGAP.bdSIGAP_DataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbCarrera = New System.Windows.Forms.ComboBox()
        Me.TbCarrerasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txRemate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.TbDetalleRematesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_DetalleRematesTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_DetalleRematesTableAdapter()
        Me.TableAdapterManager = New SIGAP.bdSIGAP_DataSetTableAdapters.TableAdapterManager()
        Me.Tb_CarrerasTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CarrerasTableAdapter()
        Me.Tb_JornadasTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_JornadasTableAdapter()
        Me.Tb_RematesTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_RematesTableAdapter()
        Me.btModificar = New System.Windows.Forms.Button()
        Me.cbPalco = New System.Windows.Forms.ComboBox()
        Me.TbPalcosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txPorcCasa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txTotalApuestas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txPremio = New System.Windows.Forms.TextBox()
        Me.Tb_PalcosTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_PalcosTableAdapter()
        Me.Tb_PorcentajesCasaTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_PorcentajesCasaTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdRemateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCarreraCaballoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroCaballoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApostadorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteApuesta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LuzDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FilaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImportePremio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Incluido = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TbJornadasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCarrerasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbDetalleRematesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbPalcosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jornada:"
        '
        'cbJornada
        '
        Me.cbJornada.DataSource = Me.TbJornadasBindingSource
        Me.cbJornada.DisplayMember = "Descripcion"
        Me.cbJornada.FormattingEnabled = True
        Me.cbJornada.Location = New System.Drawing.Point(106, 17)
        Me.cbJornada.Name = "cbJornada"
        Me.cbJornada.Size = New System.Drawing.Size(463, 21)
        Me.cbJornada.TabIndex = 1
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Carrera:"
        '
        'cbCarrera
        '
        Me.cbCarrera.DataSource = Me.TbCarrerasBindingSource
        Me.cbCarrera.DisplayMember = "Nombre"
        Me.cbCarrera.FormattingEnabled = True
        Me.cbCarrera.Location = New System.Drawing.Point(106, 39)
        Me.cbCarrera.Name = "cbCarrera"
        Me.cbCarrera.Size = New System.Drawing.Size(463, 21)
        Me.cbCarrera.TabIndex = 3
        Me.cbCarrera.ValueMember = "Id"
        '
        'TbCarrerasBindingSource
        '
        Me.TbCarrerasBindingSource.DataMember = "tb_Carreras"
        Me.TbCarrerasBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'txRemate
        '
        Me.txRemate.Location = New System.Drawing.Point(106, 67)
        Me.txRemate.Name = "txRemate"
        Me.txRemate.Size = New System.Drawing.Size(70, 20)
        Me.txRemate.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nro Remate:"
        '
        'DataGridView
        '
        Me.DataGridView.AutoGenerateColumns = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdRemateDataGridViewTextBoxColumn, Me.IdCarreraCaballoDataGridViewTextBoxColumn, Me.NroCaballoDataGridViewTextBoxColumn, Me.ApostadorDataGridViewTextBoxColumn, Me.ImporteApuesta, Me.LuzDataGridViewTextBoxColumn, Me.FilaDataGridViewTextBoxColumn, Me.ImportePremio, Me.Incluido, Me.ObservacionesDataGridViewTextBoxColumn})
        Me.DataGridView.DataSource = Me.TbDetalleRematesBindingSource
        Me.DataGridView.Location = New System.Drawing.Point(-2, 146)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(1141, 200)
        Me.DataGridView.TabIndex = 6
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_CaballosTableAdapter = Nothing
        Me.TableAdapterManager.tb_CarrerasCaballosTableAdapter = Nothing
        Me.TableAdapterManager.tb_CarrerasTableAdapter = Me.Tb_CarrerasTableAdapter
        Me.TableAdapterManager.tb_DetalleRematesTableAdapter = Me.Tb_DetalleRematesTableAdapter
        Me.TableAdapterManager.tb_EventosTableAdapter = Nothing
        Me.TableAdapterManager.tb_HipodromosTableAdapter = Nothing
        Me.TableAdapterManager.tb_JornadasTableAdapter = Me.Tb_JornadasTableAdapter
        Me.TableAdapterManager.tb_PalcosTableAdapter = Nothing
        Me.TableAdapterManager.tb_PorcentajesCasaTableAdapter = Nothing
        Me.TableAdapterManager.tb_RematadoresTableAdapter = Nothing
        Me.TableAdapterManager.tb_RematesTableAdapter = Me.Tb_RematesTableAdapter
        Me.TableAdapterManager.UpdateOrder = SIGAP.bdSIGAP_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tb_CarrerasTableAdapter
        '
        Me.Tb_CarrerasTableAdapter.ClearBeforeFill = True
        '
        'Tb_JornadasTableAdapter
        '
        Me.Tb_JornadasTableAdapter.ClearBeforeFill = True
        '
        'Tb_RematesTableAdapter
        '
        Me.Tb_RematesTableAdapter.ClearBeforeFill = True
        '
        'btModificar
        '
        Me.btModificar.Location = New System.Drawing.Point(1028, 20)
        Me.btModificar.Name = "btModificar"
        Me.btModificar.Size = New System.Drawing.Size(75, 23)
        Me.btModificar.TabIndex = 7
        Me.btModificar.Text = "Modificar"
        Me.btModificar.UseVisualStyleBackColor = True
        '
        'cbPalco
        '
        Me.cbPalco.DataSource = Me.TbPalcosBindingSource
        Me.cbPalco.DisplayMember = "Palco"
        Me.cbPalco.FormattingEnabled = True
        Me.cbPalco.Location = New System.Drawing.Point(224, 67)
        Me.cbPalco.Name = "cbPalco"
        Me.cbPalco.Size = New System.Drawing.Size(121, 21)
        Me.cbPalco.TabIndex = 8
        Me.cbPalco.ValueMember = "Id"
        '
        'TbPalcosBindingSource
        '
        Me.TbPalcosBindingSource.DataMember = "tb_Palcos"
        Me.TbPalcosBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(185, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Palco:"
        '
        'txPorcCasa
        '
        Me.txPorcCasa.Location = New System.Drawing.Point(404, 67)
        Me.txPorcCasa.Name = "txPorcCasa"
        Me.txPorcCasa.Size = New System.Drawing.Size(76, 20)
        Me.txPorcCasa.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(358, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "% Casa:"
        '
        'txTotalApuestas
        '
        Me.txTotalApuestas.Enabled = False
        Me.txTotalApuestas.Location = New System.Drawing.Point(590, 67)
        Me.txTotalApuestas.Name = "txTotalApuestas"
        Me.txTotalApuestas.Size = New System.Drawing.Size(100, 20)
        Me.txTotalApuestas.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(744, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Premio:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(508, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Total Apuesta:"
        '
        'txPremio
        '
        Me.txPremio.Location = New System.Drawing.Point(792, 67)
        Me.txPremio.Name = "txPremio"
        Me.txPremio.Size = New System.Drawing.Size(100, 20)
        Me.txPremio.TabIndex = 16
        '
        'Tb_PalcosTableAdapter
        '
        Me.Tb_PalcosTableAdapter.ClearBeforeFill = True
        '
        'Tb_PorcentajesCasaTableAdapter
        '
        Me.Tb_PorcentajesCasaTableAdapter.ClearBeforeFill = True
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
        'ImporteApuesta
        '
        Me.ImporteApuesta.DataPropertyName = "ImporteApuesta"
        Me.ImporteApuesta.HeaderText = "ImporteApuesta"
        Me.ImporteApuesta.Name = "ImporteApuesta"
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
        'ImportePremio
        '
        Me.ImportePremio.DataPropertyName = "ImportePremio"
        Me.ImportePremio.HeaderText = "ImportePremio"
        Me.ImportePremio.Name = "ImportePremio"
        '
        'Incluido
        '
        Me.Incluido.DataPropertyName = "Incluido"
        Me.Incluido.HeaderText = "Incluido"
        Me.Incluido.Name = "Incluido"
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        '
        'frmModiRemate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1141, 347)
        Me.Controls.Add(Me.txPremio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txTotalApuestas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txPorcCasa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbPalco)
        Me.Controls.Add(Me.btModificar)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txRemate)
        Me.Controls.Add(Me.cbCarrera)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbJornada)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmModiRemate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Remate"
        CType(Me.TbJornadasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbCarrerasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbDetalleRematesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbPalcosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbJornada As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbCarrera As ComboBox
    Friend WithEvents txRemate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents BdSIGAP_DataSet As bdSIGAP_DataSet
    Friend WithEvents TbDetalleRematesBindingSource As BindingSource
    Friend WithEvents Tb_DetalleRematesTableAdapter As bdSIGAP_DataSetTableAdapters.tb_DetalleRematesTableAdapter
    Friend WithEvents TableAdapterManager As bdSIGAP_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_JornadasTableAdapter As bdSIGAP_DataSetTableAdapters.tb_JornadasTableAdapter
    Friend WithEvents TbJornadasBindingSource As BindingSource
    Friend WithEvents Tb_CarrerasTableAdapter As bdSIGAP_DataSetTableAdapters.tb_CarrerasTableAdapter
    Friend WithEvents TbCarrerasBindingSource As BindingSource
    Friend WithEvents Tb_RematesTableAdapter As bdSIGAP_DataSetTableAdapters.tb_RematesTableAdapter
    Friend WithEvents btModificar As Button
    Friend WithEvents cbPalco As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txPorcCasa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txTotalApuestas As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txPremio As TextBox
    Friend WithEvents TbPalcosBindingSource As BindingSource
    Friend WithEvents Tb_PalcosTableAdapter As bdSIGAP_DataSetTableAdapters.tb_PalcosTableAdapter
    Friend WithEvents Tb_PorcentajesCasaTableAdapter As bdSIGAP_DataSetTableAdapters.tb_PorcentajesCasaTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdRemateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCarreraCaballoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroCaballoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApostadorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteApuesta As DataGridViewTextBoxColumn
    Friend WithEvents LuzDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FilaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImportePremio As DataGridViewTextBoxColumn
    Friend WithEvents Incluido As DataGridViewCheckBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
