Module Module1


    Sub Main()

        'Elaborar un programa de consola en Visual Basic. Net, que ingresado el valor total por teclado de una compra '
        'realice un descuento de acuerdo a los siguiente: si el valor comprado esta entre 50-100 el descuento es del 5%,'
        'si esta entre 101-150 el descuento es del 10% y si la compra es mayor a 150 el descuento es del 15%,'
        'el programa debe mostrar el total de la compra, el total de la compra con el descuento y el descuento'.



        Console.Write("Ingrese el valor total de la compra---:")
        Dim valorCompra As Double = Console.ReadLine()

        Dim descuento As Double = 0


        If valorCompra >= 50 And valorCompra <= 100 Then

            descuento = valorCompra * 0.05

        ElseIf valorCompra > 100 And valorCompra <= 150 Then

            descuento = valorCompra * 0.1

        ElseIf valorCompra > 150 Then

            descuento = valorCompra * 0.15

        End If

        Console.WriteLine("El valor total de la compra sin descuento es ---: " & valorCompra)
        Console.WriteLine("El valor total de la compra con descuento es ---: " & valorCompra - descuento)
        Console.WriteLine("El valor descontado en la compra es ---: " & descuento)

    End Sub


End Module
