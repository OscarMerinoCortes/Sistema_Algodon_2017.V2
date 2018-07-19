Imports Capa_Operacion.Configuracion
Public Class Etiquetas
    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Limpiar()
    End Sub
    Private Sub Etiquetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCombos()
        ConsultarUltimaPaca()
    End Sub

    Private Sub ConsultarUltimaPaca()
        Dim EntidadEtiquetas As New Capa_Entidad.Etiquetas
        Dim NegocioEtiquetas As New Capa_Negocio.Etiquetas
        Dim Tabla As New DataTable
        EntidadEtiquetas.Consulta = Consulta.ConsultaPorId
        EntidadEtiquetas.IdPlanta = CbPlanta.SelectedValue
        NegocioEtiquetas.Consultar(EntidadEtiquetas)
        Tabla = EntidadEtiquetas.TablaConsulta
        TbUltimaPaca.Text = Tabla.Rows(0).Item("Secuencia")
        If TbUltimaPaca.Text = 0 Then
            MsgBox("No hay pacas registradas en producciòn", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub

    Private Sub LlenarCombos()
        '---Planta--
        Dim EntidadEtiquetas As New Capa_Entidad.Etiquetas
        Dim NegocioEtiquetas As New Capa_Negocio.Etiquetas
        Dim Tabla As New DataTable
        EntidadEtiquetas.Consulta = Consulta.ConsultaExterna
        NegocioEtiquetas.Consultar(EntidadEtiquetas)
        Tabla = EntidadEtiquetas.TablaConsulta
        CbPlanta.DataSource = Tabla
        CbPlanta.ValueMember = "IdPlanta"
        CbPlanta.DisplayMember = "Descripcion"
        CbPlanta.SelectedValue = 1
    End Sub

    Private Sub CbPlanta_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbPlanta.SelectionChangeCommitted
        ConsultarUltimaPaca()
    End Sub

    Private Sub BtActualizar_Click(sender As Object, e As EventArgs) Handles BtActualizar.Click
        Dim EntidadEtiquetas As New Capa_Entidad.Etiquetas
        Dim NegocioEtiquetas As New Capa_Negocio.Etiquetas
        EntidadEtiquetas.IdPlanta = CbPlanta.SelectedValue
        EntidadEtiquetas.Etiqueta = CInt(TbEtiquetaActual.Text)
        NegocioEtiquetas.Actualizar(EntidadEtiquetas)
        Limpiar()
        'MsgBox("Actualizacion exitosa", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Success")
        ConsultarUltimaPaca()
    End Sub

    Private Sub Limpiar()
        TbEtiquetaActual.Text = ""
    End Sub
End Class