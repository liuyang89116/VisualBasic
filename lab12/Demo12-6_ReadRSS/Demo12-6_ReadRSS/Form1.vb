Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rssUrl = "http://xml.weather.yahoo.com/forecastrss?p=" + zipcode.Text
        Dim rssRequest As System.Net.WebRequest = System.Net.WebRequest.Create(rssUrl)

        Dim rssResponse As System.Net.WebResponse = rssRequest.GetResponse()

        Dim rssStream As System.IO.Stream = rssResponse.GetResponseStream()
        Dim rssDoc As New System.Xml.XmlDocument
        rssDoc.Load(rssStream)

        Dim nodes As System.Xml.XmlNodeList
        nodes = rssDoc.SelectNodes("/rss/channel")
        GroupBox1.Text = nodes.Item(0).SelectSingleNode("title").InnerText


    End Sub
End Class
