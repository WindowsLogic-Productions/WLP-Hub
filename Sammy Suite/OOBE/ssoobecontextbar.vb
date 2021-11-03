Public Class ssoobecontextbar
#Region "Load Settings"
    Private Sub ssoobehub_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Load background settings.
        If My.Settings.DWBWUC = 0 Then
            WLSOOBEBackground.Image = My.Resources.WLPBackground
        End If

        If My.Settings.DWBWUC = 1 Then
            WLSOOBEBackground.Image = Nothing
        End If

        If My.Settings.DWBWUC = 2 Then
            WLSOOBEBackground.Load(My.Settings.CB2)
        End If

        'Load custom colour.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Load Always On Top Settings
        If My.Settings.ContextBarOnTop = 1 Then
            CheckBox1.Checked = True
        End If

        If My.Settings.ContextBarOnTop = 0 Then
            CheckBox1.Checked = False
        End If

        'Load Attach/Detach Context Bar Settings.
        If My.Settings.DetachContextBar = 1 Then
            CheckBox4.Checked = True
        End If

        If My.Settings.DetachContextBar = 0 Then
            CheckBox4.Checked = False
        End If

        'Load parent settings.
        Label2.Parent = WLSOOBEBackground
        Label4.Parent = WLSOOBEBackground
        RMLButton.Parent = WLSOOBEBackground
        ForwardButton.Parent = WLSOOBEBackground
        CheckBox1.Parent = WLSOOBEBackground
        CheckBox4.Parent = WLSOOBEBackground
    End Sub
#End Region
#Region "Settings"
    'Enable/disable always on top.
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            sscontextbar.TopMost = True
            My.Settings.ContextBarOnTop = 1
            My.Settings.Save()
        End If
        If CheckBox1.Checked = False Then
            sscontextbar.TopMost = False
            My.Settings.ContextBarOnTop = 0
            My.Settings.Save()
        End If
    End Sub

    'Attach/Detach Context Bar.
    Private Sub CheckBox4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            My.Settings.DetachContextBar = 1
            ssmain.ContextBar.Visible = False
            sscontextbar.Show()
            My.Settings.Save()
        End If

        If CheckBox4.Checked = False Then
            My.Settings.DetachContextBar = 0
            ssmain.ContextBar.Visible = True
            sscontextbar.Close()
            My.Settings.Save()
        End If
    End Sub
#End Region
#Region "Other"
    Private Sub ForwardButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardButton.Click
        My.Settings.Save()
        ssoobesearch.Show()
        Me.Close()
    End Sub

    Private Sub RMLButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RMLButton.Click
        ssoobesearch.Show()
        Me.Close()
    End Sub
#End Region
End Class