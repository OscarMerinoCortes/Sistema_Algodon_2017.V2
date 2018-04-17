﻿Imports Capa_Operacion.Configuracion
Public Class OrdenTrabajo
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
        ConsultarUltimoRango()
    End Sub

    Private Sub CapturaLotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCombos()
        Limpiar()
        ConsultarUltimoRango()
        ConsultarCapturas()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadOrdenTrabajo As New Capa_Entidad.OrdenTrabajo
        Dim NegocioOrdenTrabajo As New Capa_Negocio.OrdenTrabajo
        EntidadOrdenTrabajo.IdOrdenTrabajo = IIf(TbIdOrdenTrabajo.Text = "", 0, TbIdOrdenTrabajo.Text)
        EntidadOrdenTrabajo.IdPlanta = CbPlantas.SelectedValue
        EntidadOrdenTrabajo.IdProductor = TbIdProductor.Text
        EntidadOrdenTrabajo.RangoInicio = TbRangoInicio.Text
        EntidadOrdenTrabajo.RangoFin = TbRangoFin.Text
        EntidadOrdenTrabajo.IdVariedadAlgodon = CbVariedad.SelectedValue
        EntidadOrdenTrabajo.IdColonia = CbColonia.SelectedValue
        EntidadOrdenTrabajo.Predio = TbPredio.Text
        EntidadOrdenTrabajo.NoModulos = TbNoModulos.Text
        EntidadOrdenTrabajo.IdEstatus = CbEstatus.SelectedValue
        EntidadOrdenTrabajo.IdUsuarioCreacion = 1
        EntidadOrdenTrabajo.FechaCreacion = Now
        EntidadOrdenTrabajo.IdUsuarioActualizacion = 1
        EntidadOrdenTrabajo.FechaActualizacion = Now
        NegocioOrdenTrabajo.Guardar(EntidadOrdenTrabajo)
        TbIdOrdenTrabajo.Text = EntidadOrdenTrabajo.IdOrdenTrabajo
        MsgBox("Realizado Correctamente")
        ConsultarCapturas()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub Limpiar()
        TbIdOrdenTrabajo.Text = ""
        CbPlantas.SelectedValue = 1
        TbIdProductor.Text = ""
        TbNombre.Text = ""
        TbRangoInicio.Text = ""
        TbRangoFin.Text = ""
        CbVariedad.SelectedValue = 1
        CbColonia.SelectedValue = 1
        TbPredio.Text = ""
    End Sub
    Private Sub LlenarCombos()
        '---Plantas--
        Dim EntidadOrdenTrabajo As New Capa_Entidad.OrdenTrabajo
        Dim NegocioOrdenTrabajo As New Capa_Negocio.OrdenTrabajo
        Dim Tabla As New DataTable
        EntidadOrdenTrabajo.Consulta = Consulta.ConsultaExterna
        NegocioOrdenTrabajo.Consultar(EntidadOrdenTrabajo)
        Tabla = EntidadOrdenTrabajo.TablaConsulta
        CbPlantas.DataSource = Tabla
        CbPlantas.ValueMember = "IdPlanta"
        CbPlantas.DisplayMember = "Descripcion"
        CbPlantas.SelectedValue = 1
        '--Variedades algodon--
        Dim Tabla2 As New DataTable
        EntidadOrdenTrabajo.Consulta = Consulta.ConsultaVariedadesAlgodon
        NegocioOrdenTrabajo.Consultar(EntidadOrdenTrabajo)
        Tabla2 = EntidadOrdenTrabajo.TablaConsulta
        CbVariedad.DataSource = Tabla2
        CbVariedad.ValueMember = "IdVariedadAlgodon"
        CbVariedad.DisplayMember = "Descripcion"
        CbVariedad.SelectedValue = 1
        '--Colonias--
        Dim Tabla3 As New DataTable
        EntidadOrdenTrabajo.Consulta = Consulta.ConsultaColonias
        NegocioOrdenTrabajo.Consultar(EntidadOrdenTrabajo)
        Tabla3 = EntidadOrdenTrabajo.TablaConsulta
        CbColonia.DataSource = Tabla3
        CbColonia.ValueMember = "IdColonia"
        CbColonia.DisplayMember = "Descripcion"
        CbColonia.SelectedValue = 1
        '--Estatus--
        Dim dt As DataTable = New DataTable("Tabla")
        dt.Columns.Add("Id")
        dt.Columns.Add("Descripcion")
        Dim dr As DataRow
        dr = dt.NewRow()
        dr("Id") = "1"
        dr("Descripcion") = "Activo"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("Id") = "2"
        dr("Descripcion") = "Inactivo"
        dt.Rows.Add(dr)
        CbEstatus.DataSource = dt
        CbEstatus.ValueMember = "Id"
        CbEstatus.DisplayMember = "Descripcion"
        CbEstatus.SelectedValue = 1
    End Sub

    Private Sub TbIdProductor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbIdProductor.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If TbIdProductor.Text <> "" Then
                    Dim EntidadOrdenTrabajo As New Capa_Entidad.OrdenTrabajo
                    Dim NegocioOrdenTrabajo As New Capa_Negocio.OrdenTrabajo
                    Dim Tabla As New DataTable
                    EntidadOrdenTrabajo.Consulta = Consulta.ConsultaProductorId
                    EntidadOrdenTrabajo.IdProductor = CInt(TbIdProductor.Text)
                    NegocioOrdenTrabajo.Consultar(EntidadOrdenTrabajo)
                    Tabla = EntidadOrdenTrabajo.TablaConsulta
                    If Tabla.Rows.Count = 0 Then
                        MsgBox("El productor no existe")
                        Exit Sub
                    Else
                        TbIdProductor.Text = Tabla.Rows(0).Item("IdCliente")
                        TbNombre.Text = Tabla.Rows(0).Item("Nombre")
                    End If
                Else
                    MsgBox("Ingrese el id del productor")
                    Exit Sub
                End If
        End Select
    End Sub
    Private Sub ConsultarUltimoRango()
        Dim EntidadOrdenTrabajo As New Capa_Entidad.OrdenTrabajo
        Dim NegocioOrdenTrabajo As New Capa_Negocio.OrdenTrabajo
        Dim Tabla As New DataTable
        EntidadOrdenTrabajo.Consulta = Consulta.ConsultaRango
        NegocioOrdenTrabajo.Consultar(EntidadOrdenTrabajo)
        Tabla = EntidadOrdenTrabajo.TablaConsulta
        TbRangoInicio.Text = (Tabla.Rows(0).Item("RangoFin") + 1)
    End Sub

    Private Sub TbRangoFin_Leave(sender As Object, e As EventArgs) Handles TbRangoFin.Leave
        If TbRangoFin.Text = "" Then
            MsgBox("Ingrese un valor para el rango final")
            Exit Sub
        Else
            TbNoModulos.Text = CInt((TbRangoFin.Text - TbRangoInicio.Text) + 1)
        End If
    End Sub
    Private Sub ConsultarCapturas()
        Dim EntidadOrdenTrabajo As New Capa_Entidad.OrdenTrabajo
        Dim NegocioOrdenTrabajo As New Capa_Negocio.OrdenTrabajo
        Dim Tabla As New DataTable
        EntidadOrdenTrabajo.Consulta = Consulta.ConsultaBasica
        NegocioOrdenTrabajo.Consultar(EntidadOrdenTrabajo)
        Tabla = EntidadOrdenTrabajo.TablaConsulta
        DgvCapturaLotes.DataSource = Tabla
    End Sub
End Class