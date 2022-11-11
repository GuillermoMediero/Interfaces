Public Class Calculadora
    Dim areaCuadarado As New Areas
    Dim volumenCubo As New Volumenes


    Private Sub CuadradoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuadradoToolStripMenuItem.Click
        Me.pFomularios.Controls.Clear()
        areaCuadarado.TopLevel = False
        Me.pFomularios.Controls.Add(areaCuadarado)
        areaCuadarado.Show()
        areaCuadarado.Dock = DockStyle.Fill
    End Sub

    Private Sub CuboToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuboToolStripMenuItem.Click
        Me.pFomularios.Controls.Clear()
        volumenCubo.TopLevel = False
        Me.pFomularios.Controls.Add(volumenCubo)
        volumenCubo.Show()
        volumenCubo.Dock = DockStyle.Fill
    End Sub
End Class
