Imports System.IO
Imports AxAcroPDFLib

Public Class FRM_Instrucciones
    Private Sub FRM_Instrucciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'guardo el archivo en alguna carpeta temporal
            Dim rutaTemporal As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "PDFtemporal.pdf")
            System.IO.File.WriteAllBytes(rutaTemporal, My.Resources.Instrucciones)
            'abro el archivo en el formulario
            PDF_Instrucciones.src = rutaTemporal
        Catch ex As Exception
            MsgBox("Ocurrio un Error inesperado al abrir el documento...")
        End Try
    End Sub
End Class