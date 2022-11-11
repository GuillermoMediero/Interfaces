<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tlpCalculadora = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.tbResultado = New System.Windows.Forms.TextBox()
        Me.nudBase = New System.Windows.Forms.NumericUpDown()
        Me.nudAltura = New System.Windows.Forms.NumericUpDown()
        Me.tlpCalculadora.SuspendLayout()
        CType(Me.nudBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAltura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpCalculadora
        '
        Me.tlpCalculadora.ColumnCount = 2
        Me.tlpCalculadora.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpCalculadora.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpCalculadora.Controls.Add(Me.btnCalcular, 0, 2)
        Me.tlpCalculadora.Controls.Add(Me.tbResultado, 0, 0)
        Me.tlpCalculadora.Controls.Add(Me.nudBase, 0, 1)
        Me.tlpCalculadora.Controls.Add(Me.nudAltura, 1, 1)
        Me.tlpCalculadora.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCalculadora.Location = New System.Drawing.Point(0, 0)
        Me.tlpCalculadora.Name = "tlpCalculadora"
        Me.tlpCalculadora.RowCount = 3
        Me.tlpCalculadora.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpCalculadora.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpCalculadora.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCalculadora.Size = New System.Drawing.Size(384, 161)
        Me.tlpCalculadora.TabIndex = 0
        '
        'btnCalcular
        '
        Me.btnCalcular.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCalcular.Location = New System.Drawing.Point(12, 112)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(12)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(168, 37)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "Calcular Area"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'tbResultado
        '
        Me.tlpCalculadora.SetColumnSpan(Me.tbResultado, 2)
        Me.tbResultado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbResultado.Location = New System.Drawing.Point(12, 12)
        Me.tbResultado.Margin = New System.Windows.Forms.Padding(12)
        Me.tbResultado.Name = "tbResultado"
        Me.tbResultado.Size = New System.Drawing.Size(360, 29)
        Me.tbResultado.TabIndex = 3
        '
        'nudBase
        '
        Me.nudBase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudBase.Location = New System.Drawing.Point(12, 65)
        Me.nudBase.Margin = New System.Windows.Forms.Padding(12)
        Me.nudBase.Name = "nudBase"
        Me.nudBase.Size = New System.Drawing.Size(168, 23)
        Me.nudBase.TabIndex = 1
        '
        'nudAltura
        '
        Me.nudAltura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudAltura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudAltura.Location = New System.Drawing.Point(204, 65)
        Me.nudAltura.Margin = New System.Windows.Forms.Padding(12)
        Me.nudAltura.Maximum = New Decimal(New Integer() {-1593835521, 466537709, 54210, 0})
        Me.nudAltura.Name = "nudAltura"
        Me.nudAltura.Size = New System.Drawing.Size(168, 23)
        Me.nudAltura.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 161)
        Me.Controls.Add(Me.tlpCalculadora)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.tlpCalculadora.ResumeLayout(False)
        Me.tlpCalculadora.PerformLayout()
        CType(Me.nudBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAltura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpCalculadora As TableLayoutPanel
    Friend WithEvents btnCalcular As Button
    Friend WithEvents tbResultado As TextBox
    Friend WithEvents nudBase As NumericUpDown
    Friend WithEvents nudAltura As NumericUpDown
End Class
