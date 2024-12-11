Module Module1

    Sub Main()

        'Valores de la matrioz de la presentacion: 25, 13, 84, 6, 22, 39 '

        '1mera Forma para almacenar datos a la matriz'

        Dim numeros = New Integer(,) {{25, 13, 84}, {6, 22, 39}}



        '2mera Forma para almacenar datos a la matriz'

        Dim numero(2, 3) As Integer

        For filas = 0 To 1 Step 1

            For columna = 0 To 2 Step 1

                Console.Write("Ingrese el numero en la posicion " & filas & " , " & columna & "-----)")
                numero(filas, columna) = Console.ReadLine()

            Next

        Next



        '3mera Forma para almacenar datos a la matriz'

        Dim numer(2, 3) As Integer

        numer(0, 0) = 25
        numer(0, 1) = 13
        numer(0, 2) = 84
        numer(1, 0) = 6
        numer(1, 1) = 22
        numer(1, 2) = 39

        Console.WriteLine(numer(0, 2))

        Dim num As Integer = numer(1, 1)

        Console.WriteLine(num)

        For i = 0 To 1 Step 1

            For j = 0 To 2 Step 1

                Console.WriteLine(numer(i, j))

            Next

        Next

        For Each nu As Integer In numer

            Console.WriteLine(nu)

        Next

        For i = 0 To numer.GetUpperBound(0) - 1 Step 1

            For j = 0 To numer.GetUpperBound(1) - 1 Step 1

                Console.WriteLine(numer(i, j))

            Next

        Next



    End Sub

End Module
