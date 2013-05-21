Public Class Form1
    '' Define player size
    Public bBucketWidth As Byte = 75
    Public bBucketHeight As Byte = 79
    Public pPlayerSpawnPoint = New Point(225, 649)

    '' Define ball/bomb size
    Public bBallWidth As Byte = 50
    Public bBallHeight As Byte = 50

    '' Variables to track balls, bombs, levels and scores
    Public bLevel As Byte
    Public bBallCount As Byte
    Public bBombCount As Byte
    Public bMultiplyer As Byte = 1
    Public sPlayer As Bucket
    Public iScore As Integer = 0
    Public bLives As Byte = 3

    '' Sets the number of balls and bombs
    Public eBomb(22) As Bomb
    Public eBall(22) As Ball

    '' Sets the game speed, game state and creates the random number generator
    Dim blnGameover As Boolean = False
    Dim iGameSpeed As Integer = 30
    Dim objRandom As New System.Random

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        '' Sets the form location to the location of the program from settings
        With My.Settings
            Me.Location = .FormLocation
        End With
    End Sub

    Private Sub Form1_Move(sender As Object, e As EventArgs) Handles Me.Move
        '' Stores the location of the form to the location setting for the program
        '' if the location of the form is different to the location setting
        With My.Settings
            If Me.Location <> .FormLocation Then
                .FormLocation = Me.Location
            End If
        End With
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        '' Sub to control player movement
        If blnGameover = False Then

            '' If the right arrow is pressed, move right
            Select Case e.KeyData
                Case Is = Keys.Right
                    sPlayer.bmoveDir = 1

                    '' If the left arror is pressed, move left
                Case Is = Keys.Left
                    sPlayer.bmoveDir = 2
            End Select
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        '' If the game is still running - stop player movement when direction key is released
        If blnGameover = False Then
            If e.KeyData = Keys.Left Then
                sPlayer.bmoveDir = 0
            ElseIf e.KeyData = Keys.Right Then
                sPlayer.bmoveDir = 0
            End If
        End If
    End Sub


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '' Sets the gameover state to true when the form loads
        blnGameover = True

        '' Reduces graphics flicker
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.UserPaint, True)
        Me.UpdateStyles()

    End Sub

    Private Sub Form1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        If blnGameover = False Then
            '' Draw and render Bucket graphics
            sPlayer.bmpBucket.MakeTransparent(Color.Blue)
            e.Graphics.DrawImage(sPlayer.bmpBucket, sPlayer.rBucket.Location)

            '' Draw and render Bomb graphics
            For i = 1 To bBombCount
                eBomb(i).eBombBmp.MakeTransparent(Color.Blue)
                e.Graphics.DrawImage(eBomb(i).eBombBmp, eBomb(i).rBomb.Location)
            Next
            '' Draw and render Ball graphics
            For i = 1 To bBallCount
                eBall(i).eBallBmp.MakeTransparent(Color.Blue)
                e.Graphics.DrawImage(eBall(i).eBallBmp, eBall(i).rBall.Location)
            Next
        End If
    End Sub

    Public Sub Hit()
        '' When a Bomb hits the Bucket
        '' Play sound
        My.Computer.Audio.Play(Application.StartupPath & "\bomb.wav")

        '' Deduct one life
        bLives = bLives - 1
        bMultiplyer = 1
        lblMulti.Text = bMultiplyer
        bBallCount = bBallCount - 1
        bBombCount = bBombCount - 1
        lblLives.Text = bLives


        '' If no more lives then game over
        If bLives = 0 Then
            blnGameover = True
            endGame()
        Else
            bLevel = bLevel - 1
            LevelIncrease()
        End If

        '' Change colour of bucket depending on how many lives
        Select Case bLives
            Case 3
                sPlayer.bmpBucket = New Bitmap(Application.StartupPath & "\bucket.bmp")
            Case 2
                sPlayer.bmpBucket = New Bitmap(Application.StartupPath & "\bucketY.bmp")
            Case 1
                sPlayer.bmpBucket = New Bitmap(Application.StartupPath & "\bucketR.bmp")
        End Select

    End Sub

    Public Sub Collide()
        '' When a ball hits the bucket
        '' Play sound
        My.Computer.Audio.Play(Application.StartupPath & "\catch.wav")

        For i = 1 To Me.bBallCount
            If eBall(i).rBall.IntersectsWith(sPlayer.rBucket) Then

                '' Add 200 points to score and increase level
                iScore = iScore + (200 * bMultiplyer)
                LevelIncrease()

                '' Write score to screen and exit sub
                lblScore.Text = iScore

                '' If user has reached level 10, 15 or 20 they get an extra life
                If bLevel = 10 Or bLevel = 15 Or bLevel = 20 Then
                    bLives = bLives + 1
                    lblLives.Text = bLives
                End If

                '' Change colour of bucket depending on how many lives
                Select Case bLives
                    Case 3
                        sPlayer.bmpBucket = New Bitmap(Application.StartupPath & "\bucket.bmp")
                    Case 2
                        sPlayer.bmpBucket = New Bitmap(Application.StartupPath & "\bucketY.bmp")
                    Case 1
                        sPlayer.bmpBucket = New Bitmap(Application.StartupPath & "\bucketR.bmp")
                End Select

                '' Increase multiplier
                If bMultiplyer = 1 Then
                    bMultiplyer = bMultiplyer + 1
                Else
                    bMultiplyer = bMultiplyer + 2
                End If
                lblMulti.Text = bMultiplyer
                Exit Sub
            End If
        Next
    End Sub
    Public Sub winGame()
        '' Resets the game and shows the form to save your score.
        SaveScore.Show()
        Reset()
        Me.Hide()

    End Sub

    Public Sub endGame()
        '' If the game ends stop all timers and hide all bombs and balls
        tmrPBMove.Enabled = False
        tmrBombs.Enabled = False
        tmrAI.Enabled = False
        tmrBalls.Enabled = False

        For i = 1 To bLevel
            eBomb(i).rBomb.Location = New Point(-100, -100)
            eBall(i).rBall.Location = New Point(-100, -100)
        Next

        '' Show the player a message asking if they want to save their score
        '' If yes then show the save score form and reset the game
        Dim bChoice As Byte = MsgBox("Game Over!" & vbLf & vbLf & "Do you want to save your score?", MsgBoxStyle.YesNo, "Game Over")
        If bChoice = vbYes Then
            SaveScore.Show()
            Reset()
            Me.Hide()

            '' Otherwise just reset the game
        Else
            Reset()
        End If


    End Sub

    Public Sub Reset()
        '' Sub to reset the game
        '' Stop all timers
        tmrPBMove.Enabled = False
        tmrBombs.Enabled = False
        tmrAI.Enabled = False
        tmrBalls.Enabled = False

        '' Hide all bombs and balls
        For i = 1 To bLevel
            eBomb(i).rBomb.Location = New Point(-100, -100)
            eBall(i).rBall.Location = New Point(-100, -100)
        Next

        '' Reset game variables
        bLevel = 0
        bLives = 3
        iScore = 0
        bBallCount = 0
        bBombCount = 0
        bMultiplyer = 1

        '' Stop form
        Me.Invalidate()

        '' Shows options again
        lblPlay.Enabled = True
        lblPlay.Visible = True
        lblScores.Enabled = True
        lblScores.Visible = True
        lblExit.Enabled = True
        lblExit.Visible = True
        lblHelp.Enabled = True
        lblHelp.Visible = True
        lblTitle.Enabled = True
        lblTitle.Visible = True

        '' hide game play labels
        lblLi.Visible = False
        lblLives.Visible = False
        lblL.Visible = False
        lblLevel.Visible = False
        lblS.Visible = False
        lblScore.Visible = False
        lblM.Visible = False
        lblMulti.Visible = False

    End Sub

    Public Sub LevelIncrease()
        '' Sub  to increase the game level
        If bLevel = 1 Then
            iGameSpeed = 10
        End If

        '' If player passes level 22 they win the game
        If bLevel > 21 Then
            winGame()
            Exit Sub
        End If

        '' Increases the level and the number of balls and bombs
        bLevel = bLevel + 1
        bBallCount = bBallCount + 1
        bBombCount = bBombCount + 1
        blnGameover = False

        '' Displays game data
        lblScore.Text = iScore
        lblLives.Text = bLives
        lblLevel.Text = bLevel
        lblMulti.Text = bMultiplyer

        '' Creates bombs
        For i = 1 To bBombCount
            eBomb(i) = New Bomb(New Point(GetRandomNumber(0, 535), GetRandomNumber(-535, -20)))
        Next

        '' Creates balls
        For i = 1 To bBallCount
            eBall(i) = New Ball(New Point(GetRandomNumber(0, 535), GetRandomNumber(-535, -20)))
        Next

        '' Updates bomb and ball interval
        tmrBombs.Interval = iGameSpeed
        tmrBalls.Interval = iGameSpeed

        '' Enables timers
        If tmrPBMove.Enabled = False Then
            tmrPBMove.Enabled = True
            tmrBombs.Enabled = True
            tmrAI.Enabled = True
            tmrBalls.Enabled = True
        End If
    End Sub


    Public Function GetRandomNumber(Optional ByVal Low As Integer = 1, Optional ByVal High As Integer = 53) As Integer
        '' Returns a random number, between the optional Low and High parameters
        Return objRandom.Next(Low, High)
    End Function

    Private Sub lblPlay_Click(sender As System.Object, e As System.EventArgs) Handles lblPlay.Click
        '' When the play label is clicked, start the game
        '' Play a sound
        My.Computer.Audio.Play(Application.StartupPath & "\start.wav")

        '' Increase the level to level one
        LevelIncrease()

        '' Set the player on the screen
        sPlayer = New Bucket(pPlayerSpawnPoint)

        '' Hide option labels
        lblPlay.Enabled = False
        lblPlay.Visible = False
        lblScores.Enabled = False
        lblScores.Visible = False
        lblExit.Enabled = False
        lblExit.Visible = False
        lblHelp.Enabled = False
        lblHelp.Visible = False
        lblTitle.Enabled = False
        lblTitle.Visible = False

        '' Show game play labels
        lblLi.Visible = True
        lblLives.Visible = True
        lblL.Visible = True
        lblLevel.Visible = True
        lblS.Visible = True
        lblScore.Visible = True
        lblM.Visible = True
        lblMulti.Visible = True

    End Sub

    Private Sub tmrPBMove_Tick(sender As System.Object, e As System.EventArgs) Handles tmrPBMove.Tick
        '' Sub to handle player movement
        Select Case sPlayer.bmoveDir
            Case Is = 1
                sPlayer.move(True)
            Case Is = 2
                sPlayer.move(False)
        End Select
    End Sub

    Private Sub tmrEnemy_Tick(sender As System.Object, e As System.EventArgs) Handles tmrBombs.Tick
        '' This timer handles bomb movement
        For i = 1 To bBombCount
            eBomb(i).move(eBomb(i).bDirection)
        Next
        Me.Invalidate()
    End Sub

    Private Sub tmrBalls_Tick(sender As System.Object, e As System.EventArgs) Handles tmrBalls.Tick
        '' This timer handles ball movement 
        For i = 1 To bBallCount
            eBall(i).move(eBall(i).bDirection)
        Next
        Me.Invalidate()
    End Sub

    Private Sub tmrAI_Tick(sender As System.Object, e As System.EventArgs) Handles tmrAI.Tick
        '' This timer handles the ball direction
        For i = 1 To bLevel
            If GetRandomNumber(1, 2) = 1 Then
                If eBall(i).rBall.Location.Y >= 0 Then
                End If
            End If
            eBall(i).bDirection = GetRandomNumber(0, 3)
        Next
    End Sub

    Private Sub lblScores_Click(sender As System.Object, e As System.EventArgs) Handles lblScores.Click
        '' Loads the highscore form when the highscore label is clicked
        frmHighScore.Show()
        Me.Hide()
    End Sub

    Private Sub lblExit_Click(sender As System.Object, e As System.EventArgs) Handles lblExit.Click
        '' When exit label is clicked, asks user to confirm they want to quit. If yes the game closes.
        Dim bExit As Byte = MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo, "Quit Game")
        If bExit = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblHelp.Click
        '' Show help form when help label is clicked
        Help.Show()
        Me.Hide()
    End Sub

End Class
