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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BdSIGAP_DataSet = New SIGAP.bdSIGAP_DataSet()
        Me.TbJornadasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_JornadasTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_JornadasTableAdapter()
        Me.cbCarrera1 = New System.Windows.Forms.ComboBox()
        Me.cbCarrera2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbCarrerasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_CarrerasTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CarrerasTableAdapter()
        Me.TbCarrerasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txCar1Nro1 = New System.Windows.Forms.TextBox()
        Me.txCar1Cab1 = New System.Windows.Forms.TextBox()
        Me.txCar2Cab1 = New System.Windows.Forms.TextBox()
        Me.txCar2Nro1 = New System.Windows.Forms.TextBox()
        Me.Tb_CarrerasCaballosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_CarrerasCaballosTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CarrerasCaballosTableAdapter()
        Me.TableAdapterManager = New SIGAP.bdSIGAP_DataSetTableAdapters.TableAdapterManager()
        Me.txCar1Cab2 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro2 = New System.Windows.Forms.TextBox()
        Me.txCar1Cab3 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro3 = New System.Windows.Forms.TextBox()
        Me.txCar1Cab4 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro4 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro8 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro7 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro5 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro16 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro15 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro14 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro13 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro12 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro11 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro10 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro9 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro20 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro19 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro18 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.txCar1Nro17 = New System.Windows.Forms.TextBox()
        Me.TbCaballosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_CaballosTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CaballosTableAdapter()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.txCar2Nro8 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
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
        Me.TextBox33 = New System.Windows.Forms.TextBox()
        Me.TextBox34 = New System.Windows.Forms.TextBox()
        Me.TextBox35 = New System.Windows.Forms.TextBox()
        Me.TextBox36 = New System.Windows.Forms.TextBox()
        Me.TextBox37 = New System.Windows.Forms.TextBox()
        Me.TextBox38 = New System.Windows.Forms.TextBox()
        Me.TextBox39 = New System.Windows.Forms.TextBox()
        Me.TextBox40 = New System.Windows.Forms.TextBox()
        Me.TextBox41 = New System.Windows.Forms.TextBox()
        Me.TextBox42 = New System.Windows.Forms.TextBox()
        Me.TextBox43 = New System.Windows.Forms.TextBox()
        Me.TextBox44 = New System.Windows.Forms.TextBox()
        Me.TextBox45 = New System.Windows.Forms.TextBox()
        Me.TextBox46 = New System.Windows.Forms.TextBox()
        Me.TextBox47 = New System.Windows.Forms.TextBox()
        Me.TextBox48 = New System.Windows.Forms.TextBox()
        Me.TextBox49 = New System.Windows.Forms.TextBox()
        Me.TextBox50 = New System.Windows.Forms.TextBox()
        Me.TextBox51 = New System.Windows.Forms.TextBox()
        Me.TextBox52 = New System.Windows.Forms.TextBox()
        Me.TextBox53 = New System.Windows.Forms.TextBox()
        Me.TextBox54 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nCarrera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nProcentajeCasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbJornadasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCarrerasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCarrerasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_CarrerasCaballosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCaballosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Size = New System.Drawing.Size(589, 115)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "General"
        '
        'nCarrera
        '
        Me.nCarrera.Location = New System.Drawing.Point(88, 46)
        Me.nCarrera.Name = "nCarrera"
        Me.nCarrera.Size = New System.Drawing.Size(120, 20)
        Me.nCarrera.TabIndex = 16
        Me.nCarrera.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(230, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nombre:"
        '
        'txNombre
        '
        Me.txNombre.Location = New System.Drawing.Point(295, 46)
        Me.txNombre.Name = "txNombre"
        Me.txNombre.Size = New System.Drawing.Size(250, 20)
        Me.txNombre.TabIndex = 14
        '
        'nProcentajeCasa
        '
        Me.nProcentajeCasa.Location = New System.Drawing.Point(322, 79)
        Me.nProcentajeCasa.Name = "nProcentajeCasa"
        Me.nProcentajeCasa.Size = New System.Drawing.Size(120, 20)
        Me.nProcentajeCasa.TabIndex = 13
        Me.nProcentajeCasa.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'cbJornada
        '
        Me.cbJornada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbJornada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbJornada.DataSource = Me.TbJornadasBindingSource
        Me.cbJornada.DisplayMember = "Descripcion"
        Me.cbJornada.DropDownWidth = 333
        Me.cbJornada.FormattingEnabled = True
        Me.cbJornada.Location = New System.Drawing.Point(88, 15)
        Me.cbJornada.Name = "cbJornada"
        Me.cbJornada.Size = New System.Drawing.Size(457, 21)
        Me.cbJornada.TabIndex = 0
        Me.cbJornada.ValueMember = "Id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 18)
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
        Me.cbTipo.Location = New System.Drawing.Point(87, 78)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(121, 21)
        Me.cbTipo.TabIndex = 9
        Me.cbTipo.Text = "Llave"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tipo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Llave N°:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(228, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Porcentaje Casa:"
        '
        'BdSIGAP_DataSet
        '
        Me.BdSIGAP_DataSet.DataSetName = "bdSIGAP_DataSet"
        Me.BdSIGAP_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbJornadasBindingSource
        '
        Me.TbJornadasBindingSource.DataMember = "tb_Jornadas"
        Me.TbJornadasBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'Tb_JornadasTableAdapter
        '
        Me.Tb_JornadasTableAdapter.ClearBeforeFill = True
        '
        'cbCarrera1
        '
        Me.cbCarrera1.DataSource = Me.TbCarrerasBindingSource
        Me.cbCarrera1.DisplayMember = "Nombre"
        Me.cbCarrera1.FormattingEnabled = True
        Me.cbCarrera1.Location = New System.Drawing.Point(86, 123)
        Me.cbCarrera1.Name = "cbCarrera1"
        Me.cbCarrera1.Size = New System.Drawing.Size(212, 21)
        Me.cbCarrera1.TabIndex = 13
        Me.cbCarrera1.ValueMember = "Id"
        '
        'cbCarrera2
        '
        Me.cbCarrera2.DataSource = Me.TbCarrerasBindingSource1
        Me.cbCarrera2.DisplayMember = "Nombre"
        Me.cbCarrera2.FormattingEnabled = True
        Me.cbCarrera2.Location = New System.Drawing.Point(389, 123)
        Me.cbCarrera2.Name = "cbCarrera2"
        Me.cbCarrera2.Size = New System.Drawing.Size(212, 21)
        Me.cbCarrera2.TabIndex = 14
        Me.cbCarrera2.ValueMember = "Id"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Carrera N° 1:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(315, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Carrera N° 2:"
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
        'TbCarrerasBindingSource1
        '
        Me.TbCarrerasBindingSource1.DataMember = "tb_Carreras"
        Me.TbCarrerasBindingSource1.DataSource = Me.BdSIGAP_DataSet
        '
        'txCar1Nro1
        '
        Me.txCar1Nro1.Location = New System.Drawing.Point(15, 150)
        Me.txCar1Nro1.Name = "txCar1Nro1"
        Me.txCar1Nro1.Size = New System.Drawing.Size(71, 20)
        Me.txCar1Nro1.TabIndex = 19
        Me.txCar1Nro1.Visible = False
        '
        'txCar1Cab1
        '
        Me.txCar1Cab1.Location = New System.Drawing.Point(99, 150)
        Me.txCar1Cab1.Name = "txCar1Cab1"
        Me.txCar1Cab1.ReadOnly = True
        Me.txCar1Cab1.Size = New System.Drawing.Size(199, 20)
        Me.txCar1Cab1.TabIndex = 20
        Me.txCar1Cab1.Visible = False
        '
        'txCar2Cab1
        '
        Me.txCar2Cab1.Location = New System.Drawing.Point(402, 150)
        Me.txCar2Cab1.Name = "txCar2Cab1"
        Me.txCar2Cab1.Size = New System.Drawing.Size(199, 20)
        Me.txCar2Cab1.TabIndex = 22
        Me.txCar2Cab1.Visible = False
        '
        'txCar2Nro1
        '
        Me.txCar2Nro1.Location = New System.Drawing.Point(318, 150)
        Me.txCar2Nro1.Name = "txCar2Nro1"
        Me.txCar2Nro1.Size = New System.Drawing.Size(71, 20)
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
        Me.TableAdapterManager.tb_HipodromosTableAdapter = Nothing
        Me.TableAdapterManager.tb_JornadasTableAdapter = Me.Tb_JornadasTableAdapter
        Me.TableAdapterManager.tb_PalcosTableAdapter = Nothing
        Me.TableAdapterManager.tb_RematadoresTableAdapter = Nothing
        Me.TableAdapterManager.tb_RematesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SIGAP.bdSIGAP_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'txCar1Cab2
        '
        Me.txCar1Cab2.Location = New System.Drawing.Point(99, 176)
        Me.txCar1Cab2.Name = "txCar1Cab2"
        Me.txCar1Cab2.Size = New System.Drawing.Size(199, 20)
        Me.txCar1Cab2.TabIndex = 24
        Me.txCar1Cab2.Visible = False
        '
        'txCar1Nro2
        '
        Me.txCar1Nro2.Location = New System.Drawing.Point(15, 176)
        Me.txCar1Nro2.Name = "txCar1Nro2"
        Me.txCar1Nro2.Size = New System.Drawing.Size(71, 20)
        Me.txCar1Nro2.TabIndex = 23
        Me.txCar1Nro2.Visible = False
        '
        'txCar1Cab3
        '
        Me.txCar1Cab3.Location = New System.Drawing.Point(99, 202)
        Me.txCar1Cab3.Name = "txCar1Cab3"
        Me.txCar1Cab3.Size = New System.Drawing.Size(199, 20)
        Me.txCar1Cab3.TabIndex = 26
        Me.txCar1Cab3.Visible = False
        '
        'txCar1Nro3
        '
        Me.txCar1Nro3.Location = New System.Drawing.Point(15, 202)
        Me.txCar1Nro3.Name = "txCar1Nro3"
        Me.txCar1Nro3.Size = New System.Drawing.Size(71, 20)
        Me.txCar1Nro3.TabIndex = 25
        Me.txCar1Nro3.Visible = False
        '
        'txCar1Cab4
        '
        Me.txCar1Cab4.Location = New System.Drawing.Point(100, 228)
        Me.txCar1Cab4.Name = "txCar1Cab4"
        Me.txCar1Cab4.Size = New System.Drawing.Size(199, 20)
        Me.txCar1Cab4.TabIndex = 28
        Me.txCar1Cab4.Visible = False
        '
        'txCar1Nro4
        '
        Me.txCar1Nro4.Location = New System.Drawing.Point(16, 228)
        Me.txCar1Nro4.Name = "txCar1Nro4"
        Me.txCar1Nro4.Size = New System.Drawing.Size(71, 20)
        Me.txCar1Nro4.TabIndex = 27
        Me.txCar1Nro4.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(102, 332)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(199, 20)
        Me.TextBox1.TabIndex = 36
        Me.TextBox1.Visible = False
        '
        'txCar1Nro8
        '
        Me.txCar1Nro8.Location = New System.Drawing.Point(18, 332)
        Me.txCar1Nro8.Name = "txCar1Nro8"
        Me.txCar1Nro8.Size = New System.Drawing.Size(71, 20)
        Me.txCar1Nro8.TabIndex = 35
        Me.txCar1Nro8.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(101, 306)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(199, 20)
        Me.TextBox3.TabIndex = 34
        Me.TextBox3.Visible = False
        '
        'txCar1Nro7
        '
        Me.txCar1Nro7.Location = New System.Drawing.Point(17, 306)
        Me.txCar1Nro7.Name = "txCar1Nro7"
        Me.txCar1Nro7.Size = New System.Drawing.Size(71, 20)
        Me.txCar1Nro7.TabIndex = 33
        Me.txCar1Nro7.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(101, 280)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(199, 20)
        Me.TextBox5.TabIndex = 32
        Me.TextBox5.Visible = False
        '
        'txCar1Nro6
        '
        Me.txCar1Nro6.Location = New System.Drawing.Point(17, 280)
        Me.txCar1Nro6.Name = "txCar1Nro6"
        Me.txCar1Nro6.Size = New System.Drawing.Size(71, 20)
        Me.txCar1Nro6.TabIndex = 31
        Me.txCar1Nro6.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(101, 254)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(199, 20)
        Me.TextBox7.TabIndex = 30
        Me.TextBox7.Visible = False
        '
        'txCar1Nro5
        '
        Me.txCar1Nro5.Location = New System.Drawing.Point(17, 254)
        Me.txCar1Nro5.Name = "txCar1Nro5"
        Me.txCar1Nro5.Size = New System.Drawing.Size(71, 20)
        Me.txCar1Nro5.TabIndex = 29
        Me.txCar1Nro5.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(102, 538)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(199, 20)
        Me.TextBox2.TabIndex = 52
        Me.TextBox2.Visible = False
        '
        'txCar1Nro16
        '
        Me.txCar1Nro16.Location = New System.Drawing.Point(18, 538)
        Me.txCar1Nro16.Name = "txCar1Nro16"
        Me.txCar1Nro16.Size = New System.Drawing.Size(71, 20)
        Me.txCar1Nro16.TabIndex = 51
        Me.txCar1Nro16.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(101, 512)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(199, 20)
        Me.TextBox6.TabIndex = 50
        Me.TextBox6.Visible = False
        '
        'txCar1Nro15
        '
        Me.txCar1Nro15.Location = New System.Drawing.Point(17, 512)
        Me.txCar1Nro15.Name = "txCar1Nro15"
        Me.txCar1Nro15.Size = New System.Drawing.Size(71, 20)
        Me.txCar1Nro15.TabIndex = 49
        Me.txCar1Nro15.Visible = False
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(101, 486)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(199, 20)
        Me.TextBox9.TabIndex = 48
        Me.TextBox9.Visible = False
        '
        'txCar1Nro14
        '
        Me.txCar1Nro14.Location = New System.Drawing.Point(17, 486)
        Me.txCar1Nro14.Name = "txCar1Nro14"
        Me.txCar1Nro14.Size = New System.Drawing.Size(71, 20)
        Me.txCar1Nro14.TabIndex = 47
        Me.txCar1Nro14.Visible = False
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(101, 460)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(199, 20)
        Me.TextBox11.TabIndex = 46
        Me.TextBox11.Visible = False
        '
        'txCar1Nro13
        '
        Me.txCar1Nro13.Location = New System.Drawing.Point(17, 460)
        Me.txCar1Nro13.Name = "txCar1Nro13"
        Me.txCar1Nro13.Size = New System.Drawing.Size(71, 20)
        Me.txCar1Nro13.TabIndex = 45
        Me.txCar1Nro13.Visible = False
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(102, 434)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(199, 20)
        Me.TextBox13.TabIndex = 44
        Me.TextBox13.Visible = False
        '
        'txCar1Nro12
        '
        Me.txCar1Nro12.Location = New System.Drawing.Point(18, 434)
        Me.txCar1Nro12.Name = "txCar1Nro12"
        Me.txCar1Nro12.Size = New System.Drawing.Size(71, 20)
        Me.txCar1Nro12.TabIndex = 43
        Me.txCar1Nro12.Visible = False
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(101, 408)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(199, 20)
        Me.TextBox15.TabIndex = 42
        Me.TextBox15.Visible = False
        '
        'txCar1Nro11
        '
        Me.txCar1Nro11.Location = New System.Drawing.Point(17, 408)
        Me.txCar1Nro11.Name = "txCar1Nro11"
        Me.txCar1Nro11.Size = New System.Drawing.Size(71, 20)
        Me.txCar1Nro11.TabIndex = 41
        Me.txCar1Nro11.Visible = False
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(101, 382)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(199, 20)
        Me.TextBox17.TabIndex = 40
        Me.TextBox17.Visible = False
        '
        'txCar1Nro10
        '
        Me.txCar1Nro10.Location = New System.Drawing.Point(17, 382)
        Me.txCar1Nro10.Name = "txCar1Nro10"
        Me.txCar1Nro10.Size = New System.Drawing.Size(71, 20)
        Me.txCar1Nro10.TabIndex = 39
        Me.txCar1Nro10.Visible = False
        '
        'TextBox19
        '
        Me.TextBox19.Location = New System.Drawing.Point(101, 356)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(199, 20)
        Me.TextBox19.TabIndex = 38
        Me.TextBox19.Visible = False
        '
        'txCar1Nro9
        '
        Me.txCar1Nro9.Location = New System.Drawing.Point(17, 356)
        Me.txCar1Nro9.Name = "txCar1Nro9"
        Me.txCar1Nro9.Size = New System.Drawing.Size(71, 20)
        Me.txCar1Nro9.TabIndex = 37
        Me.txCar1Nro9.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(103, 641)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(199, 20)
        Me.TextBox4.TabIndex = 60
        Me.TextBox4.Visible = False
        '
        'txCar1Nro20
        '
        Me.txCar1Nro20.Location = New System.Drawing.Point(19, 641)
        Me.txCar1Nro20.Name = "txCar1Nro20"
        Me.txCar1Nro20.Size = New System.Drawing.Size(71, 20)
        Me.txCar1Nro20.TabIndex = 59
        Me.txCar1Nro20.Visible = False
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(102, 615)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(199, 20)
        Me.TextBox10.TabIndex = 58
        Me.TextBox10.Visible = False
        '
        'txCar1Nro19
        '
        Me.txCar1Nro19.Location = New System.Drawing.Point(18, 615)
        Me.txCar1Nro19.Name = "txCar1Nro19"
        Me.txCar1Nro19.Size = New System.Drawing.Size(71, 20)
        Me.txCar1Nro19.TabIndex = 57
        Me.txCar1Nro19.Visible = False
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(102, 589)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(199, 20)
        Me.TextBox14.TabIndex = 56
        Me.TextBox14.Visible = False
        '
        'txCar1Nro18
        '
        Me.txCar1Nro18.Location = New System.Drawing.Point(18, 589)
        Me.txCar1Nro18.Name = "txCar1Nro18"
        Me.txCar1Nro18.Size = New System.Drawing.Size(71, 20)
        Me.txCar1Nro18.TabIndex = 55
        Me.txCar1Nro18.Visible = False
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(102, 563)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(199, 20)
        Me.TextBox18.TabIndex = 54
        Me.TextBox18.Visible = False
        '
        'txCar1Nro17
        '
        Me.txCar1Nro17.Location = New System.Drawing.Point(18, 563)
        Me.txCar1Nro17.Name = "txCar1Nro17"
        Me.txCar1Nro17.Size = New System.Drawing.Size(71, 20)
        Me.txCar1Nro17.TabIndex = 53
        Me.txCar1Nro17.Visible = False
        '
        'TbCaballosBindingSource
        '
        Me.TbCaballosBindingSource.DataMember = "tb_Caballos"
        Me.TbCaballosBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'Tb_CaballosTableAdapter
        '
        Me.Tb_CaballosTableAdapter.ClearBeforeFill = True
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(404, 357)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(199, 20)
        Me.TextBox8.TabIndex = 76
        Me.TextBox8.Visible = False
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(320, 357)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(71, 20)
        Me.TextBox12.TabIndex = 75
        Me.TextBox12.Visible = False
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(403, 331)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(199, 20)
        Me.TextBox16.TabIndex = 74
        Me.TextBox16.Visible = False
        '
        'txCar2Nro8
        '
        Me.txCar2Nro8.Location = New System.Drawing.Point(319, 331)
        Me.txCar2Nro8.Name = "txCar2Nro8"
        Me.txCar2Nro8.Size = New System.Drawing.Size(71, 20)
        Me.txCar2Nro8.TabIndex = 73
        Me.txCar2Nro8.Visible = False
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(403, 305)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(199, 20)
        Me.TextBox21.TabIndex = 72
        Me.TextBox21.Visible = False
        '
        'txCar2Nro7
        '
        Me.txCar2Nro7.Location = New System.Drawing.Point(319, 305)
        Me.txCar2Nro7.Name = "txCar2Nro7"
        Me.txCar2Nro7.Size = New System.Drawing.Size(71, 20)
        Me.txCar2Nro7.TabIndex = 71
        Me.txCar2Nro7.Visible = False
        '
        'txCar2Cab6
        '
        Me.txCar2Cab6.Location = New System.Drawing.Point(403, 279)
        Me.txCar2Cab6.Name = "txCar2Cab6"
        Me.txCar2Cab6.Size = New System.Drawing.Size(199, 20)
        Me.txCar2Cab6.TabIndex = 70
        Me.txCar2Cab6.Visible = False
        '
        'txCar2Nro6
        '
        Me.txCar2Nro6.Location = New System.Drawing.Point(319, 279)
        Me.txCar2Nro6.Name = "txCar2Nro6"
        Me.txCar2Nro6.Size = New System.Drawing.Size(71, 20)
        Me.txCar2Nro6.TabIndex = 69
        Me.txCar2Nro6.Visible = False
        '
        'txCar2Cab5
        '
        Me.txCar2Cab5.Location = New System.Drawing.Point(403, 254)
        Me.txCar2Cab5.Name = "txCar2Cab5"
        Me.txCar2Cab5.Size = New System.Drawing.Size(199, 20)
        Me.txCar2Cab5.TabIndex = 68
        Me.txCar2Cab5.Visible = False
        '
        'txCar2Nro5
        '
        Me.txCar2Nro5.Location = New System.Drawing.Point(319, 254)
        Me.txCar2Nro5.Name = "txCar2Nro5"
        Me.txCar2Nro5.Size = New System.Drawing.Size(71, 20)
        Me.txCar2Nro5.TabIndex = 67
        Me.txCar2Nro5.Visible = False
        '
        'txCar2Cab4
        '
        Me.txCar2Cab4.Location = New System.Drawing.Point(402, 228)
        Me.txCar2Cab4.Name = "txCar2Cab4"
        Me.txCar2Cab4.Size = New System.Drawing.Size(199, 20)
        Me.txCar2Cab4.TabIndex = 66
        Me.txCar2Cab4.Visible = False
        '
        'txCar2Nro4
        '
        Me.txCar2Nro4.Location = New System.Drawing.Point(318, 228)
        Me.txCar2Nro4.Name = "txCar2Nro4"
        Me.txCar2Nro4.Size = New System.Drawing.Size(71, 20)
        Me.txCar2Nro4.TabIndex = 65
        Me.txCar2Nro4.Visible = False
        '
        'txCar2Cab3
        '
        Me.txCar2Cab3.Location = New System.Drawing.Point(402, 202)
        Me.txCar2Cab3.Name = "txCar2Cab3"
        Me.txCar2Cab3.Size = New System.Drawing.Size(199, 20)
        Me.txCar2Cab3.TabIndex = 64
        Me.txCar2Cab3.Visible = False
        '
        'txCar2Nro3
        '
        Me.txCar2Nro3.Location = New System.Drawing.Point(318, 202)
        Me.txCar2Nro3.Name = "txCar2Nro3"
        Me.txCar2Nro3.Size = New System.Drawing.Size(71, 20)
        Me.txCar2Nro3.TabIndex = 63
        Me.txCar2Nro3.Visible = False
        '
        'txCar2Cab2
        '
        Me.txCar2Cab2.Location = New System.Drawing.Point(402, 176)
        Me.txCar2Cab2.Name = "txCar2Cab2"
        Me.txCar2Cab2.Size = New System.Drawing.Size(199, 20)
        Me.txCar2Cab2.TabIndex = 62
        Me.txCar2Cab2.Visible = False
        '
        'txCar2Nro2
        '
        Me.txCar2Nro2.Location = New System.Drawing.Point(318, 176)
        Me.txCar2Nro2.Name = "txCar2Nro2"
        Me.txCar2Nro2.Size = New System.Drawing.Size(71, 20)
        Me.txCar2Nro2.TabIndex = 61
        Me.txCar2Nro2.Visible = False
        '
        'TextBox33
        '
        Me.TextBox33.Location = New System.Drawing.Point(405, 564)
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New System.Drawing.Size(199, 20)
        Me.TextBox33.TabIndex = 92
        Me.TextBox33.Visible = False
        '
        'TextBox34
        '
        Me.TextBox34.Location = New System.Drawing.Point(321, 564)
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New System.Drawing.Size(71, 20)
        Me.TextBox34.TabIndex = 91
        Me.TextBox34.Visible = False
        '
        'TextBox35
        '
        Me.TextBox35.Location = New System.Drawing.Point(404, 538)
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New System.Drawing.Size(199, 20)
        Me.TextBox35.TabIndex = 90
        Me.TextBox35.Visible = False
        '
        'TextBox36
        '
        Me.TextBox36.Location = New System.Drawing.Point(320, 538)
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New System.Drawing.Size(71, 20)
        Me.TextBox36.TabIndex = 89
        Me.TextBox36.Visible = False
        '
        'TextBox37
        '
        Me.TextBox37.Location = New System.Drawing.Point(404, 512)
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New System.Drawing.Size(199, 20)
        Me.TextBox37.TabIndex = 88
        Me.TextBox37.Visible = False
        '
        'TextBox38
        '
        Me.TextBox38.Location = New System.Drawing.Point(320, 512)
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New System.Drawing.Size(71, 20)
        Me.TextBox38.TabIndex = 87
        Me.TextBox38.Visible = False
        '
        'TextBox39
        '
        Me.TextBox39.Location = New System.Drawing.Point(404, 486)
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New System.Drawing.Size(199, 20)
        Me.TextBox39.TabIndex = 86
        Me.TextBox39.Visible = False
        '
        'TextBox40
        '
        Me.TextBox40.Location = New System.Drawing.Point(320, 486)
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New System.Drawing.Size(71, 20)
        Me.TextBox40.TabIndex = 85
        Me.TextBox40.Visible = False
        '
        'TextBox41
        '
        Me.TextBox41.Location = New System.Drawing.Point(404, 461)
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New System.Drawing.Size(199, 20)
        Me.TextBox41.TabIndex = 84
        Me.TextBox41.Visible = False
        '
        'TextBox42
        '
        Me.TextBox42.Location = New System.Drawing.Point(320, 461)
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New System.Drawing.Size(71, 20)
        Me.TextBox42.TabIndex = 83
        Me.TextBox42.Visible = False
        '
        'TextBox43
        '
        Me.TextBox43.Location = New System.Drawing.Point(403, 435)
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New System.Drawing.Size(199, 20)
        Me.TextBox43.TabIndex = 82
        Me.TextBox43.Visible = False
        '
        'TextBox44
        '
        Me.TextBox44.Location = New System.Drawing.Point(319, 435)
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New System.Drawing.Size(71, 20)
        Me.TextBox44.TabIndex = 81
        Me.TextBox44.Visible = False
        '
        'TextBox45
        '
        Me.TextBox45.Location = New System.Drawing.Point(403, 409)
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New System.Drawing.Size(199, 20)
        Me.TextBox45.TabIndex = 80
        Me.TextBox45.Visible = False
        '
        'TextBox46
        '
        Me.TextBox46.Location = New System.Drawing.Point(319, 409)
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Size = New System.Drawing.Size(71, 20)
        Me.TextBox46.TabIndex = 79
        Me.TextBox46.Visible = False
        '
        'TextBox47
        '
        Me.TextBox47.Location = New System.Drawing.Point(403, 383)
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.Size = New System.Drawing.Size(199, 20)
        Me.TextBox47.TabIndex = 78
        Me.TextBox47.Visible = False
        '
        'TextBox48
        '
        Me.TextBox48.Location = New System.Drawing.Point(319, 383)
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Size = New System.Drawing.Size(71, 20)
        Me.TextBox48.TabIndex = 77
        Me.TextBox48.Visible = False
        '
        'TextBox49
        '
        Me.TextBox49.Location = New System.Drawing.Point(405, 641)
        Me.TextBox49.Name = "TextBox49"
        Me.TextBox49.Size = New System.Drawing.Size(199, 20)
        Me.TextBox49.TabIndex = 98
        Me.TextBox49.Visible = False
        '
        'TextBox50
        '
        Me.TextBox50.Location = New System.Drawing.Point(321, 641)
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.Size = New System.Drawing.Size(71, 20)
        Me.TextBox50.TabIndex = 97
        Me.TextBox50.Visible = False
        '
        'TextBox51
        '
        Me.TextBox51.Location = New System.Drawing.Point(404, 615)
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.Size = New System.Drawing.Size(199, 20)
        Me.TextBox51.TabIndex = 96
        Me.TextBox51.Visible = False
        '
        'TextBox52
        '
        Me.TextBox52.Location = New System.Drawing.Point(320, 615)
        Me.TextBox52.Name = "TextBox52"
        Me.TextBox52.Size = New System.Drawing.Size(71, 20)
        Me.TextBox52.TabIndex = 95
        Me.TextBox52.Visible = False
        '
        'TextBox53
        '
        Me.TextBox53.Location = New System.Drawing.Point(404, 589)
        Me.TextBox53.Name = "TextBox53"
        Me.TextBox53.Size = New System.Drawing.Size(199, 20)
        Me.TextBox53.TabIndex = 94
        Me.TextBox53.Visible = False
        '
        'TextBox54
        '
        Me.TextBox54.Location = New System.Drawing.Point(320, 589)
        Me.TextBox54.Name = "TextBox54"
        Me.TextBox54.Size = New System.Drawing.Size(71, 20)
        Me.TextBox54.TabIndex = 93
        Me.TextBox54.Visible = False
        '
        'frmCargarLlave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 750)
        Me.Controls.Add(Me.TextBox49)
        Me.Controls.Add(Me.TextBox50)
        Me.Controls.Add(Me.TextBox51)
        Me.Controls.Add(Me.TextBox52)
        Me.Controls.Add(Me.TextBox53)
        Me.Controls.Add(Me.TextBox54)
        Me.Controls.Add(Me.TextBox33)
        Me.Controls.Add(Me.TextBox34)
        Me.Controls.Add(Me.TextBox35)
        Me.Controls.Add(Me.TextBox36)
        Me.Controls.Add(Me.TextBox37)
        Me.Controls.Add(Me.TextBox38)
        Me.Controls.Add(Me.TextBox39)
        Me.Controls.Add(Me.TextBox40)
        Me.Controls.Add(Me.TextBox41)
        Me.Controls.Add(Me.TextBox42)
        Me.Controls.Add(Me.TextBox43)
        Me.Controls.Add(Me.TextBox44)
        Me.Controls.Add(Me.TextBox45)
        Me.Controls.Add(Me.TextBox46)
        Me.Controls.Add(Me.TextBox47)
        Me.Controls.Add(Me.TextBox48)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.txCar2Nro8)
        Me.Controls.Add(Me.TextBox21)
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
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.txCar1Nro20)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.txCar1Nro19)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.txCar1Nro18)
        Me.Controls.Add(Me.TextBox18)
        Me.Controls.Add(Me.txCar1Nro17)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txCar1Nro16)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.txCar1Nro15)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.txCar1Nro14)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.txCar1Nro13)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.txCar1Nro12)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.txCar1Nro11)
        Me.Controls.Add(Me.TextBox17)
        Me.Controls.Add(Me.txCar1Nro10)
        Me.Controls.Add(Me.TextBox19)
        Me.Controls.Add(Me.txCar1Nro9)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txCar1Nro8)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txCar1Nro7)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.txCar1Nro6)
        Me.Controls.Add(Me.TextBox7)
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
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbJornadasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbCarrerasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbCarrerasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_CarrerasCaballosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbCaballosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txCar1Nro8 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txCar1Nro7 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents txCar1Nro6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents txCar1Nro5 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txCar1Nro16 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents txCar1Nro15 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents txCar1Nro14 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents txCar1Nro13 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents txCar1Nro12 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents txCar1Nro11 As TextBox
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents txCar1Nro10 As TextBox
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents txCar1Nro9 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents txCar1Nro20 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents txCar1Nro19 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents txCar1Nro18 As TextBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents txCar1Nro17 As TextBox
    Friend WithEvents Tb_CaballosTableAdapter As bdSIGAP_DataSetTableAdapters.tb_CaballosTableAdapter
    Friend WithEvents TbCaballosBindingSource As BindingSource
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents txCar2Nro8 As TextBox
    Friend WithEvents TextBox21 As TextBox
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
    Friend WithEvents TextBox33 As TextBox
    Friend WithEvents TextBox34 As TextBox
    Friend WithEvents TextBox35 As TextBox
    Friend WithEvents TextBox36 As TextBox
    Friend WithEvents TextBox37 As TextBox
    Friend WithEvents TextBox38 As TextBox
    Friend WithEvents TextBox39 As TextBox
    Friend WithEvents TextBox40 As TextBox
    Friend WithEvents TextBox41 As TextBox
    Friend WithEvents TextBox42 As TextBox
    Friend WithEvents TextBox43 As TextBox
    Friend WithEvents TextBox44 As TextBox
    Friend WithEvents TextBox45 As TextBox
    Friend WithEvents TextBox46 As TextBox
    Friend WithEvents TextBox47 As TextBox
    Friend WithEvents TextBox48 As TextBox
    Friend WithEvents TextBox49 As TextBox
    Friend WithEvents TextBox50 As TextBox
    Friend WithEvents TextBox51 As TextBox
    Friend WithEvents TextBox52 As TextBox
    Friend WithEvents TextBox53 As TextBox
    Friend WithEvents TextBox54 As TextBox
End Class
