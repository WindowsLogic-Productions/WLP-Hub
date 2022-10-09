Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class sssketchpad
#Region "Global"
    Dim Reload As Image
    Dim bmx As Bitmap
    Dim resized As Bitmap
    Dim ErasePen As New Pen(Color.White, 4)
    Dim gr As Graphics
    Dim FirstTime As Boolean = True
    'initial Colors
    Dim Color1, Color2, Color3, Color4, Color5, Color6, Color7, Color8, Color9 As Color
    Dim Color1a, Color2a, Color3a, Color4a, Color5a, Color6a, Color7a, Color8a, Color9a As Color
    Dim SmudgeWidth As Integer = 3
    'arrays of points
    Private ThePts1(2), ThePts2(2), ThePts3(2), ThePts4(2), ThePts5(2), ThePts6(2), ThePts7(2), ThePts8(2), ThePts9(2) As Point


    ' Private 1 As Integer
#End Region
#Region "Initial Values"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sstasklist.SketchPadButton.Show()
        Dim items(Me.ImageList1.Images.Count - 1) As String
        For i As Int32 = 0 To Me.ImageList1.Images.Count - 1
            items(i) = "Item " & i.ToString
        Next
        ComboBox1.Items.AddRange(items)
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.DrawMode = DrawMode.OwnerDrawVariable
        ComboBox1.ItemHeight = Me.ImageList1.ImageSize.Height
        ComboBox1.Width = Me.ImageList1.ImageSize.Width + 18
        ComboBox1.MaxDropDownItems = Me.ImageList1.Images.Count
        ComboBox1.SelectedIndex = 2

        Reload = PictureBox1.Image.Clone
        Color1a = Color.Black
        Color2a = Color.Olive
        Color3a = Color.Purple
        Color4a = Color.Teal
        Color5a = Color.LawnGreen
        Color6a = Color.LightCoral
        Color7a = Color.Red
        Color8a = Color.DodgerBlue
        Color9a = Color.Firebrick

        Label1.BackColor = Color1a
        Label2.BackColor = Color2a
        Label3.BackColor = Color3a
        Label4.BackColor = Color4a
        Label5.BackColor = Color5a
        Label6.BackColor = Color6a
        Label7.BackColor = Color7a
        Label8.BackColor = Color8a
        Label9.BackColor = Color9a
        Rb5.Checked = True

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
            MenuStrip2.BackColor = My.Settings.CustomColour
        End If
    End Sub


#Region "Paint Images On ComboBox"

    Private Sub ComboBox1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ComboBox1.DrawItem
        If e.Index <> -1 Then
            e.Graphics.DrawImage(Me.ImageList1.Images(e.Index), e.Bounds.Left, e.Bounds.Top)
        End If
    End Sub

    Private Sub ComboBox1_DrawItem1(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) 'Handles ComboBox1.DrawItem

        If e.Index <> -1 Then
            e.Graphics.DrawImage(Me.ImageList1.Images(e.Index), e.Bounds.Left, e.Bounds.Top)
            e.Graphics.DrawString(ComboBox1.Items(e.Index).ToString(), ComboBox1.Font,
            System.Drawing.Brushes.Black,
            New RectangleF(e.Bounds.X + 15, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))
            e.DrawFocusRectangle()
        End If
    End Sub



    Private Sub ComboBox1_MeasureItem(ByVal sender As Object, ByVal e As System.Windows.Forms.MeasureItemEventArgs) Handles ComboBox1.MeasureItem
        e.ItemHeight = Me.ImageList1.ImageSize.Height
        e.ItemWidth = Me.ImageList1.ImageSize.Width
    End Sub

#End Region

#End Region
#Region "First Points"
    Private Sub Work_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        'Initial points and initial Colors
        bmx = New Bitmap(PictureBox1.Image)

        ThePts1(0).X = e.X
        ThePts4(0).X = e.X
        ThePts5(0).X = e.X
        ThePts7(0).X = e.X
        ThePts8(0).X = e.X
        ' Save the new points 
        If e.X < 4 Then
            ThePts2(0).X = e.X
        Else
            ThePts2(0).X = e.X - 2 * SmudgeWidth
        End If
        If e.X < 2 Then
            ThePts6(0).X = e.X
        Else
            ThePts6(0).X = e.X - SmudgeWidth
        End If
        If e.X > PictureBox1.Width - 2 * SmudgeWidth Then
            ThePts3(0).X = e.X
        Else
            ThePts3(0).X = e.X + 2 * SmudgeWidth
        End If
        If e.X > PictureBox1.Width - SmudgeWidth Then
            ThePts9(0).X = e.X
        Else
            ThePts9(0).X = e.X + SmudgeWidth

        End If
        ThePts1(0).Y = e.Y
        ThePts2(0).Y = e.Y
        ThePts3(0).Y = e.Y
        ThePts6(0).Y = e.Y
        ThePts9(0).Y = e.Y
        If e.Y < 4 Then
            ThePts4(0).Y = e.Y
        Else
            ThePts4(0).Y = e.Y - 2 * SmudgeWidth
        End If
        If e.Y < 2 Then
            ThePts7(0).Y = e.Y
        Else
            ThePts7(0).Y = e.Y - SmudgeWidth
        End If

        If e.Y > PictureBox1.Height - 2 * SmudgeWidth Then
            ThePts5(0).Y = e.Y
        Else
            ThePts5(0).Y = e.Y + 2 * SmudgeWidth
        End If
        If e.Y > PictureBox1.Height - 2 * SmudgeWidth Then
            ThePts8(0).Y = e.Y
        Else
            ThePts8(0).Y = e.Y + SmudgeWidth
        End If

        Try
            If Rb5.Checked = False Then
                Color1a = bmx.GetPixel(ThePts1(0).X, ThePts1(0).Y)
                Color2a = bmx.GetPixel(ThePts2(0).X, ThePts2(0).Y)
                Color3a = bmx.GetPixel(ThePts3(0).X, ThePts3(0).Y)
                Color4a = bmx.GetPixel(ThePts4(0).X, ThePts4(0).Y)
                Color5a = bmx.GetPixel(ThePts5(0).X, ThePts5(0).Y)
                Color6a = bmx.GetPixel(ThePts6(0).X, ThePts6(0).Y)
                Color7a = bmx.GetPixel(ThePts7(0).X, ThePts7(0).Y)
                Color8a = bmx.GetPixel(ThePts8(0).X, ThePts8(0).Y)
                Color9a = bmx.GetPixel(ThePts9(0).X, ThePts9(0).Y)
            End If
            Color1 = Color1a
            Color2 = Color2a
            Color3 = Color3a
            Color4 = Color4a
            Color5 = Color5a
            Color6 = Color6a
            Color7 = Color7a
            Color8 = Color8a
            Color9 = Color9a

        Catch
        End Try
    End Sub
#End Region
#Region "While Moving"
#Region "Operation"

    Private Sub Rb5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb5.CheckedChanged

        If Rb5.Checked = True Then
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True

        Else
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False

        End If
        If FirstTime = True Then
            Label1.BackColor = Color1a
            Label2.BackColor = Color2a
            Label3.BackColor = Color3a
            Label4.BackColor = Color4a
            Label5.BackColor = Color5a
            Label6.BackColor = Color6a
            Label7.BackColor = Color7a
            Label8.BackColor = Color8a
            Label9.BackColor = Color9a

        Else
            Label1.BackColor = Color1
            Label2.BackColor = Color2
            Label3.BackColor = Color3
            Label4.BackColor = Color4
            Label5.BackColor = Color5
            Label6.BackColor = Color6
            Label7.BackColor = Color7
            Label8.BackColor = Color8
            Label9.BackColor = Color9

        End If
        Refresh()
        FirstTime = False
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PictureBox1.Image = Reload.Clone

    End Sub

#End Region
#Region "Drawing"
    Private Sub Work_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        Dim bmx As New Bitmap(PictureBox1.Image)

        If (e.Button = MouseButtons.Left) Then
            ' Do nothing if we're not selecting a region.
            If ThePts1 Is Nothing Then Exit Sub
            Try
                ThePts1(1).X = e.X
                ThePts4(1).X = e.X
                ThePts5(1).X = e.X
                ThePts7(1).X = e.X
                ThePts8(1).X = e.X
                ' Save the new points 
                If e.X < 4 Then
                    ThePts2(1).X = e.X
                Else
                    ThePts2(1).X = e.X - 2 * SmudgeWidth
                End If
                If e.X < 2 Then
                    ThePts6(1).X = e.X
                Else
                    ThePts6(1).X = e.X - SmudgeWidth
                End If
                If e.X > PictureBox1.Width - 2 * SmudgeWidth Then
                    ThePts3(1).X = e.X
                Else
                    ThePts3(1).X = e.X + 2 * SmudgeWidth
                End If
                If e.X > PictureBox1.Width - SmudgeWidth Then
                    ThePts9(1).X = e.X
                Else
                    ThePts9(1).X = e.X + SmudgeWidth

                End If
                ThePts1(1).Y = e.Y
                ThePts2(1).Y = e.Y
                ThePts3(1).Y = e.Y
                ThePts6(1).Y = e.Y
                ThePts9(1).Y = e.Y
                If e.Y < 4 Then
                    ThePts4(1).Y = e.Y
                Else
                    ThePts4(1).Y = e.Y - 2 * SmudgeWidth
                End If
                If e.Y < 2 Then
                    ThePts7(1).Y = e.Y
                Else
                    ThePts7(1).Y = e.Y - SmudgeWidth
                End If

                If e.Y > PictureBox1.Height - 2 * SmudgeWidth Then
                    ThePts5(1).Y = e.Y
                Else
                    ThePts5(1).Y = e.Y + 2 * SmudgeWidth
                End If
                If e.Y > PictureBox1.Height - 2 * SmudgeWidth Then
                    ThePts8(1).Y = e.Y
                Else
                    ThePts8(1).Y = e.Y + SmudgeWidth
                End If

                'create a pen object to draw the lines
                Dim MyPen1 As New Pen(Color1, SmudgeWidth)
                Dim MyPen2 As New Pen(Color2, SmudgeWidth)
                Dim MyPen3 As New Pen(Color3, SmudgeWidth)
                Dim MyPen4 As New Pen(Color4, SmudgeWidth)
                Dim MyPen5 As New Pen(Color5, SmudgeWidth)
                Dim MyPen6 As New Pen(Color6, SmudgeWidth)
                Dim MyPen7 As New Pen(Color7, SmudgeWidth)
                Dim MyPen8 As New Pen(Color8, SmudgeWidth)
                Dim MyPen9 As New Pen(Color9, SmudgeWidth)


                'Draw last segment
                Dim g As Graphics = Graphics.FromImage(bmx)
                If Rb2.Checked = True Then
                    ' bmx = New Bitmap(Work.Image)

                    Color1a = bmx.GetPixel(ThePts1(1).X, ThePts1(1).Y)
                    Color2a = bmx.GetPixel(ThePts2(1).X, ThePts2(1).Y)
                    Color3a = bmx.GetPixel(ThePts3(1).X, ThePts3(1).Y)
                    Color4a = bmx.GetPixel(ThePts4(1).X, ThePts4(1).Y)
                    Color5a = bmx.GetPixel(ThePts5(1).X, ThePts5(1).Y)
                    Color6a = bmx.GetPixel(ThePts6(1).X, ThePts6(1).Y)
                    Color7a = bmx.GetPixel(ThePts7(1).X, ThePts7(1).Y)
                    Color8a = bmx.GetPixel(ThePts8(1).X, ThePts8(1).Y)
                    Color9a = bmx.GetPixel(ThePts9(1).X, ThePts9(1).Y)
                Else
                    Color1a = Color1
                    Color2a = Color2
                    Color3a = Color3
                    Color4a = Color4
                    Color5a = Color5
                    Color6a = Color6
                    Color7a = Color7
                    Color8a = Color8
                    Color9a = Color9

                End If
                If Rb5.Checked = True Then
                    If CheckBox1.Checked = True Then
                        g.DrawLine(MyPen1, ThePts1(0).X, ThePts1(0).Y, ThePts1(1).X, ThePts1(1).Y)
                        g.DrawLine(MyPen2, ThePts2(0).X, ThePts2(0).Y, ThePts2(1).X, ThePts2(1).Y)
                        g.DrawLine(MyPen3, ThePts3(0).X, ThePts3(0).Y, ThePts3(1).X, ThePts3(1).Y)
                        g.DrawLine(MyPen4, ThePts4(0).X, ThePts4(0).Y, ThePts4(1).X, ThePts4(1).Y)
                        g.DrawLine(MyPen5, ThePts5(0).X, ThePts5(0).Y, ThePts5(1).X, ThePts5(1).Y)
                        g.DrawLine(MyPen6, ThePts6(0).X, ThePts6(0).Y, ThePts6(1).X, ThePts6(1).Y)
                        g.DrawLine(MyPen7, ThePts7(0).X, ThePts7(0).Y, ThePts7(1).X, ThePts7(1).Y)
                        g.DrawLine(MyPen8, ThePts8(0).X, ThePts8(0).Y, ThePts8(1).X, ThePts8(1).Y)
                        g.DrawLine(MyPen9, ThePts9(0).X, ThePts9(0).Y, ThePts9(1).X, ThePts9(1).Y)
                    ElseIf CheckBox2.Checked = True Then
                        g.DrawLine(MyPen1, ThePts1(0).X, ThePts1(0).Y, ThePts1(1).X, ThePts1(1).Y)
                        g.DrawLine(MyPen4, ThePts4(0).X, ThePts4(0).Y, ThePts4(1).X, ThePts4(1).Y)
                        g.DrawLine(MyPen5, ThePts5(0).X, ThePts5(0).Y, ThePts5(1).X, ThePts5(1).Y)
                        g.DrawLine(MyPen7, ThePts7(0).X, ThePts7(0).Y, ThePts7(1).X, ThePts7(1).Y)
                        g.DrawLine(MyPen8, ThePts8(0).X, ThePts8(0).Y, ThePts8(1).X, ThePts8(1).Y)
                    ElseIf CheckBox3.Checked = True Then
                        g.DrawLine(MyPen1, ThePts1(0).X, ThePts1(0).Y, ThePts1(1).X, ThePts1(1).Y)
                        g.DrawLine(MyPen2, ThePts2(0).X, ThePts2(0).Y, ThePts2(1).X, ThePts2(1).Y)
                        g.DrawLine(MyPen3, ThePts3(0).X, ThePts3(0).Y, ThePts3(1).X, ThePts3(1).Y)
                        g.DrawLine(MyPen6, ThePts6(0).X, ThePts6(0).Y, ThePts6(1).X, ThePts6(1).Y)
                        g.DrawLine(MyPen9, ThePts9(0).X, ThePts9(0).Y, ThePts9(1).X, ThePts9(1).Y)

                    End If
                ElseIf Rb4.Checked = True Then
                    g.DrawLine(ErasePen, ThePts1(0).X, ThePts1(0).Y, ThePts1(1).X, ThePts1(1).Y)
                    g.DrawLine(ErasePen, ThePts2(0).X, ThePts2(0).Y, ThePts2(1).X, ThePts2(1).Y)
                    g.DrawLine(ErasePen, ThePts3(0).X, ThePts3(0).Y, ThePts3(1).X, ThePts3(1).Y)
                    g.DrawLine(ErasePen, ThePts4(0).X, ThePts4(0).Y, ThePts4(1).X, ThePts4(1).Y)
                    g.DrawLine(ErasePen, ThePts5(0).X, ThePts5(0).Y, ThePts5(1).X, ThePts5(1).Y)
                    g.DrawLine(ErasePen, ThePts6(0).X, ThePts6(0).Y, ThePts6(1).X, ThePts6(1).Y)
                    g.DrawLine(ErasePen, ThePts7(0).X, ThePts7(0).Y, ThePts7(1).X, ThePts7(1).Y)
                    g.DrawLine(ErasePen, ThePts8(0).X, ThePts8(0).Y, ThePts8(1).X, ThePts8(1).Y)
                    g.DrawLine(ErasePen, ThePts9(0).X, ThePts9(0).Y, ThePts9(1).X, ThePts9(1).Y)

                Else
                    g.DrawLine(MyPen1, ThePts1(0).X, ThePts1(0).Y, ThePts1(1).X, ThePts1(1).Y)
                    g.DrawLine(MyPen2, ThePts2(0).X, ThePts2(0).Y, ThePts2(1).X, ThePts2(1).Y)
                    g.DrawLine(MyPen3, ThePts3(0).X, ThePts3(0).Y, ThePts3(1).X, ThePts3(1).Y)
                    g.DrawLine(MyPen4, ThePts4(0).X, ThePts4(0).Y, ThePts4(1).X, ThePts4(1).Y)
                    g.DrawLine(MyPen5, ThePts5(0).X, ThePts5(0).Y, ThePts5(1).X, ThePts5(1).Y)
                    g.DrawLine(MyPen6, ThePts6(0).X, ThePts6(0).Y, ThePts6(1).X, ThePts6(1).Y)
                    g.DrawLine(MyPen7, ThePts7(0).X, ThePts7(0).Y, ThePts7(1).X, ThePts7(1).Y)
                    g.DrawLine(MyPen8, ThePts8(0).X, ThePts8(0).Y, ThePts8(1).X, ThePts8(1).Y)
                    g.DrawLine(MyPen9, ThePts9(0).X, ThePts9(0).Y, ThePts9(1).X, ThePts9(1).Y)

                End If
                'Make Changes permanent
                PictureBox1.Image = bmx.Clone

                'Make 2nd points first points

                ThePts1(0) = ThePts1(1)
                ThePts2(0) = ThePts2(1)
                ThePts3(0) = ThePts3(1)
                ThePts4(0) = ThePts4(1)
                ThePts5(0) = ThePts5(1)
                ThePts6(0) = ThePts6(1)
                ThePts7(0) = ThePts7(1)
                ThePts8(0) = ThePts8(1)
                ThePts9(0) = ThePts9(1)


                Color1 = Color1a
                Color2 = Color2a
                Color3 = Color3a
                Color4 = Color4a
                Color5 = Color5a
                Color6 = Color6a
                Color7 = Color7a
                Color8 = Color8a
                Color9 = Color9a

            Catch
            End Try
        End If


    End Sub


#End Region
#End Region
#Region "Visual Settings"
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            Label9.Visible = True


        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Checked = False
            CheckBox3.Checked = False
            Label1.Visible = True
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = True
            Label5.Visible = True
            Label6.Visible = False
            Label7.Visible = True
            Label8.Visible = True
            Label9.Visible = False

        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = False
            Label5.Visible = False
            Label6.Visible = True
            Label7.Visible = False
            Label8.Visible = False
            Label9.Visible = True

        End If

    End Sub

#End Region
#Region "Change Settings"
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                SmudgeWidth = 1
            Case 1
                SmudgeWidth = 2
            Case 2
                SmudgeWidth = 3
            Case 3
                SmudgeWidth = 4
            Case 4
                SmudgeWidth = 5
        End Select
    End Sub



    Private Sub pbPicker_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbPicker.MouseClick
        Static times As Integer = 0
        Try
            Dim bmx1 As Bitmap
            bmx1 = New Bitmap(pbPicker.Image)

            Select Case times Mod 9

                Case 0
                    Color1a = bmx1.GetPixel(e.X, e.Y)
                Case 1
                    Color2a = bmx1.GetPixel(e.X, e.Y)
                Case 2
                    Color3a = bmx1.GetPixel(e.X, e.Y)
                Case 3
                    Color4a = bmx1.GetPixel(e.X, e.Y)
                Case 4
                    Color5a = bmx1.GetPixel(e.X, e.Y)
                Case 5
                    Color6a = bmx1.GetPixel(e.X, e.Y)
                Case 6
                    Color7a = bmx1.GetPixel(e.X, e.Y)
                Case 7
                    Color8a = bmx1.GetPixel(e.X, e.Y)
                Case 8
                    Color9a = bmx1.GetPixel(e.X, e.Y)
            End Select
            Label1.BackColor = Color1a
            Label2.BackColor = Color2a
            Label3.BackColor = Color3a
            Label4.BackColor = Color4a
            Label5.BackColor = Color5a
            Label6.BackColor = Color6a
            Label7.BackColor = Color7a
            Label8.BackColor = Color8a
            Label9.BackColor = Color9a

            times += 1
        Catch
        End Try
    End Sub
#End Region
#Region "Stamp WaterMark"

    Function generateThumbnail(ByVal bmp As Bitmap, ByVal newWidth As Integer) As Image
        Dim newHeight As Integer

        newHeight = (newWidth / bmp.Width) * bmp.Height
        resized = New Bitmap(newWidth, newHeight)
        Dim gx As Graphics = Graphics.FromImage(resized)
        gx.SmoothingMode = SmoothingMode.HighQuality
        gx.CompositingQuality = CompositingQuality.HighQuality
        gx.InterpolationMode = InterpolationMode.High
        gx.DrawImage(bmp, New Rectangle(0, 0, resized.Width, resized.Height), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel)
        gx.Dispose()
        Return resized
        '        bmp.Dispose()
    End Function

    ' Copy the watermark image over the result image.
    Private Sub DrawWatermark(ByVal watermark_bm As Bitmap,
        ByVal result_bm As Bitmap, ByVal x As Integer, ByVal y As Integer)

        Dim ALPHA As Byte = tbTransparency.Value '255 '150
        ' Set the watermark's pixels' Alpha components.
        Dim clr As Color
        For py As Integer = 0 To watermark_bm.Height - 1
            For px As Integer = 0 To watermark_bm.Width - 1
                clr = watermark_bm.GetPixel(px, py)
                watermark_bm.SetPixel(px, py, Color.FromArgb(ALPHA, clr.R, clr.G, clr.B))
            Next px
        Next py
        ' watermark_bm.MakeTransparent(watermark_bm.GetPixel(2, 2))

        ' Copy onto the result image.
        Dim gr As Graphics = Graphics.FromImage(result_bm)
        gr.DrawImage(watermark_bm, x, y)
    End Sub

#End Region
#Region "Rotate"
    Private Sub FlipRotate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlipHorizontallyToolStripMenuItem.Click, FlipVerticalToolStripMenuItem.Click, Flip90DegressRightToolStripMenuItem.Click, Flip90DegreesLeftToolStripMenuItem.Click

        ' resultingt bitmap.
        Dim bmrotate As New Bitmap(PictureBox1.Image)

        If sender Is FlipHorizontallyToolStripMenuItem Then bmrotate.RotateFlip(RotateFlipType.RotateNoneFlipX)
        If sender Is FlipVerticalToolStripMenuItem Then bmrotate.RotateFlip(RotateFlipType.RotateNoneFlipY)
        If sender Is Flip90DegressRightToolStripMenuItem Then bmrotate.RotateFlip(RotateFlipType.Rotate90FlipNone)
        If sender Is Flip90DegreesLeftToolStripMenuItem Then bmrotate.RotateFlip(RotateFlipType.Rotate270FlipNone)
        PictureBox1.Image = bmrotate

    End Sub
#End Region
#Region "Save Drawing"
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Saveas As New SaveFileDialog()
        Saveas.Filter = "Bitmap (*.bmp)|*.bmp"
        Saveas.CheckPathExists = True
        Saveas.Title = "Save as..."
        Saveas.ShowDialog(Me)
    End Sub
#End Region
#Region "Other"
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sstasklist.SketchPadButton.Hide()
    End Sub
#End Region
#Region "Menu Bar"
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim sketch As New sssketchpad
        sketch.Show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.Filter = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff|" + "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim Saveas As New SaveFileDialog()
        Saveas.Filter = "Bitmap (*.bmp)|*.bmp"
        Saveas.CheckPathExists = True
        Saveas.Title = "Save as..."

        If Saveas.ShowDialog(Me) = DialogResult.OK Then
            PictureBox1.Image.Save(Saveas.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ClearCavasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearCavasToolStripMenuItem.Click
        PictureBox1.Image = Reload.Clone
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        ssappabout.Text = "About Sketch Pad"
        ssappabout.AppPic.Image = My.Resources.ssSketchPad
        ssappabout.AppName.Text = "Sketch Pad"
        ssappabout.AppVer.Text = "Version 3.2"
        ssappabout.ShowDialog()
    End Sub
#End Region
#Region "Updates"
    Public Sub CheckForUpdates()

        If My.Settings.Updates = 1 Then
            Try
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://dl.dropboxusercontent.com/u/93134108/Update%20Repo/SS/SS.txt")
                Dim response As System.Net.HttpWebResponse = request.GetResponse()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                Dim newestversion As String = sr.ReadToEnd()
                Dim currentversion As String = Application.ProductVersion
                If newestversion.Contains(currentversion) Then
                Else
                    ssupdateprompt.Show()
                End If
            Catch
                sserror.Show()
                sserror.Label1.Text = "No connection to the update server."
            End Try
        End If

        If My.Settings.Updates = 0 Then

        End If
    End Sub
#End Region
End Class
