Public Class ssimgview
#Region "Load Settings"
    Private Sub ssimgview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Variables.CheckForUpdates()

        sstasklist.ImageViewerButton.Show()

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
            MenuStrip1.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
#Region "Menu"
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
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

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseToolStripMenuItem.Click
        PictureBox1.Image = Nothing
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub StretchToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StretchToolStripMenuItem.Click
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub BackgroundColorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BackgroundColorToolStripMenuItem.Click
        Dim cd As New ColorDialog
        If cd.ShowDialog() = DialogResult.OK Then
            PictureBox1.BackColor = cd.Color
        End If
    End Sub

    Private Sub HelpCentreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpCentreToolStripMenuItem.Click
        sshelpoffline.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AboutToolStripMenuItem.Click
        ssappabout.Text = "About Image Viewer"
        ssappabout.AppPic.Image = My.Resources.ssImgView
        ssappabout.AppName.Text = "Image Viewer"
        ssappabout.AppVer.Text = "Version 2.2"
        ssappabout.ShowDialog()
    End Sub
#End Region
#Region "Other"
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sstasklist.ImageViewerButton.Hide()
    End Sub
#End Region
End Class