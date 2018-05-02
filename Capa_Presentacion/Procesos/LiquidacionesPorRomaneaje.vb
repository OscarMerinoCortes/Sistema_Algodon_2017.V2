﻿Imports System.Data.SqlClient
Imports Capa_Operacion.Configuracion
Public Class LiquidacionesPorRomaneaje
    Dim TablaCombos As New DataTable
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub LlenarCombos()
        Dim EntidadTierras As New Capa_Entidad.Tierras
        Dim NegocioTierras As New Capa_Negocio.Tierras
        EntidadTierras.LlenaCombo = LlenaCombo.LlenaComboCliente
        NegocioTierras.ConsultarCombo(EntidadTierras)
        TablaCombos = EntidadTierras.TablaConsulta
        CbNombreCliente.DataSource = TablaCombos
        CbNombreCliente.DisplayMember = "Nombre"
        CbNombreCliente.ValueMember = "IdCliente"
        CbNombreCliente.SelectedIndex = -1
        '---------------------------CONSULTA ASOCIACIONES   
        Dim tabla9 As New DataTable
        Dim EntidadClientes As New Capa_Entidad.Clientes
        Dim NegocioClientes As New Capa_Negocio.Clientes
        'EntidadClientes.IdEstadoApoderado = CbEstadoApoderado.SelectedValue
        EntidadClientes.Consulta = Consulta.ConsultaAsociaciones
        NegocioClientes.Consultar(EntidadClientes)
        tabla9 = EntidadClientes.TablaConsulta
        CbPorCuenta.DataSource = tabla9
        CbPorCuenta.ValueMember = "IdAsociacion"
        CbPorCuenta.DisplayMember = "Descripcion"
        CbPorCuenta.SelectedIndex = -1
        '---------------------------CONSULTA PLANTA ORIGEN
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaExterna
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        CbPlanta.DataSource = Tabla
        CbPlanta.ValueMember = "IdPlanta"
        CbPlanta.DisplayMember = "Descripcion"
        CbPlanta.SelectedIndex = -1
    End Sub
    Private Sub Limpiar()
        CbPlanta.SelectedIndex = -1
        TbIdOrden.Text = ""
        TbIdLiquidacion.Text = ""
        CbTipo.Text = ""
        DtFechaLiquidacion.Value = Now
        CbNombreCliente.SelectedIndex = -1
        CbPorCuenta.SelectedIndex = -1
        TbTotalHueso.Text = ""
        TbNumBorregos.Text = ""
        TbNumPacas.Text = ""
        TbPluma.Text = ""
        TbBorregosPluma.Text = ""
        TbPacasPluma.Text = ""
        TbMerma.Text = ""
        TbPorcentajeMerma.Text = ""
        TbPorcentajePluma.Text = ""
        TbPorcentajeSemilla.Text = ""
        TbSemilla.Text = ""
        TbPorcentajeTotal.Text = ""
        TbComentarios.Text = ""
        DgvModulos.DataSource = ""
        ChClaseMicros.Checked = False
    End Sub
    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click, ToolStripMenuItem1.Click
        Dim EntidadLiquidacionesPorRomaneaje As New Capa_Entidad.LiquidacionesPorRomaneaje
        Dim NegocioLiquidacionesPorRomaneaje As New Capa_Negocio.LiquidacionesPorRomaneaje
        Dim Tabla As New DataTable
        ConsultaOrdenTrabajo.ShowDialog()
        EntidadLiquidacionesPorRomaneaje.IdOrdenTrabajo = ConsultaOrdenTrabajo.Id
        EntidadLiquidacionesPorRomaneaje.Consulta = Consulta.ConsultaOrden
        NegocioLiquidacionesPorRomaneaje.Consultar(EntidadLiquidacionesPorRomaneaje)
        Tabla = EntidadLiquidacionesPorRomaneaje.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            Exit Sub
        End If
        TbIdOrden.Text = Tabla.Rows(0).Item("IdOrdenTrabajo")
        CbPlanta.SelectedValue = Tabla.Rows(0).Item("IdPlantaOrigen")
        CbNombreCliente.SelectedValue = Tabla.Rows(0).Item("IdCliente")
        CbPorCuenta.SelectedValue = Tabla.Rows(0).Item("IdPorCuenta")
        CbTipo.Text = Tabla.Rows(0).Item("Tipo")
        TbTotalHueso.Text = Tabla.Rows(0).Item("TotalHueso")
        TbNumPacas.Text = Tabla.Rows(0).Item("Pacas")
        TbNumBorregos.Text = 0
        TbPacasPluma.Text = Tabla.Rows(0).Item("Pluma")
        TbBorregosPluma.Text = Tabla.Rows(0).Item("PlumaBorregos")
        TbPluma.Text = Tabla.Rows(0).Item("Pluma")
        TbSemilla.Text = Tabla.Rows(0).Item("Semilla")
        TbMerma.Text = Tabla.Rows(0).Item("Merma")
        TbPorcentajePluma.Text = Tabla.Rows(0).Item("PorcentajePluma")
        TbPorcentajeSemilla.Text = Tabla.Rows(0).Item("PorcentajeSemilla")
        TbPorcentajeMerma.Text = Tabla.Rows(0).Item("PorcentajeMerma")
        TbPorcentajeTotal.Text = Tabla.Rows(0).Item("PorcentajePluma") + Tabla.Rows(0).Item("PorcentajeSemilla") + Tabla.Rows(0).Item("PorcentajeMerma")

        ConsultarModulos()
    End Sub
    Private Sub ConsultarModulos()
        Dim EntidadLiquidacionesPorRomaneaje As New Capa_Entidad.LiquidacionesPorRomaneaje
        Dim NegocioLiquidacionesPorRomaneaje As New Capa_Negocio.LiquidacionesPorRomaneaje
        Dim Tabla As New DataTable
        EntidadLiquidacionesPorRomaneaje.IdOrdenTrabajo = TbIdOrden.Text
        EntidadLiquidacionesPorRomaneaje.Consulta = Consulta.ConsultaDetallada
        NegocioLiquidacionesPorRomaneaje.Consultar(EntidadLiquidacionesPorRomaneaje)
        DgvModulos.DataSource = EntidadLiquidacionesPorRomaneaje.TablaConsulta
        PropiedadesDgvModulos()
    End Sub
    Private Sub PropiedadesDgvModulos()
        DgvModulos.Columns("IdOrdenTrabajo").Visible = False
        DgvModulos.Columns("IdPlanta").Visible = False
    End Sub
    Private Sub LiquidacionesPorRomaneaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCombos()
        Limpiar()
        TbIdOrden.Focus()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadLiquidacionesPorRomaneaje As New Capa_Entidad.LiquidacionesPorRomaneaje
        Dim NegocioLiquidacionesPorRomaneaje As New Capa_Negocio.LiquidacionesPorRomaneaje
        EntidadLiquidacionesPorRomaneaje.IdLiquidacion = IIf(TbIdLiquidacion.Text = "", 0, TbIdLiquidacion.Text)
        EntidadLiquidacionesPorRomaneaje.IdOrdenTrabajo = TbIdOrden.Text
        EntidadLiquidacionesPorRomaneaje.Fecha = DtFechaLiquidacion.Value
        EntidadLiquidacionesPorRomaneaje.Comentarios = TbComentarios.Text
        EntidadLiquidacionesPorRomaneaje.IdEstatus = 1
        EntidadLiquidacionesPorRomaneaje.IdUsuarioCreacion = 1
        EntidadLiquidacionesPorRomaneaje.FechaCreacion = Now
        EntidadLiquidacionesPorRomaneaje.IdUsuarioActualizacion = 1
        EntidadLiquidacionesPorRomaneaje.FechaActualizacion = Now
        NegocioLiquidacionesPorRomaneaje.Guardar(EntidadLiquidacionesPorRomaneaje)
        TbIdLiquidacion.Text = EntidadLiquidacionesPorRomaneaje.IdOrdenTrabajo
        MsgBox("Realizado Correctamente")
    End Sub

    Private Sub TbIdOrden_Enter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbIdOrden.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If TbIdOrden.Text <> "" Then
                    Dim EntidadLiquidacionesPorRomaneaje As New Capa_Entidad.LiquidacionesPorRomaneaje
                    Dim NegocioLiquidacionesPorRomaneaje As New Capa_Negocio.LiquidacionesPorRomaneaje
                    Dim Tabla As New DataTable
                    EntidadLiquidacionesPorRomaneaje.Consulta = Consulta.ConsultaOrden
                    EntidadLiquidacionesPorRomaneaje.IdOrdenTrabajo = CInt(TbIdOrden.Text)
                    NegocioLiquidacionesPorRomaneaje.Consultar(EntidadLiquidacionesPorRomaneaje)
                    Tabla = EntidadLiquidacionesPorRomaneaje.TablaConsulta
                    If Tabla.Rows.Count = 0 Then
                        MsgBox("La orden de trabajo no existe...")
                        Limpiar()
                        Exit Sub
                    Else
                        TbIdOrden.Text = Tabla.Rows(0).Item("IdOrdenTrabajo")
                        CbPlanta.SelectedValue = Tabla.Rows(0).Item("IdPlantaOrigen")
                        TbIdLiquidacion.Text = Tabla.Rows(0).Item("IdLiquidacion")
                        CbNombreCliente.SelectedValue = Tabla.Rows(0).Item("IdCliente")
                        CbPorCuenta.SelectedValue = Tabla.Rows(0).Item("IdPorCuenta")
                        CbTipo.Text = Tabla.Rows(0).Item("Tipo")
                        DtFechaLiquidacion.Value = Tabla.Rows(0).Item("Fecha")
                        TbComentarios.Text = Tabla.Rows(0).Item("Comentarios")
                        TbTotalHueso.Text = Tabla.Rows(0).Item("TotalHueso")
                        TbNumPacas.Text = Tabla.Rows(0).Item("Pacas")
                        TbNumBorregos.Text = 0
                        TbPacasPluma.Text = Tabla.Rows(0).Item("Pluma")
                        TbBorregosPluma.Text = Tabla.Rows(0).Item("PlumaBorregos")
                        TbPluma.Text = Tabla.Rows(0).Item("Pluma")
                        TbSemilla.Text = Tabla.Rows(0).Item("Semilla")
                        TbMerma.Text = Tabla.Rows(0).Item("Merma")
                        TbPorcentajePluma.Text = Tabla.Rows(0).Item("PorcentajePluma")
                        TbPorcentajeSemilla.Text = Tabla.Rows(0).Item("PorcentajeSemilla")
                        TbPorcentajeMerma.Text = Tabla.Rows(0).Item("PorcentajeMerma")
                        TbPorcentajeTotal.Text = Tabla.Rows(0).Item("PorcentajePluma") + Tabla.Rows(0).Item("PorcentajeSemilla") + Tabla.Rows(0).Item("PorcentajeMerma")
                        ConsultarModulos()
                    End If
                Else
                    MsgBox("Ingrese el ID de la orden de trabajo...")
                    Exit Sub
                End If
        End Select
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
End Class