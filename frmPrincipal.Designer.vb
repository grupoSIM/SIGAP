<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ParámetrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HipódromoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JornadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarrerasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PalcosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarrerasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarCarreraCaballosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RematesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarRematesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RematadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParámetrosToolStripMenuItem, Me.CarrerasToolStripMenuItem1, Me.RematesToolStripMenuItem, Me.ConsultasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(629, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ParámetrosToolStripMenuItem
        '
        Me.ParámetrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HipódromoToolStripMenuItem, Me.JornadasToolStripMenuItem, Me.CarrerasToolStripMenuItem, Me.PalcosToolStripMenuItem, Me.RematadorToolStripMenuItem})
        Me.ParámetrosToolStripMenuItem.Name = "ParámetrosToolStripMenuItem"
        Me.ParámetrosToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.ParámetrosToolStripMenuItem.Text = "Parámetros"
        '
        'HipódromoToolStripMenuItem
        '
        Me.HipódromoToolStripMenuItem.Name = "HipódromoToolStripMenuItem"
        Me.HipódromoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HipódromoToolStripMenuItem.Text = "Hipódromos"
        '
        'JornadasToolStripMenuItem
        '
        Me.JornadasToolStripMenuItem.Name = "JornadasToolStripMenuItem"
        Me.JornadasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.JornadasToolStripMenuItem.Text = "Jornadas"
        '
        'CarrerasToolStripMenuItem
        '
        Me.CarrerasToolStripMenuItem.Name = "CarrerasToolStripMenuItem"
        Me.CarrerasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CarrerasToolStripMenuItem.Text = "Caballos"
        '
        'PalcosToolStripMenuItem
        '
        Me.PalcosToolStripMenuItem.Name = "PalcosToolStripMenuItem"
        Me.PalcosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PalcosToolStripMenuItem.Text = "Palcos"
        '
        'CarrerasToolStripMenuItem1
        '
        Me.CarrerasToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarCarreraCaballosToolStripMenuItem})
        Me.CarrerasToolStripMenuItem1.Name = "CarrerasToolStripMenuItem1"
        Me.CarrerasToolStripMenuItem1.Size = New System.Drawing.Size(62, 20)
        Me.CarrerasToolStripMenuItem1.Text = "Carreras"
        '
        'CargarCarreraCaballosToolStripMenuItem
        '
        Me.CargarCarreraCaballosToolStripMenuItem.Name = "CargarCarreraCaballosToolStripMenuItem"
        Me.CargarCarreraCaballosToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.CargarCarreraCaballosToolStripMenuItem.Text = "Cargar carrera / caballos"
        '
        'RematesToolStripMenuItem
        '
        Me.RematesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarRematesToolStripMenuItem})
        Me.RematesToolStripMenuItem.Name = "RematesToolStripMenuItem"
        Me.RematesToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.RematesToolStripMenuItem.Text = "Remates"
        '
        'CargarRematesToolStripMenuItem
        '
        Me.CargarRematesToolStripMenuItem.Name = "CargarRematesToolStripMenuItem"
        Me.CargarRematesToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CargarRematesToolStripMenuItem.Text = "Cargar Remates"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'RematadorToolStripMenuItem
        '
        Me.RematadorToolStripMenuItem.Name = "RematadorToolStripMenuItem"
        Me.RematadorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RematadorToolStripMenuItem.Text = "Rematador"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 354)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "SiGAp"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ParámetrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HipódromoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RematesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarRematesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JornadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CarrerasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CarrerasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CargarCarreraCaballosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PalcosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RematadorToolStripMenuItem As ToolStripMenuItem
End Class
