﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemate
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdRemateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCarreraCaballoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroCaballoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApostadorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteApuestaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LuzDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FilaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ImportePremioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbDetalleRematesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdSIGAP_DataSet = New SIGAP.bdSIGAP_DataSet()
        Me.Tb_DetalleRematesTableAdapter = New SIGAP.bdSIGAP_DataSetTableAdapters.tb_DetalleRematesTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbDetalleRematesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdRemateDataGridViewTextBoxColumn, Me.IdCarreraCaballoDataGridViewTextBoxColumn, Me.NroCaballoDataGridViewTextBoxColumn, Me.ApostadorDataGridViewTextBoxColumn, Me.ImporteApuestaDataGridViewTextBoxColumn, Me.LuzDataGridViewTextBoxColumn, Me.FilaDataGridViewTextBoxColumn, Me.ImportePremioDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TbDetalleRematesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(2, 103)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(536, 218)
        Me.DataGridView1.TabIndex = 0
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
        Me.NroCaballoDataGridViewTextBoxColumn.HeaderText = "NroCaballo"
        Me.NroCaballoDataGridViewTextBoxColumn.Name = "NroCaballoDataGridViewTextBoxColumn"
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
        'BdSIGAP_DataSet
        '
        Me.BdSIGAP_DataSet.DataSetName = "bdSIGAP_DataSet"
        Me.BdSIGAP_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_DetalleRematesTableAdapter
        '
        Me.Tb_DetalleRematesTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(200, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(385, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Label5"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(243, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(44, 13)
        Me.lblTitulo.TabIndex = 6
        Me.lblTitulo.Text = "Remate"
        '
        'frmRemate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 362)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmRemate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remate"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbDetalleRematesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdSIGAP_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BdSIGAP_DataSet As bdSIGAP_DataSet
    Friend WithEvents TbDetalleRematesBindingSource As BindingSource
    Friend WithEvents Tb_DetalleRematesTableAdapter As bdSIGAP_DataSetTableAdapters.tb_DetalleRematesTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdRemateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCarreraCaballoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroCaballoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApostadorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteApuestaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LuzDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents FilaDataGridViewTextBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ImportePremioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTitulo As Label
End Class
