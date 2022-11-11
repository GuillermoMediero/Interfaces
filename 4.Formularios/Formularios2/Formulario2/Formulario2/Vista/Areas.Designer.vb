<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Areas
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
        Me.nudNumArea1 = New System.Windows.Forms.NumericUpDown()
        Me.nudNumArea2 = New System.Windows.Forms.NumericUpDown()
        Me.tbResultadoArea = New System.Windows.Forms.TextBox()
        Me.bCalcularArea = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.nudNumArea1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumArea2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.nudNumArea1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.nudNumArea2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbResultadoArea, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.bCalcularArea, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(551, 296)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'nudNumArea1
        '
        Me.nudNumArea1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudNumArea1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNumArea1.Location = New System.Drawing.Point(5, 56)
        Me.nudNumArea1.Margin = New System.Windows.Forms.Padding(5)
        Me.nudNumArea1.Name = "nudNumArea1"
        Me.nudNumArea1.Size = New System.Drawing.Size(265, 36)
        Me.nudNumArea1.TabIndex = 0
        '
        'nudNumArea2
        '
        Me.nudNumArea2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudNumArea2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNumArea2.Location = New System.Drawing.Point(280, 56)
        Me.nudNumArea2.Margin = New System.Windows.Forms.Padding(5)
        Me.nudNumArea2.Name = "nudNumArea2"
        Me.nudNumArea2.Size = New System.Drawing.Size(266, 36)
        Me.nudNumArea2.TabIndex = 1
        '
        'tbResultadoArea
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.tbResultadoArea, 2)
        Me.tbResultadoArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbResultadoArea.Enabled = False
        Me.tbResultadoArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbResultadoArea.Location = New System.Drawing.Point(5, 5)
        Me.tbResultadoArea.Margin = New System.Windows.Forms.Padding(5)
        Me.tbResultadoArea.Name = "tbResultadoArea"
        Me.tbResultadoArea.Size = New System.Drawing.Size(541, 41)
        Me.tbResultadoArea.TabIndex = 2
        '
        'bCalcularArea
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.bCalcularArea, 2)
        Me.bCalcularArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bCalcularArea.Location = New System.Drawing.Point(5, 102)
        Me.bCalcularArea.Margin = New System.Windows.Forms.Padding(5)
        Me.bCalcularArea.Name = "bCalcularArea"
        Me.bCalcularArea.Size = New System.Drawing.Size(541, 189)
        Me.bCalcularArea.TabIndex = 3
        Me.bCalcularArea.Text = "Calcular Area"
        Me.bCalcularArea.UseVisualStyleBackColor = True
        '
        'Areas
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(551, 296)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Areas"
        Me.Text = "Areas"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.nudNumArea1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumArea2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents nudNumArea1 As NumericUpDown
    Friend WithEvents nudNumArea2 As NumericUpDown
    Friend WithEvents tbResultadoArea As TextBox
    Friend WithEvents bCalcularArea As Button
End Class
