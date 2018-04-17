<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Camiones
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
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LbPlacas = New System.Windows.Forms.Label()
        Me.LbDescripcion = New System.Windows.Forms.Label()
        Me.TbPlacas = New System.Windows.Forms.TextBox()
        Me.TbDescripcion = New System.Windows.Forms.TextBox()
        Me.TbID = New System.Windows.Forms.TextBox()
        Me.LbID = New System.Windows.Forms.Label()
        Me.DgvRegistro = New System.Windows.Forms.DataGridView()
        Me.MSMenu.SuspendLayout()
        CType(Me.DgvRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(1052, 24)
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
        'LbPlacas
        '
        Me.LbPlacas.AutoSize = True
        Me.LbPlacas.Location = New System.Drawing.Point(15, 86)
        Me.LbPlacas.Name = "LbPlacas"
        Me.LbPlacas.Size = New System.Drawing.Size(39, 13)
        Me.LbPlacas.TabIndex = 11
        Me.LbPlacas.Text = "Placas"
        '
        'LbDescripcion
        '
        Me.LbDescripcion.AutoSize = True
        Me.LbDescripcion.Location = New System.Drawing.Point(15, 60)
        Me.LbDescripcion.Name = "LbDescripcion"
        Me.LbDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.LbDescripcion.TabIndex = 10
        Me.LbDescripcion.Text = "Descripcion"
        '
        'TbPlacas
        '
        Me.TbPlacas.Location = New System.Drawing.Point(109, 79)
        Me.TbPlacas.Name = "TbPlacas"
        Me.TbPlacas.Size = New System.Drawing.Size(100, 20)
        Me.TbPlacas.TabIndex = 9
        '
        'TbDescripcion
        '
        Me.TbDescripcion.Location = New System.Drawing.Point(109, 53)
        Me.TbDescripcion.Name = "TbDescripcion"
        Me.TbDescripcion.Size = New System.Drawing.Size(100, 20)
        Me.TbDescripcion.TabIndex = 8
        '
        'TbID
        '
        Me.TbID.Location = New System.Drawing.Point(109, 27)
        Me.TbID.Name = "TbID"
        Me.TbID.Size = New System.Drawing.Size(100, 20)
        Me.TbID.TabIndex = 7
        '
        'LbID
        '
        Me.LbID.AutoSize = True
        Me.LbID.Location = New System.Drawing.Point(15, 34)
        Me.LbID.Name = "LbID"
        Me.LbID.Size = New System.Drawing.Size(18, 13)
        Me.LbID.TabIndex = 6
        Me.LbID.Text = "ID"
        '
        'DgvRegistro
        '
        Me.DgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRegistro.Location = New System.Drawing.Point(0, 117)
        Me.DgvRegistro.Name = "DgvRegistro"
        Me.DgvRegistro.Size = New System.Drawing.Size(1052, 380)
        Me.DgvRegistro.TabIndex = 12
        '
        'Camiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 537)
        Me.Controls.Add(Me.DgvRegistro)
        Me.Controls.Add(Me.LbPlacas)
        Me.Controls.Add(Me.LbDescripcion)
        Me.Controls.Add(Me.TbPlacas)
        Me.Controls.Add(Me.TbDescripcion)
        Me.Controls.Add(Me.TbID)
        Me.Controls.Add(Me.LbID)
        Me.Controls.Add(Me.MSMenu)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "Camiones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Camiones"
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        CType(Me.DgvRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LbPlacas As Label
    Friend WithEvents LbDescripcion As Label
    Friend WithEvents TbPlacas As TextBox
    Friend WithEvents TbDescripcion As TextBox
    Friend WithEvents TbID As TextBox
    Friend WithEvents LbID As Label
    Friend WithEvents DgvRegistro As DataGridView
End Class
