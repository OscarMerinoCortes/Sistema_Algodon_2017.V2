﻿
Namespace Configuracion

    'Namespace Constante
    '    'para uso en VENTA ==============================================================
    '    Public Enum TipoVenta
    '        Credito = 1
    '        Contado = 2
    '        Apartado = 3
    '        Ninguno = 4
    '    End Enum
    '    Public Enum DasboardOpcion
    '        Grafica1 = 1
    '        Grafica2 = 2
    '        Grafica3 = 3
    '        Grafica4 = 4
    '        Grafica5 = 5
    '        Grafica6 = 6
    '    End Enum
    '    Public Enum TipoEntrega
    '        DelCliente = 1
    '        EnMano = 2
    '        ClientePasa = 3
    '    End Enum
    '    Public Enum TipoVentaEstado
    '        AUTORIZADO = 1
    '        CANCELADO = 2
    '        RECHAZADO = 3
    '        ACTIVO = 4
    '        LIQUIDADO = 5
    '        PENDIENTE = 6
    '    End Enum
    '    Public Enum Cantidad
    '        Ninguno = 1
    '        Agregar = 2
    '        Quitar = 3
    '        Descuento = 4
    '        Cantidad = 5
    '    End Enum
    Public Enum Reporte
        Clientes = 1
        'Producto = 2
        'Apartado = 3
        'AgregaDescuento = 4
        'AgregaCantidad = 5
        'Venta = 5
    End Enum
    Public Enum Eliminar
        EliminarRegistro = 1
        'VentanaBusquedaProducto = 2
        'VentanaBusquedaCliente = 3
        'VentanaBusquedaVenta = 4
        'VentanaCredito = 5
        'VentanaContado = 6
        'VentanaAviso = 7
    End Enum
    '    '==============================================================================
    '    Public Class Formato
    '        Public Shared Miles As String = "#,###,##0.00"
    '        Public Shared Porcentaje As String = "##0.##%"
    '        Public Shared FechaCorta As String = "{0:d}"
    '        Public Shared Moneda As String = "$#,###,##0.00"
    '    End Class
    Public Enum Consulta
        ConsultaEstado = 1
        ConsultaMunicipio = 2
        ConsultaTipoPersona = 3
        ConsultaMunicipioMovilizacion = 4
        ConsultaEstadoMoral = 5
        ConsultaEstadoApoderado = 6
        ConsultaMunicipioApoderado = 7
        ConsultaDetallada = 8
        ConsultaAsociaciones = 9
        ConsultaBasica = 10
        ConsultaExterna = 11
        ConsultaClases = 12
        ConsultaClasesDetalle = 13
        ConsultaTierras = 14
        ConsultaDiferenciales = 15
        ConsultaVariedadesAlgodon = 16
        ConsultaProductores = 17
        ConsultaCompradores = 18
        ConsultaColonias = 19
        ConsultaProductorId = 20
        ConsultaRango = 21
        ConsultaOperadores = 22
        ConsultaPorId = 23
        ConsultaOrden = 24
        ConsultaModulosLiquidacion = 25
        ConsultaPaca = 26
        ConsultaModoCompra = 27
        ConsultaPacaExistente = 28
        ConsultaSecuencia = 29
        ConsultaModulosEntradas = 30
        ConsultaModulosIncidencias = 31
        ConsultaEncabezado = 32
        ConsultaBaseDatos = 33
        ConsultaInstancia = 34
        ConsultaLiquidaciones = 35
        'Para consulta de castigos
        ConsultaResistenciaFibra = 36
        ConsultaLargoFibra = 37
        ConsultaMicros = 38
        ConsultaModalidadCompra = 39
    End Enum
    Public Enum LlenaCombo
        LlenaComboCliente = 1
        LlenaComboColonia = 2
        LlenaComboRegimen = 3
        LlenaComboBaseDatos = 4
    End Enum
End Namespace

