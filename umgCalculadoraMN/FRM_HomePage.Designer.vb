<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_HomePage
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
        PictureBox1 = New PictureBox()
        btn_Documentacion = New Button()
        btn_Calculadora = New Button()
        btn_Salir = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.Umglogo
        PictureBox1.Location = New Point(71, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(190, 190)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btn_Documentacion
        ' 
        btn_Documentacion.BackColor = Color.Transparent
        btn_Documentacion.BackgroundImage = My.Resources.Resources.descarga_de_archivos
        btn_Documentacion.BackgroundImageLayout = ImageLayout.Stretch
        btn_Documentacion.Location = New Point(38, 422)
        btn_Documentacion.Name = "btn_Documentacion"
        btn_Documentacion.Size = New Size(80, 80)
        btn_Documentacion.TabIndex = 1
        btn_Documentacion.UseVisualStyleBackColor = False
        ' 
        ' btn_Calculadora
        ' 
        btn_Calculadora.BackColor = Color.Transparent
        btn_Calculadora.BackgroundImage = My.Resources.Resources.calculadora
        btn_Calculadora.BackgroundImageLayout = ImageLayout.Stretch
        btn_Calculadora.Location = New Point(124, 422)
        btn_Calculadora.Name = "btn_Calculadora"
        btn_Calculadora.Size = New Size(80, 80)
        btn_Calculadora.TabIndex = 2
        btn_Calculadora.UseVisualStyleBackColor = False
        ' 
        ' btn_Salir
        ' 
        btn_Salir.BackColor = Color.Transparent
        btn_Salir.BackgroundImage = My.Resources.Resources.salir_alt
        btn_Salir.BackgroundImageLayout = ImageLayout.Stretch
        btn_Salir.Location = New Point(210, 422)
        btn_Salir.Name = "btn_Salir"
        btn_Salir.Size = New Size(80, 80)
        btn_Salir.TabIndex = 3
        btn_Salir.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 217)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 15)
        Label1.TabIndex = 4
        Label1.Text = "Universidad Mariano Galvez"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(12, 232)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 15)
        Label2.TabIndex = 5
        Label2.Text = "Métodos Numéricos"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(12, 247)
        Label3.Name = "Label3"
        Label3.Size = New Size(215, 15)
        Label3.TabIndex = 6
        Label3.Text = "Seccion 2 Horario 11:00 am - 1:00 pm"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(12, 262)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 15)
        Label4.TabIndex = 7
        Label4.Text = "Ciclo 2024"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(145, 379)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 15)
        Label5.TabIndex = 11
        Label5.Text = "5990-20-11568"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(145, 364)
        Label6.Name = "Label6"
        Label6.Size = New Size(175, 15)
        Label6.TabIndex = 10
        Label6.Text = "Jorge Mario Monzón González"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(61, 316)
        Label7.Name = "Label7"
        Label7.Size = New Size(200, 15)
        Label7.TabIndex = 9
        Label7.Text = "(Resolucion de ecuaciones lineales)"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(88, 301)
        Label8.Name = "Label8"
        Label8.Size = New Size(139, 15)
        Label8.TabIndex = 8
        Label8.Text = "Proyecto Final del Curso"
        ' 
        ' FRM_HomePage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Surf
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(332, 514)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_Salir)
        Controls.Add(btn_Calculadora)
        Controls.Add(btn_Documentacion)
        Controls.Add(PictureBox1)
        Name = "FRM_HomePage"
        Text = "HomePage"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_Documentacion As Button
    Friend WithEvents btn_Calculadora As Button
    Friend WithEvents btn_Salir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
