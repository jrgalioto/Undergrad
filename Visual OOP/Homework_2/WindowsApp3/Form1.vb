Public Class CoffeeOrderForm

    Dim CAPPUCCINO_PRICE As Decimal = 3.5
    Dim ESPRESSO_PRICE As Decimal = 3.0
    Dim LATTE_PRICE As Decimal = 2.25
    Dim ICED_LATTE_PRICE As Decimal = 2.75
    Dim ICED_CAPPUCCINO_PRICE As Decimal = 2.75
    Dim TAKEOUT_TAX As Decimal = 0.0725

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles ItemAmountLabel.Click

    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click

        'variables declaration
        Dim QuantityInteger As Integer
        Dim ItemAmmountDecimal As Decimal

        'validate quantity is valid entry
        Try
            QuantityInteger = Integer.Parse(QuantityTextBox.Text)

            'calculate the price based on selection
            If (CappuccinoRadioButton.Checked) Then
                ItemAmmountDecimal = QuantityInteger * CAPPUCCINO_PRICE

            ElseIf (EspressoRadioButton.Checked) Then
                ItemAmmountDecimal = QuantityInteger * ESPRESSO_PRICE

            ElseIf (LatteRadioButton.Checked) Then
                ItemAmmountDecimal = QuantityInteger * LATTE_PRICE

            ElseIf (IcedLatteRadioButton.Checked) Then
                ItemAmmountDecimal = QuantityInteger * ICED_LATTE_PRICE

            Else
                ItemAmmountDecimal = QuantityInteger * ICED_CAPPUCCINO_PRICE

            End If

            'recaluculate price if takeout = false
            If (TakeoutCheckBox.Checked) Then
                ItemAmountTextLabel.Text = ItemAmmountDecimal.ToString("c")
            Else
                ItemAmountTextLabel.Text = ((ItemAmmountDecimal * TAKEOUT_TAX) + ItemAmmountDecimal).ToString("c")
            End If

        Catch ex As Exception
            'if entry is invalid
            MessageBox.Show("You must enter a numberic quantity.",
                            "Nice try, jackass.",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk)

            'place curser in quantity box
            With QuantityTextBox
                .Focus()
                .SelectAll()
            End With

        End Try

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class
