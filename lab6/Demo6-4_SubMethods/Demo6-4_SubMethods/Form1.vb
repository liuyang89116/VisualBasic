Public Class Form1
    Private Sub ClearForm()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Customer(ByVal name As String, ByVal addr As String)
        TextBox1.Text = name
        TextBox2.Text = addr
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ClearForm()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Customer("Yang", "265 AVH")
    End Sub
End Class
