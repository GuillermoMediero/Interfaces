Public Class ControladorCalculadora
    Enum Operaciones
        Sumar
        Restar
        Dividir
        Multiplicar
        Elevar
    End Enum
    Function Operar(num1 As Double, num2 As Double, tipo As Operaciones) As String
        Dim miOperacion As New Operacion(num1, num2, tipo)
        If tipo = Operaciones.Dividir AndAlso num2 = 0 Then
            Throw New System.Exception("No se puede dividir entre 0. Cambia el valor del segundo número")
        Else
            Return String.Format("{0}", miOperacion.Operar())
        End If

    End Function
End Class
