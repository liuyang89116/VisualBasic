Public Class Form1
    Private Sub openBtn_Click(sender As Object, e As EventArgs) Handles openBtn.Click
        With OpenFileDialog1
            .Title = "Open File"
            .Filter = "Rich Text Files | *.rtf"
            .FileName = ""
            .CheckFileExists = True
        End With

        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.RichText)
        End If
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        With SaveFileDialog1
            .Title = "Save File"
            .Filter = "Rich Text Files | *.rtf"
            .DefaultExt = ".rtf"
            .OverwritePrompt = True
        End With

        If SaveFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText)
        End If
    End Sub

    Private Sub printBtn_Click(sender As Object, e As EventArgs) Handles printBtn.Click
        If PrintDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            PrintDialog1.Document.Print()
        End If
    End Sub
End Class
