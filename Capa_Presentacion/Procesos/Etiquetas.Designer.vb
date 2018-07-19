<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Etiquetas
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
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TbEtiquetaActual = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbIdProduccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbOrdenTrabajoInfo = New System.Windows.Forms.TextBox()
        Me.TbIdProduccionInfo = New System.Windows.Forms.TextBox()
        Me.TbIdPlantaInfo = New System.Windows.Forms.TextBox()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MSMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(541, 24)
        Me.MSMenu.TabIndex = 0
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'TbEtiquetaActual
        '
        Me.TbEtiquetaActual.Enabled = False
        Me.TbEtiquetaActual.Location = New System.Drawing.Point(112, 55)
        Me.TbEtiquetaActual.Name = "TbEtiquetaActual"
        Me.TbEtiquetaActual.Size = New System.Drawing.Size(121, 20)
        Me.TbEtiquetaActual.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Etiqueta Actual"
        '
        'TbIdProduccion
        '
        Me.TbIdProduccion.Location = New System.Drawing.Point(112, 29)
        Me.TbIdProduccion.Name = "TbIdProduccion"
        Me.TbIdProduccion.Size = New System.Drawing.Size(121, 20)
        Me.TbIdProduccion.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Id Produccion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(239, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "ID Produccion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(239, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "ID Orden de Trabajo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(239, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "ID Planta"
        '
        'TbOrdenTrabajoInfo
        '
        Me.TbOrdenTrabajoInfo.Enabled = False
        Me.TbOrdenTrabajoInfo.Location = New System.Drawing.Point(349, 53)
        Me.TbOrdenTrabajoInfo.Name = "TbOrdenTrabajoInfo"
        Me.TbOrdenTrabajoInfo.Size = New System.Drawing.Size(100, 20)
        Me.TbOrdenTrabajoInfo.TabIndex = 13
        '
        'TbIdProduccionInfo
        '
        Me.TbIdProduccionInfo.Enabled = False
        Me.TbIdProduccionInfo.Location = New System.Drawing.Point(349, 27)
        Me.TbIdProduccionInfo.Name = "TbIdProduccionInfo"
        Me.TbIdProduccionInfo.Size = New System.Drawing.Size(100, 20)
        Me.TbIdProduccionInfo.TabIndex = 14
        '
        'TbIdPlantaInfo
        '
        Me.TbIdPlantaInfo.Enabled = False
        Me.TbIdPlantaInfo.Location = New System.Drawing.Point(349, 79)
        Me.TbIdPlantaInfo.Name = "TbIdPlantaInfo"
        Me.TbIdPlantaInfo.Size = New System.Drawing.Size(100, 20)
        Me.TbIdPlantaInfo.TabIndex = 15
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'Etiquetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 143)
        Me.Controls.Add(Me.TbIdPlantaInfo)
        Me.Controls.Add(Me.TbIdProduccionInfo)
        Me.Controls.Add(Me.TbOrdenTrabajoInfo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TbIdProduccion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbEtiquetaActual)
        Me.Controls.Add(Me.MSMenu)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "Etiquetas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Etiquetas"
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TbEtiquetaActual As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbIdProduccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TbOrdenTrabajoInfo As TextBox
    Friend WithEvents TbIdProduccionInfo As TextBox
    Friend WithEvents TbIdPlantaInfo As TextBox
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
End Class
