Imports System.Math

Public Class Logica
    Public valores(100) As Decimal
    Public intervalos(100) As Decimal
    Dim i, max, min As Integer
    Dim minTemporal, maxTemporal As Integer
    Public ValorIntervalo As Double
    Public numeroIntervalo As Integer

    ''Guarda Valores en el array
    Sub GuardarValores(valor)
        i = i + 1
        valores(i) = valor

    End Sub

    ''Funcion Para obtener Numero mayor y numero Menor
    Sub MayorMenor()
        minTemporal = 999999

        For index As Integer = 1 To i
            If (valores(index) > maxTemporal) Then
                maxTemporal = valores(index)
            End If
        Next
        max = maxTemporal

        For index As Integer = 1 To i
            If (valores(index) < minTemporal) Then
                minTemporal = valores(index)
            End If
        Next
        min = minTemporal

    End Sub

    Sub operaciones()
        ''Intervalo
        ValorIntervalo = Ceiling((max - min) / (4.2323 + (Log(i, 10))))

        ''Inicio de intervalos
        For index As Integer = 1 To 100

            If index = 1 Then ''cuando es el primer intervalo, se coloca el numero menor
                intervalos(index) = min
            ElseIf (index Mod 2 = 0) Then '' cuando el index del array es par

                intervalos(index) = (intervalos(index - 1) + ValorIntervalo) - 1
            Else '' cuando es impar
                If intervalos(index - 1) < max Then
                    intervalos(index) = intervalos(index - 1) + 1
                Else
                    MessageBox.Show("entro aca")
                    Exit For
                End If
            End If
            numeroIntervalo = numeroIntervalo + 1
            'MessageBox.Show("intervalo: " & intervalos(index))
            ' MessageBox.Show(numeroIntervalo)
        Next
        MessageBox.Show("numero de intervalos " & numeroIntervalo)
    End Sub
    Sub generar()
        MayorMenor()
        operaciones()
    End Sub
End Class
