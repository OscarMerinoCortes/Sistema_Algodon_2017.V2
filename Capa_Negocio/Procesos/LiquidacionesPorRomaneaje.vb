Public Class LiquidacionesPorRomaneaje
    Public Overridable Sub Guardar(ByRef EntidadLiquidacionesPorRomaneaje As Capa_Entidad.LiquidacionesPorRomaneaje)
        Dim EntidadLiquidacionesPorRomaneaje1 As New Capa_Entidad.LiquidacionesPorRomaneaje
        Dim DatosLiquidacionesPorRomaneaje As New Capa_Datos.LiquidacionesPorRomaneaje
        EntidadLiquidacionesPorRomaneaje1 = EntidadLiquidacionesPorRomaneaje
        DatosLiquidacionesPorRomaneaje.Upsert(EntidadLiquidacionesPorRomaneaje1)
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadLiquidacionesPorRomaneaje As Capa_Entidad.LiquidacionesPorRomaneaje)
        Dim DatosLiquidacionesPorRomaneaje As New Capa_Datos.LiquidacionesPorRomaneaje
        DatosLiquidacionesPorRomaneaje.Consultar(EntidadLiquidacionesPorRomaneaje)
    End Sub
    Public Overridable Sub upsert(ByRef EntidadLiquidacionesPorRomaneaje As Capa_Entidad.LiquidacionesPorRomaneaje)
        Dim DatosLiquidacionesPorRomaneaje As New Capa_Datos.LiquidacionesPorRomaneaje
        DatosLiquidacionesPorRomaneaje.Upsert(EntidadLiquidacionesPorRomaneaje)
    End Sub
End Class
