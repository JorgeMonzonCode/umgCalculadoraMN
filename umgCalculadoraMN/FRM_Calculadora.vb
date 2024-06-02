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
            Write_log("")
            'Colocando 0 en los recuadros vacios
            PL_colocar_ceros()

            'Validar campos numericos
            If Not PL_validad_campos_numericos() Then
                Exit Sub
            End If

            'Parsear los datos a double 
            Dim _x1 As Double = FormatNumber(CDec(txt_x1.Text), 4)
            Dim _x2 As Double = FormatNumber(CDec(txt_x2.Text), 4)
            Dim _x3 As Double = FormatNumber(CDec(txt_x3.Text), 4)

            Dim _y1 As Double = FormatNumber(CDec(txt_y1.Text), 4)
            Dim _y2 As Double = FormatNumber(CDec(txt_y2.Text), 4)
            Dim _y3 As Double = FormatNumber(CDec(txt_y3.Text), 4)

            Dim _z1 As Double = FormatNumber(CDec(txt_z1.Text), 4)
            Dim _z2 As Double = FormatNumber(CDec(txt_z2.Text), 4)
            Dim _z3 As Double = FormatNumber(CDec(txt_z3.Text), 4)

            Dim _n1 As Double = FormatNumber(CDec(txt_1.Text), 4)
            Dim _n2 As Double = FormatNumber(CDec(txt_2.Text), 4)
            Dim _n3 As Double = FormatNumber(CDec(txt_3.Text), 4)

            'Imprimir sistema de ecuaciones
            Write_log("Generando sistema de ecuaciones:")
            PL_Imprimir_Matriz(IIf(_x1 >= 0, "+" + _x1.ToString() + "X ", _x1.ToString() + "X "), IIf(_x2 >= 0, "+" + _x2.ToString() + "X ", _x2.ToString() + "X "), IIf(_x3 >= 0, "+" + _x3.ToString() + "X ", _x3.ToString() + "X "),
                               IIf(_y1 >= 0, "+" + _y1.ToString() + "Y ", _y1.ToString() + "Y "), IIf(_y2 >= 0, "+" + _y2.ToString() + "Y ", _y2.ToString() + "Y "), IIf(_y3 >= 0, "+" + _y3.ToString() + "Y ", _y3.ToString() + "Y "),
                               IIf(_z1 >= 0, "+" + _z1.ToString() + "Z ", _z1.ToString() + "Z "), IIf(_z2 >= 0, "+" + _z2.ToString() + "Z ", _z2.ToString() + "Z "), IIf(_z3 >= 0, "+" + _z3.ToString() + "Z ", _z3.ToString() + "Z "),
                               IIf(_n1 >= 0, "= +" + _n1.ToString(), "= " + _n1.ToString()), IIf(_n2 >= 0, "= +" + _n2.ToString(), "= " + _n2.ToString()), IIf(_n3 >= 0, "= +" + _n3.ToString(), "= " + _n3.ToString()),
                                "")

            'Imprimir Matriz Aumentada
            Write_log("Generando matriz aumentada:")
            PL_Imprimir_Matriz(_x1, _x2, _x3, _y1, _y2, _y3, _z1, _z2, _z3, _n1, _n2, _n3, "|")

            'Resolver Sistema de ecuaciones por metodo de eliminacion gaussiana
            Write_log("Resolviendo sistema de ecuaciones por metodo de eliminación Gaussiana")

            Dim vSigno As Double = _x1 * _x2
            Write_log("")
            Write_log("Cero en la columna 1 fila 2")
            Write_log("F2 = F2 " + IIf(vSigno >= 0, "-", "+") + Replace(_x2.ToString, "-", "") + "/" + Replace(_x1.ToString, "-", "") + " F1")
            Write_log("")

            Dim factor As Double = Math.Abs(_x2 / _x1)
            If (_x1 = 0) Then
                Write_log("Error denominador es Cero")
                MsgBox("Error denominador es Cero")
                Exit Try
            End If

            _x2 = FormatNumber(_x2 + IIf(vSigno >= 0, -factor * _x1, +factor * _x1), 4)
            _y2 = FormatNumber(_y2 + IIf(vSigno >= 0, -factor * _y1, +factor * _y1), 4)
            _z2 = FormatNumber(_z2 + IIf(vSigno >= 0, -factor * _z1, +factor * _z1), 4)
            _n2 = FormatNumber(_n2 + IIf(vSigno >= 0, -factor * _n1, +factor * _n1), 4)

            PL_Imprimir_Matriz(_x1, _x2, _x3, _y1, _y2, _y3, _z1, _z2, _z3, _n1, _n2, _n3, "|")

            vSigno = _x1 * _x3

            Write_log("Cero en la columna 1 fila 3")
            Write_log("F3 = F3 " + IIf(vSigno >= 0, "-", "+") + Replace(_x3.ToString, "-", "") + "/" + Replace(_x1.ToString, "-", "") + " F1")
            Write_log("")

            factor = Math.Abs(_x3 / _x1)
            If (_x1 = 0) Then
                Write_log("Error denominador es Cero")
                MsgBox("Error denominador es Cero")
                Exit Try
            End If

            _x3 = FormatNumber(_x3 + IIf(vSigno >= 0, -factor * _x1, +factor * _x1), 4)
            _y3 = FormatNumber(_y3 + IIf(vSigno >= 0, -factor * _y1, +factor * _y1), 4)
            _z3 = FormatNumber(_z3 + IIf(vSigno >= 0, -factor * _z1, +factor * _z1), 4)
            _n3 = FormatNumber(_n3 + IIf(vSigno >= 0, -factor * _n1, +factor * _n1), 4)

            PL_Imprimir_Matriz(_x1, _x2, _x3, _y1, _y2, _y3, _z1, _z2, _z3, _n1, _n2, _n3, "|")

            vSigno = _y2 * _y3

            Write_log("Cero en la columna 2 fila 3")
            Write_log("F3 = F3 " + IIf(vSigno >= 0, "-", "+") + Replace(_y3.ToString, "-", "") + "/" + Replace(_y2.ToString, "-", "") + " F2")
            Write_log("")

            factor = Math.Abs(_y3 / _y2)
            If (_y2 = 0) Then
                Write_log("Error denominador es Cero")
                MsgBox("Error denominador es Cero")
                Exit Try
            End If

            _x3 = FormatNumber(_x3 + IIf(vSigno >= 0, -factor * _x2, +factor * _x2), 4)
            _y3 = FormatNumber(_y3 + IIf(vSigno >= 0, -factor * _y2, +factor * _y2), 4)
            _z3 = FormatNumber(_z3 + IIf(vSigno >= 0, -factor * _z2, +factor * _z2), 4)
            _n3 = FormatNumber(_n3 + IIf(vSigno >= 0, -factor * _n2, +factor * _n2), 4)

            Write_log("Mostrando matriz escalonada:")
            PL_Imprimir_Matriz(_x1, _x2, _x3, _y1, _y2, _y3, _z1, _z2, _z3, _n1, _n2, _n3, "|")
            Write_log("")

            'Valido las soluciones
            If _z3 = 0 And _n3 = 0 Then
                Write_log("El sistema de ecuaciones tiene infinitas soluciones...")
                MsgBox("El sistema de ecuaciones tiene infinitas soluciones")
                Write_log("")
                Exit Try
            End If

            If _z3 = 0 And _n3 <> 0 Then
                Write_log("El sistema de ecuaciones no tiene solucion...")
                MsgBox("El sistema de ecuaciones no tiene solucion")
                Write_log("")
                Exit Try
            End If

            'Presento las soluciones de la ecuacion
            Write_log("Presentando las soluciones:.........")
            Write_log("")

            txt_RZ.Text = FormatNumber(_n3 / _z3, 4).ToString
            Write_log("Determino el valor de Z: " + txt_RZ.Text)
            If (_z3 = 0) Then
                Write_log("Error denominador es Cero")
                MsgBox("Error denominador es Cero")
                Exit Try
            End If
            txt_RY.Text = FormatNumber(((_n2 - _z2 * (_n3 / _z3)) / _y2), 4).ToString
            Write_log("Determino el valor de Y: " + txt_RY.Text)
            If (_y2 = 0) Then
                Write_log("Error denominador es Cero")
                MsgBox("Error denominador es Cero")
                Exit Try
            End If
            txt_RX.Text = FormatNumber(((_n1 - _y1 * ((_n2 - _z2 * (_n3 / _z3)) / _y2) - _z1 * (_n3 / _z3)) / _x1), 4).ToString
            Write_log("Determino el valor de X: " + txt_RX.Text)
            If (_x1 = 0) Then
                Write_log("Error denominador es Cero")
                MsgBox("Error denominador es Cero")
                Exit Try
            End If
        Catch ex As Exception
            Write_log("Se detuvo la ejecucion de forma inesperada........ " + ex.Message)
            MsgBox("Ocurrio un error inesperado intente mas tarde." + ex.Message)
        End Try
        Write_log("")
        Write_log("Fin de la ejecucion........")
    End Sub
    Private Sub PL_Imprimir_Matriz(ByVal x1 As String, ByVal x2 As String, ByVal x3 As String,
                                   ByVal y1 As String, ByVal y2 As String, ByVal y3 As String,
                                   ByVal z1 As String, ByVal z2 As String, ByVal z3 As String,
                                   ByVal n1 As String, ByVal n2 As String, ByVal n3 As String,
                                   ByVal separador As String)
        Try
            Write_log("")
            Write_log(separador + " " + x1.ToString + " " + separador + " " + y1.ToString + " " + separador + " " + z1.ToString + " " + separador + separador + " " + n1.ToString + " " + separador)
            Write_log(separador + " " + x2.ToString + " " + separador + " " + y2.ToString + " " + separador + " " + z2.ToString + " " + separador + separador + " " + n2.ToString + " " + separador)
            Write_log(separador + " " + x3.ToString + " " + separador + " " + y3.ToString + " " + separador + " " + z3.ToString + " " + separador + separador + " " + n3.ToString + " " + separador)
            Write_log("")
        Catch ex As Exception
            Write_log("Se detuvo la ejecucion de forma inesperada........ " + ex.Message)
            MsgBox("Ocurrio un error inesperado intente mas tarde." + ex.Message)
        End Try
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