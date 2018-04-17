﻿Imports Capa_Operacion.Configuracion
Imports System.IO
Imports System.Data.OleDb
Public Class PaquetesHVI
        Public TablaPaquetesHVIGlobal As DataTable
        'Public Paquete As Integer
        Public NumeroPacas As Integer
        Private Sub BtSeleccionar_Click(sender As Object, e As EventArgs) Handles BtSeleccionar.Click
            ' Call ShowDialog.
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.Filter = "Access Database (*.mdb)|*.mdb| & All Files|*.*"
            Dim result As DialogResult = OpenFileDialog1.ShowDialog()
            If result = DialogResult.OK Then
                Dim path As String = OpenFileDialog1.FileName
                TbRuta.Text = path
                AbrirBaseDatosAccess()
                Inhabilitar()
                ContarFilas()
            End If
        End Sub

        Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
            Limpiar()
        End Sub

        Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
            If DgvPaquetesHVI.DataSource IsNot Nothing And TbPaquete.Text = "" Then
                Guardar()
                MsgBox("Guardado con éxito.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Aviso")
            Else
                MsgBox("Por favor, cargar la base de datos de access.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
            End If
        End Sub

        Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
            Close()
        End Sub

        Private Sub Limpiar()
            TbIdPaqueteHVI.Text = ""
            CbPlanta.SelectedValue = 1
            DtpFecha.Value = Now
            TbPaquete.Text = ""
            TbRuta.Text = ""
            Habilitar()
            DgvPaquetesHVI.DataSource = Nothing
        End Sub

        Private Sub CargarCombos()
            '---Planta Origen--
            Dim EntidadPaquetesHVI As New Capa_Entidad.PaquetesHVI
            Dim NegocioPaquetesHVI As New Capa_Negocio.PaquetesHVI
            Dim Tabla As New DataTable
            EntidadPaquetesHVI.Consulta = Consulta.ConsultaExterna
            NegocioPaquetesHVI.Consultar(EntidadPaquetesHVI)
            Tabla = EntidadPaquetesHVI.TablaConsulta
            CbPlanta.DataSource = Tabla
            CbPlanta.ValueMember = "IdPlanta"
            CbPlanta.DisplayMember = "Descripcion"
            CbPlanta.SelectedValue = 1
            '---------------------------COMBO ESTATUS
            Dim dt As DataTable = New DataTable("Tabla")
            dt.Columns.Add("IdEstatus")
            dt.Columns.Add("Descripcion")
            Dim dr As DataRow
            dr = dt.NewRow()
            dr("IdEstatus") = "1"
            dr("Descripcion") = "Activo"
            dt.Rows.Add(dr)
            dr = dt.NewRow()
            dr("IdEstatus") = "2"
            dr("Descripcion") = "Inactivo"
            dt.Rows.Add(dr)
            CbEstatus.DataSource = dt
            CbEstatus.ValueMember = "IdEstatus"
            CbEstatus.DisplayMember = "Descripcion"
            CbEstatus.SelectedValue = 1
        End Sub

        Private Sub PaquetesHVI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            CargarCombos()
            Limpiar()
        End Sub

        Private Sub AbrirBaseDatosAccess()
            Dim bbdd As OleDbConnection
            Dim dt As New DataTable
            Dim sConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & TbRuta.Text
            bbdd = New OleDb.OleDbConnection(sConnString)
            bbdd.Open()
            Dim ds As DataSet
            ds = New DataSet()
            Dim cm As OleDbCommand
            cm = New OleDbCommand("SELECT * FROM " & "SystemTestData", bbdd)
            Dim da As OleDbDataAdapter
            da = New OleDbDataAdapter(cm)
            da.Fill(ds)
            dt = ds.Tables(0)
            DgvPaquetesHVI.DataSource = dt
            TablaPaquetesHVIGlobal = dt
            'Paquete = dt.Rows(0).Item("LotID")
            bbdd.Close()
        End Sub

        Private Sub Inhabilitar()
            TbPaquete.Enabled = False
        End Sub

        Private Sub Habilitar()
            TbPaquete.Enabled = True
            BtSeleccionar.Enabled = True
        End Sub

        Private Sub Guardar()
            Dim EntidadPaquetesHVI As New Capa_Entidad.PaquetesHVI
            Dim NegocioPaquetesHVI As New Capa_Negocio.PaquetesHVI
            EntidadPaquetesHVI.IdPaqueteHVI = IIf(TbIdPaqueteHVI.Text = "", 0, TbIdPaqueteHVI.Text)
            EntidadPaquetesHVI.NumeroPacas = NumeroPacas
            EntidadPaquetesHVI.IdPlanta = CbPlanta.SelectedValue
            EntidadPaquetesHVI.Fecha = DtpFecha.Value
            EntidadPaquetesHVI.IdEstatus = CbEstatus.SelectedValue
            EntidadPaquetesHVI.IdUsuarioCreacion = 1
            EntidadPaquetesHVI.FechaCreacion = Now
            EntidadPaquetesHVI.IdUsuarioActualizacion = 1
            EntidadPaquetesHVI.FechaActualizacion = Now
            EntidadPaquetesHVI.TablaGlobal = TablaPaquetesHVIGlobal
            NegocioPaquetesHVI.Guardar(EntidadPaquetesHVI)
            TbIdPaqueteHVI.Text = EntidadPaquetesHVI.IdPaqueteHVI
        End Sub

        Private Sub ContarFilas()
            NumeroPacas = DgvPaquetesHVI.RowCount
        End Sub

        Private Sub TbPaquete_KeyDown(sender As Object, e As KeyEventArgs) Handles TbPaquete.KeyDown
            Select Case e.KeyData
                Case Keys.Enter
                    If TbPaquete.Text <> "" Then
                        Dim EntidadPaquetesHVI As New Capa_Entidad.PaquetesHVI
                        Dim NegocioPaquetesHVI As New Capa_Negocio.PaquetesHVI
                        EntidadPaquetesHVI.Consulta = Consulta.ConsultaDetallada
                        EntidadPaquetesHVI.IdPaquete = TbPaquete.Text
                        NegocioPaquetesHVI.Consultar(EntidadPaquetesHVI)
                        TablaPaquetesHVIGlobal = EntidadPaquetesHVI.TablaConsulta
                        DgvPaquetesHVI.DataSource = TablaPaquetesHVIGlobal
                        BtSeleccionar.Enabled = False
                    Else
                        MsgBox("Por favor, ingrese el ID del paquete", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
                        Exit Sub
                    End If
            End Select
        End Sub
End Class