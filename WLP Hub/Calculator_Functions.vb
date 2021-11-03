Public Class Calculator_Functions
    Sub ShowValue(ByVal button As Button)
        Calculator.TextBox1.Text = Val(Calculator.TextBox1.Text & button.Text)
    End Sub

    Sub Arithmetic(ByVal button As Button)
        Calculator.Value1 = Val(Calculator.TextBox1.Text)
        Calculator.Operation = button.Text
        Calculator.TextBox1.Text = ""
    End Sub

    Sub Calculate()
        Select Case Calculator.Operation
            Case "+"
                Calculator.TextBox1.Text = Calculator.Value1 + Val(Calculator.TextBox1.Text)
            Case "-"
                Calculator.TextBox1.Text = Calculator.Value1 - Val(Calculator.TextBox1.Text)
            Case "/"
                Calculator.TextBox1.Text = Calculator.Value1 / Val(Calculator.TextBox1.Text)
            Case "*"
                Calculator.TextBox1.Text = Calculator.Value1 * Val(Calculator.TextBox1.Text)
        End Select
    End Sub
End Class
