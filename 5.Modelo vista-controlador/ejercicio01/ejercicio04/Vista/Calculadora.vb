Public Class Calculadora
    Dim miControlador As New ControladorCalculadora

    Private Sub bElevar_Click(sender As Object, e As EventArgs) Handles bElevar.Click
        tbResultado.Text = miControlador.Operar(nudNum1.Value, nudNum2.Value, ControladorCalculadora.Operaciones.Elevar)
    End Sub

    Private Sub bLimpiar_Click(sender As Object, e As EventArgs) Handles bLimpiar.Click
        nudNum1.Value = 0.00
        nudNum2.Value = 0.00
        tbResultado.Text = ""
    End Sub

    Private Sub bSumar_Click(sender As Object, e As EventArgs) Handles bSumar.Click
        tbResultado.Text = miControlador.Operar(nudNum1.Value, nudNum2.Value, ControladorCalculadora.Operaciones.Sumar)
    End Sub

    Private Sub bRestar_Click(sender As Object, e As EventArgs) Handles bRestar.Click
        tbResultado.Text = miControlador.Operar(nudNum1.Value, nudNum2.Value, ControladorCalculadora.Operaciones.Restar)
    End Sub

    Private Sub bMultiplicar_Click(sender As Object, e As EventArgs) Handles bMultiplicar.Click
        tbResultado.Text = miControlador.Operar(nudNum1.Value, nudNum2.Value, ControladorCalculadora.Operaciones.Multiplicar)
    End Sub

    Private Sub bDividir_Click(sender As Object, e As EventArgs) Handles bDividir.Click
        Try
            tbResultado.Text = miControlador.Operar(nudNum1.Value, nudNum2.Value, ControladorCalculadora.Operaciones.Dividir)
        Catch miExcepcion As Exception
            MsgBox(miExcepcion.Message)
        End Try
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim nudWidth As Double = Me.Width * 180 / 399
        Dim nudFontSize As Double = Me.Height * 15.75 / 246
        Dim labelFontSize As Double = Me.Height * 10 / 246
        Dim textBoxFontSize As Double = Me.Height * 14 / 246
        Dim buttonFontSize As Double = Me.Height * 18 / 246

        'Cambiar los tamaños de fuente
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", labelFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", labelFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", labelFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        tbResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", textBoxFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        nudNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", nudFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        nudNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", nudFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        bSumar.Font = New System.Drawing.Font("Microsoft Sans Serif", buttonFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        bRestar.Font = New System.Drawing.Font("Microsoft Sans Serif", buttonFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        bElevar.Font = New System.Drawing.Font("Microsoft Sans Serif", buttonFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        bMultiplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", buttonFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        bDividir.Font = New System.Drawing.Font("Microsoft Sans Serif", buttonFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        bLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", buttonFontSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))


        'Cambiar los anchos del textbox y los numericUpDown
        tbResultado.Width = nudWidth
        nudNum1.Width = nudWidth
        nudNum2.Width = nudWidth
    End Sub

End Class
