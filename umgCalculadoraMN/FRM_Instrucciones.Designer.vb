<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Instrucciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Instrucciones))
        PDF_Instrucciones = New AxAcroPDFLib.AxAcroPDF()
        CType(PDF_Instrucciones, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PDF_Instrucciones
        ' 
        PDF_Instrucciones.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PDF_Instrucciones.Enabled = True
        PDF_Instrucciones.Location = New Point(0, 1)
        PDF_Instrucciones.Name = "PDF_Instrucciones"
        PDF_Instrucciones.OcxState = CType(resources.GetObject("PDF_Instrucciones.OcxState"), AxHost.State)
        PDF_Instrucciones.Size = New Size(799, 447)
        PDF_Instrucciones.TabIndex = 0
        ' 
        ' FRM_Instrucciones
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PDF_Instrucciones)
        Name = "FRM_Instrucciones"
        Text = "FRM_Instrucciones"
        CType(PDF_Instrucciones, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PDF_Instrucciones As AxAcroPDFLib.AxAcroPDF
End Class
