Public Class ssupdater
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()

            If ProgressBar1.Value = 100 Then
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://u.windowslogic.co.uk/HUB/HUB.txt")
                Dim response As System.Net.HttpWebResponse = request.GetResponse()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                Dim newestversion As String = sr.ReadToEnd()
                Dim currentversion As String = Application.ProductVersion
                If newestversion.Contains(currentversion) Then
                    Label1.Text = ("No updates available.")
                    Label2.Show()
                    Label2.Text = ("Please close the updater.")
                    Button2.Text = ("Close")
                    PictureBox2.Hide()
                Else
                    Label1.Text = ("Updates available.")
                    WebBrowser1.Navigate("https://dl.dropboxusercontent.com/u/93134108/Update%20Repo/SS/WLP%20Hub%20Setup.exe")
                    Label2.Show()
                    Label2.Text = ("Please close the updater.")
                    Button2.Text = ("Close")
                    label3.show()
                    PictureBox2.Hide()
                End If
            End If
        End If
    End Sub

    Public Sub CheckForUpdates()
        If ProgressBar1.Value = 100 Then
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://dl.dropboxusercontent.com/u/93134108/Update%20Repo/SS/SS.txt")
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim newestversion As String = sr.ReadToEnd()
            Dim currentversion As String = Application.ProductVersion
            If newestversion.Contains(currentversion) Then
                Label1.Text = ("No updates available.")
                Label2.Text = ("Please close the updater.")
                PictureBox2.Hide()
            Else
                Label1.Text = ("Updates are available.")
                WebBrowser1.Navigate("https://dl.dropboxusercontent.com/u/93134108/Update%20Repo/SS/WLP%20Hub%20Setup.exe")
                Label2.Text = ("Please close the updater.")
                PictureBox2.Hide()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Updater_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Button1.Enabled = False
        Label1.Text = "We're getting ready..."
        Timer1.Start()
        CheckForUpdates()
    End Sub
End Class