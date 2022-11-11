Module Module1
    'Crearemos una matriz para guardar datos de nuestra
    'empresa. Queremos guardar los nombres de los
    'departamentos, y el nombre del jefe de departamento y los
    'nombres de las personas que trabajan en el departamento.
    'No en todos los departamentos habrá el mismo número de
    'personas trabajando.
    'Para crear la matriz le pediremos al usuario el número de
    'departamentos. Para insertar los datos de los
    'departamentos deberemos pedir el número de trabajadores
    'o trabajadoras del departamento, y después el resto de
    'datos. Una vez insertados todos los datos, los
    'visualizaremos como en la imagen.




    'bd     => [array1,array2,array3]
    'array1 => [nombre,jefe,trabajador1,trabajador2,trabajador3]

    Sub Main()
        Dim departamentos, numtrabajadores As Integer

        Console.WriteLine("Introduce el número de departamentos")
        departamentos = pedirInt(1)

        Dim bd As String()() = New String(departamentos - 1)() {}

        For x = 1 To bd.GetLength(0)

            'Dim dept, jefe, trabajador As String

            'Console.WriteLine("Introduce el nombre del departamento")
            'dept = Console.ReadLine()

            'Console.WriteLine("Introduce el nombre del jefe de departamento")
            'jefe = Console.ReadLine()

            Console.WriteLine("Introduce el numero de empleados del departamento")
            numtrabajadores = pedirInt(1)
            bd(x - 1) = New String(numtrabajadores + 1) {}

            For y = 1 To numtrabajadores + 2
                Dim texto As String
                Select Case y
                    Case 1
                        Console.WriteLine("Introduce el nombre del departamento")
                    Case 2
                        Console.WriteLine("Introduce el nombre del jefe de departamento")
                    Case Else
                        Console.WriteLine("Introduce el nombre del empleado {0}", y - 2)
                End Select

                texto = Console.ReadLine()

                bd(x - 1)(y - 1) = texto
            Next

        Next

        'Departamento: xxxx
        'Jefe del departamento: xxxx
        '       1.- Trabajador: xxxx
        '       2.- Trabajador: xxxx
        '       3.- Trabajador: xxxx

        Console.WriteLine("")
        Console.WriteLine("")
        For Each departamento In bd
            Console.Write("Departamento: ")
            Console.WriteLine("{0}", departamento(0))

            Console.Write("Jefe del departamento: ")
            Console.WriteLine("{0}", departamento(1))

            For index = 2 To departamento.Length - 1
                Console.Write("     {0}.- Trabajador: ", index - 1)
                Console.WriteLine("{0}", departamento(index))
            Next

        Next


    End Sub

    Function pedirInt(Optional min As Integer = 0, Optional max As Integer = 10000) As Integer
        Dim a As Integer
        While Not (Integer.TryParse(Console.ReadLine(), a) And (a <= max And a >= min))
            Console.WriteLine("Introduce un número entero")
        End While
        Return a
    End Function

End Module
