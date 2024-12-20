Public Class AireAcondicionado

    Public marca As String
    Public modelo As String
    Public color As String
    Public voltaje As Integer
    Public btu As Integer
    Public temperatura As Integer

    Public Sub subirTemperatura()

        temperatura += 1

    End Sub

    Public Sub bajasTemperatura()

        temperatura -= 1

    End Sub

    Public Function darTemperatura() As Integer

        Return temperatura

    End Function

End Class
