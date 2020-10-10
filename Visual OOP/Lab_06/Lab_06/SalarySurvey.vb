'Project: Lab 6 
'Author: Anthony DePinto 
'Date: Spring 2019
'Description: Description of the form being created 

Public Class SalarySurvey
    Dim TotalInteger(9)

    Const SALARY_BASE_DECIMAL As Decimal = 100
    Const COMMISSION_RATE_DECIMAL As Decimal = 0.2

    ' handles Calculate Button's Click event
    Private Sub calculateButton_Click(sender As Object,
       e As EventArgs) Handles calculateButton.Click

        ' get sales amount entered
        Dim SalesAmountDecimal As Decimal
        Dim SalaryDecimal As Decimal
        Dim IndexInteger As Integer

        Try
            SalesAmountDecimal = Convert.ToDecimal(amountTextBox.Text)
            ' validate sales amount

            'compute salary
            SalaryDecimal = SALARY_BASE_DECIMAL + (SalesAmountDecimal * COMMISSION_RATE_DECIMAL)

            'compute index for the array based on the salary
            IndexInteger = Convert.ToInt32(Math.Truncate(SalaryDecimal / 100)) - 1

            'increment the appropriate salary category
            TotalInteger(IndexInteger) += 1
            IndexInteger = Math.Min(IndexInteger, TotalInteger.GetUpperBound(0))
            'update display
            UpdateValue()

            'clear input
            amountTextBox.Clear()

        Catch ex As FormatException
            MessageBox.Show("You must enter a valid amount.",
                            "Data Entry Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)

            amountTextBox.Focus()
            amountTextBox.SelectAll()
        End Try





    End Sub ' calculateButton_Click

    Private Sub rangesLabel_Click(sender As Object, e As EventArgs) Handles rangesLabel.Click

    End Sub

    Private Sub SalarySurvey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RangeString As String
        ' initialization tasks, 
        ' happens ONCE

        RangeString = String.Format("$100-100{0}$200-299{0}$300-399{0}$400-499{0}$500-599{0}$600-699{0}$700-799{0}$800-899{0}$900-999{0}$1000 and over{0}", ControlChars.NewLine)
        rangesLabel.Text = RangeString

        UpdateValue()


    End Sub

    Sub UpdateValue()
        Dim OutputString As String = ""
        ' For CounterInteger As Integer = 0 To TotalInteger.GetUpperBound(0)
        ' OutputString = OutputString & TotalInteger(CounterInteger) & vbCrLf

        For Each valueInteger As Integer In TotalInteger
            OutputString &= valueInteger & vbCrLf

        Next

        'Next

        valuesLabel.Text = OutputString

    End Sub
End Class ' SalarySurvey
