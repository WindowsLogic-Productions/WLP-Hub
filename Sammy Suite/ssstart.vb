Public Class ssstart

    Private Sub ssstart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.About, AudioPlayMode.Background)
        checkforupdates()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ssmain.Show()
        Me.Hide()
    End Sub

    Public Sub CheckForUpdates()

        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://dl.dropboxusercontent.com/u/93134108/Update%20Repo/SS/SS.txt")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim newestversion As String = sr.ReadToEnd()
        Dim currentversion As String = Application.ProductVersion
        If newestversion.Contains(currentversion) Then
            MsgBox("You have the latest version.", MsgBoxStyle.Information)
        ElseIf MsgBox("There is an update available, would you like to download it?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            System.Diagnostics.Process.Start("https://dl.dropboxusercontent.com/u/93134108/Update%20Repo/SS/Sammy%27s%20Suite%20Setup.exe")
        End If
    End Sub
End Class