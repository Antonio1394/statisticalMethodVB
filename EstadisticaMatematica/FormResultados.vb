Imports System.Math

Public Class FormResultados

    Private Sub FormResultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        resultados()

    End Sub

#Region "Funciones"

    Public valores(100) As Decimal
    Public intervalos(100) As Decimal
    Public frecuencia(100) As Integer
    Dim i As Integer 'es el numero de valores ingresados
    Dim conteoFrecuencia As Integer
    Dim max, min As Double
    Dim minTemporal, maxTemporal As Double
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

    Sub GetIntervalos()
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
                    ' MessageBox.Show("entro aca")
                    Exit For
                End If
            End If
            numeroIntervalo = numeroIntervalo + 1
            'MessageBox.Show("intervalo: " & intervalos(index))
            ' MessageBox.Show(numeroIntervalo)
        Next ''Fin de intervalor

        GetFrecuencia()


    End Sub
    'Para calcular las frecuencias'
    Sub GetFrecuencia()
        For index As Integer = 1 To numeroIntervalo
            Dim index3 As Integer
            index3 += 1

            conteoFrecuencia = 0
            For index2 As Integer = 1 To i
                If valores(index2) >= intervalos(index) And valores(index2) <= intervalos(index + 1) Then
                    conteoFrecuencia += 1
                End If
            Next
            index = index + 1
            frecuencia(index3) = conteoFrecuencia
        Next



    End Sub
    Sub generar()
        MayorMenor()
        GetIntervalos()
        Me.Show()
    End Sub
    Sub resultados()
        MessageBox.Show("yaa")
        ''MessageBox.Show(numeroIntervalo)
        For index As Integer = 1 To numeroIntervalo
            If index Mod 2 <> 0 Then
                ListIntervalos.Items.Add(intervalos(index) & "-" & intervalos(index + 1))
            End If
        Next

        For Index2 As Integer = 1 To numeroIntervalo / 2
            ListFrecuencias.Items.Add(frecuencia(Index2))
        Next
       
    End Sub
#End Region


  
End Class
