Public Class ssrun

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ofd As New OpenFileDialog
        ofd.ShowDialog()
        TextBox1.Text = ofd.FileName
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Process.Start(TextBox1.Text)
        Catch ex As Exception
            sserror.Show()
        End Try
    End Sub

    Private Sub Textbox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Textbox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Process.Start(TextBox1.Text)
            Catch ex As Exception
                sserror.Show()
            End Try
        End If
    End Sub

    Private Sub ssrun_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class