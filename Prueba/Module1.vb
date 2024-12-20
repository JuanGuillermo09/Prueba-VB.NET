Module Module1

    Sub Main()

        Dim hyu As AireAcondicionado = New AireAcondicionado()

        hyu.marca = "hyu"
        hyu.modelo = "hy220ac18k2020"
        hyu.color = "azul"
        hyu.voltaje = 220
        hyu.btu = 18000
        hyu.temperatura = 0

        Console.WriteLine(hyu.marca)
        Console.WriteLine(hyu.modelo)
        Console.WriteLine(hyu.color)
        Console.WriteLine(hyu.voltaje)
        Console.WriteLine(hyu.btu)
        Console.WriteLine(hyu.temperatura)

        hyu.subirTemperatura()

        Console.WriteLine(hyu.temperatura)

        hyu.subirTemperatura()
        hyu.subirTemperatura()

        Console.WriteLine(hyu.temperatura)

    End Sub

End Module
