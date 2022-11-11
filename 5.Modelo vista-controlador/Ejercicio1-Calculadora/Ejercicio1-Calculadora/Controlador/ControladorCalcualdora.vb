Public Class ControladorCalcualdora

    Function calcularResultado(num1 As Double, num2 As Double, opcion As String) As Double
        Dim calculador As New Calculadora(num1, num2)
        Dim resultado As Double
        Select Case opcion
            Case "sumar"
                resultado = calculador.sumar()
            Case "restar"
                resultado = calculador.restar()
            Case "multiplicar"
                resultado = calculador.multiplicar()
            Case "dividir"
                resultado = calculador.dividir()
            Case "elevar"
                resultado = calculador.elevar()
        End Select

        Return resultado
    End Function
End Class
