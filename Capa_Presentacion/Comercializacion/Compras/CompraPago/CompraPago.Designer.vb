﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CompraPago
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompraPago))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbTipoCambio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbPrecioQuintal = New System.Windows.Forms.TextBox()
        Me.TbIdProductor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbNombreProductor = New System.Windows.Forms.TextBox()
        Me.DgvResumenPagoPacas = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbTotalPacas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbTotalKilos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbEfectivo = New System.Windows.Forms.TextBox()
        Me.TbDolares = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbSubtotal = New System.Windows.Forms.TextBox()
        Me.TbDescuento = New System.Windows.Forms.TextBox()
        Me.TbTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GbPagoFinal = New System.Windows.Forms.GroupBox()
        Me.TbAnticipoDlls = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ChkBDolares = New System.Windows.Forms.CheckBox()
        Me.ChkBEfectivo = New System.Windows.Forms.CheckBox()
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.PagarItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpResumenDePacasItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpDetallesDeCompraItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpResumenDeLiquidacionesItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbCastigos = New System.Windows.Forms.GroupBox()
        Me.TbCastigoxresistencia = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TbCastigoxlargo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TbCastigoxmicro = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GbDatosGenerales = New System.Windows.Forms.GroupBox()
        CType(Me.DgvResumenPagoPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbPagoFinal.SuspendLayout()
        Me.MSMenu.SuspendLayout()
        Me.GbCastigos.SuspendLayout()
        Me.GbDatosGenerales.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TIpo de cambio"
        '
        'TbTipoCambio
        '
        Me.TbTipoCambio.Location = New System.Drawing.Point(143, 95)
        Me.TbTipoCambio.Name = "TbTipoCambio"
        Me.TbTipoCambio.Size = New System.Drawing.Size(145, 29)
        Me.TbTipoCambio.TabIndex = 1
        Me.TbTipoCambio.Text = "1.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Precio quintal"
        '
        'TbPrecioQuintal
        '
        Me.TbPrecioQuintal.Enabled = False
        Me.TbPrecioQuintal.Location = New System.Drawing.Point(99, 31)
        Me.TbPrecioQuintal.Name = "TbPrecioQuintal"
        Me.TbPrecioQuintal.Size = New System.Drawing.Size(100, 20)
        Me.TbPrecioQuintal.TabIndex = 3
        '
        'TbIdProductor
        '
        Me.TbIdProductor.Enabled = False
        Me.TbIdProductor.Location = New System.Drawing.Point(99, 57)
        Me.TbIdProductor.Name = "TbIdProductor"
        Me.TbIdProductor.Size = New System.Drawing.Size(100, 20)
        Me.TbIdProductor.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Id Productor"
        '
        'TbNombreProductor
        '
        Me.TbNombreProductor.Enabled = False
        Me.TbNombreProductor.Location = New System.Drawing.Point(205, 57)
        Me.TbNombreProductor.Name = "TbNombreProductor"
        Me.TbNombreProductor.Size = New System.Drawing.Size(441, 20)
        Me.TbNombreProductor.TabIndex = 6
        '
        'DgvResumenPagoPacas
        '
        Me.DgvResumenPagoPacas.AllowUserToAddRows = False
        Me.DgvResumenPagoPacas.AllowUserToDeleteRows = False
        Me.DgvResumenPagoPacas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvResumenPagoPacas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvResumenPagoPacas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvResumenPagoPacas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvResumenPagoPacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvResumenPagoPacas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvResumenPagoPacas.Location = New System.Drawing.Point(7, 83)
        Me.DgvResumenPagoPacas.MultiSelect = False
        Me.DgvResumenPagoPacas.Name = "DgvResumenPagoPacas"
        Me.DgvResumenPagoPacas.RowHeadersVisible = False
        Me.DgvResumenPagoPacas.RowHeadersWidth = 40
        Me.DgvResumenPagoPacas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvResumenPagoPacas.Size = New System.Drawing.Size(639, 239)
        Me.DgvResumenPagoPacas.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 18)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Total de pacas"
        '
        'TbTotalPacas
        '
        Me.TbTotalPacas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbTotalPacas.Location = New System.Drawing.Point(9, 55)
        Me.TbTotalPacas.Name = "TbTotalPacas"
        Me.TbTotalPacas.Size = New System.Drawing.Size(212, 26)
        Me.TbTotalPacas.TabIndex = 15
        Me.TbTotalPacas.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 18)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Total de kilos"
        '
        'TbTotalKilos
        '
        Me.TbTotalKilos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbTotalKilos.Location = New System.Drawing.Point(9, 110)
        Me.TbTotalKilos.Name = "TbTotalKilos"
        Me.TbTotalKilos.Size = New System.Drawing.Size(212, 26)
        Me.TbTotalKilos.TabIndex = 17
        Me.TbTotalKilos.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 18)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Efectivo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 18)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Dolares"
        '
        'TbEfectivo
        '
        Me.TbEfectivo.Enabled = False
        Me.TbEfectivo.Location = New System.Drawing.Point(144, 25)
        Me.TbEfectivo.Name = "TbEfectivo"
        Me.TbEfectivo.Size = New System.Drawing.Size(145, 29)
        Me.TbEfectivo.TabIndex = 20
        Me.TbEfectivo.Text = "0"
        '
        'TbDolares
        '
        Me.TbDolares.Location = New System.Drawing.Point(143, 60)
        Me.TbDolares.Name = "TbDolares"
        Me.TbDolares.Size = New System.Drawing.Size(145, 29)
        Me.TbDolares.TabIndex = 21
        Me.TbDolares.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(395, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 18)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Subtotal"
        '
        'TbSubtotal
        '
        Me.TbSubtotal.Location = New System.Drawing.Point(488, 19)
        Me.TbSubtotal.Name = "TbSubtotal"
        Me.TbSubtotal.Size = New System.Drawing.Size(145, 29)
        Me.TbSubtotal.TabIndex = 23
        Me.TbSubtotal.Text = "0"
        '
        'TbDescuento
        '
        Me.TbDescuento.Location = New System.Drawing.Point(488, 54)
        Me.TbDescuento.Name = "TbDescuento"
        Me.TbDescuento.Size = New System.Drawing.Size(145, 29)
        Me.TbDescuento.TabIndex = 24
        Me.TbDescuento.Text = "0"
        '
        'TbTotal
        '
        Me.TbTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbTotal.Location = New System.Drawing.Point(488, 134)
        Me.TbTotal.Multiline = True
        Me.TbTotal.Name = "TbTotal"
        Me.TbTotal.Size = New System.Drawing.Size(145, 34)
        Me.TbTotal.TabIndex = 25
        Me.TbTotal.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(395, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 18)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Descuento"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(402, 134)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 31)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Total"
        '
        'GbPagoFinal
        '
        Me.GbPagoFinal.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GbPagoFinal.Controls.Add(Me.TbAnticipoDlls)
        Me.GbPagoFinal.Controls.Add(Me.Label11)
        Me.GbPagoFinal.Controls.Add(Me.ChkBDolares)
        Me.GbPagoFinal.Controls.Add(Me.ChkBEfectivo)
        Me.GbPagoFinal.Controls.Add(Me.TbSubtotal)
        Me.GbPagoFinal.Controls.Add(Me.Label10)
        Me.GbPagoFinal.Controls.Add(Me.Label1)
        Me.GbPagoFinal.Controls.Add(Me.Label9)
        Me.GbPagoFinal.Controls.Add(Me.TbTipoCambio)
        Me.GbPagoFinal.Controls.Add(Me.TbTotal)
        Me.GbPagoFinal.Controls.Add(Me.Label6)
        Me.GbPagoFinal.Controls.Add(Me.TbDescuento)
        Me.GbPagoFinal.Controls.Add(Me.Label7)
        Me.GbPagoFinal.Controls.Add(Me.TbEfectivo)
        Me.GbPagoFinal.Controls.Add(Me.Label8)
        Me.GbPagoFinal.Controls.Add(Me.TbDolares)
        Me.GbPagoFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbPagoFinal.Location = New System.Drawing.Point(7, 354)
        Me.GbPagoFinal.Name = "GbPagoFinal"
        Me.GbPagoFinal.Size = New System.Drawing.Size(639, 174)
        Me.GbPagoFinal.TabIndex = 28
        Me.GbPagoFinal.TabStop = False
        Me.GbPagoFinal.Text = "Resumen de la compra"
        '
        'TbAnticipoDlls
        '
        Me.TbAnticipoDlls.Location = New System.Drawing.Point(143, 130)
        Me.TbAnticipoDlls.Name = "TbAnticipoDlls"
        Me.TbAnticipoDlls.Size = New System.Drawing.Size(146, 29)
        Me.TbAnticipoDlls.TabIndex = 31
        Me.TbAnticipoDlls.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 18)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Ant. Dolares"
        '
        'ChkBDolares
        '
        Me.ChkBDolares.AutoSize = True
        Me.ChkBDolares.Checked = True
        Me.ChkBDolares.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkBDolares.Location = New System.Drawing.Point(294, 60)
        Me.ChkBDolares.Name = "ChkBDolares"
        Me.ChkBDolares.Size = New System.Drawing.Size(15, 14)
        Me.ChkBDolares.TabIndex = 29
        Me.ChkBDolares.UseVisualStyleBackColor = True
        '
        'ChkBEfectivo
        '
        Me.ChkBEfectivo.AutoSize = True
        Me.ChkBEfectivo.Location = New System.Drawing.Point(295, 27)
        Me.ChkBEfectivo.Name = "ChkBEfectivo"
        Me.ChkBEfectivo.Size = New System.Drawing.Size(15, 14)
        Me.ChkBEfectivo.TabIndex = 28
        Me.ChkBEfectivo.UseVisualStyleBackColor = True
        '
        'MSMenu
        '
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PagarItem, Me.ImpResumenDePacasItem, Me.ImpDetallesDeCompraItem, Me.ImpResumenDeLiquidacionesItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(886, 24)
        Me.MSMenu.TabIndex = 29
        Me.MSMenu.Text = "MenuStrip1"
        '
        'PagarItem
        '
        Me.PagarItem.Name = "PagarItem"
        Me.PagarItem.Size = New System.Drawing.Size(49, 20)
        Me.PagarItem.Text = "Pagar"
        '
        'ImpResumenDePacasItem
        '
        Me.ImpResumenDePacasItem.Name = "ImpResumenDePacasItem"
        Me.ImpResumenDePacasItem.Size = New System.Drawing.Size(141, 20)
        Me.ImpResumenDePacasItem.Text = "Imp.Resumen de Pacas"
        '
        'ImpDetallesDeCompraItem
        '
        Me.ImpDetallesDeCompraItem.Name = "ImpDetallesDeCompraItem"
        Me.ImpDetallesDeCompraItem.Size = New System.Drawing.Size(146, 20)
        Me.ImpDetallesDeCompraItem.Text = "Imp.Detalles de Compra"
        '
        'ImpResumenDeLiquidacionesItem
        '
        Me.ImpResumenDeLiquidacionesItem.Name = "ImpResumenDeLiquidacionesItem"
        Me.ImpResumenDeLiquidacionesItem.Size = New System.Drawing.Size(184, 20)
        Me.ImpResumenDeLiquidacionesItem.Text = "Imp.Resumen de Liquidaciones"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GbCastigos
        '
        Me.GbCastigos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GbCastigos.Controls.Add(Me.TbCastigoxresistencia)
        Me.GbCastigos.Controls.Add(Me.Label14)
        Me.GbCastigos.Controls.Add(Me.TbCastigoxlargo)
        Me.GbCastigos.Controls.Add(Me.Label13)
        Me.GbCastigos.Controls.Add(Me.TbCastigoxmicro)
        Me.GbCastigos.Controls.Add(Me.Label12)
        Me.GbCastigos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbCastigos.Location = New System.Drawing.Point(0, 297)
        Me.GbCastigos.Name = "GbCastigos"
        Me.GbCastigos.Size = New System.Drawing.Size(227, 174)
        Me.GbCastigos.TabIndex = 30
        Me.GbCastigos.TabStop = False
        Me.GbCastigos.Text = "Castigos"
        '
        'TbCastigoxresistencia
        '
        Me.TbCastigoxresistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCastigoxresistencia.Location = New System.Drawing.Point(9, 131)
        Me.TbCastigoxresistencia.Name = "TbCastigoxresistencia"
        Me.TbCastigoxresistencia.Size = New System.Drawing.Size(212, 22)
        Me.TbCastigoxresistencia.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 115)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(151, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Castigo por resistencia de fibra"
        '
        'TbCastigoxlargo
        '
        Me.TbCastigoxlargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCastigoxlargo.Location = New System.Drawing.Point(9, 86)
        Me.TbCastigoxlargo.Name = "TbCastigoxlargo"
        Me.TbCastigoxlargo.Size = New System.Drawing.Size(212, 22)
        Me.TbCastigoxlargo.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Castigo por largo de fibra"
        '
        'TbCastigoxmicro
        '
        Me.TbCastigoxmicro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCastigoxmicro.Location = New System.Drawing.Point(9, 41)
        Me.TbCastigoxmicro.Name = "TbCastigoxmicro"
        Me.TbCastigoxmicro.Size = New System.Drawing.Size(212, 22)
        Me.TbCastigoxmicro.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Castigo por micros"
        '
        'GbDatosGenerales
        '
        Me.GbDatosGenerales.BackColor = System.Drawing.Color.Gainsboro
        Me.GbDatosGenerales.Controls.Add(Me.Label4)
        Me.GbDatosGenerales.Controls.Add(Me.GbCastigos)
        Me.GbDatosGenerales.Controls.Add(Me.TbTotalPacas)
        Me.GbDatosGenerales.Controls.Add(Me.TbTotalKilos)
        Me.GbDatosGenerales.Controls.Add(Me.Label5)
        Me.GbDatosGenerales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbDatosGenerales.Location = New System.Drawing.Point(652, 57)
        Me.GbDatosGenerales.Name = "GbDatosGenerales"
        Me.GbDatosGenerales.Size = New System.Drawing.Size(227, 471)
        Me.GbDatosGenerales.TabIndex = 6
        Me.GbDatosGenerales.TabStop = False
        Me.GbDatosGenerales.Text = "Datos Generales"
        '
        'CompraPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(886, 542)
        Me.Controls.Add(Me.GbDatosGenerales)
        Me.Controls.Add(Me.GbPagoFinal)
        Me.Controls.Add(Me.DgvResumenPagoPacas)
        Me.Controls.Add(Me.TbNombreProductor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbIdProductor)
        Me.Controls.Add(Me.TbPrecioQuintal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MSMenu)
        Me.MainMenuStrip = Me.MSMenu
        Me.MaximizeBox = False
        Me.Name = "CompraPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Metodo de pago"
        CType(Me.DgvResumenPagoPacas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbPagoFinal.ResumeLayout(False)
        Me.GbPagoFinal.PerformLayout()
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.GbCastigos.ResumeLayout(False)
        Me.GbCastigos.PerformLayout()
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.GbDatosGenerales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TbTipoCambio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbPrecioQuintal As TextBox
    Friend WithEvents TbIdProductor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbNombreProductor As TextBox
    Friend WithEvents DgvResumenPagoPacas As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents TbTotalPacas As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TbTotalKilos As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TbEfectivo As TextBox
    Friend WithEvents TbDolares As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TbSubtotal As TextBox
    Friend WithEvents TbDescuento As TextBox
    Friend WithEvents TbTotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GbPagoFinal As GroupBox
    Friend WithEvents ChkBDolares As CheckBox
    Friend WithEvents ChkBEfectivo As CheckBox
    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents PagarItem As ToolStripMenuItem
    Friend WithEvents ImpResumenDePacasItem As ToolStripMenuItem
    Friend WithEvents ImpDetallesDeCompraItem As ToolStripMenuItem
    Friend WithEvents ImpResumenDeLiquidacionesItem As ToolStripMenuItem
    Friend WithEvents TbAnticipoDlls As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GbCastigos As GroupBox
    Friend WithEvents TbCastigoxresistencia As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TbCastigoxlargo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TbCastigoxmicro As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GbDatosGenerales As GroupBox
End Class
