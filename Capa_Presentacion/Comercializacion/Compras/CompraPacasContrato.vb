﻿Imports Capa_Operacion.Configuracion
Public Class CompraPacasContrato
    Public TablaModalidadCompra As New DataTable
    Public TablacastigoMicros As New DataTable
    Public TablaCastigoLargoFibra As New DataTable
    Public TablaCastigoResistenciaFibra As New DataTable
    Public TablaPacasAgrupadas As New DataTable
    Private Sub BtModalidadCompra_Click(sender As Object, e As EventArgs) Handles BtModalidadCompra.Click
        ModalidadCompra.ShowDialog()
        TablaModalidadCompra = Tabla
    End Sub
    Private Sub BtCastigoResFibra_Click(sender As Object, e As EventArgs) Handles BtCastigoResFibra.Click
        CastigosResistenciaFibra.ShowDialog()
        TablaCastigoResistenciaFibra = Tabla
    End Sub

    Private Sub BtCastigoMicros_Click(sender As Object, e As EventArgs) Handles BtCastigoMicros.Click
        CastigosMicro.ShowDialog()
        TablacastigoMicros = Tabla
    End Sub

    Private Sub BtCastLarFib_Click(sender As Object, e As EventArgs) Handles BtCastLarFib.Click
        CastigosLargoFibra.ShowDialog()
        TablaCastigoLargoFibra = Tabla
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        If TbIdProductor.Text = "" Or TbPrecioQuintal.Text = "" Then
            MsgBox("Seleccionar a un productor y/o un contrato", MsgBoxStyle.Exclamation)
        Else
            VarGlob2.IdProductor = TbIdProductor.Text
            VarGlob2.NombreProductor = TbNombreProductor.Text
            VarGlob2.PrecioQuintal = TbPrecioQuintal.Text
            _Tabla = Table()
            CompraPago.ShowDialog()
        End If
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click

    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Nuevo()
    End Sub
    Private Sub CompraPacasContrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TablaPacasAgrupadas.Columns.Clear()
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Clase", System.Type.GetType("System.String")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Cantidad", System.Type.GetType("System.Int32")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Kilos", System.Type.GetType("System.Double")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Quintales", System.Type.GetType("System.Double")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("PrecioQuintal", System.Type.GetType("System.Double")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("Total", System.Type.GetType("System.Int32")))
        TablaPacasAgrupadas.Columns.Add(New DataColumn("TotalDlls", System.Type.GetType("System.Double")))
        CargarCombos()
        Nuevo()
    End Sub
    Private Sub Nuevo()
        TbIdCompraPaca.Text = ""
        TbIdProductor.Text = ""
        TbNombreProductor.Text = ""
        CbPlanta.SelectedValue = 1
        TbDesdePaca.Text = ""
        TbHastaPaca.Text = ""
        TbIdContrato.Text = ""
        TbPrecioQuintal.Text = ""
        TbNoPacas.Text = ""
        DgvContratos.DataSource = Nothing
        DgvDatosLiquidacion.DataSource = Nothing
        DgvLiqCompradas.DataSource = Nothing
        DgvPacasComprar.DataSource = Nothing
        DgvIndCompradas.DataSource = Nothing
        DgvPacasSinClasif.DataSource = Nothing
        DgvAgrupadasCliente.DataSource = Nothing
        DgvAgrupadasClases.DataSource = Nothing
        DgvContratos.Columns.Clear()
        DgvDatosLiquidacion.Columns.Clear()
        DgvLiqCompradas.Columns.Clear()
        DgvPacasComprar.Columns.Clear()
        DgvIndCompradas.Columns.Clear()
        DgvPacasSinClasif.Columns.Clear()
        DgvAgrupadasCliente.Columns.Clear()
        DgvAgrupadasClases.Columns.Clear()
        TbPacasCont.Text = ""
        TbPacasDisp.Text = ""
        TbPacasCompCont.Text = ""
        TbPacasMarc.Text = ""
        TbPacasComp.Text = ""
        TbKilosComp.Text = ""
        TablaModalidadCompra.Clear()
        TablacastigoMicros.Clear()
        TablaCastigoLargoFibra.Clear()
        TablaCastigoResistenciaFibra.Clear()
    End Sub
    Private Sub CargarCombos()
        '---Planta Origen--
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaExterna
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        CbPlanta.DataSource = Tabla
        CbPlanta.ValueMember = "IdPlanta"
        CbPlanta.DisplayMember = "Descripcion"
        CbPlanta.SelectedValue = 1
        '---Modalidad De Compra--
        'Dim Tabla2 As New DataTable
        'EntidadProduccion.Consulta = Consulta.ConsultaModoCompra
        'NegocioProduccion.Consultar(EntidadProduccion)
        'Tabla2 = EntidadProduccion.TablaConsulta
        'CbModalidadCompra.DataSource = Tabla2
        'CbModalidadCompra.ValueMember = "IdModoEncabezado"
        'CbModalidadCompra.DisplayMember = "Descripcion"
        'CbModalidadCompra.SelectedValue = 11
    End Sub

    Private Sub BtnBuscarProd_Click(sender As Object, e As EventArgs) Handles BtnBuscarProd.Click
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        ConsultaProductores.ShowDialog()
        TbIdProductor.Text = _Id
        TbNombreProductor.Text = _Nombre
        'TbAsociacion.Text = _Dato
        If TbIdProductor.Text = 0 Then
            TbIdProductor.Text = ""
            MsgBox("Seleccionar a un productor para ver sus contratos", MsgBoxStyle.Exclamation)
        Else
            '---Consultar contratos del productor---
            EntidadCompraPacasContrato.Consulta = Consulta.ConsultaPorId
            EntidadCompraPacasContrato.IdProductor = CInt(TbIdProductor.Text)
            NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
            Tabla = EntidadCompraPacasContrato.TablaConsulta
            DgvContratos.Columns.Clear()
            DgvContratos.DataSource = Tabla
            Dim colSelCon As New DataGridViewCheckBoxColumn()
            colSelCon.Name = "Seleccionar"
            colSelCon.FalseValue = False
            colSelCon.Visible = True
            DgvContratos.Columns.Insert(5, colSelCon)
            '---Consultar liquidaciones del productor
            EntidadCompraPacasContrato.Consulta = Consulta.ConsultaLiquidaciones
            EntidadCompraPacasContrato.IdProductor = CInt(TbIdProductor.Text)
            NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
            Tabla = EntidadCompraPacasContrato.TablaConsulta
            DgvDatosLiquidacion.Columns.Clear()
            DgvDatosLiquidacion.DataSource = Tabla
            'Dim colSelLiq As New DataGridViewCheckBoxColumn()
            'colSelLiq.Name = "Seleccionar"
            'colSelLiq.FalseValue = False
            'colSelLiq.Visible = True
            'DgvDatosLiquidacion.Columns.Insert(6, colSelLiq)
            PropiedadesDgvLiquidacionesComprar()
            '---Consultar las pacas ya clasificadas del productor
            EntidadCompraPacasContrato.Consulta = Consulta.ConsultaPaca
            EntidadCompraPacasContrato.IdProductor = CInt(TbIdProductor.Text)
            NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
            Tabla = EntidadCompraPacasContrato.TablaConsulta
            DgvPacasComprar.Columns.Clear()
            DgvPacasComprar.DataSource = Tabla
            'Dim colSelPac As New DataGridViewCheckBoxColumn()
            'colSelPac.Name = "Seleccionar"
            'colSelPac.FalseValue = False
            'colSelPac.Visible = True
            'DgvPacasComprar.Columns.Insert(7, colSelPac)
            PropiedadesDgvPacasComprar()
        End If
    End Sub

    Private Sub PropiedadesDgvPacasComprar()
        DgvPacasComprar.Columns("IdOrdenTrabajo").ReadOnly = True
        DgvPacasComprar.Columns("IdLiquidacion").ReadOnly = True
        DgvPacasComprar.Columns("Descripcion").ReadOnly = True
        DgvPacasComprar.Columns("BaleId").ReadOnly = True
        DgvPacasComprar.Columns("FolioCIA").ReadOnly = True
        DgvPacasComprar.Columns("Kilos").ReadOnly = True
        DgvPacasComprar.Columns("Clase").ReadOnly = True
    End Sub

    Private Sub PropiedadesDgvLiquidacionesComprar()
        DgvDatosLiquidacion.Columns("IdLiquidacion").ReadOnly = True
        DgvDatosLiquidacion.Columns("Cliente").ReadOnly = True
        DgvDatosLiquidacion.Columns("Fecha").ReadOnly = True
        DgvDatosLiquidacion.Columns("Comentarios").ReadOnly = True
        DgvDatosLiquidacion.Columns("TotalPacas").ReadOnly = True
    End Sub

    Private Sub PropiedadesDgvContratos()
        DgvContratos.Columns("IdContratoAlgodon").ReadOnly = True
        DgvContratos.Columns("Pacas").ReadOnly = True
        DgvContratos.Columns("SuperficieComprometida").ReadOnly = True
        DgvContratos.Columns("PrecioQuintal").ReadOnly = True
        DgvContratos.Columns("Fecha").ReadOnly = True
    End Sub

    Private Sub DgvContratos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvContratos.CellContentClick
        Dim filaSeleccionada As Integer = DgvContratos.CurrentRow.Index
        For Each row As DataGridViewRow In DgvContratos.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If Index = filaSeleccionada Then
                DgvContratos.Rows(Index).Cells("Seleccionar").Value = True
                TbPrecioQuintal.Text = DgvContratos.Rows(Index).Cells("PrecioQuintal").Value
                TbNoPacas.Text = DgvContratos.Rows(Index).Cells("Pacas").Value
                TbIdContrato.Text = DgvContratos.Rows(Index).Cells("IdCOntratoAlgodon").Value
            Else
                DgvContratos.Rows(Index).Cells("Seleccionar").Value = False
            End If
        Next
    End Sub

    Private Sub DgvDatosLiquidacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDatosLiquidacion.CellContentClick
        Dim filaSeleccionada As Integer = DgvDatosLiquidacion.CurrentRow.Index
        Dim chkSel As Boolean = DgvDatosLiquidacion.Rows(filaSeleccionada).Cells("Seleccionar").Value
        Dim IdLiquidacion As Integer
        IdLiquidacion = DgvDatosLiquidacion.Rows(filaSeleccionada).Cells("IdLiquidacion").Value
        For Each row As DataGridViewRow In DgvPacasComprar.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If row.Cells("IdLiquidacion").Value = IdLiquidacion And chkSel = False Then
                row.Cells("Seleccionar").Value = True
            Else
                row.Cells("Seleccionar").Value = False
            End If
        Next
    End Sub
    Private Sub CheckFalse()
        Dim Contador As Integer
        For Contador = 0 To DgvPacasComprar.RowCount - 1
            If DgvPacasComprar.Rows(Contador).Cells("Seleccionar").Value = Nothing Or DgvPacasComprar.Rows(Contador).Cells("Seleccionar").Value = True Then
                DgvPacasComprar.Rows(Contador).Cells("Seleccionar").Value = False
            End If
        Next Contador
    End Sub

    Private Function Table() As DataTable
        Dim TablaRenglonAInsertar As DataRow
        For Each row As DataGridViewRow In DgvPacasComprar.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            TablaRenglonAInsertar = TablaPacasAgrupadas.NewRow()
            TablaRenglonAInsertar("Clase") = DgvPacasComprar.Rows(Index).Cells("Clase").Value
            TablaRenglonAInsertar("Cantidad") = 1
            TablaRenglonAInsertar("Kilos") = DgvPacasComprar.Rows(Index).Cells("Kilos").Value
            TablaRenglonAInsertar("Quintales") = CDbl(DgvPacasComprar.Rows(Index).Cells("Kilos").Value / 46.02)
            TablaRenglonAInsertar("PrecioQuintal") = CDbl(TbPrecioQuintal.Text)
            TablaRenglonAInsertar("Total") = DgvPacasComprar.Rows(Index).Cells("Kilos").Value
            TablaRenglonAInsertar("TotalDlls") = Val(CDbl(DgvPacasComprar.Rows(Index).Cells("Kilos").Value / 46.02) * CDbl(TbPrecioQuintal.Text))
            TablaPacasAgrupadas.Rows.Add(TablaRenglonAInsertar)
        Next
        'Tabla = TablaModalidadCompra
        ''
        Dim query = From q In TablaPacasAgrupadas.AsEnumerable() Select q Order By q.Item("Clase")
        Dim dtResultado As New DataTable()
        dtResultado.Columns.Add("Clase")
        dtResultado.Columns.Add("Cantidad")
        dtResultado.Columns.Add("Kilos")
        dtResultado.Columns.Add("Quintales")
        dtResultado.Columns.Add("PrecioQuintal")
        dtResultado.Columns.Add("Total")
        dtResultado.Columns.Add("TotalDlls")
        ''
        Dim dtCopy = query.CopyToDataTable()
        dtCopy.Rows.Add()
        Dim dr As DataRow = dtCopy.NewRow()
        Dim i, value, TotalPacas As Integer
        Dim TotalQuintales, TotalDolares As Double
        For j As Integer = 0 To dtCopy.Rows.Count - 2
            Dim item = dtCopy.Rows(j)
            Dim Clase = Convert.ToString(item(0))
            Dim Cantidad = Convert.ToInt32(item(1))
            Dim Kilos = Convert.ToDouble(item(2))
            Dim Quintales = Convert.ToString(item(3))
            Dim TbPrecioQuintalQuintal = Convert.ToInt32(item(4))
            Dim Total = Convert.ToDouble(item(5))
            Dim TotalDlls = Convert.ToString(item(6))
            Dim drr As DataRow = dtResultado.NewRow()
            drr.Item(0) = Clase
            drr.Item(1) = Cantidad
            drr.Item(2) = Kilos
            drr.Item(3) = Quintales
            drr.Item(4) = TbPrecioQuintalQuintal
            drr.Item(5) = Total
            drr.Item(6) = TotalDlls
            dtResultado.ImportRow(item)
            Dim filaSig As String = Convert.ToString(dtCopy.Rows(i + 1).Item(0)) 'fila siguiente
            If (Clase = filaSig) Then 'clase actual es igual a la siguiente zona
                value += Kilos
                TotalPacas += Cantidad
            Else 'cuando cambie la clase insertar nueva fila y poner "Total" & Clase
                drr.Item(0) = "Total " & Clase
                drr.Item(1) = TotalPacas + Cantidad
                drr.Item(2) = value + Kilos
                drr.Item(3) = TotalQuintales + Quintales
                drr.Item(4) = ""
                drr.Item(5) = ""
                drr.Item(6) = TotalDlls + TotalDolares
                dtResultado.Rows.Add(drr)
                value = 0

                TotalPacas = 0
            End If
            i += 1 'indice
        Next
        Return dtResultado
    End Function
End Class