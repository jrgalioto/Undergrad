'Project:     Lab 4
'Programmer:  Jim Galioto
'Date:        Fall 2018
'Description: This project maintains a checking account balance.
'             The requested transaction is calculated and 
'             the new balance is displayed.
'             A summary includes all transactions.

Public Class CheckingForm
    'Accumilated value variable
    Dim BalanceDecimal As Decimal
    Dim SERVICE_CHARGE_DECIMAL As Decimal = 10.0
    Dim DepositCountInteger As Integer
    Dim DepositTotalDecimal As Decimal


    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'End the program

        Me.Close()
    End Sub

    Private Sub CalculateTextBox_Click(sender As Object, e As EventArgs) Handles CalculateTextBox.Click
        'Calculate the transaction and display the new balance.
        Dim AmountDecimal As Decimal

        If DepositRadioButton.Checked Or CheckRadioButton.Checked Or ChargeRadioButton.Checked Then
            Try
                AmountDecimal = Decimal.Parse(AmountTextBox.Text)

                'Calculate each transaction and keep track of summary information.
                If DepositRadioButton.Checked Then
                    'deposit is checked
                    BalanceDecimal = AmountDecimal + BalanceDecimal
                    DepositCountInteger += 1
                    DepositTotalDecimal += AmountDecimal

                ElseIf CheckRadioButton.Checked Then
                    'check withdrawl is checked

                    If (BalanceDecimal < AmountDecimal) Then
                        MessageBox.Show("You don't have money. ")
                    Else
                        BalanceDecimal = BalanceDecimal - AmountDecimal

                    End If

                Else
                    'service charge is checked
                    BalanceDecimal = BalanceDecimal - SERVICE_CHARGE_DECIMAL

                End If

                'output result
                BalanceTextBox.Text = BalanceDecimal.ToString("c")
            Catch AmountException As FormatException
                MessageBox.Show("Please make sure that only numeric data has been entered.",
                    "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With AmountTextBox
                    .Focus()
                    .SelectAll()
                End With

            Catch AnyException As Exception
                MessageBox.Show("Error: " & AnyException.Message)
            End Try
        Else
            MessageBox.Show("Please select deposit, check, or service charge", "Input needed")
        End If

    End Sub

    Private Sub DepositRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DepositRadioButton.CheckedChanged

    End Sub

    Private Sub ClearTextBox_Click(sender As Object, e As EventArgs) Handles ClearTextBox.Click
        AmountTextBox.Text = ""
        DepositRadioButton.Checked = True
        DepositRadioButton.Checked = False


    End Sub

    Private Sub CheckingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BalanceTextBox.Text = BalanceDecimal.ToString("c")

    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        'output summary results
        Dim ResultString As String

        'build my output
        ResultString = "Total Deposit Count: " & DepositCountInteger.ToString & ControlChars.NewLine
        ResultString &= "Total Deposit Ammount: " & DepositTotalDecimal.ToString & ControlChars.NewLine
        ResultString &= "Tota; Service Charges: " & 


        'put it on string
        MessageBox.Show(ResultString, "Account Summary: ")
    End Sub
End Class

