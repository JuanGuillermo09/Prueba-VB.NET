Module Module1


    Sub Main()

        Dim numero As Integer = 5

        cambiarNumeroVariable(numero, 45)

        Console.WriteLine(numero)

    End Sub


    Sub cambiarNumeroVariable(ByRef num As Integer, numNuevo As Integer)

        num = numNuevo

    End Sub

End Module
