Module Module1

    Sub Main()

        ' Buscar la posicion de un dato'

        Dim edades = New Integer() {25, 21, 43, 58, 34}

        Dim edad, indice As Integer

        Dim encontrado As Boolean = False

        Console.Write("Ingrese el numero a buscar ---)")
        edad = Console.ReadLine()

        For i = 0 To edades.Length - 1 And encontrado = False Step 1

            If edad = edades(i) Then

                indice = i

                encontrado = True

            End If

        Next

        If encontrado = True Then

            Console.WriteLine("El valor buscado se encuentra en la posicion: " & indice)

        Else

            Console.WriteLine("El valor a buscar no fue encontrado")

        End If




        'Buscar numeros menores de 50 '

        Dim edade = New Integer() {25, 21, 43, 58, 34}

        Dim contadora As Integer = 0

        For i = 0 To edade.Length - 1 Step 1

            If edade(i) < 50 Then

                contadora += 1

            End If

        Next

        Console.WriteLine("El numero de personas cuya edad es menor a 50 es: " & contadora)

    End Sub

End Module
