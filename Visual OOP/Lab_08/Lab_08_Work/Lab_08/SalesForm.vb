'Program:		Lab #7
'Programmer:	Jim Galioto
'Date:			4/3/19
'Description:	Calculate sales price using the BookSale class.
'				Instantiate TheBookSale as a new object of the BookSale class.

Public Class SalesForm
	' Declare the new object.
	Dim TheBookSale As New BookSale
	Dim TheBookSale2 As New BookSale


	Private Sub CalculateSaleToolStripMenuItem_Click(ByVal sender As System.Object,
     ByVal e As System.EventArgs) Handles CalculateSaleToolStripMenuItem.Click
		Try
			' Calculate the extended price for the sale.
			TheBookSale = New BookSale(TitleTextBox.Text,
									   Integer.Parse(QuantityTextBox.Text),
									   Decimal.Parse(PriceTextBox.Text))

			'output the resule
			ExtendedPriceTextBox.Text = TheBookSale.ExtendedPrice.ToString("c")

		Catch ex As FormatException
			'bad quantity
		Catch ex1 As ArgumentOutOfRangeException
			'catch errors thrown by class
			MessageBox.Show(ex1.Message)
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
		Dim MessageString As String
		MessageString = "Sales Count: " & BookSale.SalesCount.ToString & vbCrLf
		MessageString &= "Sales Total: " & BookSale.SalesTotal.ToString("c")

		MessageBox.Show(MessageString)

	End Sub

	Private Sub TitleTextBox_TextChanged(sender As Object, e As EventArgs) Handles TitleTextBox.TextChanged

	End Sub

	Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
		'AboutBox1.Show()                        'modeless
		AboutBox1.ShowDialog()                  'modally

	End Sub
End Class
