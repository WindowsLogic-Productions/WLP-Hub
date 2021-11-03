Public Class ssskype
#Region "Load Settings"
    Private Sub ssskype_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        sstasklist.SkypeButton.Show()
    End Sub
#End Region
#Region "Other"
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sstasklist.SkypeButton.Hide()
    End Sub
#End Region
End Class