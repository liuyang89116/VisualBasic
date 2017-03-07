Public Class Form1
    Private Sub Clear()
        Label1.Text = "..."
        Label2.Text = "..."
        Label3.Text = "..."
        Label4.Text = "..."
        Label5.Text = "..."
        Label6.Text = "..."

        pickBtn.Enabled = True
        resetBtn.Enabled = False

        ' start random number generator
        Randomize()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
    End Sub

    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        Clear()
    End Sub

    Private Sub pickBtn_Click(sender As Object, e As EventArgs) Handles pickBtn.Click
        ' declare working variables
        Dim i, r, tmp, nums(50)

        ' fill elements 1-49 to nums
        For i = 1 To 49
            nums(i) = i
        Next

        ' shuffle the values in elements 1 to 49
        For i = 1 To 49
            r = Int(49 * Rnd()) + 1
            tmp = nums(i)
            nums(i) = nums(r)
            nums(r) = tmp
        Next

        ' display the values
        Label1.Text = nums(1)
        Label2.Text = nums(2)
        Label3.Text = nums(3)
        Label4.Text = nums(4)
        Label5.Text = nums(5)
        Label6.Text = nums(6)

        ' set the button status
        pickBtn.Enabled = False
        resetBtn.Enabled = True

    End Sub
End Class
