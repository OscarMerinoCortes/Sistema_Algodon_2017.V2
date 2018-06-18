Imports Capa_Operacion.Configuracion
Public Class CompraPacasContrato
    Private Sub CompraPacasContrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nuevo()
        CargarCombos()
    End Sub
    Private Sub Nuevo()
        TbIdProductor.Focus()
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
        Dim Tabla2 As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaModoCompra
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla2 = EntidadProduccion.TablaConsulta
        CbModalidadCompra.DataSource = Tabla2
        CbModalidadCompra.ValueMember = "IdModoEncabezado"
        CbModalidadCompra.DisplayMember = "Descripcion"
        CbModalidadCompra.SelectedValue = 0
    End Sub
    Private Sub BtCastigosPorMicros_Click(sender As Object, e As EventArgs) Handles BtCastigosPorMicros.Click
        CastigosMicros.ShowDialog()
    End Sub
    Private Sub BtCastigoResistenciaFibra_Click(sender As Object, e As EventArgs) Handles BtCastigoResistenciaFibra.Click
        CastigosResistenciasFibras.ShowDialog()
    End Sub
    Private Sub BtDiferenciasPorClases_Click(sender As Object, e As EventArgs) Handles BtDiferenciasPorClases.Click
        ClasesDif.ShowDialog()
    End Sub
    Private Sub BtCastigosLargoFibra_Click(sender As Object, e As EventArgs) Handles BtCastigosLargoFibra.Click
        CastigosLargoFibra.ShowDialog()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Nuevo()
    End Sub
End Class