﻿Imports Capa_Operacion.Configuracion
Public Class Colonias
    Private Sub Colonias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        ConsultaColonia()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadColonias As New Capa_Entidad.Colonias
        Dim NegocioColonias As New Capa_Negocio.Colonias
        EntidadColonias.IdColonia = IIf(TbIdColonia.Text = "", 0, TbIdColonia.Text)
        EntidadColonias.Descripcion = TbDescripcion.Text
        EntidadColonias.NumeroPacas = TbNoPacas.Text
        EntidadColonias.IdEstatus = CbEstatus.SelectedValue
        EntidadColonias.IdUsuarioCreacion = 1
        EntidadColonias.FechaCreacion = Now
        NegocioColonias.Guardar(EntidadColonias)
        TbIdColonia.Text = EntidadColonias.IdColonia
        MsgBox("Realizado Correctamente")
        ConsultaColonia()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Limpiar()
        TbIdColonia.Text = ""
        TbDescripcion.Text = ""
        TbNoPacas.Text = ""
        CbEstatus.SelectedValue = 1
    End Sub

    Private Sub CargarCombos()
        '---------------------------COMBO ESTATUS
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

    Private Sub ConsultaColonia()
        Dim EntidadColonias As New Capa_Entidad.Colonias
        Dim NegocioColonias As New Capa_Negocio.Colonias
        Dim Tabla As New DataTable
        'EntidadClientes.IdCliente = ConsultaClientes.IdCliente
        EntidadColonias.Consulta = Consulta.ConsultaDetallada
        NegocioColonias.Consultar(EntidadColonias)
        DgvCompradores.DataSource = EntidadColonias.TablaConsulta
    End Sub
End Class