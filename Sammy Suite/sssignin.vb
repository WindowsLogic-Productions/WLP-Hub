Public Class sssignin

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ssregister1.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.Username And
            TextBox2.Text = My.Settings.Password Then
            ssmain.Show()
            ssscload.Show()
            Me.Close()
        Else
            MsgBox("Incorrect username or password.", MsgBoxStyle.Critical, "Sign in")
        End If
    End Sub

    Private Sub sssignin_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1
        Label3.Parent = PictureBox1
    End Sub
End Class