Module Module1

    Sub Main()

        Dim cadena1 As String = "Estamos en el mejor curso de Visual Basic. Net"

        Dim cadena2 As String = "Estamos en el mejor Curso de Visual basic. Net"

        Dim cadena3 As String = "Estamos en el mejor Curso"

        Console.WriteLine(cadena1.ToUpper())
        Console.WriteLine(cadena1.ToLower())
        Console.WriteLine(cadena1.Substring(0, cadena3.Length()))
        Console.WriteLine(cadena3.Length())
        Console.WriteLine(cadena1.Equals(cadena2))

    End Sub

End Module
