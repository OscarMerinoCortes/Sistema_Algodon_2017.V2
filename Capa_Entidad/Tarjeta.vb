﻿Public Class Tarjeta
    Public Property Consulta As Capa_Operacion.Configuracion.Consulta
    Public Property Reporte As Capa_Operacion.Configuracion.Reporte
    Public Property Eliminar As Capa_Operacion.Configuracion.Eliminar
    Public Property LlenaCombo As Capa_Operacion.Configuracion.LlenaCombo
    Public Property TablaConsulta As DataTable
    Public Property TablaGeneral As DataTable
    Public Property IdExterno As Integer
    Public Property IdUsuarioCreacion As Integer
    Public Property FechaCreacion As DateTime
    Public Property IdUsuarioActualizacion As Integer
    Public Property FechaActualizacion As DateTime
    Public Property DescripcionConsulta As String
End Class
