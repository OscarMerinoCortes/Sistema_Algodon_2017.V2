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
        Me.TbUltimaPaca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbEtiquetaActual = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbPlanta = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtActualizar = New System.Windows.Forms.Button()
        Me.MSMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(269, 24)
        Me.MSMenu.TabIndex = 0
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'TbUltimaPaca
        '
        Me.TbUltimaPaca.Enabled = False
        Me.TbUltimaPaca.Location = New System.Drawing.Point(125, 54)
        Me.TbUltimaPaca.Name = "TbUltimaPaca"
        Me.TbUltimaPaca.Size = New System.Drawing.Size(121, 20)
        Me.TbUltimaPaca.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ultima Paca Producida"
        '
        'TbEtiquetaActual
        '
        Me.TbEtiquetaActual.Location = New System.Drawing.Point(125, 80)
        Me.TbEtiquetaActual.Name = "TbEtiquetaActual"
        Me.TbEtiquetaActual.Size = New System.Drawing.Size(121, 20)
        Me.TbEtiquetaActual.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Etiqueta Actual"
        '
        'CbPlanta
        '
        Me.CbPlanta.FormattingEnabled = True
        Me.CbPlanta.Location = New System.Drawing.Point(125, 27)
        Me.CbPlanta.Name = "CbPlanta"
        Me.CbPlanta.Size = New System.Drawing.Size(121, 21)
        Me.CbPlanta.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Planta"
        '
        'BtActualizar
        '
        Me.BtActualizar.Location = New System.Drawing.Point(171, 106)
        Me.BtActualizar.Name = "BtActualizar"
        Me.BtActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtActualizar.TabIndex = 7
        Me.BtActualizar.Text = "Actualizar"
        Me.BtActualizar.UseVisualStyleBackColor = True
        '
        'Etiquetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 140)
        Me.Controls.Add(Me.BtActualizar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbPlanta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbEtiquetaActual)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbUltimaPaca)
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
    Friend WithEvents TbUltimaPaca As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TbEtiquetaActual As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CbPlanta As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtActualizar As Button
End Class
