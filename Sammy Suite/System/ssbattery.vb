Public Class ssbattery
    Dim power As PowerStatus = SystemInformation.PowerStatus
    Dim percent As Single = power.BatteryLifePercent
    Dim timeleft As Single = power.BatteryChargeStatus

    Private Sub BatteryPercentSystem()
        If Label2.Text = "Your computer is currently on power" + vbNewLine + "(supplying power to the built-in battery or PSU)" Then
            PictureBox1.Image = My.Resources.ssBatteryCharging
        End If

        If Label1.Text = "100%" And Label2.Text = "Your computer is currently not on power" + vbNewLine + "(discharging battery)" Then
            PictureBox1.Image = My.Resources.ssBatteryFull
        End If

        If Label1.Text = "90%" Or Label1.Text = "89%" Or Label1.Text = "88%" Or Label1.Text = "87%" Or Label1.Text = "86%" Or Label1.Text = "85%" Or Label1.Text = "84%" Or Label1.Text = "83%" Or Label1.Text = "82%" Or Label1.Text = "81%" And Label2.Text = "Your computer is currently not on power" + vbNewLine + "(discharging battery)" Then
            PictureBox1.Image = My.Resources.ssBattery90
        End If

        If Label1.Text = "80%" Or Label1.Text = "79%" Or Label1.Text = "78%" Or Label1.Text = "77%" Or Label1.Text = "76%" Or Label1.Text = "75%" Or Label1.Text = "74%" Or Label1.Text = "73%" Or Label1.Text = "72%" Or Label1.Text = "71%" And Label2.Text = "Your computer is currently not on power" + vbNewLine + "(discharging battery)" Then
            PictureBox1.Image = My.Resources.ssBattery80
        End If

        If Label1.Text = "70%" Or Label1.Text = "69%" Or Label1.Text = "68%" Or Label1.Text = "67%" Or Label1.Text = "66%" Or Label1.Text = "65%" Or Label1.Text = "64%" Or Label1.Text = "63%" Or Label1.Text = "62%" Or Label1.Text = "61%" And Label2.Text = "Your computer is currently not on power" + vbNewLine + "(discharging battery)" Then
            PictureBox1.Image = My.Resources.ssBattery70
        End If

        If Label1.Text = "60%" Or Label1.Text = "59%" Or Label1.Text = "58%" Or Label1.Text = "57%" Or Label1.Text = "56%" Or Label1.Text = "55%" Or Label1.Text = "54%" Or Label1.Text = "53%" Or Label1.Text = "52%" Or Label1.Text = "51%" And Label2.Text = "Your computer is currently not on power" + vbNewLine + "(discharging battery)" Then
            PictureBox1.Image = My.Resources.ssBattery60
        End If

        If Label1.Text = "50%" Or Label1.Text = "49%" Or Label1.Text = "48%" Or Label1.Text = "47%" Or Label1.Text = "46%" Or Label1.Text = "45%" Or Label1.Text = "44%" Or Label1.Text = "43%" Or Label1.Text = "42%" Or Label1.Text = "41%" And Label2.Text = "Your computer is currently not on power" + vbNewLine + "(discharging battery)" Then
            PictureBox1.Image = My.Resources.ssBatteryHalf
        End If

        If Label1.Text = "40%" Or Label1.Text = "39%" Or Label1.Text = "38%" Or Label1.Text = "37%" Or Label1.Text = "36%" Or Label1.Text = "35%" Or Label1.Text = "34%" Or Label1.Text = "33%" Or Label1.Text = "32%" Or Label1.Text = "31%" And Label2.Text = "Your computer is currently not on power" + vbNewLine + "(discharging battery)" Then
            PictureBox1.Image = My.Resources.ssBattery40
        End If

        If Label1.Text = "30%" Or Label1.Text = "29%" Or Label1.Text = "28%" Or Label1.Text = "27%" Or Label1.Text = "26%" Or Label1.Text = "25%" Or Label1.Text = "24%" Or Label1.Text = "23%" Or Label1.Text = "22%" Or Label1.Text = "21%" And Label2.Text = "Your computer is currently not on power" + vbNewLine + "(discharging battery)" Then
            PictureBox1.Image = My.Resources.ssBattery30
        End If

        If Label1.Text = "20%" Or Label1.Text = "19%" Or Label1.Text = "18%" Or Label1.Text = "17%" Or Label1.Text = "16%" Or Label1.Text = "15%" Or Label1.Text = "14%" Or Label1.Text = "13%" Or Label1.Text = "12%" Or Label1.Text = "11%" And Label2.Text = "Your computer is currently not on power" + vbNewLine + "(discharging battery)" Then
            PictureBox1.Image = My.Resources.ssBattery20
        End If

        If Label1.Text = "20%" And Label2.Text = "Your computer is currently not on power" + vbNewLine + "(discharging battery)" Then
            ssbatterylow.Show()
        End If

        If Label1.Text = "10%" Or Label1.Text = "9%" Or Label1.Text = "8%" And Label2.Text = "Your computer is currently not on power" + vbNewLine + "(discharging battery)" Then
            PictureBox1.Image = My.Resources.ssBattery10
        End If

        If Label1.Text = "7%" And Label2.Text = "Your computer is currently not on power" + vbNewLine + "(discharging battery)" Then
            PictureBox1.Image = My.Resources.ssBatteryEmpty
            ssbatterycritical.Show()
        End If
    End Sub

    Private Sub ssbattery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'start timers.
        BatteryPercentCheck.Start()
        PowerToggle.Start()

        'get power information.
        Dim st As PowerLineStatus = SystemInformation.PowerStatus.PowerLineStatus
        If st = PowerLineStatus.Offline Then
            Label2.Text = "Your computer is currently not on power" + vbNewLine + "(discharging battery)"
        Else
            Label2.Text = "Your computer is currently on power" + vbNewLine + "(supplying power to the built-in battery or PSU)"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatteryPercentCheck.Tick
        percent = SystemInformation.PowerStatus.BatteryLifePercent * 100
        Label1.Text = percent.ToString + "%"

        BatteryPercentSystem()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PowerToggle.Tick
        Dim st As PowerLineStatus = SystemInformation.PowerStatus.PowerLineStatus
        If st = PowerLineStatus.Offline Then
            Label2.Text = "Your computer is currently not on power" + vbNewLine + "(discharging battery)"
        Else
            Label2.Text = "Your computer is currently on power" + vbNewLine + "(supplying power to the built-in battery or PSU)"
            PictureBox1.Image = My.Resources.ssBatteryCharging
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutButton.Click
        ssabout.Text = "About Battery Status"
        ssabout.AppPic.Image = My.Resources.ssBatteryIcon
        ssabout.AppName.Text = "Hub Battery Status - Version 1.1"
        ssabout.ShowDialog()
    End Sub

    Private Sub SettingsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsButton.Click
        Shell("control /name Microsoft.PowerOptions")
    End Sub
End Class