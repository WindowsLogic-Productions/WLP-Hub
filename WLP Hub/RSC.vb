Public Class RSC

    Private Sub RSC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = ProgressBar1.Value.ToString + "%"
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Me.Close()
            System_Controls.Show()
        End If
    End Sub
End Class