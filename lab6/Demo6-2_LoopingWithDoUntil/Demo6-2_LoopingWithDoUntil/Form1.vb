Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sales() As Double = {5641, 8579, 5463, 1258, 9678, 4891}
        Dim sum As String

        Dim counter As Integer
        Do Until counter = sales.Length
            sum = FormatCurrency(sales(counter))
            counter = counter + 1
            sum = sum & vbTab & MonthName(counter)
            ListBox1.Items.Add(sum)
        Loop
    End Sub
End Class
