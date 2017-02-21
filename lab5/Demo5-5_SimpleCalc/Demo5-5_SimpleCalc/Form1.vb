Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' addition function
        ans.Text = "The answer is: " & Str(Val(num1.Text) + Val(num2.Text))

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' substraction function
        ans.Text = "The answer is: " & Str(Val(num1.Text) - Val(num2.Text))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' division function
        ans.Text = "The answer is: " & Str(Val(num1.Text) / Val(num2.Text))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' multiplication function
        ans.Text = "The answer is: " & Str(Val(num1.Text) * Val(num2.Text))
    End Sub
End Class
