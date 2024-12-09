Module Module1

    Sub Main()



        'Crear un programa que lea un numero N entero positivo de cualquier numero de digito, '
        'calcule suma de sus digitos y que imprima en pantalla el numero leido y la'
        'suma de sus digitos. Ejemplo: N = 89563 suma = 31'

        Console.Write("Ingrese el digito-->")
        Dim digito As Integer = Console.ReadLine()

        Dim sumaDigitos As Integer = 0

        While digito > 0

            sumaDigitos = sumaDigitos + digito Mod 10

            digito = Math.Truncate(digito / 10)

        End While

        Console.WriteLine("La suma de los digitos es-->" & sumaDigitos)



        '  Ejemplo

        ' Dim numero As Integer = 1

        '  While numero <> 0

        ' Console.WriteLine("Estamos en el bucle while")

        ' Console.Write("Ingrese un nuevo numero para la variable-->")
        ' numero = Console.ReadLine() 

        ' End While

    End Sub

End Module
