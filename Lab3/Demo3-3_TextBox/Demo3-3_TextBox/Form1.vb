Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim length As Integer = Len(TextBox.Text)
        MsgBox("You typed " & Str(length) & " characters")

    End Sub
End Class
