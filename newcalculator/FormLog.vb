Public Class FormLog
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Clear()
        txtName.Clear()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim name As String = txtName.Text
        Dim age As Integer = Date.Now.Year - DateTimePicker1.Value.Year
        If DateTimePicker1.Value > Date.Now.AddYears(-age) Then age -= 1
        If age < 4 Then
            MessageBox.Show("Oooops! " & name & " you are too young for this.")

        ElseIf age > 8 Then
            MessageBox.Show("Oooh, " & name & " this is too basic for you.")

        Else
            Dim frmIndex As New FormInd()
            frmIndex.Show()
            Me.Hide()
        End If
        Clear()

    End Sub

    Private Sub FormLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class