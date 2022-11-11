Module Module1

    Dim alumnos As List(Of Estudiante) = New List(Of Estudiante) From {}
    Dim asignaturas As List(Of Asignatura) = New List(Of Asignatura) From {New Asignatura("Matemáticas"), New Asignatura("Lengua Castellana y literatura"), New Asignatura("Física"), New Asignatura("Química"), New Asignatura("Biología"), New Asignatura("Dibujo técnico")}
    Sub Main()
        Dim opcion As Integer


        While opcion <> 8
            opcion = menu()
            Select Case opcion
                Case 1
                    crearEstudiante()
                Case 2
                    matricularEstudianteAsignatura()
                Case 3
                    Console.WriteLine("{0}", opcion)
                Case 4
                    Console.WriteLine("{0}", opcion)
                Case 5
                    Console.WriteLine("{0}", opcion)
                Case 6
                    Console.WriteLine("{0}", opcion)
                Case 7
                    Console.WriteLine("{0}", opcion)
            End Select
        End While
    End Sub

    Sub crearEstudiante()
        Dim nombre, apellido1, apellido2 As String
        Console.WriteLine("Vamos a pedir los datos de un nuevo estudiante")

        Console.Write("Nombre: ")
        nombre = Console.ReadLine()

        Console.Write("Primer apellido: ")
        apellido1 = Console.ReadLine()

        Console.Write("Segundo apellido: ")
        apellido2 = Console.ReadLine()

        alumnos.Add(New Estudiante(nombre, apellido1, apellido2))
    End Sub



    Sub matricularEstudianteAsignatura()
        Dim numalumno, numAsignatura As Integer
        numalumno = elegirAlumno()
        numAsignatura = elegirAsignatura(alumnos(numalumno))
        alumnos(numalumno).asignaturas.Add(asignaturas(numAsignatura))
    End Sub



    Function elegirAsignatura(alumno As Estudiante) As Integer

        Dim noDisponibles As List(Of String) = New List(Of String) From {}
        Dim eleccion As Integer
        Dim x As Integer = 0

        For Each asignatura In alumno.asignaturas
            noDisponibles.Add(asignatura.nombre)
        Next
        Console.WriteLine(vbCrLf + "Introduce el numero de asignatura en la que se va a matricular a {0}", alumno.getNombreCompleto())
        For Each asignatura In asignaturas
            x += 1
            If Not noDisponibles.Contains(asignatura.nombre) Then
                Console.WriteLine("    {0}.- {1}", x, asignatura.nombre)
            End If
        Next

        While Not (Integer.TryParse(Console.ReadLine(), eleccion) AndAlso (eleccion >= 1 AndAlso eleccion <= 6))
            Console.WriteLine("Elige una asignatura (numero del 1 al {0})", x)
        End While

        Return eleccion - 1
    End Function



    Function elegirAlumno() As Integer
        Dim eleccion, x As Integer
        Dim disponible As Boolean
        x = 1

        For Each alumno In alumnos
            If alumno.asignaturas.Count < 6 Then
                If disponible = False Then
                    disponible = True
                    Console.WriteLine("Elige un alumno de la lista: ")
                End If
                Console.WriteLine("    {0}.- {1}", x, alumno.getNombreCompleto())

            End If
            x += 1
        Next
        x -= 1

        If x >= 1 Then
            While Not (Integer.TryParse(Console.ReadLine(), eleccion) AndAlso (eleccion >= 1 AndAlso eleccion <= x))
                Console.WriteLine("Elige un estudiante (numero del 1 al {0})", x)
            End While
        End If

        Return eleccion - 1
    End Function





    Function menu() As Integer
        Dim opcion As Integer
        Console.WriteLine("" + vbCrLf + "" + vbCrLf + "Elige una opción:" + vbCrLf + "      1.- Insertar estudiante" + vbCrLf + "      2.- Matricular estudiante en una asignatura" + vbCrLf + "      3.- Insertar nota a un estudiante en una asignatura" + vbCrLf + "      4.- Visualizar los datos de un estudiante" + vbCrLf + "      5.- Visualizar los datos de una asignatura" + vbCrLf + "      6.- Visualizar los datos de todos los estudiantes" + vbCrLf + "      7.- Visualizar la nota media de un estudiante" + vbCrLf + "      8.- Finalizar")
        While Not (Integer.TryParse(Console.ReadLine(), opcion) AndAlso (opcion >= 1 AndAlso opcion <= 8))
            Console.WriteLine("" + vbCrLf + "" + vbCrLf + "Elige una opción:" + vbCrLf + "      1.- Insertar estudiante" + vbCrLf + "      2.- Matricular estudiante en una asignatura" + vbCrLf + "      3.- Insertar nota a un estudiante en una asignatura" + vbCrLf + "      4.- Visualizar los datos de un estudiante" + vbCrLf + "      5.- Visualizar los datos de una asignatura" + vbCrLf + "      6.- Visualizar los datos de todos los estudiantes" + vbCrLf + "      7.- Visualizar la nota media de un estudiante" + vbCrLf + "      8.- Finalizar")
        End While

        Return opcion
    End Function





    Function pedirNombreAsignatura() As String
        Dim opcion As Integer
        Dim nombre As String
        Console.WriteLine("" + vbCrLf + "" + vbCrLf + "Introduce el número de la asignatura, actualmente se imparten las siguientes:" + vbCrLf + "          1.- Matemáticas" + vbCrLf + "          2.- Lengua castellana y literatura" + vbCrLf + "          3.- Física" + vbCrLf + "          4.- Química" + vbCrLf + "          5.- Biología" + vbCrLf + "          6.- Dibujo técnico")

        While Not (Integer.TryParse(Console.ReadLine(), opcion) AndAlso (opcion >= 1 AndAlso opcion <= 6))
            Console.WriteLine("" + vbCrLf + "" + vbCrLf + "Introduce el número de la asignatura, actualmente se imparten las siguientes:" + vbCrLf + "          1.- Matemáticas" + vbCrLf + "          2.- Lengua castellana y literatura" + vbCrLf + "          3.- Física" + vbCrLf + "          4.- Química" + vbCrLf + "          5.- Biología" + vbCrLf + "          6.- Dibujo técnico")
        End While

        Select Case opcion
            Case 1
                nombre = "Matemáticas"
            Case 2
                nombre = "Lengua castellana y literatura"
            Case 3
                nombre = "Física"
            Case 4
                nombre = "Química"
            Case 5
                nombre = "Biología"
            Case 6
                nombre = "Dibujo técnico"
        End Select

        Return nombre
    End Function

End Module
