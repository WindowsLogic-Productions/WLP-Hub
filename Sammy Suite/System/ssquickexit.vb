Public Class ssquickexit
#Region "Disable Close Button"
    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property
#End Region
#Region "Load Settings"
    Private Sub ssquickexit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
#Region "Other"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YesButton.Click
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoButton.Click
        sssecuritybackground.Close()
        Me.Close()
    End Sub
#End Region
End Class