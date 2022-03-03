Public Class Form1
    Private Sub botonRestarA_Click(sender As Object, e As EventArgs) Handles botonRestarA.Click
        labelA.Text = Restar(labelA.Text)
    End Sub
    Function Restar(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevoTexto As String
        numero = numero - 1
        nuevoTexto = numero.ToString()
        Return nuevoTexto
    End Function
    Function Aumentar(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevoTexto As String
        numero = numero + 1
        nuevoTexto = numero.ToString()
        Return nuevoTexto
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub botonSumarA_Click(sender As Object, e As EventArgs) Handles botonSumarA.Click
        labelA.Text = Aumentar(labelA.Text)
    End Sub

    Private Sub botonRestarB_Click(sender As Object, e As EventArgs) Handles botonRestarB.Click
        labelB.Text = Restar(labelB.Text)
    End Sub

    Private Sub botonSumarB_Click(sender As Object, e As EventArgs) Handles botonSumarB.Click
        labelB.Text = Aumentar(labelB.Text)
    End Sub

    Private Sub botonSuma_Click(sender As Object, e As EventArgs) Handles botonSuma.Click
        Dim txtA = labelA.Text
        Dim numA = Int32.Parse(txtA)
        Dim txtB = labelB.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultaadoSuma = Suma(numA, numB)
        labelResultado.Text = "El resultado de la suma es: " + resultaadoSuma.ToString
    End Sub
    Function Suma(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA + numB
        Return resultado

    End Function
    Function Resta(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA - numB
        Return resultado

    End Function

    Private Sub botonRestar_Click(sender As Object, e As EventArgs) Handles botonRestar.Click
        Dim txtA = labelA.Text
        Dim numA = Int32.Parse(txtA)
        Dim txtB = labelB.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadoResta = Resta(numA, numB)
        labelResultado.Text = "El resultado de la resta es: " + resultadoResta.ToString
    End Sub
    Function Multiplicacion(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA * numB
        Return resultado

    End Function
    Function Division(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA / numB
        Return resultado

    End Function

    Private Sub botonMultiplicar_Click(sender As Object, e As EventArgs) Handles botonMultiplicar.Click
        Dim txtA = labelA.Text
        Dim numA = Int32.Parse(txtA)
        Dim txtB = labelB.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadoMulti = Multiplicacion(numA, numB)
        labelResultado.Text = "El resultado de la multi es: " + resultadoMulti.ToString
    End Sub

    Private Sub botonDividir_Click(sender As Object, e As EventArgs) Handles botonDividir.Click
        Dim txtA = labelA.Text
        Dim numA = Int32.Parse(txtA)
        Dim txtB = labelB.Text
        Dim numB = Int32.Parse(txtB)

        If numB = 0 Then
            MsgBox("MATH ERROR. ES IMPOSIBLE DIVIDIR ENTRE CERO")
        Else
            Dim resultadoDivision = Division(numA, numB)
            labelResultado.Text = "El resultado de la división es: " + resultadoDivision.ToString
        End If
    End Sub

    Private Sub botonLimpiar_Click(sender As Object, e As EventArgs) Handles botonLimpiar.Click
        labelA.Text = "0"
        labelB.Text = "0"
        labelResultado.Text = "El resultado es: "

    End Sub
End Class
