<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AreasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuadradoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolumentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuboToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pFomularios = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AreasToolStripMenuItem, Me.VolumentesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AreasToolStripMenuItem
        '
        Me.AreasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuadradoToolStripMenuItem})
        Me.AreasToolStripMenuItem.Name = "AreasToolStripMenuItem"
        Me.AreasToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.AreasToolStripMenuItem.Text = "Areas"
        '
        'CuadradoToolStripMenuItem
        '
        Me.CuadradoToolStripMenuItem.Name = "CuadradoToolStripMenuItem"
        Me.CuadradoToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CuadradoToolStripMenuItem.Text = "Cuadrado"
        '
        'VolumentesToolStripMenuItem
        '
        Me.VolumentesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuboToolStripMenuItem})
        Me.VolumentesToolStripMenuItem.Name = "VolumentesToolStripMenuItem"
        Me.VolumentesToolStripMenuItem.Size = New System.Drawing.Size(100, 24)
        Me.VolumentesToolStripMenuItem.Text = "Volumentes"
        '
        'CuboToolStripMenuItem
        '
        Me.CuboToolStripMenuItem.Name = "CuboToolStripMenuItem"
        Me.CuboToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CuboToolStripMenuItem.Text = "Cubo"
        '
        'pFomularios
        '
        Me.pFomularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pFomularios.Location = New System.Drawing.Point(0, 28)
        Me.pFomularios.Name = "pFomularios"
        Me.pFomularios.Size = New System.Drawing.Size(800, 422)
        Me.pFomularios.TabIndex = 2
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pFomularios)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Calculadora"
        Me.Text = "Calcualdora"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AreasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuadradoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolumentesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuboToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pFomularios As Panel
End Class
