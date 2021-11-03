Public Class sschat

    Private Sub sschat_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        sssc.Button14.Show()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sssc.Button14.Hide()
    End Sub
End Class