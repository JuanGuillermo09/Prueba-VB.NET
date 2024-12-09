Module Module1

    Sub Main()



        'si es false el bucle se repite'

        Dim numero As Integer

        Do
            Console.Write("Ingrese un numero-->")
            numero = Console.ReadLine()

            Console.WriteLine("Este es el mejor curso de Visual Basec. Net")

        Loop Until numero <> 0



        'si es true el bucle se repite'

        Dim numer As Integer

        Do
            Console.Write("Ingrese un numero-->")
            numer = Console.ReadLine()

            Console.WriteLine("Este es el mejor curso de Visual Basec. Net")

        Loop While numer <> 0


    End Sub

End Module
