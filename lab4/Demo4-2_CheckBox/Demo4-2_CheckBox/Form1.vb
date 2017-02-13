Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Pizza.Items.Clear()
        If RadioButton1.Checked = True Then
            Pizza.Items.Add(RadioButton1.Text)
        End If
        If RadioButton2.Checked = True Then
            Pizza.Items.Add(RadioButton2.Text)
        End If


        If CheckBox1.Checked = True Then
            Pizza.Items.Add(CheckBox1.Text)
        End If

        If CheckBox2.Checked = True Then
            Pizza.Items.Add(CheckBox2.Text)
        End If
    End Sub
End Class
