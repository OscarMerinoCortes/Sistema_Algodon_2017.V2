Imports System.Data.SqlClient
Public Class CapturaBoletasPorLotes
    Public Overridable Sub Consultar(ByRef EntidadCapturaBoletasPorLotes As Capa_Entidad.CapturaBoletasPorLotes)
        Dim EntidadCapturaBoletasPorLotes1 As New Capa_Entidad.CapturaBoletasPorLotes
        EntidadCapturaBoletasPorLotes1 = EntidadCapturaBoletasPorLotes
        EntidadCapturaBoletasPorLotes1.TablaConsulta = New DataTable
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadCapturaBoletasPorLotes1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqldat1 = New SqlDataAdapter("sp_ConsultaModulos", cnn)
                    sqldat1.Fill(EntidadCapturaBoletasPorLotes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaModulosEntradas
                    sqldat1 = New SqlDataAdapter("sp_ConsultaModulosSinTara", cnn)
                    sqldat1.Fill(EntidadCapturaBoletasPorLotes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaModulosIncidencias
                    sqldat1 = New SqlDataAdapter("Sp_ConsultaIncidenciasBoletasPorLotes", cnn)
                    sqldat1.Fill(EntidadCapturaBoletasPorLotes1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCapturaBoletasPorLotes = EntidadCapturaBoletasPorLotes1
        End Try
    End Sub
    Public Overridable Sub Upsert(ByRef EntidadCapturaBoletasPorLotes As Capa_Entidad.CapturaBoletasPorLotes)
        Dim EntidadCapturaBoletasPorLotes1 As New Capa_Entidad.CapturaBoletasPorLotes
        EntidadCapturaBoletasPorLotes1 = EntidadCapturaBoletasPorLotes
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("ActualizaBoletaPeso", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@Idboleta", EntidadCapturaBoletasPorLotes1.Idboleta))
            cmdGuardar.Parameters.Add(New SqlParameter("@Bruto", EntidadCapturaBoletasPorLotes1.Bruto))
            cmdGuardar.Parameters.Add(New SqlParameter("@Tara", EntidadCapturaBoletasPorLotes1.Tara))
            cmdGuardar.Parameters.Add(New SqlParameter("@Total", EntidadCapturaBoletasPorLotes1.Neto))
            cmdGuardar.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCapturaBoletasPorLotes = EntidadCapturaBoletasPorLotes1
        End Try
    End Sub
    Public Overridable Sub UpsertAuto(ByRef EntidadCapturaBoletasPorLotes As Capa_Entidad.CapturaBoletasPorLotes)
        Dim EntidadCapturaBoletasPorLotes1 As New Capa_Entidad.CapturaBoletasPorLotes
        EntidadCapturaBoletasPorLotes1 = EntidadCapturaBoletasPorLotes
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("ActualizaBoletaPesoAuto", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@Idboleta", EntidadCapturaBoletasPorLotes1.Idboleta))
            cmdGuardar.Parameters.Add(New SqlParameter("@NoTransporte", EntidadCapturaBoletasPorLotes1.NoTransporte))
            cmdGuardar.Parameters.Add(New SqlParameter("@PesoBruto", EntidadCapturaBoletasPorLotes1.Bruto))
            cmdGuardar.Parameters.Add(New SqlParameter("@Tara", EntidadCapturaBoletasPorLotes1.Tara))
            cmdGuardar.Parameters.Add(New SqlParameter("@Neto", EntidadCapturaBoletasPorLotes1.Neto))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaActualizacion", EntidadCapturaBoletasPorLotes1.FechaActualizacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@TipoFlete", EntidadCapturaBoletasPorLotes1.TipoFlete))
            cmdGuardar.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCapturaBoletasPorLotes = EntidadCapturaBoletasPorLotes1
        End Try
    End Sub
End Class
