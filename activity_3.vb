Public Class activity_3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim marks As Integer = txtMark.Text
        Dim grade As String

        Select Case marks
            Case 80 To 100
                grade = “A”
            Case 70 To 79
                grade = “B”
            Case 60 To 69
                grade = “C”
            Case 50 To 59
                grade = “D”
            Case 0 To 49
                grade = “F”
            Case Else
                MessageBox.Show(“Invalid marks”, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select

        txtGrade.Text = grade
    End Sub
End Class