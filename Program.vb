Imports System

Module Program

    Sub Main(args As String())

        Dim Empleado1 As Empleado
        Empleado1.ID = 1
        Empleado1.Contraseña = "1234"
        Empleado1.Nombre = "PEDRO_MARCOS"
        Empleado1.Departamento = 2
        Empleado1.Edad = 56
        Empleado1.Antiguedad = 34

        Dim Empleado2 As Empleado
        Empleado2.ID = 2
        Empleado2.Contraseña = "HOLA"
        Empleado2.Nombre = "ANA ATUTXA"
        Empleado2.Departamento = 1
        Empleado2.Edad = 23
        Empleado2.Antiguedad = 4

        Dim Empleado3 As Empleado
        Empleado3.ID = 3
        Empleado3.Contraseña = "QWER"
        Empleado3.Nombre = "PEPE FERNANDEZ"
        Empleado3.Departamento = 1
        Empleado3.Edad = 23
        Empleado3.Antiguedad = 8

        Dim Empleado5 As Empleado
        Empleado5.ID = 5
        Empleado5.Contraseña = "ABC"
        Empleado5.Nombre = "JUAN GOMEZ"
        Empleado5.Departamento = 3
        Empleado5.Edad = 65
        Empleado5.Antiguedad = 23

        Dim ListaEmpleados As New ArrayList
        ListaEmpleados.Add(Empleado1)
        ListaEmpleados.Add(Empleado2)
        ListaEmpleados.Add(Empleado3)
        ListaEmpleados.Add(Empleado5)

        Console.WriteLine("¡Bienvenido al Programa de Gestion de Trabajadores de la Empresa A!")
        Dim Seguir As Integer
        Do

            Console.WriteLine(vbLf + "Introduzca su ID de Usuario o Introduzca 0 para registrar a un Nuevo Usuario")

            Dim IDIntroducido As Integer = Console.ReadLine()

            If IDIntroducido = 0 Then

                Dim NuevoEmpleado As Empleado

                Console.WriteLine(vbLf + "Ha elegido la opcion de Registrar un Nuevo Usuario")

                Console.WriteLine(vbLf + vbLf + "Introduzca el Nombre del Nuevo Usuario")
                NuevoEmpleado.Nombre = Console.ReadLine()

                Console.WriteLine(vbLf + "Introduzca el ID del Nuevo Usuario")
                NuevoEmpleado.ID = Console.ReadLine()

                Console.WriteLine(vbLf + "Introduzca la Contraseña del Nuevo Usuario")
                NuevoEmpleado.Contraseña = Console.ReadLine()

                Console.WriteLine(vbLf + "Introduzca el Departamento al que pertenece el Nuevo Usuario")
                NuevoEmpleado.Departamento = Console.ReadLine()

                Console.WriteLine(vbLf + "Introduzca la Edad del Nuevo Usuario")
                NuevoEmpleado.Edad = Console.ReadLine()

                Console.WriteLine(vbLf + "Introduzca los años que lleva trabajando el Nuevo Usuario")
                NuevoEmpleado.Antiguedad = Console.ReadLine()

                Console.WriteLine("El Nuevo Usuario creado tendria los siguientes datos:")
                Console.WriteLine(vbLf + "ID del Usuario:")
                Console.WriteLine(NuevoEmpleado.ID)
                Console.WriteLine(vbLf + "Nombre del Usuario:")
                Console.WriteLine(NuevoEmpleado.Nombre)
                Console.WriteLine(vbLf + "Contraseña del Usuario:")
                Console.WriteLine(NuevoEmpleado.Contraseña)
                Console.WriteLine(vbLf + "Departamento del Usuario:")
                Console.WriteLine(NuevoEmpleado.Departamento)
                Console.WriteLine(vbLf + "Edad del Usuario:")
                Console.WriteLine(NuevoEmpleado.Edad)
                Console.WriteLine(vbLf + "Antiguedad del Usuario:")
                Console.WriteLine(NuevoEmpleado.Antiguedad)
                Console.WriteLine(vbLf + "Salario correspondiente (Euros):")
                Console.WriteLine(NuevoEmpleado.Salario)
                Console.WriteLine(vbLf + "Dias de Vacaciones correspondientes:")
                Console.WriteLine(NuevoEmpleado.Vacaciones)

                Console.WriteLine("Si los datos son correctos se almacenaran")
                Console.WriteLine("Los datos son correctos (S/N)")
                If Console.ReadLine() = "S" Then
                    ListaEmpleados.Add(NuevoEmpleado)
                Else
                End If

            Else

                Console.WriteLine("Introduzca la Contraseña correspondiente")
                Dim PassIntroducida As String = Console.ReadLine()

                For contador = 0 To (ListaEmpleados.Count - 1) Step 1
                    If ListaEmpleados(contador).ID.Equals(IDIntroducido) And ListaEmpleados(contador).Contraseña.Equals(PassIntroducida) Then
                        Console.WriteLine(vbLf + "ID del Usuario:")
                        Console.WriteLine(ListaEmpleados(contador).ID)
                        Console.WriteLine(vbLf + "Nombre del Usuario:")
                        Console.WriteLine(ListaEmpleados(contador).Nombre)
                        Console.WriteLine(vbLf + "Contraseña del Usuario:")
                        Console.WriteLine(ListaEmpleados(contador).Contraseña)
                        Console.WriteLine(vbLf + "Departamento del Usuario:")
                        Console.WriteLine(ListaEmpleados(contador).Departamento)
                        Console.WriteLine(vbLf + "Edad del Usuario:")
                        Console.WriteLine(ListaEmpleados(contador).Edad)
                        Console.WriteLine(vbLf + "Antiguedad del Usuario:")
                        Console.WriteLine(ListaEmpleados(contador).Antiguedad)
                        Console.WriteLine(vbLf + "Salario correspondiente (Euros):")
                        Console.WriteLine(ListaEmpleados(contador).Salario)
                        Console.WriteLine(vbLf + "Dias de Vacaciones correspondientes:")
                        Console.WriteLine(ListaEmpleados(contador).Vacaciones)
                    Else Continue For
                    End If

                Next


            End If

            Console.WriteLine("Introduzca cualquier numero excepto el 0 para continuar con el programa")
            Seguir = Console.ReadLine()
        Loop Until Seguir = 0


    End Sub

    Public Structure Empleado
        Public ID As Integer
        Public Contraseña As String
        Public Nombre As String
        Public Departamento As Integer
        Public Edad As Integer
        Public Antiguedad As Integer
        Public Function Salario()
            Salario = 1500
            Select Case Edad
                Case Is < 18
                    Debug.WriteLine("{Nombre} es Menor de edad y NO puede trabajar")
                Case 18 To 50
                    Salario *= 1.05
                Case 51 To 60
                    Salario *= 1.1
                Case 60 To 80
                    Salario *= 1.15
                Case Else
                    Salario *= 1.15
            End Select
        End Function

        Public Function Vacaciones()
            Vacaciones = 15
            If Departamento = 1 And Antiguedad > 6 Then
                Vacaciones = 20
            ElseIf Departamento = 2 And Antiguedad > 6 Then
                Vacaciones = 25
            ElseIf Departamento = 3 And Antiguedad > 6 Then
                Vacaciones = 30
            End If

        End Function

    End Structure

End Module
