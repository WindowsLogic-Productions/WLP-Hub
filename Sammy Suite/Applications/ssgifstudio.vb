Imports System.Collections.Generic
Imports System.Text
Imports System.IO
Imports System.Collections
Imports System.Collections.Specialized
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System
Imports System.Drawing.Drawing2D
Imports System.Drawing.Image
Imports System.Threading

Public Class ssgifstudio
#Region "Load Settings"
        Dim OriginalGif As Image
        Dim NameToUse As String = "Frame"
        Dim ImgForSepia As Image

        Dim W, H As Integer
        Dim ImageArray, MemPic, WorkAry As New ArrayList
        Dim N As Integer = 0
        Dim Start, Finish As Integer 'For Selecting A Range Of Frames

        Dim InitX As Integer = 0 'Top Left corner of crop
        Dim InitY As Integer = 0
        Dim Pictures As Integer = 0 'Frames Counter
        'bitmap to contain the cropped image
        Dim cropBitmap As Bitmap
        Dim Im As Image 'Splash
        'the position and size to crop the image file
        Dim Xcropping As Integer
        Dim Ycropping As Integer
        Dim CroppingW As Integer
        Dim CroppingH As Integer
        Dim XStretching As Double = 1
        Dim YStretching As Double = 1
        Dim rect As Rectangle
        'create a pen object
        Public Marker As Pen
        Dim NewName As String

        'select a default crop line size
        Public MarkerSize As Integer = 2

        'will contain the dashStyle of the pen
        Public crpStyle As Drawing2D.DashStyle = Drawing2D.DashStyle.Solid

        'set a default crop line color
        Public MarkerColor As Color = Color.Red
        Dim tt As New ToolTip
        Dim WasAnError As Boolean = False

        Private _numberPreviewImages As Integer = 100
        Private _imageSize As Integer = 100 '75

        Dim Position As Integer = 0 'Where Are We On ImageArray When Clicking A Cell

        Private Sub ssgifstudio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Variables.CheckForUpdates()

        sstasklist.GIFStudioButton.Show()

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.MenuStrip1.BackColor = My.Settings.CustomColour
            Me.BackColor = My.Settings.CustomColour
        End If

        'Load other things.
        cbType.Items.Add(".bmp")
        cbType.Items.Add(".gif")
        cbType.Items.Add(".jpg")
        cbType.Items.Add(".png")
        cbType.Items.Add(".tif")
            ImageArray = New ArrayList
            MemPic = New ArrayList
            cbType.SelectedIndex = 2
            OriginalGif = pbSelect.Image
    End Sub

    Public Sub Rip(ByVal Prefix As String)

        If ckJoin.Checked = False Then 'For joining
            ImageArray.Clear()
            MemPic.Clear()
        End If

        Try
            Dim Picture As Image
            Dim MS As MemoryStream
            Dim Buf As Byte()
            Dim TempName As String
            Dim OrigDim As New FrameDimension(OriginalGif.FrameDimensionsList(0))
            Dim FrameCount As Integer = OriginalGif.GetFrameCount(OrigDim)
            ' Dim MemStr As Bitmap
            For i As Integer = 0 To FrameCount - 1
                OriginalGif.SelectActiveFrame(OrigDim, i)
                MS = New MemoryStream
                Using Frames As New Bitmap(OriginalGif)
                    TempName = GetNewName(Prefix, cbType.Text)
                    ImageArray.Add(TempName)
                    Frames.Clone.Save(MS, ImageFormat.Jpeg)
                    Buf = MS.ToArray
                    Picture = BytesToBitmap(Buf)

                    MemPic.Add(Picture)
                    MS.SetLength(0)
                    Select Case Trim(cbType.Text.ToUpper)
                        Case ".BMP"
                            Frames.Save(GetNewName(Prefix, cbType.Text), ImageFormat.Bmp)
                        Case ".JPG"
                            Frames.Save(GetNewName(Prefix, cbType.Text), ImageFormat.Jpeg)
                        Case ".GIF"
                            Frames.Save(GetNewName(Prefix, cbType.Text), ImageFormat.Gif)
                        Case ".PNG"
                            Frames.Save(GetNewName(Prefix, cbType.Text), ImageFormat.Png)
                        Case ".TIFF"
                            Frames.Save(GetNewName(Prefix, cbType.Text), ImageFormat.Tiff)
                    End Select

                End Using

            Next
        Catch
            sserror.Show()
            sserror.Label1.Text = "You have not opened an GIF image."
        End Try

    End Sub

    Public Shared Function BytesToBitmap(ByVal byteArray As Byte()) As Bitmap

        Using ms As New MemoryStream(byteArray)
            Dim img As Bitmap = DirectCast(Image.FromStream(ms), Bitmap)
            Return img
        End Using

    End Function
    Private Sub Save(ByVal Pic As Image)
        Dim i As Integer
        Dim str As String = ""
        For i = 1 To 1000
            If i < 10 Then str = "Pic_00" & i.ToString & ".gif"
            If i > 9 And i < 100 Then str = "Pic_0" & i.ToString & ".gif"
            If i > 99 Then str = "Pic_" & i.ToString & ".gif"
            If i > 900 Then MessageBox.Show("You Have Over 900 Pictures, Please Check And Delete Unnecessary Ones")
            If Not System.IO.File.Exists(str) Then
                Try
                    Pic.Save(str, System.Drawing.Imaging.ImageFormat.Gif)
                Catch Ex As Exception
                    MessageBox.Show("Could Not Write To Location")
                End Try
                Exit For
            End If
        Next

    End Sub
    Private Function CropImage(ByVal Orig_Pic As Image) As Image
        ' Get the source Bmp.
        If CroppingW <= 0 Or CroppingH <= 0 Then
            MessageBox.Show("Please Select Again")
            WasAnError = True
            Return pbSelect.Image
        End If
        Dim Orig_bmp As New Bitmap(Orig_Pic)

        ' Create the destination Bmp.
        Dim TheWidth As Integer = CroppingW '.Image.Width
        Dim TheHeight As Integer = CroppingH 'PbCrop.Image.Height
        Dim Dest_bmp As New Bitmap(TheWidth, TheHeight, Orig_Pic.PixelFormat)
        Dim G As Graphics = Graphics.FromImage(Dest_bmp)

        ' Copy the image.
        G.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBilinear
        G.DrawImage(Orig_bmp, -InitX, -InitY, W, H)

        G.Dispose()
        Return Dest_bmp 'Cropped image

    End Function
#End Region
#Region "File"
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim f As New OpenFileDialog
        Try
            With f
                .Filter = "GIF Files|*.gif"

                If .ShowDialog = DialogResult.OK Then
                    OriginalGif = Image.FromFile(.FileName)
                    pbPreview.Image = Image.FromFile(.FileName)

                    If ImageArray IsNot Nothing Then
                        If ckJoin.Checked = False Then ImageArray.Clear() 'For joining
                    End If

                    N = 0
                    Me.Text = "GIF Studio - " & .FileName.Substring(.FileName.LastIndexOf("\") + 1)

                End If

            End With

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        Finally
            If Not f Is Nothing Then
                f.Dispose()
                f = Nothing
            End If
        End Try
        pbPreview.Visible = True
        pbSelect.Visible = False
        pbPreview.BringToFront()
    End Sub

    Private Sub ViewDirectoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewDirectoryToolStripMenuItem.Click
        Shell("Explorer " & AppDomain.CurrentDomain.BaseDirectory, AppWinStyle.NormalFocus)
    End Sub

    Private Sub ScanFolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScanFolderToolStripMenuItem.Click
        scan()
        lblImages.Text = "*.Jpg Files In Folder: " & ImageArray.Count.ToString
        LoadImages()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
#End Region
#Region "Frames"

    Private Sub btnExtract_Click(sender As System.Object, e As System.EventArgs) Handles btnExtract.Click
        Try
            Rip(NameToUse)
            pbPreview.Visible = False
            pbSelect.Visible = True
            pbSelect.Image = Image.FromFile(ImageArray(0))
            lblImages.Text = "Frames In Animation: " & ImageArray.Count.ToString
            LoadImages()
        Catch
            sserror.Show()
            sserror.Text = "Fatal Error (Sammie Suite Exception)"
            sserror.Label1.Text = "No GIF is loaded into GIF Studio. (Error code: 0000x001)"
        End Try
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Try
            If ImageArray.Count = 1 Then Exit Sub

            N = N - 1
            If N < 0 Then
                N = ImageArray.Count - 1

            End If
            If ImageArray(N) IsNot Nothing Then
                pbSelect.Image = Image.FromFile(ImageArray(N))
            End If

            lblTour.Text = ImageArray(N) & vbNewLine & "Image(" & N & ")"
            Hilite()
        Catch
            sserror.Show()
            sserror.Text = "Fatal Error (Sammie Suite Exception)"
            sserror.Label1.Text = "No GIF image frames. (Error code: 0000x005)"
        End Try
    End Sub

    Private Sub btnForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForward.Click
        Try
            If ImageArray.Count = 1 Then Exit Sub
            N += 1
            If N > ImageArray.Count - 1 Then
                N = 0
            End If
            If ImageArray(N) IsNot Nothing Then
                pbSelect.Image = Image.FromFile(ImageArray(N))
            End If
            lblTour.Text = ImageArray(N) & vbNewLine & "Image(" & N & ")"
            Hilite()
        Catch
            sserror.Show()
            sserror.Text = "Fatal Error (Sammie Suite Exception)"
            sserror.Label1.Text = "No GIF image frames. (Error code: 0000x005)"
        End Try
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Try
            Start = N
        Catch
            sserror.Show()
            sserror.Text = "Fatal Error (Sammie Suite Exception)"
            sserror.Label1.Text = "No GIF image frames. (Error code: 0000x005)"
        End Try
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        Try
            Finish = N
            WorkAry.Clear()
            For i As Integer = Start To Finish
                WorkAry.Add(ImageArray(i))
            Next
            ImageArray.Clear()
            For i As Integer = 0 To WorkAry.Count - 1

                ImageArray.Add(WorkAry(i))
            Next
            N = ImageArray.Count - 1
        Catch
            sserror.Show()
            sserror.Text = "Fatal Error (Sammie Suite Exception)"
            sserror.Label1.Text = "No GIF image frames. (Error code: 0000x005)"
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            ImageArray.RemoveAt(N)
            LoadImages()
            lblImages.Text = "Frames In Animation: " & ImageArray.Count.ToString
        Catch
            sserror.Show()
            sserror.Text = "Fatal Error (Sammie Suite Exception)"
            sserror.Label1.Text = "You have already deleted all frames. (Error code: 0000x004)"
        End Try
    End Sub
#End Region
#Region "Effects"

    Private Sub ckDark_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckDark.CheckedChanged
        If ckDark.Checked = True Then

            tbIntensity.Visible = True
        Else
            tbIntensity.Visible = False
        End If
    End Sub

    Private Sub tbIntensity_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbIntensity.MouseEnter
        lblValue.Visible = True
    End Sub

    Private Sub tbIntensity_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbIntensity.MouseLeave
        lblValue.Visible = False
    End Sub

    Private Sub tbIntensity_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbIntensity.MouseUp
        Preview()
    End Sub

    Private Sub tbIntensity_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIntensity.Scroll
        lblValue.Text = tbIntensity.Value.ToString
    End Sub

    Private Sub tbTolerance_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbTolerance.MouseEnter
        lblValue1.Visible = True
    End Sub

    Private Sub tbTolerance_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbTolerance.MouseLeave
        lblValue1.Visible = False

    End Sub

    Private Sub tbTolerance_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbTolerance.MouseUp
        Preview()
    End Sub

    Private Sub tbTolerance_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbTolerance.Scroll
        lblValue1.Text = tbTolerance.Value.ToString
    End Sub

    Private Sub btnFramePView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFramePView.Click
        Preview()
    End Sub


    Private Sub btnAnimate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnimate.Click
        Try
            Assemble(1)
            pbResult.Image = Image.FromFile(NewName)
        Catch
            sserror.Show()
            sserror.Text = "Fatal Error (Sammie Suite Exception)"
            sserror.Label1.Text = "No GIF image frames (Error code: 0000x005)"
        End Try
    End Sub

    Private Sub btnResize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn50.Click, btn33.Click, btn25.Click, btn150.Click, btn75.Click, btn200.Click
        Try
            Dim Orig_bmp As Bitmap
            'following code resizes pictures
            MemPic.Clear()
            For NX As Integer = 0 To ImageArray.Count - 1
                W = GetImageWidth(ImageArray(0))
                H = GetImageHeight(ImageArray(0))

                If rbNormal.Checked = True Then
                    Orig_bmp = New Bitmap(Image.FromFile(ImageArray(NX)))

                ElseIf rbGrayScale.Checked = True Then
                    Orig_bmp = New Bitmap(Grayscale((Image.FromFile(ImageArray(NX)))))

                ElseIf rbSepiaTone.Checked = True Then
                    Orig_bmp = New Bitmap(Sepia(Image.FromFile(ImageArray(NX))))
                Else
                    ' Orig_bmp = New Bitmap(Dark(Image.FromFile(ImageArray(NX))))

                End If
                Dim x, y As Integer


                If sender Is btn50 Then
                    x = W / 2
                    y = H / 2
                End If

                If sender Is btn33 Then
                    x = W / 3
                    y = H / 3
                End If

                If sender Is btn25 Then
                    x = W / 4
                    y = H / 4
                End If

                If sender Is btn150 Then
                    x = W * 3 / 2
                    y = H * 3 / 2
                End If
                If sender Is btn75 Then
                    x = W * 3 / 4
                    y = H * 3 / 4
                End If
                If sender Is btn200 Then
                    x = W * 2
                    y = H * 2
                End If

                ' Dim Small As New Bitmap(Width, Height)
                Dim Small As New Bitmap(x, y)
                Dim G As Graphics = Graphics.FromImage(Small)

                G.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                G.DrawImage(Orig_bmp, New Rectangle(0, 0, x, y), New Rectangle(0, 0, Orig_bmp.Width, Orig_bmp.Height), GraphicsUnit.Pixel)

                G.Dispose()
                MemPic.Add(Small)

            Next
            Assemble(2)
            pbResult.Image = Image.FromFile(NewName)
            Refresh()
        Catch
            sserror.Show()
            sserror.Text = "Fatal Error (Sammie Suite Exception)"
            sserror.Label1.Text = "No GIF image frames. (Error code: 0000x005)"
        End Try
    End Sub
#End Region
#Region "Help"
    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        sshelpoffline.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ssappabout.Text = "About GIF Studio"
        ssappabout.AppPic.Image = My.Resources.ssGIFStudio
        ssappabout.AppName.Text = "GIF Studio"
        ssappabout.AppVer.Text = "Version 2.4"
        ssappabout.ShowDialog()
    End Sub
#End Region
#Region "Functions"
    Private Sub File_Rename(ByVal OldName As String)
        'Frame3.jpg
        If OldName.Length > 12 Then Exit Sub 'Already processed

        Dim NewFname As String = ""
        Dim Len As Integer
        Dim Ending = OldName.Substring(5)
        Len = Ending.Length
        Try
            Select Case Len

                Case 5
                    NewFname = "Frame000" & Ending
                Case 6
                    NewFname = "Frame00" & Ending
                Case 7
                    NewFname = "Frame0" & Ending
                Case 8
                    NewFname = "Frame" & Ending

            End Select

            My.Computer.FileSystem.RenameFile(OldName, NewFname)
        Catch
            sserror.Show()
            sserror.Label1.Text = "Unable to rename the file."
        End Try


    End Sub

    Public Sub Assemble(ByVal But As Integer)
        Me.Cursor = Cursors.WaitCursor
        'Variable declaration
        Dim memoryStream As MemoryStream
        Dim binaryWriter As BinaryWriter
        Dim image As Image
        Dim buf1 As [Byte]()
        Dim buf2 As [Byte]()
        Dim buf3 As [Byte]()
        memoryStream = New MemoryStream()
        buf2 = New [Byte](18) {}
        buf3 = New [Byte](7) {}
        buf2(0) = 33
        'extension introducer
        buf2(1) = 255
        'application extension
        buf2(2) = 11
        'size of block
        buf2(3) = 78
        'N
        buf2(4) = 69
        'E
        buf2(5) = 84
        'T
        buf2(6) = 83
        'S
        buf2(7) = 67
        'C
        buf2(8) = 65
        'A
        buf2(9) = 80
        'P
        buf2(10) = 69
        'E
        buf2(11) = 50
        '2
        buf2(12) = 46
        '.
        buf2(13) = 48
        '0
        buf2(14) = 3
        'Size of block
        buf2(15) = 1
        '
        buf2(16) = 0
        '
        buf2(17) = 0
        '
        buf2(18) = 0
        'Block terminator
        buf3(0) = 33
        'Extension introducer
        buf3(1) = 249
        'Graphic control extension
        buf3(2) = 4
        'Size of block
        buf3(3) = 9
        'Flags: reserved, disposal method, user input, transparent color
        buf3(4) = 10 ' 88 
        If ckSlide.Checked = True Then
            'Delay time low byte
            buf3(5) = 1
            'Delay time high byte
            buf3(6) = 0
        Else
            'Delay time low byte
            buf3(5) = 0 '1 
            'Delay time high byte
            buf3(6) = 255
        End If

        'Transparent color index
        buf3(7) = 0
        'Block terminator

        NewName = GetNewName1()
        GroupBox3.Text = "Output Animation - " & NewName
        binaryWriter = New BinaryWriter(File.Open(NewName, FileMode.Create))

        For picCount As Integer = 0 To ImageArray.Count - 1 'stringCollection.Count - 1

            Select Case But
                Case 1
                    'Animate
                    image = Bitmap.FromFile(ImageArray(picCount))
                    If ckDark.Checked = True Then image = Dark(image)
                    If rbSepiaTone.Checked = True Then image = Sepia(image)
                    If rbGrayScale.Checked = True Then image = Grayscale(image)
                    If ckGhost.Checked = True Then Ghost(image)
                    If ckFlip.Checked = True Then image.RotateFlip(RotateFlipType.RotateNoneFlipX)
                Case 2
                    If MemPic IsNot Nothing Then
                        image = MemPic(picCount)
                        If ckDark.Checked = True Then image = Dark(image)
                        If rbSepiaTone.Checked = True Then image = Sepia(image)
                        If rbGrayScale.Checked = True Then image = Grayscale(image)
                        If ckGhost.Checked = True Then Ghost(image)
                        If ckFlip.Checked = True Then image.RotateFlip(RotateFlipType.RotateNoneFlipX)
                    Else
                        sserror.Show()
                        sserror.Label1.Text = "The GIF image has not been selected."
                    End If

            End Select
            image.Save(memoryStream, ImageFormat.Gif)
            buf1 = memoryStream.ToArray()

            If picCount = 0 Then
                'only write these the first time....
                binaryWriter.Write(buf1, 0, 781)
                'Header & global color table
                'Application extension
                binaryWriter.Write(buf2, 0, 19)
            End If
            binaryWriter.Write(buf3, 0, 8)
            'Graphic extension
            binaryWriter.Write(buf1, 781, buf1.Length - 782)
            'Image data
            ' If picCount = stringCollection.Count - 1 Then
            If picCount = ImageArray.Count - 1 Then
                'only write this one the last time....
                'Image terminator
                binaryWriter.Write(";")
            End If


            memoryStream.SetLength(0)
            Progress.Value = 100 * picCount / ImageArray.Count
        Next

        binaryWriter.Close()
        pbSelect.Invalidate()
        memoryStream.Close()
        Me.Cursor = Cursors.Default
        pbSelect.Image = image.FromFile(ImageArray(N))
        pbSelect.Refresh()
        Progress.Value = 0
    End Sub

    Public Function GetNewName1() As String
        Dim i As Integer
        Dim str As String = ""
        For i = 1 To 1000
            If i < 10 Then str = "Animation_00" & i.ToString & ".gif"
            If i > 9 And i < 100 Then str = "Animation_0" & i.ToString & ".gif"
            If i > 99 Then str = "Animation_" & i.ToString & ".gif"
            If i > 900 Then sserror.Show()
            sserror.Label1.Text = "You have exceeded the limit of 900 images."
            If Not System.IO.File.Exists(str) Then
                Exit For
            End If
        Next
        Return str
    End Function

    Private Sub scan()
        ImageArray.Clear()
        Try
            Dim di As New IO.DirectoryInfo(Environment.CurrentDirectory)
            Dim aryFi As IO.FileInfo() = di.GetFiles("*.jpg")
            Pictures = aryFi.Count
            Dim fi As IO.FileInfo
            For Each fi In aryFi
                File_Rename(fi.Name)
            Next
            Dim aryFi2 As IO.FileInfo() = di.GetFiles("*.jpg")

            For Each fi In aryFi2
                ImageArray.Add(fi.Name) 'Original jpg Files 

            Next

            If ImageArray IsNot Nothing Then
                ImageArray.Sort()
                If ImageArray(0) IsNot Nothing Then
                    pbSelect.Image = Image.FromFile(ImageArray(0))
                    Im = pbSelect.Image.Clone
                    lblTour.Text = ImageArray(0)
                End If
            End If
        Catch
            sserror.Show()
            sserror.Label1.Text = "No JPEG images are present in the current directory."
        End Try
    End Sub

    Private Function Ghost(ByVal img) As Image
        Dim countx, county As Integer
        Dim Tol As Integer = tbTolerance.Value '30

        Try
            Dim rect As Rectangle = Rectangle.Round(img.GetBounds(GraphicsUnit.Pixel))
            Dim TheWidth As Integer = img.Width
            Dim TheHeight As Integer = img.Height
            Dim bmpSr As BitmapData = img.LockBits(New Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadWrite, img.PixelFormat)

            Dim ptrSr As IntPtr = bmpSr.Scan0
            Dim R, G, B, A, A1, A2, A3, A4 As Integer
            R = 2
            G = 1
            B = 0
            A = 3
            Dim bytesSr As Integer = bmpSr.Stride * img.Height
            Dim rgbvaluesSr(bytesSr) As Byte
            System.Runtime.InteropServices.Marshal.Copy(ptrSr, rgbvaluesSr, 0, bytesSr)
            'For i As Integer = 0 To rgbvaluesSr.Length - 4 Step 4
            For county = 0 To img.Height - 2
                If img.PixelFormat = System.Drawing.Imaging.PixelFormat.Format24bppRgb Then
                    For countx = county * bmpSr.Stride To (county + 1) * bmpSr.Stride - 6 Step 3
                        A1 = CInt(rgbvaluesSr(countx + R)) + CInt(rgbvaluesSr(countx + G)) + CInt(rgbvaluesSr(countx + B))
                        A2 = CInt(rgbvaluesSr(countx + 3 + R)) + CInt(rgbvaluesSr(countx + 3 + G)) + CInt(rgbvaluesSr(countx + 3 + B))
                        A3 = CInt(rgbvaluesSr(countx + R + bmpSr.Stride)) + CInt(rgbvaluesSr(countx + G + bmpSr.Stride)) + CInt(rgbvaluesSr(countx + B + bmpSr.Stride))
                        A4 = CInt(rgbvaluesSr(countx + 3 + R + bmpSr.Stride)) + CInt(rgbvaluesSr(countx + 3 + G + bmpSr.Stride)) + CInt(rgbvaluesSr(countx + 3 + B + bmpSr.Stride))

                        'If (A2 - A1) > Tol Or (A3 - A1) > Tol Or (A4 - A1) > Tol Then
                        If Math.Abs(A2 - A1) > Tol Or Math.Abs(A3 - A1) > Tol Or Math.Abs(A4 - A1) > Tol Then

                            ' Comment Next Lines To Get Color Edges

                            rgbvaluesSr(countx + R) = 0
                            rgbvaluesSr(countx + G) = 0
                            rgbvaluesSr(countx + B) = 0


                        Else
                            rgbvaluesSr(countx + R) = 255
                            rgbvaluesSr(countx + G) = 255
                            rgbvaluesSr(countx + B) = 255

                        End If
                        If countx = (county + 1) * bmpSr.Stride - 6 Then
                            'Dark Line To the Right
                            rgbvaluesSr(countx + R + 4) = 255
                            rgbvaluesSr(countx + G + 4) = 255
                            rgbvaluesSr(countx + B + 4) = 255
                            rgbvaluesSr(countx + R + 8) = 255
                            rgbvaluesSr(countx + G + 8) = 255
                            rgbvaluesSr(countx + B + 8) = 255
                            rgbvaluesSr(countx + R + 12) = 255
                            rgbvaluesSr(countx + G + 12) = 255
                            rgbvaluesSr(countx + B + 12) = 255

                        End If
                    Next countx

                ElseIf img.PixelFormat = System.Drawing.Imaging.PixelFormat.Format32bppArgb Then
                    For countx = county * bmpSr.Stride To (county + 1) * bmpSr.Stride - 8 Step 4
                        A1 = CInt(rgbvaluesSr(countx + R)) + CInt(rgbvaluesSr(countx + G)) + CInt(rgbvaluesSr(countx + B))
                        A2 = CInt(rgbvaluesSr(countx + 4 + R)) + CInt(rgbvaluesSr(countx + 4 + G)) + CInt(rgbvaluesSr(countx + 4 + B))
                        A3 = CInt(rgbvaluesSr(countx + R + bmpSr.Stride)) + CInt(rgbvaluesSr(countx + G + bmpSr.Stride)) + CInt(rgbvaluesSr(countx + B + bmpSr.Stride))
                        A4 = CInt(rgbvaluesSr(countx + 4 + R + bmpSr.Stride)) + CInt(rgbvaluesSr(countx + 4 + G + bmpSr.Stride)) + CInt(rgbvaluesSr(countx + 4 + B + bmpSr.Stride))

                        'If (A2 - A1) > Tol Or (A3 - A1) > Tol Or (A4 - A1) > Tol Then
                        If Math.Abs(A2 - A1) > Tol Or Math.Abs(A3 - A1) > Tol Or Math.Abs(A4 - A1) > Tol Then

                            rgbvaluesSr(countx + A) = 255
                            rgbvaluesSr(countx + R) = 0
                            rgbvaluesSr(countx + G) = 0
                            rgbvaluesSr(countx + B) = 0


                        Else
                            rgbvaluesSr(countx + A) = 255
                            rgbvaluesSr(countx + R) = 255
                            rgbvaluesSr(countx + G) = 255
                            rgbvaluesSr(countx + B) = 255

                        End If
                        If countx = (county + 1) * bmpSr.Stride - 8 Then
                            'Dark Line To the Right
                            rgbvaluesSr(countx + A + 4) = 255
                            rgbvaluesSr(countx + R + 4) = 255
                            rgbvaluesSr(countx + G + 4) = 255
                            rgbvaluesSr(countx + B + 4) = 255
                            rgbvaluesSr(countx + A + 8) = 255
                            rgbvaluesSr(countx + R + 8) = 255
                            rgbvaluesSr(countx + G + 8) = 255
                            rgbvaluesSr(countx + B + 8) = 255
                            rgbvaluesSr(countx + A + 12) = 255
                            rgbvaluesSr(countx + R + 12) = 255
                            rgbvaluesSr(countx + G + 12) = 255
                            rgbvaluesSr(countx + B + 12) = 255

                        End If
                    Next countx
                Else
                    sserror.Show()
                    sserror.Label1.Text = "No JPEG images are present in the current directory."
                End If


            Next county
            System.Runtime.InteropServices.Marshal.Copy(rgbvaluesSr, 0, ptrSr, bytesSr)

            img.UnlockBits(bmpSr)
        Catch
            sserror.Show()
            sserror.Text = "Error"
            sserror.Label1.Text = "An unknown error has occurred. (Error code: 0000x000)"
        End Try
        Return img

    End Function

    Private Sub ckGhost_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckGhost.CheckedChanged
        If ckGhost.Checked = True Then

            tbTolerance.Visible = True
        Else
            tbTolerance.Visible = False
        End If

    End Sub

    Public Shared Function ConvertToRGB(ByVal original As Bitmap) As Bitmap
        Dim newImage As New Bitmap(original.Width, original.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        newImage.SetResolution(original.HorizontalResolution, original.VerticalResolution)
        Dim g As Graphics = Graphics.FromImage(newImage)
        g.DrawImageUnscaled(original, 0, 0)
        g.Dispose()
        Return newImage
    End Function
    Public Function GetNewName(ByVal Prefix As String, ByVal Suffix As String) As String
        Dim i As Integer
        Dim str As String = ""
        For i = 0 To 10000
            If i < 10 Then str = Prefix & "000" & i.ToString & Suffix
            If i > 9 And i < 100 Then str = Prefix & "00" & i.ToString & Suffix
            If i > 99 And i < 1000 Then str = Prefix & "0" & i.ToString & Suffix
            If i > 999 Then str = Prefix & i.ToString & Suffix
            If Not System.IO.File.Exists(str) Then
                Exit For
            End If
        Next
        Return str
    End Function


    Private Function Sepia(ByVal img) As Image
        Dim image_attr As New ImageAttributes
        ' Dim img As Image
        '~29%,57%,14%


        Dim cmy As ColorMatrix = New ColorMatrix(New Single()() _
        { _
        New Single() {0.32645, 0.29305, 0.22633, 0.0, 0.0}, _
        New Single() {0.64149, 0.57594, 0.44491, 0.0, 0.0}, _
        New Single() {0.15752, 0.14144, 0.10929, 0.0, 0.0}, _
        New Single() {0.0, 0.0, 0.0, 1.0, 0.0}, _
        New Single() {0.001, 0.001, 0.001, 0.0, 1.0}})

        Try
            Dim rect As Rectangle = Rectangle.Round(img.GetBounds(GraphicsUnit.Pixel))
            Dim wid As Integer = img.Width
            Dim hgt As Integer = img.Height
            img = ConvertToRGB(img)
            Dim gr As Graphics = Graphics.FromImage(img)
            gr.SmoothingMode = SmoothingMode.HighQuality
            gr.CompositingQuality = CompositingQuality.HighQuality
            gr.InterpolationMode = InterpolationMode.High

            image_attr.SetColorMatrix(cmy)
            gr.DrawImage(img, rect, 0, 0, wid, hgt, GraphicsUnit.Pixel, image_attr)

            Return img
        Catch
            sserror.Show()
            sserror.Text = "Error (Sammy Suite Exception Error 000000x907)"
            sserror.Label1.Text = "An unknown error has occurred. (Error Code: 000000x907)"
        End Try
        Return img

    End Function

    Private Function Grayscale(ByVal img As Image) As Image
        Dim image_Attr As New ImageAttributes

        Dim rL As Single = 0.2225 '0.3086
        Dim gL As Single = 0.7169 '0.0694
        Dim bL As Single = 0.0606 '0.0820


        Dim cmy As ColorMatrix = New ColorMatrix(New Single()() _
            { _
            New Single() {rL, rL, rL, 0, 0}, _
            New Single() {gL, gL, gL, 0, 0}, _
            New Single() {bL, bL, bL, 0, 0}, _
            New Single() {0, 0, 0, 1, 0}, _
            New Single() {0, 0, 0, 0, 0}})
        Try
            Dim rect As Rectangle = Rectangle.Round(img.GetBounds(GraphicsUnit.Pixel))
            Dim wid As Integer = img.Width
            Dim hgt As Integer = img.Height
            img = ConvertToRGB(img)
            Dim gr As Graphics = Graphics.FromImage(img)
            gr.InterpolationMode = InterpolationMode.High
            gr.SmoothingMode = SmoothingMode.HighQuality
            gr.CompositingQuality = CompositingQuality.HighQuality

            image_Attr.SetColorMatrix(cmy)
            gr.DrawImage(img, rect, 0, 0, wid, hgt, GraphicsUnit.Pixel, image_Attr)

            Return img
        Catch
            sserror.Show()
            sserror.Label1.Text = "Unable to make GIF image greyscale."
        End Try
        Return img
    End Function

    Private Function Dark(ByVal img As Image) As Image
        Dim image_Attr As New ImageAttributes
        Dim Tol As Single = CSng(tbIntensity.Value) / 128

        Dim cmy As ColorMatrix = New ColorMatrix(New Single()() _
            { _
            New Single() {Tol, 0, 0, 0, 0}, _
            New Single() {0, Tol, 0, 0, 0}, _
            New Single() {0, 0, Tol, 0, 0}, _
            New Single() {0, 0, 0, 1, 0}, _
            New Single() {0, 0, 0, 0, 1}})
        Try
            Dim rect As Rectangle = Rectangle.Round(img.GetBounds(GraphicsUnit.Pixel))
            Dim wid As Integer = img.Width
            Dim hgt As Integer = img.Height
            img = ConvertToRGB(img)
            Dim gr As Graphics = Graphics.FromImage(img)
            gr.SmoothingMode = SmoothingMode.HighQuality
            gr.CompositingQuality = CompositingQuality.HighQuality
            gr.InterpolationMode = InterpolationMode.High

            image_Attr.SetColorMatrix(cmy)
            gr.DrawImage(img, rect, 0, 0, wid, hgt, GraphicsUnit.Pixel, image_Attr)

            Return img
        Catch
            sserror.Show()
            sserror.Text = "Fatal Error (Sammie Suite Exception)"
            sserror.Label1.Text = "An unknown error has occurred. (Error code: 0000x000)"
        End Try
        Return img
    End Function

    Private Sub Preview()
        Try
            Dim Im As Bitmap
            Im = pbSelect.Image.Clone
            If ckDark.Checked = True Then Im = Dark(Im)
            If rbSepiaTone.Checked = True Then Im = Sepia(Im)
            If rbGrayScale.Checked = True Then Im = Grayscale(Im)
            If ckGhost.Checked = True Then Ghost(Im)
            If ckFlip.Checked = True Then Im.RotateFlip(RotateFlipType.RotateNoneFlipX)
            pbResult.Image = Im
        Catch
            sserror.Show()
            sserror.Text = "Fatal Error (Sammie Suite Exception)"
            sserror.Label1.Text = "No GIF image frames. (Error code: 0000x005)"
        End Try
    End Sub

    Private Sub LoadImages()
        Try
            If ImageArray Is Nothing Then
                Return
            End If

            If Me.WindowState = FormWindowState.Minimized Then
                Return
            End If
            Me.Cursor = Cursors.WaitCursor
            dataVImages.Rows.Clear()
            dataVImages.Columns.Clear()

            Dim ColumnsThatFit As Integer = (dataVImages.Width - 10) / (_imageSize + 25)
            Dim numRows As Integer = 0

            Dim ImagesToDisplay As Integer = ImageArray.Count

            numRows = CInt(Math.Ceiling(CDbl(ImageArray.Count) / CDbl(ColumnsThatFit)))

            Dim CellsForPictureNumber As Integer = numRows * ColumnsThatFit
            '  MessageBox.Show(ColumnsThatFit.ToString & "," & numRows.ToString & "," & CellsForPictureNumber.ToString)
            ' Dynamically create the columns
            For index As Integer = 0 To ColumnsThatFit - 1
                Dim dataGridViewColumn As New DataGridViewImageColumn()

                dataVImages.Columns.Add(dataGridViewColumn)
                dataVImages.Columns(index).Width = _imageSize + 20
            Next

            ' Create the rows

            For index As Integer = 0 To numRows - 1
                dataVImages.Rows.Add()
                dataVImages.Rows(index).Height = _imageSize + 20
            Next

            Dim columnIndex As Integer = 0
            Dim rowIndex As Integer = 0

            For index As Integer = 0 To (ImagesToDisplay - 1)
                ' Load the image from the file and add to the DataGridView
                Dim image As Image = Helper.ResizeImage(ImageArray(index), _imageSize, _imageSize, False)
                dataVImages.Rows(rowIndex).Cells(columnIndex).Value = image
                dataVImages.Rows(rowIndex).Cells(columnIndex).ToolTipText = "Frame-" & index.ToString & ": " & Path.GetFileName(ImageArray(index)) & " " & GetImageWidth(ImageArray(index)) & "x" & GetImageHeight(ImageArray(index))

                ' Have we reached the end column? if so then start on the next row
                If columnIndex = ColumnsThatFit - 1 Then
                    rowIndex += 1
                    columnIndex = 0
                Else
                    columnIndex += 1
                End If
            Next
            ' Blank the unused cells
            If CellsForPictureNumber > ImagesToDisplay Then
                For index As Integer = 0 To CellsForPictureNumber - ImagesToDisplay - 1
                    Dim dataGridViewCellStyle As New DataGridViewCellStyle()
                    dataGridViewCellStyle.NullValue = Nothing
                    dataGridViewCellStyle.Tag = "BLANK"
                    dataVImages.Rows(rowIndex).Cells(columnIndex + index).Style = dataGridViewCellStyle
                Next
            End If
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Function GetImageHeight(ByRef file As String) As Integer
        Using image As System.Drawing.Image = System.Drawing.Image.FromFile(file)
            Return image.Height
        End Using
    End Function

    Private Function GetImageWidth(ByRef file As String) As Integer
        Using image As System.Drawing.Image = System.Drawing.Image.FromFile(file)
            Return image.Width
        End Using
    End Function

    Private Sub Hilite()
        Dim rcol, rrow As Integer
        rcol = N Mod dataVImages.Columns.Count
        '  rrow = N / dataVImages.Columns.Count
        rrow = CInt(Math.Ceiling(CDbl(N + 1) / CDbl(dataVImages.Columns.Count))) - 1
        dataVImages.CurrentCell = dataVImages(rcol, rrow)
        dataVImages.BeginEdit(True)

        '   MessageBox.Show("Col " & rcol.ToString & "  Row " & rrow.ToString)
    End Sub

    Private Sub dataVImages_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataVImages.CellClick
        'Select Frame By Using Mouse
        Dim i, j As Integer
        i = e.RowIndex
        j = e.ColumnIndex
        Position = i * dataVImages.Columns.Count + j ' + 1  'index of imagearray
        If Position > ImageArray.Count - 1 Then Exit Sub
        pbSelect.Image = Image.FromFile(ImageArray(Position))
        lblTour.Text = ImageArray(Position) & vbNewLine & "Image(" & Position & ")"
        N = Position
        Refresh()
    End Sub

    Private Sub dataVImages_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataVImages.CellEnter
        'Select Frame By Using Arrows
        Dim i, j As Integer
        i = e.RowIndex
        j = e.ColumnIndex
        Position = i * dataVImages.Columns.Count + j ' + 1  'index of imagearray
        If Position > ImageArray.Count - 1 Then Exit Sub
        pbSelect.Image = Image.FromFile(ImageArray(Position))
        lblTour.Text = ImageArray(Position) & vbNewLine & "Image(" & Position & ")"
        N = Position
        Refresh()
    End Sub
#End Region
#Region "Other"
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sstasklist.GIFStudioButton.Hide()
    End Sub
#End Region

    Private Sub ReverseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReverseToolStripMenuItem.Click
        Try
            ImageArray.Reverse()
            Assemble(1)
            pbResult.Image = Image.FromFile(NewName)
        Catch
            sserror.Show()
            sserror.Text = "Fatal Error (Sammie Suite Exception)"
            sserror.Label1.Text = "No GIF image frames. (Error code: 0000x005)"
        End Try
    End Sub

    Private Sub PreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviewToolStripMenuItem.Click

    End Sub
End Class