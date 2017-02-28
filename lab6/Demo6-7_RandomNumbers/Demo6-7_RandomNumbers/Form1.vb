Public Class Form1
    Dim num As Integer

    Private Sub GetNumber()
        num = Math.Ceiling(Rnd() * 20)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        GetNumber()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case (Val(guess.Text))
            Case Is > num
                msg.Text = guess.Text & " is too high"
            Case Is < num
                msg.Text = guess.Text & " is too low"
            Case Is = num
                msg.Text = guess.Text & " is correct " & "and I have another number. Try Again."
                GetNumber()
        End Select
        guess.Text = ""
        guess.Focus()
    End Sub

    Private Sub msg_Click(sender As Object, e As EventArgs) Handles msg.Click

    End Sub
End Class
