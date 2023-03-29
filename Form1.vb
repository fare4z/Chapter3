Public Class Form1
    Private Sub btnLab1_Click(sender As Object, e As EventArgs) Handles btnLab1.Click
        activity_1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLab2.Click
        activity_2.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        activity_3.Show()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Homework1.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Homework2.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        temperature.Show()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        AboutBox1.ShowDialog()

    End Sub
End Class
