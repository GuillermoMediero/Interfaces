Public Class Calculadora
    Private num1 As Double
    Private num2 As Double

    Public Sub New(num1 As Double, num2 As Double)
        Me.num1 = num1
        Me.num2 = num2
    End Sub

    Function sumar() As Double
        Return num1 + num2
    End Function

    Function restar() As Double
        Return num1 - num2
    End Function

    Function multiplicar() As Double
        Return num1 * num2
    End Function

    Function dividir() As Double
        If num2 = 0 Then
            MsgBox("No puedes dividir entre 0")
            Exit Function
        Else
            Return num1 / num2
        End If
    End Function

    Function elevar() As Double
        Return num1 ^ num2
    End Function

End Class
