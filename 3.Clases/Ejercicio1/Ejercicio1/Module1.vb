Imports System.Reflection

Module Module1

    Sub Main()
        Dim numDep, numEmp As Integer
        Dim nombreDept As String
        Dim empleados As List(Of Empleado)
        Dim empleado As Empleado
        Dim dept As Departamento

        Dim nombre, apellido1, apellido2 As String
        Console.WriteLine("Introduce el número de departamentos")
        numDep = pedirInt(1)

        Dim empresa = New Empresa(New List(Of Departamento) From {})

        For x = 1 To numDep

            Console.WriteLine("Introduce el nombre del departamento")
            nombreDept = Console.ReadLine()

            Console.WriteLine("Introduce el nombre del jefe del departamento de {0}", nombreDept)
            nombre = Console.ReadLine()

            Console.WriteLine("Introduce el primer apellido del jefe del departamento de {0}", nombreDept)
            apellido1 = Console.ReadLine()

            Console.WriteLine("Introduce el segundo apellido del jefe del departamento de {0}", nombreDept)
            apellido2 = Console.ReadLine()

            empleado = New Empleado(nombre, apellido1, apellido2)

            dept = New Departamento(nombreDept, empleado, New List(Of Empleado) From {})

            Console.WriteLine("Introduce el número de empleados del departamento de {0}", nombreDept)
            numEmp = pedirInt(1)

            For y = 1 To numEmp
                Console.WriteLine("Introduce el nombre del empleado {1} del departamento de {0}", nombreDept, y)
                nombre = Console.ReadLine()

                Console.WriteLine("Introduce el primer apellido del empleado {1} del departamento de {0}", nombreDept, y)
                apellido1 = Console.ReadLine()

                Console.WriteLine("Introduce el segundo apellido del empleado {1} del departamento de {0}", nombreDept, y)
                apellido2 = Console.ReadLine()

                empleado = New Empleado(nombre, apellido1, apellido2)

                dept.empleados.Add(empleado)
            Next

            empresa.departamentos.Add(dept)
        Next

        For Each departamento In empresa.departamentos
            Console.Write("Departamento: ")
            Console.WriteLine("{0}", departamento.nombre)
            Console.Write("Jefe: ")
            Console.WriteLine("{0}", departamento.jefe.getNombreCompleto())

            Dim x As Integer = 1
            For Each empleado In departamento.empleados
                Console.WriteLine("     {0}.- Trabajador: {1}", x, empleado.getNombreCompleto())
                x = x + 1
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
