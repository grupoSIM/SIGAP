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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.TbDetalleRematesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdSIGAP_DataSet = New SIGAP.bdSIGAP_DataSet()
        Me.cmbCarrera = New System.Windows.Forms.ComboBox()
        Me.TbCarrerasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtRemate = New System.Windows.Forms.TextBox()
        Me.txtPorcentajeCasa = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtJornada = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbPalco = New System.Windows.Forms.ComboBox()
        Me.Tb_PalcosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_DetalleRematesTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_DetalleRematesTableAdapter()
        Me.Tb_CarrerasTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CarrerasTableAdapter()
        Me.Tb_CaballosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_CaballosTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CaballosTableAdapter()
        Me.TableAdapterManager = New SIGAP.bdSIGAP_DataSetTableAdapters.TableAdapterManager()
        Me.Tb_CarrerasCaballosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_CarrerasCaballosTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CarrerasCaballosTableAdapter()
        Me.Tb_RematesTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_RematesTableAdapter()
        Me.Tb_JornadasTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_JornadasTableAdapter()
        Me.TbRematesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_PalcosTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_PalcosTableAdapter()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblCaballo = New System.Windows.Forms.Label()
        Me.lblApostador = New System.Windows.Forms.Label()
        Me.lblApuesta = New System.Windows.Forms.Label()
        Me.lblIncluido = New System.Windows.Forms.Label()
        Me.lblLuz = New System.Windows.Forms.Label()
        Me.lblFila = New System.Windows.Forms.Label()
        Me.txtNumero0 = New System.Windows.Forms.TextBox()
        Me.txtCaballo0 = New System.Windows.Forms.TextBox()
        Me.txtApostador0 = New System.Windows.Forms.TextBox()
        Me.mtxApuesta0 = New System.Windows.Forms.MaskedTextBox()
        Me.chbincluido0 = New System.Windows.Forms.CheckBox()
        Me.cmbLuz0 = New System.Windows.Forms.ComboBox()
        Me.radFila0 = New System.Windows.Forms.RadioButton()
        Me.radFila1 = New System.Windows.Forms.RadioButton()
        Me.cmbLuz1 = New System.Windows.Forms.ComboBox()
        Me.chbincluido1 = New System.Windows.Forms.CheckBox()
        Me.mtxApuesta1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtApostador1 = New System.Windows.Forms.TextBox()
        Me.txtCaballo1 = New System.Windows.Forms.TextBox()
        Me.txtNumero1 = New System.Windows.Forms.TextBox()
        Me.radFila2 = New System.Windows.Forms.RadioButton()
        Me.cmbLuz2 = New System.Windows.Forms.ComboBox()
        Me.chbincluido2 = New System.Windows.Forms.CheckBox()
        Me.mtxApuesta2 = New System.Windows.Forms.MaskedTextBox()
        Me.txtApostador2 = New System.Windows.Forms.TextBox()
        Me.txtCaballo2 = New System.Windows.Forms.TextBox()
        Me.txtNumero2 = New System.Windows.Forms.TextBox()
        Me.radFila3 = New System.Windows.Forms.RadioButton()
        Me.cmbLuz3 = New System.Windows.Forms.ComboBox()
        Me.chbincluido3 = New System.Windows.Forms.CheckBox()
        Me.mtxApuesta3 = New System.Windows.Forms.MaskedTextBox()
        Me.txtApostador3 = New System.Windows.Forms.TextBox()
        Me.txtCaballo3 = New System.Windows.Forms.TextBox()
        Me.txtNumero3 = New System.Windows.Forms.TextBox()
        Me.radFila4 = New System.Windows.Forms.RadioButton()
        Me.cmbLuz4 = New System.Windows.Forms.ComboBox()
        Me.chbincluido4 = New System.Windows.Forms.CheckBox()
        Me.mtxApuesta4 = New System.Windows.Forms.MaskedTextBox()
        Me.txtApostador4 = New System.Windows.Forms.TextBox()
        Me.txtCaballo4 = New System.Windows.Forms.TextBox()
        Me.txtNumero4 = New System.Windows.Forms.TextBox()
        Me.radFila5 = New System.Windows.Forms.RadioButton()
        Me.cmbLuz5 = New System.Windows.Forms.ComboBox()
        Me.chbincluido5 = New System.Windows.Forms.CheckBox()
        Me.mtxApuesta5 = New System.Windows.Forms.MaskedTextBox()
        Me.txtApostador5 = New System.Windows.Forms.TextBox()
        Me.txtCaballo5 = New System.Windows.Forms.TextBox()
        Me.txtNumero5 = New System.Windows.Forms.TextBox()
        Me.radFila6 = New System.Windows.Forms.RadioButton()
        Me.cmbLuz6 = New System.Windows.Forms.ComboBox()
        Me.chbincluido6 = New System.Windows.Forms.CheckBox()
        Me.mtxApuesta6 = New System.Windows.Forms.MaskedTextBox()
        Me.txtApostador6 = New System.Windows.Forms.TextBox()
        Me.txtCaballo6 = New System.Windows.Forms.TextBox()
        Me.txtNumero6 = New System.Windows.Forms.TextBox()
        Me.radFila7 = New System.Windows.Forms.RadioButton()
        Me.cmbLuz7 = New System.Windows.Forms.ComboBox()
        Me.chbincluido7 = New System.Windows.Forms.CheckBox()
        Me.mtxApuesta7 = New System.Windows.Forms.MaskedTextBox()
        Me.txtApostador7 = New System.Windows.Forms.TextBox()
        Me.txtCaballo7 = New System.Windows.Forms.TextBox()
        Me.txtNumero7 = New System.Windows.Forms.TextBox()
        CType(Me.TbDetalleRematesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCarrerasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_PalcosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_CaballosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_CarrerasCaballosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbRematesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.cmbCarrera.TabStop = False
        Me.cmbCarrera.ValueMember = "Id"
        '
        'TbCarrerasBindingSource
        '
        Me.TbCarrerasBindingSource.DataMember = "tb_Carreras"
        Me.TbCarrerasBindingSource.DataSource = Me.BdSIGAP_DataSet
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
        Me.txtPorcentajeCasa.TabStop = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(411, 334)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.TabStop = False
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
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(497, 334)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(104, 23)
        Me.btnImprimir.TabIndex = 7
        Me.btnImprimir.Text = "Guardar e Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
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
        Me.cmbPalco.TabStop = False
        Me.cmbPalco.ValueMember = "Id"
        '
        'Tb_PalcosBindingSource
        '
        Me.Tb_PalcosBindingSource.DataMember = "tb_Palcos"
        Me.Tb_PalcosBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'Tb_DetalleRematesTableAdapter
        '
        Me.Tb_DetalleRematesTableAdapter.ClearBeforeFill = True
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
        'Tb_JornadasTableAdapter
        '
        Me.Tb_JornadasTableAdapter.ClearBeforeFill = True
        '
        'TbRematesBindingSource
        '
        Me.TbRematesBindingSource.DataMember = "tb_Remates"
        Me.TbRematesBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'Tb_PalcosTableAdapter
        '
        Me.Tb_PalcosTableAdapter.ClearBeforeFill = True
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(6, 354)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 17
        Me.txtId.Visible = False
        '
        'lblNumero
        '
        Me.lblNumero.Location = New System.Drawing.Point(11, 115)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(49, 13)
        Me.lblNumero.TabIndex = 0
        Me.lblNumero.Text = "Número"
        Me.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCaballo
        '
        Me.lblCaballo.AutoSize = True
        Me.lblCaballo.Location = New System.Drawing.Point(133, 115)
        Me.lblCaballo.Name = "lblCaballo"
        Me.lblCaballo.Size = New System.Drawing.Size(42, 13)
        Me.lblCaballo.TabIndex = 19
        Me.lblCaballo.Text = "Caballo"
        Me.lblCaballo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblApostador
        '
        Me.lblApostador.AutoSize = True
        Me.lblApostador.Location = New System.Drawing.Point(264, 115)
        Me.lblApostador.Name = "lblApostador"
        Me.lblApostador.Size = New System.Drawing.Size(55, 13)
        Me.lblApostador.TabIndex = 20
        Me.lblApostador.Text = "Apostador"
        Me.lblApostador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblApuesta
        '
        Me.lblApuesta.AutoSize = True
        Me.lblApuesta.Location = New System.Drawing.Point(356, 115)
        Me.lblApuesta.Name = "lblApuesta"
        Me.lblApuesta.Size = New System.Drawing.Size(46, 13)
        Me.lblApuesta.TabIndex = 21
        Me.lblApuesta.Text = "Apuesta"
        Me.lblApuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIncluido
        '
        Me.lblIncluido.AutoSize = True
        Me.lblIncluido.Location = New System.Drawing.Point(426, 115)
        Me.lblIncluido.Name = "lblIncluido"
        Me.lblIncluido.Size = New System.Drawing.Size(44, 13)
        Me.lblIncluido.TabIndex = 22
        Me.lblIncluido.Text = "Incluido"
        Me.lblIncluido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLuz
        '
        Me.lblLuz.AutoSize = True
        Me.lblLuz.Location = New System.Drawing.Point(501, 115)
        Me.lblLuz.Name = "lblLuz"
        Me.lblLuz.Size = New System.Drawing.Size(24, 13)
        Me.lblLuz.TabIndex = 23
        Me.lblLuz.Text = "Luz"
        Me.lblLuz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFila
        '
        Me.lblFila.AutoSize = True
        Me.lblFila.Location = New System.Drawing.Point(562, 115)
        Me.lblFila.Name = "lblFila"
        Me.lblFila.Size = New System.Drawing.Size(23, 13)
        Me.lblFila.TabIndex = 24
        Me.lblFila.Text = "Fila"
        Me.lblFila.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNumero0
        '
        Me.txtNumero0.Location = New System.Drawing.Point(8, 131)
        Me.txtNumero0.Name = "txtNumero0"
        Me.txtNumero0.Size = New System.Drawing.Size(55, 20)
        Me.txtNumero0.TabIndex = 25
        Me.txtNumero0.Visible = False
        '
        'txtCaballo0
        '
        Me.txtCaballo0.Location = New System.Drawing.Point(69, 131)
        Me.txtCaballo0.Name = "txtCaballo0"
        Me.txtCaballo0.ReadOnly = True
        Me.txtCaballo0.Size = New System.Drawing.Size(170, 20)
        Me.txtCaballo0.TabIndex = 26
        Me.txtCaballo0.Visible = False
        '
        'txtApostador0
        '
        Me.txtApostador0.Location = New System.Drawing.Point(245, 131)
        Me.txtApostador0.Name = "txtApostador0"
        Me.txtApostador0.Size = New System.Drawing.Size(92, 20)
        Me.txtApostador0.TabIndex = 27
        Me.txtApostador0.Visible = False
        '
        'mtxApuesta0
        '
        Me.mtxApuesta0.Location = New System.Drawing.Point(344, 131)
        Me.mtxApuesta0.Mask = "999,999,990"
        Me.mtxApuesta0.Name = "mtxApuesta0"
        Me.mtxApuesta0.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mtxApuesta0.Size = New System.Drawing.Size(71, 20)
        Me.mtxApuesta0.TabIndex = 28
        Me.mtxApuesta0.Visible = False
        '
        'chbincluido0
        '
        Me.chbincluido0.AutoSize = True
        Me.chbincluido0.Location = New System.Drawing.Point(441, 134)
        Me.chbincluido0.Name = "chbincluido0"
        Me.chbincluido0.Size = New System.Drawing.Size(15, 14)
        Me.chbincluido0.TabIndex = 29
        Me.chbincluido0.UseVisualStyleBackColor = True
        Me.chbincluido0.Visible = False
        '
        'cmbLuz0
        '
        Me.cmbLuz0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLuz0.FormattingEnabled = True
        Me.cmbLuz0.Items.AddRange(New Object() {"Da", "Recibe"})
        Me.cmbLuz0.Location = New System.Drawing.Point(473, 131)
        Me.cmbLuz0.Name = "cmbLuz0"
        Me.cmbLuz0.Size = New System.Drawing.Size(81, 21)
        Me.cmbLuz0.TabIndex = 30
        Me.cmbLuz0.Visible = False
        '
        'radFila0
        '
        Me.radFila0.AutoSize = True
        Me.radFila0.Location = New System.Drawing.Point(566, 135)
        Me.radFila0.Name = "radFila0"
        Me.radFila0.Size = New System.Drawing.Size(14, 13)
        Me.radFila0.TabIndex = 31
        Me.radFila0.TabStop = True
        Me.radFila0.UseVisualStyleBackColor = True
        Me.radFila0.Visible = False
        '
        'radFila1
        '
        Me.radFila1.AutoSize = True
        Me.radFila1.Location = New System.Drawing.Point(566, 159)
        Me.radFila1.Name = "radFila1"
        Me.radFila1.Size = New System.Drawing.Size(14, 13)
        Me.radFila1.TabIndex = 38
        Me.radFila1.TabStop = True
        Me.radFila1.UseVisualStyleBackColor = True
        Me.radFila1.Visible = False
        '
        'cmbLuz1
        '
        Me.cmbLuz1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLuz1.FormattingEnabled = True
        Me.cmbLuz1.Items.AddRange(New Object() {"Da", "Recibe"})
        Me.cmbLuz1.Location = New System.Drawing.Point(473, 155)
        Me.cmbLuz1.Name = "cmbLuz1"
        Me.cmbLuz1.Size = New System.Drawing.Size(81, 21)
        Me.cmbLuz1.TabIndex = 37
        Me.cmbLuz1.Visible = False
        '
        'chbincluido1
        '
        Me.chbincluido1.AutoSize = True
        Me.chbincluido1.Location = New System.Drawing.Point(441, 158)
        Me.chbincluido1.Name = "chbincluido1"
        Me.chbincluido1.Size = New System.Drawing.Size(15, 14)
        Me.chbincluido1.TabIndex = 36
        Me.chbincluido1.UseVisualStyleBackColor = True
        Me.chbincluido1.Visible = False
        '
        'mtxApuesta1
        '
        Me.mtxApuesta1.Location = New System.Drawing.Point(344, 155)
        Me.mtxApuesta1.Mask = "999,999,990"
        Me.mtxApuesta1.Name = "mtxApuesta1"
        Me.mtxApuesta1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mtxApuesta1.Size = New System.Drawing.Size(71, 20)
        Me.mtxApuesta1.TabIndex = 35
        Me.mtxApuesta1.Visible = False
        '
        'txtApostador1
        '
        Me.txtApostador1.Location = New System.Drawing.Point(245, 155)
        Me.txtApostador1.Name = "txtApostador1"
        Me.txtApostador1.Size = New System.Drawing.Size(92, 20)
        Me.txtApostador1.TabIndex = 34
        Me.txtApostador1.Visible = False
        '
        'txtCaballo1
        '
        Me.txtCaballo1.Location = New System.Drawing.Point(69, 155)
        Me.txtCaballo1.Name = "txtCaballo1"
        Me.txtCaballo1.ReadOnly = True
        Me.txtCaballo1.Size = New System.Drawing.Size(170, 20)
        Me.txtCaballo1.TabIndex = 33
        Me.txtCaballo1.Visible = False
        '
        'txtNumero1
        '
        Me.txtNumero1.Location = New System.Drawing.Point(8, 155)
        Me.txtNumero1.Name = "txtNumero1"
        Me.txtNumero1.Size = New System.Drawing.Size(55, 20)
        Me.txtNumero1.TabIndex = 32
        Me.txtNumero1.Visible = False
        '
        'radFila2
        '
        Me.radFila2.AutoSize = True
        Me.radFila2.Location = New System.Drawing.Point(566, 183)
        Me.radFila2.Name = "radFila2"
        Me.radFila2.Size = New System.Drawing.Size(14, 13)
        Me.radFila2.TabIndex = 45
        Me.radFila2.TabStop = True
        Me.radFila2.UseVisualStyleBackColor = True
        Me.radFila2.Visible = False
        '
        'cmbLuz2
        '
        Me.cmbLuz2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLuz2.FormattingEnabled = True
        Me.cmbLuz2.Items.AddRange(New Object() {"Da", "Recibe"})
        Me.cmbLuz2.Location = New System.Drawing.Point(473, 179)
        Me.cmbLuz2.Name = "cmbLuz2"
        Me.cmbLuz2.Size = New System.Drawing.Size(81, 21)
        Me.cmbLuz2.TabIndex = 44
        Me.cmbLuz2.Visible = False
        '
        'chbincluido2
        '
        Me.chbincluido2.AutoSize = True
        Me.chbincluido2.Location = New System.Drawing.Point(441, 182)
        Me.chbincluido2.Name = "chbincluido2"
        Me.chbincluido2.Size = New System.Drawing.Size(15, 14)
        Me.chbincluido2.TabIndex = 43
        Me.chbincluido2.UseVisualStyleBackColor = True
        Me.chbincluido2.Visible = False
        '
        'mtxApuesta2
        '
        Me.mtxApuesta2.Location = New System.Drawing.Point(344, 179)
        Me.mtxApuesta2.Mask = "999,999,990"
        Me.mtxApuesta2.Name = "mtxApuesta2"
        Me.mtxApuesta2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mtxApuesta2.Size = New System.Drawing.Size(71, 20)
        Me.mtxApuesta2.TabIndex = 42
        Me.mtxApuesta2.Visible = False
        '
        'txtApostador2
        '
        Me.txtApostador2.Location = New System.Drawing.Point(245, 179)
        Me.txtApostador2.Name = "txtApostador2"
        Me.txtApostador2.Size = New System.Drawing.Size(92, 20)
        Me.txtApostador2.TabIndex = 41
        Me.txtApostador2.Visible = False
        '
        'txtCaballo2
        '
        Me.txtCaballo2.Location = New System.Drawing.Point(69, 179)
        Me.txtCaballo2.Name = "txtCaballo2"
        Me.txtCaballo2.ReadOnly = True
        Me.txtCaballo2.Size = New System.Drawing.Size(170, 20)
        Me.txtCaballo2.TabIndex = 40
        Me.txtCaballo2.Visible = False
        '
        'txtNumero2
        '
        Me.txtNumero2.Location = New System.Drawing.Point(8, 179)
        Me.txtNumero2.Name = "txtNumero2"
        Me.txtNumero2.Size = New System.Drawing.Size(55, 20)
        Me.txtNumero2.TabIndex = 39
        Me.txtNumero2.Visible = False
        '
        'radFila3
        '
        Me.radFila3.AutoSize = True
        Me.radFila3.Location = New System.Drawing.Point(566, 207)
        Me.radFila3.Name = "radFila3"
        Me.radFila3.Size = New System.Drawing.Size(14, 13)
        Me.radFila3.TabIndex = 52
        Me.radFila3.TabStop = True
        Me.radFila3.UseVisualStyleBackColor = True
        Me.radFila3.Visible = False
        '
        'cmbLuz3
        '
        Me.cmbLuz3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLuz3.FormattingEnabled = True
        Me.cmbLuz3.Items.AddRange(New Object() {"Da", "Recibe"})
        Me.cmbLuz3.Location = New System.Drawing.Point(473, 203)
        Me.cmbLuz3.Name = "cmbLuz3"
        Me.cmbLuz3.Size = New System.Drawing.Size(81, 21)
        Me.cmbLuz3.TabIndex = 51
        Me.cmbLuz3.Visible = False
        '
        'chbincluido3
        '
        Me.chbincluido3.AutoSize = True
        Me.chbincluido3.Location = New System.Drawing.Point(441, 206)
        Me.chbincluido3.Name = "chbincluido3"
        Me.chbincluido3.Size = New System.Drawing.Size(15, 14)
        Me.chbincluido3.TabIndex = 50
        Me.chbincluido3.UseVisualStyleBackColor = True
        Me.chbincluido3.Visible = False
        '
        'mtxApuesta3
        '
        Me.mtxApuesta3.Location = New System.Drawing.Point(344, 203)
        Me.mtxApuesta3.Mask = "999,999,990"
        Me.mtxApuesta3.Name = "mtxApuesta3"
        Me.mtxApuesta3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mtxApuesta3.Size = New System.Drawing.Size(71, 20)
        Me.mtxApuesta3.TabIndex = 49
        Me.mtxApuesta3.Visible = False
        '
        'txtApostador3
        '
        Me.txtApostador3.Location = New System.Drawing.Point(245, 203)
        Me.txtApostador3.Name = "txtApostador3"
        Me.txtApostador3.Size = New System.Drawing.Size(92, 20)
        Me.txtApostador3.TabIndex = 48
        Me.txtApostador3.Visible = False
        '
        'txtCaballo3
        '
        Me.txtCaballo3.Location = New System.Drawing.Point(69, 203)
        Me.txtCaballo3.Name = "txtCaballo3"
        Me.txtCaballo3.ReadOnly = True
        Me.txtCaballo3.Size = New System.Drawing.Size(170, 20)
        Me.txtCaballo3.TabIndex = 47
        Me.txtCaballo3.Visible = False
        '
        'txtNumero3
        '
        Me.txtNumero3.Location = New System.Drawing.Point(8, 203)
        Me.txtNumero3.Name = "txtNumero3"
        Me.txtNumero3.Size = New System.Drawing.Size(55, 20)
        Me.txtNumero3.TabIndex = 46
        Me.txtNumero3.Visible = False
        '
        'radFila4
        '
        Me.radFila4.AutoSize = True
        Me.radFila4.Location = New System.Drawing.Point(566, 231)
        Me.radFila4.Name = "radFila4"
        Me.radFila4.Size = New System.Drawing.Size(14, 13)
        Me.radFila4.TabIndex = 59
        Me.radFila4.TabStop = True
        Me.radFila4.UseVisualStyleBackColor = True
        Me.radFila4.Visible = False
        '
        'cmbLuz4
        '
        Me.cmbLuz4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLuz4.FormattingEnabled = True
        Me.cmbLuz4.Items.AddRange(New Object() {"Da", "Recibe"})
        Me.cmbLuz4.Location = New System.Drawing.Point(473, 227)
        Me.cmbLuz4.Name = "cmbLuz4"
        Me.cmbLuz4.Size = New System.Drawing.Size(81, 21)
        Me.cmbLuz4.TabIndex = 58
        Me.cmbLuz4.Visible = False
        '
        'chbincluido4
        '
        Me.chbincluido4.AutoSize = True
        Me.chbincluido4.Location = New System.Drawing.Point(441, 230)
        Me.chbincluido4.Name = "chbincluido4"
        Me.chbincluido4.Size = New System.Drawing.Size(15, 14)
        Me.chbincluido4.TabIndex = 57
        Me.chbincluido4.UseVisualStyleBackColor = True
        Me.chbincluido4.Visible = False
        '
        'mtxApuesta4
        '
        Me.mtxApuesta4.Location = New System.Drawing.Point(344, 227)
        Me.mtxApuesta4.Mask = "999,999,990"
        Me.mtxApuesta4.Name = "mtxApuesta4"
        Me.mtxApuesta4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mtxApuesta4.Size = New System.Drawing.Size(71, 20)
        Me.mtxApuesta4.TabIndex = 56
        Me.mtxApuesta4.Visible = False
        '
        'txtApostador4
        '
        Me.txtApostador4.Location = New System.Drawing.Point(245, 227)
        Me.txtApostador4.Name = "txtApostador4"
        Me.txtApostador4.Size = New System.Drawing.Size(92, 20)
        Me.txtApostador4.TabIndex = 55
        Me.txtApostador4.Visible = False
        '
        'txtCaballo4
        '
        Me.txtCaballo4.Location = New System.Drawing.Point(69, 227)
        Me.txtCaballo4.Name = "txtCaballo4"
        Me.txtCaballo4.ReadOnly = True
        Me.txtCaballo4.Size = New System.Drawing.Size(170, 20)
        Me.txtCaballo4.TabIndex = 54
        Me.txtCaballo4.Visible = False
        '
        'txtNumero4
        '
        Me.txtNumero4.Location = New System.Drawing.Point(8, 227)
        Me.txtNumero4.Name = "txtNumero4"
        Me.txtNumero4.Size = New System.Drawing.Size(55, 20)
        Me.txtNumero4.TabIndex = 53
        Me.txtNumero4.Visible = False
        '
        'radFila5
        '
        Me.radFila5.AutoSize = True
        Me.radFila5.Location = New System.Drawing.Point(566, 255)
        Me.radFila5.Name = "radFila5"
        Me.radFila5.Size = New System.Drawing.Size(14, 13)
        Me.radFila5.TabIndex = 66
        Me.radFila5.TabStop = True
        Me.radFila5.UseVisualStyleBackColor = True
        Me.radFila5.Visible = False
        '
        'cmbLuz5
        '
        Me.cmbLuz5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLuz5.FormattingEnabled = True
        Me.cmbLuz5.Items.AddRange(New Object() {"Da", "Recibe"})
        Me.cmbLuz5.Location = New System.Drawing.Point(473, 251)
        Me.cmbLuz5.Name = "cmbLuz5"
        Me.cmbLuz5.Size = New System.Drawing.Size(81, 21)
        Me.cmbLuz5.TabIndex = 65
        Me.cmbLuz5.Visible = False
        '
        'chbincluido5
        '
        Me.chbincluido5.AutoSize = True
        Me.chbincluido5.Location = New System.Drawing.Point(441, 254)
        Me.chbincluido5.Name = "chbincluido5"
        Me.chbincluido5.Size = New System.Drawing.Size(15, 14)
        Me.chbincluido5.TabIndex = 64
        Me.chbincluido5.UseVisualStyleBackColor = True
        Me.chbincluido5.Visible = False
        '
        'mtxApuesta5
        '
        Me.mtxApuesta5.Location = New System.Drawing.Point(344, 251)
        Me.mtxApuesta5.Mask = "999,999,990"
        Me.mtxApuesta5.Name = "mtxApuesta5"
        Me.mtxApuesta5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mtxApuesta5.Size = New System.Drawing.Size(71, 20)
        Me.mtxApuesta5.TabIndex = 63
        Me.mtxApuesta5.Visible = False
        '
        'txtApostador5
        '
        Me.txtApostador5.Location = New System.Drawing.Point(245, 251)
        Me.txtApostador5.Name = "txtApostador5"
        Me.txtApostador5.Size = New System.Drawing.Size(92, 20)
        Me.txtApostador5.TabIndex = 62
        Me.txtApostador5.Visible = False
        '
        'txtCaballo5
        '
        Me.txtCaballo5.Location = New System.Drawing.Point(69, 251)
        Me.txtCaballo5.Name = "txtCaballo5"
        Me.txtCaballo5.ReadOnly = True
        Me.txtCaballo5.Size = New System.Drawing.Size(170, 20)
        Me.txtCaballo5.TabIndex = 61
        Me.txtCaballo5.Visible = False
        '
        'txtNumero5
        '
        Me.txtNumero5.Location = New System.Drawing.Point(8, 251)
        Me.txtNumero5.Name = "txtNumero5"
        Me.txtNumero5.Size = New System.Drawing.Size(55, 20)
        Me.txtNumero5.TabIndex = 60
        Me.txtNumero5.Visible = False
        '
        'radFila6
        '
        Me.radFila6.AutoSize = True
        Me.radFila6.Location = New System.Drawing.Point(566, 279)
        Me.radFila6.Name = "radFila6"
        Me.radFila6.Size = New System.Drawing.Size(14, 13)
        Me.radFila6.TabIndex = 73
        Me.radFila6.TabStop = True
        Me.radFila6.UseVisualStyleBackColor = True
        Me.radFila6.Visible = False
        '
        'cmbLuz6
        '
        Me.cmbLuz6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLuz6.FormattingEnabled = True
        Me.cmbLuz6.Items.AddRange(New Object() {"Da", "Recibe"})
        Me.cmbLuz6.Location = New System.Drawing.Point(473, 275)
        Me.cmbLuz6.Name = "cmbLuz6"
        Me.cmbLuz6.Size = New System.Drawing.Size(81, 21)
        Me.cmbLuz6.TabIndex = 72
        Me.cmbLuz6.Visible = False
        '
        'chbincluido6
        '
        Me.chbincluido6.AutoSize = True
        Me.chbincluido6.Location = New System.Drawing.Point(441, 278)
        Me.chbincluido6.Name = "chbincluido6"
        Me.chbincluido6.Size = New System.Drawing.Size(15, 14)
        Me.chbincluido6.TabIndex = 71
        Me.chbincluido6.UseVisualStyleBackColor = True
        Me.chbincluido6.Visible = False
        '
        'mtxApuesta6
        '
        Me.mtxApuesta6.Location = New System.Drawing.Point(344, 275)
        Me.mtxApuesta6.Mask = "999,999,990"
        Me.mtxApuesta6.Name = "mtxApuesta6"
        Me.mtxApuesta6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mtxApuesta6.Size = New System.Drawing.Size(71, 20)
        Me.mtxApuesta6.TabIndex = 70
        Me.mtxApuesta6.Visible = False
        '
        'txtApostador6
        '
        Me.txtApostador6.Location = New System.Drawing.Point(245, 275)
        Me.txtApostador6.Name = "txtApostador6"
        Me.txtApostador6.Size = New System.Drawing.Size(92, 20)
        Me.txtApostador6.TabIndex = 69
        Me.txtApostador6.Visible = False
        '
        'txtCaballo6
        '
        Me.txtCaballo6.Location = New System.Drawing.Point(69, 275)
        Me.txtCaballo6.Name = "txtCaballo6"
        Me.txtCaballo6.ReadOnly = True
        Me.txtCaballo6.Size = New System.Drawing.Size(170, 20)
        Me.txtCaballo6.TabIndex = 68
        Me.txtCaballo6.Visible = False
        '
        'txtNumero6
        '
        Me.txtNumero6.Location = New System.Drawing.Point(8, 275)
        Me.txtNumero6.Name = "txtNumero6"
        Me.txtNumero6.Size = New System.Drawing.Size(55, 20)
        Me.txtNumero6.TabIndex = 67
        Me.txtNumero6.Visible = False
        '
        'radFila7
        '
        Me.radFila7.AutoSize = True
        Me.radFila7.Location = New System.Drawing.Point(566, 303)
        Me.radFila7.Name = "radFila7"
        Me.radFila7.Size = New System.Drawing.Size(14, 13)
        Me.radFila7.TabIndex = 80
        Me.radFila7.TabStop = True
        Me.radFila7.UseVisualStyleBackColor = True
        Me.radFila7.Visible = False
        '
        'cmbLuz7
        '
        Me.cmbLuz7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLuz7.FormattingEnabled = True
        Me.cmbLuz7.Items.AddRange(New Object() {"Da", "Recibe"})
        Me.cmbLuz7.Location = New System.Drawing.Point(473, 299)
        Me.cmbLuz7.Name = "cmbLuz7"
        Me.cmbLuz7.Size = New System.Drawing.Size(81, 21)
        Me.cmbLuz7.TabIndex = 79
        Me.cmbLuz7.Visible = False
        '
        'chbincluido7
        '
        Me.chbincluido7.AutoSize = True
        Me.chbincluido7.Location = New System.Drawing.Point(441, 302)
        Me.chbincluido7.Name = "chbincluido7"
        Me.chbincluido7.Size = New System.Drawing.Size(15, 14)
        Me.chbincluido7.TabIndex = 78
        Me.chbincluido7.UseVisualStyleBackColor = True
        Me.chbincluido7.Visible = False
        '
        'mtxApuesta7
        '
        Me.mtxApuesta7.Location = New System.Drawing.Point(344, 299)
        Me.mtxApuesta7.Mask = "999,999,990"
        Me.mtxApuesta7.Name = "mtxApuesta7"
        Me.mtxApuesta7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mtxApuesta7.Size = New System.Drawing.Size(71, 20)
        Me.mtxApuesta7.TabIndex = 77
        Me.mtxApuesta7.Visible = False
        '
        'txtApostador7
        '
        Me.txtApostador7.Location = New System.Drawing.Point(245, 299)
        Me.txtApostador7.Name = "txtApostador7"
        Me.txtApostador7.Size = New System.Drawing.Size(92, 20)
        Me.txtApostador7.TabIndex = 76
        Me.txtApostador7.Visible = False
        '
        'txtCaballo7
        '
        Me.txtCaballo7.Location = New System.Drawing.Point(69, 299)
        Me.txtCaballo7.Name = "txtCaballo7"
        Me.txtCaballo7.ReadOnly = True
        Me.txtCaballo7.Size = New System.Drawing.Size(170, 20)
        Me.txtCaballo7.TabIndex = 75
        Me.txtCaballo7.Visible = False
        '
        'txtNumero7
        '
        Me.txtNumero7.Location = New System.Drawing.Point(8, 299)
        Me.txtNumero7.Name = "txtNumero7"
        Me.txtNumero7.Size = New System.Drawing.Size(55, 20)
        Me.txtNumero7.TabIndex = 74
        Me.txtNumero7.Visible = False
        '
        'frmRemate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 377)
        Me.Controls.Add(Me.radFila7)
        Me.Controls.Add(Me.cmbLuz7)
        Me.Controls.Add(Me.chbincluido7)
        Me.Controls.Add(Me.mtxApuesta7)
        Me.Controls.Add(Me.txtApostador7)
        Me.Controls.Add(Me.txtCaballo7)
        Me.Controls.Add(Me.txtNumero7)
        Me.Controls.Add(Me.radFila6)
        Me.Controls.Add(Me.cmbLuz6)
        Me.Controls.Add(Me.chbincluido6)
        Me.Controls.Add(Me.mtxApuesta6)
        Me.Controls.Add(Me.txtApostador6)
        Me.Controls.Add(Me.txtCaballo6)
        Me.Controls.Add(Me.txtNumero6)
        Me.Controls.Add(Me.radFila5)
        Me.Controls.Add(Me.cmbLuz5)
        Me.Controls.Add(Me.chbincluido5)
        Me.Controls.Add(Me.mtxApuesta5)
        Me.Controls.Add(Me.txtApostador5)
        Me.Controls.Add(Me.txtCaballo5)
        Me.Controls.Add(Me.txtNumero5)
        Me.Controls.Add(Me.radFila4)
        Me.Controls.Add(Me.cmbLuz4)
        Me.Controls.Add(Me.chbincluido4)
        Me.Controls.Add(Me.mtxApuesta4)
        Me.Controls.Add(Me.txtApostador4)
        Me.Controls.Add(Me.txtCaballo4)
        Me.Controls.Add(Me.txtNumero4)
        Me.Controls.Add(Me.radFila3)
        Me.Controls.Add(Me.cmbLuz3)
        Me.Controls.Add(Me.chbincluido3)
        Me.Controls.Add(Me.mtxApuesta3)
        Me.Controls.Add(Me.txtApostador3)
        Me.Controls.Add(Me.txtCaballo3)
        Me.Controls.Add(Me.txtNumero3)
        Me.Controls.Add(Me.radFila2)
        Me.Controls.Add(Me.cmbLuz2)
        Me.Controls.Add(Me.chbincluido2)
        Me.Controls.Add(Me.mtxApuesta2)
        Me.Controls.Add(Me.txtApostador2)
        Me.Controls.Add(Me.txtCaballo2)
        Me.Controls.Add(Me.txtNumero2)
        Me.Controls.Add(Me.radFila1)
        Me.Controls.Add(Me.cmbLuz1)
        Me.Controls.Add(Me.chbincluido1)
        Me.Controls.Add(Me.mtxApuesta1)
        Me.Controls.Add(Me.txtApostador1)
        Me.Controls.Add(Me.txtCaballo1)
        Me.Controls.Add(Me.txtNumero1)
        Me.Controls.Add(Me.radFila0)
        Me.Controls.Add(Me.cmbLuz0)
        Me.Controls.Add(Me.chbincluido0)
        Me.Controls.Add(Me.mtxApuesta0)
        Me.Controls.Add(Me.txtApostador0)
        Me.Controls.Add(Me.txtCaballo0)
        Me.Controls.Add(Me.txtNumero0)
        Me.Controls.Add(Me.lblFila)
        Me.Controls.Add(Me.lblLuz)
        Me.Controls.Add(Me.lblIncluido)
        Me.Controls.Add(Me.lblApuesta)
        Me.Controls.Add(Me.lblApostador)
        Me.Controls.Add(Me.lblCaballo)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.txtId)
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
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmRemate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remate"
        CType(Me.TbDetalleRematesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbCarrerasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_PalcosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_CaballosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_CarrerasCaballosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbRematesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BdSIGAP_DataSet As bdSIGAP_DataSet
    Friend WithEvents lblTitulo As Label
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
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblNumero As Label
    Friend WithEvents lblCaballo As Label
    Friend WithEvents lblApostador As Label
    Friend WithEvents lblApuesta As Label
    Friend WithEvents lblIncluido As Label
    Friend WithEvents lblLuz As Label
    Friend WithEvents lblFila As Label
    Friend WithEvents txtNumero0 As TextBox
    Friend WithEvents txtCaballo0 As TextBox
    Friend WithEvents txtApostador0 As TextBox
    Friend WithEvents mtxApuesta0 As MaskedTextBox
    Friend WithEvents chbincluido0 As CheckBox
    Friend WithEvents cmbLuz0 As ComboBox
    Friend WithEvents radFila0 As RadioButton
    Friend WithEvents radFila1 As RadioButton
    Friend WithEvents cmbLuz1 As ComboBox
    Friend WithEvents chbincluido1 As CheckBox
    Friend WithEvents mtxApuesta1 As MaskedTextBox
    Friend WithEvents txtApostador1 As TextBox
    Friend WithEvents txtCaballo1 As TextBox
    Friend WithEvents txtNumero1 As TextBox
    Friend WithEvents radFila2 As RadioButton
    Friend WithEvents cmbLuz2 As ComboBox
    Friend WithEvents chbincluido2 As CheckBox
    Friend WithEvents mtxApuesta2 As MaskedTextBox
    Friend WithEvents txtApostador2 As TextBox
    Friend WithEvents txtCaballo2 As TextBox
    Friend WithEvents txtNumero2 As TextBox
    Friend WithEvents radFila3 As RadioButton
    Friend WithEvents cmbLuz3 As ComboBox
    Friend WithEvents chbincluido3 As CheckBox
    Friend WithEvents mtxApuesta3 As MaskedTextBox
    Friend WithEvents txtApostador3 As TextBox
    Friend WithEvents txtCaballo3 As TextBox
    Friend WithEvents txtNumero3 As TextBox
    Friend WithEvents radFila4 As RadioButton
    Friend WithEvents cmbLuz4 As ComboBox
    Friend WithEvents chbincluido4 As CheckBox
    Friend WithEvents mtxApuesta4 As MaskedTextBox
    Friend WithEvents txtApostador4 As TextBox
    Friend WithEvents txtCaballo4 As TextBox
    Friend WithEvents txtNumero4 As TextBox
    Friend WithEvents radFila5 As RadioButton
    Friend WithEvents cmbLuz5 As ComboBox
    Friend WithEvents chbincluido5 As CheckBox
    Friend WithEvents mtxApuesta5 As MaskedTextBox
    Friend WithEvents txtApostador5 As TextBox
    Friend WithEvents txtCaballo5 As TextBox
    Friend WithEvents txtNumero5 As TextBox
    Friend WithEvents radFila6 As RadioButton
    Friend WithEvents cmbLuz6 As ComboBox
    Friend WithEvents chbincluido6 As CheckBox
    Friend WithEvents mtxApuesta6 As MaskedTextBox
    Friend WithEvents txtApostador6 As TextBox
    Friend WithEvents txtCaballo6 As TextBox
    Friend WithEvents txtNumero6 As TextBox
    Friend WithEvents radFila7 As RadioButton
    Friend WithEvents cmbLuz7 As ComboBox
    Friend WithEvents chbincluido7 As CheckBox
    Friend WithEvents mtxApuesta7 As MaskedTextBox
    Friend WithEvents txtApostador7 As TextBox
    Friend WithEvents txtCaballo7 As TextBox
    Friend WithEvents txtNumero7 As TextBox
End Class
