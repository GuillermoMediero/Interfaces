Public Class InsertarDepartamento
    Private Sub InsertarDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()

    End Sub

    Sub CargarDatos()
        cbNombreJefe.Items.Clear()
        dgwEmpleados.Rows.Clear()

        For Each empleado In Form1.misEmpleados
            cbNombreJefe.Items.Add(empleado)
            dgwEmpleados.Rows.Add(empleado)
        Next

    End Sub

End Class