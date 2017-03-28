Public Class Form1
    Private Sub colorBtn_Click(sender As Object, e As EventArgs) Handles colorBtn.Click
        If ColorDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Me.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub fontBtn_Click(sender As Object, e As EventArgs) Handles fontBtn.Click
        If FontDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            TextBox1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub imgBtn_Click(sender As Object, e As EventArgs) Handles imgBtn.Click
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Try
                PictureBox1.Image = New Bitmap(OpenFileDialog1.FileName)
            Catch ex As Exception
                MsgBox("Not an image")
            End Try
        End If
    End Sub
End Class
