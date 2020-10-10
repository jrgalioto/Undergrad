Public Class CarRentalCalculator
    'author: Jim Galioto

    'global constants
    Const DAY_RATE As Decimal = 49.0
    Const MILEAGE_RATE As Decimal = 0.2

    Private Sub TotalMilesDrivenDecimalTextBox_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click

        'variables
        Dim BeginingOdometerDecimal As Decimal
        Dim EndingOdometerDecimal As Decimal
        Dim NumberOfDaysInteger As Integer
        Dim TotalMilesDrivenDecimal As Decimal
        Dim TotalCostDecimal As Decimal

        Try
            'convert begining to int
            BeginingOdometerDecimal = Decimal.Parse(BeginingOdometerTextBox.Text)

            Try
                'convert ending to int
                EndingOdometerDecimal = Decimal.Parse(EndingOdometerTextBox.Text)
                TotalMileDrivenLabel.Text = EndingOdometerDecimal - BeginingOdometerDecimal

                Try
                    'convert days and miles entries to int
                    NumberOfDaysInteger = Integer.Parse(NumberOfDaysTextBox.Text)
                    TotalMilesDrivenDecimal = Decimal.Parse(TotalMileDrivenLabel.Text)

                    'calculate cost
                    TotalCostDecimal = (NumberOfDaysInteger * DAY_RATE) + (TotalMilesDrivenDecimal * MILEAGE_RATE)
                    TotalPriceTextLabel.Text = TotalCostDecimal.ToString("c")

                Catch ex As Exception
                    'days entry is invalid exception
                    MessageBox.Show("Days entry is invalid", "Data entry error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    With NumberOfDaysTextBox
                        .Focus()
                        .SelectAll()
                    End With

                End Try

            Catch ex As Exception
                'if ending miles entry is invalid
                MessageBox.Show("Ending milage is invalid", "Data entry error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                With EndingOdometerTextBox
                    .Focus()
                    .SelectAll()
                End With

            End Try

        Catch ex As Exception
            'if beging miles entry is invalid
            MessageBox.Show("Starting milage is invalid", "Data entry error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BeginingOdometerTextBox.Focus()
            BeginingOdometerTextBox.SelectAll()

        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'exits application
        Application.Exit()

    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click

        'clears all fields
        BeginingOdometerTextBox.Clear()
        EndingOdometerTextBox.Clear()
        NumberOfDaysTextBox.Clear()
        TotalPriceTextLabel.Text = ""
        TotalMileDrivenLabel.Text = ""

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TotalPriceTextLabel_Click(sender As Object, e As EventArgs) Handles TotalPriceTextLabel.Click

    End Sub
End Class
