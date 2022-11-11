Public Class Departamento
    Public Sub New(nombre As String, jefe As Empleado, empleados As List(Of Empleado))
        Me.nombre = nombre
        Me.jefe = jefe
        Me.empleados = empleados
    End Sub

    Property nombre As String
    Property jefe As Empleado
    Property empleados As List(Of Empleado)
End Class
