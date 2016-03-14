Public Class FormResultados
    Dim fn As New Logica
    Dim numeroIntervalo As Integer




    Private Sub FormResultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        resultados()

    End Sub

#Region "Funciones"
    Sub resultados()
        MessageBox.Show("yaa")
        numeroIntervalo = fn.numeroIntervalo
        For index As Integer = 0 To numeroIntervalo
            TableResultados.Rows.Add(New Integer(), fn.intervalos(index))
        Next

    End Sub
#End Region


End Class
