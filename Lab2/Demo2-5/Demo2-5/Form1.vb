Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sum.Text = Val(num1.Text) + Val(num2.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sum.Text = "Result"
        num1.Text = ""
        num2.Text = ""
    End Sub
End Class
