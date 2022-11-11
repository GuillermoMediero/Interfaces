<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertarDepartamento
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
        Me.lDepartamento = New System.Windows.Forms.Label()
        Me.lNombreJefe = New System.Windows.Forms.Label()
        Me.cbNombreJefe = New System.Windows.Forms.ComboBox()
        Me.tbNombreDep = New System.Windows.Forms.TextBox()
        Me.dgwEmpleados = New System.Windows.Forms.DataGridView()
        Me.bGuardarDep = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgwEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lDepartamento, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lNombreJefe, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cbNombreJefe, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbNombreDep, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgwEmpleados, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.bGuardarDep, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lDepartamento
        '
        Me.lDepartamento.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lDepartamento.AutoSize = True
        Me.lDepartamento.Location = New System.Drawing.Point(239, 18)
        Me.lDepartamento.Name = "lDepartamento"
        Me.lDepartamento.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.lDepartamento.Size = New System.Drawing.Size(158, 16)
        Me.lDepartamento.TabIndex = 0
        Me.lDepartamento.Text = "Nombre Departamento:"
        '
        'lNombreJefe
        '
        Me.lNombreJefe.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lNombreJefe.AutoSize = True
        Me.lNombreJefe.Location = New System.Drawing.Point(167, 71)
        Me.lNombreJefe.Name = "lNombreJefe"
        Me.lNombreJefe.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.lNombreJefe.Size = New System.Drawing.Size(230, 16)
        Me.lNombreJefe.TabIndex = 1
        Me.lNombreJefe.Text = "Nombre del Jef@ del Departameto:"
        '
        'cbNombreJefe
        '
        Me.cbNombreJefe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbNombreJefe.FormattingEnabled = True
        Me.cbNombreJefe.Location = New System.Drawing.Point(403, 67)
        Me.cbNombreJefe.Margin = New System.Windows.Forms.Padding(3, 15, 3, 15)
        Me.cbNombreJefe.Name = "cbNombreJefe"
        Me.cbNombreJefe.Size = New System.Drawing.Size(394, 24)
        Me.cbNombreJefe.TabIndex = 2
        '
        'tbNombreDep
        '
        Me.tbNombreDep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbNombreDep.Location = New System.Drawing.Point(403, 15)
        Me.tbNombreDep.Margin = New System.Windows.Forms.Padding(3, 15, 3, 15)
        Me.tbNombreDep.Name = "tbNombreDep"
        Me.tbNombreDep.Size = New System.Drawing.Size(394, 22)
        Me.tbNombreDep.TabIndex = 3
        '
        'dgwEmpleados
        '
        Me.dgwEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.dgwEmpleados, 2)
        Me.dgwEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwEmpleados.Location = New System.Drawing.Point(3, 109)
        Me.dgwEmpleados.Name = "dgwEmpleados"
        Me.dgwEmpleados.RowHeadersWidth = 51
        Me.dgwEmpleados.RowTemplate.Height = 24
        Me.dgwEmpleados.Size = New System.Drawing.Size(794, 295)
        Me.dgwEmpleados.TabIndex = 4
        '
        'bGuardarDep
        '
        Me.bGuardarDep.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel1.SetColumnSpan(Me.bGuardarDep, 2)
        Me.bGuardarDep.Location = New System.Drawing.Point(362, 417)
        Me.bGuardarDep.Margin = New System.Windows.Forms.Padding(10)
        Me.bGuardarDep.Name = "bGuardarDep"
        Me.bGuardarDep.Size = New System.Drawing.Size(75, 23)
        Me.bGuardarDep.TabIndex = 5
        Me.bGuardarDep.Text = "Guardar"
        Me.bGuardarDep.UseVisualStyleBackColor = True
        '
        'InsertarDepartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InsertarDepartamento"
        Me.Text = "InsertarDepartamento"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgwEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lDepartamento As Label
    Friend WithEvents lNombreJefe As Label
    Friend WithEvents cbNombreJefe As ComboBox
    Friend WithEvents tbNombreDep As TextBox
    Friend WithEvents dgwEmpleados As DataGridView
    Friend WithEvents bGuardarDep As Button
End Class
