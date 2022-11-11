Module Module1

    Sub Main()
        'sumar, restar, multiplicar, dividir y salir
        Dim opcion, n1, n2 As Integer

        Console.WriteLine("Bienvenido elige una opción: " + vbCrLf + "1.- Sumar " + vbCrLf + "2.- Restar " + vbCrLf + "3.- Multiplicar " + vbCrLf + "4.- Dividir " + vbCrLf + "5.- Salir")
        While Not (Integer.TryParse(Console.ReadLine(), opcion) And (opcion >= 1 And opcion <= 5))
            Console.WriteLine("Bienvenido elige una opción: " + vbCrLf + "1.- Sumar " + vbCrLf + "2.- Restar " + vbCrLf + "3.- Multiplicar " + vbCrLf + "4.- Dividir " + vbCrLf + "5.- Salir")
        End While

        If opcion <> 5 Then
            Console.WriteLine("Introduce el primer numero")
            While Not (Integer.TryParse(Console.ReadLine(), n1))
                Console.WriteLine("Introduce el primer numero")
            End While

            Console.WriteLine("Introduce el segundo numero")
            While Not (Integer.TryParse(Console.ReadLine(), n2))
                Console.WriteLine("Introduce el segundo numero")
            End While
        End If

        Select Case opcion
            Case 1
                Console.WriteLine("{0} + {1} = {2}", n1, n2, n1 + n2)
            Case 2
                Console.WriteLine("{0} - {1} = {2}", n1, n2, n1 - n2)
            Case 3
                Console.WriteLine("{0} * {1} = {2}", n1, n2, n1 * n2)
            Case 4
                Console.WriteLine("{0} / {1} = {2}", n1, n2, n1 / n2)
            Case 5
                Console.WriteLine("¡Hasta pronto!")

        End Select
    End Sub

End Module
