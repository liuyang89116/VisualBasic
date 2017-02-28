Public Class Form1
    Private Function Inches(ByVal cm As String) As Double
        Inches = cm / 2.54
        Inches = FormatNumber(Inches, 2)
        Return Inches
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label3.Text = Inches(TextBox1.Text) & " inches"
    End Sub
End Class
