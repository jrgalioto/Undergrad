'Program:		Lab #8
'Programmer:	Your Name
'Date:			Today's Date
'Description:	Calculate sales price using the BookSale class.
'				Instantiate TheBookSale as a new object of the BookSale class.

Public Class SalesForm
    ' Declare the new object.
    Private TheBookSale As BookSale


    Private Sub CalculateSaleToolStripMenuItem_Click(ByVal sender As System.Object,
     ByVal e As System.EventArgs) Handles CalculateSaleToolStripMenuItem.Click
        ' Calculate the extended price for the sale.

        Try
            ' Instantiate the BookSale object and set the properties.
            TheBookSale = New BookSale(TitleTextBox.Text,
                  Integer.Parse(QuantityTextBox.Text), Decimal.Parse(PriceTextBox.Text))
            ' Calculate and format the result.
            ExtendedPriceTextBox.Text = TheBookSale.ExtendedPrice.ToString("N")
        Catch ex As Exception
            MessageBox.Show("Enter numeric data.", "R 'n R Book Sales",
              MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object,
      ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        ' Clear the screen controls.

        QuantityTextBox.Clear()
        PriceTextBox.Clear()
        ExtendedPriceTextBox.Clear()
        With TitleTextBox
            .Clear()
            .Focus()
        End With
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object,
      ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ' Exit the program.

        Me.Close()
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(ByVal sender As System.Object,
      ByVal e As System.EventArgs) Handles SummaryToolStripMenuItem.Click
        ' Display the sales summary information.


    End Sub
End Class
