﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LiquidacionesPorRomaneaje
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbPorCuenta = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbNombreCliente = New System.Windows.Forms.ComboBox()
        Me.DtFechaLiquidacion = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbTipo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbIdLiquidacion = New System.Windows.Forms.TextBox()
        Me.TbIdOrden = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbPlanta = New System.Windows.Forms.ComboBox()
        Me.GbResumen = New System.Windows.Forms.GroupBox()
        Me.ChClaseMicros = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TbPorcentajeTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TbTotalHueso = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TbNumPacas = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TbNumBorregos = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbPacasPluma = New System.Windows.Forms.TextBox()
        Me.TbPorcentajeMerma = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbPorcentajeSemilla = New System.Windows.Forms.TextBox()
        Me.TbBorregosPluma = New System.Windows.Forms.TextBox()
        Me.TbPorcentajePluma = New System.Windows.Forms.TextBox()
        Me.TbMerma = New System.Windows.Forms.TextBox()
        Me.TbPluma = New System.Windows.Forms.TextBox()
        Me.TbSemilla = New System.Windows.Forms.TextBox()
        Me.TbComentarios = New System.Windows.Forms.TextBox()
        Me.GbComentarios = New System.Windows.Forms.GroupBox()
        Me.GbModulos = New System.Windows.Forms.GroupBox()
        Me.DgvModulos = New System.Windows.Forms.DataGridView()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MSMenu.SuspendLayout()
        Me.GbDatosGenerales.SuspendLayout()
        Me.GbResumen.SuspendLayout()
        Me.GbComentarios.SuspendLayout()
        Me.GbModulos.SuspendLayout()
        CType(Me.DgvModulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.ToolStripMenuItem1, Me.ImprimirToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(1400, 24)
        Me.MSMenu.TabIndex = 0
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(184, 20)
        Me.ConsultarToolStripMenuItem.Text = "Consultar Ordenes Por Liquidar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GbDatosGenerales
        '
        Me.GbDatosGenerales.Controls.Add(Me.Label7)
        Me.GbDatosGenerales.Controls.Add(Me.CbPorCuenta)
        Me.GbDatosGenerales.Controls.Add(Me.Label6)
        Me.GbDatosGenerales.Controls.Add(Me.Label5)
        Me.GbDatosGenerales.Controls.Add(Me.CbNombreCliente)
        Me.GbDatosGenerales.Controls.Add(Me.DtFechaLiquidacion)
        Me.GbDatosGenerales.Controls.Add(Me.Label4)
        Me.GbDatosGenerales.Controls.Add(Me.CbTipo)
        Me.GbDatosGenerales.Controls.Add(Me.Label3)
        Me.GbDatosGenerales.Controls.Add(Me.Label2)
        Me.GbDatosGenerales.Controls.Add(Me.TbIdLiquidacion)
        Me.GbDatosGenerales.Controls.Add(Me.TbIdOrden)
        Me.GbDatosGenerales.Controls.Add(Me.Label1)
        Me.GbDatosGenerales.Controls.Add(Me.CbPlanta)
        Me.GbDatosGenerales.Location = New System.Drawing.Point(12, 27)
        Me.GbDatosGenerales.Name = "GbDatosGenerales"
        Me.GbDatosGenerales.Size = New System.Drawing.Size(429, 220)
        Me.GbDatosGenerales.TabIndex = 1
        Me.GbDatosGenerales.TabStop = False
        Me.GbDatosGenerales.Text = "Datos Generales"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Por cuenta de"
        '
        'CbPorCuenta
        '
        Me.CbPorCuenta.Enabled = False
        Me.CbPorCuenta.FormattingEnabled = True
        Me.CbPorCuenta.Location = New System.Drawing.Point(116, 179)
        Me.CbPorCuenta.Name = "CbPorCuenta"
        Me.CbPorCuenta.Size = New System.Drawing.Size(303, 21)
        Me.CbPorCuenta.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Fecha"
        '
        'CbNombreCliente
        '
        Me.CbNombreCliente.Enabled = False
        Me.CbNombreCliente.FormattingEnabled = True
        Me.CbNombreCliente.Location = New System.Drawing.Point(116, 152)
        Me.CbNombreCliente.Name = "CbNombreCliente"
        Me.CbNombreCliente.Size = New System.Drawing.Size(303, 21)
        Me.CbNombreCliente.TabIndex = 9
        '
        'DtFechaLiquidacion
        '
        Me.DtFechaLiquidacion.Enabled = False
        Me.DtFechaLiquidacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaLiquidacion.Location = New System.Drawing.Point(116, 125)
        Me.DtFechaLiquidacion.Name = "DtFechaLiquidacion"
        Me.DtFechaLiquidacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DtFechaLiquidacion.Size = New System.Drawing.Size(200, 20)
        Me.DtFechaLiquidacion.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tipo"
        '
        'CbTipo
        '
        Me.CbTipo.Enabled = False
        Me.CbTipo.FormattingEnabled = True
        Me.CbTipo.Location = New System.Drawing.Point(116, 98)
        Me.CbTipo.Name = "CbTipo"
        Me.CbTipo.Size = New System.Drawing.Size(121, 21)
        Me.CbTipo.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Liquidacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ord. Prod."
        '
        'TbIdLiquidacion
        '
        Me.TbIdLiquidacion.Enabled = False
        Me.TbIdLiquidacion.Location = New System.Drawing.Point(116, 72)
        Me.TbIdLiquidacion.Name = "TbIdLiquidacion"
        Me.TbIdLiquidacion.Size = New System.Drawing.Size(100, 20)
        Me.TbIdLiquidacion.TabIndex = 3
        '
        'TbIdOrden
        '
        Me.TbIdOrden.Location = New System.Drawing.Point(116, 46)
        Me.TbIdOrden.Name = "TbIdOrden"
        Me.TbIdOrden.Size = New System.Drawing.Size(100, 20)
        Me.TbIdOrden.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Plantas"
        '
        'CbPlanta
        '
        Me.CbPlanta.Enabled = False
        Me.CbPlanta.FormattingEnabled = True
        Me.CbPlanta.Location = New System.Drawing.Point(116, 19)
        Me.CbPlanta.Name = "CbPlanta"
        Me.CbPlanta.Size = New System.Drawing.Size(121, 21)
        Me.CbPlanta.TabIndex = 0
        '
        'GbResumen
        '
        Me.GbResumen.Controls.Add(Me.ChClaseMicros)
        Me.GbResumen.Controls.Add(Me.Label16)
        Me.GbResumen.Controls.Add(Me.Label20)
        Me.GbResumen.Controls.Add(Me.Label19)
        Me.GbResumen.Controls.Add(Me.TbPorcentajeTotal)
        Me.GbResumen.Controls.Add(Me.Label12)
        Me.GbResumen.Controls.Add(Me.Label18)
        Me.GbResumen.Controls.Add(Me.TbTotalHueso)
        Me.GbResumen.Controls.Add(Me.Label17)
        Me.GbResumen.Controls.Add(Me.Label11)
        Me.GbResumen.Controls.Add(Me.TbNumPacas)
        Me.GbResumen.Controls.Add(Me.Label15)
        Me.GbResumen.Controls.Add(Me.Label10)
        Me.GbResumen.Controls.Add(Me.Label14)
        Me.GbResumen.Controls.Add(Me.TbNumBorregos)
        Me.GbResumen.Controls.Add(Me.Label13)
        Me.GbResumen.Controls.Add(Me.Label9)
        Me.GbResumen.Controls.Add(Me.TbPacasPluma)
        Me.GbResumen.Controls.Add(Me.TbPorcentajeMerma)
        Me.GbResumen.Controls.Add(Me.Label8)
        Me.GbResumen.Controls.Add(Me.TbPorcentajeSemilla)
        Me.GbResumen.Controls.Add(Me.TbBorregosPluma)
        Me.GbResumen.Controls.Add(Me.TbPorcentajePluma)
        Me.GbResumen.Controls.Add(Me.TbMerma)
        Me.GbResumen.Controls.Add(Me.TbPluma)
        Me.GbResumen.Controls.Add(Me.TbSemilla)
        Me.GbResumen.Location = New System.Drawing.Point(447, 27)
        Me.GbResumen.Name = "GbResumen"
        Me.GbResumen.Size = New System.Drawing.Size(408, 220)
        Me.GbResumen.TabIndex = 2
        Me.GbResumen.TabStop = False
        Me.GbResumen.Text = "Resumen"
        '
        'ChClaseMicros
        '
        Me.ChClaseMicros.AutoSize = True
        Me.ChClaseMicros.Location = New System.Drawing.Point(14, 197)
        Me.ChClaseMicros.Name = "ChClaseMicros"
        Me.ChClaseMicros.Size = New System.Drawing.Size(186, 17)
        Me.ChClaseMicros.TabIndex = 17
        Me.ChClaseMicros.Text = "Incluir Clases y Micros en Reporte"
        Me.ChClaseMicros.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(293, 100)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Total"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(379, 100)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(15, 13)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "%"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(379, 74)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(15, 13)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "%"
        '
        'TbPorcentajeTotal
        '
        Me.TbPorcentajeTotal.Enabled = False
        Me.TbPorcentajeTotal.Location = New System.Drawing.Point(330, 97)
        Me.TbPorcentajeTotal.Name = "TbPorcentajeTotal"
        Me.TbPorcentajeTotal.Size = New System.Drawing.Size(43, 20)
        Me.TbPorcentajeTotal.TabIndex = 9
        Me.TbPorcentajeTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 126)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Pluma (Borregos)"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(379, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(15, 13)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "%"
        '
        'TbTotalHueso
        '
        Me.TbTotalHueso.Enabled = False
        Me.TbTotalHueso.Location = New System.Drawing.Point(103, 19)
        Me.TbTotalHueso.Name = "TbTotalHueso"
        Me.TbTotalHueso.Size = New System.Drawing.Size(100, 20)
        Me.TbTotalHueso.TabIndex = 3
        Me.TbTotalHueso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(379, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(15, 13)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "%"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Pluma (Pacas)"
        '
        'TbNumPacas
        '
        Me.TbNumPacas.Enabled = False
        Me.TbNumPacas.Location = New System.Drawing.Point(103, 45)
        Me.TbNumPacas.Name = "TbNumPacas"
        Me.TbNumPacas.Size = New System.Drawing.Size(100, 20)
        Me.TbNumPacas.TabIndex = 4
        Me.TbNumPacas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(219, 74)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 13)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Merma"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Num. Borregos"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(219, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Semilla"
        '
        'TbNumBorregos
        '
        Me.TbNumBorregos.Enabled = False
        Me.TbNumBorregos.Location = New System.Drawing.Point(103, 71)
        Me.TbNumBorregos.Name = "TbNumBorregos"
        Me.TbNumBorregos.Size = New System.Drawing.Size(100, 20)
        Me.TbNumBorregos.TabIndex = 5
        Me.TbNumBorregos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(222, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 13)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Pluma"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Num. Pacas"
        '
        'TbPacasPluma
        '
        Me.TbPacasPluma.Enabled = False
        Me.TbPacasPluma.Location = New System.Drawing.Point(103, 97)
        Me.TbPacasPluma.Name = "TbPacasPluma"
        Me.TbPacasPluma.Size = New System.Drawing.Size(100, 20)
        Me.TbPacasPluma.TabIndex = 6
        Me.TbPacasPluma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbPorcentajeMerma
        '
        Me.TbPorcentajeMerma.Enabled = False
        Me.TbPorcentajeMerma.Location = New System.Drawing.Point(330, 71)
        Me.TbPorcentajeMerma.Name = "TbPorcentajeMerma"
        Me.TbPorcentajeMerma.Size = New System.Drawing.Size(43, 20)
        Me.TbPorcentajeMerma.TabIndex = 8
        Me.TbPorcentajeMerma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Total Hueso"
        '
        'TbPorcentajeSemilla
        '
        Me.TbPorcentajeSemilla.Enabled = False
        Me.TbPorcentajeSemilla.Location = New System.Drawing.Point(330, 45)
        Me.TbPorcentajeSemilla.Name = "TbPorcentajeSemilla"
        Me.TbPorcentajeSemilla.Size = New System.Drawing.Size(43, 20)
        Me.TbPorcentajeSemilla.TabIndex = 7
        Me.TbPorcentajeSemilla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbBorregosPluma
        '
        Me.TbBorregosPluma.Enabled = False
        Me.TbBorregosPluma.Location = New System.Drawing.Point(103, 123)
        Me.TbBorregosPluma.Name = "TbBorregosPluma"
        Me.TbBorregosPluma.Size = New System.Drawing.Size(100, 20)
        Me.TbBorregosPluma.TabIndex = 7
        Me.TbBorregosPluma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbPorcentajePluma
        '
        Me.TbPorcentajePluma.Enabled = False
        Me.TbPorcentajePluma.Location = New System.Drawing.Point(330, 19)
        Me.TbPorcentajePluma.Name = "TbPorcentajePluma"
        Me.TbPorcentajePluma.Size = New System.Drawing.Size(43, 20)
        Me.TbPorcentajePluma.TabIndex = 6
        Me.TbPorcentajePluma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbMerma
        '
        Me.TbMerma.Enabled = False
        Me.TbMerma.Location = New System.Drawing.Point(264, 71)
        Me.TbMerma.Name = "TbMerma"
        Me.TbMerma.Size = New System.Drawing.Size(60, 20)
        Me.TbMerma.TabIndex = 5
        Me.TbMerma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbPluma
        '
        Me.TbPluma.Enabled = False
        Me.TbPluma.Location = New System.Drawing.Point(264, 19)
        Me.TbPluma.Name = "TbPluma"
        Me.TbPluma.Size = New System.Drawing.Size(60, 20)
        Me.TbPluma.TabIndex = 3
        Me.TbPluma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbSemilla
        '
        Me.TbSemilla.Enabled = False
        Me.TbSemilla.Location = New System.Drawing.Point(265, 45)
        Me.TbSemilla.Name = "TbSemilla"
        Me.TbSemilla.Size = New System.Drawing.Size(59, 20)
        Me.TbSemilla.TabIndex = 4
        Me.TbSemilla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbComentarios
        '
        Me.TbComentarios.Location = New System.Drawing.Point(9, 19)
        Me.TbComentarios.Multiline = True
        Me.TbComentarios.Name = "TbComentarios"
        Me.TbComentarios.Size = New System.Drawing.Size(799, 85)
        Me.TbComentarios.TabIndex = 3
        '
        'GbComentarios
        '
        Me.GbComentarios.Controls.Add(Me.TbComentarios)
        Me.GbComentarios.Location = New System.Drawing.Point(12, 253)
        Me.GbComentarios.Name = "GbComentarios"
        Me.GbComentarios.Size = New System.Drawing.Size(843, 115)
        Me.GbComentarios.TabIndex = 4
        Me.GbComentarios.TabStop = False
        Me.GbComentarios.Text = "Comentarios"
        '
        'GbModulos
        '
        Me.GbModulos.Controls.Add(Me.DgvModulos)
        Me.GbModulos.Location = New System.Drawing.Point(861, 27)
        Me.GbModulos.Name = "GbModulos"
        Me.GbModulos.Size = New System.Drawing.Size(530, 478)
        Me.GbModulos.TabIndex = 5
        Me.GbModulos.TabStop = False
        Me.GbModulos.Text = "Modulos"
        '
        'DgvModulos
        '
        Me.DgvModulos.AllowUserToAddRows = False
        Me.DgvModulos.AllowUserToDeleteRows = False
        Me.DgvModulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvModulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvModulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvModulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvModulos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvModulos.Location = New System.Drawing.Point(6, 19)
        Me.DgvModulos.MultiSelect = False
        Me.DgvModulos.Name = "DgvModulos"
        Me.DgvModulos.ReadOnly = True
        Me.DgvModulos.RowHeadersVisible = False
        Me.DgvModulos.RowHeadersWidth = 40
        Me.DgvModulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvModulos.Size = New System.Drawing.Size(518, 453)
        Me.DgvModulos.TabIndex = 30
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(146, 20)
        Me.ToolStripMenuItem1.Text = "Consultar Liquidaciones"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'LiquidacionesPorRomaneaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1400, 517)
        Me.Controls.Add(Me.GbModulos)
        Me.Controls.Add(Me.GbComentarios)
        Me.Controls.Add(Me.GbResumen)
        Me.Controls.Add(Me.GbDatosGenerales)
        Me.Controls.Add(Me.MSMenu)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "LiquidacionesPorRomaneaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liquidaciones Por Romaneaje"
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.GbDatosGenerales.PerformLayout()
        Me.GbResumen.ResumeLayout(False)
        Me.GbResumen.PerformLayout()
        Me.GbComentarios.ResumeLayout(False)
        Me.GbComentarios.PerformLayout()
        Me.GbModulos.ResumeLayout(False)
        CType(Me.DgvModulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GbDatosGenerales As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CbNombreCliente As ComboBox
    Friend WithEvents DtFechaLiquidacion As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents CbTipo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TbIdLiquidacion As TextBox
    Friend WithEvents TbIdOrden As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CbPlanta As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CbPorCuenta As ComboBox
    Friend WithEvents GbResumen As GroupBox
    Friend WithEvents TbTotalHueso As TextBox
    Friend WithEvents TbNumPacas As TextBox
    Friend WithEvents TbNumBorregos As TextBox
    Friend WithEvents TbPacasPluma As TextBox
    Friend WithEvents TbBorregosPluma As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TbPorcentajeTotal As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TbPorcentajeMerma As TextBox
    Friend WithEvents TbPorcentajeSemilla As TextBox
    Friend WithEvents TbPorcentajePluma As TextBox
    Friend WithEvents TbMerma As TextBox
    Friend WithEvents TbPluma As TextBox
    Friend WithEvents TbSemilla As TextBox
    Friend WithEvents TbComentarios As TextBox
    Friend WithEvents GbComentarios As GroupBox
    Friend WithEvents GbModulos As GroupBox
    Friend WithEvents DgvModulos As DataGridView
    Friend WithEvents Label20 As Label
    Friend WithEvents ChClaseMicros As CheckBox
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
End Class
