Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' create variables
        Dim flag As Boolean = False
        Dim str As String = "CSCE101"
        Dim intNum As Integer = 10
        Dim doubleNum As Double = 8.8

        ' add variables in listbox
        ListBox1.Items.Add("flag value is " & flag)
        ListBox1.Items.Add("str value is " & str)
        ListBox1.Items.Add("intNum value is " & intNum)
        ListBox1.Items.Add("doubleNum value is " & doubleNum)
    End Sub
End Class
