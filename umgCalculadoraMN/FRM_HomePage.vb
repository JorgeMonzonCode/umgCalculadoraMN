Public Class FRM_HomePage
    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_Calculadora_Click(sender As Object, e As EventArgs) Handles btn_Calculadora.Click
        Try
            Me.Hide()
            FRM_Calculadora.Show()
        Catch ex As Exception
            MsgBox("Ocurrio un error inesperado intente mas tarde.")
        End Try
    End Sub

    Private Sub btn_Documentacion_Click(sender As Object, e As EventArgs) Handles btn_Documentacion.Click
        Try
            FRM_Instrucciones.Show()
        Catch ex As Exception
            MsgBox("Ocurrio un error inesperado intente mas tarde.")
        End Try
    End Sub
End Class