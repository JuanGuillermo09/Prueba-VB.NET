Module Module1

    Sub Main()

        Dim numeros = New Integer() {14, 28, 56}

        Dim arrayCopia(3) As Integer

        For i = 0 To 2 Step 1

            arrayCopia(i) = numeros(i)

        Next

        For i = 0 To 2 Step 1

            Console.Write(arrayCopia(i) & " ")

        Next



        Dim numero = New Integer() {14, 28, 56}

        Dim arrayCopi(2) As Integer

        For i = 0 To 2 Step 1

            arrayCopi(i) = numero(i)

        Next

        For i = 0 To arrayCopi.Length - 1 Step 1

            Console.Write(arrayCopi(i) & " ")

        Next


        Dim matrizOrigen = New Integer(,) {{14, 28}, {56, 70}}

        Dim matrizCopia(2, 2) As Integer

        For i = 0 To 1 Step 1

            For j = 0 To 1 Step 1

                matrizCopia(i, j) = matrizOrigen(i, j)

            Next

        Next

        For i = 0 To 1 Step 1

            For j = 0 To 1 Step 1

                Console.Write(matrizCopia(i, j) & " ")

            Next

        Next










    End Sub

End Module
