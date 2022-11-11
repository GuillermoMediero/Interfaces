Public Class InsertarEmpleado
    Private Sub bAñadirEmpleado_Click(sender As Object, e As EventArgs) Handles bAñadirEmpleado.Click
        Dim Empleado As Empleado
        Empleado = New Empleado(tbNombre.Text, tbPrimerApellido.Text, tbSegundoApellido.Text)
        If Not Form1.checkIfExistEmpleado(Empleado) Then
            Form1.addEmpleado(Empleado)
            MsgBox(Empleado.getNombreCompleto + " insertado Correctamente")
            tbNombre.Text = ""
            tbPrimerApellido.Text = ""
            tbSegundoApellido.Text = ""
        Else
            MsgBox(Empleado.getNombreCompleto + " ya esta creado")
        End If

    End Sub
End Class