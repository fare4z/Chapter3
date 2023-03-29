Public Class temperature

    Public Enum bulan
        January = 1
        February
        March
        April
        May
        June
        July
        August
        September
        October
        November
        Disember
    End Enum

    Private Sub temperature_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DataSource = [Enum].GetNames(GetType(bulan))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim temperature As Integer = TextBox1.Text

        If temperature >= 40 And temperature <= 43 Then
            '      If temperature > 40 Then
            Label1.Text = “A little cold, isn’t it?”
        Else
            Label1.Text = “Nice weather we’re having!”
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim grade As String = txtGrade.Text

        Select Case grade
            Case "A"
                MsgBox("Excellent")
            Case "B", "C", "D"
                MsgBox("Well Done")
            Case Else
                MsgBox("Invalid")
        End Select
        MsgBox(grade)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim strMonth As String = ComboBox1.SelectedItem

        If strMonth = "January" Then
            Label4.Text = "31 Days in " + strMonth

        ElseIf strMonth = "February" Then
            Label4.Text = "28 Days in " + strMonth
        ElseIf strMonth = "March" Then
            Label4.Text = "30 Days in " + strMonth
        Else
            Label4.Text = "Invalid"
        End If
    End Sub
End Class