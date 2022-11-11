Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnCalcular.Click
        tbResultado.Text = nudAltura.Value * nudBase.Value

    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles nudAltura.ValueChanged

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles nudBase.ValueChanged

    End Sub

    Private Sub btnCalcular_MouseEnter(sender As Object, e As EventArgs) Handles btnCalcular.MouseEnter
        'tlpCalculadora.Controls.Remove(btnCalcular)
        'tlpCalculadora.Controls.Add(btnCalcular, 1, 2)
    End Sub
End Class
