Module Module1


    Sub Main()

        'Elaborar un programa de consola en Visual Basic. Net, que permita realizar una operacion basica matematica '
        'entre dos numeros, teniendo en cuenta la opcion del usuario por teclado, siendo 1.Suma, 2.Resta,'
        '3.Multiplicacion, 4.Divicion y 5.Porcentaje.'


        Console.Write("Ingrese 1.Suma, 2.Resta, 3.Multiplicacion, 4.Divicion y 5.Porcentaje---:")
        Dim opcion As Integer = Console.ReadLine()

        Dim numero1, numero2 As Double

        Select Case opcion

            Case 1 : Console.Write("Ingrese el primer numero a sumar---:")
                numero1 = Console.ReadLine()
                Console.Write("Ingrese el segundo numero a sumar---:")
                numero2 = Console.ReadLine()

                Console.WriteLine("La suma de los numeros es---:" & (numero1 + numero2))

            Case 2 : Console.Write("Ingrese el primer numero a restar---:")
                numero1 = Console.ReadLine()
                Console.Write("Ingrese el segundo numero a restar---:")
                numero2 = Console.ReadLine()

                Console.WriteLine("La resta de los numeros es---:" & (numero1 - numero2))

            Case 3 : Console.Write("Ingrese el multiplicando---:")
                numero1 = Console.ReadLine()
                Console.Write("Ingrese el multiplicador---:")
                numero2 = Console.ReadLine()

                Console.WriteLine("La multiplicacion de los numeros es---:" & (numero1 * numero2))

            Case 4 : Console.Write("Ingrese el dividendo---:")
                numero1 = Console.ReadLine()
                Console.Write("Ingrese el divisor---:")
                numero2 = Console.ReadLine()

                Console.WriteLine("La division de los numeros es---:" & (numero1 / numero2))

            Case 5 : Console.Write("Ingrese el numero a sacar el porcentaje---:")
                numero1 = Console.ReadLine()
                Console.Write("Ingrese el porcentaje---:")
                numero2 = Console.ReadLine()

                Console.WriteLine("El " & numero2 & "% de " & numero1 & " es---:" & (numero1 * numero2) / 100)


            Case Else
                Console.WriteLine("La opcion ingresada no es valida")

        End Select


    End Sub


End Module
