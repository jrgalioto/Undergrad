Public Class BookSale
	'Properties of sale
	'Dim at class level = private
	Dim TitleString As String                                       'title of book
	Dim QuantityInteger As Integer                                  'number of a book
	Dim PriceDecimal, ExtendedPriceDecimal As Decimal               'price of book

	'autoimplimented property
	Public Property Title As String                                 'when you do not need any business logic in your property

	Public Property Quantity As Integer
		Get
			Return QuantityInteger
		End Get
		Set(value As Integer)
			If value < 1 Then
				'bad value
				Throw New ArgumentOutOfRangeException("Quantity must be greater than 0")
			End If
			'good value
			QuantityInteger = value
		End Set
	End Property

	Public Property Price As Decimal
		Get
			Return PriceDecimal
		End Get
		Set(value As Decimal)
			'bad value
			If value <= 0 Then
				Throw New ArgumentOutOfRangeException("Price must be greater than 0")
			End If
			'good value
			PriceDecimal = value
		End Set
	End Property

	Public ReadOnly Property ExtendedPrice As Decimal
		Get
			Return ExtendedPriceDecimal
		End Get
	End Property

	'Shared properties
	'Private Shared SalesCountInteger As Integer
	'Private Shared SalesTotalDecimal As Decimal
	Public Shared Property SalesCount As Integer
	Public Shared Property SalesTotal As Decimal


	'Constructor
	'default constructor provided
	Public Sub New()

	End Sub

	'overloaded new()
	Public Sub New(inTitle As String,
				   inQuantity As Integer,
				   InPrice As Decimal)
		'set the properties
		'I have access to private instance variables
		TitleString = inTitle
		'if there is a property that is defined, use it rather than the instance variable
		Quantity = inQuantity
		Price = InPrice
		'calculate extended price
		CalculateExtendedPrice()
		AddToTotals()


	End Sub
	'Methods

	Private Sub CalculateExtendedPrice()
		'quantity * price -> ext price
		ExtendedPriceDecimal = Quantity * Price

	End Sub

	Private Sub AddToTotals()
		'add to our summary
		SalesCount += 1
		SalesTotal = SalesTotal + ExtendedPrice

	End Sub

End Class
