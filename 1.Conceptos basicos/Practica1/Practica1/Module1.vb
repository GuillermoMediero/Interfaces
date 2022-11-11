Module Module1

    Sub Main()
        Dim n1, n2 As Integer
        Console.WriteLine("Introduce el primer número")
        While Not Integer.TryParse(Console.ReadLine(), n1)
            Console.WriteLine("Introduce el primer número")
        End While

        Console.WriteLine("Introduce el segundo número")
        While Not Integer.TryParse(Console.ReadLine(), n2)
            Console.WriteLine("Introduce el segundo número")
        End While

        If n1 > n2 Then
            Console.WriteLine("El resultado de la resta es {0} y el de la suma, {1}", n1 - n2, n1 + n2)
        Else
            Console.WriteLine("El resultado de la suma es {0}", n1 + n2)
        End If
    End Sub

End Module
