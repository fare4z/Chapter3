Public Class Homework1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblHeight As Double = txtHeight.Text
        Dim dblWeight As Double = txtWeight.Text
        Dim bmi As Double
        Dim category As String

        bmi = dblWeight / (dblHeight ^ 2)


        If bmi < 18.5 Then
            category = "Underweight"
        ElseIf bmi < 25 Then
            category = "Normal weight"
        ElseIf bmi < 30 Then
            category = "Overweight"
        Else
            category = "Obese"
        End If

        lblResult.Text = "Result : " & category.ToString

    End Sub
End Class