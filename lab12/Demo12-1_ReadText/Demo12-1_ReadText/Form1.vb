Public Class Form1
    Dim myFile As String = "D:\code\VisualBasic\lab12\Demo12-1_ReadText\log.txt"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.FileSystem.WriteAllText(myFile, TextBox1.Text & vbCrLf, True)
        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            TextBox2.Text = My.Computer.FileSystem.ReadAllText(myFile)
        Catch ex As Exception
            TextBox2.Text = "Unable to read from " & myFile
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        If My.Computer.FileSystem.FileExists(myFile) Then
            My.Computer.FileSystem.DeleteFile(myFile)
        End If
    End Sub
End Class
