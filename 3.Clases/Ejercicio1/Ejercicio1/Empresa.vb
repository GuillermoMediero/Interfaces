Public Class Empresa
    Public Sub New(departamentos As List(Of Departamento))
        Me.departamentos = departamentos
    End Sub

    Property departamentos As List(Of Departamento)
End Class
