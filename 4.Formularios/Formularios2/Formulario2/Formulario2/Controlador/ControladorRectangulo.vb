Public Class ControladorRectangulo
    Public Function calcularArea(lado As Double, altura As Double) As Double
        Dim rectangulo As Rectangulo = New Rectangulo(lado, altura)
        Return rectangulo.calcularArea()
    End Function
End Class
