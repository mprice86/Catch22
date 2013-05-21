'' Imports the oleDB class
Imports System.Data.OleDb

Public Class SaveScore
    Dim iScore As Integer = Form1.iScore
    '' Sets the path for the database connection
    Const Con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\HighScores.MDB"

    Private Sub SaveScore_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        '' Sets the form location to the location of the program from settings
        With My.Settings
            Me.Location = .FormLocation
        End With
    End Sub

    Private Sub SaveScore_Move(sender As Object, e As EventArgs) Handles Me.Move
        '' Stores the location of the form to the location setting for the program
        '' if the location of the form is different to the location setting
        With My.Settings
            If Me.Location <> .FormLocation Then
                .FormLocation = Me.Location
            End If
        End With
    End Sub

    Private Sub lblSave_Click(sender As System.Object, e As System.EventArgs) Handles lblSave.Click
        ''Sub to store the data the user has input to the database

        '' Variables for handling the database connection
        Dim oleDbcAdd As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim strAdd As String = ""

        '' Sets the connection string
        oleDbcAdd.ConnectionString = Con

        '' If the user hasn't entered their initials then a messagebox is shown.
        If txtPlayerName.Text = "" Then
            MsgBox("You must enter your initials before you can save.", , "Error")
            txtPlayerName.Focus()
            lblScore.Text = iScore
        ElseIf IsNumeric(txtPlayerName.Text) Then '' If the player has entered numbers for their initials then a message box is shown.
            MsgBox("Your initials must be letters, not numbers.", , "Error")
            txtPlayerName.Focus()
            lblScore.Text = iScore
            txtPlayerName.Text = ""
        ElseIf txtPlayerName.Text.Length < 3 Then
            MsgBox("You must enter 3 initials to save.", , "Error")
            txtPlayerName.Focus()
            lblScore.Text = iScore
            txtPlayerName.Text = ""
        Else '' Otherwise...
            '' Try to write the player name and score to the database
            Try
                strAdd = " insert into Scores (Name, Score) Values('" & _
                    txtPlayerName.Text.Replace("'", "") & "', '" & _
                    lblScore.Text.Replace("'", "") & "' )"

                oleDbcAdd.Open()
                cmd.CommandText = strAdd
                cmd.Connection = oleDbcAdd
                cmd.ExecuteNonQuery()

                '' If there is an error show a message box
            Catch ex As Exception
                MsgBox("Invalid data entered.", , "Error")
            Finally
                oleDbcAdd.Close()
            End Try

            '' Wipe the player initials and open the high score form.
            txtPlayerName.Text = ""
            Me.Hide()
            frmHighScore.Show()
        End If
    End Sub

    Private Sub lblBack_Click(sender As System.Object, e As System.EventArgs) Handles lblBack.Click
        '' Reopens the main form
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub SaveScore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' Displays the users score on the form.
        lblScore.Text = iScore
    End Sub
End Class