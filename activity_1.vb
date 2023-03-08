Public Class activity_1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim marks As Integer = txtMark.Text
        Dim grade As String
        If marks >= 80 And marks <= 100 Then
            grade = "A"
        ElseIf marks >= 70 And marks <= 79 Then
            grade = "B"
        ElseIf marks >= 60 And marks <= 69 Then
            grade = "C"
        ElseIf marks >= 50 And marks <= 59 Then
            grade = "D"
        Else
            grade = "E"
        End If

        txtGrade.Text = grade
    End Sub

End Class