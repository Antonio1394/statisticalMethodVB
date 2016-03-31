Public Class RadForm1
    Dim fn As New FormResultados

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        If txtValor.Text.Length = 0 Then
            MessageBox.Show("Valor Vacio")
        Else

            fn.GuardarValores(txtValor.Text)
            MessageBox.Show("Dato Almacenado Exitosamente")
            Lista.Items.Add(txtValor.Text)
            txtValor.Clear()
            txtValor.Focus()

        End If
    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
        fn.generar()
        Lista.Items.Clear()
    End Sub

    Private Sub RadForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
