Imports System.IO

Public Class Form1
    Private Sub changeResult(newResult As Double)
        tbResultado.Text = newResult
    End Sub

    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        changeResult(nudNum1.Value + nudNum2.Value)
    End Sub

    Private Sub btnRestar_Click(sender As Object, e As EventArgs) Handles btnRestar.Click
        changeResult(nudNum1.Value - nudNum2.Value)
    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        changeResult(nudNum1.Value * nudNum2.Value)
    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        changeResult(nudNum1.Value / nudNum2.Value)
    End Sub

    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        changeResult(nudNum1.Value ^ nudNum2.Value)
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbResultado.Text = ""
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim pixels As Integer = 42.5 * (Me.Size.Width / 100)
        Const minHeight = 246
        Dim height = Me.Size.Height
        Dim TextBox As Integer = minHeight / (height * 14)
        Dim Label As Integer = minHeight / (height * 10)
        Dim Nud As Integer = minHeight / (height * 15.75)
        Dim Botones As Integer = minHeight / (height * 18)

        tbResultado.Font = New Font("Microsoft Sans Serif", TextBox, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbPrimerOperador.Font = New Font("Microsoft Sans Serif", Label, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbSegundoOperador.Font = New Font("Microsoft Sans Serif", Label, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbResultado.Font = New Font("Microsoft Sans Serif", Label, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        nudNum1.Font = New Font("Microsoft Sans Serif", Nud, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        nudNum2.Font = New Font("Microsoft Sans Serif", Nud, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnClear.Font = New Font("Microsoft Sans Serif", Botones, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnDividir.Font = New Font("Microsoft Sans Serif", Botones, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnMultiplicar.Font = New Font("Microsoft Sans Serif", Botones, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnPower.Font = New Font("Microsoft Sans Serif", Botones, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnRestar.Font = New Font("Microsoft Sans Serif", Botones, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnSumar.Font = New Font("Microsoft Sans Serif", Botones, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        resizeWidth(pixels)
    End Sub

    Private Sub resizeFonts(font As Double)

    End Sub
    Private Sub resizeWidth(pixels As Integer)
        tbResultado.Width = pixels
        nudNum1.Width = pixels
        nudNum2.Width = pixels
    End Sub

End Class
