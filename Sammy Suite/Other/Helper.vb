Imports System
Imports System.Drawing
Public NotInheritable Class Helper
    Private Sub New()
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="file"></param>
    ''' <param name="width"></param>
    ''' <param name="height"></param>
    ''' <param name="onlyResizeIfWider"></param>
    ''' <returns></returns>
    Public Shared Function ResizeImage(ByVal file As String, ByVal width As Integer, ByVal height As Integer, ByVal onlyResizeIfWider As Boolean) As Image
        Using image__1 As Image = Image.FromFile(file)
            ' Prevent using images internal thumbnail
            image__1.RotateFlip(RotateFlipType.Rotate180FlipNone)
            image__1.RotateFlip(RotateFlipType.Rotate180FlipNone)

            If onlyResizeIfWider = True Then
                If image__1.Width <= width Then
                    width = image__1.Width
                End If
            End If

            Dim newHeight As Integer = image__1.Height * width / image__1.Width
            If newHeight > height Then
                ' Resize with height instead
                width = image__1.Width * height / image__1.Height
                newHeight = height
            End If

            Dim NewImage As Image = image__1.GetThumbnailImage(width, newHeight, Nothing, IntPtr.Zero)

            Return NewImage
        End Using
    End Function
End Class
