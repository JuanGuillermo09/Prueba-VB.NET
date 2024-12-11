Module Module1

    Sub Main()

        'Valores del array nombres de la presentacion: Maria, Pedro, Daniela, Juan, Carlos, Camila '



        ' 1mra forma de almacenar datos en una array'

        Dim nombres = New String() {"Maria", "Pedro", "Daniela", "Juan", "Carlos", "Camila"}

        ' 2mra forma de almacenar datos en una array'

        Dim nombre(6) As String

        For i = 0 To nombre.Length - 1 Step 1

            Console.Write("Ingrese el nombre en la posicion " & i & " -----)")

            nombre(i) = Console.ReadLine()

        Next

        ' 3mra forma de almacenar datos en una array'

        Dim nombr(6) As String

        nombr(0) = "Maria"
        nombr(1) = "Pedro"
        nombr(2) = "Daniela"
        nombr(3) = "Juan"
        nombr(4) = "Carlos"
        nombr(5) = "Camila"

        Console.WriteLine(nombr(3))

        Dim nomb As String = nombr(4)

        Console.WriteLine(nombr)

        For i = 0 To nombr.Length - 1 Step 1

            Console.WriteLine(nombr(i))

        Next

        For Each nom As String In nombr

            Console.WriteLine(nom)

        Next






    End Sub

End Module
