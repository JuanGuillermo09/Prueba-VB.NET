Module Module1

    Sub Main()

        Dim numeros = New Integer() {1, 2, 3, 4}

        For Each num As Integer In numeros

            Console.Write(num & "")

        Next

        ReDim Preserve numeros(5)

        numeros(4) = 5
        numeros(5) = 6

        Console.WriteLine(" ")

        For Each num As Integer In numeros

            Console.Write(num & "")

        Next



        Dim numero = New Integer(,) {{1, 2}, {3, 4}}

        ReDim numero(3, 3)

        numero(0, 0) = 11
        numero(0, 1) = 22
        numero(0, 2) = 33
        numero(1, 0) = 44
        numero(1, 1) = 55
        numero(1, 2) = 66
        numero(2, 0) = 77
        numero(2, 1) = 88
        numero(2, 2) = 99

        For i = 0 To 2 Step 1

            For j = 0 To 2 Step 1

                Console.Write(numero(i, j) & " ")
            Next

        Next



    End Sub

End Module
