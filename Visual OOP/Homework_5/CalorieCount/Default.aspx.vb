
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        'create macro count
        Dim MacroCount As Macros

        Try
            MacroCount = New Macros(Integer.Parse(FatTextBox.Text),
                                    Integer.Parse(CarbsTextBox.Text),
                                    Integer.Parse(ProteinTextBox.Text))

            'output calorie total
            TotalCaloriesTextBox.Text = MacroCount.Calories()

        Catch ex As Exception
            ErrorLabel.Text = "You must enter a valid number."

        End Try
    End Sub

    Protected Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'clears totals
        ProteinTextBox.Text = ""
        CarbsTextBox.Text = ""
        FatTextBox.Text = ""

    End Sub
End Class
