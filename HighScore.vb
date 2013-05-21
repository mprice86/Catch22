'' Imports the oleDB class
Imports System.Data.OleDb

Public Class frmHighScore

    '' Sets the path for the database connection
    Const Con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\HighScores.MDB"

    Private Sub HighScore_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        '' Sets the form location to the location of the program from settings
        With My.Settings
            Me.Location = .FormLocation
        End With

        '' Loads data into the high scores table and sorts it by score
        Me.ScoresTableAdapter.Fill(Me.HighScoresDataSet.Scores)
        DataGridView1.Sort(DataGridView1.Columns(1), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub HighScore_Move(sender As Object, e As EventArgs) Handles Me.Move
        '' Stores the location of the form to the location setting for the program
        '' if the location of the form is different to the location setting
        With My.Settings
            If Me.Location <> .FormLocation Then
                .FormLocation = Me.Location
            End If
        End With
    End Sub

    Private Sub lblBack_Click(sender As System.Object, e As System.EventArgs) Handles lblBack.Click
        '' Reopens the main form
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub lblExit_Click(sender As System.Object, e As System.EventArgs) Handles lblExit.Click
        '' Asks the user if they want to exit, if they do, the application is closed.
        Dim bExit As Byte = MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo, "Quit Game")
        If bExit = vbYes Then
            Application.Exit()
        End If
    End Sub
End Class