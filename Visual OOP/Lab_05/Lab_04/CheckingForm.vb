'Project:     Lab 5
'Programmer:  Jim Galioto
'Date:        Spring 2019
'Description: This project maintains a checking account balance.
'             The requested transaction is calculated and 
'             the new balance is displayed.
'             A summary includes all transactions.

Public Class CheckingForm
    'class level variables
    Dim BalanceDecimal As Decimal = 100 'holds our balance
    Const SERVICE_CHARGE_DECIMAL As Decimal = 10.0


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
                If DepositRadioButton.Checked = True Then
                    'deposit
                    BalanceDecimal = Deposit(BalanceDecimal, AmountDecimal)

                ElseIf ChargeRadioButton.Checked = True Then
                    'service charge
                    BalanceDecimal = ServiceCharge(BalanceDecimal, AmountDecimal)

                Else
                    'check
                    If (AmountDecimal > BalanceDecimal) Then
                        'not enough money 
                        MessageBox.Show("Insufficient Funds")
                        BalanceDecimal = ServiceCharge(BalanceDecimal)

                    Else
                        'perform withdrawl
                        Check(AmountDecimal, BalanceDecimal)

                    End If

                End If

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

        'output account balance
        DisplayBalance()

    End Sub

    'deposit method
    Function Deposit(BalanceDecimal As Decimal,
                     AmountDecimal As Decimal) As Decimal
        Dim NewBalanceDecimal As Decimal
        NewBalanceDecimal = BalanceDecimal + AmountDecimal

        Return NewBalanceDecimal
    End Function

    'service change function
    Function ServiceCharge(inBalanceDecimal As Decimal,
                           Optional inAmmountDecimal As Decimal = SERVICE_CHARGE_DECIMAL) As Decimal
        'apply service chanrge
        Return inBalanceDecimal - inAmmountDecimal
    End Function


    Sub DisplayBalance()
        'display our balance
        BalanceTextBox.Text = BalanceDecimal.ToString("c")
    End Sub


    Private Sub CheckingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'we can do initialization work 
        DisplayBalance()
    End Sub


    Sub Check(inAmountDecimal As Decimal,
              ByRef inBalanceDecimal As Decimal)
        BalanceDecimal = inAmountDecimal - inBalanceDecimal
    End Sub

End Class

