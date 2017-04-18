Public Class Form1
    Private Sub readBtn_Click(sender As Object, e As EventArgs) Handles readBtn.Click
        DataSet1.ReadXml("C:\Users\Yang\Desktop\books.xml")
        DataGridView1.DataSource = DataSet1
        DataGridView1.DataMember = "book"
    End Sub

    Private Sub writeBtn_Click(sender As Object, e As EventArgs) Handles writeBtn.Click
        DataSet1.WriteXml("C:\Users\Yang\Desktop\books.xml")
    End Sub
End Class
