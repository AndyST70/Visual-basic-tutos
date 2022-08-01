Public Class Form1
    Dim num1, num2, resultado As Integer
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        resultado = Val(TextBox3.Text)
        resultado = Val(num1) + Val(num2)
        TextBox3.Text = resultado

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        resultado = Val(TextBox3.Text)
        resultado = Val(num1) * Val(num2)
        TextBox3.Text = resultado
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num11, num22, resultado2 As Double
        num11 = Val(TextBox1.Text)
        num22 = Val(TextBox2.Text)
        resultado2 = Val(TextBox3.Text)
        resultado2 = Val(num11) / Val(num22)
        TextBox3.Text = resultado2
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Val(Edad.Text) < 18 Then
            lbl.Text = "Es menor de edad"
        Else
            lbl.Text = "Es mayor de edad"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim Numero1, numero2, resultpapita As Integer 'esto hace referencia a un número
        Numero1 = Val(TextBox1.Text)
        numero2 = Val(TextBox2.Text) ' Obtenga los datos
        resultpapita = Val(TextBox4.Text)
        resultpapita = Val(Numero1) + Val(numero2)
        TextBox4.Text = resultpapita





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        resultado = Val(TextBox3.Text)
        resultado = Val(num1) - Val(num2)
        TextBox3.Text = resultado
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Edad.Clear()


    End Sub
End Class
