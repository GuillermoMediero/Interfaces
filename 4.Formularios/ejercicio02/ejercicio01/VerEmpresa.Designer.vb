﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VerEmpresa
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
        Me.flDepartamentos = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'flDepartamentos
        '
        Me.flDepartamentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.flDepartamentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flDepartamentos.Location = New System.Drawing.Point(0, 0)
        Me.flDepartamentos.MinimumSize = New System.Drawing.Size(646, 404)
        Me.flDepartamentos.Name = "flDepartamentos"
        Me.flDepartamentos.Size = New System.Drawing.Size(646, 404)
        Me.flDepartamentos.TabIndex = 0
        '
        'VerEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 404)
        Me.Controls.Add(Me.flDepartamentos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(646, 404)
        Me.Name = "VerEmpresa"
        Me.Text = "VerEmpresa"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flDepartamentos As FlowLayoutPanel
End Class
