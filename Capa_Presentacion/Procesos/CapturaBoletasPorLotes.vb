Imports Capa_Operacion.Configuracion
Public Class CapturaBoletasPorLotes
    Private Sub CapturaBoletasPorLotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultaModulos()
    End Sub
    Private Sub ConsultaModulos()
        Dim EntidadCapturaBoletasPorLotes As New Capa_Entidad.CapturaBoletasPorLotes
        Dim NegocioCapturaBoletasPorLotes As New Capa_Negocio.CapturaBoletasPorLotes
        Dim Tabla As New DataTable
        EntidadCapturaBoletasPorLotes.Consulta = Consulta.ConsultaDetallada
        NegocioCapturaBoletasPorLotes.Consultar(EntidadCapturaBoletasPorLotes)
        DgvModulos.DataSource = EntidadCapturaBoletasPorLotes.TablaConsulta
        propiedadesDgv()
    End Sub
    Private Sub propiedadesDgv()
        DgvModulos.Columns("IdPlanta").HeaderText = "ID Planta"
        DgvModulos.Columns("FechaOrden").HeaderText = "Fecha de Orden"
        DgvModulos.Columns("Bruto").HeaderText = "Bruto"
        DgvModulos.Columns("Tara").HeaderText = "Tara"
        DgvModulos.Columns("Total").HeaderText = "Total"
        DgvModulos.Columns("Nombre").HeaderText = "Productor"
        DgvModulos.Columns("IdOrdenTrabajo").HeaderText = "Orden de Trabajo"
        DgvModulos.Columns("FlagCancelada").HeaderText = "Cancelado"
        DgvModulos.Columns("FlagRevisada").HeaderText = "Revisado"

        DgvModulos.Columns("IdBoleta").Visible = False
        DgvModulos.Columns("IdPlanta").ReadOnly = True
        DgvModulos.Columns("FechaOrden").ReadOnly = True
        DgvModulos.Columns("Bruto").ReadOnly = False
        DgvModulos.Columns("Tara").ReadOnly = False
        DgvModulos.Columns("Total").ReadOnly = True
        DgvModulos.Columns("Nombre").ReadOnly = True
        DgvModulos.Columns("IdOrdenTrabajo").ReadOnly = True
        DgvModulos.Columns("FlagCancelada").ReadOnly = False
        DgvModulos.Columns("FlagRevisada").ReadOnly = False
    End Sub
    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DgvModulos.CellEnter
        Dim Total, Bruto, Tara As Double
        Dim IndexCell As Integer = IIf(e.RowIndex > 0, e.RowIndex - 1, e.RowIndex)
        Bruto = CDbl(DgvModulos.Rows(IndexCell).Cells("Bruto").Value)
        Tara = CDbl(DgvModulos.Rows(IndexCell).Cells("Tara").Value)
        If Tara > Bruto Then
            MsgBox("La tara no puede ser mayor al peso Bruto")
            DgvModulos.Rows(IndexCell).Cells("Total").Value = 0
        Else
            Total = Bruto - Tara
            DgvModulos.Rows(IndexCell).Cells("Total").Value = Total
            ActualizaPesoModulo(IndexCell, DgvModulos.Rows(IndexCell).Cells("IdBoleta").Value, Bruto, Tara, Total)
        End If
    End Sub
    Private Sub ActualizaPesoModulo(ByVal IndexCell As Integer, ByVal IdBoleta As Integer, ByVal Bruto As Double, ByVal Tara As Double, ByVal Total As Double)
        Dim EntidadCapturaBoletasPorLotes As New Capa_Entidad.CapturaBoletasPorLotes
        Dim NegocioCapturaBoletasPorLotes As New Capa_Negocio.CapturaBoletasPorLotes
        EntidadCapturaBoletasPorLotes.Idboleta = IdBoleta
        EntidadCapturaBoletasPorLotes.Bruto = Bruto
        EntidadCapturaBoletasPorLotes.Tara = Tara
        EntidadCapturaBoletasPorLotes.Total = Total
        NegocioCapturaBoletasPorLotes.upsert(EntidadCapturaBoletasPorLotes)
        'TbIdOrdenTrabajo.Text = EntidadCapturaBoletasPorLotes.IdOrdenTrabajo
        'MsgBox("Realizado Correctamente")
        'ConsultarCapturas()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        ConsultaModulos()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class