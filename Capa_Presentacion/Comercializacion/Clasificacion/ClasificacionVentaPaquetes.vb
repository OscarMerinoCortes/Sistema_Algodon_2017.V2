Imports Capa_Operacion.Configuracion
Public Class ClasificacionVentaPaquetes
    Private TablaClasificacionGrid, TablaClasificacionGlobal As New DataTable
    Private Sub ClasificacionVentaPaquetes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaCombos()
        propiedadesDgv1()
        CreaTabla()
    End Sub
    Private Sub CreaTabla()
        TablaClasificacionGrid.Columns.Clear()
        TablaClasificacionGrid.Columns.Add(New DataColumn("BaleId", System.Type.GetType("System.Int32")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("Mic", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("ColorGrade", System.Type.GetType("System.String")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("TrashId", System.Type.GetType("System.Int32")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("Clase", System.Type.GetType("System.String")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("UHML", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("Strength", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("SCI", System.Type.GetType("System.Int32")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("IdHviDetalle", System.Type.GetType("System.Int32")))
    End Sub
    Private Sub ContarPacas()
        TbCantidadPacas.Text = DgvPacasClasificacion1.Rows.Count
    End Sub
    Private Sub DataGridViewToTable()
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        Dim index As Integer
        Dim rengloninsertar As DataRow
        TablaClasificacionGrid.Clear()
        For Each row As DataGridViewRow In DgvPacasClasificacion1.Rows
            index = Convert.ToUInt64(row.Index)
            rengloninsertar = TablaClasificacionGrid.NewRow()
            rengloninsertar("BaleId") = DgvPacasClasificacion1.Rows(index).Cells("BaleId").Value
            rengloninsertar("Mic") = DgvPacasClasificacion1.Rows(index).Cells("Mic").Value
            rengloninsertar("ColorGrade") = DgvPacasClasificacion1.Rows(index).Cells("ColorGrade").Value
            rengloninsertar("TrashId") = DgvPacasClasificacion1.Rows(index).Cells("TrashId").Value
            rengloninsertar("Clase") = DgvPacasClasificacion1.Rows(index).Cells("Clase").Value
            rengloninsertar("UHML") = DgvPacasClasificacion1.Rows(index).Cells("LargoFibra").Value
            rengloninsertar("Strength") = DgvPacasClasificacion1.Rows(index).Cells("Resistencia").Value
            rengloninsertar("SCI") = DgvPacasClasificacion1.Rows(index).Cells("SCI").Value
            rengloninsertar("IdHviDetalle") = DgvPacasClasificacion1.Rows(index).Cells("IdHviDetalle").Value
            TablaClasificacionGrid.Rows.Add(rengloninsertar)
        Next
        TablaClasificacionGlobal = TablaClasificacionGrid
        EntidadClasificacionVentaPaquetes.TablaGeneral = TablaClasificacionGlobal
        NegocioClasificacionVentaPaquetes.GuardarTablas(EntidadClasificacionVentaPaquetes)
    End Sub
    Private Sub TextBox_PreviewKeyDown(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DgvPacasClasificacion1.CellEnter
        Dim GradoColor As String = Convert.ToString(DgvPacasClasificacion1.CurrentRow.Cells("ColorGrade").Value)
        Dim TrashId As Integer = DgvPacasClasificacion1.CurrentRow.Cells("TrashID").Value
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        Dim Tabla2 As New DataTable
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaClasesDetalle
        EntidadClasificacionVentaPaquetes.GradoColor = GradoColor
        EntidadClasificacionVentaPaquetes.TrashId = TrashId
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla2 = EntidadClasificacionVentaPaquetes.TablaConsulta
        If Tabla2.Rows.Count = 0 Then
            MsgBox("Verifica los valores de Grado Color y TrashID", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            DgvPacasClasificacion1.CurrentRow.Cells("Clase").Value = Tabla2.Rows(0).Item("ClaveCorta")
            Exit Sub
        End If
    End Sub
    Private Sub CargaCombos()
        '---Planta Origen--
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaExterna
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        CbPlanta.DataSource = Tabla
        CbPlanta.ValueMember = "IdPlanta"
        CbPlanta.DisplayMember = "Descripcion"
        CbPlanta.SelectedValue = 1
        '---Clasificacion--
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        Dim Tabla2 As New DataTable
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaClases
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla2 = EntidadClasificacionVentaPaquetes.TablaConsulta
        CbClases.DataSource = Tabla2
        CbClases.ValueMember = "IdClasificacion"
        CbClases.DisplayMember = "ClaveCorta"
        CbClases.SelectedValue = 1
    End Sub
    Private Sub TbNoPaca_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbNoPaca.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If TbNoPaca.Text <> "" Then
                    Consultar()
                    TbNoPaca.Text = ""
                    'PropiedadesDGV()
                    'End If

                Else
                    MsgBox("Ingrese el ID de la orden de trabajo...")
                    Exit Sub
                End If
        End Select
        ContarPacas()
    End Sub
    'Private Sub deseleccionDgv() Handles DgvPacasClasificacion1.Click
    '    DgvPacasClasificacion1.ClearSelection()
    'End Sub
    Private Sub Consultar()
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        Dim Tabla As New DataTable
        Dim VerificaDuplicado As Boolean
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaPaca
        EntidadClasificacionVentaPaquetes.NumeroPaca = CInt(TbNoPaca.Text)
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla = EntidadClasificacionVentaPaquetes.TablaConsulta
        'DgvPacasClasificacion1.DataSource = Tabla
        If Tabla.Rows.Count = 0 Then
            MsgBox("El la paca no se encuentra en la base de datos HVI.")
        ElseIf VerificaPacaRepetida(VerificaDuplicado) = False Then
            DgvPacasClasificacion1.Rows.Add(Tabla.Rows(0).Item("BaleId"), Tabla.Rows(0).Item("Mic"), Tabla.Rows(0).Item("ColorGrade"), Tabla.Rows(0).Item("TrashId"), Tabla.Rows(0).Item("Clase"), Tabla.Rows(0).Item("LargoFibra"), Tabla.Rows(0).Item("ResistenciaFibra"), Tabla.Rows(0).Item("SCI"), Tabla.Rows(0).Item("IdHviDet"))
        Else
            MsgBox("El numero de paca ya se encuentra registrado.")
        End If
        'PropiedadesDGV()
    End Sub
    Public Function VerificaPacaRepetida(ByVal VerificaDuplicado As Boolean)
        VerificaDuplicado = False
        For Each row As DataGridViewRow In DgvPacasClasificacion1.Rows
            Dim NoPaca As Integer = TbNoPaca.Text
            If NoPaca = row.Cells("BaleId").Value Then
                VerificaDuplicado = True
            End If
        Next row
        Return VerificaDuplicado
    End Function
    Private Sub EliminarRegistro()
        Dim dt As DataTable = DataGridViewToDataTable(DgvPacasClasificacion1)
        Dim filas As Integer = dt.Rows.Count
        Dim idd As Boolean
        For i As Integer = 0 To dt.Rows.Count - 1
            idd = dt.Rows(i).Item(8)
            If idd = True Then
                dt.Rows.RemoveAt(i)
            End If
        Next
        DgvPacasClasificacion1.Columns.Clear()
        DgvPacasClasificacion1.DataSource = dt
    End Sub
    Private Sub EliminarRegistro2()
        For Rowp As Integer = DgvPacasClasificacion1.Rows.Count - 1 To 0 Step -1
            For Row As Integer = DgvPacasClasificacion1.Rows.Count - 2 To 0 Step -1
                If Convert.ToBoolean(DgvPacasClasificacion1.Rows(Row).Cells("sel").Value) Then
                    DgvPacasClasificacion1.Rows.RemoveAt(Row)
                End If
            Next
        Next
        'Dim dt As DataTable = DataGridViewToDataTable(DgvPacasClasificacion1)
        'Dim dt As DataTable = DgvPacasClasificacion1.DataSource - 1 To 0 Step -1
        'For Contador = 0 To DgvPacasClasificacion1.RowCount - 1
        '    If DgvPacasClasificacion1.Rows(Contador).Cells("Sel").Value = True Then
        '        DgvPacasClasificacion1.Rows.RemoveAt(Contador)
        '        'Contador = 0
        '    End If
        'Next Contador
        'For n As Int32 = DgvPacasClasificacion1.Rows.Count - 1 To 0 Step -1
        ' Referenciamos la fila
        'Dim row As DataRow = DgvPacasClasificacion1.Rows(n)

        ' Si el valor del campo tipo CheckBox está
        ' marcado (es True), eliminamos la fila.
        '
        'If Convert.ToBoolean(row.Item("NombreColumna")) = True Then
        '    dt.Rows.Remove(row)
        'End If
        'Next
        'For Each row As DataGridViewRow In DgvPacasClasificacion1.SelectedRows
        '    If row.Cells("Sel").Value = True Then
        '        DgvPacasClasificacion1.Rows.Remove(row)
        '    End If
        'Next row
    End Sub
    Public Sub EditaFila()
        With DgvPacasClasificacion1
            '.CurrentCell = .Rows(.Rows.Count - 1).Cells("ColorGrade")
            .BeginEdit(True)
        End With
    End Sub
    Private Sub verificaChecks(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPacasClasificacion1.CellContentClick
        Dim Contador As Integer
        For Contador = 0 To DgvPacasClasificacion1.RowCount - 1
            If DgvPacasClasificacion1.Rows(Contador).Selected Then
                If DgvPacasClasificacion1.Rows(Contador).Cells("Sel").Value = False Then
                    DgvPacasClasificacion1.Rows(Contador).Cells("Sel").Value = True
                ElseIf DgvPacasClasificacion1.Rows(Contador).Cells("Sel").Value = True Then
                    DgvPacasClasificacion1.Rows(Contador).Cells("Sel").Value = False
                End If
            End If
        Next Contador
    End Sub
    Private Sub EliminarRegistro3()
        For Each filap As DataGridViewRow In DgvPacasClasificacion1.Rows
            For Each fila As DataGridViewRow In DgvPacasClasificacion1.Rows
                If CBool(fila.Cells(9).Value) = True Then
                    DgvPacasClasificacion1.Rows.Remove(fila)
                End If
            Next
        Next
    End Sub
    Private Function IdentificaColor() As Integer
        Dim ContadorColor As Integer
        For Each fila As DataGridViewRow In DgvPacasClasificacion1.Rows
            If fila.Cells(4).Value.ToString <> CbClases.Text Then
                fila.DefaultCellStyle.BackColor = Color.Red
                ContadorColor = ContadorColor + 1
            Else
                fila.DefaultCellStyle.BackColor = Color.White
                ContadorColor = ContadorColor + 0
            End If
        Next
        Return ContadorColor
    End Function
    Private Sub PropiedadesDGV()
        ' DgvPacasClasificacion1.Columns("IdCalculoClasificacion").ReadOnly = False
        DgvPacasClasificacion1.Columns("BaleId").ReadOnly = False
        DgvPacasClasificacion1.Columns("TrashID").ReadOnly = False
        'DgvPacasClasificacion1.Columns("Clase").ReadOnly = False
        DgvPacasClasificacion1.Columns("Resistencia").ReadOnly = False
        DgvPacasClasificacion1.Columns("Mic").ReadOnly = False
        DgvPacasClasificacion1.Columns("ColorGrade").ReadOnly = False
        DgvPacasClasificacion1.Columns("TrashID").ReadOnly = False
        DgvPacasClasificacion1.Columns("LargoFibra").ReadOnly = False
        DgvPacasClasificacion1.Columns("Resistencia").ReadOnly = False
    End Sub
    Private Sub propiedadesDgv1()
        DgvPacasClasificacion1.Columns.Clear()

        If DgvPacasClasificacion1.Columns("BaleId") Is Nothing Then
            Dim colBaleId As New DataGridViewTextBoxColumn
            colBaleId.Name = "BaleId"
            colBaleId.HeaderText = "No Paca"
            colBaleId.ReadOnly = True
            ' colBaleId.Width = 50
            DgvPacasClasificacion1.Columns.Insert(0, colBaleId)

            Dim colMic As New DataGridViewTextBoxColumn
            colMic.Name = "Mic"
            'colMic.Visible = False
            DgvPacasClasificacion1.Columns.Insert(1, colMic)

            Dim colColorGrade As New DataGridViewTextBoxColumn
            colColorGrade.Name = "ColorGrade"
            ' colColorGrade.Width = 70
            ' colColorGrade.Visible = False
            DgvPacasClasificacion1.Columns.Insert(2, colColorGrade)

            Dim ColTrashId As New DataGridViewTextBoxColumn()
            ColTrashId.Name = "TrashId"
            'ColClase.Width = 75
            'ColClase.Name = "grupoGrano"
            DgvPacasClasificacion1.Columns.Insert(3, ColTrashId)

            Dim ColClase As New DataGridViewTextBoxColumn()
            ColClase.Name = "Clase"
            ColClase.ReadOnly = True
            'ColClase.Width = 75
            'ColClase.Name = "grupoGrano"
            DgvPacasClasificacion1.Columns.Insert(4, ColClase)

            Dim ColLargoFibra As New DataGridViewTextBoxColumn()
            ColLargoFibra.Name = "LargoFibra"
            ColLargoFibra.ValueType = GetType(Int32)
            ' Colneto.Width = 65
            ' Colneto.Name = "Neto"
            DgvPacasClasificacion1.Columns.Insert(5, ColLargoFibra)

            Dim ColResistencia As New DataGridViewTextBoxColumn()
            ColResistencia.Name = "Resistencia"
            'ColResistencia.Width = 60
            'ColResistencia.Name = "Deducciones"
            DgvPacasClasificacion1.Columns.Insert(6, ColResistencia)

            Dim ColSCI As New DataGridViewTextBoxColumn()
            ColSCI.Name = "SCI"
            'ColSCI.Width = 70
            ' ColSCI.Name = "Total"
            ColSCI.ReadOnly = True
            DgvPacasClasificacion1.Columns.Insert(7, ColSCI)

            Dim colIdHviDetalle As New DataGridViewTextBoxColumn
            colIdHviDetalle.Name = "IdHviDetalle"
            colIdHviDetalle.Visible = False
            DgvPacasClasificacion1.Columns.Insert(8, colIdHviDetalle)

            Dim colSel As New DataGridViewCheckBoxColumn()
            colSel.Name = "Sel"
            DgvPacasClasificacion1.Columns.Insert(9, colSel)

            'DgvPacasClasificacion1.Columns("Neto").DefaultCellStyle.Format = "###,##0.00"
            'DgvPacasClasificacion1.Columns("Deducciones").DefaultCellStyle.Format = "###,##0.00"
            'DgvPacasClasificacion1.Columns("Total").DefaultCellStyle.Format = "###,##0.00"

            'DgvPacasClasificacion1.Columns("Neto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'DgvPacasClasificacion1.Columns("Deducciones").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'DgvPacasClasificacion1.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
    End Sub
    Private Sub agregar()

    End Sub
    Private Sub EliminarPacasSeleccionadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarPacasSeleccionadasToolStripMenuItem.Click
        EliminarRegistro2()
        EliminarRegistro2()
        ContarPacas()
        'Datatb()
        'DgvPacasClasificacion1.ClearSelection()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        If IdentificaColor() > 0 Then
            MsgBox("Mayor 0")
        Else
            DataGridViewToTable()
            MsgBox("Igual 0")
        End If
    End Sub
    Private Sub Datatb()
        Try
            Dim dt As DataTable = DataGridViewToDataTable(DgvPacasClasificacion1)
            MessageBox.Show(String.Format("Nº de filas añadidas: {0}", dt.Rows.Count))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        DgvPacasClasificacion1.Columns.Clear()
        propiedadesDgv1()
    End Sub

    Private Function DataGridViewToDataTable(dgv As DataGridView) As DataTable
        If (dgv Is Nothing) Then Return Nothing
        Dim dt As New DataTable()
        For Each col As DataGridViewColumn In dgv.Columns
            Dim column As New DataColumn(col.Name, Type.GetType("System.String"))
            dt.Columns.Add(column)
        Next
        For Each viewRow As DataGridViewRow In dgv.Rows
            Dim row As DataRow = dt.NewRow()
            For Each col As DataGridViewColumn In dgv.Columns
                Dim value As Object = viewRow.Cells(col.Name).Value
                row.Item(col.Name) = If(value Is Nothing, DBNull.Value, value)
            Next col
            dt.Rows.Add(row)
        Next viewRow
        Return dt
    End Function
End Class