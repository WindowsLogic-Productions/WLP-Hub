Imports System.Drawing.Text
Public Class sswriter
#Region "Load Settings"
    Private Sub ssffw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Variables.CheckForUpdates()

        sstasklist.WriterButton.Show()

        For fntSize = 1 To 72

            ToolStripComboBox2.Items.Add(fntSize)
        Next


        Dim fonts As New InstalledFontCollection()

        For fntFamily As Integer = 0 To fonts.Families.Length - 1
            ToolStripComboBox1.Items.Add(fonts.Families(fntFamily).Name)

        Next

        '-----------------------------

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
            MenuStrip1.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
#Region "File Menu"
    Private Sub NewDocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewDocumentToolStripMenuItem.Click
        Dim n As New sswriter
        n.Show()
    End Sub

    Private Sub OpenDocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDocumentToolStripMenuItem.Click
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

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
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

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
#End Region
#Region "Edit Menu"
    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub CutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem1.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub DeleteAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAllToolStripMenuItem.Click
        RichTextBox1.Clear()
    End Sub
#End Region
#Region "Format Menu"
    Private Sub BoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoldToolStripMenuItem.Click
        Dim bfont As New Font(RichTextBox1.Font, FontStyle.Bold)
        Dim rfont As New Font(RichTextBox1.Font, FontStyle.Regular)

        If RichTextBox1.SelectedText.Length = 0 Then Exit Sub
        If RichTextBox1.SelectionFont.Bold Then
            RichTextBox1.SelectionFont = rfont
        Else
            RichTextBox1.SelectionFont = bfont
        End If
    End Sub

    Private Sub ItalicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItalicToolStripMenuItem.Click
        Dim Ifont As New Font(RichTextBox1.Font, FontStyle.Italic)
        Dim rfont As New Font(RichTextBox1.Font, FontStyle.Regular)

        If RichTextBox1.SelectedText.Length = 0 Then Exit Sub
        If RichTextBox1.SelectionFont.Italic Then
            RichTextBox1.SelectionFont = rfont
        Else
            RichTextBox1.SelectionFont = Ifont
        End If
    End Sub

    Private Sub UnderlineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnderlineToolStripMenuItem.Click
        Dim Ufont As New Font(RichTextBox1.Font, FontStyle.Underline)
        Dim rfont As New Font(RichTextBox1.Font, FontStyle.Regular)

        If RichTextBox1.SelectedText.Length = 0 Then Exit Sub
        If RichTextBox1.SelectionFont.Underline Then
            RichTextBox1.SelectionFont = rfont
        Else
            RichTextBox1.SelectionFont = Ufont
        End If
    End Sub

    Private Sub StrikeoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StrikeoutToolStripMenuItem.Click
        Dim Sfont As New Font(RichTextBox1.Font, FontStyle.Strikeout)
        Dim rfont As New Font(RichTextBox1.Font, FontStyle.Regular)


        If RichTextBox1.SelectedText.Length = 0 Then Exit Sub
        If RichTextBox1.SelectionFont.Strikeout Then
            RichTextBox1.SelectionFont = rfont
        Else
            RichTextBox1.SelectionFont = Sfont
        End If
    End Sub

    Private Sub AlignLeftToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AlignLeftToolStripMenuItem1.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub AlignCentreToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AlignCentreToolStripMenuItem1.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub AlignRightToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AlignRightToolStripMenuItem1.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub UppercaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UppercaseToolStripMenuItem.Click
        RichTextBox1.SelectedText = RichTextBox1.SelectedText.ToUpper()
    End Sub

    Private Sub LowercaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LowercaseToolStripMenuItem.Click
        RichTextBox1.SelectedText = RichTextBox1.SelectedText.ToLower()
    End Sub

    Private Sub TextColourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextColourToolStripMenuItem.Click
        RichTextBox1.ForeColor = ColorDialog1.Color
    End Sub
#End Region
#Region "Help Menu"
    Private Sub HelpCentreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpCentreToolStripMenuItem.Click
        sshelpoffline.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AboutToolStripMenuItem.Click
        ssabout.Text = "About Writer"
        ssabout.AppPic.Image = My.Resources.ssWriter
        ssabout.AppName.Text = "Hub Writer - Version 3.3"
        ssabout.ShowDialog()
    End Sub
#End Region
#Region "Toolbar Functions"
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim n As New sswriter
        n.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim Open As New OpenFileDialog()
        Dim MyStreamReader As System.IO.StreamReader
        Open.Filter = "Rich Text Document (*.rtf)|*.rtf"
        Open.CheckFileExists = True
        Open.Title = "Open Document..."
        Open.ShowDialog(Me)
        Try
            Open.OpenFile()
            MyStreamReader = System.IO.File.OpenText(Open.FileName)
            RichTextBox1.Text = MyStreamReader.ReadToEnd()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim Saveas As New SaveFileDialog()
        Dim myStreamWriter As System.IO.StreamWriter
        Saveas.Filter = "Rich Text Document (*.rtf)|*.rtf"
        Saveas.CheckPathExists = True
        Saveas.Title = "Save As..."
        Saveas.ShowDialog(Me)
        Try
            myStreamWriter = System.IO.File.AppendText(Saveas.FileName)
            myStreamWriter.Write(RichTextBox1.Text)
            myStreamWriter.Flush()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        If RichTextBox1.Text = "" Then
            sserror.Show()
            sserror.Label1.Text = "The document is empty."
        Else
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub ToolStripButton5_Click_2(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        If RichTextBox1.Text = "" Then
            sserror.Show()
            sserror.Label1.Text = "The document is empty."
        Else
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub ToolStripComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Dim ComboFonts As System.Drawing.Font

        Try
            ComboFonts = RichTextBox1.SelectionFont
            RichTextBox1.SelectionFont = New System.Drawing.Font(ToolStripComboBox1.Text, RichTextBox1.SelectionFont.Size, RichTextBox1.SelectionFont.Style)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox2.SelectedIndexChanged
        RichTextBox1.SelectionFont = New Font(ToolStripComboBox2.SelectedItem.ToString, CInt(ToolStripComboBox2.SelectedItem.ToString), RichTextBox1.SelectionFont.Style)
    End Sub

    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click
        Dim bfont As New Font(RichTextBox1.Font, FontStyle.Bold)
        Dim rfont As New Font(RichTextBox1.Font, FontStyle.Regular)

        If RichTextBox1.SelectedText.Length = 0 Then Exit Sub
        If RichTextBox1.SelectionFont.Bold Then
            RichTextBox1.SelectionFont = rfont
        Else
            RichTextBox1.SelectionFont = bfont
        End If
    End Sub

    Private Sub ToolStripButton13_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton13.Click
        Dim Ifont As New Font(RichTextBox1.Font, FontStyle.Italic)
        Dim rfont As New Font(RichTextBox1.Font, FontStyle.Regular)

        If RichTextBox1.SelectedText.Length = 0 Then Exit Sub
        If RichTextBox1.SelectionFont.Italic Then
            RichTextBox1.SelectionFont = rfont
        Else
            RichTextBox1.SelectionFont = Ifont
        End If
    End Sub

    Private Sub ToolStripButton14_Click(sender As Object, e As EventArgs) Handles ToolStripButton14.Click
        Dim Ufont As New Font(RichTextBox1.Font, FontStyle.Underline)
        Dim rfont As New Font(RichTextBox1.Font, FontStyle.Regular)

        If RichTextBox1.SelectedText.Length = 0 Then Exit Sub
        If RichTextBox1.SelectionFont.Underline Then
            RichTextBox1.SelectionFont = rfont
        Else
            RichTextBox1.SelectionFont = Ufont
        End If
    End Sub

    Private Sub ToolStripButton18_Click(sender As Object, e As EventArgs) Handles ToolStripButton18.Click
        Dim Sfont As New Font(RichTextBox1.Font, FontStyle.Strikeout)
        Dim rfont As New Font(RichTextBox1.Font, FontStyle.Regular)


        If RichTextBox1.SelectedText.Length = 0 Then Exit Sub
        If RichTextBox1.SelectionFont.Strikeout Then
            RichTextBox1.SelectionFont = rfont
        Else
            RichTextBox1.SelectionFont = Sfont
        End If
    End Sub

    Private Sub ToolStripButton15_Click(sender As Object, e As EventArgs) Handles ToolStripButton15.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub ToolStripButton16_Click(sender As Object, e As EventArgs) Handles ToolStripButton16.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub ToolStripButton17_Click(sender As Object, e As EventArgs) Handles ToolStripButton17.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub ToolStripButton19_Click(sender As Object, e As EventArgs) Handles ToolStripButton19.Click
        RichTextBox1.SelectedText = RichTextBox1.SelectedText.ToUpper()
    End Sub

    Private Sub ToolStripButton20_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton20.Click
        RichTextBox1.SelectedText = RichTextBox1.SelectedText.ToLower()
    End Sub

    Private Sub ToolStripButton21_Click(sender As Object, e As EventArgs) Handles ToolStripButton21.Click
        If RichTextBox1.ZoomFactor = 1 Then
            Exit Sub

        Else

            RichTextBox1.ZoomFactor = RichTextBox1.ZoomFactor - 1
        End If
    End Sub

    Private Sub ToolStripButton22_Click(sender As Object, e As EventArgs) Handles ToolStripButton22.Click
        If RichTextBox1.ZoomFactor = 50 Then

            Exit Sub
        Else

            RichTextBox1.ZoomFactor = RichTextBox1.ZoomFactor + 1
        End If
    End Sub
#End Region
#Region "Other"
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If RichTextBox1.Text = "" Then
            Me.Dispose()
            sstasklist.WriterButton.Hide()
        Else
            sswritersaveyesno.ShowDialog()
            e.Cancel = True
        End If

        If sswritersaveyesno.SaveButton.Enabled = True Then
            e.Cancel = False
        End If

        If sswritersaveyesno.SaveButton.Enabled = False Then
            e.Cancel = True
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font1 As New Font("Segoe UI", 16, FontStyle.Regular)
        e.Graphics.DrawString(RichTextBox1.Text, font1, Brushes.Black, 100, 100)
    End Sub
#End Region
End Class
