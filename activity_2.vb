Public Class activity_2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim intSalary As Integer = CInt(txtIncome.Text)
		Dim intYears As Integer = txtYear.Text

		If intSalary > 30000 Then
			If intYears > 2 Then
				lblStatus.Text = “Applicant qualifies."
			Else
				lblStatus.Text = “Applicant does not qualify."
			End If
		Else
			If intYears > 5 Then
				lblStatus.Text = “Applicant qualifies."
			Else
				lblStatus.Text = “Applicant does not qualify."
			End If
		End If

	End Sub
End Class