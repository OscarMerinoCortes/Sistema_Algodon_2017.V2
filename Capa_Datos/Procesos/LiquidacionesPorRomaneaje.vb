Imports System.Data.SqlClient
Public Class LiquidacionesPorRomaneaje
    Public Overridable Sub Consultar(ByRef EntidadLiquidacionesPorRomaneaje As Capa_Entidad.LiquidacionesPorRomaneaje)
        Dim EntidadLiquidacionesPorRomaneaje1 As New Capa_Entidad.LiquidacionesPorRomaneaje
        EntidadLiquidacionesPorRomaneaje1 = EntidadLiquidacionesPorRomaneaje
        EntidadLiquidacionesPorRomaneaje1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadLiquidacionesPorRomaneaje1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaModulosLiquidacion
                    sqldat1 = New SqlDataAdapter("sp_ConsultaModulos", cnn)
                    sqldat1.Fill(EntidadLiquidacionesPorRomaneaje1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaOrden
                    sqlcom1 = New SqlCommand("sp_ConsultaOrdenTrabajoLiquidacion", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadLiquidacionesPorRomaneaje1.IdOrdenTrabajo))
                    sqldat1.Fill(EntidadLiquidacionesPorRomaneaje1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqlcom1 = New SqlCommand("sp_ConsultaModulosLiquidacion", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadLiquidacionesPorRomaneaje1.IdOrdenTrabajo))
                    sqldat1.Fill(EntidadLiquidacionesPorRomaneaje1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaColonias
                    '    sqldat1 = New SqlDataAdapter("sp_ConsultaColonias", cnn)
                    '    sqldat1.Fill(EntidadOrdenTrabajo1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaProductorId
                    '    sqlcom1 = New SqlCommand("sp_ConsultaProductorId", cnn)
                    '    sqldat1 = New SqlDataAdapter(sqlcom1)
                    '    sqlcom1.CommandType = CommandType.StoredProcedure
                    '    sqlcom1.Parameters.Clear()
                    '    sqlcom1.Parameters.Add(New SqlParameter("@IdProductor", EntidadOrdenTrabajo1.IdProductor))
                    '    sqldat1.Fill(EntidadOrdenTrabajo1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaRango
                    '    sqldat1 = New SqlDataAdapter("sp_ConsultaUltimoRango", cnn)
                    '    sqldat1.Fill(EntidadOrdenTrabajo1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    '    sqldat1 = New SqlDataAdapter("sp_ConsultaBasicaOrdenes", cnn)
                    '    sqldat1.Fill(EntidadOrdenTrabajo1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadLiquidacionesPorRomaneaje = EntidadLiquidacionesPorRomaneaje1
        End Try
    End Sub
    Public Overridable Sub Upsert(ByRef EntidadLiquidacionesPorRomaneaje As Capa_Entidad.LiquidacionesPorRomaneaje)
        Dim EntidadLiquidacionesPorRomaneaje1 As New Capa_Entidad.LiquidacionesPorRomaneaje
        EntidadLiquidacionesPorRomaneaje1 = EntidadLiquidacionesPorRomaneaje
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarLiquidacionPorRomaneaje", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdLiquidacion", EntidadLiquidacionesPorRomaneaje1.IdLiquidacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadLiquidacionesPorRomaneaje1.IdOrdenTrabajo))
            cmdGuardar.Parameters.Add(New SqlParameter("@Fecha", EntidadLiquidacionesPorRomaneaje1.Fecha))
            cmdGuardar.Parameters.Add(New SqlParameter("@Comentarios", EntidadLiquidacionesPorRomaneaje1.Comentarios))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadLiquidacionesPorRomaneaje1.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadLiquidacionesPorRomaneaje1.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadLiquidacionesPorRomaneaje1.FechaCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioActualizacion", EntidadLiquidacionesPorRomaneaje1.IdUsuarioActualizacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaActualizacion", EntidadLiquidacionesPorRomaneaje1.FechaActualizacion))
            cmdGuardar.Parameters("@IdLiquidacion").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadLiquidacionesPorRomaneaje1.IdLiquidacion = 0 Then
                EntidadLiquidacionesPorRomaneaje1.IdLiquidacion = cmdGuardar.Parameters("@IdLiquidacion").Value
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadLiquidacionesPorRomaneaje = EntidadLiquidacionesPorRomaneaje1
        End Try
    End Sub
End Class
