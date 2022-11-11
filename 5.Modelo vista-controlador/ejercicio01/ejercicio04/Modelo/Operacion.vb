Public Class Operacion
    Dim num1 As Double
    Dim num2 As Double
    Dim tipo As ControladorCalculadora.Operaciones

    Public Sub New(num1 As Double, num2 As Double, tipo As ControladorCalculadora.Operaciones)
        Me.num1 = num1
        Me.num2 = num2
        Me.tipo = tipo
    End Sub

    Function Operar() As Double
        Select Case tipo
            Case ControladorCalculadora.Operaciones.Elevar
                Operar = num1 ^ num2
            Case ControladorCalculadora.Operaciones.Sumar
                Operar = num1 + num2
            Case ControladorCalculadora.Operaciones.Restar
                Operar = num1 - num2
            Case ControladorCalculadora.Operaciones.Multiplicar
                Operar = num1 * num2
            Case ControladorCalculadora.Operaciones.Dividir
                Operar = num1 / num2
        End Select
        Return Operar
    End Function
End Class
