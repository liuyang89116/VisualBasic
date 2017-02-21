Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Weekday(Now)
            Case Is = vbMonday
                Label1.Text = "It's Monday"
            Case Is = vbTuesday
                Label1.Text = "It's Tuesday"
            Case Is = vbWednesday
                Label1.Text = "It's Wednesday"
            Case Is = vbThursday
                Label1.Text = "It's Thursday"
            Case Is = vbFriday
                Label1.Text = "It's Friday"
            Case Else
                Label1.Text = "It's weekend! Let's party"
        End Select
    End Sub
End Class
