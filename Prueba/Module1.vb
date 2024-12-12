Module Module1

    Sub Main()

        Dim vector(2) As Integer
        Dim matriz(1, 1) As Integer

        vector(0) = 15
        vector(1) = 30
        vector(2) = 45

        matriz(0, 0) = 20
        matriz(0, 1) = 40
        matriz(1, 0) = 60
        matriz(1, 1) = 80

        For Each num As Integer In vector

            Console.Write(num & " ")

        Next

        Console.WriteLine("")

        For Each num As Integer In matriz

            Console.Write(num & " ")

        Next



    End Sub

End Module
