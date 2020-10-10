'Project: Lab #1
'Name: Jim Galioto
'Description: This program displays 4 different sayings the screen



Public Class GreetingsForm
    Private Sub Saying1Button_Click(sender As Object, e As EventArgs) Handles Saying1Button.Click
        'This is what runs when somebody clicks on saying1button
        MessageLabel.Text = "Let's go Pens!
"
    End Sub

    Private Sub Saying2Button_Click(sender As Object, e As EventArgs) Handles Saying2Button.Click
        MessageLabel.Text = "A penny saved is..."

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'close the program
        Me.Close()

    End Sub

    Private Sub Saying3Button_Click(sender As Object, e As EventArgs) Handles Saying3Button.Click
        MessageLabel.Text = "I don't understand hockey."
    End Sub

    Private Sub Saying4Button_Click(sender As Object, e As EventArgs) Handles Saying4Button.Click
        MessageLabel.Text = ":-)"

    End Sub

    Private Sub MessageLabel_Click(sender As Object, e As EventArgs) Handles MessageLabel.Click

    End Sub
End Class
