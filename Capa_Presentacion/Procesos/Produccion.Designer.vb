<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TbTotalHueso = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbPacas = New System.Windows.Forms.TextBox()
        Me.TbPlumaPacas = New System.Windows.Forms.TextBox()
        Me.TbBorregosPacas = New System.Windows.Forms.TextBox()
        Me.TbPluma = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TbSemilla = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TbMerma = New System.Windows.Forms.TextBox()
        Me.TbBorra = New System.Windows.Forms.TextBox()
        Me.TbPorcPluma = New System.Windows.Forms.TextBox()
        Me.TbPorcSemilla = New System.Windows.Forms.TextBox()
        Me.TbPorcMerma = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GbResumen = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.BtAbrirProduccion = New System.Windows.Forms.Button()
        Me.BtCerrarProduccion = New System.Windows.Forms.Button()
        Me.TbFolioCIA = New System.Windows.Forms.TextBox()
        Me.TbFolioCliente = New System.Windows.Forms.TextBox()
        Me.TbKilos = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GbDatosProduccion = New System.Windows.Forms.GroupBox()
        Me.CbTipoProducto = New System.Windows.Forms.ComboBox()
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
        Me.MSMenu.SuspendLayout()
        Me.GbDatosGenerales.SuspendLayout()
        Me.GbResumen.SuspendLayout()
        Me.GbDatosProduccion.SuspendLayout()
        Me.GbModulos.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbCapturaAutomatica.SuspendLayout()
        Me.GbLotes.SuspendLayout()
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label3.Text = "Planta Elabora"
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
        'TbTotalHueso
        '
        Me.TbTotalHueso.Location = New System.Drawing.Point(97, 19)
        Me.TbTotalHueso.Name = "TbTotalHueso"
        Me.TbTotalHueso.Size = New System.Drawing.Size(100, 20)
        Me.TbTotalHueso.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Total Hueso"
        '
        'TbPacas
        '
        Me.TbPacas.Location = New System.Drawing.Point(97, 45)
        Me.TbPacas.Name = "TbPacas"
        Me.TbPacas.Size = New System.Drawing.Size(100, 20)
        Me.TbPacas.TabIndex = 18
        '
        'TbPlumaPacas
        '
        Me.TbPlumaPacas.Location = New System.Drawing.Point(97, 71)
        Me.TbPlumaPacas.Name = "TbPlumaPacas"
        Me.TbPlumaPacas.Size = New System.Drawing.Size(100, 20)
        Me.TbPlumaPacas.TabIndex = 19
        '
        'TbBorregosPacas
        '
        Me.TbBorregosPacas.Location = New System.Drawing.Point(97, 97)
        Me.TbBorregosPacas.Name = "TbBorregosPacas"
        Me.TbBorregosPacas.Size = New System.Drawing.Size(100, 20)
        Me.TbBorregosPacas.TabIndex = 20
        '
        'TbPluma
        '
        Me.TbPluma.Location = New System.Drawing.Point(97, 123)
        Me.TbPluma.Name = "TbPluma"
        Me.TbPluma.Size = New System.Drawing.Size(100, 20)
        Me.TbPluma.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Pacas"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Pluma (Pacas)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Pluma (Borregos)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 126)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Pluma"
        '
        'TbSemilla
        '
        Me.TbSemilla.Location = New System.Drawing.Point(97, 149)
        Me.TbSemilla.Name = "TbSemilla"
        Me.TbSemilla.Size = New System.Drawing.Size(100, 20)
        Me.TbSemilla.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Semilla"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 178)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Merma"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(203, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Borra"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(220, 126)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(15, 13)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "%"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(220, 152)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(15, 13)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "%"
        '
        'TbMerma
        '
        Me.TbMerma.Location = New System.Drawing.Point(97, 175)
        Me.TbMerma.Name = "TbMerma"
        Me.TbMerma.Size = New System.Drawing.Size(100, 20)
        Me.TbMerma.TabIndex = 32
        '
        'TbBorra
        '
        Me.TbBorra.Location = New System.Drawing.Point(241, 45)
        Me.TbBorra.Name = "TbBorra"
        Me.TbBorra.Size = New System.Drawing.Size(100, 20)
        Me.TbBorra.TabIndex = 33
        '
        'TbPorcPluma
        '
        Me.TbPorcPluma.Location = New System.Drawing.Point(241, 123)
        Me.TbPorcPluma.Name = "TbPorcPluma"
        Me.TbPorcPluma.Size = New System.Drawing.Size(100, 20)
        Me.TbPorcPluma.TabIndex = 34
        '
        'TbPorcSemilla
        '
        Me.TbPorcSemilla.Location = New System.Drawing.Point(241, 149)
        Me.TbPorcSemilla.Name = "TbPorcSemilla"
        Me.TbPorcSemilla.Size = New System.Drawing.Size(100, 20)
        Me.TbPorcSemilla.TabIndex = 35
        '
        'TbPorcMerma
        '
        Me.TbPorcMerma.Location = New System.Drawing.Point(241, 175)
        Me.TbPorcMerma.Name = "TbPorcMerma"
        Me.TbPorcMerma.Size = New System.Drawing.Size(100, 20)
        Me.TbPorcMerma.TabIndex = 36
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(220, 181)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(15, 13)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "%"
        '
        'GbResumen
        '
        Me.GbResumen.Controls.Add(Me.TbBorra)
        Me.GbResumen.Controls.Add(Me.Label18)
        Me.GbResumen.Controls.Add(Me.TbTotalHueso)
        Me.GbResumen.Controls.Add(Me.TbPorcMerma)
        Me.GbResumen.Controls.Add(Me.Label8)
        Me.GbResumen.Controls.Add(Me.TbPorcSemilla)
        Me.GbResumen.Controls.Add(Me.TbPacas)
        Me.GbResumen.Controls.Add(Me.TbPorcPluma)
        Me.GbResumen.Controls.Add(Me.TbPlumaPacas)
        Me.GbResumen.Controls.Add(Me.TbBorregosPacas)
        Me.GbResumen.Controls.Add(Me.TbMerma)
        Me.GbResumen.Controls.Add(Me.TbPluma)
        Me.GbResumen.Controls.Add(Me.Label17)
        Me.GbResumen.Controls.Add(Me.Label9)
        Me.GbResumen.Controls.Add(Me.Label16)
        Me.GbResumen.Controls.Add(Me.Label10)
        Me.GbResumen.Controls.Add(Me.Label15)
        Me.GbResumen.Controls.Add(Me.Label11)
        Me.GbResumen.Controls.Add(Me.Label14)
        Me.GbResumen.Controls.Add(Me.Label12)
        Me.GbResumen.Controls.Add(Me.Label13)
        Me.GbResumen.Controls.Add(Me.TbSemilla)
        Me.GbResumen.Enabled = False
        Me.GbResumen.Location = New System.Drawing.Point(442, 30)
        Me.GbResumen.Name = "GbResumen"
        Me.GbResumen.Size = New System.Drawing.Size(353, 205)
        Me.GbResumen.TabIndex = 38
        Me.GbResumen.TabStop = False
        Me.GbResumen.Text = "Resumen"
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
        Me.BtAbrirProduccion.Location = New System.Drawing.Point(12, 97)
        Me.BtAbrirProduccion.Name = "BtAbrirProduccion"
        Me.BtAbrirProduccion.Size = New System.Drawing.Size(95, 23)
        Me.BtAbrirProduccion.TabIndex = 45
        Me.BtAbrirProduccion.Text = "Abrir Produccion"
        Me.BtAbrirProduccion.UseVisualStyleBackColor = True
        '
        'BtCerrarProduccion
        '
        Me.BtCerrarProduccion.Location = New System.Drawing.Point(115, 97)
        Me.BtCerrarProduccion.Name = "BtCerrarProduccion"
        Me.BtCerrarProduccion.Size = New System.Drawing.Size(100, 23)
        Me.BtCerrarProduccion.TabIndex = 46
        Me.BtCerrarProduccion.Text = "Cerrar Produccion"
        Me.BtCerrarProduccion.UseVisualStyleBackColor = True
        '
        'TbFolioCIA
        '
        Me.TbFolioCIA.Enabled = False
        Me.TbFolioCIA.Location = New System.Drawing.Point(115, 126)
        Me.TbFolioCIA.Name = "TbFolioCIA"
        Me.TbFolioCIA.Size = New System.Drawing.Size(121, 20)
        Me.TbFolioCIA.TabIndex = 47
        '
        'TbFolioCliente
        '
        Me.TbFolioCliente.Enabled = False
        Me.TbFolioCliente.Location = New System.Drawing.Point(115, 152)
        Me.TbFolioCliente.Name = "TbFolioCliente"
        Me.TbFolioCliente.Size = New System.Drawing.Size(121, 20)
        Me.TbFolioCliente.TabIndex = 48
        '
        'TbKilos
        '
        Me.TbKilos.Enabled = False
        Me.TbKilos.Location = New System.Drawing.Point(115, 178)
        Me.TbKilos.Name = "TbKilos"
        Me.TbKilos.Size = New System.Drawing.Size(121, 20)
        Me.TbKilos.TabIndex = 49
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(9, 129)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(49, 13)
        Me.Label22.TabIndex = 50
        Me.Label22.Text = "Folio CIA"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(9, 155)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 13)
        Me.Label23.TabIndex = 51
        Me.Label23.Text = "Folio Cliente"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(9, 181)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(29, 13)
        Me.Label24.TabIndex = 52
        Me.Label24.Text = "Kilos"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(221, 97)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(25, 23)
        Me.Button3.TabIndex = 53
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GbDatosProduccion
        '
        Me.GbDatosProduccion.Controls.Add(Me.CbTipoProducto)
        Me.GbDatosProduccion.Controls.Add(Me.CbOperador)
        Me.GbDatosProduccion.Controls.Add(Me.CbTurno)
        Me.GbDatosProduccion.Controls.Add(Me.Button3)
        Me.GbDatosProduccion.Controls.Add(Me.Label24)
        Me.GbDatosProduccion.Controls.Add(Me.Label23)
        Me.GbDatosProduccion.Controls.Add(Me.Label19)
        Me.GbDatosProduccion.Controls.Add(Me.Label22)
        Me.GbDatosProduccion.Controls.Add(Me.Label20)
        Me.GbDatosProduccion.Controls.Add(Me.TbKilos)
        Me.GbDatosProduccion.Controls.Add(Me.Label21)
        Me.GbDatosProduccion.Controls.Add(Me.TbFolioCliente)
        Me.GbDatosProduccion.Controls.Add(Me.BtAbrirProduccion)
        Me.GbDatosProduccion.Controls.Add(Me.TbFolioCIA)
        Me.GbDatosProduccion.Controls.Add(Me.BtCerrarProduccion)
        Me.GbDatosProduccion.Location = New System.Drawing.Point(801, 30)
        Me.GbDatosProduccion.Name = "GbDatosProduccion"
        Me.GbDatosProduccion.Size = New System.Drawing.Size(256, 205)
        Me.GbDatosProduccion.TabIndex = 54
        Me.GbDatosProduccion.TabStop = False
        Me.GbDatosProduccion.Text = "Datos de Produccion"
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
        'Produccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 792)
        Me.Controls.Add(Me.DgvPacas)
        Me.Controls.Add(Me.GbLotes)
        Me.Controls.Add(Me.GbCapturaAutomatica)
        Me.Controls.Add(Me.GbModulos)
        Me.Controls.Add(Me.GbDatosProduccion)
        Me.Controls.Add(Me.GbResumen)
        Me.Controls.Add(Me.GbDatosGenerales)
        Me.Controls.Add(Me.MSMenu)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "Produccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produccion"
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.GbDatosGenerales.PerformLayout()
        Me.GbResumen.ResumeLayout(False)
        Me.GbResumen.PerformLayout()
        Me.GbDatosProduccion.ResumeLayout(False)
        Me.GbDatosProduccion.PerformLayout()
        Me.GbModulos.ResumeLayout(False)
        Me.GbModulos.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbCapturaAutomatica.ResumeLayout(False)
        Me.GbLotes.ResumeLayout(False)
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TbTotalHueso As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TbPacas As TextBox
    Friend WithEvents TbPlumaPacas As TextBox
    Friend WithEvents TbBorregosPacas As TextBox
    Friend WithEvents TbPluma As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TbSemilla As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TbMerma As TextBox
    Friend WithEvents TbBorra As TextBox
    Friend WithEvents TbPorcPluma As TextBox
    Friend WithEvents TbPorcSemilla As TextBox
    Friend WithEvents TbPorcMerma As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents GbResumen As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents BtAbrirProduccion As Button
    Friend WithEvents BtCerrarProduccion As Button
    Friend WithEvents TbFolioCIA As TextBox
    Friend WithEvents TbFolioCliente As TextBox
    Friend WithEvents TbKilos As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Button3 As Button
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
End Class
