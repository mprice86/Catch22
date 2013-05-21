Public Class Help

    Private Sub Help_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        '' Sets the form location to the location of the program from settings
        With My.Settings
            Me.Location = .FormLocation
        End With
    End Sub

    Private Sub lblBack_Click(sender As System.Object, e As System.EventArgs) Handles lblBack.Click
        '' Reopens the main form
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Help_Move(sender As Object, e As EventArgs) Handles Me.Move
        '' Stores the location of the form to the location setting for the program
        '' if the location of the form is different to the location setting
        With My.Settings
            If Me.Location <> .FormLocation Then
                .FormLocation = Me.Location
            End If
        End With
    End Sub

End Class