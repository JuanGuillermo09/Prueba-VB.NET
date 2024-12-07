Module Module1

    ' Variable global.

    Dim numero As Integer = 12

    Sub Main()

        ' Menjase por CMD.

        Console.WriteLine("Hola mundo")

        Console.ReadKey(True)

        ' Variables.

        Dim numeros As Integer = 12

        Dim pulgada As Double = 2.54

        Dim letra As Char = "a"

        Dim cadena As String = "Esto es una cadena"

        Dim condicion As Boolean = True ' O False.

        ' Esto No se puede Porque reconoce que es la misma Variable.

        'Dim numero As Integer = 12.    'Dim Numero As Integer = 12.


        ' Ambito de las variables.

        Dim numero As Integer = 12

        numero = 24


        ' Constante.

        Const PULGADA As Double = 2.54





    End Sub

    Sub otroMetodo()

        numero = 80
    End Sub


End Module
