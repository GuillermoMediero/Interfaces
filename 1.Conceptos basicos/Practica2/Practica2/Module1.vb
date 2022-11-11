Module Module1

    Sub Main()
        Dim mes, anno, dias As Integer
        Console.WriteLine("Introduce el mes")
        While Not (Integer.TryParse(Console.ReadLine(), mes) And (mes <= 12 And mes >= 1))
            Console.WriteLine("Introduce el mes")
        End While

        Console.WriteLine("Introduce el año")
        While Not (Integer.TryParse(Console.ReadLine(), anno) And anno >= 0)
            Console.WriteLine("Introduce el año")
        End While

        Select Case mes
            Case 1, 3, 5, 7, 8, 10, 12
                dias = 31
            Case 4, 6, 9, 11
                dias = 30
            Case 2
                dias = 28
                If anno Mod 4 = 0 OrElse (anno Mod 100 = 0 AndAlso anno Mod 400 = 0) Then
                    dias = 29
                End If
        End Select
        Console.WriteLine("Este mes tiene {0} dias", dias)
    End Sub

End Module
