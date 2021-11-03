Public Class sscalc
    Public Value1, Value2 As Double
    Public Oper As Char
    Public Mem As Double
    Dim sign_Indicator As Integer = 0
    Dim variable1 As Double
    Dim variable2 As Double
    Dim addBit As Integer = 0
    Dim subBit As Integer = 0
    Dim multBit As Integer = 0
    Dim divBit As Integer = 0
    Dim modBit As Integer = 0
    Dim powerBit As Integer = 0
    Dim permBit As Integer = 0
    Dim combBit As Integer = 0
    Dim andBit As Integer = 0
    Dim orBit As Integer = 0
    Dim xorBit As Integer = 0
    Dim powerFunctionBit As Integer = 0
    Dim trigFunctionBit As Integer = 0
    Dim HypertrigFunctionBit As Integer = 0
    Dim InversetrigFunctionBit As Integer = 0
    Dim otherFuncsBit As Integer = 0
    Dim logicalFuncsBit As Integer = 0
    Dim memFuncsBit As Integer = 0
    Dim fl As Integer = 0
    Dim memoryVariable As Double = 0
    Dim scientificModeBit As Integer = 0

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sstasklist.CalculatorButton.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZeroButton.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(0)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 0
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OneButton.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(1)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 1
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TwoButton.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(2)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 2
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(3)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 3
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(4)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 4
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(5)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 5
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(6)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 6
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(7)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 7
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(8)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 8
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If sign_Indicator = 0 Then
            displayText.Text = displayText.Text & CStr(9)
        ElseIf sign_Indicator = 1 Then
            displayText.Text = 9
            sign_Indicator = 0
        End If
        fl = 1
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PointButton.Click
        Dim i As Integer
        Dim chr As Char
        Dim decimal_Indicator As Integer = 0

        If sign_Indicator <> 1 Then
            For i = 0 To displayText.Text.Count - 1
                chr = displayText.Text(i)
                If chr = "." Then
                    decimal_Indicator = 1
                End If
            Next

            If decimal_Indicator <> 1 Then
                displayText.Text = displayText.Text & CStr(".")
            End If
        End If
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            divBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            multBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        If displayText.Text.Length <> 0 Then
            variable2 = displayText.Text
            Calculate()
            reset_SignBits()
            subBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlusButton.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            addBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
        End If
        sign_Indicator = 1
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = 1 / displayText.Text
        End If
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            modBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        If displayText.Text.Length <> 0 Then
            If displayText.Text <> "." Then
                displayText.Text = Math.Sqrt(displayText.Text)
            End If
            sign_Indicator = 1
        End If
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If displayText.Text.Length = 0 Then
            displayText.Text = displayText.Text + CStr("-")
        ElseIf displayText.Text <> "." Then
            displayText.Text = displayText.Text * -1
        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        displayText.Clear()
        sign_Indicator = 0
        variable1 = 0
        variable2 = 0
        memoryVariable = 0
        reset_SignBits()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        displayText.Clear()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = displayText.Text.Remove(displayText.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        If displayText.Text.Length <> 0 Then
            If memoryVariable = 0 Then
                memoryVariable = CDbl(displayText.Text)
            End If
        End If
        sign_Indicator = 1
        displayText.Text = CStr(memoryVariable)
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        If memoryVariable <> 0 Then
            memoryVariable = memoryVariable + memoryVariable
        End If
        sign_Indicator = 1
        displayText.Text = CStr(memoryVariable)
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        If memoryVariable <> 0 Then
            memoryVariable = memoryVariable - memoryVariable
        End If
        sign_Indicator = 1
        displayText.Text = CStr(memoryVariable)
    End Sub

    Private Sub OnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnToolStripMenuItem1.Click
        Me.Width = 358
        Me.Height = 410
        ToolStripDropDownButton2.Text = "Scientific: On"
    End Sub

    Private Sub OffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OffToolStripMenuItem1.Click
        Me.Width = 202
        Me.Height = 335
        ToolStripDropDownButton2.Text = "Scientific: Off"
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        If displayText.Text.Length <> 0 Then
            Dim temp As Double = displayText.Text
            Dim result = Factorial(temp)
            displayText.Text = CStr(result)
        End If
        sign_Indicator = 1
    End Sub

    Private Function reset_SignBits()
        addBit = 0
        subBit = 0
        multBit = 0
        divBit = 0
        modBit = 0
        powerBit = 0
        permBit = 0
        combBit = 0
        andBit = 0
        orBit = 0
        xorBit = 0
        fl = 0
        Return 0
    End Function

    Private Function permutation(ByVal variable1, ByVal variable2)
        Dim result As Double
        result = Factorial(variable1) / Factorial(variable1 - variable2)
        Return result
    End Function

    Private Function combination(ByVal variable1, ByVal variable2)
        Dim result As Double
        result = Factorial(variable1) / (Factorial(variable2) * Factorial(variable1 - variable2))
        Return result
    End Function

    Private Function Calculate()
        If displayText.Text <> "." Then
            variable2 = displayText.Text
            If fl = False Then
                variable1 = variable2
            ElseIf addBit = 1 Then
                variable1 = variable1 + variable2
            ElseIf subBit = 1 Then
                variable1 = variable1 - variable2
            ElseIf multBit = 1 Then
                variable1 = variable1 * variable2
            ElseIf divBit = 1 Then
                variable1 = variable1 / variable2
            ElseIf modBit = 1 Then
                variable1 = variable1 Mod variable2
            ElseIf powerBit = 1 Then
                variable1 = Math.Pow(variable1, variable2)
            ElseIf permBit = 1 Then
                variable1 = permutation(variable1, variable2)
            ElseIf combBit = 1 Then
                variable1 = combination(variable1, variable2)
            ElseIf andBit = 1 Then
                variable1 = variable1 And variable2
            ElseIf orBit = 1 Then
                variable1 = variable1 Or variable2
            ElseIf xorBit = 1 Then
                variable1 = variable1 Xor variable2
            Else
                variable1 = variable2
            End If
            displayText.Text = CStr(variable1)
            sscalculations.TextBox1.Text = "= " & variable1

        End If
        Return 0
    End Function

    Public Function Factorial(ByVal temp)
        Dim result As Double = temp
        If temp = 0 Then
            Return 1
        Else
            For i = temp - 1 To 1 Step -1
                result = result * i
            Next
        End If
        Return result
    End Function

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        displayText.Text = Math.PI
        sign_Indicator = 1
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Log(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            powerBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            permBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        displayText.Text = Math.E
        sign_Indicator = 1
    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Exp(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = displayText.Text * displayText.Text
        End If
        sign_Indicator = 1
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            combBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Log10(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub Button44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button44.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            andBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button39.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = displayText.Text * displayText.Text * displayText.Text
        End If
        sign_Indicator = 1
    End Sub

    Private Sub Button43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button43.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            orBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub Button42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button42.Click
        If displayText.Text.Length <> 0 Then
            variable1 = CDbl(displayText.Text)
            variable1 = Not variable1
            displayText.Text = CStr(variable1)
            sign_Indicator = 1
        End If
    End Sub

    Private Sub Button41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button41.Click
        If displayText.Text.Length <> 0 Then
            Calculate()
            reset_SignBits()
            xorBit = 1
            sign_Indicator = 1
        End If
    End Sub

    Private Sub Button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button40.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = displayText.Text * displayText.Text * displayText.Text * displayText.Text
        End If
        sign_Indicator = 1
    End Sub

    Private Sub Button48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button48.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Sin(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub Button47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button47.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Cos(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub Button52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button52.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Cosh(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub Button51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button51.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Tanh(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub Button56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button56.Click
        If displayText.Text.Length <> 0 Then
            Dim temp As Double = displayText.Text
            displayText.Text = Math.Truncate(temp)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub Button55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button55.Click
        If displayText.Text.Length <> 0 Then
            Dim temp As Double = displayText.Text
            displayText.Text = Math.Ceiling(temp)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub Button46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button46.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Tan(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub Button45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button45.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Sinh(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub Button50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button50.Click
        If displayText.Text.Length <> 0 Then
            Dim temp As Double = displayText.Text
            displayText.Text = Math.Round(temp)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub Button49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button49.Click
        If displayText.Text.Length <> 0 Then
            Dim temp As Double = displayText.Text
            displayText.Text = Math.Floor(temp)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub Button54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button54.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Asin(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub Button53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button53.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Acos(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub Button57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button57.Click
        If displayText.Text.Length <> 0 Then
            displayText.Text = Math.Atan(displayText.Text)
        End If
        sign_Indicator = 1
    End Sub

    Private Sub AboutSAMMYSuiteCalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ssabout.Text = "About Calculator"
        ssabout.AppPic.Image = My.Resources.ssCalc
        ssabout.AppName.Text = "Hub Calculator - Version 4.0"
        ssabout.ShowDialog()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem1.Click
        displayText.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem1.Click
        displayText.Paste()
    End Sub

    Private Sub FormulaeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormulaeToolStripMenuItem.Click
        sscalcconsts.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Dispose()
    End Sub

    Private Sub sscalc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sstasklist.CalculatorButton.Show()

        Variables.CheckForUpdates()
        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
            MenuStrip1.BackColor = My.Settings.CustomColour
            StatusStrip1.BackColor = My.Settings.CustomColour
        End If
    End Sub
    Private Sub displayText_KeyPress(sender As Object, e As KeyPressEventArgs) Handles displayText.KeyPress

        If Not Char.IsDigit(e.KeyChar) Then e.Handled = True

        If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        
    End Sub
    
    Private Sub WriteEquationsToFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WriteEquationsToFileToolStripMenuItem.Click
        'This is temporary for now, will program new area of calc later.
        sscalculations.Show()
    End Sub
End Class