Public Class AireAcondicionado

    Private marca As String
    Private modelo As String
    Private color As String
    Private voltaje As Integer
    Private btu As Integer
    Private temperatura As Integer

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
