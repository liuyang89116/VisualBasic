Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(BookList.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BookList.Items.Add("HTML in eays steps")
        BookList.Items.Add("Effective Java")
        BookList.Items.Add("Design Pattern")
        BookList.Items.Add("CSCE101")
        BookList.Items.Add("Python")

        BookList.Sorted = True
        BookList.SelectedIndex = 0
        Me.Text = "We have " & BookList.Items.Count & " books in the list"
    End Sub
End Class
