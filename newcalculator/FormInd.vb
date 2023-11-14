Public Class FormInd
    Dim grade As Integer
    Dim num1 As Integer
    Dim num2 As Integer
    Dim userAnswer As Integer
    Dim trials As Integer

    Private Sub FormInd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        grade = ComboBox1.SelectedIndex + 1
    End Sub

    Private Sub BtnGenerate_Click(sender As Object, e As EventArgs) Handles BtnGenerate.Click

        Label1.Text = ""
        Label2.Text = ""
        Label5.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        userAnswer = 0
        trials = 0


        Select Case grade
            Case 1
                num1 = Int(Rnd() * 10)
                num2 = Int(Rnd() * 10)
                Label1.Text = num1.ToString()
                Label2.Text = num2.ToString()

            Case 2
                num1 = Int(Rnd() * 90) + 10
                num2 = Int(Rnd() * 90) + 10
                Label1.Text = num1.ToString()
                Label2.Text = num2.ToString()

            Case 3
                num1 = Int(Rnd() * 90) + 10
                num2 = Int(Rnd() * 90) + 10
                Label1.Text = num1.ToString()
                Label2.Text = num2.ToString()

        End Select
    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        Label5.Text = "What is " & num1 & " " & TextBox1.Text & " " & num2 & " ?"
    End Sub

    Private Sub Clear()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim op As String = TextBox1.Text.Trim()
        If TextBox1.Text.Trim() = "" Or TextBox2.Text.Trim() = "" Then
            MessageBox.Show("Operator and answer cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not Integer.TryParse(TextBox2.Text.Trim(), userAnswer) Then
            MessageBox.Show("Invalid input for answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf op = "+" Then

            Dim expectedAnswer As Integer = num1 + num2

                If Integer.TryParse(TextBox2.Text.Trim(), userAnswer) Then

                If userAnswer = expectedAnswer Then
                    MessageBox.Show("Very Very Correct!")
                    Clear()
                Else
                        MessageBox.Show("Your Answer is Incorrect! Please Try again!")
                        trials += 1
                        If trials > 5 Then
                            MessageBox.Show("Number of trials exceeded 5. Correct answer is " & expectedAnswer & ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Clear()
                        End If
                    End If
                End If
            ElseIf op = "-" Then
                Dim expectedAnswer As Integer = num1 - num2

                If Integer.TryParse(TextBox2.Text.Trim(), userAnswer) Then

                If userAnswer = expectedAnswer Then
                    MessageBox.Show("Very Very Correct!")
                    Clear()
                Else
                        MessageBox.Show("Your Answer is Incorrect! Please Try again!")
                        trials += 1
                        If trials > 5 Then
                            MessageBox.Show("Number of trials exceeded 5. Correct answer is " & expectedAnswer & ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Clear()
                        End If
                    End If
                End If
            ElseIf op = "*" Then
                Dim expectedAnswer As Integer = num1 * num2

                If Integer.TryParse(TextBox2.Text.Trim(), userAnswer) Then

                If userAnswer = expectedAnswer Then
                    MessageBox.Show("Very Very Correct!")
                    Clear()
                Else
                    MessageBox.Show("Your Answer is Incorrect! Please Try again!")
                    trials += 1
                        If trials > 5 Then
                            MessageBox.Show("Number of trials exceeded 5. Correct answer is " & expectedAnswer & ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Clear()
                        End If
                    End If
                End If
            ElseIf op = "/" Then
                Dim expectedAnswer As Integer = num1 / num2

                If Integer.TryParse(TextBox2.Text.Trim(), userAnswer) Then

                If userAnswer = expectedAnswer Then
                    MessageBox.Show("Very Very Correct!")
                    Clear()
                Else
                        MessageBox.Show("Your Answer is Incorrect! Please Try again!")
                        trials += 1
                        If trials > 5 Then
                            MessageBox.Show("Number of trials exceeded 5. Correct answer is " & expectedAnswer & ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Clear()
                        End If
                    End If
                End If
            Else
                MessageBox.Show("Invalid arithmetic sign.")

            End If
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to quit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class