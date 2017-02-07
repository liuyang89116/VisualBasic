Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles firstName.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles secondName.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles num1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles num2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sum.Text = Val(num1.Text) + Val(num2.Text)
    End Sub
End Class
