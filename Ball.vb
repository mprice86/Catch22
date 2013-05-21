'' Class to define the Balls
Public Class Ball
    '' Attributes 
    Public rBall As Rectangle
    Public eBallBmp As Bitmap
    Public pSpawnPoint As New Point(267, 10)
    Public blnExplode As Boolean
    Dim bSpeed As Byte = 8
    Property bDirection As Byte = 0 '' 0 = forward

    Public Sub New(ByVal spawn As Point)
        '' Property controlling the creation of a new ball
        rBall = New Rectangle(Form1.bBallWidth, Form1.bBallHeight, Form1.bBallWidth, Form1.bBallHeight)
        pSpawnPoint = spawn
        rBall.Location = pSpawnPoint
        eBallBmp = New Bitmap(Application.StartupPath & "\ball.bmp")
    End Sub

    Public Sub move(ByVal dir As Integer) '' 0 = down, 1 = right/down, 2 = left/down.
        '' Movement property
        Select Case dir
            Case Is = 0
                rBall.Location = rBall.Location + New Point(0, bSpeed)
            Case Is = 1
                rBall.Location = rBall.Location + New Point(bSpeed, 0)
                rBall.Location = rBall.Location + New Point(0, bSpeed)

            Case Is = 2
                rBall.Location = rBall.Location + New Point(-bSpeed, 0)
                rBall.Location = rBall.Location + New Point(0, bSpeed)

        End Select
        collide()
    End Sub

    Public Sub collide()
        '' Property to detect collisions
        '' IF statements will stop balls leaving sides of form
        If rBall.Left <= 0 Then
            bDirection = 1
        End If
        If rBall.Left + rBall.Width >= 535 Then
            bDirection = 2
        End If

        '' Check for impact with player avatar
        If rBall.IntersectsWith(Form1.sPlayer.rBucket) Then
            Form1.Collide()
            rBall.Location = pSpawnPoint
            Exit Sub
        End If

        '' When ball leaves bottom of form return to spawn point
        If rBall.Top >= 768 Then
            rBall.Location = pSpawnPoint

            '' If a ball is dropped then multiplier is reduced by 2, unless it is less than 2 already
            If Form1.bMultiplyer > 2 Then
                Form1.bMultiplyer = Form1.bMultiplyer - 2
                Form1.lblMulti.Text = Form1.bMultiplyer
            ElseIf Form1.bMultiplyer = 2 Then
                Form1.bMultiplyer = Form1.bMultiplyer - 1
                Form1.lblMulti.Text = Form1.bMultiplyer
            End If
        End If
    End Sub

    Public Sub playsound(ByVal sound As String)
        '' Sub to set the location for sounds to be played from
        My.Computer.Audio.Play(Application.StartupPath & sound)
    End Sub
End Class
