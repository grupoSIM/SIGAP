<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCargarLlave
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nCarrera = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txNombre = New System.Windows.Forms.TextBox()
        Me.nProcentajeCasa = New System.Windows.Forms.NumericUpDown()
        Me.cbJornada = New System.Windows.Forms.ComboBox()
        Me.TbJornadasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdSIGAP_DataSet = New SIGAP.bdSIGAP_DataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tb_JornadasTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_JornadasTableAdapter()
        Me.cbCarrera1 = New System.Windows.Forms.ComboBox()
        Me.TbCarrerasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbCarrera2 = New System.Windows.Forms.ComboBox()
        Me.TbCarrerasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tb_CarrerasTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CarrerasTableAdapter()
        Me.txCar1Nro1 = New System.Windows.Forms.TextBox()
        Me.txCar1Cab1 = New System.Windows.Forms.TextBox()
        Me.txCar2Cab1 = New System.Windows.Forms.TextBox()
        Me.txCar2Nro1 = New System.Windows.Forms.TextBox()
        Me.Tb_CarrerasCaballosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_CarrerasCaballosTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CarrerasCaballosTableAdapter()
        Me.TableAdapterManager = New SIGAP.bdSIGAP_DataSetTableAdapters.TableAdapterManager()
        Me.Tb_CaballosTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CaballosTableAdapter()
        Me.txCar1Cab2 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro2 = New System.Windows.Forms.TextBox()
        Me.txCar1Cab3 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro3 = New System.Windows.Forms.TextBox()
        Me.txCar1Cab4 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro4 = New System.Windows.Forms.TextBox()
        Me.txCar1Cab8 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro8 = New System.Windows.Forms.TextBox()
        Me.txCar1Cab7 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro7 = New System.Windows.Forms.TextBox()
        Me.txCar1Cab6 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro6 = New System.Windows.Forms.TextBox()
        Me.txCar1Cab5 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro5 = New System.Windows.Forms.TextBox()
        Me.txCar1Cab16 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro16 = New System.Windows.Forms.TextBox()
        Me.txCar1Cab15 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro15 = New System.Windows.Forms.TextBox()
        Me.txCar1Cab14 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro14 = New System.Windows.Forms.TextBox()
        Me.txCar1Cab13 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro13 = New System.Windows.Forms.TextBox()
        Me.txCar1Cab12 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro12 = New System.Windows.Forms.TextBox()
        Me.txCar1Cab11 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro11 = New System.Windows.Forms.TextBox()
        Me.txCar1Cab10 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro10 = New System.Windows.Forms.TextBox()
        Me.txCar1Cab9 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro9 = New System.Windows.Forms.TextBox()
        Me.txCar1Cab20 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro20 = New System.Windows.Forms.TextBox()
        Me.txCar1Cab19 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro19 = New System.Windows.Forms.TextBox()
        Me.txCar1Cab18 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro18 = New System.Windows.Forms.TextBox()
        Me.txCar1Cab17 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro17 = New System.Windows.Forms.TextBox()
        Me.TbCaballosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txCar2Cab9 = New System.Windows.Forms.TextBox()
        Me.txCar2Nro9 = New System.Windows.Forms.TextBox()
        Me.txCar2Cab8 = New System.Windows.Forms.TextBox()
        Me.txCar2Nro8 = New System.Windows.Forms.TextBox()
        Me.txCar2Cab7 = New System.Windows.Forms.TextBox()
        Me.txCar2Nro7 = New System.Windows.Forms.TextBox()
        Me.txCar2Cab6 = New System.Windows.Forms.TextBox()
        Me.txCar2Nro6 = New System.Windows.Forms.TextBox()
        Me.txCar2Cab5 = New System.Windows.Forms.TextBox()
        Me.txCar2Nro5 = New System.Windows.Forms.TextBox()
        Me.txCar2Cab4 = New System.Windows.Forms.TextBox()
        Me.txCar2Nro4 = New System.Windows.Forms.TextBox()
        Me.txCar2Cab3 = New System.Windows.Forms.TextBox()
        Me.txCar2Nro3 = New System.Windows.Forms.TextBox()
        Me.txCar2Cab2 = New System.Windows.Forms.TextBox()
        Me.txCar2Nro2 = New System.Windows.Forms.TextBox()
        Me.txCar2Cab17 = New System.Windows.Forms.TextBox()
        Me.txCar2Nro17 = New System.Windows.Forms.TextBox()
        Me.txCar2Cab16 = New System.Windows.Forms.TextBox()
        Me.txCar2Nro16 = New System.Windows.Forms.TextBox()
        Me.txCar2Cab15 = New System.Windows.Forms.TextBox()
        Me.txCar2Nro15 = New System.Windows.Forms.TextBox()
        Me.txCar2Cab14 = New System.Windows.Forms.TextBox()
        Me.txCar2Nro14 = New System.Windows.Forms.TextBox()
        Me.txCar2Cab13 = New System.Windows.Forms.TextBox()
        Me.txCar2Nro13 = New System.Windows.Forms.TextBox()
        Me.txCar2Cab12 = New System.Windows.Forms.TextBox()
        Me.txCar2Nro12 = New System.Windows.Forms.TextBox()
        Me.txCar2Cab11 = New System.Windows.Forms.TextBox()
        Me.txCar2Nro11 = New System.Windows.Forms.TextBox()
        Me.txCar2Cab10 = New System.Windows.Forms.TextBox()
        Me.txCar2Nro10 = New System.Windows.Forms.TextBox()
        Me.txCar2Cab20 = New System.Windows.Forms.TextBox()
        Me.txCar2Nro20 = New System.Windows.Forms.TextBox()
        Me.txCar2Cab19 = New System.Windows.Forms.TextBox()
        Me.txCar2Nro19 = New System.Windows.Forms.TextBox()
        Me.txCar2Cab18 = New System.Windows.Forms.TextBox()
        Me.txCar2Nro18 = New System.Windows.Forms.TextBox()
        Me.BindingSourceCarCab = New System.Windows.Forms.BindingSource(Me.components)
        Me.btCreaCarrera = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ColorDialog2 = New System.Windows.Forms.ColorDialog()
        Me.ColorDialog3 = New System.Windows.Forms.ColorDialog()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.Tb_PorcentajesCasaTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_PorcentajesCasaTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nCarrera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nProcentajeCasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbJornadasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCarrerasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCarrerasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_CarrerasCaballosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCaballosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceCarCab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nCarrera)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txNombre)
        Me.GroupBox1.Controls.Add(Me.nProcentajeCasa)
        Me.GroupBox1.Controls.Add(Me.cbJornada)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbTipo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(645, 102)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "General"
        '
        'nCarrera
        '
        Me.nCarrera.Location = New System.Drawing.Point(130, 43)
        Me.nCarrera.Name = "nCarrera"
        Me.nCarrera.Size = New System.Drawing.Size(120, 20)
        Me.nCarrera.TabIndex = 16
        Me.nCarrera.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(284, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nombre:"
        '
        'txNombre
        '
        Me.txNombre.Location = New System.Drawing.Point(337, 43)
        Me.txNombre.Name = "txNombre"
        Me.txNombre.Size = New System.Drawing.Size(250, 20)
        Me.txNombre.TabIndex = 14
        '
        'nProcentajeCasa
        '
        Me.nProcentajeCasa.Location = New System.Drawing.Point(337, 69)
        Me.nProcentajeCasa.Name = "nProcentajeCasa"
        Me.nProcentajeCasa.Size = New System.Drawing.Size(120, 20)
        Me.nProcentajeCasa.TabIndex = 13
        '
        'cbJornada
        '
        Me.cbJornada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbJornada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbJornada.DataSource = Me.TbJornadasBindingSource
        Me.cbJornada.DisplayMember = "Descripcion"
        Me.cbJornada.DropDownWidth = 333
        Me.cbJornada.FormattingEnabled = True
        Me.cbJornada.Location = New System.Drawing.Point(130, 19)
        Me.cbJornada.Name = "cbJornada"
        Me.cbJornada.Size = New System.Drawing.Size(457, 21)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Jornada:"
        '
        'cbTipo
        '
        Me.cbTipo.AutoCompleteCustomSource.AddRange(New String() {"Normal", "Llave"})
        Me.cbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Items.AddRange(New Object() {"Normal", "Llave"})
        Me.cbTipo.Location = New System.Drawing.Point(129, 69)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(121, 21)
        Me.cbTipo.TabIndex = 9
        Me.cbTipo.Text = "Llave"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(93, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tipo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Llave N°:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(286, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "% Casa:"
        '
        'Tb_JornadasTableAdapter
        '
        Me.Tb_JornadasTableAdapter.ClearBeforeFill = True
        '
        'cbCarrera1
        '
        Me.cbCarrera1.DataSource = Me.TbCarrerasBindingSource
        Me.cbCarrera1.DisplayMember = "Nombre"
        Me.cbCarrera1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCarrera1.FormattingEnabled = True
        Me.cbCarrera1.Location = New System.Drawing.Point(86, 111)
        Me.cbCarrera1.Name = "cbCarrera1"
        Me.cbCarrera1.Size = New System.Drawing.Size(244, 21)
        Me.cbCarrera1.TabIndex = 13
        Me.cbCarrera1.ValueMember = "Id"
        '
        'TbCarrerasBindingSource
        '
        Me.TbCarrerasBindingSource.DataMember = "tb_Carreras"
        Me.TbCarrerasBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'cbCarrera2
        '
        Me.cbCarrera2.DataSource = Me.TbCarrerasBindingSource1
        Me.cbCarrera2.DisplayMember = "Nombre"
        Me.cbCarrera2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCarrera2.FormattingEnabled = True
        Me.cbCarrera2.Location = New System.Drawing.Point(413, 111)
        Me.cbCarrera2.Name = "cbCarrera2"
        Me.cbCarrera2.Size = New System.Drawing.Size(244, 21)
        Me.cbCarrera2.TabIndex = 14
        Me.cbCarrera2.ValueMember = "Id"
        '
        'TbCarrerasBindingSource1
        '
        Me.TbCarrerasBindingSource1.DataMember = "tb_Carreras"
        Me.TbCarrerasBindingSource1.DataSource = Me.BdSIGAP_DataSet
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Carrera N° 1:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(344, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Carrera N° 2:"
        '
        'Tb_CarrerasTableAdapter
        '
        Me.Tb_CarrerasTableAdapter.ClearBeforeFill = True
        '
        'txCar1Nro1
        '
        Me.txCar1Nro1.Location = New System.Drawing.Point(18, 150)
        Me.txCar1Nro1.Name = "txCar1Nro1"
        Me.txCar1Nro1.Size = New System.Drawing.Size(50, 20)
        Me.txCar1Nro1.TabIndex = 19
        Me.txCar1Nro1.Visible = False
        '
        'txCar1Cab1
        '
        Me.txCar1Cab1.Location = New System.Drawing.Point(74, 150)
        Me.txCar1Cab1.Name = "txCar1Cab1"
        Me.txCar1Cab1.ReadOnly = True
        Me.txCar1Cab1.Size = New System.Drawing.Size(199, 20)
        Me.txCar1Cab1.TabIndex = 20
        Me.txCar1Cab1.Visible = False
        '
        'txCar2Cab1
        '
        Me.txCar2Cab1.Location = New System.Drawing.Point(335, 150)
        Me.txCar2Cab1.Name = "txCar2Cab1"
        Me.txCar2Cab1.ReadOnly = True
        Me.txCar2Cab1.Size = New System.Drawing.Size(199, 20)
        Me.txCar2Cab1.TabIndex = 22
        Me.txCar2Cab1.Visible = False
        '
        'txCar2Nro1
        '
        Me.txCar2Nro1.Location = New System.Drawing.Point(280, 150)
        Me.txCar2Nro1.Name = "txCar2Nro1"
        Me.txCar2Nro1.Size = New System.Drawing.Size(50, 20)
        Me.txCar2Nro1.TabIndex = 21
        Me.txCar2Nro1.Visible = False
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
        Me.TableAdapterManager.tb_CaballosTableAdapter = Me.Tb_CaballosTableAdapter
        Me.TableAdapterManager.tb_CarrerasCaballosTableAdapter = Me.Tb_CarrerasCaballosTableAdapter
        Me.TableAdapterManager.tb_CarrerasTableAdapter = Me.Tb_CarrerasTableAdapter
        Me.TableAdapterManager.tb_DetalleRematesTableAdapter = Nothing
        Me.TableAdapterManager.tb_EventosTableAdapter = Nothing
        Me.TableAdapterManager.tb_HipodromosTableAdapter = Nothing
        Me.TableAdapterManager.tb_JornadasTableAdapter = Me.Tb_JornadasTableAdapter
        Me.TableAdapterManager.tb_PalcosTableAdapter = Nothing
        Me.TableAdapterManager.tb_PorcentajesCasaTableAdapter = Nothing
        Me.TableAdapterManager.tb_RematadoresTableAdapter = Nothing
        Me.TableAdapterManager.tb_RematesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SIGAP.bdSIGAP_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tb_CaballosTableAdapter
        '
        Me.Tb_CaballosTableAdapter.ClearBeforeFill = True
        '
        'txCar1Cab2
        '
        Me.txCar1Cab2.Location = New System.Drawing.Point(74, 175)
        Me.txCar1Cab2.Name = "txCar1Cab2"
        Me.txCar1Cab2.ReadOnly = True
        Me.txCar1Cab2.Size = New System.Drawing.Size(199, 20)
        Me.txCar1Cab2.TabIndex = 24
        Me.txCar1Cab2.Visible = False
        '
        'txCar1Nro2
        '
        Me.txCar1Nro2.Location = New System.Drawing.Point(19, 175)
        Me.txCar1Nro2.Name = "txCar1Nro2"
        Me.txCar1Nro2.Size = New System.Drawing.Size(50, 20)
        Me.txCar1Nro2.TabIndex = 23
        Me.txCar1Nro2.Visible = False
        '
        'txCar1Cab3
        '
        Me.txCar1Cab3.Location = New System.Drawing.Point(74, 200)
        Me.txCar1Cab3.Name = "txCar1Cab3"
        Me.txCar1Cab3.ReadOnly = True
        Me.txCar1Cab3.Size = New System.Drawing.Size(199, 20)
        Me.txCar1Cab3.TabIndex = 26
        Me.txCar1Cab3.Visible = False
        '
        'txCar1Nro3
        '
        Me.txCar1Nro3.Location = New System.Drawing.Point(19, 200)
        Me.txCar1Nro3.Name = "txCar1Nro3"
        Me.txCar1Nro3.Size = New System.Drawing.Size(50, 20)
        Me.txCar1Nro3.TabIndex = 25
        Me.txCar1Nro3.Visible = False
        '
        'txCar1Cab4
        '
        Me.txCar1Cab4.Location = New System.Drawing.Point(74, 225)
        Me.txCar1Cab4.Name = "txCar1Cab4"
        Me.txCar1Cab4.ReadOnly = True
        Me.txCar1Cab4.Size = New System.Drawing.Size(199, 20)
        Me.txCar1Cab4.TabIndex = 28
        Me.txCar1Cab4.Visible = False
        '
        'txCar1Nro4
        '
        Me.txCar1Nro4.Location = New System.Drawing.Point(19, 225)
        Me.txCar1Nro4.Name = "txCar1Nro4"
        Me.txCar1Nro4.Size = New System.Drawing.Size(50, 20)
        Me.txCar1Nro4.TabIndex = 27
        Me.txCar1Nro4.Visible = False
        '
        'txCar1Cab8
        '
        Me.txCar1Cab8.Location = New System.Drawing.Point(74, 325)
        Me.txCar1Cab8.Name = "txCar1Cab8"
        Me.txCar1Cab8.ReadOnly = True
        Me.txCar1Cab8.Size = New System.Drawing.Size(199, 20)
        Me.txCar1Cab8.TabIndex = 36
        Me.txCar1Cab8.Visible = False
        '
        'txCar1Nro8
        '
        Me.txCar1Nro8.Location = New System.Drawing.Point(19, 325)
        Me.txCar1Nro8.Name = "txCar1Nro8"
        Me.txCar1Nro8.Size = New System.Drawing.Size(50, 20)
        Me.txCar1Nro8.TabIndex = 35
        Me.txCar1Nro8.Visible = False
        '
        'txCar1Cab7
        '
        Me.txCar1Cab7.Location = New System.Drawing.Point(74, 300)
        Me.txCar1Cab7.Name = "txCar1Cab7"
        Me.txCar1Cab7.ReadOnly = True
        Me.txCar1Cab7.Size = New System.Drawing.Size(199, 20)
        Me.txCar1Cab7.TabIndex = 34
        Me.txCar1Cab7.Visible = False
        '
        'txCar1Nro7
        '
        Me.txCar1Nro7.Location = New System.Drawing.Point(19, 300)
        Me.txCar1Nro7.Name = "txCar1Nro7"
        Me.txCar1Nro7.Size = New System.Drawing.Size(50, 20)
        Me.txCar1Nro7.TabIndex = 33
        Me.txCar1Nro7.Visible = False
        '
        'txCar1Cab6
        '
        Me.txCar1Cab6.Location = New System.Drawing.Point(74, 275)
        Me.txCar1Cab6.Name = "txCar1Cab6"
        Me.txCar1Cab6.ReadOnly = True
        Me.txCar1Cab6.Size = New System.Drawing.Size(199, 20)
        Me.txCar1Cab6.TabIndex = 32
        Me.txCar1Cab6.Visible = False
        '
        'txCar1Nro6
        '
        Me.txCar1Nro6.Location = New System.Drawing.Point(19, 275)
        Me.txCar1Nro6.Name = "txCar1Nro6"
        Me.txCar1Nro6.Size = New System.Drawing.Size(50, 20)
        Me.txCar1Nro6.TabIndex = 31
        Me.txCar1Nro6.Visible = False
        '
        'txCar1Cab5
        '
        Me.txCar1Cab5.Location = New System.Drawing.Point(74, 250)
        Me.txCar1Cab5.Name = "txCar1Cab5"
        Me.txCar1Cab5.ReadOnly = True
        Me.txCar1Cab5.Size = New System.Drawing.Size(199, 20)
        Me.txCar1Cab5.TabIndex = 30
        Me.txCar1Cab5.Visible = False
        '
        'txCar1Nro5
        '
        Me.txCar1Nro5.Location = New System.Drawing.Point(19, 250)
        Me.txCar1Nro5.Name = "txCar1Nro5"
        Me.txCar1Nro5.Size = New System.Drawing.Size(50, 20)
        Me.txCar1Nro5.TabIndex = 29
        Me.txCar1Nro5.Visible = False
        '
        'txCar1Cab16
        '
        Me.txCar1Cab16.Location = New System.Drawing.Point(74, 525)
        Me.txCar1Cab16.Name = "txCar1Cab16"
        Me.txCar1Cab16.ReadOnly = True
        Me.txCar1Cab16.Size = New System.Drawing.Size(199, 20)
        Me.txCar1Cab16.TabIndex = 52
        Me.txCar1Cab16.Visible = False
        '
        'txCar1Nro16
        '
        Me.txCar1Nro16.Location = New System.Drawing.Point(19, 525)
        Me.txCar1Nro16.Name = "txCar1Nro16"
        Me.txCar1Nro16.Size = New System.Drawing.Size(50, 20)
        Me.txCar1Nro16.TabIndex = 51
        Me.txCar1Nro16.Visible = False
        '
        'txCar1Cab15
        '
        Me.txCar1Cab15.Location = New System.Drawing.Point(74, 500)
        Me.txCar1Cab15.Name = "txCar1Cab15"
        Me.txCar1Cab15.ReadOnly = True
        Me.txCar1Cab15.Size = New System.Drawing.Size(199, 20)
        Me.txCar1Cab15.TabIndex = 50
        Me.txCar1Cab15.Visible = False
        '
        'txCar1Nro15
        '
        Me.txCar1Nro15.Location = New System.Drawing.Point(19, 500)
        Me.txCar1Nro15.Name = "txCar1Nro15"
        Me.txCar1Nro15.Size = New System.Drawing.Size(50, 20)
        Me.txCar1Nro15.TabIndex = 49
        Me.txCar1Nro15.Visible = False
        '
        'txCar1Cab14
        '
        Me.txCar1Cab14.Location = New System.Drawing.Point(74, 475)
        Me.txCar1Cab14.Name = "txCar1Cab14"
        Me.txCar1Cab14.ReadOnly = True
        Me.txCar1Cab14.Size = New System.Drawing.Size(199, 20)
        Me.txCar1Cab14.TabIndex = 48
        Me.txCar1Cab14.Visible = False
        '
        'txCar1Nro14
        '
        Me.txCar1Nro14.Location = New System.Drawing.Point(19, 475)
        Me.txCar1Nro14.Name = "txCar1Nro14"
        Me.txCar1Nro14.Size = New System.Drawing.Size(50, 20)
        Me.txCar1Nro14.TabIndex = 47
        Me.txCar1Nro14.Visible = False
        '
        'txCar1Cab13
        '
        Me.txCar1Cab13.Location = New System.Drawing.Point(74, 450)
        Me.txCar1Cab13.Name = "txCar1Cab13"
        Me.txCar1Cab13.ReadOnly = True
        Me.txCar1Cab13.Size = New System.Drawing.Size(199, 20)
        Me.txCar1Cab13.TabIndex = 46
        Me.txCar1Cab13.Visible = False
        '
        'txCar1Nro13
        '
        Me.txCar1Nro13.Location = New System.Drawing.Point(19, 450)
        Me.txCar1Nro13.Name = "txCar1Nro13"
        Me.txCar1Nro13.Size = New System.Drawing.Size(50, 20)
        Me.txCar1Nro13.TabIndex = 45
        Me.txCar1Nro13.Visible = False
        '
        'txCar1Cab12
        '
        Me.txCar1Cab12.Location = New System.Drawing.Point(74, 425)
        Me.txCar1Cab12.Name = "txCar1Cab12"
        Me.txCar1Cab12.ReadOnly = True
        Me.txCar1Cab12.Size = New System.Drawing.Size(199, 20)
        Me.txCar1Cab12.TabIndex = 44
        Me.txCar1Cab12.Visible = False
        '
        'txCar1Nro12
        '
        Me.txCar1Nro12.Location = New System.Drawing.Point(19, 425)
        Me.txCar1Nro12.Name = "txCar1Nro12"
        Me.txCar1Nro12.Size = New System.Drawing.Size(50, 20)
        Me.txCar1Nro12.TabIndex = 43
        Me.txCar1Nro12.Visible = False
        '
        'txCar1Cab11
        '
        Me.txCar1Cab11.Location = New System.Drawing.Point(74, 400)
        Me.txCar1Cab11.Name = "txCar1Cab11"
        Me.txCar1Cab11.ReadOnly = True
        Me.txCar1Cab11.Size = New System.Drawing.Size(199, 20)
        Me.txCar1Cab11.TabIndex = 42
        Me.txCar1Cab11.Visible = False
        '
        'txCar1Nro11
        '
        Me.txCar1Nro11.Location = New System.Drawing.Point(19, 400)
        Me.txCar1Nro11.Name = "txCar1Nro11"
        Me.txCar1Nro11.Size = New System.Drawing.Size(50, 20)
        Me.txCar1Nro11.TabIndex = 41
        Me.txCar1Nro11.Visible = False
        '
        'txCar1Cab10
        '
        Me.txCar1Cab10.Location = New System.Drawing.Point(74, 375)
        Me.txCar1Cab10.Name = "txCar1Cab10"
        Me.txCar1Cab10.ReadOnly = True
        Me.txCar1Cab10.Size = New System.Drawing.Size(199, 20)
        Me.txCar1Cab10.TabIndex = 40
        Me.txCar1Cab10.Visible = False
        '
        'txCar1Nro10
        '
        Me.txCar1Nro10.Location = New System.Drawing.Point(19, 375)
        Me.txCar1Nro10.Name = "txCar1Nro10"
        Me.txCar1Nro10.Size = New System.Drawing.Size(50, 20)
        Me.txCar1Nro10.TabIndex = 39
        Me.txCar1Nro10.Visible = False
        '
        'txCar1Cab9
        '
        Me.txCar1Cab9.Location = New System.Drawing.Point(74, 350)
        Me.txCar1Cab9.Name = "txCar1Cab9"
        Me.txCar1Cab9.ReadOnly = True
        Me.txCar1Cab9.Size = New System.Drawing.Size(199, 20)
        Me.txCar1Cab9.TabIndex = 38
        Me.txCar1Cab9.Visible = False
        '
        'txCar1Nro9
        '
        Me.txCar1Nro9.Location = New System.Drawing.Point(19, 350)
        Me.txCar1Nro9.Name = "txCar1Nro9"
        Me.txCar1Nro9.Size = New System.Drawing.Size(50, 20)
        Me.txCar1Nro9.TabIndex = 37
        Me.txCar1Nro9.Visible = False
        '
        'txCar1Cab20
        '
        Me.txCar1Cab20.Location = New System.Drawing.Point(74, 625)
        Me.txCar1Cab20.Name = "txCar1Cab20"
        Me.txCar1Cab20.ReadOnly = True
        Me.txCar1Cab20.Size = New System.Drawing.Size(199, 20)
        Me.txCar1Cab20.TabIndex = 60
        Me.txCar1Cab20.Visible = False
        '
        'txCar1Nro20
        '
        Me.txCar1Nro20.Location = New System.Drawing.Point(19, 625)
        Me.txCar1Nro20.Name = "txCar1Nro20"
        Me.txCar1Nro20.Size = New System.Drawing.Size(50, 20)
        Me.txCar1Nro20.TabIndex = 59
        Me.txCar1Nro20.Visible = False
        '
        'txCar1Cab19
        '
        Me.txCar1Cab19.Location = New System.Drawing.Point(74, 600)
        Me.txCar1Cab19.Name = "txCar1Cab19"
        Me.txCar1Cab19.ReadOnly = True
        Me.txCar1Cab19.Size = New System.Drawing.Size(199, 20)
        Me.txCar1Cab19.TabIndex = 58
        Me.txCar1Cab19.Visible = False
        '
        'txCar1Nro19
        '
        Me.txCar1Nro19.Location = New System.Drawing.Point(19, 600)
        Me.txCar1Nro19.Name = "txCar1Nro19"
        Me.txCar1Nro19.Size = New System.Drawing.Size(50, 20)
        Me.txCar1Nro19.TabIndex = 57
        Me.txCar1Nro19.Visible = False
        '
        'txCar1Cab18
        '
        Me.txCar1Cab18.Location = New System.Drawing.Point(74, 575)
        Me.txCar1Cab18.Name = "txCar1Cab18"
        Me.txCar1Cab18.ReadOnly = True
        Me.txCar1Cab18.Size = New System.Drawing.Size(199, 20)
        Me.txCar1Cab18.TabIndex = 56
        Me.txCar1Cab18.Visible = False
        '
        'txCar1Nro18
        '
        Me.txCar1Nro18.Location = New System.Drawing.Point(19, 575)
        Me.txCar1Nro18.Name = "txCar1Nro18"
        Me.txCar1Nro18.Size = New System.Drawing.Size(50, 20)
        Me.txCar1Nro18.TabIndex = 55
        Me.txCar1Nro18.Visible = False
        '
        'txCar1Cab17
        '
        Me.txCar1Cab17.Location = New System.Drawing.Point(74, 550)
        Me.txCar1Cab17.Name = "txCar1Cab17"
        Me.txCar1Cab17.ReadOnly = True
        Me.txCar1Cab17.Size = New System.Drawing.Size(199, 20)
        Me.txCar1Cab17.TabIndex = 54
        Me.txCar1Cab17.Visible = False
        '
        'txCar1Nro17
        '
        Me.txCar1Nro17.Location = New System.Drawing.Point(19, 550)
        Me.txCar1Nro17.Name = "txCar1Nro17"
        Me.txCar1Nro17.Size = New System.Drawing.Size(50, 20)
        Me.txCar1Nro17.TabIndex = 53
        Me.txCar1Nro17.Visible = False
        '
        'TbCaballosBindingSource
        '
        Me.TbCaballosBindingSource.DataMember = "tb_Caballos"
        Me.TbCaballosBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'txCar2Cab9
        '
        Me.txCar2Cab9.Location = New System.Drawing.Point(335, 350)
        Me.txCar2Cab9.Name = "txCar2Cab9"
        Me.txCar2Cab9.ReadOnly = True
        Me.txCar2Cab9.Size = New System.Drawing.Size(199, 20)
        Me.txCar2Cab9.TabIndex = 76
        Me.txCar2Cab9.Visible = False
        '
        'txCar2Nro9
        '
        Me.txCar2Nro9.Location = New System.Drawing.Point(280, 350)
        Me.txCar2Nro9.Name = "txCar2Nro9"
        Me.txCar2Nro9.Size = New System.Drawing.Size(50, 20)
        Me.txCar2Nro9.TabIndex = 75
        Me.txCar2Nro9.Visible = False
        '
        'txCar2Cab8
        '
        Me.txCar2Cab8.Location = New System.Drawing.Point(335, 325)
        Me.txCar2Cab8.Name = "txCar2Cab8"
        Me.txCar2Cab8.ReadOnly = True
        Me.txCar2Cab8.Size = New System.Drawing.Size(199, 20)
        Me.txCar2Cab8.TabIndex = 74
        Me.txCar2Cab8.Visible = False
        '
        'txCar2Nro8
        '
        Me.txCar2Nro8.Location = New System.Drawing.Point(280, 325)
        Me.txCar2Nro8.Name = "txCar2Nro8"
        Me.txCar2Nro8.Size = New System.Drawing.Size(50, 20)
        Me.txCar2Nro8.TabIndex = 73
        Me.txCar2Nro8.Visible = False
        '
        'txCar2Cab7
        '
        Me.txCar2Cab7.Location = New System.Drawing.Point(335, 300)
        Me.txCar2Cab7.Name = "txCar2Cab7"
        Me.txCar2Cab7.ReadOnly = True
        Me.txCar2Cab7.Size = New System.Drawing.Size(199, 20)
        Me.txCar2Cab7.TabIndex = 72
        Me.txCar2Cab7.Visible = False
        '
        'txCar2Nro7
        '
        Me.txCar2Nro7.Location = New System.Drawing.Point(280, 300)
        Me.txCar2Nro7.Name = "txCar2Nro7"
        Me.txCar2Nro7.Size = New System.Drawing.Size(50, 20)
        Me.txCar2Nro7.TabIndex = 71
        Me.txCar2Nro7.Visible = False
        '
        'txCar2Cab6
        '
        Me.txCar2Cab6.Location = New System.Drawing.Point(335, 275)
        Me.txCar2Cab6.Name = "txCar2Cab6"
        Me.txCar2Cab6.ReadOnly = True
        Me.txCar2Cab6.Size = New System.Drawing.Size(199, 20)
        Me.txCar2Cab6.TabIndex = 70
        Me.txCar2Cab6.Visible = False
        '
        'txCar2Nro6
        '
        Me.txCar2Nro6.Location = New System.Drawing.Point(280, 275)
        Me.txCar2Nro6.Name = "txCar2Nro6"
        Me.txCar2Nro6.Size = New System.Drawing.Size(50, 20)
        Me.txCar2Nro6.TabIndex = 69
        Me.txCar2Nro6.Visible = False
        '
        'txCar2Cab5
        '
        Me.txCar2Cab5.Location = New System.Drawing.Point(335, 250)
        Me.txCar2Cab5.Name = "txCar2Cab5"
        Me.txCar2Cab5.ReadOnly = True
        Me.txCar2Cab5.Size = New System.Drawing.Size(199, 20)
        Me.txCar2Cab5.TabIndex = 68
        Me.txCar2Cab5.Visible = False
        '
        'txCar2Nro5
        '
        Me.txCar2Nro5.Location = New System.Drawing.Point(280, 250)
        Me.txCar2Nro5.Name = "txCar2Nro5"
        Me.txCar2Nro5.Size = New System.Drawing.Size(50, 20)
        Me.txCar2Nro5.TabIndex = 67
        Me.txCar2Nro5.Visible = False
        '
        'txCar2Cab4
        '
        Me.txCar2Cab4.Location = New System.Drawing.Point(335, 225)
        Me.txCar2Cab4.Name = "txCar2Cab4"
        Me.txCar2Cab4.ReadOnly = True
        Me.txCar2Cab4.Size = New System.Drawing.Size(199, 20)
        Me.txCar2Cab4.TabIndex = 66
        Me.txCar2Cab4.Visible = False
        '
        'txCar2Nro4
        '
        Me.txCar2Nro4.Location = New System.Drawing.Point(280, 225)
        Me.txCar2Nro4.Name = "txCar2Nro4"
        Me.txCar2Nro4.Size = New System.Drawing.Size(50, 20)
        Me.txCar2Nro4.TabIndex = 65
        Me.txCar2Nro4.Visible = False
        '
        'txCar2Cab3
        '
        Me.txCar2Cab3.Location = New System.Drawing.Point(335, 200)
        Me.txCar2Cab3.Name = "txCar2Cab3"
        Me.txCar2Cab3.ReadOnly = True
        Me.txCar2Cab3.Size = New System.Drawing.Size(199, 20)
        Me.txCar2Cab3.TabIndex = 64
        Me.txCar2Cab3.Visible = False
        '
        'txCar2Nro3
        '
        Me.txCar2Nro3.Location = New System.Drawing.Point(280, 200)
        Me.txCar2Nro3.Name = "txCar2Nro3"
        Me.txCar2Nro3.Size = New System.Drawing.Size(50, 20)
        Me.txCar2Nro3.TabIndex = 63
        Me.txCar2Nro3.Visible = False
        '
        'txCar2Cab2
        '
        Me.txCar2Cab2.Location = New System.Drawing.Point(335, 175)
        Me.txCar2Cab2.Name = "txCar2Cab2"
        Me.txCar2Cab2.ReadOnly = True
        Me.txCar2Cab2.Size = New System.Drawing.Size(199, 20)
        Me.txCar2Cab2.TabIndex = 62
        Me.txCar2Cab2.Visible = False
        '
        'txCar2Nro2
        '
        Me.txCar2Nro2.Location = New System.Drawing.Point(280, 175)
        Me.txCar2Nro2.Name = "txCar2Nro2"
        Me.txCar2Nro2.Size = New System.Drawing.Size(50, 20)
        Me.txCar2Nro2.TabIndex = 61
        Me.txCar2Nro2.Visible = False
        '
        'txCar2Cab17
        '
        Me.txCar2Cab17.Location = New System.Drawing.Point(335, 550)
        Me.txCar2Cab17.Name = "txCar2Cab17"
        Me.txCar2Cab17.ReadOnly = True
        Me.txCar2Cab17.Size = New System.Drawing.Size(199, 20)
        Me.txCar2Cab17.TabIndex = 92
        Me.txCar2Cab17.Visible = False
        '
        'txCar2Nro17
        '
        Me.txCar2Nro17.Location = New System.Drawing.Point(280, 550)
        Me.txCar2Nro17.Name = "txCar2Nro17"
        Me.txCar2Nro17.Size = New System.Drawing.Size(50, 20)
        Me.txCar2Nro17.TabIndex = 91
        Me.txCar2Nro17.Visible = False
        '
        'txCar2Cab16
        '
        Me.txCar2Cab16.Location = New System.Drawing.Point(335, 525)
        Me.txCar2Cab16.Name = "txCar2Cab16"
        Me.txCar2Cab16.ReadOnly = True
        Me.txCar2Cab16.Size = New System.Drawing.Size(199, 20)
        Me.txCar2Cab16.TabIndex = 90
        Me.txCar2Cab16.Visible = False
        '
        'txCar2Nro16
        '
        Me.txCar2Nro16.Location = New System.Drawing.Point(280, 525)
        Me.txCar2Nro16.Name = "txCar2Nro16"
        Me.txCar2Nro16.Size = New System.Drawing.Size(50, 20)
        Me.txCar2Nro16.TabIndex = 89
        Me.txCar2Nro16.Visible = False
        '
        'txCar2Cab15
        '
        Me.txCar2Cab15.Location = New System.Drawing.Point(335, 500)
        Me.txCar2Cab15.Name = "txCar2Cab15"
        Me.txCar2Cab15.ReadOnly = True
        Me.txCar2Cab15.Size = New System.Drawing.Size(199, 20)
        Me.txCar2Cab15.TabIndex = 88
        Me.txCar2Cab15.Visible = False
        '
        'txCar2Nro15
        '
        Me.txCar2Nro15.Location = New System.Drawing.Point(280, 500)
        Me.txCar2Nro15.Name = "txCar2Nro15"
        Me.txCar2Nro15.Size = New System.Drawing.Size(50, 20)
        Me.txCar2Nro15.TabIndex = 87
        Me.txCar2Nro15.Visible = False
        '
        'txCar2Cab14
        '
        Me.txCar2Cab14.Location = New System.Drawing.Point(335, 475)
        Me.txCar2Cab14.Name = "txCar2Cab14"
        Me.txCar2Cab14.ReadOnly = True
        Me.txCar2Cab14.Size = New System.Drawing.Size(199, 20)
        Me.txCar2Cab14.TabIndex = 86
        Me.txCar2Cab14.Visible = False
        '
        'txCar2Nro14
        '
        Me.txCar2Nro14.Location = New System.Drawing.Point(280, 475)
        Me.txCar2Nro14.Name = "txCar2Nro14"
        Me.txCar2Nro14.Size = New System.Drawing.Size(50, 20)
        Me.txCar2Nro14.TabIndex = 85
        Me.txCar2Nro14.Visible = False
        '
        'txCar2Cab13
        '
        Me.txCar2Cab13.Location = New System.Drawing.Point(335, 450)
        Me.txCar2Cab13.Name = "txCar2Cab13"
        Me.txCar2Cab13.ReadOnly = True
        Me.txCar2Cab13.Size = New System.Drawing.Size(199, 20)
        Me.txCar2Cab13.TabIndex = 84
        Me.txCar2Cab13.Visible = False
        '
        'txCar2Nro13
        '
        Me.txCar2Nro13.Location = New System.Drawing.Point(280, 450)
        Me.txCar2Nro13.Name = "txCar2Nro13"
        Me.txCar2Nro13.Size = New System.Drawing.Size(50, 20)
        Me.txCar2Nro13.TabIndex = 83
        Me.txCar2Nro13.Visible = False
        '
        'txCar2Cab12
        '
        Me.txCar2Cab12.Location = New System.Drawing.Point(335, 425)
        Me.txCar2Cab12.Name = "txCar2Cab12"
        Me.txCar2Cab12.ReadOnly = True
        Me.txCar2Cab12.Size = New System.Drawing.Size(199, 20)
        Me.txCar2Cab12.TabIndex = 82
        Me.txCar2Cab12.Visible = False
        '
        'txCar2Nro12
        '
        Me.txCar2Nro12.Location = New System.Drawing.Point(280, 425)
        Me.txCar2Nro12.Name = "txCar2Nro12"
        Me.txCar2Nro12.Size = New System.Drawing.Size(50, 20)
        Me.txCar2Nro12.TabIndex = 81
        Me.txCar2Nro12.Visible = False
        '
        'txCar2Cab11
        '
        Me.txCar2Cab11.Location = New System.Drawing.Point(335, 400)
        Me.txCar2Cab11.Name = "txCar2Cab11"
        Me.txCar2Cab11.ReadOnly = True
        Me.txCar2Cab11.Size = New System.Drawing.Size(199, 20)
        Me.txCar2Cab11.TabIndex = 80
        Me.txCar2Cab11.Visible = False
        '
        'txCar2Nro11
        '
        Me.txCar2Nro11.Location = New System.Drawing.Point(280, 400)
        Me.txCar2Nro11.Name = "txCar2Nro11"
        Me.txCar2Nro11.Size = New System.Drawing.Size(50, 20)
        Me.txCar2Nro11.TabIndex = 79
        Me.txCar2Nro11.Visible = False
        '
        'txCar2Cab10
        '
        Me.txCar2Cab10.Location = New System.Drawing.Point(335, 375)
        Me.txCar2Cab10.Name = "txCar2Cab10"
        Me.txCar2Cab10.ReadOnly = True
        Me.txCar2Cab10.Size = New System.Drawing.Size(199, 20)
        Me.txCar2Cab10.TabIndex = 78
        Me.txCar2Cab10.Visible = False
        '
        'txCar2Nro10
        '
        Me.txCar2Nro10.Location = New System.Drawing.Point(280, 375)
        Me.txCar2Nro10.Name = "txCar2Nro10"
        Me.txCar2Nro10.Size = New System.Drawing.Size(50, 20)
        Me.txCar2Nro10.TabIndex = 77
        Me.txCar2Nro10.Visible = False
        '
        'txCar2Cab20
        '
        Me.txCar2Cab20.Location = New System.Drawing.Point(335, 625)
        Me.txCar2Cab20.Name = "txCar2Cab20"
        Me.txCar2Cab20.ReadOnly = True
        Me.txCar2Cab20.Size = New System.Drawing.Size(199, 20)
        Me.txCar2Cab20.TabIndex = 98
        Me.txCar2Cab20.Visible = False
        '
        'txCar2Nro20
        '
        Me.txCar2Nro20.Location = New System.Drawing.Point(280, 625)
        Me.txCar2Nro20.Name = "txCar2Nro20"
        Me.txCar2Nro20.Size = New System.Drawing.Size(50, 20)
        Me.txCar2Nro20.TabIndex = 97
        Me.txCar2Nro20.Visible = False
        '
        'txCar2Cab19
        '
        Me.txCar2Cab19.Location = New System.Drawing.Point(335, 600)
        Me.txCar2Cab19.Name = "txCar2Cab19"
        Me.txCar2Cab19.ReadOnly = True
        Me.txCar2Cab19.Size = New System.Drawing.Size(199, 20)
        Me.txCar2Cab19.TabIndex = 96
        Me.txCar2Cab19.Visible = False
        '
        'txCar2Nro19
        '
        Me.txCar2Nro19.Location = New System.Drawing.Point(280, 600)
        Me.txCar2Nro19.Name = "txCar2Nro19"
        Me.txCar2Nro19.Size = New System.Drawing.Size(50, 20)
        Me.txCar2Nro19.TabIndex = 95
        Me.txCar2Nro19.Visible = False
        '
        'txCar2Cab18
        '
        Me.txCar2Cab18.Location = New System.Drawing.Point(335, 575)
        Me.txCar2Cab18.Name = "txCar2Cab18"
        Me.txCar2Cab18.ReadOnly = True
        Me.txCar2Cab18.Size = New System.Drawing.Size(199, 20)
        Me.txCar2Cab18.TabIndex = 94
        Me.txCar2Cab18.Visible = False
        '
        'txCar2Nro18
        '
        Me.txCar2Nro18.Location = New System.Drawing.Point(280, 575)
        Me.txCar2Nro18.Name = "txCar2Nro18"
        Me.txCar2Nro18.Size = New System.Drawing.Size(50, 20)
        Me.txCar2Nro18.TabIndex = 93
        Me.txCar2Nro18.Visible = False
        '
        'BindingSourceCarCab
        '
        Me.BindingSourceCarCab.DataMember = "tb_CarrerasCaballos"
        Me.BindingSourceCarCab.DataSource = Me.BdSIGAP_DataSet
        '
        'btCreaCarrera
        '
        Me.btCreaCarrera.Location = New System.Drawing.Point(551, 150)
        Me.btCreaCarrera.Name = "btCreaCarrera"
        Me.btCreaCarrera.Size = New System.Drawing.Size(106, 23)
        Me.btCreaCarrera.TabIndex = 100
        Me.btCreaCarrera.Text = "Crear Llave"
        Me.btCreaCarrera.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Location = New System.Drawing.Point(551, 180)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(106, 23)
        Me.btCancelar.TabIndex = 101
        Me.btCancelar.Text = "Salir"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'Tb_PorcentajesCasaTableAdapter
        '
        Me.Tb_PorcentajesCasaTableAdapter.ClearBeforeFill = True
        '
        'frmCargarLlave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 655)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btCreaCarrera)
        Me.Controls.Add(Me.txCar2Cab20)
        Me.Controls.Add(Me.txCar2Nro20)
        Me.Controls.Add(Me.txCar2Cab19)
        Me.Controls.Add(Me.txCar2Nro19)
        Me.Controls.Add(Me.txCar2Cab18)
        Me.Controls.Add(Me.txCar2Nro18)
        Me.Controls.Add(Me.txCar2Cab17)
        Me.Controls.Add(Me.txCar2Nro17)
        Me.Controls.Add(Me.txCar2Cab16)
        Me.Controls.Add(Me.txCar2Nro16)
        Me.Controls.Add(Me.txCar2Cab15)
        Me.Controls.Add(Me.txCar2Nro15)
        Me.Controls.Add(Me.txCar2Cab14)
        Me.Controls.Add(Me.txCar2Nro14)
        Me.Controls.Add(Me.txCar2Cab13)
        Me.Controls.Add(Me.txCar2Nro13)
        Me.Controls.Add(Me.txCar2Cab12)
        Me.Controls.Add(Me.txCar2Nro12)
        Me.Controls.Add(Me.txCar2Cab11)
        Me.Controls.Add(Me.txCar2Nro11)
        Me.Controls.Add(Me.txCar2Cab10)
        Me.Controls.Add(Me.txCar2Nro10)
        Me.Controls.Add(Me.txCar2Cab9)
        Me.Controls.Add(Me.txCar2Nro9)
        Me.Controls.Add(Me.txCar2Cab8)
        Me.Controls.Add(Me.txCar2Nro8)
        Me.Controls.Add(Me.txCar2Cab7)
        Me.Controls.Add(Me.txCar2Nro7)
        Me.Controls.Add(Me.txCar2Cab6)
        Me.Controls.Add(Me.txCar2Nro6)
        Me.Controls.Add(Me.txCar2Cab5)
        Me.Controls.Add(Me.txCar2Nro5)
        Me.Controls.Add(Me.txCar2Cab4)
        Me.Controls.Add(Me.txCar2Nro4)
        Me.Controls.Add(Me.txCar2Cab3)
        Me.Controls.Add(Me.txCar2Nro3)
        Me.Controls.Add(Me.txCar2Cab2)
        Me.Controls.Add(Me.txCar2Nro2)
        Me.Controls.Add(Me.txCar1Cab20)
        Me.Controls.Add(Me.txCar1Nro20)
        Me.Controls.Add(Me.txCar1Cab19)
        Me.Controls.Add(Me.txCar1Nro19)
        Me.Controls.Add(Me.txCar1Cab18)
        Me.Controls.Add(Me.txCar1Nro18)
        Me.Controls.Add(Me.txCar1Cab17)
        Me.Controls.Add(Me.txCar1Nro17)
        Me.Controls.Add(Me.txCar1Cab16)
        Me.Controls.Add(Me.txCar1Nro16)
        Me.Controls.Add(Me.txCar1Cab15)
        Me.Controls.Add(Me.txCar1Nro15)
        Me.Controls.Add(Me.txCar1Cab14)
        Me.Controls.Add(Me.txCar1Nro14)
        Me.Controls.Add(Me.txCar1Cab13)
        Me.Controls.Add(Me.txCar1Nro13)
        Me.Controls.Add(Me.txCar1Cab12)
        Me.Controls.Add(Me.txCar1Nro12)
        Me.Controls.Add(Me.txCar1Cab11)
        Me.Controls.Add(Me.txCar1Nro11)
        Me.Controls.Add(Me.txCar1Cab10)
        Me.Controls.Add(Me.txCar1Nro10)
        Me.Controls.Add(Me.txCar1Cab9)
        Me.Controls.Add(Me.txCar1Nro9)
        Me.Controls.Add(Me.txCar1Cab8)
        Me.Controls.Add(Me.txCar1Nro8)
        Me.Controls.Add(Me.txCar1Cab7)
        Me.Controls.Add(Me.txCar1Nro7)
        Me.Controls.Add(Me.txCar1Cab6)
        Me.Controls.Add(Me.txCar1Nro6)
        Me.Controls.Add(Me.txCar1Cab5)
        Me.Controls.Add(Me.txCar1Nro5)
        Me.Controls.Add(Me.txCar1Cab4)
        Me.Controls.Add(Me.txCar1Nro4)
        Me.Controls.Add(Me.txCar1Cab3)
        Me.Controls.Add(Me.txCar1Nro3)
        Me.Controls.Add(Me.txCar1Cab2)
        Me.Controls.Add(Me.txCar1Nro2)
        Me.Controls.Add(Me.txCar2Cab1)
        Me.Controls.Add(Me.txCar2Nro1)
        Me.Controls.Add(Me.txCar1Cab1)
        Me.Controls.Add(Me.txCar1Nro1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbCarrera2)
        Me.Controls.Add(Me.cbCarrera1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCargarLlave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargar Llave"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nCarrera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nProcentajeCasa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbJornadasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbCarrerasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbCarrerasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_CarrerasCaballosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbCaballosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceCarCab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents nCarrera As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents txNombre As TextBox
    Friend WithEvents nProcentajeCasa As NumericUpDown
    Friend WithEvents cbJornada As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbTipo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BdSIGAP_DataSet As bdSIGAP_DataSet
    Friend WithEvents TbJornadasBindingSource As BindingSource
    Friend WithEvents Tb_JornadasTableAdapter As bdSIGAP_DataSetTableAdapters.tb_JornadasTableAdapter
    Friend WithEvents cbCarrera1 As ComboBox
    Friend WithEvents cbCarrera2 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TbCarrerasBindingSource As BindingSource
    Friend WithEvents Tb_CarrerasTableAdapter As bdSIGAP_DataSetTableAdapters.tb_CarrerasTableAdapter
    Friend WithEvents TbCarrerasBindingSource1 As BindingSource
    Friend WithEvents txCar1Nro1 As TextBox
    Friend WithEvents txCar1Cab1 As TextBox
    Friend WithEvents txCar2Cab1 As TextBox
    Friend WithEvents txCar2Nro1 As TextBox
    Friend WithEvents Tb_CarrerasCaballosBindingSource As BindingSource
    Friend WithEvents Tb_CarrerasCaballosTableAdapter As bdSIGAP_DataSetTableAdapters.tb_CarrerasCaballosTableAdapter
    Friend WithEvents TableAdapterManager As bdSIGAP_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents txCar1Cab2 As TextBox
    Friend WithEvents txCar1Nro2 As TextBox
    Friend WithEvents txCar1Cab3 As TextBox
    Friend WithEvents txCar1Nro3 As TextBox
    Friend WithEvents txCar1Cab4 As TextBox
    Friend WithEvents txCar1Nro4 As TextBox
    Friend WithEvents txCar1Cab8 As TextBox
    Friend WithEvents txCar1Nro8 As TextBox
    Friend WithEvents txCar1Cab7 As TextBox
    Friend WithEvents txCar1Nro7 As TextBox
    Friend WithEvents txCar1Cab6 As TextBox
    Friend WithEvents txCar1Nro6 As TextBox
    Friend WithEvents txCar1Cab5 As TextBox
    Friend WithEvents txCar1Nro5 As TextBox
    Friend WithEvents txCar1Cab16 As TextBox
    Friend WithEvents txCar1Nro16 As TextBox
    Friend WithEvents txCar1Cab15 As TextBox
    Friend WithEvents txCar1Nro15 As TextBox
    Friend WithEvents txCar1Cab14 As TextBox
    Friend WithEvents txCar1Nro14 As TextBox
    Friend WithEvents txCar1Cab13 As TextBox
    Friend WithEvents txCar1Nro13 As TextBox
    Friend WithEvents txCar1Cab12 As TextBox
    Friend WithEvents txCar1Nro12 As TextBox
    Friend WithEvents txCar1Cab11 As TextBox
    Friend WithEvents txCar1Nro11 As TextBox
    Friend WithEvents txCar1Cab10 As TextBox
    Friend WithEvents txCar1Nro10 As TextBox
    Friend WithEvents txCar1Cab9 As TextBox
    Friend WithEvents txCar1Nro9 As TextBox
    Friend WithEvents txCar1Cab20 As TextBox
    Friend WithEvents txCar1Nro20 As TextBox
    Friend WithEvents txCar1Cab19 As TextBox
    Friend WithEvents txCar1Nro19 As TextBox
    Friend WithEvents txCar1Cab18 As TextBox
    Friend WithEvents txCar1Nro18 As TextBox
    Friend WithEvents txCar1Cab17 As TextBox
    Friend WithEvents txCar1Nro17 As TextBox
    Friend WithEvents Tb_CaballosTableAdapter As bdSIGAP_DataSetTableAdapters.tb_CaballosTableAdapter
    Friend WithEvents TbCaballosBindingSource As BindingSource
    Friend WithEvents txCar2Cab9 As TextBox
    Friend WithEvents txCar2Nro9 As TextBox
    Friend WithEvents txCar2Cab8 As TextBox
    Friend WithEvents txCar2Nro8 As TextBox
    Friend WithEvents txCar2Cab7 As TextBox
    Friend WithEvents txCar2Nro7 As TextBox
    Friend WithEvents txCar2Cab6 As TextBox
    Friend WithEvents txCar2Nro6 As TextBox
    Friend WithEvents txCar2Cab5 As TextBox
    Friend WithEvents txCar2Nro5 As TextBox
    Friend WithEvents txCar2Cab4 As TextBox
    Friend WithEvents txCar2Nro4 As TextBox
    Friend WithEvents txCar2Cab3 As TextBox
    Friend WithEvents txCar2Nro3 As TextBox
    Friend WithEvents txCar2Cab2 As TextBox
    Friend WithEvents txCar2Nro2 As TextBox
    Friend WithEvents txCar2Cab17 As TextBox
    Friend WithEvents txCar2Nro17 As TextBox
    Friend WithEvents txCar2Cab16 As TextBox
    Friend WithEvents txCar2Nro16 As TextBox
    Friend WithEvents txCar2Cab15 As TextBox
    Friend WithEvents txCar2Nro15 As TextBox
    Friend WithEvents txCar2Cab14 As TextBox
    Friend WithEvents txCar2Nro14 As TextBox
    Friend WithEvents txCar2Cab13 As TextBox
    Friend WithEvents txCar2Nro13 As TextBox
    Friend WithEvents txCar2Cab12 As TextBox
    Friend WithEvents txCar2Nro12 As TextBox
    Friend WithEvents txCar2Cab11 As TextBox
    Friend WithEvents txCar2Nro11 As TextBox
    Friend WithEvents txCar2Cab10 As TextBox
    Friend WithEvents txCar2Nro10 As TextBox
    Friend WithEvents txCar2Cab20 As TextBox
    Friend WithEvents txCar2Nro20 As TextBox
    Friend WithEvents txCar2Cab19 As TextBox
    Friend WithEvents txCar2Nro19 As TextBox
    Friend WithEvents txCar2Cab18 As TextBox
    Friend WithEvents txCar2Nro18 As TextBox
    Friend WithEvents BindingSourceCarCab As BindingSource
    Friend WithEvents btCreaCarrera As Button
    Friend WithEvents txref1 As TextBox
    Friend WithEvents txref2 As TextBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ColorDialog2 As ColorDialog
    Friend WithEvents ColorDialog3 As ColorDialog
    Friend WithEvents btCancelar As Button
    Friend WithEvents Tb_PorcentajesCasaTableAdapter As bdSIGAP_DataSetTableAdapters.tb_PorcentajesCasaTableAdapter
End Class
