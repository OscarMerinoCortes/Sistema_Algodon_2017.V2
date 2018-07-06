Imports Capa_Operacion.Configuracion
Imports System.IO.Ports
Public Class CapturaBoletasPorLotes
    Dim Puerto As String
    Dim com1 As IO.Ports.SerialPort = Nothing
    Dim bandera As Boolean = True
    Dim Salir As Boolean 'True sale del bucle, false sigue
    'Dim th As New Threading.Thread(AddressOf ReceiveSerialData)
    Private Sub CapturaBoletasPorLotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultaModulos()
        GetSerialPortNames()
        CheckForIllegalCrossThreadCalls = False
        LbStatus.Text = "CAPTURA AUTOMATICA DESACTIVADA"
    End Sub
    Sub Setup_Puerto_Serie()

        Try

            With SpCapturaAuto

                If .IsOpen Then

                    .Close()

                End If

                .PortName = CbPuertosSeriales.Text

                .BaudRate = 9600 '// 9600 baud rate

                .DataBits = 8 '// 8 data bits

                .StopBits = IO.Ports.StopBits.One '// 1 Stop bit

                .Parity = IO.Ports.Parity.None '

                .DtrEnable = False

                .Handshake = IO.Ports.Handshake.None

                .ReadBufferSize = 4096

                .WriteBufferSize = 2048

                '.ReceivedBytesThreshold = 1

                .WriteTimeout = 500

                .Encoding = System.Text.Encoding.Default

                .Open() ' ABRE EL PUERTO SERIE

            End With

        Catch ex As Exception

            MsgBox("Error al abrir el puerto serial: " & ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub
    Private Sub ConsultaModulos()
        Dim EntidadCapturaBoletasPorLotes As New Capa_Entidad.CapturaBoletasPorLotes
        Dim NegocioCapturaBoletasPorLotes As New Capa_Negocio.CapturaBoletasPorLotes
        Dim Tabla As New DataTable
        EntidadCapturaBoletasPorLotes.Consulta = Consulta.ConsultaDetallada
        NegocioCapturaBoletasPorLotes.Consultar(EntidadCapturaBoletasPorLotes)
        DgvModulos.DataSource = EntidadCapturaBoletasPorLotes.TablaConsulta
        propiedadesDgv()
    End Sub
    Sub ReceiveSerialData_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SpCapturaAuto.DataReceived
        'While bandera = True
        Dim NoTransporte, IdBoleta As Integer
        Dim Bruto, Tara, Neto As Double
        Dim TipoFlete As String = ""
        Dim returnStr As String = ""
        Dim FechaActualizacion As DateTime
        Dim numeroRecorrido As Integer = 0
        Dim az As String     'utilizada para almacenar los datos que se reciben por el puerto
        Dim sib As Integer    ' sera utilizada como contador
        Dim msn(1000) As String
        Try
            '
            ''com1 = My.Computer.Ports.OpenSerialPort(CbPuertosSeriales.Text)
            'Dim i = 0
            'Do Until i = 6
            '    Dim Incoming As String = com1.ReadLine

            '    If Incoming Is Nothing Then
            '        Exit Do
            '    Else
            '        returnStr &= IIf(Incoming = vbCr, "", Incoming & vbCrLf)
            '    End If
            '    i += 1
            'Loop

            az = SpCapturaAuto.ReadExisting.Trim

            msn(sib) = az

            returnStr += msn(sib) + " "

            sib = sib + 1
        Catch ex As TimeoutException
            returnStr = "Error: Serial Port read timed out."
        Finally
            ' If com1 IsNot Nothing Then com1.Close()
        End Try
        If returnStr.Contains("INBOUND") Then
            NoTransporte = returnStr.Substring(3, 2)
            IdBoleta = LTrim(returnStr.Substring(6, 5))
            Bruto = LTrim(returnStr.Substring(20, 10))
            Tara = 0
            Neto = 0
            FechaActualizacion = Now
            TipoFlete = "INBOUND"
            ActualizaPesoModuloAutomatico(NoTransporte, IdBoleta, Bruto, Tara, Neto, FechaActualizacion, TipoFlete)
        ElseIf returnStr.Contains("RECALLED") Then
            NoTransporte = returnStr.Substring(3, 2)
            IdBoleta = LTrim(returnStr.Substring(6, 5))
            Bruto = 0
            Tara = LTrim(returnStr.Substring(48, 11))
            Neto = LTrim(returnStr.Substring(68, 12))
            FechaActualizacion = Now
            TipoFlete = "RECALLED"
            ActualizaPesoModuloAutomatico(NoTransporte, IdBoleta, Bruto, Tara, Neto, FechaActualizacion, TipoFlete)

        End If
        ' End While
        'ConsultaModulos()
    End Sub
    Private Sub propiedadesDgv()
        DgvModulos.Columns("IdPlanta").HeaderText = "ID Planta"
        DgvModulos.Columns("FechaOrden").HeaderText = "Fecha de Orden"
        DgvModulos.Columns("Bruto").HeaderText = "Bruto"
        DgvModulos.Columns("Tara").HeaderText = "Tara"
        DgvModulos.Columns("Total").HeaderText = "Total"
        DgvModulos.Columns("Nombre").HeaderText = "Productor"
        DgvModulos.Columns("IdOrdenTrabajo").HeaderText = "Orden de Trabajo"
        DgvModulos.Columns("FlagCancelada").HeaderText = "Cancelado"
        DgvModulos.Columns("FlagRevisada").HeaderText = "Revisado"
        DgvModulos.Columns("IdBoleta").Visible = True
        DgvModulos.Columns("IdPlanta").ReadOnly = True
        DgvModulos.Columns("FechaOrden").ReadOnly = True
        DgvModulos.Columns("Bruto").ReadOnly = False
        DgvModulos.Columns("Tara").ReadOnly = False
        DgvModulos.Columns("Total").ReadOnly = True
        DgvModulos.Columns("Nombre").ReadOnly = True
        DgvModulos.Columns("IdOrdenTrabajo").ReadOnly = True
        DgvModulos.Columns("FlagCancelada").ReadOnly = False
        DgvModulos.Columns("FlagRevisada").ReadOnly = False
    End Sub
    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Dim Total, Bruto, Tara As Double
        Dim IndexCell As Integer = IIf(e.RowIndex > 0, e.RowIndex - 1, e.RowIndex)
        Bruto = CDbl(DgvModulos.Rows(IndexCell).Cells("Bruto").Value)
        Tara = CDbl(DgvModulos.Rows(IndexCell).Cells("Tara").Value)
        If Tara > Bruto Then
            MsgBox("La tara no puede ser mayor al peso Bruto")
            DgvModulos.Rows(IndexCell).Cells("Total").Value = 0
        Else
            Total = Bruto - Tara
            DgvModulos.Rows(IndexCell).Cells("Total").Value = Total
            ActualizaPesoModuloManual(IndexCell, DgvModulos.Rows(IndexCell).Cells("IdBoleta").Value, Bruto, Tara, Total)
        End If
    End Sub
    Private Sub ActualizaPesoModuloManual(ByVal IndexCell As Integer, ByVal IdBoleta As Integer, ByVal Bruto As Double, ByVal Tara As Double, ByVal Total As Double)
        Dim EntidadCapturaBoletasPorLotes As New Capa_Entidad.CapturaBoletasPorLotes
        Dim NegocioCapturaBoletasPorLotes As New Capa_Negocio.CapturaBoletasPorLotes
        EntidadCapturaBoletasPorLotes.Idboleta = IdBoleta
        EntidadCapturaBoletasPorLotes.Bruto = Bruto
        EntidadCapturaBoletasPorLotes.Tara = Tara
        EntidadCapturaBoletasPorLotes.Neto = Total
        NegocioCapturaBoletasPorLotes.upsert(EntidadCapturaBoletasPorLotes)
    End Sub
    Private Sub ActualizaPesoModuloAutomatico(ByVal NoTransporte As Integer, ByVal IdBoleta As Integer, ByVal Bruto As Double, ByVal Tara As Double, ByVal Neto As Double, ByVal FechaActualizacion As DateTime, ByVal TipoFlete As String)
        Dim EntidadCapturaBoletasPorLotes As New Capa_Entidad.CapturaBoletasPorLotes
        Dim NegocioCapturaBoletasPorLotes As New Capa_Negocio.CapturaBoletasPorLotes
        EntidadCapturaBoletasPorLotes.NoTransporte = NoTransporte
        EntidadCapturaBoletasPorLotes.Idboleta = IdBoleta
        EntidadCapturaBoletasPorLotes.Bruto = Bruto
        EntidadCapturaBoletasPorLotes.Tara = Tara
        EntidadCapturaBoletasPorLotes.Neto = Neto
        EntidadCapturaBoletasPorLotes.FechaActualizacion = FechaActualizacion
        EntidadCapturaBoletasPorLotes.TipoFlete = TipoFlete
        NegocioCapturaBoletasPorLotes.upsertAuto(EntidadCapturaBoletasPorLotes)
    End Sub
    Private Sub GetSerialPortNames()

        ' muestra COM ports disponibles.

        Dim l As Integer

        Dim ncom As String

        Try

            CbPuertosSeriales.Items.Clear()

            For Each sp As String In My.Computer.Ports.SerialPortNames

                l = sp.Length

                If ((sp(l - 1) >= "0") And (sp(l - 1) <= "9")) Then
                    CbPuertosSeriales.Items.Add(sp)
                Else
                    'hay una letra al final del COM
                    ncom = sp.Substring(0, l - 1)
                    CbPuertosSeriales.Items.Add(ncom)
                End If
            Next
            If CbPuertosSeriales.Items.Count >= 1 Then

                CbPuertosSeriales.Text = CbPuertosSeriales.Items(0)
                Puerto = CbPuertosSeriales.Items(0)
            Else

                CbPuertosSeriales.Text = ""

            End If

        Catch ex As Exception

        End Try

    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        ConsultaModulos()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
        com1.Close()
    End Sub
    Private Sub BtAutomatico_Click(sender As Object, e As EventArgs) Handles BtAutomatico.Click
        'If th.ThreadState = Threading.ThreadState.Unstarted Or th.ThreadState = Threading.ThreadState.WaitSleepJoin Or th.ThreadState = Threading.ThreadState.Aborted Or th.ThreadState = Threading.ThreadState.Stopped Then

        ' If th.ThreadState <> Threading.ThreadState.WaitSleepJoin Then hacer()
        If LbStatus.Text = "CAPTURA AUTOMATICA DESACTIVADA" Then
            TiActualizaDgvModulos.Enabled = True
            LbStatus.Text = "CAPTURA AUTOMATICA ACTIVADA"
            Setup_Puerto_Serie()
        Else
            TiActualizaDgvModulos.Enabled = False
            LbStatus.Text = "CAPTURA AUTOMATICA DESACTIVADA"
            SpCapturaAuto.Close()
        End If
        '    LbStatus.Text = TiActualizaDgvModulos.Tag.ToString

        'If com1 IsNot Nothing Then
        '    MsgBox("Puerto Abierto")
        'Else
        '    MsgBox("Puerto Cerrado")
        'End If

        'End If
    End Sub
    Private Sub hacer()
        'Controlamos los estados
        'If th.ThreadState = Threading.ThreadState.Unstarted Or th.ThreadState = Threading.ThreadState.WaitSleepJoin Or th.ThreadState = Threading.ThreadState.Aborted Or th.ThreadState = Threading.ThreadState.Stopped Then
        '    th = New Threading.Thread(AddressOf ReceiveSerialData)
        '    bandera = True
        '    Salir = False 'indica False para que el bucle pueda seguir
        '    th.Start() 'Inicia el hilo

        'Else
        '    Label1.Text = th.ThreadState.ToString 'asigna al label el estado del hilo
        'End If
    End Sub
    Private Sub TiActualizaDgvModulos_Tick(sender As Object, e As EventArgs) Handles TiActualizaDgvModulos.Tick
        ConsultaModulos()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        TiActualizaDgvModulos.Start()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        TiActualizaDgvModulos.Stop()
    End Sub
    Private Sub BtAutomatico_Click_1(sender As Object, e As EventArgs)
        hacer()
    End Sub
End Class