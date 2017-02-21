Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sales(2, 1) As Double
        sales(0, 0) = 10.23 : sales(1, 0) = 1.1 : sales(2, 0) = 6.85
        sales(0, 1) = 3.68 : sales(1, 1) = 4.23 : sales(2, 1) = 98.21

        Dim store1, store2 As Double
        store1 = sales(0, 0) + sales(1, 0) + sales(2, 0)
        store2 = sales(0, 1) + sales(1, 1) + sales(2, 1)

        MsgBox("Quarter sales: " & vbCrLf &
               "Store 1: " & FormatCurrency(store1) & vbCrLf &
               "Store 2: " & FormatCurrency(store2))
    End Sub
End Class
