﻿Public Class CompraPacasContrato
    'Public Overridable Sub Guardar(ByRef EntidadCompraPacasContrato As Capa_Entidad.CompraPacasContrato)
    '    Dim EntidadCompraPacasContrato1 As New Capa_Entidad.CompraPacasContrato
    '    Dim DatosCompraPacasContrato As New Capa_Datos.CompraPacasContrato
    '    EntidadCompraPacasContrato1 = EntidadCompraPacasContrato
    '    DatosCompraPacasContrato.Upsert(EntidadCompraPacasContrato)
    'End Sub

    Public Overridable Sub Consultar(ByRef EntidadCompraPacasContrato As Capa_Entidad.CompraPacasContrato)
        Dim DatosCompraPacasContrato As New Capa_Datos.CompraPacasContrato
        DatosCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
    End Sub
End Class
