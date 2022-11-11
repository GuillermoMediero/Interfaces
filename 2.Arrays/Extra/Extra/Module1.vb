Module Module1

    Sub Main()
        'El usuario nos mostrará por en pantalla el siguiente menú
        '1.- Comprobar si es primo.
        '2.- Calcular la factorial
        '3.-Visualizar la tabla de multiplicar
        '4.-Salir del programa.
        'Elige una opción
        'Cuando el usuario nos indique la opción que desea ejecutar le pedimos que nos teclee un
        'número y realizamos las operaciones pertinentes. Cuando tengamos el resultado lo
        'visualizamos en pantalla y volvemos a mostrar el menú hasta que seleccione la opción 4
        'para salir de la ejecución del ejercicio

        Dim eleccion, num As Integer

        Dim seguir As Boolean = True

        While seguir
            menu()
            eleccion = pedirInt(1, 4)

            Select Case eleccion
                Case 1
                    Console.WriteLine("Introduce un número para saber si es primo o no")
                    num = pedirInt()
                    If numerosPrimos(num) Then
                        Console.WriteLine("El número {0} es primo", num)
                    Else
                        Console.WriteLine("El número {0} NO es primo", num)
                    End If
                Case 2
                    Console.WriteLine("Introduce un número para calcular su factorial")
                    num = pedirInt()
                    Dim fact = factorial(num)
                    Console.WriteLine("El factorial de {0} es {1}", num, fact)
                Case 3
                    Console.WriteLine("Introduce un número para ver su tabla de multiplicar (●'◡'●)")
                    num = pedirInt()
                    Console.WriteLine(tablaMultiplicar(num))

                Case Else
                    seguir = False
            End Select

        End While
    End Sub

    Sub menu()
        Console.WriteLine("Elige una opción: " + vbCrLf + "1.- Comprobar números primos " + vbCrLf + "2.- Calcular la factorial " + vbCrLf + "3.- Visualizar la tabla de multiplicar " + vbCrLf + "4.- Salir ")
    End Sub

    Function pedirInt(Optional min As Integer = 0, Optional max As Integer = 10000) As Integer
        Dim a As Integer
        While Not (Integer.TryParse(Console.ReadLine(), a) And (a <= max And a >= min))
            menu()
        End While
        Return a
    End Function

    Function numerosPrimos(num As Integer) As Boolean
        If num <= 1 Then
            Return False
        End If
        For i = 2 To num - 1
            If num Mod i = 0 Then
                Return False
            End If
        Next
        Return True
    End Function

    Function factorial(num As Integer) As Integer
        Dim result As Integer = 1
        For index = 1 To num
            result = result * index
        Next
        Return result
    End Function

    Function tablaMultiplicar(num As Integer) As String
        Dim result As String = "Tabla del " + CStr(num) + vbCrLf
        For index = 1 To 10
            result = result + CStr(num) + " x " + CStr(index) + " = " + CStr(num * index) + vbCrLf
        Next
        Return result
    End Function
End Module