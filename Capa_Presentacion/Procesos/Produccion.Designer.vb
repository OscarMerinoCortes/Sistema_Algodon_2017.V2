﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Produccion
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
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbIdProduccion = New System.Windows.Forms.TextBox()
        Me.CbPlantaOrigen = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBPlantaElabora = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpFechaProduccion = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbTipo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.TbIdOrdenTrabajo = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TbNombreProductor = New System.Windows.Forms.TextBox()
        Me.TbPorCuentaDe = New System.Windows.Forms.TextBox()
        Me.TbIdProductor = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.BtAbrirProduccion = New System.Windows.Forms.Button()
        Me.BtCerrarProduccion = New System.Windows.Forms.Button()
        Me.TbFolioCIA = New System.Windows.Forms.TextBox()
        Me.TbKilos = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.BtActualizarFolio = New System.Windows.Forms.Button()
        Me.GbDatosProduccion = New System.Windows.Forms.GroupBox()
        Me.TbFolioInicial = New System.Windows.Forms.TextBox()
        Me.CbTipoProducto = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CbOperador = New System.Windows.Forms.ComboBox()
        Me.CbTurno = New System.Windows.Forms.ComboBox()
        Me.GbModulos = New System.Windows.Forms.GroupBox()
        Me.TbTotalModulos = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TbModulos = New System.Windows.Forms.TextBox()
        Me.BtActivarPrensa = New System.Windows.Forms.Button()
        Me.BtAgregarExcel = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.BtImprimir = New System.Windows.Forms.Button()
        Me.BtIncidencias = New System.Windows.Forms.Button()
        Me.GbCapturaAutomatica = New System.Windows.Forms.GroupBox()
        Me.GbLotes = New System.Windows.Forms.GroupBox()
        Me.BtFin = New System.Windows.Forms.Button()
        Me.BtInicio = New System.Windows.Forms.Button()
        Me.BtSiguiente = New System.Windows.Forms.Button()
        Me.BtAnterior = New System.Windows.Forms.Button()
        Me.DgvPacas = New System.Windows.Forms.DataGridView()
        Me.GbTipoCaptura = New System.Windows.Forms.GroupBox()
        Me.RbAutomatico = New System.Windows.Forms.RadioButton()
        Me.RbManual = New System.Windows.Forms.RadioButton()
        Me.MSMenu.SuspendLayout()
        Me.GbDatosGenerales.SuspendLayout()
        Me.GbDatosProduccion.SuspendLayout()
        Me.GbModulos.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbCapturaAutomatica.SuspendLayout()
        Me.GbLotes.SuspendLayout()
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbTipoCaptura.SuspendLayout()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(1076, 24)
        Me.MSMenu.TabIndex = 0
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'TbIdProduccion
        '
        Me.TbIdProduccion.Enabled = False
        Me.TbIdProduccion.Location = New System.Drawing.Point(130, 19)
        Me.TbIdProduccion.Name = "TbIdProduccion"
        Me.TbIdProduccion.Size = New System.Drawing.Size(71, 20)
        Me.TbIdProduccion.TabIndex = 2
        '
        'CbPlantaOrigen
        '
        Me.CbPlantaOrigen.FormattingEnabled = True
        Me.CbPlantaOrigen.Location = New System.Drawing.Point(130, 45)
        Me.CbPlantaOrigen.Name = "CbPlantaOrigen"
        Me.CbPlantaOrigen.Size = New System.Drawing.Size(200, 21)
        Me.CbPlantaOrigen.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Planta Origen"
        '
        'CBPlantaElabora
        '
        Me.CBPlantaElabora.Enabled = False
        Me.CBPlantaElabora.FormattingEnabled = True
        Me.CBPlantaElabora.Location = New System.Drawing.Point(130, 72)
        Me.CBPlantaElabora.Name = "CBPlantaElabora"
        Me.CBPlantaElabora.Size = New System.Drawing.Size(200, 21)
        Me.CBPlantaElabora.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Planta Destino"
        '
        'DtpFechaProduccion
        '
        Me.DtpFechaProduccion.Location = New System.Drawing.Point(130, 99)
        Me.DtpFechaProduccion.Name = "DtpFechaProduccion"
        Me.DtpFechaProduccion.Size = New System.Drawing.Size(200, 20)
        Me.DtpFechaProduccion.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha"
        '
        'CbTipo
        '
        Me.CbTipo.Enabled = False
        Me.CbTipo.FormattingEnabled = True
        Me.CbTipo.Location = New System.Drawing.Point(130, 125)
        Me.CbTipo.Name = "CbTipo"
        Me.CbTipo.Size = New System.Drawing.Size(121, 21)
        Me.CbTipo.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tipo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Productor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Por Cuenta de"
        '
        'GbDatosGenerales
        '
        Me.GbDatosGenerales.Controls.Add(Me.TbIdOrdenTrabajo)
        Me.GbDatosGenerales.Controls.Add(Me.Label26)
        Me.GbDatosGenerales.Controls.Add(Me.TbNombreProductor)
        Me.GbDatosGenerales.Controls.Add(Me.TbPorCuentaDe)
        Me.GbDatosGenerales.Controls.Add(Me.TbIdProductor)
        Me.GbDatosGenerales.Controls.Add(Me.CbPlantaOrigen)
        Me.GbDatosGenerales.Controls.Add(Me.Label7)
        Me.GbDatosGenerales.Controls.Add(Me.Label1)
        Me.GbDatosGenerales.Controls.Add(Me.TbIdProduccion)
        Me.GbDatosGenerales.Controls.Add(Me.Label6)
        Me.GbDatosGenerales.Controls.Add(Me.Label2)
        Me.GbDatosGenerales.Controls.Add(Me.CBPlantaElabora)
        Me.GbDatosGenerales.Controls.Add(Me.Label5)
        Me.GbDatosGenerales.Controls.Add(Me.Label3)
        Me.GbDatosGenerales.Controls.Add(Me.CbTipo)
        Me.GbDatosGenerales.Controls.Add(Me.DtpFechaProduccion)
        Me.GbDatosGenerales.Controls.Add(Me.Label4)
        Me.GbDatosGenerales.Location = New System.Drawing.Point(12, 27)
        Me.GbDatosGenerales.Name = "GbDatosGenerales"
        Me.GbDatosGenerales.Size = New System.Drawing.Size(424, 208)
        Me.GbDatosGenerales.TabIndex = 15
        Me.GbDatosGenerales.TabStop = False
        Me.GbDatosGenerales.Text = "Datos Generales"
        '
        'TbIdOrdenTrabajo
        '
        Me.TbIdOrdenTrabajo.Location = New System.Drawing.Point(263, 19)
        Me.TbIdOrdenTrabajo.Name = "TbIdOrdenTrabajo"
        Me.TbIdOrdenTrabajo.Size = New System.Drawing.Size(143, 20)
        Me.TbIdOrdenTrabajo.TabIndex = 60
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(207, 24)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(50, 13)
        Me.Label26.TabIndex = 59
        Me.Label26.Text = "ID Orden"
        '
        'TbNombreProductor
        '
        Me.TbNombreProductor.Enabled = False
        Me.TbNombreProductor.Location = New System.Drawing.Point(192, 152)
        Me.TbNombreProductor.Name = "TbNombreProductor"
        Me.TbNombreProductor.Size = New System.Drawing.Size(226, 20)
        Me.TbNombreProductor.TabIndex = 58
        '
        'TbPorCuentaDe
        '
        Me.TbPorCuentaDe.Enabled = False
        Me.TbPorCuentaDe.Location = New System.Drawing.Point(130, 178)
        Me.TbPorCuentaDe.Name = "TbPorCuentaDe"
        Me.TbPorCuentaDe.Size = New System.Drawing.Size(288, 20)
        Me.TbPorCuentaDe.TabIndex = 57
        Me.TbPorCuentaDe.Text = "ALGODONERA NUEVA HOLANDA"
        '
        'TbIdProductor
        '
        Me.TbIdProductor.Enabled = False
        Me.TbIdProductor.Location = New System.Drawing.Point(130, 152)
        Me.TbIdProductor.Name = "TbIdProductor"
        Me.TbIdProductor.Size = New System.Drawing.Size(56, 20)
        Me.TbIdProductor.TabIndex = 15
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 13)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "Turno"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(9, 48)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(28, 13)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "Tipo"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(9, 74)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(51, 13)
        Me.Label21.TabIndex = 44
        Me.Label21.Text = "Operador"
        '
        'BtAbrirProduccion
        '
        Me.BtAbrirProduccion.Location = New System.Drawing.Point(12, 169)
        Me.BtAbrirProduccion.Name = "BtAbrirProduccion"
        Me.BtAbrirProduccion.Size = New System.Drawing.Size(95, 23)
        Me.BtAbrirProduccion.TabIndex = 45
        Me.BtAbrirProduccion.Text = "Abrir Produccion"
        Me.BtAbrirProduccion.UseVisualStyleBackColor = True
        '
        'BtCerrarProduccion
        '
        Me.BtCerrarProduccion.Location = New System.Drawing.Point(115, 169)
        Me.BtCerrarProduccion.Name = "BtCerrarProduccion"
        Me.BtCerrarProduccion.Size = New System.Drawing.Size(100, 23)
        Me.BtCerrarProduccion.TabIndex = 46
        Me.BtCerrarProduccion.Text = "Cerrar Produccion"
        Me.BtCerrarProduccion.UseVisualStyleBackColor = True
        '
        'TbFolioCIA
        '
        Me.TbFolioCIA.Location = New System.Drawing.Point(807, 134)
        Me.TbFolioCIA.Name = "TbFolioCIA"
        Me.TbFolioCIA.Size = New System.Drawing.Size(121, 20)
        Me.TbFolioCIA.TabIndex = 47
        '
        'TbKilos
        '
        Me.TbKilos.Location = New System.Drawing.Point(807, 160)
        Me.TbKilos.Multiline = True
        Me.TbKilos.Name = "TbKilos"
        Me.TbKilos.Size = New System.Drawing.Size(121, 27)
        Me.TbKilos.TabIndex = 49
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(705, 130)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 24)
        Me.Label22.TabIndex = 50
        Me.Label22.Text = "Folio CIA"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(746, 160)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(55, 24)
        Me.Label24.TabIndex = 52
        Me.Label24.Text = "Kilos"
        '
        'BtActualizarFolio
        '
        Me.BtActualizarFolio.Location = New System.Drawing.Point(186, 128)
        Me.BtActualizarFolio.Name = "BtActualizarFolio"
        Me.BtActualizarFolio.Size = New System.Drawing.Size(64, 23)
        Me.BtActualizarFolio.TabIndex = 53
        Me.BtActualizarFolio.Text = "Actualizar"
        Me.BtActualizarFolio.UseVisualStyleBackColor = True
        '
        'GbDatosProduccion
        '
        Me.GbDatosProduccion.Controls.Add(Me.TbFolioInicial)
        Me.GbDatosProduccion.Controls.Add(Me.CbTipoProducto)
        Me.GbDatosProduccion.Controls.Add(Me.Label8)
        Me.GbDatosProduccion.Controls.Add(Me.CbOperador)
        Me.GbDatosProduccion.Controls.Add(Me.CbTurno)
        Me.GbDatosProduccion.Controls.Add(Me.BtActualizarFolio)
        Me.GbDatosProduccion.Controls.Add(Me.Label19)
        Me.GbDatosProduccion.Controls.Add(Me.Label20)
        Me.GbDatosProduccion.Controls.Add(Me.Label21)
        Me.GbDatosProduccion.Controls.Add(Me.BtAbrirProduccion)
        Me.GbDatosProduccion.Controls.Add(Me.BtCerrarProduccion)
        Me.GbDatosProduccion.Location = New System.Drawing.Point(442, 30)
        Me.GbDatosProduccion.Name = "GbDatosProduccion"
        Me.GbDatosProduccion.Size = New System.Drawing.Size(256, 205)
        Me.GbDatosProduccion.TabIndex = 54
        Me.GbDatosProduccion.TabStop = False
        Me.GbDatosProduccion.Text = "Datos de Produccion"
        '
        'TbFolioInicial
        '
        Me.TbFolioInicial.Location = New System.Drawing.Point(6, 125)
        Me.TbFolioInicial.Multiline = True
        Me.TbFolioInicial.Name = "TbFolioInicial"
        Me.TbFolioInicial.Size = New System.Drawing.Size(174, 27)
        Me.TbFolioInicial.TabIndex = 57
        '
        'CbTipoProducto
        '
        Me.CbTipoProducto.FormattingEnabled = True
        Me.CbTipoProducto.Items.AddRange(New Object() {"PACA"})
        Me.CbTipoProducto.Location = New System.Drawing.Point(115, 42)
        Me.CbTipoProducto.Name = "CbTipoProducto"
        Me.CbTipoProducto.Size = New System.Drawing.Size(121, 21)
        Me.CbTipoProducto.TabIndex = 56
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 24)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Folio Inicial"
        '
        'CbOperador
        '
        Me.CbOperador.FormattingEnabled = True
        Me.CbOperador.Location = New System.Drawing.Point(115, 71)
        Me.CbOperador.Name = "CbOperador"
        Me.CbOperador.Size = New System.Drawing.Size(121, 21)
        Me.CbOperador.TabIndex = 55
        '
        'CbTurno
        '
        Me.CbTurno.FormattingEnabled = True
        Me.CbTurno.Location = New System.Drawing.Point(115, 18)
        Me.CbTurno.Name = "CbTurno"
        Me.CbTurno.Size = New System.Drawing.Size(121, 21)
        Me.CbTurno.TabIndex = 54
        '
        'GbModulos
        '
        Me.GbModulos.Controls.Add(Me.TbTotalModulos)
        Me.GbModulos.Controls.Add(Me.Label25)
        Me.GbModulos.Controls.Add(Me.TbModulos)
        Me.GbModulos.Location = New System.Drawing.Point(12, 241)
        Me.GbModulos.Name = "GbModulos"
        Me.GbModulos.Size = New System.Drawing.Size(1052, 124)
        Me.GbModulos.TabIndex = 55
        Me.GbModulos.TabStop = False
        Me.GbModulos.Text = "Modulos"
        '
        'TbTotalModulos
        '
        Me.TbTotalModulos.Enabled = False
        Me.TbTotalModulos.Location = New System.Drawing.Point(101, 97)
        Me.TbTotalModulos.Name = "TbTotalModulos"
        Me.TbTotalModulos.Size = New System.Drawing.Size(100, 20)
        Me.TbTotalModulos.TabIndex = 56
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 100)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(89, 13)
        Me.Label25.TabIndex = 56
        Me.Label25.Text = "Total de Modulos"
        '
        'TbModulos
        '
        Me.TbModulos.Enabled = False
        Me.TbModulos.Location = New System.Drawing.Point(6, 19)
        Me.TbModulos.Multiline = True
        Me.TbModulos.Name = "TbModulos"
        Me.TbModulos.Size = New System.Drawing.Size(1039, 72)
        Me.TbModulos.TabIndex = 0
        '
        'BtActivarPrensa
        '
        Me.BtActivarPrensa.Location = New System.Drawing.Point(6, 19)
        Me.BtActivarPrensa.Name = "BtActivarPrensa"
        Me.BtActivarPrensa.Size = New System.Drawing.Size(305, 29)
        Me.BtActivarPrensa.TabIndex = 57
        Me.BtActivarPrensa.Text = "Activar Lectura de Prensa"
        Me.BtActivarPrensa.UseVisualStyleBackColor = True
        '
        'BtAgregarExcel
        '
        Me.BtAgregarExcel.Location = New System.Drawing.Point(6, 54)
        Me.BtAgregarExcel.Name = "BtAgregarExcel"
        Me.BtAgregarExcel.Size = New System.Drawing.Size(305, 29)
        Me.BtAgregarExcel.TabIndex = 58
        Me.BtAgregarExcel.Text = "Agregar Pacas desde Archivo de Excel"
        Me.BtAgregarExcel.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(6, 89)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 59
        '
        'BtImprimir
        '
        Me.BtImprimir.Location = New System.Drawing.Point(127, 86)
        Me.BtImprimir.Name = "BtImprimir"
        Me.BtImprimir.Size = New System.Drawing.Size(184, 23)
        Me.BtImprimir.TabIndex = 60
        Me.BtImprimir.Text = "Imprimir"
        Me.BtImprimir.UseVisualStyleBackColor = True
        '
        'BtIncidencias
        '
        Me.BtIncidencias.Location = New System.Drawing.Point(6, 115)
        Me.BtIncidencias.Name = "BtIncidencias"
        Me.BtIncidencias.Size = New System.Drawing.Size(305, 29)
        Me.BtIncidencias.TabIndex = 61
        Me.BtIncidencias.Text = "Incidencias"
        Me.BtIncidencias.UseVisualStyleBackColor = True
        '
        'GbCapturaAutomatica
        '
        Me.GbCapturaAutomatica.Controls.Add(Me.BtActivarPrensa)
        Me.GbCapturaAutomatica.Controls.Add(Me.BtIncidencias)
        Me.GbCapturaAutomatica.Controls.Add(Me.BtAgregarExcel)
        Me.GbCapturaAutomatica.Controls.Add(Me.BtImprimir)
        Me.GbCapturaAutomatica.Controls.Add(Me.NumericUpDown1)
        Me.GbCapturaAutomatica.Location = New System.Drawing.Point(742, 371)
        Me.GbCapturaAutomatica.Name = "GbCapturaAutomatica"
        Me.GbCapturaAutomatica.Size = New System.Drawing.Size(322, 155)
        Me.GbCapturaAutomatica.TabIndex = 62
        Me.GbCapturaAutomatica.TabStop = False
        Me.GbCapturaAutomatica.Text = "Captura de Lotes Automatico"
        '
        'GbLotes
        '
        Me.GbLotes.Controls.Add(Me.BtFin)
        Me.GbLotes.Controls.Add(Me.BtInicio)
        Me.GbLotes.Controls.Add(Me.BtSiguiente)
        Me.GbLotes.Controls.Add(Me.BtAnterior)
        Me.GbLotes.Location = New System.Drawing.Point(742, 532)
        Me.GbLotes.Name = "GbLotes"
        Me.GbLotes.Size = New System.Drawing.Size(322, 90)
        Me.GbLotes.TabIndex = 63
        Me.GbLotes.TabStop = False
        Me.GbLotes.Text = "Lotes"
        '
        'BtFin
        '
        Me.BtFin.Location = New System.Drawing.Point(185, 48)
        Me.BtFin.Name = "BtFin"
        Me.BtFin.Size = New System.Drawing.Size(131, 23)
        Me.BtFin.TabIndex = 3
        Me.BtFin.Text = "Final"
        Me.BtFin.UseVisualStyleBackColor = True
        '
        'BtInicio
        '
        Me.BtInicio.Location = New System.Drawing.Point(6, 48)
        Me.BtInicio.Name = "BtInicio"
        Me.BtInicio.Size = New System.Drawing.Size(131, 23)
        Me.BtInicio.TabIndex = 2
        Me.BtInicio.Text = "Inicio"
        Me.BtInicio.UseVisualStyleBackColor = True
        '
        'BtSiguiente
        '
        Me.BtSiguiente.Location = New System.Drawing.Point(184, 19)
        Me.BtSiguiente.Name = "BtSiguiente"
        Me.BtSiguiente.Size = New System.Drawing.Size(131, 23)
        Me.BtSiguiente.TabIndex = 1
        Me.BtSiguiente.Text = "Siguiente"
        Me.BtSiguiente.UseVisualStyleBackColor = True
        '
        'BtAnterior
        '
        Me.BtAnterior.Location = New System.Drawing.Point(6, 19)
        Me.BtAnterior.Name = "BtAnterior"
        Me.BtAnterior.Size = New System.Drawing.Size(131, 23)
        Me.BtAnterior.TabIndex = 0
        Me.BtAnterior.Text = "Anterior"
        Me.BtAnterior.UseVisualStyleBackColor = True
        '
        'DgvPacas
        '
        Me.DgvPacas.AllowUserToAddRows = False
        Me.DgvPacas.AllowUserToDeleteRows = False
        Me.DgvPacas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPacas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvPacas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvPacas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvPacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvPacas.Location = New System.Drawing.Point(12, 371)
        Me.DgvPacas.MultiSelect = False
        Me.DgvPacas.Name = "DgvPacas"
        Me.DgvPacas.ReadOnly = True
        Me.DgvPacas.RowHeadersVisible = False
        Me.DgvPacas.RowHeadersWidth = 40
        Me.DgvPacas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPacas.Size = New System.Drawing.Size(724, 409)
        Me.DgvPacas.TabIndex = 64
        '
        'GbTipoCaptura
        '
        Me.GbTipoCaptura.Controls.Add(Me.RbAutomatico)
        Me.GbTipoCaptura.Controls.Add(Me.RbManual)
        Me.GbTipoCaptura.Enabled = False
        Me.GbTipoCaptura.Location = New System.Drawing.Point(704, 30)
        Me.GbTipoCaptura.Name = "GbTipoCaptura"
        Me.GbTipoCaptura.Size = New System.Drawing.Size(360, 92)
        Me.GbTipoCaptura.TabIndex = 65
        Me.GbTipoCaptura.TabStop = False
        Me.GbTipoCaptura.Text = "Tipo Captura"
        '
        'RbAutomatico
        '
        Me.RbAutomatico.AutoSize = True
        Me.RbAutomatico.Location = New System.Drawing.Point(6, 48)
        Me.RbAutomatico.Name = "RbAutomatico"
        Me.RbAutomatico.Size = New System.Drawing.Size(78, 17)
        Me.RbAutomatico.TabIndex = 66
        Me.RbAutomatico.Text = "Automatico"
        Me.RbAutomatico.UseVisualStyleBackColor = True
        '
        'RbManual
        '
        Me.RbManual.AutoSize = True
        Me.RbManual.Checked = True
        Me.RbManual.Location = New System.Drawing.Point(6, 22)
        Me.RbManual.Name = "RbManual"
        Me.RbManual.Size = New System.Drawing.Size(60, 17)
        Me.RbManual.TabIndex = 0
        Me.RbManual.TabStop = True
        Me.RbManual.Text = "Manual"
        Me.RbManual.UseVisualStyleBackColor = True
        '
        'Produccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 792)
        Me.Controls.Add(Me.GbTipoCaptura)
        Me.Controls.Add(Me.DgvPacas)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.GbLotes)
        Me.Controls.Add(Me.GbCapturaAutomatica)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.GbModulos)
        Me.Controls.Add(Me.GbDatosProduccion)
        Me.Controls.Add(Me.TbKilos)
        Me.Controls.Add(Me.GbDatosGenerales)
        Me.Controls.Add(Me.MSMenu)
        Me.Controls.Add(Me.TbFolioCIA)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "Produccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produccion"
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.GbDatosGenerales.PerformLayout()
        Me.GbDatosProduccion.ResumeLayout(False)
        Me.GbDatosProduccion.PerformLayout()
        Me.GbModulos.ResumeLayout(False)
        Me.GbModulos.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbCapturaAutomatica.ResumeLayout(False)
        Me.GbLotes.ResumeLayout(False)
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbTipoCaptura.ResumeLayout(False)
        Me.GbTipoCaptura.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TbIdProduccion As TextBox
    Friend WithEvents CbPlantaOrigen As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CBPlantaElabora As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DtpFechaProduccion As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents CbTipo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GbDatosGenerales As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents BtAbrirProduccion As Button
    Friend WithEvents BtCerrarProduccion As Button
    Friend WithEvents TbFolioCIA As TextBox
    Friend WithEvents TbKilos As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents BtActualizarFolio As Button
    Friend WithEvents GbDatosProduccion As GroupBox
    Friend WithEvents GbModulos As GroupBox
    Friend WithEvents TbTotalModulos As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents TbModulos As TextBox
    Friend WithEvents BtActivarPrensa As Button
    Friend WithEvents BtAgregarExcel As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents BtImprimir As Button
    Friend WithEvents BtIncidencias As Button
    Friend WithEvents GbCapturaAutomatica As GroupBox
    Friend WithEvents GbLotes As GroupBox
    Friend WithEvents BtFin As Button
    Friend WithEvents BtInicio As Button
    Friend WithEvents BtSiguiente As Button
    Friend WithEvents BtAnterior As Button
    Friend WithEvents TbNombreProductor As TextBox
    Friend WithEvents TbPorCuentaDe As TextBox
    Friend WithEvents TbIdProductor As TextBox
    Friend WithEvents CbTurno As ComboBox
    Friend WithEvents CbOperador As ComboBox
    Friend WithEvents TbIdOrdenTrabajo As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents DgvPacas As DataGridView
    Friend WithEvents CbTipoProducto As ComboBox
    Friend WithEvents GbTipoCaptura As GroupBox
    Friend WithEvents RbAutomatico As RadioButton
    Friend WithEvents RbManual As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents TbFolioInicial As TextBox
End Class
