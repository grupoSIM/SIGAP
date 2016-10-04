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
        Me.cmbCarrera = New System.Windows.Forms.ComboBox()
        Me.TbCarrerasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdSIGAP_DataSet = New SIGAP.bdSIGAP_DataSet()
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
        Me.TbPalcosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblCaballo = New System.Windows.Forms.Label()
        Me.lblApostador = New System.Windows.Forms.Label()
        Me.lblApuesta = New System.Windows.Forms.Label()
        Me.lblIncluido = New System.Windows.Forms.Label()
        Me.lblLuz = New System.Windows.Forms.Label()
        Me.lblFila = New System.Windows.Forms.Label()
        Me.Tb_PalcosTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_PalcosTableAdapter()
        Me.Tb_JornadasTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_JornadasTableAdapter()
        Me.Tb_CarrerasCaballosTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CarrerasCaballosTableAdapter()
        Me.Tb_CaballosTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CaballosTableAdapter()
        Me.Tb_CarrerasTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_CarrerasTableAdapter()
        Me.Tb_DetalleRematesTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_DetalleRematesTableAdapter()
        Me.Tb_RematesTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_RematesTableAdapter()
        Me.Tb_RematadoresTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_RematadoresTableAdapter()
        Me.Tb_PorcentajesCasaTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_PorcentajesCasaTableAdapter()
        Me.txYunta = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.TbCarrerasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbPalcosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(256, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(44, 13)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Remate"
        '
        'cmbCarrera
        '
        Me.cmbCarrera.DataSource = Me.TbCarrerasBindingSource
        Me.cmbCarrera.DisplayMember = "Nombre"
        Me.cmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarrera.FormattingEnabled = True
        Me.cmbCarrera.Location = New System.Drawing.Point(81, 64)
        Me.cmbCarrera.Name = "cmbCarrera"
        Me.cmbCarrera.Size = New System.Drawing.Size(121, 21)
        Me.cmbCarrera.TabIndex = 9
        Me.cmbCarrera.TabStop = False
        Me.cmbCarrera.ValueMember = "Id"
        '
        'TbCarrerasBindingSource
        '
        Me.TbCarrerasBindingSource.DataMember = "tb_Carreras"
        Me.TbCarrerasBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'BdSIGAP_DataSet
        '
        Me.BdSIGAP_DataSet.DataSetName = "bdSIGAP_DataSet"
        Me.BdSIGAP_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtRemate
        '
        Me.txtRemate.Location = New System.Drawing.Point(308, 64)
        Me.txtRemate.Name = "txtRemate"
        Me.txtRemate.ReadOnly = True
        Me.txtRemate.Size = New System.Drawing.Size(100, 20)
        Me.txtRemate.TabIndex = 11
        Me.txtRemate.TabStop = False
        '
        'txtPorcentajeCasa
        '
        Me.txtPorcentajeCasa.Location = New System.Drawing.Point(478, 64)
        Me.txtPorcentajeCasa.Name = "txtPorcentajeCasa"
        Me.txtPorcentajeCasa.Size = New System.Drawing.Size(100, 20)
        Me.txtPorcentajeCasa.TabIndex = 13
        Me.txtPorcentajeCasa.TabStop = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(395, 555)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 500
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtJornada
        '
        Me.txtJornada.Location = New System.Drawing.Point(102, 27)
        Me.txtJornada.Name = "txtJornada"
        Me.txtJornada.ReadOnly = True
        Me.txtJornada.Size = New System.Drawing.Size(100, 20)
        Me.txtJornada.TabIndex = 3
        Me.txtJornada.TabStop = False
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(276, 27)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 5
        Me.txtFecha.TabStop = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(481, 555)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(104, 23)
        Me.btnImprimir.TabIndex = 501
        Me.btnImprimir.TabStop = False
        Me.btnImprimir.Text = "Guardar e Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(408, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Palco"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(233, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jornada"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Carrera"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(220, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Nro. de Remate"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(414, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Porcentaje"
        '
        'cmbPalco
        '
        Me.cmbPalco.DataSource = Me.TbPalcosBindingSource
        Me.cmbPalco.DisplayMember = "Palco"
        Me.cmbPalco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPalco.FormattingEnabled = True
        Me.cmbPalco.Location = New System.Drawing.Point(457, 26)
        Me.cmbPalco.Name = "cmbPalco"
        Me.cmbPalco.Size = New System.Drawing.Size(121, 21)
        Me.cmbPalco.TabIndex = 7
        Me.cmbPalco.TabStop = False
        Me.cmbPalco.ValueMember = "Id"
        '
        'TbPalcosBindingSource
        '
        Me.TbPalcosBindingSource.DataMember = "tb_Palcos"
        Me.TbPalcosBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(6, 573)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 502
        Me.txtId.TabStop = False
        Me.txtId.Visible = False
        '
        'lblNumero
        '
        Me.lblNumero.Location = New System.Drawing.Point(11, 104)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(49, 13)
        Me.lblNumero.TabIndex = 14
        Me.lblNumero.Text = "Número"
        Me.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCaballo
        '
        Me.lblCaballo.AutoSize = True
        Me.lblCaballo.Location = New System.Drawing.Point(133, 104)
        Me.lblCaballo.Name = "lblCaballo"
        Me.lblCaballo.Size = New System.Drawing.Size(42, 13)
        Me.lblCaballo.TabIndex = 15
        Me.lblCaballo.Text = "Caballo"
        Me.lblCaballo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblApostador
        '
        Me.lblApostador.AutoSize = True
        Me.lblApostador.Location = New System.Drawing.Point(264, 104)
        Me.lblApostador.Name = "lblApostador"
        Me.lblApostador.Size = New System.Drawing.Size(55, 13)
        Me.lblApostador.TabIndex = 16
        Me.lblApostador.Text = "Apostador"
        Me.lblApostador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblApuesta
        '
        Me.lblApuesta.AutoSize = True
        Me.lblApuesta.Location = New System.Drawing.Point(365, 104)
        Me.lblApuesta.Name = "lblApuesta"
        Me.lblApuesta.Size = New System.Drawing.Size(46, 13)
        Me.lblApuesta.TabIndex = 17
        Me.lblApuesta.Text = "Apuesta"
        Me.lblApuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIncluido
        '
        Me.lblIncluido.AutoSize = True
        Me.lblIncluido.Location = New System.Drawing.Point(426, 104)
        Me.lblIncluido.Name = "lblIncluido"
        Me.lblIncluido.Size = New System.Drawing.Size(44, 13)
        Me.lblIncluido.TabIndex = 18
        Me.lblIncluido.Text = "Incluido"
        Me.lblIncluido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLuz
        '
        Me.lblLuz.AutoSize = True
        Me.lblLuz.Location = New System.Drawing.Point(501, 104)
        Me.lblLuz.Name = "lblLuz"
        Me.lblLuz.Size = New System.Drawing.Size(24, 13)
        Me.lblLuz.TabIndex = 19
        Me.lblLuz.Text = "Luz"
        Me.lblLuz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFila
        '
        Me.lblFila.AutoSize = True
        Me.lblFila.Location = New System.Drawing.Point(562, 104)
        Me.lblFila.Name = "lblFila"
        Me.lblFila.Size = New System.Drawing.Size(23, 13)
        Me.lblFila.TabIndex = 20
        Me.lblFila.Text = "Fila"
        Me.lblFila.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tb_PalcosTableAdapter
        '
        Me.Tb_PalcosTableAdapter.ClearBeforeFill = True
        '
        'Tb_JornadasTableAdapter
        '
        Me.Tb_JornadasTableAdapter.ClearBeforeFill = True
        '
        'Tb_CarrerasCaballosTableAdapter
        '
        Me.Tb_CarrerasCaballosTableAdapter.ClearBeforeFill = True
        '
        'Tb_CaballosTableAdapter
        '
        Me.Tb_CaballosTableAdapter.ClearBeforeFill = True
        '
        'Tb_CarrerasTableAdapter
        '
        Me.Tb_CarrerasTableAdapter.ClearBeforeFill = True
        '
        'Tb_DetalleRematesTableAdapter
        '
        Me.Tb_DetalleRematesTableAdapter.ClearBeforeFill = True
        '
        'Tb_RematesTableAdapter
        '
        Me.Tb_RematesTableAdapter.ClearBeforeFill = True
        '
        'Tb_RematadoresTableAdapter
        '
        Me.Tb_RematadoresTableAdapter.ClearBeforeFill = True
        '
        'Tb_PorcentajesCasaTableAdapter
        '
        Me.Tb_PorcentajesCasaTableAdapter.ClearBeforeFill = True
        '
        'txYunta
        '
        Me.txYunta.Location = New System.Drawing.Point(637, 53)
        Me.txYunta.Name = "txYunta"
        Me.txYunta.Size = New System.Drawing.Size(100, 20)
        Me.txYunta.TabIndex = 503
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(637, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 23)
        Me.Button1.TabIndex = 504
        Me.Button1.Text = "Crear YUNTA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmRemate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 599)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txYunta)
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
        CType(Me.TbCarrerasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbPalcosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As Label
    Friend WithEvents cmbCarrera As ComboBox
    Friend WithEvents txtRemate As TextBox
    Friend WithEvents txtPorcentajeCasa As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtJornada As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbPalco As ComboBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblNumero As Label
    Friend WithEvents lblCaballo As Label
    Friend WithEvents lblApostador As Label
    Friend WithEvents lblApuesta As Label
    Friend WithEvents lblIncluido As Label
    Friend WithEvents lblLuz As Label
    Friend WithEvents lblFila As Label
    Friend WithEvents BdSIGAP_DataSet As bdSIGAP_DataSet
    Friend WithEvents Tb_PalcosTableAdapter As bdSIGAP_DataSetTableAdapters.tb_PalcosTableAdapter
    Friend WithEvents Tb_JornadasTableAdapter As bdSIGAP_DataSetTableAdapters.tb_JornadasTableAdapter
    Friend WithEvents Tb_CarrerasCaballosTableAdapter As bdSIGAP_DataSetTableAdapters.tb_CarrerasCaballosTableAdapter
    Friend WithEvents Tb_CaballosTableAdapter As bdSIGAP_DataSetTableAdapters.tb_CaballosTableAdapter
    Friend WithEvents Tb_CarrerasTableAdapter As bdSIGAP_DataSetTableAdapters.tb_CarrerasTableAdapter
    Friend WithEvents Tb_DetalleRematesTableAdapter As bdSIGAP_DataSetTableAdapters.tb_DetalleRematesTableAdapter
    Friend WithEvents Tb_RematesTableAdapter As bdSIGAP_DataSetTableAdapters.tb_RematesTableAdapter
    Friend WithEvents TbPalcosBindingSource As BindingSource
    Friend WithEvents TbCarrerasBindingSource As BindingSource
    Friend WithEvents Tb_RematadoresTableAdapter As bdSIGAP_DataSetTableAdapters.tb_RematadoresTableAdapter
    Friend WithEvents Tb_PorcentajesCasaTableAdapter As bdSIGAP_DataSetTableAdapters.tb_PorcentajesCasaTableAdapter
    Friend WithEvents txYunta As TextBox
    Friend WithEvents Button1 As Button
End Class
