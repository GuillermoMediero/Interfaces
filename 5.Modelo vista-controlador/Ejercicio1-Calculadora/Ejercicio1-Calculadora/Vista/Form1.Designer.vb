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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbResultado = New System.Windows.Forms.Label()
        Me.tbResultado = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbPrimerOperador = New System.Windows.Forms.Label()
        Me.nudNum1 = New System.Windows.Forms.NumericUpDown()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbSegundoOperador = New System.Windows.Forms.Label()
        Me.nudNum2 = New System.Windows.Forms.NumericUpDown()
        Me.btnPower = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSumar = New System.Windows.Forms.Button()
        Me.btnRestar = New System.Windows.Forms.Button()
        Me.btnMultiplicar = New System.Windows.Forms.Button()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.nudNum1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel3.SuspendLayout()
        CType(Me.nudNum2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPower, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnClear, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSumar, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRestar, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnMultiplicar, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDividir, 3, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(822, 415)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.FlowLayoutPanel1, 2)
        Me.FlowLayoutPanel1.Controls.Add(Me.lbResultado)
        Me.FlowLayoutPanel1.Controls.Add(Me.tbResultado)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(4, 4)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(402, 130)
        Me.FlowLayoutPanel1.TabIndex = 3
        '
        'lbResultado
        '
        Me.lbResultado.AutoSize = True
        Me.lbResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbResultado.Location = New System.Drawing.Point(4, 0)
        Me.lbResultado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbResultado.Name = "lbResultado"
        Me.lbResultado.Size = New System.Drawing.Size(84, 20)
        Me.lbResultado.TabIndex = 0
        Me.lbResultado.Text = "Resultado"
        '
        'tbResultado
        '
        Me.tbResultado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbResultado.Enabled = False
        Me.tbResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbResultado.Location = New System.Drawing.Point(4, 24)
        Me.tbResultado.Margin = New System.Windows.Forms.Padding(4)
        Me.tbResultado.MinimumSize = New System.Drawing.Size(239, 4)
        Me.tbResultado.Name = "tbResultado"
        Me.tbResultado.Size = New System.Drawing.Size(239, 34)
        Me.tbResultado.TabIndex = 1
        '
        'FlowLayoutPanel2
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.FlowLayoutPanel2, 2)
        Me.FlowLayoutPanel2.Controls.Add(Me.lbPrimerOperador)
        Me.FlowLayoutPanel2.Controls.Add(Me.nudNum1)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(4, 142)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(402, 130)
        Me.FlowLayoutPanel2.TabIndex = 4
        '
        'lbPrimerOperador
        '
        Me.lbPrimerOperador.AutoSize = True
        Me.lbPrimerOperador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPrimerOperador.Location = New System.Drawing.Point(4, 0)
        Me.lbPrimerOperador.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPrimerOperador.Name = "lbPrimerOperador"
        Me.lbPrimerOperador.Size = New System.Drawing.Size(130, 20)
        Me.lbPrimerOperador.TabIndex = 0
        Me.lbPrimerOperador.Text = "Primer operador"
        '
        'nudNum1
        '
        Me.nudNum1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudNum1.DecimalPlaces = 2
        Me.nudNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNum1.Location = New System.Drawing.Point(4, 24)
        Me.nudNum1.Margin = New System.Windows.Forms.Padding(4)
        Me.nudNum1.MinimumSize = New System.Drawing.Size(240, 0)
        Me.nudNum1.Name = "nudNum1"
        Me.nudNum1.Size = New System.Drawing.Size(240, 37)
        Me.nudNum1.TabIndex = 1
        Me.nudNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FlowLayoutPanel3
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.FlowLayoutPanel3, 2)
        Me.FlowLayoutPanel3.Controls.Add(Me.lbSegundoOperador)
        Me.FlowLayoutPanel3.Controls.Add(Me.nudNum2)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(4, 280)
        Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(402, 131)
        Me.FlowLayoutPanel3.TabIndex = 5
        '
        'lbSegundoOperador
        '
        Me.lbSegundoOperador.AutoSize = True
        Me.lbSegundoOperador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSegundoOperador.Location = New System.Drawing.Point(4, 0)
        Me.lbSegundoOperador.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbSegundoOperador.Name = "lbSegundoOperador"
        Me.lbSegundoOperador.Size = New System.Drawing.Size(145, 20)
        Me.lbSegundoOperador.TabIndex = 0
        Me.lbSegundoOperador.Text = "Segundo operador"
        '
        'nudNum2
        '
        Me.nudNum2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudNum2.DecimalPlaces = 2
        Me.nudNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNum2.Location = New System.Drawing.Point(4, 24)
        Me.nudNum2.Margin = New System.Windows.Forms.Padding(4)
        Me.nudNum2.MinimumSize = New System.Drawing.Size(240, 0)
        Me.nudNum2.Name = "nudNum2"
        Me.nudNum2.Size = New System.Drawing.Size(240, 37)
        Me.nudNum2.TabIndex = 1
        Me.nudNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnPower
        '
        Me.btnPower.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPower.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPower.Location = New System.Drawing.Point(421, 10)
        Me.btnPower.Margin = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.btnPower.Name = "btnPower"
        Me.btnPower.Size = New System.Drawing.Size(183, 118)
        Me.btnPower.TabIndex = 6
        Me.btnPower.Text = "^"
        Me.btnPower.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(626, 10)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(185, 118)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSumar
        '
        Me.btnSumar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSumar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSumar.Location = New System.Drawing.Point(421, 148)
        Me.btnSumar.Margin = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.btnSumar.Name = "btnSumar"
        Me.btnSumar.Size = New System.Drawing.Size(183, 118)
        Me.btnSumar.TabIndex = 8
        Me.btnSumar.Text = "+"
        Me.btnSumar.UseVisualStyleBackColor = True
        '
        'btnRestar
        '
        Me.btnRestar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestar.Location = New System.Drawing.Point(626, 148)
        Me.btnRestar.Margin = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.btnRestar.Name = "btnRestar"
        Me.btnRestar.Size = New System.Drawing.Size(185, 118)
        Me.btnRestar.TabIndex = 9
        Me.btnRestar.Text = "-"
        Me.btnRestar.UseVisualStyleBackColor = True
        '
        'btnMultiplicar
        '
        Me.btnMultiplicar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMultiplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplicar.Location = New System.Drawing.Point(421, 286)
        Me.btnMultiplicar.Margin = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(183, 119)
        Me.btnMultiplicar.TabIndex = 10
        Me.btnMultiplicar.Text = "x"
        Me.btnMultiplicar.UseVisualStyleBackColor = True
        '
        'btnDividir
        '
        Me.btnDividir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDividir.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDividir.Location = New System.Drawing.Point(626, 286)
        Me.btnDividir.Margin = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(185, 119)
        Me.btnDividir.TabIndex = 11
        Me.btnDividir.Text = "/"
        Me.btnDividir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 415)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        CType(Me.nudNum1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        CType(Me.nudNum2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lbResultado As Label
    Friend WithEvents tbResultado As TextBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents lbPrimerOperador As Label
    Friend WithEvents nudNum1 As NumericUpDown
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents lbSegundoOperador As Label
    Friend WithEvents nudNum2 As NumericUpDown
    Friend WithEvents btnPower As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSumar As Button
    Friend WithEvents btnRestar As Button
    Friend WithEvents btnMultiplicar As Button
    Friend WithEvents btnDividir As Button
End Class
