Public Class ssimgview

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sssc.Button6.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Clipboard.SetImage(PictureBox1.Image)

        'Create a JPG on disk and add the location to the clipboard
        Dim TempName As String = "TempName.jpg"
        Dim TempPath As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, TempName)
        Using FS As New System.IO.FileStream(TempPath, IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.Read)
            PictureBox1.Image.Save(FS, System.Drawing.Imaging.ImageFormat.Jpeg)
        End Using
        Dim Paths As New System.Collections.Specialized.StringCollection()
        Paths.Add(TempPath)
        Clipboard.SetFileDropList(Paths)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim cd As New ColorDialog
        If cd.ShowDialog() = DialogResult.OK Then
            PictureBox1.BackColor = cd.Color
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        ssabout.Show()
    End Sub

    Private Sub ssimgview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sssc.Button6.Show()
    End Sub
End Class