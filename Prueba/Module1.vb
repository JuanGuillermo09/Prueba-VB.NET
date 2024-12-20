Module Module1


    Sub Main()

        Dim resultado As Integer = Sumar(20, 15)

        Console.WriteLine(Sumar(9, 8))

        Dim numeros = New Integer() {25, 48, 17, 33, 54, 99, 103}

        Console.WriteLine(buscarNumeroArray(33, numeros))


    End Sub

    'Realiza un procedimiento que permita retornar la suma entre dos numeros enteros

    Function Sumar(num1 As Integer, num2 As Integer) As Integer

        Dim resultado As Integer = num1 + num2

        Return resultado

    End Function

    'Realiza un procedimiento que permita buscar un numero en concreto dentro de un array,
    ' retornando la posicion donde encontro el elemento buscado. 

    Function buscarNumeroArray(numBuscar As Integer, vector() As Integer) As Integer

        Dim pos As Integer = -1

        Dim encontrado As Boolean = False

        For i = 0 To vector.Length - 1 And encontrado = False Step 1

            If vector(i) = numBuscar Then

                pos = i

                encontrado = True

            End If

        Next

        Return pos

    End Function






End Module
