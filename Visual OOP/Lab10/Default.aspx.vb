
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        'create book sale
        Dim BookSale As BookSale

        Try
            BookSale = New BookSale(Integer.Parse(QuantityTextBox.Text),
                                                  TitleTextBox.Text,
                                                  Convert.ToDecimal(PriceTextBox.Text))
            'output results
            ExtPriceTextBox.Text = BookSale.ExtPrice.ToString("c")
            DiscountTextBox.Text = BookSale.Discount.ToString("c")
            DiscoutedPriceTextBox.Text = BookSale.DiscountedPrice.ToString("c")

        Catch ex As Exception
            ErrorLabel.Text = "You must enter a valid price"

        End Try


    End Sub

    Protected Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

        QuantityTextBox.Text = ""
        TitleTextBox.Text = ""
        PriceTextBox.Text = ""
        ExtPriceTextBox.Text = ""
        DiscoutedPriceTextBox.Text = ""
        DiscountTextBox.Text = ""

    End Sub
End Class
