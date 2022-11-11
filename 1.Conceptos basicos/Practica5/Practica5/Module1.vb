Module Module1

    Sub Main()
        While True

            Dim pisos, asteriscos, espacios As Integer
            Console.WriteLine("Introduce el numero de pisos de la piramide")
            While Not Integer.TryParse(Console.ReadLine(), pisos)
                Console.WriteLine("Introduce el numero de pisos de la piramide, recuerda que debe ser un numero entero")
            End While

            asteriscos = pisos * 2 - 1

            For i = 1 To pisos

                espacios = i - 1

                Dim caracterEspacio, caracterAsterisco As String

                For index = 1 To espacios
                    caracterEspacio += " "
                Next

                For index = 1 To asteriscos
                    caracterAsterisco += "*"
                Next

                Console.WriteLine("{0}{1}", caracterEspacio, caracterAsterisco)

                asteriscos -= 2
                caracterEspacio = ""
                caracterAsterisco = ""
            Next

        End While
    End Sub

    '   *****
    '    ***
    '     *
End Module
