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
        Me.bElevar = New System.Windows.Forms.Button()
        Me.bSumar = New System.Windows.Forms.Button()
        Me.bMultiplicar = New System.Windows.Forms.Button()
        Me.bLimpiar = New System.Windows.Forms.Button()
        Me.bRestar = New System.Windows.Forms.Button()
        Me.bDividir = New System.Windows.Forms.Button()
        Me.tbResultado = New System.Windows.Forms.TextBox()
        Me.nudNum1 = New System.Windows.Forms.NumericUpDown()
        Me.nudNum2 = New System.Windows.Forms.NumericUpDown()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.flowLayout1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.flowLayout2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.flowLayout3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.nudNum1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNum2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.flowLayout1.SuspendLayout()
        Me.flowLayout2.SuspendLayout()
        Me.flowLayout3.SuspendLayout()
        Me.SuspendLayout()
        '
        'bElevar
        '
        Me.bElevar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bElevar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bElevar.Location = New System.Drawing.Point(199, 8)
        Me.bElevar.Margin = New System.Windows.Forms.Padding(8)
        Me.bElevar.Name = "bElevar"
        Me.bElevar.Size = New System.Drawing.Size(79, 53)
        Me.bElevar.TabIndex = 2
        Me.bElevar.Text = "^"
        Me.bElevar.UseVisualStyleBackColor = True
        '
        'bSumar
        '
        Me.bSumar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSumar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSumar.Location = New System.Drawing.Point(199, 77)
        Me.bSumar.Margin = New System.Windows.Forms.Padding(8)
        Me.bSumar.Name = "bSumar"
        Me.bSumar.Size = New System.Drawing.Size(79, 53)
        Me.bSumar.TabIndex = 3
        Me.bSumar.Text = "+"
        Me.bSumar.UseVisualStyleBackColor = True
        '
        'bMultiplicar
        '
        Me.bMultiplicar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bMultiplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMultiplicar.Location = New System.Drawing.Point(199, 146)
        Me.bMultiplicar.Margin = New System.Windows.Forms.Padding(8)
        Me.bMultiplicar.Name = "bMultiplicar"
        Me.bMultiplicar.Size = New System.Drawing.Size(79, 53)
        Me.bMultiplicar.TabIndex = 4
        Me.bMultiplicar.Text = "x"
        Me.bMultiplicar.UseVisualStyleBackColor = True
        '
        'bLimpiar
        '
        Me.bLimpiar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bLimpiar.Location = New System.Drawing.Point(294, 8)
        Me.bLimpiar.Margin = New System.Windows.Forms.Padding(8)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(81, 53)
        Me.bLimpiar.TabIndex = 5
        Me.bLimpiar.Text = "C"
        Me.bLimpiar.UseVisualStyleBackColor = True
        '
        'bRestar
        '
        Me.bRestar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bRestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bRestar.Location = New System.Drawing.Point(294, 77)
        Me.bRestar.Margin = New System.Windows.Forms.Padding(8)
        Me.bRestar.Name = "bRestar"
        Me.bRestar.Size = New System.Drawing.Size(81, 53)
        Me.bRestar.TabIndex = 6
        Me.bRestar.Text = "-"
        Me.bRestar.UseVisualStyleBackColor = True
        '
        'bDividir
        '
        Me.bDividir.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bDividir.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDividir.Location = New System.Drawing.Point(294, 146)
        Me.bDividir.Margin = New System.Windows.Forms.Padding(8)
        Me.bDividir.Name = "bDividir"
        Me.bDividir.Size = New System.Drawing.Size(81, 53)
        Me.bDividir.TabIndex = 7
        Me.bDividir.Text = "/"
        Me.bDividir.UseVisualStyleBackColor = True
        '
        'tbResultado
        '
        Me.tbResultado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbResultado.Location = New System.Drawing.Point(3, 26)
        Me.tbResultado.Name = "tbResultado"
        Me.tbResultado.ReadOnly = True
        Me.tbResultado.Size = New System.Drawing.Size(180, 29)
        Me.tbResultado.TabIndex = 8
        Me.tbResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudNum1
        '
        Me.nudNum1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudNum1.DecimalPlaces = 2
        Me.nudNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNum1.Location = New System.Drawing.Point(3, 26)
        Me.nudNum1.Name = "nudNum1"
        Me.nudNum1.Size = New System.Drawing.Size(180, 31)
        Me.nudNum1.TabIndex = 9
        Me.nudNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudNum2
        '
        Me.nudNum2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudNum2.DecimalPlaces = 2
        Me.nudNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNum2.Location = New System.Drawing.Point(3, 26)
        Me.nudNum2.Name = "nudNum2"
        Me.nudNum2.Size = New System.Drawing.Size(180, 31)
        Me.nudNum2.TabIndex = 10
        Me.nudNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.flowLayout1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.bSumar, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.bMultiplicar, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.bDividir, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.flowLayout2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.bElevar, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.bRestar, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.flowLayout3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.bLimpiar, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(383, 207)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'flowLayout1
        '
        Me.flowLayout1.Controls.Add(Me.Label1)
        Me.flowLayout1.Controls.Add(Me.tbResultado)
        Me.flowLayout1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowLayout1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowLayout1.Location = New System.Drawing.Point(3, 3)
        Me.flowLayout1.Name = "flowLayout1"
        Me.flowLayout1.Size = New System.Drawing.Size(185, 63)
        Me.flowLayout1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Resultado"
        '
        'flowLayout2
        '
        Me.flowLayout2.Controls.Add(Me.Label2)
        Me.flowLayout2.Controls.Add(Me.nudNum1)
        Me.flowLayout2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowLayout2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowLayout2.Location = New System.Drawing.Point(3, 72)
        Me.flowLayout2.Name = "flowLayout2"
        Me.flowLayout2.Size = New System.Drawing.Size(185, 63)
        Me.flowLayout2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Primer operando"
        '
        'flowLayout3
        '
        Me.flowLayout3.Controls.Add(Me.Label3)
        Me.flowLayout3.Controls.Add(Me.nudNum2)
        Me.flowLayout3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowLayout3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowLayout3.Location = New System.Drawing.Point(3, 141)
        Me.flowLayout3.Name = "flowLayout3"
        Me.flowLayout3.Size = New System.Drawing.Size(185, 63)
        Me.flowLayout3.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 3)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Segundo operando"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 207)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimumSize = New System.Drawing.Size(399, 246)
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        CType(Me.nudNum1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNum2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.flowLayout1.ResumeLayout(False)
        Me.flowLayout1.PerformLayout()
        Me.flowLayout2.ResumeLayout(False)
        Me.flowLayout2.PerformLayout()
        Me.flowLayout3.ResumeLayout(False)
        Me.flowLayout3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bElevar As Button
    Friend WithEvents bSumar As Button
    Friend WithEvents bMultiplicar As Button
    Friend WithEvents bLimpiar As Button
    Friend WithEvents bRestar As Button
    Friend WithEvents bDividir As Button
    Friend WithEvents tbResultado As TextBox
    Friend WithEvents nudNum1 As NumericUpDown
    Friend WithEvents nudNum2 As NumericUpDown
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents flowLayout1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents flowLayout2 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents flowLayout3 As FlowLayoutPanel
    Friend WithEvents Label3 As Label
End Class
