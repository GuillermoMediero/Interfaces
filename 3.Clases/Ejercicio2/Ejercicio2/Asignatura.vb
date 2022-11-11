Public Class Asignatura
    Public Sub New(nombre As String)
        Me.nombre = nombre
        Me.alumnos = New List(Of Estudiante) From {}
    End Sub


    Property nombre As String
    Property nota As String
    Property alumnos As List(Of Estudiante)

End Class
