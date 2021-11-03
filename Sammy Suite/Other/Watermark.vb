Imports System.ComponentModel

Public Class Watermark
    Inherits TextBox

    'Declare variables.
    Dim Watermark As String
    Dim Watermarkcolour As Color
    Dim Watermarkfont As Font
    Dim Watermarkbrush As SolidBrush
    Dim Watermarkcontainer As Panel

    Public Sub New()
        MyBase.new()
        StartProcess()
    End Sub

    Private Sub StartProcess()
        'Declare variable values.
        Watermark = "Default"
        Watermarkcolour = Color.Gray
        Watermarkfont = New Font(Me.font, FontStyle.Italic)
        Watermarkbrush = New SolidBrush(Watermarkcolour)

        Createwatermark()

        AddHandler TextChanged, AddressOf Changetext
        AddHandler FontChanged, AddressOf Changefont
    End Sub

    Private Sub Createwatermark()
        Watermarkcontainer = New Panel
        Me.Controls.Add(Watermarkcontainer)
        AddHandler Watermarkcontainer.Click, AddressOf Clicked
        AddHandler Watermarkcontainer.Paint, AddressOf Painted
    End Sub

    Private Sub Removewatermark()
        Me.Controls.Remove(Watermarkcontainer)
    End Sub

    Private Sub Changetext(sender As Object, e As EventArgs)
        If Me.TextLength <= 0 Then
            Createwatermark()
        ElseIf Me.TextLength > 0 Then
            Removewatermark()
        End If
    End Sub

    Private Sub Changefont(sender As Object, e As EventArgs)
        Watermarkfont = New Font(Me.Font, FontStyle.Italic)
    End Sub

    Private Sub Clicked(sender As Object, e As EventArgs)
        Me.Focus()
    End Sub

    Private Sub Painted(sender As Object, e As PaintEventArgs)
        Watermarkcontainer.Location = New Point(2, 0)
        Watermarkcontainer.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Watermarkcontainer.Height = Me.Height
        Watermarkcontainer.Width = Me.Width
        Watermarkbrush = New SolidBrush(Watermarkcolour)

        Dim Graphic As Graphics = e.Graphics
        Graphic.DrawString(Watermark, Watermarkfont, Watermarkbrush, New PointF(-2.0!, 1.0!))
    End Sub

    Protected Overrides Sub OnInvalidated(e As System.Windows.Forms.InvalidateEventArgs)
        MyBase.OnInvalidated(e)
        Watermarkcontainer.Invalidate()
    End Sub

    <Category("Watermark attributes"), Description("Set watermark text")> Public Property Watermarktext As String
        Get
            Return Watermark
        End Get
        Set(value As String)
            Watermark = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Watermark attributes"), Description("Set watermark colour")> Public Property markcolour As Color
        Get
            Return Watermarkcolour
        End Get
        Set(value As Color)
            Watermarkcolour = value
            Me.Invalidate()
        End Set
    End Property
End Class
