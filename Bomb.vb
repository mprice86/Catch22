'' Class to define the Bombs
Public Class Bomb
    Public rBomb As Rectangle
    Public eBombBmp As Bitmap
    Public pSpawnPoint As New Point(267, 10)
    Public blnExplode As Boolean
    Dim bSpeed As Byte = 10
    Property bDirection As Byte = 0 '' 0 = forward, 1 = right, 2 = left

    Public Sub New(ByVal spawn As Point)
        '' Property controlling the creation of a new bomb
        rBomb = New Rectangle(Form1.bBallWidth, Form1.bBallHeight, Form1.bBallWidth, Form1.bBallHeight)
        pSpawnPoint = spawn
        rBomb.Location = pSpawnPoint
        eBombBmp = New Bitmap(Application.StartupPath & "\bomb.bmp")


    End Sub

    Public Sub move(ByVal dir As Integer) '' 0 = down, 1 = right/down, 2 = left/down.
        '' Movement property
        Select Case dir
            Case Is = 0
                rBomb.Location = rBomb.Location + New Point(0, bSpeed)
            Case Is = 1
                rBomb.Location = rBomb.Location + New Point(bSpeed, 0)
                rBomb.Location = rBomb.Location + New Point(0, bSpeed)

            Case Is = 2
                rBomb.Location = rBomb.Location + New Point(-bSpeed, 0)
                rBomb.Location = rBomb.Location + New Point(0, bSpeed)

        End Select
        collide()
    End Sub

    Public Sub collide()
        '' Property to detect collisions
        '' IF statements will stop bomb leaving sides of form
        If rBomb.Left <= 0 Then
            bDirection = 1
        End If
        If rBomb.Left + rBomb.Width >= 535 Then
            bDirection = 2
        End If
        '' Check for impact with player avatar
        If rBomb.IntersectsWith(Form1.sPlayer.rBucket) Then
            Form1.Hit()
            rBomb.Location = pSpawnPoint
            Exit Sub
        End If
        '' When bomb leaves bottom of form return to spawn point
        If rBomb.Top >= 768 Then
            rBomb.Location = pSpawnPoint

            '' Bombs avoided give 10 points
            Form1.iScore = Form1.iScore + 10
            Form1.lblScore.Text = Form1.iScore
        End If
    End Sub

    Public Sub playsound(ByVal sound As String)
        '' Sub to set the location for sounds to be played from
        My.Computer.Audio.Play(Application.StartupPath & sound)
    End Sub


End Class


