Public Class RadForm1
    Dim fn As New Logica

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        If txtValor.Text.Length = 0 Then
            MessageBox.Show("Valor Vacio")
        Else

            fn.GuardarValores(txtValor.Text)
            MessageBox.Show("Dato Almacenado Exitosamente")
            txtValor.Clear()
            txtValor.Focus()
        End If
    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
        fn.generar()
    End Sub
End Class
