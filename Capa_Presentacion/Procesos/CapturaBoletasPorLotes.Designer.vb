<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CapturaBoletasPorLotes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtDetener = New System.Windows.Forms.Button()
        Me.BtIniciar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvModulos = New System.Windows.Forms.DataGridView()
        Me.TiActualizaDgvModulos = New System.Windows.Forms.Timer(Me.components)
        Me.BtAutomatico = New System.Windows.Forms.Button()
        Me.CbPuertosSeriales = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MSMenu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvModulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(1205, 24)
        Me.MSMenu.TabIndex = 0
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CbPuertosSeriales)
        Me.GroupBox1.Controls.Add(Me.BtAutomatico)
        Me.GroupBox1.Controls.Add(Me.BtDetener)
        Me.GroupBox1.Controls.Add(Me.BtIniciar)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1205, 102)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'BtDetener
        '
        Me.BtDetener.Location = New System.Drawing.Point(12, 55)
        Me.BtDetener.Name = "BtDetener"
        Me.BtDetener.Size = New System.Drawing.Size(75, 23)
        Me.BtDetener.TabIndex = 60
        Me.BtDetener.Text = "Detener Hilo"
        Me.BtDetener.UseVisualStyleBackColor = True
        '
        'BtIniciar
        '
        Me.BtIniciar.Location = New System.Drawing.Point(12, 26)
        Me.BtIniciar.Name = "BtIniciar"
        Me.BtIniciar.Size = New System.Drawing.Size(75, 23)
        Me.BtIniciar.TabIndex = 59
        Me.BtIniciar.Text = "Iniciar Hilo"
        Me.BtIniciar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvModulos)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1205, 592)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion"
        '
        'DgvModulos
        '
        Me.DgvModulos.AllowUserToAddRows = False
        Me.DgvModulos.AllowUserToDeleteRows = False
        Me.DgvModulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvModulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvModulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvModulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvModulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvModulos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvModulos.Location = New System.Drawing.Point(3, 16)
        Me.DgvModulos.MultiSelect = False
        Me.DgvModulos.Name = "DgvModulos"
        Me.DgvModulos.RowHeadersVisible = False
        Me.DgvModulos.RowHeadersWidth = 40
        Me.DgvModulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvModulos.Size = New System.Drawing.Size(1199, 573)
        Me.DgvModulos.TabIndex = 30
        '
        'TiActualizaDgvModulos
        '
        Me.TiActualizaDgvModulos.Enabled = True
        Me.TiActualizaDgvModulos.Interval = 2000
        '
        'BtAutomatico
        '
        Me.BtAutomatico.Location = New System.Drawing.Point(93, 28)
        Me.BtAutomatico.Name = "BtAutomatico"
        Me.BtAutomatico.Size = New System.Drawing.Size(101, 50)
        Me.BtAutomatico.TabIndex = 61
        Me.BtAutomatico.Text = "Captura Automatica de Datos"
        Me.BtAutomatico.UseVisualStyleBackColor = True
        '
        'CbPuertosSeriales
        '
        Me.CbPuertosSeriales.FormattingEnabled = True
        Me.CbPuertosSeriales.Location = New System.Drawing.Point(200, 28)
        Me.CbPuertosSeriales.Name = "CbPuertosSeriales"
        Me.CbPuertosSeriales.Size = New System.Drawing.Size(121, 21)
        Me.CbPuertosSeriales.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 63
        '
        'CapturaBoletasPorLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 718)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MSMenu)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "CapturaBoletasPorLotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Captura de Boletas Por Lotes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvModulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DgvModulos As DataGridView
    Friend WithEvents TiActualizaDgvModulos As Timer
    Friend WithEvents BtIniciar As Button
    Friend WithEvents BtDetener As Button
    Friend WithEvents CbPuertosSeriales As ComboBox
    Friend WithEvents BtAutomatico As Button
    Friend WithEvents Label1 As Label
End Class
