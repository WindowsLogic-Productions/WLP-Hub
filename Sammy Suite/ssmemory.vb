Public Class ssmemory

#Region "Customizable Variables"
    Dim GridOn As Color = Color.LightBlue
    Dim GridOff As Color = Color.DarkBlue
    Dim MaxTime As Integer = 5
#End Region
#Region "Other Variables"
    Dim TimeLeft As Integer
    Dim Wins As Integer = 0 'How many wins the player has this session
    Dim Losses As Integer = 0 'How many losses the player has this session
    Dim AllowEdit As Boolean = False
    Dim GridRandom As New Random
    Dim StatusText(5) As String
    Dim RandHolder As Integer
#End Region

    Private Sub ssmemory_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        sssc.Button10.Show()
        'Start customizable strings'
        StatusText(0) = "Please start a new game." 'What text is displayed upon startup
        StatusText(1) = "Go! You have " & MaxTime & " seconds to memorise." 'Text displayed to tell user x amt of time
        StatusText(2) = "Time up! To play again, click 'New Game'." 'Text when the timer runs up, user must enter pattern
        StatusText(3) = "Congratulations, you win." 'Displayed when the user wins the round
        StatusText(4) = "You lose." 'Displayed when the user loses the round.
        'End customizable strings'

        Label3.Text = StatusText(0)
        For Each pic As Control In Me.Controls 'For every picture in form1's controls...
            If TypeOf pic Is PictureBox Then   'Then, only picks the pictureboxes, not the buttons, labels, etc.
                AddHandler pic.Click, AddressOf PictureBoxClick 'For each picturebox (grid), add an event handler (PictureBoxClick) to avoid
            End If                                              'typing 16 of them ourselves
        Next
    End Sub

    Private Sub PictureBoxClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If AllowEdit = True Then
            Dim ctrl As PictureBox = DirectCast(sender, Control)
            If ctrl.BackColor = GridOn Then
                ctrl.BackColor = GridOff 'Set the backcolor to either GridOn or GridOff
            Else : ctrl.BackColor = GridOn
            End If
        Else
            'Do not allow the user to change the colors
        End If
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TimeLeft = MaxTime
        Label2.Text = "Time remaining: " & MaxTime     'Display the time left
        Label3.Text = StatusText(1)             'Show the 'Memorize this board' text

        Button1.Enabled = False                 'Disable the button so it can't be pressed again, for now

        For Each pic As Control In Me.Controls 'Randomize the grid arrangement
            If TypeOf pic Is PictureBox Then   'If the control is a picturebox...
                RandHolder = GridRandom.Next(0, 2) 'Generates a random number, either 0 or 1, NOT 2! The last number must be 1 higher than
                If RandHolder = 1 Then              'how high you want. If the random number is 1, then the grid is "On," otherwise it's "Off"
                    pic.BackColor = GridOn
                Else
                    pic.BackColor = GridOff
                End If
            End If
        Next

        For Each picture As Control In Me.Controls                  'This section stores the color
            If TypeOf picture Is PictureBox Then                    'of the original grids in tag.
                If picture.BackColor = GridOff Then : picture.Tag = 0 'Tag of 0 is equal to GridOff
                Else : picture.Tag = 1                              'Tag of 1 is equal to GridOn
                End If
            End If
        Next
        Timer1.Start() 'Start the game timer to start counting down!
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If TimeLeft > 0 Then 'If the time hasn't yet run out...
            TimeLeft -= 1 'Remove one second from the clock
            Label2.Text = "Time remaining: " & TimeLeft 'Display the time left
        Else
            AllowEdit = True 'The memorization is over, and the user must reconfigure the grid
            Label3.Text = StatusText(2) 'Tell the user the 'reconfigure' dialog
            For Each grid As Control In Me.Controls
                If TypeOf grid Is PictureBox Then
                    grid.BackColor = GridOff 'Reset all the grids, of course, so the user has to enter it
                End If
            Next

            Button3.Enabled = True 'Enable the 'Done' button when the user is finished
            Timer1.Stop() 'Stop the timer
        End If
    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Check answers
        Dim correct As Integer = 0 'We'll declare this to count how many grids the user got correct
        For Each grid As Control In Me.Controls
            If TypeOf grid Is PictureBox Then
                If grid.Tag = 1 And grid.BackColor = GridOn Or grid.Tag = 0 And grid.BackColor = GridOff Then 'The tag is used to store the correct answer: 0=off, 1=on, check those answers
                    correct += 1 'If it matches up, add one to the correct counter.
                Else
                    'The grid must not be correct
                    'Do not add to the correct count
                End If
            End If
        Next
        If correct = 16 Then 'If the user got all 16 correct...
            Wins += 1 'Add a win to the player's score
        Else 'Otherwise
            Losses += 1 'Add a loss to the player's score
        End If
        Label1.Text = "Wins: " & Wins & vbNewLine & "Losses: " & Losses 'Refresh the score to the user

        Button1.Enabled = True 'Enable the 'New Game' button so the user can play another round
        Button3.Enabled = False 'Disable this button, since it's only used to check answers

        For Each pic As Control In Me.Controls
            If TypeOf pic Is PictureBox Then
                pic.BackColor = GridOff 'Reset the picture boxes
                pic.Tag = ""
            End If
        Next
        AllowEdit = False 'Disable the ability for the player to toggle the grids
    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ssabout.Show()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sssc.Button10.Hide()
    End Sub
End Class