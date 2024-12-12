Module Module1

    Sub Main()

        Dim numeros = New Integer() {233, 301, 192, 169, 215}

        Dim menor As Integer = numeros(0)

        Dim posMenor As Integer = 0

        For i = 1 To numeros.Length.ToString - 1 Step 1

            If numeros(i) < menor Then

                menor = numeros(i + 1)
                posMenor = i

            End If

        Next

        Dim aux As Integer = numeros(0)
        numeros(0) = numeros(posMenor)
        numeros(posMenor) = aux

        For Each num As Integer In numeros

            Console.Write(num & " ")

        Next

    End Sub

End Module
