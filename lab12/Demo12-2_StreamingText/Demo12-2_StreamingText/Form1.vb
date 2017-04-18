Public Class Form1
    Dim txt As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .Title = "Open File"
            .Filter = "Text Document | *.txt"
            .FileName = ""
            .CheckFileExists = True
        End With

        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim stream As New System.IO.FileStream(OpenFileDialog1.FileName, System.IO.FileMode.Open)
            Dim reader As New System.IO.StreamReader(stream)
            txt = reader.ReadToEnd()
            reader.Dispose() : stream.Dispose()
            TextBox1.Text = txt
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PrintDialog1.AllowSomePages = True
        PrintDialog1.ShowHelp = True
        If PrintDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            If txt <> "" Then
                PrintDocument1.Print()
            End If
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(txt, Me.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic)
    End Sub
End Class
