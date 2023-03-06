Public Class Form1



    Enum DaysOfWeek
        Sunday = 1
        Monday
        Tuesday
        Wednesday
        Thursday
        Friday
        Saturday
    End Enum

    Public Enum JabatanSelection
        JTMK = 1
        JP
        JKE
        JKM
    End Enum


    Public Sub test(ByVal dir As JabatanSelection)
        If (dir = JabatanSelection.JTMK) Then
            MsgBox("JTMK")
        ElseIf (dir = JabatanSelection.JP) Then
            MsgBox("JP")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        test(ComboBox1.SelectedItem)

        If (ComboBox1.SelectedItem = JabatanSelection.JTMK) Then
            MsgBox("Greee")
        End If

        Dim today As DaysOfWeek = DaysOfWeek.Tuesday

        If today = DaysOfWeek.Saturday Or today = DaysOfWeek.Sunday Then
            MsgBox("It's the weekend!")
        Else
            MsgBox("It's a weekday.")
        End If


        MsgBox(ComboBox1.SelectedItem)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DataSource = [Enum].GetValues(GetType(JabatanSelection))



    End Sub
End Class
