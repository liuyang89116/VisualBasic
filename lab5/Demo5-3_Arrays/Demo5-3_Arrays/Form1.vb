Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sales(2) As Double
        sales(0) = 0.1
        sales(1) = 0.2
        sales(2) = 0.3
        Dim sum As Double = sales(0) + sales(1) + sales(2)
        MsgBox("Quarter sales: " & FormatCurrency(sum))

    End Sub
End Class
