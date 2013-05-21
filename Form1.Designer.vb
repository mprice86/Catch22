<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.lblScores = New System.Windows.Forms.Label()
        Me.lblPlay = New System.Windows.Forms.Label()
        Me.lblLi = New System.Windows.Forms.Label()
        Me.lblS = New System.Windows.Forms.Label()
        Me.lblL = New System.Windows.Forms.Label()
        Me.lblLives = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.tmrBalls = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBombs = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPBMove = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAI = New System.Windows.Forms.Timer(Me.components)
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblM = New System.Windows.Forms.Label()
        Me.lblMulti = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.BackColor = System.Drawing.Color.Transparent
        Me.lblExit.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblExit.Location = New System.Drawing.Point(405, 664)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(102, 56)
        Me.lblExit.TabIndex = 32
        Me.lblExit.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.lblExit, "Exit the game")
        '
        'lblScores
        '
        Me.lblScores.AutoSize = True
        Me.lblScores.BackColor = System.Drawing.Color.Transparent
        Me.lblScores.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScores.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblScores.Location = New System.Drawing.Point(117, 310)
        Me.lblScores.Name = "lblScores"
        Me.lblScores.Size = New System.Drawing.Size(297, 56)
        Me.lblScores.TabIndex = 31
        Me.lblScores.Text = "High Scores"
        Me.ToolTip1.SetToolTip(Me.lblScores, "View highscores")
        '
        'lblPlay
        '
        Me.lblPlay.AutoSize = True
        Me.lblPlay.BackColor = System.Drawing.Color.Transparent
        Me.lblPlay.Font = New System.Drawing.Font("Century Gothic", 60.0!, System.Drawing.FontStyle.Bold)
        Me.lblPlay.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblPlay.Location = New System.Drawing.Point(171, 204)
        Me.lblPlay.Name = "lblPlay"
        Me.lblPlay.Size = New System.Drawing.Size(203, 93)
        Me.lblPlay.TabIndex = 30
        Me.lblPlay.Text = "Play"
        Me.ToolTip1.SetToolTip(Me.lblPlay, "Start the game")
        '
        'lblLi
        '
        Me.lblLi.AutoSize = True
        Me.lblLi.BackColor = System.Drawing.Color.Transparent
        Me.lblLi.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLi.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblLi.Location = New System.Drawing.Point(327, 41)
        Me.lblLi.Name = "lblLi"
        Me.lblLi.Size = New System.Drawing.Size(85, 32)
        Me.lblLi.TabIndex = 29
        Me.lblLi.Text = "Lives:"
        Me.lblLi.Visible = False
        '
        'lblS
        '
        Me.lblS.AutoSize = True
        Me.lblS.BackColor = System.Drawing.Color.Transparent
        Me.lblS.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblS.Location = New System.Drawing.Point(12, 9)
        Me.lblS.Name = "lblS"
        Me.lblS.Size = New System.Drawing.Size(97, 32)
        Me.lblS.TabIndex = 28
        Me.lblS.Text = "Score:"
        Me.lblS.Visible = False
        '
        'lblL
        '
        Me.lblL.AutoSize = True
        Me.lblL.BackColor = System.Drawing.Color.Transparent
        Me.lblL.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblL.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblL.Location = New System.Drawing.Point(327, 9)
        Me.lblL.Name = "lblL"
        Me.lblL.Size = New System.Drawing.Size(90, 32)
        Me.lblL.TabIndex = 27
        Me.lblL.Text = "Level:"
        Me.lblL.Visible = False
        '
        'lblLives
        '
        Me.lblLives.AutoSize = True
        Me.lblLives.BackColor = System.Drawing.Color.Transparent
        Me.lblLives.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLives.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblLives.Location = New System.Drawing.Point(419, 42)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(101, 32)
        Me.lblLives.TabIndex = 26
        Me.lblLives.Text = "Label9"
        Me.lblLives.Visible = False
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblScore.Location = New System.Drawing.Point(146, 10)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(101, 32)
        Me.lblScore.TabIndex = 25
        Me.lblScore.Text = "Label8"
        Me.lblScore.Visible = False
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.BackColor = System.Drawing.Color.Transparent
        Me.lblLevel.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblLevel.Location = New System.Drawing.Point(419, 9)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(101, 32)
        Me.lblLevel.TabIndex = 24
        Me.lblLevel.Text = "Label7"
        Me.lblLevel.Visible = False
        '
        'tmrBalls
        '
        Me.tmrBalls.Interval = 2000
        '
        'tmrBombs
        '
        Me.tmrBombs.Interval = 40
        '
        'tmrPBMove
        '
        Me.tmrPBMove.Interval = 40
        '
        'tmrAI
        '
        Me.tmrAI.Interval = 2000
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.BackColor = System.Drawing.Color.Transparent
        Me.lblHelp.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblHelp.Location = New System.Drawing.Point(12, 664)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(132, 56)
        Me.lblHelp.TabIndex = 33
        Me.lblHelp.Text = "Help"
        Me.ToolTip1.SetToolTip(Me.lblHelp, "Get help with playing the game")
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Eras Demi ITC", 90.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblTitle.Location = New System.Drawing.Point(-15, 3)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(561, 138)
        Me.lblTitle.TabIndex = 34
        Me.lblTitle.Text = "Catch 22"
        '
        'lblM
        '
        Me.lblM.AutoSize = True
        Me.lblM.BackColor = System.Drawing.Color.Transparent
        Me.lblM.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblM.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblM.Location = New System.Drawing.Point(12, 42)
        Me.lblM.Name = "lblM"
        Me.lblM.Size = New System.Drawing.Size(139, 32)
        Me.lblM.TabIndex = 36
        Me.lblM.Text = "Multiplier:"
        Me.lblM.Visible = False
        '
        'lblMulti
        '
        Me.lblMulti.AutoSize = True
        Me.lblMulti.BackColor = System.Drawing.Color.Transparent
        Me.lblMulti.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMulti.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblMulti.Location = New System.Drawing.Point(146, 44)
        Me.lblMulti.Name = "lblMulti"
        Me.lblMulti.Size = New System.Drawing.Size(101, 32)
        Me.lblMulti.TabIndex = 35
        Me.lblMulti.Text = "Label9"
        Me.lblMulti.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Catch22.My.Resources.Resources.walltile150
        Me.ClientSize = New System.Drawing.Size(529, 739)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblM)
        Me.Controls.Add(Me.lblMulti)
        Me.Controls.Add(Me.lblHelp)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblScores)
        Me.Controls.Add(Me.lblPlay)
        Me.Controls.Add(Me.lblLi)
        Me.Controls.Add(Me.lblS)
        Me.Controls.Add(Me.lblL)
        Me.Controls.Add(Me.lblLives)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblLevel)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Catch 22"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblExit As System.Windows.Forms.Label
    Friend WithEvents lblScores As System.Windows.Forms.Label
    Friend WithEvents lblPlay As System.Windows.Forms.Label
    Friend WithEvents lblLi As System.Windows.Forms.Label
    Friend WithEvents lblS As System.Windows.Forms.Label
    Friend WithEvents lblL As System.Windows.Forms.Label
    Friend WithEvents lblLives As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents tmrBalls As System.Windows.Forms.Timer
    Friend WithEvents tmrBombs As System.Windows.Forms.Timer
    Friend WithEvents tmrPBMove As System.Windows.Forms.Timer
    Friend WithEvents tmrAI As System.Windows.Forms.Timer
    Friend WithEvents lblHelp As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblM As System.Windows.Forms.Label
    Friend WithEvents lblMulti As System.Windows.Forms.Label

End Class
