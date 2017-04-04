Public Class Form1
    Friend WithEvents player As New System.Media.SoundPlayer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        player.Stream = My.Resources.Speech_On
        player.Play()
    End Sub
End Class
