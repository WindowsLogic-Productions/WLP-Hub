Imports System.ComponentModel

Public Class ssmusicplaylist

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddMusicButton.Click
        OpenFileDialog2.Multiselect = True

        OpenFileDialog2.ShowDialog()

        Try
            For Each s As String In OpenFileDialog2.SafeFileNames
                ListBox3.Items.Add(s)
            Next

            ListBox3.SelectedIndex = ListBox3.SelectedIndex + 1

            For Each s As String In OpenFileDialog2.FileNames
                ListBox1.Items.Add(s)
            Next

            ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1

        Catch ex As Exception
            sserror.Show()
            sserror.Label1.Text = "Playlist creation has been cancelled."
        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RemoveMusicButton.Click
        ListBox3.Items.Remove(ListBox3.SelectedItem)
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SavePlaylistButton.Click

        For Each s As String In ListBox3.Items
            ssmusic.ListBox1.Items.Add(s)

        Next

        For Each s As String In ListBox1.Items
            ssmusic.ListBox2.Items.Add(s)
        Next
        Me.Dispose()


    End Sub

    Private Sub ssmusicplaylist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub
End Class