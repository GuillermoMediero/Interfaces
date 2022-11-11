<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InsertarEmpleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lNombre = New System.Windows.Forms.Label()
        Me.lPrimerApellido = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbPrimerApellido = New System.Windows.Forms.TextBox()
        Me.tbSegundoApellido = New System.Windows.Forms.TextBox()
        Me.bAñadirEmpleado = New System.Windows.Forms.Button()
        Me.lSegundoApellido = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.53846!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23077!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23077!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23077!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23077!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.53846!))
        Me.TableLayoutPanel1.Controls.Add(Me.lNombre, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lPrimerApellido, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbNombre, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbPrimerApellido, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbSegundoApellido, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.bAñadirEmpleado, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lSegundoApellido, 1, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lNombre
        '
        Me.lNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lNombre.AutoSize = True
        Me.lNombre.Location = New System.Drawing.Point(166, 157)
        Me.lNombre.Margin = New System.Windows.Forms.Padding(0, 10, 20, 10)
        Me.lNombre.Name = "lNombre"
        Me.lNombre.Size = New System.Drawing.Size(59, 16)
        Me.lNombre.TabIndex = 0
        Me.lNombre.Text = "Nombre:"
        '
        'lPrimerApellido
        '
        Me.lPrimerApellido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lPrimerApellido.AutoSize = True
        Me.lPrimerApellido.Location = New System.Drawing.Point(123, 199)
        Me.lPrimerApellido.Margin = New System.Windows.Forms.Padding(0, 10, 20, 10)
        Me.lPrimerApellido.Name = "lPrimerApellido"
        Me.lPrimerApellido.Size = New System.Drawing.Size(102, 16)
        Me.lPrimerApellido.TabIndex = 1
        Me.lPrimerApellido.Text = "Primer Apellido:"
        '
        'tbNombre
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.tbNombre, 3)
        Me.tbNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbNombre.Location = New System.Drawing.Point(245, 157)
        Me.tbNombre.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(459, 22)
        Me.tbNombre.TabIndex = 3
        '
        'tbPrimerApellido
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.tbPrimerApellido, 3)
        Me.tbPrimerApellido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbPrimerApellido.Location = New System.Drawing.Point(245, 199)
        Me.tbPrimerApellido.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.tbPrimerApellido.Name = "tbPrimerApellido"
        Me.tbPrimerApellido.Size = New System.Drawing.Size(459, 22)
        Me.tbPrimerApellido.TabIndex = 4
        '
        'tbSegundoApellido
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.tbSegundoApellido, 3)
        Me.tbSegundoApellido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbSegundoApellido.Location = New System.Drawing.Point(245, 241)
        Me.tbSegundoApellido.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.tbSegundoApellido.Name = "tbSegundoApellido"
        Me.tbSegundoApellido.Size = New System.Drawing.Size(459, 22)
        Me.tbSegundoApellido.TabIndex = 5
        '
        'bAñadirEmpleado
        '
        Me.bAñadirEmpleado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.bAñadirEmpleado, 2)
        Me.bAñadirEmpleado.Location = New System.Drawing.Point(360, 276)
        Me.bAñadirEmpleado.Name = "bAñadirEmpleado"
        Me.bAñadirEmpleado.Size = New System.Drawing.Size(75, 23)
        Me.bAñadirEmpleado.TabIndex = 6
        Me.bAñadirEmpleado.Text = "Guardar"
        Me.bAñadirEmpleado.UseVisualStyleBackColor = True
        '
        'lSegundoApellido
        '
        Me.lSegundoApellido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lSegundoApellido.AutoSize = True
        Me.lSegundoApellido.Location = New System.Drawing.Point(110, 241)
        Me.lSegundoApellido.Margin = New System.Windows.Forms.Padding(0, 10, 20, 10)
        Me.lSegundoApellido.Name = "lSegundoApellido"
        Me.lSegundoApellido.Size = New System.Drawing.Size(115, 16)
        Me.lSegundoApellido.TabIndex = 2
        Me.lSegundoApellido.Text = "SegundoApellido:"
        '
        'InsertarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InsertarEmpleado"
        Me.Text = "InsertarEmpleado"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lNombre As Label
    Friend WithEvents lPrimerApellido As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbPrimerApellido As TextBox
    Friend WithEvents tbSegundoApellido As TextBox
    Friend WithEvents bAñadirEmpleado As Button
    Friend WithEvents lSegundoApellido As Label
End Class
