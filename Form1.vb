Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim counter, sum As Integer
        For counter = 1 To 100 Step 10
            sum += counter
            ListBox1.Items.Add(sum)
        Next
    End Sub
End Class
