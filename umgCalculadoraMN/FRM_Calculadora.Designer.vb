<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Calculadora
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btn_Salir = New Button()
        Label1 = New Label()
        txt_x1 = New TextBox()
        txt_y1 = New TextBox()
        txt_z1 = New TextBox()
        txt_1 = New TextBox()
        txt_2 = New TextBox()
        txt_z2 = New TextBox()
        txt_y2 = New TextBox()
        txt_x2 = New TextBox()
        txt_3 = New TextBox()
        txt_z3 = New TextBox()
        txt_y3 = New TextBox()
        txt_x3 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btn_Ejecutar = New Button()
        btn_Limpiar = New Button()
        txt_log = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        txt_RX = New TextBox()
        txt_RY = New TextBox()
        txt_RZ = New TextBox()
        SuspendLayout()
        ' 
        ' btn_Salir
        ' 
        btn_Salir.BackColor = Color.Transparent
        btn_Salir.BackgroundImage = My.Resources.Resources.salir_alt
        btn_Salir.BackgroundImageLayout = ImageLayout.Stretch
        btn_Salir.Location = New Point(217, 422)
        btn_Salir.Name = "btn_Salir"
        btn_Salir.Size = New Size(80, 80)
        btn_Salir.TabIndex = 14
        btn_Salir.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(67, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(190, 15)
        Label1.TabIndex = 5
        Label1.Text = "Método de Eliminación Gaussiana"
        ' 
        ' txt_x1
        ' 
        txt_x1.Location = New Point(21, 59)
        txt_x1.Name = "txt_x1"
        txt_x1.Size = New Size(65, 23)
        txt_x1.TabIndex = 0
        ' 
        ' txt_y1
        ' 
        txt_y1.Location = New Point(92, 59)
        txt_y1.Name = "txt_y1"
        txt_y1.Size = New Size(65, 23)
        txt_y1.TabIndex = 1
        ' 
        ' txt_z1
        ' 
        txt_z1.Location = New Point(163, 59)
        txt_z1.Name = "txt_z1"
        txt_z1.Size = New Size(65, 23)
        txt_z1.TabIndex = 2
        ' 
        ' txt_1
        ' 
        txt_1.Location = New Point(234, 59)
        txt_1.Name = "txt_1"
        txt_1.Size = New Size(65, 23)
        txt_1.TabIndex = 3
        ' 
        ' txt_2
        ' 
        txt_2.Location = New Point(234, 88)
        txt_2.Name = "txt_2"
        txt_2.Size = New Size(65, 23)
        txt_2.TabIndex = 7
        ' 
        ' txt_z2
        ' 
        txt_z2.Location = New Point(163, 88)
        txt_z2.Name = "txt_z2"
        txt_z2.Size = New Size(65, 23)
        txt_z2.TabIndex = 6
        ' 
        ' txt_y2
        ' 
        txt_y2.Location = New Point(92, 88)
        txt_y2.Name = "txt_y2"
        txt_y2.Size = New Size(65, 23)
        txt_y2.TabIndex = 5
        ' 
        ' txt_x2
        ' 
        txt_x2.Location = New Point(21, 88)
        txt_x2.Name = "txt_x2"
        txt_x2.Size = New Size(65, 23)
        txt_x2.TabIndex = 4
        ' 
        ' txt_3
        ' 
        txt_3.Location = New Point(234, 117)
        txt_3.Name = "txt_3"
        txt_3.Size = New Size(65, 23)
        txt_3.TabIndex = 11
        ' 
        ' txt_z3
        ' 
        txt_z3.Location = New Point(163, 117)
        txt_z3.Name = "txt_z3"
        txt_z3.Size = New Size(65, 23)
        txt_z3.TabIndex = 10
        ' 
        ' txt_y3
        ' 
        txt_y3.Location = New Point(92, 117)
        txt_y3.Name = "txt_y3"
        txt_y3.Size = New Size(65, 23)
        txt_y3.TabIndex = 9
        ' 
        ' txt_x3
        ' 
        txt_x3.Location = New Point(21, 117)
        txt_x3.Name = "txt_x3"
        txt_x3.Size = New Size(65, 23)
        txt_x3.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(45, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(14, 15)
        Label2.TabIndex = 18
        Label2.Text = "X"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(113, 41)
        Label3.Name = "Label3"
        Label3.Size = New Size(14, 15)
        Label3.TabIndex = 19
        Label3.Text = "Y"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(185, 41)
        Label4.Name = "Label4"
        Label4.Size = New Size(14, 15)
        Label4.TabIndex = 20
        Label4.Text = "Z"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(257, 41)
        Label5.Name = "Label5"
        Label5.Size = New Size(15, 15)
        Label5.TabIndex = 21
        Label5.Text = "="
        ' 
        ' btn_Ejecutar
        ' 
        btn_Ejecutar.BackColor = Color.Transparent
        btn_Ejecutar.BackgroundImage = My.Resources.Resources.comprobacion_de_circulo_de_caja
        btn_Ejecutar.BackgroundImageLayout = ImageLayout.Stretch
        btn_Ejecutar.Location = New Point(131, 422)
        btn_Ejecutar.Name = "btn_Ejecutar"
        btn_Ejecutar.Size = New Size(80, 80)
        btn_Ejecutar.TabIndex = 12
        btn_Ejecutar.UseVisualStyleBackColor = False
        ' 
        ' btn_Limpiar
        ' 
        btn_Limpiar.BackColor = Color.Transparent
        btn_Limpiar.BackgroundImage = My.Resources.Resources.limpio
        btn_Limpiar.BackgroundImageLayout = ImageLayout.Stretch
        btn_Limpiar.Location = New Point(45, 422)
        btn_Limpiar.Name = "btn_Limpiar"
        btn_Limpiar.Size = New Size(80, 80)
        btn_Limpiar.TabIndex = 13
        btn_Limpiar.UseVisualStyleBackColor = False
        ' 
        ' txt_log
        ' 
        txt_log.Location = New Point(21, 161)
        txt_log.Multiline = True
        txt_log.Name = "txt_log"
        txt_log.ReadOnly = True
        txt_log.Size = New Size(277, 153)
        txt_log.TabIndex = 24
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(21, 143)
        Label6.Name = "Label6"
        Label6.Size = New Size(40, 15)
        Label6.TabIndex = 25
        Label6.Text = "Pasos:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(21, 24)
        Label7.Name = "Label7"
        Label7.Size = New Size(104, 15)
        Label7.TabIndex = 26
        Label7.Text = "Ingreso de Datos:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(21, 317)
        Label8.Name = "Label8"
        Label8.Size = New Size(57, 15)
        Label8.TabIndex = 27
        Label8.Text = "Solución:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.ForeColor = Color.White
        Label9.Location = New Point(21, 338)
        Label9.Name = "Label9"
        Label9.Size = New Size(40, 15)
        Label9.TabIndex = 28
        Label9.Text = "X      ="
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.ForeColor = Color.White
        Label10.Location = New Point(21, 367)
        Label10.Name = "Label10"
        Label10.Size = New Size(40, 15)
        Label10.TabIndex = 29
        Label10.Text = "Y      ="
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.ForeColor = Color.White
        Label11.Location = New Point(21, 396)
        Label11.Name = "Label11"
        Label11.Size = New Size(40, 15)
        Label11.TabIndex = 30
        Label11.Text = "Z      ="
        ' 
        ' txt_RX
        ' 
        txt_RX.Enabled = False
        txt_RX.Location = New Point(76, 335)
        txt_RX.Name = "txt_RX"
        txt_RX.Size = New Size(222, 23)
        txt_RX.TabIndex = 31
        ' 
        ' txt_RY
        ' 
        txt_RY.Enabled = False
        txt_RY.Location = New Point(76, 364)
        txt_RY.Name = "txt_RY"
        txt_RY.Size = New Size(222, 23)
        txt_RY.TabIndex = 32
        ' 
        ' txt_RZ
        ' 
        txt_RZ.Enabled = False
        txt_RZ.Location = New Point(76, 393)
        txt_RZ.Name = "txt_RZ"
        txt_RZ.Size = New Size(222, 23)
        txt_RZ.TabIndex = 33
        ' 
        ' FRM_Calculadora
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Surf
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(332, 514)
        Controls.Add(txt_RZ)
        Controls.Add(txt_RY)
        Controls.Add(txt_RX)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(txt_log)
        Controls.Add(btn_Limpiar)
        Controls.Add(btn_Ejecutar)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txt_3)
        Controls.Add(txt_z3)
        Controls.Add(txt_y3)
        Controls.Add(txt_x3)
        Controls.Add(txt_2)
        Controls.Add(txt_z2)
        Controls.Add(txt_y2)
        Controls.Add(txt_x2)
        Controls.Add(txt_1)
        Controls.Add(txt_z1)
        Controls.Add(txt_y1)
        Controls.Add(txt_x1)
        Controls.Add(Label1)
        Controls.Add(btn_Salir)
        Name = "FRM_Calculadora"
        Text = "Ecuaciones Lineales"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_Salir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_x1 As TextBox
    Friend WithEvents txt_y1 As TextBox
    Friend WithEvents txt_z1 As TextBox
    Friend WithEvents txt_1 As TextBox
    Friend WithEvents txt_2 As TextBox
    Friend WithEvents txt_z2 As TextBox
    Friend WithEvents txt_y2 As TextBox
    Friend WithEvents txt_x2 As TextBox
    Friend WithEvents txt_3 As TextBox
    Friend WithEvents txt_z3 As TextBox
    Friend WithEvents txt_y3 As TextBox
    Friend WithEvents txt_x3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_Ejecutar As Button
    Friend WithEvents btn_Limpiar As Button
    Friend WithEvents txt_log As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_RX As TextBox
    Friend WithEvents txt_RY As TextBox
    Friend WithEvents txt_RZ As TextBox
End Class
