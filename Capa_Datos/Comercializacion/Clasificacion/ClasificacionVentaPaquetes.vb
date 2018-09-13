﻿Imports System.Data.SqlClient
Public Class ClasificacionVentaPaquetes
    Public Overridable Sub Consultar(ByRef EntidadClasificacionVentaPaquetes As Capa_Entidad.ClasificacionVentaPaquetes)
        Dim EntidadClasificacionVentaPaquetes1 As New Capa_Entidad.ClasificacionVentaPaquetes
        EntidadClasificacionVentaPaquetes1 = EntidadClasificacionVentaPaquetes
        EntidadClasificacionVentaPaquetes1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadClasificacionVentaPaquetes1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaClases
                    sqldat1 = New SqlDataAdapter("sp_LlenarComboClases", cnn)
                    sqldat1.Fill(EntidadClasificacionVentaPaquetes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPaca
                    sqlcom1 = New SqlCommand("sp_consultaClasesCalculo", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@NumPaca", EntidadClasificacionVentaPaquetes.NumeroPaca))
                    sqldat1.Fill(EntidadClasificacionVentaPaquetes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaClasesDetalle
                    sqlcom1 = New SqlCommand("sp_SeleccionClase", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@GradoColor", EntidadClasificacionVentaPaquetes.GradoColor))
                    sqlcom1.Parameters.Add(New SqlParameter("@TrashId", EntidadClasificacionVentaPaquetes.TrashId))
                    sqldat1.Fill(EntidadClasificacionVentaPaquetes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqlcom1 = New SqlCommand("sp_ConsultaPaqueteEncabezadoDetalle", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdPaquete", EntidadClasificacionVentaPaquetes.IdPaquete))
                    sqldat1.Fill(EntidadClasificacionVentaPaquetes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPorId
                    sqlcom1 = New SqlCommand("sp_ConsultaPacasCalculoClasif", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdPaquete", EntidadClasificacionVentaPaquetes.IdPaquete))
                    sqldat1.Fill(EntidadClasificacionVentaPaquetes1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadClasificacionVentaPaquetes = EntidadClasificacionVentaPaquetes1
        End Try
    End Sub
    Public Overridable Sub Upsert(ByRef EntidadClasificacionVentaPaquetes As Capa_Entidad.ClasificacionVentaPaquetes)
        Dim EntidadClasificacionVentaPaquetes1 As New Capa_Entidad.ClasificacionVentaPaquetes
        EntidadClasificacionVentaPaquetes1 = EntidadClasificacionVentaPaquetes
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As New SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarPaqueteEncabezado", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdPaquete", EntidadClasificacionVentaPaquetes1.IdPaquete))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdPlanta", EntidadClasificacionVentaPaquetes1.IdPlanta))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdClase", EntidadClasificacionVentaPaquetes1.IdClase))
            cmdGuardar.Parameters.Add(New SqlParameter("@CantidadPacas", EntidadClasificacionVentaPaquetes1.CantidadPacas))
            cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadClasificacionVentaPaquetes1.Descripcion))
            cmdGuardar.Parameters.Add(New SqlParameter("@chkrevisado", EntidadClasificacionVentaPaquetes1.chkrevisado))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadClasificacionVentaPaquetes1.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadClasificacionVentaPaquetes1.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadClasificacionVentaPaquetes1.FechaCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioActualizacion", EntidadClasificacionVentaPaquetes1.IdUsuarioActualizacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaActualizacion", EntidadClasificacionVentaPaquetes1.FechaActualizacion))
            cmdGuardar.Parameters("@IdPaquete").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadClasificacionVentaPaquetes1.IdPaquete = 0 Then
                EntidadClasificacionVentaPaquetes1.IdPaquete = cmdGuardar.Parameters("@IdPaquete").Value
            End If
            If EntidadClasificacionVentaPaquetes1.chkrevisado = False Then
                For Each MiTableRow As DataRow In EntidadClasificacionVentaPaquetes1.TablaGeneral.Rows
                    cmdGuardar = New SqlCommand("sp_InsertarClasificacionPacas", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Clear()
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdCalculoClasificacion", 0))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdPaqueteEncabezado", EntidadClasificacionVentaPaquetes1.IdPaquete))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdHviDetalle", MiTableRow("IdHviDetalle")))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", MiTableRow("IdOrdenTrabajo")))
                    cmdGuardar.Parameters.Add(New SqlParameter("@BaleId", MiTableRow("BaleId")))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Mic", MiTableRow("Mic")))
                    cmdGuardar.Parameters.Add(New SqlParameter("@ColorGrade", MiTableRow("ColorGrade")))
                    cmdGuardar.Parameters.Add(New SqlParameter("@TrashId", MiTableRow("TrashId")))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Clase", MiTableRow("Clase")))
                    cmdGuardar.Parameters.Add(New SqlParameter("@UHML", MiTableRow("UHML")))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Strength", MiTableRow("Strength")))
                    cmdGuardar.Parameters.Add(New SqlParameter("@SCI", MiTableRow("SCI")))
                    cmdGuardar.Parameters.Add(New SqlParameter("@flagterminado", MiTableRow("flagterminado")))
                    cmdGuardar.ExecuteNonQuery()
                Next
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadClasificacionVentaPaquetes = EntidadClasificacionVentaPaquetes1
        End Try
    End Sub
    Public Overridable Sub UpsertHvi(ByRef EntidadClasificacionVentaPaquetes As Capa_Entidad.ClasificacionVentaPaquetes)
        Dim EntidadClasificacionVentaPaquetes1 As New Capa_Entidad.ClasificacionVentaPaquetes
        EntidadClasificacionVentaPaquetes1 = EntidadClasificacionVentaPaquetes
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertaClasesCalculo", cnn)
            sqldat1 = New SqlDataAdapter(cmdGuardar)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@NumPaca", EntidadClasificacionVentaPaquetes1.NumeroPaca))
            cmdGuardar.ExecuteNonQuery()
            'sqldat1.Fill(EntidadClasificacionVentaPaquetes1.TablaConsulta)
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadClasificacionVentaPaquetes = EntidadClasificacionVentaPaquetes1
        End Try
    End Sub
End Class
