Public Class FormD
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles myprogress.Click

    End Sub

    Private Sub FormDefault_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        myprogress.Increment(10)
        Percentage.Text = Convert.ToString(myprogress.Value) + "%"
        If myprogress.Value = 100 Then
            Me.Hide()
            Dim log = New FormLog
            FormLog.Show()
            Timer1.Enabled = False
        End If
    End Sub
End Class
