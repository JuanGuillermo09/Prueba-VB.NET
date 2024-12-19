Module Module1

    'Crear un procedimiento sub que permita mostrar un saludo a una persona, el nombre de la persona debe ser'
    'pasado por parametro ' 

    Sub Main()

        Console.WriteLine("Mensaje del procedimiento main")

        saludo("Maria")
        saludo("Pedro")

    End Sub


    Sub saludo(nom As String)

        Console.WriteLine("Hola " & nom & " bienvenido(a) al mejor curso de Visual Basic. NET")

    End Sub

End Module
