Public Class FRM_Calculadora
    ''' <summary>
    ''' Metodo para visualizar la calculadora
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Try
            FRM_HomePage.Show()
            Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error inesperado intente mas tarde.")
        End Try
    End Sub
    ''' <summary>
    ''' Metodo para limpiar los controles de la calculadora
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        Try
            'limpiar controles de ingreso de datos
            txt_x1.Text = ""
            txt_x2.Text = ""
            txt_x3.Text = ""
            txt_y1.Text = ""
            txt_y2.Text = ""
            txt_y3.Text = ""
            txt_z1.Text = ""
            txt_z2.Text = ""
            txt_z3.Text = ""
            txt_1.Text = ""
            txt_2.Text = ""
            txt_3.Text = ""

            'limpiar controles de log
            txt_log.Text = ""

            'limpiar controles de respuesta
            txt_RX.Text = ""
            txt_RY.Text = ""
            txt_RZ.Text = ""

        Catch ex As Exception
            MsgBox("Ocurrio un error inesperado intente mas tarde.")
        End Try
    End Sub
    ''' <summary>
    ''' realizar calculo de las soluciones de las ecuaciones lineales
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_Ejecutar_Click(sender As Object, e As EventArgs) Handles btn_Ejecutar.Click
        Try
            Write_log("Iniciando la ejecucion........")
            'Colocando 0 en los recuadros vacios
            PL_colocar_ceros()

            'Validar campos numericos
            If Not PL_validad_campos_numericos() Then
                Exit Sub
            End If


        Catch ex As Exception
            Write_log("Se detuvo la ejecucion de forma inesperada........ " + ex.Message)
            MsgBox("Ocurrio un error inesperado intente mas tarde." + ex.Message)
        End Try
        Write_log("Fin de la ejecucion........")
    End Sub
    ''' <summary>
    ''' coloca en cero el valor de la casilla si se dejo vacia
    ''' </summary>
    Private Sub PL_colocar_ceros()
        Try
            'colocando ceros a los valores de X
            Write_log("Seteando Ceros en casillas vacias de X")
            If txt_x1.Text = "" Then
                txt_x1.Text = "0"
            End If
            If txt_x2.Text = "" Then
                txt_x2.Text = "0"
            End If
            If txt_x3.Text = "" Then
                txt_x3.Text = "0"
            End If

            'colocando ceros a los valores de Y
            Write_log("Seteando Ceros en casillas vacias de Y")
            If txt_y1.Text = "" Then
                txt_y1.Text = "0"
            End If
            If txt_y2.Text = "" Then
                txt_y2.Text = "0"
            End If
            If txt_y3.Text = "" Then
                txt_y3.Text = "0"
            End If

            'colocando ceros a los valores de Z
            Write_log("Seteando Ceros en casillas vacias de Z")
            If txt_z1.Text = "" Then
                txt_z1.Text = "0"
            End If
            If txt_z2.Text = "" Then
                txt_z2.Text = "0"
            End If
            If txt_z3.Text = "" Then
                txt_z3.Text = "0"
            End If

            'colocando ceros a los valores de las soluciones
            Write_log("Seteando Ceros en casillas vacias de las igualdades")
            If txt_1.Text = "" Then
                txt_1.Text = "0"
            End If
            If txt_2.Text = "" Then
                txt_2.Text = "0"
            End If
            If txt_3.Text = "" Then
                txt_3.Text = "0"
            End If
            Write_log("Seteando Ceros con Exito....")
        Catch ex As Exception
            Write_log("Seteando Ceros con Error... " + ex.Message)
            MsgBox("Ocurrio un error inesperado intente mas tarde. " + ex.Message)
        End Try
        Write_log("")
    End Sub
    ''' <summary>
    ''' escribe log de sucesos en la ejecucion
    ''' </summary>
    ''' <param name="linea"></param>
    Private Sub Write_log(ByVal linea As String)
        Try
            txt_log.Text += linea + Environment.NewLine
        Catch ex As Exception
            txt_log.Text += "*** Ocurrio un Error inesperado no se logro escribir el log " * ex.Message + "/n"
        End Try
    End Sub
    Private Function PL_validad_campos_numericos() As Boolean
        Try
            Write_log("Validar si los valores ingresados son numericos....")
            'validando si los valores de X son numericos
            If IsNumeric(txt_x1.Text) And IsNumeric(txt_x2.Text) And IsNumeric(txt_x3.Text) Then
                Write_log("Valores de X correctos...")
            Else
                Write_log("Revise los valores de X ya que no son numericos")
                MsgBox("Revise los valores de X ya que no son numericos")
                Return False
            End If

            'validando si los valores de Y son numericos
            If IsNumeric(txt_y1.Text) And IsNumeric(txt_y2.Text) And IsNumeric(txt_y3.Text) Then
                Write_log("Valores de Y correctos...")
            Else
                Write_log("Revise los valores de Y ya que no son numericos")
                MsgBox("Revise los valores de Y ya que no son numericos")
                Return False
            End If

            'validando si los valores de Z son numericos
            If IsNumeric(txt_z1.Text) And IsNumeric(txt_z2.Text) And IsNumeric(txt_z3.Text) Then
                Write_log("Valores de Z correctos...")
            Else
                Write_log("Revise los valores de Z ya que no son numericos")
                MsgBox("Revise los valores de Z ya que no son numericos")
                Return False
            End If

            'validando si los valores de las igualdades son numericos
            If IsNumeric(txt_1.Text) And IsNumeric(txt_2.Text) And IsNumeric(txt_3.Text) Then
                Write_log("Valores de las igualdades son correctos...")
            Else
                Write_log("Revise los valores de las igualdades ya que no son numericos")
                MsgBox("Revise los valores de las igualdades ya que no son numericos")
                Return False
            End If
        Catch ex As Exception
            Write_log("*** Ocurrio un Error inesperado no se lograron validar todos los campos. " + ex.Message)
            Return False
        End Try
        Write_log("Valores de los campos son numericos....")
        Write_log("")
        Return True
    End Function

End Class