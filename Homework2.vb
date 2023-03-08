Public Class Homework2

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
    Private Sub Homework2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DataSource = [Enum].GetValues(GetType(bulan))
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim MonthName As String = ComboBox1.SelectedItem.ToString
        Dim days As Integer
        Select Case MonthName
            Case "January", "March", "May", "July", "August", "October", "December"
                days = 31
            Case "April", "June", "September", "November"
                days = 30
            Case "February"
                days = 28
            Case Else
                days = -1 ' Invalid input
        End Select

        lblOutput.Text = days & " days in " & MonthName

    End Sub
End Class