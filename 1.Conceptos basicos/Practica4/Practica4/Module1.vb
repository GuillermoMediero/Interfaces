Module Module1

    Sub Main()
        Dim horas, sueldo As Integer
        Dim estadoCivil, estudios As String

        Console.WriteLine("Introduzca el número de horas trabajadas por el empleado en el mes")
        While Not Integer.TryParse(Console.ReadLine(), horas)
            Console.WriteLine("Introduzca el número de horas trabajadas por el empleado en el mes")
        End While

        If horas > 160 Then
            Dim extras As Integer = horas - 160
            sueldo = 160 * 10 + extras * 15
        Else
            sueldo = horas * 10
        End If

        While Not (estadoCivil = "S" OrElse estadoCivil = "C" OrElse estadoCivil = "V" OrElse estadoCivil = "D")
            Console.WriteLine("Introduzca el estado civil del empleado (S C V D)")
            estadoCivil = Console.ReadLine().ToUpper()
        End While

        While Not (estudios = "S" OrElse estudios = "P" OrElse estudios = "M")
            Console.WriteLine("Introduzca el nivel de estudios del empleado (P M S)")
            estudios = Console.ReadLine().ToUpper()
        End While

        Select Case estadoCivil + estudios
            Case "SP", "SS", "SM", "CS", "DS", "VS", "VP"
                sueldo += 100
        End Select

        Console.WriteLine("{0}", sueldo)

        'SP SS SM CS DS VS VP 
    End Sub

End Module
