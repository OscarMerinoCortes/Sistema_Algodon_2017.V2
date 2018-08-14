Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Public Class Menu
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Clientes.ShowDialog()
    End Sub
    Private Sub TsSalir_Click(sender As Object, e As EventArgs) Handles TsSalir.Click
        Close()
    End Sub
    Private Sub AsociacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsociacionesToolStripMenuItem.Click
        Asociaciones.ShowDialog()
    End Sub
    Private Sub CompradoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompradoresToolStripMenuItem.Click
        Compradores.ShowDialog()
    End Sub
    Private Sub ColoniasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColoniasToolStripMenuItem.Click
        Colonias.ShowDialog()
    End Sub
    Private Sub MunicipiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MunicipiosToolStripMenuItem.Click
        Municipios.ShowDialog()
    End Sub
    Private Sub PlantasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlantasToolStripMenuItem.Click
        Plantas.ShowDialog()
    End Sub
    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Empleados.ShowDialog()
    End Sub
    Private Sub CamionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CamionesToolStripMenuItem.Click
        Camiones.ShowDialog()
    End Sub
    Private Sub CapturaDeLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapturaDeLToolStripMenuItem.Click
        OrdenTrabajo.ShowDialog()
    End Sub
    Private Sub CapturaDeBoletasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapturaDeBoletasToolStripMenuItem.Click
        CapturaBoletas.ShowDialog()
    End Sub
    Private Sub TiposDeIncidenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeIncidenciasToolStripMenuItem.Click
        TiposIncidencias.ShowDialog()
    End Sub
    Private Sub IncidenciasDeParoDeOperacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncidenciasDeParoDeOperacionesToolStripMenuItem.Click
        IncidenciaOperaciones.ShowDialog()
    End Sub
    Private Sub PuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PuestosToolStripMenuItem.Click
        Puestos.ShowDialog()
    End Sub
    Private Sub MaquinariaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaquinariaToolStripMenuItem.Click
        Maquinaria.ShowDialog()
    End Sub
    Private Sub RangosDeTemperaturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RangosDeTemperaturaToolStripMenuItem.Click
        RangosTemperatura.ShowDialog()
    End Sub
    Private Sub ContratosDeAlgodónConProductoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContratosDeAlgodónConProductoresToolStripMenuItem.Click
        ContratosAlgodon.ShowDialog()
    End Sub
    Private Sub ProfesionalesFitosanitariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfesionalesFitosanitariosToolStripMenuItem.Click
        ProfesionalesFitosanitarios.ShowDialog()
    End Sub
    Private Sub ModalidadesDeCompraDePacasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModalidadesDeCompraDePacasToolStripMenuItem.Click
        ModalidadesCompra.ShowDialog()
    End Sub
    Private Sub TierrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TierrasToolStripMenuItem.Click
        Tierras.ShowDialog()
    End Sub
    Private Sub VariedadesDeAlgodónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VariedadesDeAlgodónToolStripMenuItem.Click
        VariedadesAlgodon.ShowDialog()
    End Sub
    Private Sub LargosDeFibraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LargosDeFibraToolStripMenuItem.Click
        LargoFibra.ShowDialog()
    End Sub
    Private Sub RendimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RendimientosToolStripMenuItem.Click
        Rendimientos.ShowDialog()
    End Sub
    Private Sub CastigosPorMicrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CastigosPorMicrosToolStripMenuItem.Click
        CastigoPorQuintal.ShowDialog()
    End Sub
    Private Sub RegímenesHídricosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegímenesHídricosToolStripMenuItem.Click
        RegimenHidrico.ShowDialog()
    End Sub
    Private Sub ContratosDeAlgodónConCompradoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContratosDeAlgodónConCompradoresToolStripMenuItem.Click
        ContratosAlgodonCompradores.ShowDialog()
    End Sub
    Private Sub ContratosDeSemillaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContratosDeSemillaToolStripMenuItem.Click
        ContratoSemillas.ShowDialog()
    End Sub
    Private Sub CastigosPorLargosDeFibraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CastigosPorLargosDeFibraToolStripMenuItem.Click
        CastigoLargoFibra.ShowDialog()
    End Sub
    Private Sub CastigosPorResistenciaDeFibraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CastigosPorResistenciaDeFibraToolStripMenuItem.Click
        CastigoResistenciaFibra.ShowDialog()
    End Sub
    Private Sub CapturaDeProducciónPacasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapturaDeProducciónPacasToolStripMenuItem.Click
        Produccion.Show()
    End Sub
    Private Sub CapturaDeBoletasPorLotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapturaDeBoletasPorLotesToolStripMenuItem.Click
        CapturaBoletasPorLotes.ShowDialog()
    End Sub
    Private Sub LiquidacionesPorRomaneajeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiquidacionesPorRomaneajeToolStripMenuItem.Click
        LiquidacionesPorRomaneaje.ShowDialog()
    End Sub
    Private Sub CompraDePacasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompraDePacasToolStripMenuItem.Click
        CompraPacas.ShowDialog()
    End Sub
    Private Sub CompraDePacasAProductoresPorContratoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompraDePacasAProductoresPorContratoToolStripMenuItem.Click
        CompraPacasContrato.ShowDialog()
    End Sub
    Private Sub AltaDePacasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDePacasToolStripMenuItem.Click
        AltaPacas.ShowDialog()
    End Sub
    Private Sub ClasificaciónDePacasConCertificadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClasificaciónDePacasConCertificadoToolStripMenuItem.Click
        ClasificacionPacasCertificado.ShowDialog()
    End Sub
    Private Sub PaquetesHVIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaquetesHVIToolStripMenuItem.Click
        PaquetesHVI.ShowDialog()
    End Sub

    Private Sub PaquetesParaVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaquetesParaVentaToolStripMenuItem.Click
        ClasificacionVentaPaquetes.ShowDialog()
    End Sub

    Private Sub ClasificaciónDePacasConArchivoExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClasificaciónDePacasConArchivoExcelToolStripMenuItem.Click
        ClasificacionPacasExcel.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        RepClientes.ShowDialog()
    End Sub

    Private Sub ChequearEtiquetaDePacaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChequearEtiquetaDePacaToolStripMenuItem.Click
        Etiquetas.Show()
    End Sub

    Private Sub ConfiguracionDeParametrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguracionDeParametrosToolStripMenuItem.Click
        ConfiguracionParametros.ShowDialog()
    End Sub

    Private Sub SalidaDePacasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaDePacasToolStripMenuItem.Click
        SalidaPacas.ShowDialog()
    End Sub
    Private Sub SalidaDeSemillaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaDeSemillaToolStripMenuItem.Click
        SalidaSemilla.ShowDialog()
    End Sub

    Private Sub SalidaDePacasDeBorraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaDePacasDeBorraToolStripMenuItem.Click
        SalidaPacasBorra.ShowDialog()
    End Sub

    Private Sub SalidaDeBasuraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaDeBasuraToolStripMenuItem.Click
        SalidaBasura.ShowDialog()
    End Sub
End Class
