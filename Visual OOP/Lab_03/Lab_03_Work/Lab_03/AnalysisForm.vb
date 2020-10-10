'Project: Lab #3
'Author: Jim Galioto
'Date: Spring 2019
'Description: Analysis of grades
'
Public Class AnalysisForm

    'constants
    Const MAX_INPUT_INTEGER As Integer = 10

    Private Sub SubmitResultButton_Click(sender As Object, e As EventArgs) Handles SubmitResultButton.Click
        'place good result on the listbox
        Dim ResultString As String

        'get what they typed in
        ResultString = ResultTextBox.Text.ToUpper

        ' validate in the input, (P or F)
        If (ResultString = "P") Then
            'result = P
            ResultsListBox.Items.Insert(0, ResultString)
        Else
            If (ResultString = "F") Then
                'result = F
                ResultsListBox.Items.Insert(0, ResultString)
            Else
                'not P or F
                MessageBox.Show("You must enter a P or F", "Entry error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

        'clear/focus
        ResultTextBox.Clear()
        ResultTextBox.Focus()

        'check if we have 10 inputs
        If ResultsListBox.Items.Count = MAX_INPUT_INTEGER Then
            'disable input
            ResultTextBox.Enabled = False
            SubmitResultButton.Enabled = False
            'enable analysis
            AnalyzeResultsButton.Enabled = True
        End If

    End Sub

    Private Sub ClearResultsButton_Click(sender As Object, e As EventArgs) Handles ClearResultsButton.Click

        'reset form
        ResultTextBox.Enabled = True
        SubmitResultButton.Enabled = True
        AnalyzeResultsButton.Enabled = False
        AnalysisResultsLabel.Text = ""
        ResultsListBox.Items.Clear()
        ResultTextBox.Focus()

    End Sub

    Private Sub AnalyzeResultsButton_Click(sender As Object, e As EventArgs) Handles AnalyzeResultsButton.Click
        Dim PassesInteger, FailureInteger, CounterInteger As Integer
        Dim ResultString As String

        'loop through results
        Do While (CounterInteger < 10)
            'iterate through items collection
            ResultString = ResultsListBox.Items(CounterInteger)

            If (ResultString = "P") Then
                PassesInteger += 1
            Else
                FailureInteger += 1
            End If
            'incriment our counter
            CounterInteger += 1

            'display exam results
            AnalysisResultsLabel.Text = "Passed: " & PassesInteger.ToString & ControlChars.NewLine &
                "Failed: " & FailureInteger.ToString
        Loop

    End Sub
End Class ' Analysis

