Imports System.Drawing.Text
Public Class ssffw

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sswritersaveyesno.ShowDialog()
        e.Cancel = True

        If sswritersaveyesno.Button2.Enabled = True Then
            e.Cancel = False
        End If

        If sswritersaveyesno.Button2.Enabled = False Then
            e.Cancel = True
        End If
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RichTextBox1.SelectAll()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FC As New ColorDialog
        Try
            FC.ShowDialog()
            RichTextBox1.ForeColor = FC.Color
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RichTextBox1.Redo()
    End Sub

    Private Sub DeleteAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RichTextBox1.Clear()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ssabout.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ssabout.Show()
    End Sub

    Private Sub ToolStripButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RichTextBox1.Undo()
    End Sub

    Private Sub ToolStripButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RichTextBox1.Redo()
    End Sub

    Private Sub ToolStripButton5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RichTextBox1.Cut()
    End Sub

    Private Sub ToolStripButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RichTextBox1.Copy()
    End Sub

    Private Sub ToolStripButton3_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RichTextBox1.Paste()
    End Sub

    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Sfont As New Font(RichTextBox1.Font, FontStyle.Strikeout)
        Dim rfont As New Font(RichTextBox1.Font, FontStyle.Regular)


        If RichTextBox1.SelectedText.Length = 0 Then Exit Sub
        If RichTextBox1.SelectionFont.Strikeout Then
            RichTextBox1.SelectionFont = rfont
        Else
            RichTextBox1.SelectionFont = Sfont
        End If
    End Sub


    Private Sub ssffw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sssc.Button4.Show()

        For fntSize = 1 To 72

            ComboBox2.Items.Add(fntSize)
        Next


        Dim fonts As New InstalledFontCollection()

        For fntFamily As Integer = 0 To fonts.Families.Length - 1
            ComboBox1.Items.Add(fonts.Families(fntFamily).Name)

        Next

        '-----------------------------

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If RichTextBox1.ZoomFactor = 50 Then

            Exit Sub
        Else

            RichTextBox1.ZoomFactor = RichTextBox1.ZoomFactor + 1
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If RichTextBox1.ZoomFactor = 1 Then
            Exit Sub

        Else

            RichTextBox1.ZoomFactor = RichTextBox1.ZoomFactor - 1
        End If
    End Sub

    Private Sub tbSelectFont_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim ComboFonts As System.Drawing.Font

        Try
            ComboFonts = RichTextBox1.SelectionFont
            RichTextBox1.SelectionFont = New System.Drawing.Font(ComboBox1.Text, RichTextBox1.SelectionFont.Size, RichTextBox1.SelectionFont.Style)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub tbSelectSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        RichTextBox1.SelectionFont = New Font(ComboBox2.SelectedItem.ToString, CInt(ComboBox2.SelectedItem.ToString), RichTextBox1.SelectionFont.Style)
    End Sub

    Private Sub ToolStripButton20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If RichTextBox1.ZoomFactor = 50 Then

            Exit Sub
        Else

            RichTextBox1.ZoomFactor = RichTextBox1.ZoomFactor + 1
        End If
    End Sub

    Private Sub ZoomInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If RichTextBox1.ZoomFactor = 50 Then

            Exit Sub
        Else

            RichTextBox1.ZoomFactor = RichTextBox1.ZoomFactor + 1
        End If
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim n As New ssffw
        n.Show()
    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim Open As New OpenFileDialog()
        Dim MyStreamReader As System.IO.StreamReader
        Open.Filter = "Rich Text Document (*.rtf)|*.rtf"
        Open.CheckFileExists = True
        Open.Title = "Open..."
        Open.ShowDialog(Me)
        Try
            Open.OpenFile()
            MyStreamReader = System.IO.File.OpenText(Open.FileName)
            RichTextBox1.Text = MyStreamReader.ReadToEnd()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim Saveas As New SaveFileDialog()
        Dim myStreamWriter As System.IO.StreamWriter
        Saveas.Filter = "Rich Text Document (*.rtf)|*.rtf"
        Saveas.CheckPathExists = True
        Saveas.Title = "Save as..."
        Saveas.ShowDialog(Me)
        Try
            myStreamWriter = System.IO.File.AppendText(Saveas.FileName)
            myStreamWriter.Write(RichTextBox1.Text)
            myStreamWriter.Flush()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PrintDocument1.Print()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If RichTextBox1.Text = "" Then
            MsgBox("You have not entered any text.", MsgBoxStyle.Information)
        Else
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Dim bfont As New Font(RichTextBox1.Font, FontStyle.Bold)
        Dim rfont As New Font(RichTextBox1.Font, FontStyle.Regular)

        If RichTextBox1.SelectedText.Length = 0 Then Exit Sub
        If RichTextBox1.SelectionFont.Bold Then
            RichTextBox1.SelectionFont = rfont
        Else
            RichTextBox1.SelectionFont = bfont
        End If
    End Sub

    Private Sub Button21_Click(sender As System.Object, e As System.EventArgs) Handles Button21.Click
        Dim Ifont As New Font(RichTextBox1.Font, FontStyle.Italic)
        Dim rfont As New Font(RichTextBox1.Font, FontStyle.Regular)

        If RichTextBox1.SelectedText.Length = 0 Then Exit Sub
        If RichTextBox1.SelectionFont.Italic Then
            RichTextBox1.SelectionFont = rfont
        Else
            RichTextBox1.SelectionFont = Ifont
        End If
    End Sub

    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        Dim Ufont As New Font(RichTextBox1.Font, FontStyle.Underline)
        Dim rfont As New Font(RichTextBox1.Font, FontStyle.Regular)

        If RichTextBox1.SelectedText.Length = 0 Then Exit Sub
        If RichTextBox1.SelectionFont.Underline Then
            RichTextBox1.SelectionFont = rfont
        Else
            RichTextBox1.SelectionFont = Ufont
        End If
    End Sub

    Private Sub Button18_Click(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        Dim Sfont As New Font(RichTextBox1.Font, FontStyle.Strikeout)
        Dim rfont As New Font(RichTextBox1.Font, FontStyle.Regular)


        If RichTextBox1.SelectedText.Length = 0 Then Exit Sub
        If RichTextBox1.SelectionFont.Strikeout Then
            RichTextBox1.SelectionFont = rfont
        Else
            RichTextBox1.SelectionFont = Sfont
        End If
    End Sub

    Private Sub Button19_Click(sender As System.Object, e As System.EventArgs) Handles Button19.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub Button20_Click(sender As System.Object, e As System.EventArgs) Handles Button20.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub Button32_Click(sender As System.Object, e As System.EventArgs) Handles Button32.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub Button17_Click(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        RichTextBox1.SelectedText = RichTextBox1.SelectedText.ToUpper()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        RichTextBox1.SelectedText = RichTextBox1.SelectedText.ToLower()
    End Sub

    Private Sub Button24_Click(sender As System.Object, e As System.EventArgs) Handles Button24.Click
        Dim FC As New ColorDialog
        Try
            FC.ShowDialog()
            RichTextBox1.ForeColor = FC.Color
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button23_Click(sender As System.Object, e As System.EventArgs)
        If RichTextBox1.ZoomFactor = 1 Then
            Exit Sub

        Else

            RichTextBox1.ZoomFactor = RichTextBox1.ZoomFactor - 1
        End If
    End Sub

    Private Sub Button25_Click(sender As System.Object, e As System.EventArgs)
        If RichTextBox1.ZoomFactor = 1 Then
            Exit Sub

        Else

            RichTextBox1.ZoomFactor = RichTextBox1.ZoomFactor - 1
        End If
    End Sub

    Private Sub Button31_Click(sender As System.Object, e As System.EventArgs) Handles Button31.Click
        ssabout.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font1 As New Font("Segoe UI", 16, FontStyle.Regular)
        e.Graphics.DrawString(RichTextBox1.Text, font1, Brushes.Black, 100, 100)
    End Sub
End Class
