Public Class Estudiante
    Public Sub New(nombre As String, apellido1 As String, apellido2 As String)
        Me.nombre = nombre
        Me.apellido1 = apellido1
        Me.apellido2 = apellido2
        Me.asignaturas = New List(Of Asignatura) From {}
    End Sub

    Property nombre As String
    Property apellido1 As String
    Property apellido2 As String
    Property asignaturas As List(Of Asignatura)
    Public Function getNombreCompleto() As String
        Return Me.nombre + " " + Me.apellido1 + " " + Me.apellido2
    End Function
End Class