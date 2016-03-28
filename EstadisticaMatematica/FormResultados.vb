Imports System.Math

Public Class FormResultados

    Private Sub FormResultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        resultados()

    End Sub

#Region "Funciones"

    Public valores(100) As Decimal '' array para valores de la muestra
    Public intervalos(100) As Decimal '' array para almacenar los intervalos
    Public frecuencia(100) As Double '' Para almacenar las frecuencias
    Public Lri(100) As Double ''para almacenar los limites reales inferiores
    Public Lrs(100) As Double '' Para almacenar los limites reales superiores
    Public Fx(100) As Integer 'para almacenar la frecuencia acumulada
    Public promedio(100) As Double ''para almacenar los promedios
    Public promedioCuadrado(100) As Double ''para almacenar x^2
    Public fxX(100) As Double 'frecuencia por X^2
    Public fxAcumulada(100) As Double '' frecuencia por x^2 Acumulada
    Dim i As Integer 'es el numero de valores ingresados
    Dim conteoFrecuencia As Integer
    Dim max, min As Double
    Dim minTemporal, maxTemporal As Double
    Public ValorIntervalo As Double
    Public numeroIntervalo As Integer
    Dim sumaValores As Double
    Dim mediaAritmetica As Double '' media aritmetica
    Dim Moda As Double ''moda
    Dim primerLimiteI As Double
    Dim primerFrecuencia, segundafrecuencia As Double
    Dim varianza As Double ''varianza
    Dim sumaFx, ultimafrecuencia As Double
    Dim cocienteVariacion As Double
    ''Variables para Quarteto
    Dim nDivido4 As Double
    Dim restas(100) As Double



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
        getFx()
        getLri()
        getLrs()
        getPromedio()
        xCuadrado()
        getFxX()
        getFxAcumulada()
        getValoresQuarteto()


        Formulas()

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
    ''Obtener FX
    Sub getFx()
        For index As Integer = 1 To numeroIntervalo / 2
            If index = 1 Then
                Fx(index) = frecuencia(index)
            Else
                Fx(index) = Fx(index - 1) + frecuencia(index)
            End If
            'MessageBox.Show(Fx(index))
        Next
    End Sub

    ''obtener limite real inferior
    Sub getLri()
        For index As Integer = 1 To numeroIntervalo
            If index Mod 2 <> 0 Then
                Lri(index) = intervalos(index) - 0.5
            End If
        Next
    End Sub

    ''obtener Limite real superiro

    Sub getLrs()
        For index As Integer = 1 To numeroIntervalo
            If index Mod 2 = 0 Then
                Lrs(index) = intervalos(index) + 0.5
            End If
        Next
    End Sub

    ''obtener el promedio
    Sub getPromedio()
        Dim index2 As Integer = 1
        For index As Integer = 1 To numeroIntervalo
            promedio(index2) = (intervalos(index) + intervalos(index + 1)) / 2
            index = index + 1
            index2 = index2 + 1
        Next
    End Sub

    '' obtener X^2
    Sub xCuadrado()
        For index As Integer = 1 To numeroIntervalo
            promedioCuadrado(index) = (promedio(index)) ^ 2
        Next
    End Sub
    ''frecuencia por promedio al cuadrado
    Sub getFxX()
        For index As Integer = 1 To numeroIntervalo
            fxX(index) = frecuencia(index) * promedioCuadrado(index)
        Next
    End Sub

    ''fxAcumulada
    Sub getFxAcumulada()
        For index As Integer = 1 To numeroIntervalo / 2
            If index = 1 Then
                fxAcumulada(index) = fxX(index)
            Else
                fxAcumulada(index) = fxAcumulada(index - 1) + fxX(index)
            End If
        Next
    End Sub
    '''obtengo los valores de los qurtetos
    Sub getValoresQuarteto()
        nDivido4 = (i / 4)

        For index As Integer = 1 To i
            restas(index) = Fx(index) - nDivido4
            MessageBox.Show(restas(index))
        Next

    End Sub


    Sub Formulas()

        MessageBox.Show(nDivido4)
        For index As Integer = 1 To i
            sumaValores = valores(index) + sumaValores
        Next

        mediaAritmetica = sumaValores / i


        For index As Integer = 1 To 1
            primerLimiteI = intervalos(index)
            primerFrecuencia = frecuencia(index)
            segundafrecuencia = frecuencia(index + 1)
        Next

        For index As Integer = 1 To numeroIntervalo / 2
            sumaFx = fxX(index)
            ultimafrecuencia = Fx(index)
        Next


        Moda = primerLimiteI + (((primerFrecuencia - 0) * ValorIntervalo) / ((primerFrecuencia - 0) + (primerFrecuencia - segundafrecuencia)))
        varianza = (sumaFx - (ultimafrecuencia * (mediaAritmetica ^ 2))) / (i - 1)
        cocienteVariacion = (mediaAritmetica / Sqrt(varianza)) * 100







    End Sub

    Sub generar()
        MayorMenor()
        GetIntervalos()
        Me.Show()
    End Sub
    Sub resultados()


        For index As Integer = 1 To numeroIntervalo ''LLeno los intervalos
            If index Mod 2 <> 0 Then
                ListIntervalos.Items.Add(intervalos(index) & "-" & intervalos(index + 1))
            End If
        Next

        For Index2 As Integer = 1 To numeroIntervalo / 2 ''LLeno la frecuencia
            ListFrecuencias.Items.Add(frecuencia(Index2))
        Next

        For index3 As Integer = 1 To numeroIntervalo / 2 ''Frecuencia Acumulada
            ListFx.Items.Add(Fx(index3))
        Next

        For index3 As Integer = 1 To numeroIntervalo
            If index3 Mod 2 <> 0 Then
                ListLri.Items.Add(Lri(index3))
            End If
        Next

        For index3 As Integer = 1 To numeroIntervalo
            If index3 Mod 2 = 0 Then
                ListLrs.Items.Add(Lrs(index3))
            End If
        Next

        For index3 As Integer = 1 To numeroIntervalo / 2
            ListPromedio.Items.Add(promedio(index3))
        Next

        For index3 As Integer = 1 To numeroIntervalo / 2
            listxCuadrado.Items.Add(promedioCuadrado(index3))
        Next

        For index3 As Integer = 1 To numeroIntervalo / 2
            listFxX.Items.Add(fxX(index3))
        Next

        For index3 As Integer = 1 To numeroIntervalo / 2 ''Frecuencia Acumulada
            ListFxAcumulada.Items.Add(fxAcumulada(index3))
        Next

        For index As Integer = 1 To 1
            tableFormulas.Rows.Add(mediaAritmetica, Moda, varianza, cocienteVariacion)
        Next


    End Sub
#End Region


End Class
