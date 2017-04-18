Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim doc As New System.Xml.XmlDocument
        doc.Load("C:\Users\Yang\Desktop\books.xml")

        Dim nodes As System.Xml.XmlNodeList
        nodes = doc.SelectNodes("shelf/book")

        Dim count = 0
        Do Until count = nodes.Count
            ListBox1.Items.Add(nodes.Item(count).SelectSingleNode("title").InnerText & " by " & nodes.Item(count).SelectSingleNode("author").InnerText & vbCrLf)
            count += 1
        Loop

    End Sub
End Class
