<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.NombreLabel1 = New System.Windows.Forms.Label()
        Me.FechaLabel1 = New System.Windows.Forms.Label()
        Me.NroCarreraLabel1 = New System.Windows.Forms.Label()
        Me.PalcoLabel1 = New System.Windows.Forms.Label()
        Me.NroCaballoLabel1 = New System.Windows.Forms.Label()
        Me.CaballoNombreLabel1 = New System.Windows.Forms.Label()
        Me.ImporteApuestaLabel1 = New System.Windows.Forms.Label()
        Me.ApostadorLabel1 = New System.Windows.Forms.Label()
        Me.ApuC1Label1 = New System.Windows.Forms.Label()
        Me.ApuC2Label1 = New System.Windows.Forms.Label()
        Me.ApuC3Label1 = New System.Windows.Forms.Label()
        Me.ApuC4Label1 = New System.Windows.Forms.Label()
        Me.ApuC5Label1 = New System.Windows.Forms.Label()
        Me.ApuC6Label1 = New System.Windows.Forms.Label()
        Me.ApuC7Label1 = New System.Windows.Forms.Label()
        Me.ApuC8Label1 = New System.Windows.Forms.Label()
        Me.ApuC9Label1 = New System.Windows.Forms.Label()
        Me.ApuC10Label1 = New System.Windows.Forms.Label()
        Me.ApuC11Label1 = New System.Windows.Forms.Label()
        Me.ApuC12Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PremioLabel1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.VwTicketBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdSIGAP_DataSet = New SIGAP.bdSIGAP_DataSet()
        Me.VwTicketTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.VwTicketTableAdapter()
        Me.TableAdapterManager = New SIGAP.bdSIGAP_DataSetTableAdapters.TableAdapterManager()
        Me.NroRemateLabel1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.VwTicketBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'NombreLabel1
        '
        Me.NombreLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwTicketBindingSource, "Nombre", True))
        Me.NombreLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreLabel1.Location = New System.Drawing.Point(-4, 9)
        Me.NombreLabel1.Name = "NombreLabel1"
        Me.NombreLabel1.Size = New System.Drawing.Size(295, 23)
        Me.NombreLabel1.TabIndex = 3
        Me.NombreLabel1.Text = "Lbl_Hipodromo"
        '
        'FechaLabel1
        '
        Me.FechaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwTicketBindingSource, "Fecha", True))
        Me.FechaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaLabel1.Location = New System.Drawing.Point(-3, 43)
        Me.FechaLabel1.Name = "FechaLabel1"
        Me.FechaLabel1.Size = New System.Drawing.Size(80, 15)
        Me.FechaLabel1.TabIndex = 5
        Me.FechaLabel1.Text = "Lbl_Fecha"
        '
        'NroCarreraLabel1
        '
        Me.NroCarreraLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwTicketBindingSource, "NroCarrera", True))
        Me.NroCarreraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NroCarreraLabel1.Location = New System.Drawing.Point(93, 71)
        Me.NroCarreraLabel1.Name = "NroCarreraLabel1"
        Me.NroCarreraLabel1.Size = New System.Drawing.Size(43, 15)
        Me.NroCarreraLabel1.TabIndex = 7
        Me.NroCarreraLabel1.Text = "Lbl_NroCarrera"
        '
        'PalcoLabel1
        '
        Me.PalcoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwTicketBindingSource, "Palco", True))
        Me.PalcoLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PalcoLabel1.Location = New System.Drawing.Point(251, 43)
        Me.PalcoLabel1.Name = "PalcoLabel1"
        Me.PalcoLabel1.Size = New System.Drawing.Size(33, 15)
        Me.PalcoLabel1.TabIndex = 9
        Me.PalcoLabel1.Text = "Lbl_Palco"
        '
        'NroCaballoLabel1
        '
        Me.NroCaballoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwTicketBindingSource, "NroCaballo", True))
        Me.NroCaballoLabel1.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NroCaballoLabel1.Location = New System.Drawing.Point(-5, 136)
        Me.NroCaballoLabel1.Name = "NroCaballoLabel1"
        Me.NroCaballoLabel1.Size = New System.Drawing.Size(57, 41)
        Me.NroCaballoLabel1.TabIndex = 11
        Me.NroCaballoLabel1.Text = "Lbl__NroCaballo"
        Me.NroCaballoLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CaballoNombreLabel1
        '
        Me.CaballoNombreLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwTicketBindingSource, "CaballoNombre", True))
        Me.CaballoNombreLabel1.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaballoNombreLabel1.Location = New System.Drawing.Point(51, 136)
        Me.CaballoNombreLabel1.Name = "CaballoNombreLabel1"
        Me.CaballoNombreLabel1.Size = New System.Drawing.Size(260, 41)
        Me.CaballoNombreLabel1.TabIndex = 13
        Me.CaballoNombreLabel1.Text = "Lbl_NombreCaballo"
        '
        'ImporteApuestaLabel1
        '
        Me.ImporteApuestaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwTicketBindingSource, "ImporteApuesta", True))
        Me.ImporteApuestaLabel1.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImporteApuestaLabel1.Location = New System.Drawing.Point(1, 223)
        Me.ImporteApuestaLabel1.Name = "ImporteApuestaLabel1"
        Me.ImporteApuestaLabel1.Size = New System.Drawing.Size(138, 25)
        Me.ImporteApuestaLabel1.TabIndex = 15
        Me.ImporteApuestaLabel1.Text = "Lbl_ImporteApuesta"
        Me.ImporteApuestaLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ApostadorLabel1
        '
        Me.ApostadorLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwTicketBindingSource, "Apostador", True))
        Me.ApostadorLabel1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApostadorLabel1.Location = New System.Drawing.Point(0, 298)
        Me.ApostadorLabel1.Name = "ApostadorLabel1"
        Me.ApostadorLabel1.Size = New System.Drawing.Size(271, 21)
        Me.ApostadorLabel1.TabIndex = 17
        Me.ApostadorLabel1.Text = "Lbl_Apostador"
        Me.ApostadorLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ApuC1Label1
        '
        Me.ApuC1Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwTicketBindingSource, "ApuC1", True))
        Me.ApuC1Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApuC1Label1.Location = New System.Drawing.Point(-2, 360)
        Me.ApuC1Label1.Name = "ApuC1Label1"
        Me.ApuC1Label1.Size = New System.Drawing.Size(100, 16)
        Me.ApuC1Label1.TabIndex = 21
        Me.ApuC1Label1.Text = "Lbl_Apu1"
        '
        'ApuC2Label1
        '
        Me.ApuC2Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwTicketBindingSource, "ApuC2", True))
        Me.ApuC2Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApuC2Label1.Location = New System.Drawing.Point(99, 360)
        Me.ApuC2Label1.Name = "ApuC2Label1"
        Me.ApuC2Label1.Size = New System.Drawing.Size(100, 16)
        Me.ApuC2Label1.TabIndex = 23
        Me.ApuC2Label1.Text = "Lbl_Apu2"
        '
        'ApuC3Label1
        '
        Me.ApuC3Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwTicketBindingSource, "ApuC3", True))
        Me.ApuC3Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApuC3Label1.Location = New System.Drawing.Point(202, 360)
        Me.ApuC3Label1.Name = "ApuC3Label1"
        Me.ApuC3Label1.Size = New System.Drawing.Size(100, 16)
        Me.ApuC3Label1.TabIndex = 25
        Me.ApuC3Label1.Text = "Lbl_Apu3"
        '
        'ApuC4Label1
        '
        Me.ApuC4Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwTicketBindingSource, "ApuC4", True))
        Me.ApuC4Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApuC4Label1.Location = New System.Drawing.Point(-2, 382)
        Me.ApuC4Label1.Name = "ApuC4Label1"
        Me.ApuC4Label1.Size = New System.Drawing.Size(100, 16)
        Me.ApuC4Label1.TabIndex = 27
        Me.ApuC4Label1.Text = "Lbl_Apu4"
        '
        'ApuC5Label1
        '
        Me.ApuC5Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwTicketBindingSource, "ApuC5", True))
        Me.ApuC5Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApuC5Label1.Location = New System.Drawing.Point(99, 382)
        Me.ApuC5Label1.Name = "ApuC5Label1"
        Me.ApuC5Label1.Size = New System.Drawing.Size(100, 16)
        Me.ApuC5Label1.TabIndex = 29
        Me.ApuC5Label1.Text = "Lbl_Apu5"
        '
        'ApuC6Label1
        '
        Me.ApuC6Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwTicketBindingSource, "ApuC6", True))
        Me.ApuC6Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApuC6Label1.Location = New System.Drawing.Point(202, 382)
        Me.ApuC6Label1.Name = "ApuC6Label1"
        Me.ApuC6Label1.Size = New System.Drawing.Size(100, 16)
        Me.ApuC6Label1.TabIndex = 31
        Me.ApuC6Label1.Text = "Lbl_Apu6"
        '
        'ApuC7Label1
        '
        Me.ApuC7Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwTicketBindingSource, "ApuC7", True))
        Me.ApuC7Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApuC7Label1.Location = New System.Drawing.Point(-2, 404)
        Me.ApuC7Label1.Name = "ApuC7Label1"
        Me.ApuC7Label1.Size = New System.Drawing.Size(100, 16)
        Me.ApuC7Label1.TabIndex = 33
        Me.ApuC7Label1.Text = "Lbl_Apu7"
        '
        'ApuC8Label1
        '
        Me.ApuC8Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwTicketBindingSource, "ApuC8", True))
        Me.ApuC8Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApuC8Label1.Location = New System.Drawing.Point(99, 404)
        Me.ApuC8Label1.Name = "ApuC8Label1"
        Me.ApuC8Label1.Size = New System.Drawing.Size(100, 16)
        Me.ApuC8Label1.TabIndex = 35
        Me.ApuC8Label1.Text = "Lbl_Apu8"
        '
        'ApuC9Label1
        '
        Me.ApuC9Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwTicketBindingSource, "ApuC9", True))
        Me.ApuC9Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApuC9Label1.Location = New System.Drawing.Point(202, 404)
        Me.ApuC9Label1.Name = "ApuC9Label1"
        Me.ApuC9Label1.Size = New System.Drawing.Size(100, 16)
        Me.ApuC9Label1.TabIndex = 37
        Me.ApuC9Label1.Text = "Lbl_Apu9"
        '
        'ApuC10Label1
        '
        Me.ApuC10Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwTicketBindingSource, "ApuC10", True))
        Me.ApuC10Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApuC10Label1.Location = New System.Drawing.Point(-2, 428)
        Me.ApuC10Label1.Name = "ApuC10Label1"
        Me.ApuC10Label1.Size = New System.Drawing.Size(100, 16)
        Me.ApuC10Label1.TabIndex = 39
        Me.ApuC10Label1.Text = "Lbl_Apu10"
        '
        'ApuC11Label1
        '
        Me.ApuC11Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwTicketBindingSource, "ApuC11", True))
        Me.ApuC11Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApuC11Label1.Location = New System.Drawing.Point(99, 428)
        Me.ApuC11Label1.Name = "ApuC11Label1"
        Me.ApuC11Label1.Size = New System.Drawing.Size(100, 16)
        Me.ApuC11Label1.TabIndex = 41
        Me.ApuC11Label1.Text = "Lbl_Apu11"
        '
        'ApuC12Label1
        '
        Me.ApuC12Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwTicketBindingSource, "ApuC12", True))
        Me.ApuC12Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApuC12Label1.Location = New System.Drawing.Point(202, 428)
        Me.ApuC12Label1.Name = "ApuC12Label1"
        Me.ApuC12Label1.Size = New System.Drawing.Size(100, 16)
        Me.ApuC12Label1.TabIndex = 43
        Me.ApuC12Label1.Text = "Lbl_Apu12"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(302, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 23)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-2, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "CARRERA Nº"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "CABALLO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(89, 324)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "APOSTADOR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(200, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "PREMIO"
        '
        'PremioLabel1
        '
        Me.PremioLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwTicketBindingSource, "Premio", True))
        Me.PremioLabel1.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PremioLabel1.Location = New System.Drawing.Point(163, 223)
        Me.PremioLabel1.Name = "PremioLabel1"
        Me.PremioLabel1.Size = New System.Drawing.Size(128, 25)
        Me.PremioLabel1.TabIndex = 49
        Me.PremioLabel1.Text = "Lbl_Premio"
        Me.PremioLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(208, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "PALCO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(182, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "REMATE"
        '
        'VwTicketBindingSource
        '
        Me.VwTicketBindingSource.DataMember = "VwTicket"
        Me.VwTicketBindingSource.DataSource = Me.BdSIGAP_DataSet
        '
        'BdSIGAP_DataSet
        '
        Me.BdSIGAP_DataSet.DataSetName = "bdSIGAP_DataSet"
        Me.BdSIGAP_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwTicketTableAdapter
        '
        Me.VwTicketTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tb_CaballosTableAdapter = Nothing
        Me.TableAdapterManager.tb_CarrerasCaballosTableAdapter = Nothing
        Me.TableAdapterManager.tb_CarrerasTableAdapter = Nothing
        Me.TableAdapterManager.tb_DetalleRematesTableAdapter = Nothing
        Me.TableAdapterManager.tb_HipodromosTableAdapter = Nothing
        Me.TableAdapterManager.tb_JornadasTableAdapter = Nothing
        Me.TableAdapterManager.tb_PalcosTableAdapter = Nothing
        Me.TableAdapterManager.tb_RematadoresTableAdapter = Nothing
        Me.TableAdapterManager.tb_RematesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SIGAP.bdSIGAP_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NroRemateLabel1
        '
        Me.NroRemateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwTicketBindingSource, "NroRemate", True))
        Me.NroRemateLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NroRemateLabel1.Location = New System.Drawing.Point(242, 72)
        Me.NroRemateLabel1.Name = "NroRemateLabel1"
        Me.NroRemateLabel1.Size = New System.Drawing.Size(46, 13)
        Me.NroRemateLabel1.TabIndex = 52
        Me.NroRemateLabel1.Text = "Label7"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(38, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "APUESTA"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(356, 448)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NroRemateLabel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PremioLabel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NombreLabel1)
        Me.Controls.Add(Me.FechaLabel1)
        Me.Controls.Add(Me.NroCarreraLabel1)
        Me.Controls.Add(Me.PalcoLabel1)
        Me.Controls.Add(Me.NroCaballoLabel1)
        Me.Controls.Add(Me.CaballoNombreLabel1)
        Me.Controls.Add(Me.ImporteApuestaLabel1)
        Me.Controls.Add(Me.ApostadorLabel1)
        Me.Controls.Add(Me.ApuC1Label1)
        Me.Controls.Add(Me.ApuC2Label1)
        Me.Controls.Add(Me.ApuC3Label1)
        Me.Controls.Add(Me.ApuC4Label1)
        Me.Controls.Add(Me.ApuC5Label1)
        Me.Controls.Add(Me.ApuC6Label1)
        Me.Controls.Add(Me.ApuC7Label1)
        Me.Controls.Add(Me.ApuC8Label1)
        Me.Controls.Add(Me.ApuC9Label1)
        Me.Controls.Add(Me.ApuC10Label1)
        Me.Controls.Add(Me.ApuC11Label1)
        Me.Controls.Add(Me.ApuC12Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Ticket"
        CType(Me.VwTicketBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents VwTicketBindingSource As BindingSource
    Friend WithEvents BdSIGAP_DataSet As bdSIGAP_DataSet
    Friend WithEvents VwTicketTableAdapter As bdSIGAP_DataSetTableAdapters.VwTicketTableAdapter
    Friend WithEvents TableAdapterManager As bdSIGAP_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents NombreLabel1 As Label
    Friend WithEvents FechaLabel1 As Label
    Friend WithEvents NroCarreraLabel1 As Label
    Friend WithEvents PalcoLabel1 As Label
    Friend WithEvents NroCaballoLabel1 As Label
    Friend WithEvents CaballoNombreLabel1 As Label
    Friend WithEvents ImporteApuestaLabel1 As Label
    Friend WithEvents ApostadorLabel1 As Label
    Friend WithEvents ApuC1Label1 As Label
    Friend WithEvents ApuC2Label1 As Label
    Friend WithEvents ApuC3Label1 As Label
    Friend WithEvents ApuC4Label1 As Label
    Friend WithEvents ApuC5Label1 As Label
    Friend WithEvents ApuC6Label1 As Label
    Friend WithEvents ApuC7Label1 As Label
    Friend WithEvents ApuC8Label1 As Label
    Friend WithEvents ApuC9Label1 As Label
    Friend WithEvents ApuC10Label1 As Label
    Friend WithEvents ApuC11Label1 As Label
    Friend WithEvents ApuC12Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PremioLabel1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NroRemateLabel1 As Label
    Friend WithEvents Label7 As Label
End Class
