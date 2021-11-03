Public Class ssbreakout

#Region "Variables"
    Private Score As Integer = 10
    Private Const brickWidth As Integer = 75
    Private Const brickHeight As Integer = 23
    Private Const brickRows As Integer = 6 - 1
    Private Const brickColumns As Integer = 6 - 1

    Private brickArray(brickRows, brickColumns) As Rectangle
    Private isBrickEnabled(brickRows, brickColumns) As Boolean

    Private gamePaddle As Rectangle = New Rectangle(300, 434, 72, 10)

    Private gameBall As Rectangle = New Rectangle(gamePaddle.X + 72 / 2 _
    - (16 / 2), 432 - 16, 16, 16)
    Private isBallGlued As Boolean = True

    Dim speed As Single = 5
    Dim xVel As Single = Math.Cos(speed) * speed
    Dim yVel As Single = Math.Sin(speed) * speed
#End Region

#Region "Load Game"
    Private Sub gameMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sssc.Button12.Show()
        loadBricks()
    End Sub
#End Region

#Region "Paint Event"
    Private Sub gameMain_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ' Loop through all enabled bricks and display them.
        For row As Integer = 0 To brickRows
            For column As Integer = 0 To brickColumns
                If isBrickEnabled(row, column) Then _
                    e.Graphics.FillRectangle(Brushes.Red, brickArray(row, column))
            Next
        Next

        ' Show the ball and the paddle.
        e.Graphics.FillRectangle(Brushes.Green, gameBall)
        e.Graphics.FillRectangle(Brushes.DarkGreen, gamePaddle)
    End Sub
#End Region

#Region "Game Timer"
    Private Sub tmrGame_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGame.Tick
        If Not isBallGlued Then _
        gameBall.Location = New Point(gameBall.X + xVel, gameBall.Y + yVel)

        ' Check for top wall.
        If gameBall.Location.Y < 0 Then
            gameBall.Location = New Point(gameBall.Location.X, 0)
            yVel = -yVel
        End If

        ' Check for bottom wall (restart)
        If gameBall.Location.Y - gameBall.Height > Me.Height Then
            isBallGlued = True
            gameBall.Location = New Point(gamePaddle.X + 72 / 2 _
            - (gameBall.Width / 2), 432 - 16)
        End If

        ' Check for left wall.
        If gameBall.Location.X < 0 Then
            gameBall.Location = New Point(0, gameBall.Location.Y)
            xVel = -xVel
        End If

        ' Check for right wall.
        If gameBall.Location.X + gameBall.Width > Me.Width Then
            gameBall.Location = New Point(Me.Width - gameBall.Width, _
            gameBall.Location.Y)
            xVel = -xVel
        End If

        ' Check for paddle.
        If gameBall.IntersectsWith(gamePaddle) Then
            gameBall.Location = New Point(gameBall.X, gamePaddle.Y - gameBall.Height)
            yVel = -yVel
        End If

        ' Check for blocks

        For rows As Integer = 0 To brickRows
            For columns As Integer = 0 To brickColumns
                If Not isBrickEnabled(rows, columns) Then Continue For
                If gameBall.IntersectsWith(brickArray(rows, columns)) Then
                    isBrickEnabled(rows, columns) = False
                    Label2.Text = "Score: " & Score
                    Score += 10
                    If gameBall.X + 10 < brickArray(rows, columns).X Or _
                    gameBall.X > brickArray(rows, columns).X + brickArray(rows, columns).Width _
                     Then
                        xVel = -xVel
                    Else
                        yVel = -yVel
                    End If
                End If
            Next
        Next

        ' Check for end of game.
        If getBrickCount() = 0 Then
            tmrGame.Stop()
            Windows.Forms.Cursor.Show()
            If MessageBox.Show("Would you like to play again?", "Play Again?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                loadBricks()
                isBallGlued = True
                Windows.Forms.Cursor.Hide()
                gameBall.Location = New Point(gamePaddle.X + 72 / 2 - (gameBall.Width / 2), _
                432 - 16)
                tmrGame.Start()
            Else
                Application.Exit()
            End If
        End If

        Me.Refresh()
    End Sub
#End Region

#Region "Set Up Bricks"
    Sub loadBricks()
        Dim xOffset As Integer = 75, yOffset As Integer = 100
        For row As Integer = 0 To brickRows
            For column As Integer = 0 To brickColumns

                brickArray(row, column) = New Rectangle( _
                xOffset, yOffset, brickWidth, brickHeight)

                xOffset += brickWidth + 10
                isBrickEnabled(row, column) = True
            Next
            yOffset += brickHeight + 10
            xOffset = 75
        Next
    End Sub
#End Region

#Region "Get Amount of Bricks"
    Function getBrickCount() As Integer
        Dim Count As Integer = 0
        For Each brick As Boolean In isBrickEnabled
            If brick = True Then Count += 1
        Next
        Return Count
    End Function
#End Region

#Region "Move Paddle According to Mouse Position"
    Private Sub gameMain_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.X > 0 And e.X < Me.Width - 72 Then _
        gamePaddle.Location = New Point(e.X, gamePaddle.Y)

        If isBallGlued Then
            gameBall.Location = New Point(gamePaddle.X + 72 / 2 - (gameBall.Width / 2), _
            432 - 16)
        End If
    End Sub
#End Region

#Region "Launch Ball"

    Private Sub gameMain_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' Launch the ball.
            If isBallGlued Then
                isBallGlued = False
            End If
        End If
    End Sub
#End Region

#Region "Quit on Escape Key Press and Pause on P Key Press"
    Private Sub gameMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        ' Exit
        If e.KeyCode = Keys.Escape Then Application.Exit()

        ' Toggle Paused
        If e.KeyCode = Keys.P Then
            If tmrGame.Enabled Then tmrGame.Stop() _
            Else tmrGame.Start()
        End If
    End Sub
#End Region

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ssabout.Show()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sssc.Button12.Hide()
    End Sub
End Class
