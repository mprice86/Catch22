'' Class to define the Bucket
Public Class Bucket
    '' Attributes 
    Public bSpeed As Byte = 30
    Public bmoveDir As Byte
    Public rBucket As Rectangle
    Public bmpBucket As Bitmap

    Public Sub New(ByVal spawnPoint As Point)
        '' Property controlling the creation of a new bucket
        rBucket = New Rectangle(Form1.bBucketWidth, Form1.bBucketHeight, Form1.bBucketWidth, Form1.bBucketHeight)
        '' spawn point for bucket
        rBucket.Location = (spawnPoint)
        '' Sets the image for the bucket
        bmpBucket = New Bitmap(Application.StartupPath & "\bucket.bmp")
    End Sub

    Public Sub move(ByVal dir As Boolean) '' True = right, False = left
        '' Movement property
        Select Case dir
            Case Is = True
                If rBucket.Location.X >= 535 - rBucket.Width Then
                    Exit Sub
                Else
                    rBucket.Location = rBucket.Location + New Point(bSpeed, 0)
                End If
            Case Is = False
                If rBucket.Location.X <= 0 Then
                    Exit Sub
                Else
                    rBucket.Location = rBucket.Location + New Point(-bSpeed, 0)
                End If
        End Select
    End Sub

End Class


