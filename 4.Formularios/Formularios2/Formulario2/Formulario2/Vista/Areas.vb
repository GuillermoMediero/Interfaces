Imports Formulario2.ControladorRectangulo

Public Class Areas
    Dim Controlador As New ControladorRectangulo
    Private Sub bCalcularArea_Click(sender As Object, e As EventArgs) Handles bCalcularArea.Click
        tbResultadoArea.Text = Controlador.calcularArea(nudNumArea1.Value, nudNumArea2.Value)
    End Sub
End Class