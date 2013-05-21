<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaveScore
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
        Me.lblBack = New System.Windows.Forms.Label()
        Me.lblPlay = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.txtPlayerName = New System.Windows.Forms.TextBox()
        Me.lblSave = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblBack.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblBack.Location = New System.Drawing.Point(364, 664)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(143, 56)
        Me.lblBack.TabIndex = 37
        Me.lblBack.Text = "Back"
        Me.ToolTip1.SetToolTip(Me.lblBack, "Return to the menu")
        '
        'lblPlay
        '
        Me.lblPlay.AutoSize = True
        Me.lblPlay.BackColor = System.Drawing.Color.Transparent
        Me.lblPlay.Font = New System.Drawing.Font("Century Gothic", 60.0!, System.Drawing.FontStyle.Bold)
        Me.lblPlay.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblPlay.Location = New System.Drawing.Point(12, 9)
        Me.lblPlay.Name = "lblPlay"
        Me.lblPlay.Size = New System.Drawing.Size(474, 93)
        Me.lblPlay.TabIndex = 35
        Me.lblPlay.Text = "Save Score"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblScore.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblScore.Location = New System.Drawing.Point(18, 242)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(153, 56)
        Me.lblScore.TabIndex = 38
        Me.lblScore.Text = "score"
        Me.ToolTip1.SetToolTip(Me.lblScore, "Your score")
        '
        'txtPlayerName
        '
        Me.txtPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlayerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlayerName.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold)
        Me.txtPlayerName.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.txtPlayerName.Location = New System.Drawing.Point(270, 242)
        Me.txtPlayerName.MaxLength = 3
        Me.txtPlayerName.Name = "txtPlayerName"
        Me.txtPlayerName.Size = New System.Drawing.Size(216, 66)
        Me.txtPlayerName.TabIndex = 39
        Me.ToolTip1.SetToolTip(Me.txtPlayerName, "Enter your initials, 3 characters only.")
        '
        'lblSave
        '
        Me.lblSave.AutoSize = True
        Me.lblSave.BackColor = System.Drawing.Color.Transparent
        Me.lblSave.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblSave.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblSave.Location = New System.Drawing.Point(12, 664)
        Me.lblSave.Name = "lblSave"
        Me.lblSave.Size = New System.Drawing.Size(139, 56)
        Me.lblSave.TabIndex = 40
        Me.lblSave.Text = "Save"
        Me.ToolTip1.SetToolTip(Me.lblSave, "Save score")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label2.Location = New System.Drawing.Point(42, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(411, 56)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Enter your initials"
        '
        'SaveScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(529, 739)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSave)
        Me.Controls.Add(Me.txtPlayerName)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.lblPlay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "SaveScore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SaveScore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBack As System.Windows.Forms.Label
    Friend WithEvents lblPlay As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents txtPlayerName As System.Windows.Forms.TextBox
    Friend WithEvents lblSave As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
