﻿Imports Capa_Operacion.Configuracion
Public Class Etiquetas
    Dim IdProduccion As Integer
    Dim IdOrdenTrabajo As Integer
    Dim IdPlantaOrigen As Integer
    Dim UltimaSecuencia As Integer
    Private Sub Etiquetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCombos()
        Limpiar()
    End Sub

    Private Sub ConsultarUltimaPaca()
        'Dim EntidadEtiquetas As New Capa_Entidad.Etiquetas
        'Dim NegocioEtiquetas As New Capa_Negocio.Etiquetas
        'Dim Tabla As New DataTable
        'EntidadEtiquetas.Consulta = Consulta.ConsultaPorId
        'EntidadEtiquetas.IdPlanta = CbPlanta.SelectedValue
        'NegocioEtiquetas.Consultar(EntidadEtiquetas)
        'Tabla = EntidadEtiquetas.TablaConsulta
        'TbUltimaPaca.Text = Tabla.Rows(0).Item("Secuencia")
        'If TbUltimaPaca.Text = 0 Then
        '    MsgBox("No hay pacas registradas en producciòn", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
        'End If
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

    Private Sub Limpiar()
        TbFolioInicial.Text = ""
        TbFolioInicial.Enabled = False
        TbIdProduccion.Enabled = True
        TbIdProduccion.Text = ""
        TbEtiquetaActual.Text = ""
        TbEtiquetaActual.Enabled = False
        TbIdProduccionInfo.Text = ""
        TbOrdenTrabajoInfo.Text = ""
        CbPlanta.SelectedIndex = -1
    End Sub

    Private Sub TbEtiquetaActual_Enter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbEtiquetaActual.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If ConsultarPacaExistente(TbEtiquetaActual.Text, IdPlantaOrigen) = 1 Then
                    MsgBox("Folio existente para esta planta, verificar", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
                    TbEtiquetaActual.Text = ""
                    Exit Sub
                Else
                    ConsultaUltimaSecuencia()
                    If TbEtiquetaActual.Text <> UltimaSecuencia Then
                        Dim opc = MessageBox.Show("El folio no coincide, ¿Desea reemplazarlo por el consecutivo" + " " + CStr(UltimaSecuencia) + " " + "siguiente?", "Aviso", MessageBoxButtons.YesNo)
                        If opc = DialogResult.Yes Then
                            TbEtiquetaActual.Text = UltimaSecuencia
                            Dim EntidadProduccion As New Capa_Entidad.Produccion
                            Dim NegocioProduccion As New Capa_Negocio.Produccion
                            EntidadProduccion.IdProduccionDetalle = 0
                            EntidadProduccion.IdProduccion = IdProduccion
                            EntidadProduccion.IdOrdenTrabajo = IdOrdenTrabajo
                            EntidadProduccion.IdPlantaOrigen = IdPlantaOrigen
                            EntidadProduccion.FolioCIA = TbEtiquetaActual.Text
                            EntidadProduccion.Tipo = ""
                            EntidadProduccion.Kilos = 0
                            EntidadProduccion.BandExiste = True
                            EntidadProduccion.IdTurno = 1
                            EntidadProduccion.IdEstatus = 1
                            EntidadProduccion.Fecha = Now
                            EntidadProduccion.IdBaja = 0
                            EntidadProduccion.FechaBaja = Now
                            EntidadProduccion.ClaveClasificacion = 0
                            EntidadProduccion.Micros = 0
                            EntidadProduccion.Castigo = 0
                            EntidadProduccion.CastigoMicCpa = 0
                            EntidadProduccion.CastigoMicVta = 0
                            EntidadProduccion.CastigoLargoFibra = 0
                            EntidadProduccion.CastigoLargoFibraCpa = 0
                            EntidadProduccion.CastigoLargoFibraVta = 0
                            EntidadProduccion.CastigoResistenciaFibra = 0
                            EntidadProduccion.CastigoResistenciaFibraCpa = 0
                            EntidadProduccion.CastigoResistenciaFibraVta = 0
                            EntidadProduccion.ClaveClasificacionCpa = 0
                            EntidadProduccion.ClaveClasificacionVta = 0
                            EntidadProduccion.FechaClasificacion = Now
                            EntidadProduccion.Libras = 0
                            EntidadProduccion.ClaveCertificado = 0
                            EntidadProduccion.ClaveContratoAlgodon = 0
                            EntidadProduccion.ClaveContratoAlgodon2 = 0
                            EntidadProduccion.ClavePaqueteHVI = 0
                            EntidadProduccion.LargoFibra = 0
                            EntidadProduccion.ResistenciaFibra = 0
                            NegocioProduccion.GuardarDetalle(EntidadProduccion)
                            ActualizarUltimaEtiqueta()
                            TbEtiquetaActual.Text = ""
                            'MsgBox("Folio existente para esta planta, verificar", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
                        Else
                            Dim EntidadProduccion As New Capa_Entidad.Produccion
                            Dim NegocioProduccion As New Capa_Negocio.Produccion
                            EntidadProduccion.IdProduccionDetalle = 0
                            EntidadProduccion.IdProduccion = IdProduccion
                            EntidadProduccion.IdOrdenTrabajo = IdOrdenTrabajo
                            EntidadProduccion.IdPlantaOrigen = IdPlantaOrigen
                            EntidadProduccion.FolioCIA = TbEtiquetaActual.Text
                            EntidadProduccion.Tipo = ""
                            EntidadProduccion.Kilos = 0
                            EntidadProduccion.BandExiste = True
                            EntidadProduccion.IdTurno = 1
                            EntidadProduccion.IdEstatus = 1
                            EntidadProduccion.Fecha = Now
                            EntidadProduccion.IdBaja = 0
                            EntidadProduccion.FechaBaja = Now
                            EntidadProduccion.ClaveClasificacion = 0
                            EntidadProduccion.Micros = 0
                            EntidadProduccion.Castigo = 0
                            EntidadProduccion.CastigoMicCpa = 0
                            EntidadProduccion.CastigoMicVta = 0
                            EntidadProduccion.CastigoLargoFibra = 0
                            EntidadProduccion.CastigoLargoFibraCpa = 0
                            EntidadProduccion.CastigoLargoFibraVta = 0
                            EntidadProduccion.CastigoResistenciaFibra = 0
                            EntidadProduccion.CastigoResistenciaFibraCpa = 0
                            EntidadProduccion.CastigoResistenciaFibraVta = 0
                            EntidadProduccion.ClaveClasificacionCpa = 0
                            EntidadProduccion.ClaveClasificacionVta = 0
                            EntidadProduccion.FechaClasificacion = Now
                            EntidadProduccion.Libras = 0
                            EntidadProduccion.ClaveCertificado = 0
                            EntidadProduccion.ClaveContratoAlgodon = 0
                            EntidadProduccion.ClaveContratoAlgodon2 = 0
                            EntidadProduccion.ClavePaqueteHVI = 0
                            EntidadProduccion.LargoFibra = 0
                            EntidadProduccion.ResistenciaFibra = 0
                            NegocioProduccion.GuardarDetalle(EntidadProduccion)
                            ActualizarUltimaEtiqueta()
                            TbEtiquetaActual.Text = ""
                        End If
                    Else
                        Dim EntidadProduccion As New Capa_Entidad.Produccion
                        Dim NegocioProduccion As New Capa_Negocio.Produccion
                        EntidadProduccion.IdProduccionDetalle = 0
                        EntidadProduccion.IdProduccion = IdProduccion
                        EntidadProduccion.IdOrdenTrabajo = IdOrdenTrabajo
                        EntidadProduccion.IdPlantaOrigen = IdPlantaOrigen
                        EntidadProduccion.FolioCIA = TbEtiquetaActual.Text
                        EntidadProduccion.Tipo = ""
                        EntidadProduccion.Kilos = 0
                        EntidadProduccion.BandExiste = True
                        EntidadProduccion.IdTurno = 1
                        EntidadProduccion.IdEstatus = 1
                        EntidadProduccion.Fecha = Now
                        EntidadProduccion.IdBaja = 0
                        EntidadProduccion.FechaBaja = Now
                        EntidadProduccion.ClaveClasificacion = 0
                        EntidadProduccion.Micros = 0
                        EntidadProduccion.Castigo = 0
                        EntidadProduccion.CastigoMicCpa = 0
                        EntidadProduccion.CastigoMicVta = 0
                        EntidadProduccion.CastigoLargoFibra = 0
                        EntidadProduccion.CastigoLargoFibraCpa = 0
                        EntidadProduccion.CastigoLargoFibraVta = 0
                        EntidadProduccion.CastigoResistenciaFibra = 0
                        EntidadProduccion.CastigoResistenciaFibraCpa = 0
                        EntidadProduccion.CastigoResistenciaFibraVta = 0
                        EntidadProduccion.ClaveClasificacionCpa = 0
                        EntidadProduccion.ClaveClasificacionVta = 0
                        EntidadProduccion.FechaClasificacion = Now
                        EntidadProduccion.Libras = 0
                        EntidadProduccion.ClaveCertificado = 0
                        EntidadProduccion.ClaveContratoAlgodon = 0
                        EntidadProduccion.ClaveContratoAlgodon2 = 0
                        EntidadProduccion.ClavePaqueteHVI = 0
                        EntidadProduccion.LargoFibra = 0
                        EntidadProduccion.ResistenciaFibra = 0
                        NegocioProduccion.GuardarDetalle(EntidadProduccion)
                        ActualizarUltimaEtiqueta()
                        TbEtiquetaActual.Text = ""
                    End If
                End If
        End Select
    End Sub


    Private Sub TbIdProduccion_Enter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbIdProduccion.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                TbIdProduccion.Enabled = False
                TbFolioInicial.Enabled = True
                TbFolioInicial.Focus()
        End Select
    End Sub
    Private Sub TbFolioInicial_Enter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbFolioInicial.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Dim EntidadEtiquetas As New Capa_Entidad.Etiquetas
                Dim NegocioEtiquetas As New Capa_Negocio.Etiquetas
                Dim Tabla As New DataTable
                EntidadEtiquetas.Consulta = Consulta.ConsultaOrden
                EntidadEtiquetas.IdProduccion = CInt(TbIdProduccion.Text)
                NegocioEtiquetas.Consultar(EntidadEtiquetas)
                Tabla = EntidadEtiquetas.TablaConsulta
                If Tabla.Rows.Count <> 0 Then
                    IdProduccion = Tabla.Rows(0).Item("IdProduccion")
                    IdOrdenTrabajo = Tabla.Rows(0).Item("IdOrdenTrabajo")
                    IdPlantaOrigen = Tabla.Rows(0).Item("IdPlantaOrigen")
                    TbIdProduccionInfo.Text = IdProduccion
                    TbOrdenTrabajoInfo.Text = IdOrdenTrabajo
                    CbPlanta.SelectedValue = IdPlantaOrigen
                    TbFolioInicial.Enabled = False
                    TbEtiquetaActual.Enabled = True
                    TbEtiquetaActual.Focus()
                Else
                    MsgBox("No hay pacas registradas en producciòn", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
                End If
        End Select
    End Sub
    Private Function ConsultarPacaExistente(ByVal FolioCIA As Integer, ByVal IdPlantaElabora As Integer)
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaPacaExistente
        EntidadProduccion.FolioCIA = TbEtiquetaActual.Text
        EntidadProduccion.IdPlantaOrigen = IdPlantaOrigen
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        If Tabla.Rows(0).Item("Resultado") = 1 Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Sub ConsultaUltimaSecuencia()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaSecuencia
        EntidadProduccion.IdPlantaOrigen = IdPlantaOrigen
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            UltimaSecuencia = 1
        Else
            UltimaSecuencia = Tabla.Rows(0).Item("Secuencia")
        End If
    End Sub

    Private Sub ActualizarUltimaEtiqueta()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.IdPlantaOrigen = IdPlantaOrigen
        EntidadProduccion.FolioCIA = TbEtiquetaActual.Text
        NegocioProduccion.GuardarEtiqueta(EntidadProduccion)
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
End Class