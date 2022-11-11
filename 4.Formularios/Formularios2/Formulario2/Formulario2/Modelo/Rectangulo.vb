Public Class Rectangulo
    Private lado As Double
    Private altura As Double

    Public Sub New(lado As Double, altura As Double)
        Me.lado = lado
        Me.altura = altura
    End Sub

    Function calcularArea() As Double
        Return lado * altura
    End Function
End Class
