Public Class Form1
    Private localStr As String = "This is localStr"
    Public globleStr As String = "This is globleStr"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim msg As String = "Hello this is button1"
        MsgBox(msg)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim msg As String = "Hello this is button2"
        MsgBox(msg)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox(globleStr & vbCrLf & localStr)
    End Sub
End Class
