Public Class ssupdater
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        Label1.Text = ProgressBar1.Value & " %"
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            CheckForUpdates()
        End If
    End Sub

    Public Sub CheckForUpdates()
        Try
            If ProgressBar1.Value = 100 Then
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(Variables.vertext)
                Dim response As System.Net.HttpWebResponse = request.GetResponse()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                Dim newestversion As String = sr.ReadToEnd()
                Dim currentversion As String = Application.ProductVersion
                If newestversion.Contains(currentversion) Then
                    Label2.Text = ("No updates available.")
                Else
                    GeckoGeckoWebBrowser1.Navigate(Variables.setup)
                    Label2.Text = ("Downloading updates...")
                    Me.Hide()
                End If
            End If

                Catch

        End Try
    End Sub

    Private Sub Updater_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label4.Parent = PictureBox2
        PictureBox1.Parent = PictureBox2

        Button1.Enabled = False
        Label2.Text = "Please wait..."
        Timer1.Start()
        Label1.Text = ProgressBar1.Value
        CheckForUpdates()

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton1.Click
        Me.Hide()
    End Sub
End Class