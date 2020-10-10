Imports Microsoft.VisualBasic

Public Class BookSale
    'CONSTANTS
    Const DISCOUNT_RATE As Decimal = 0.15


    'PROPERTIES
    Public Property Quantity As Integer
    Public Property Title As String
    Public Property Price As Decimal
    Public Property ExtPrice As Decimal
    Public Property Discount As Decimal
    Public Property DiscountedPrice As Decimal


    'CONSTRUCTOR
    Public Sub New()

    End Sub

    Public Sub New(inQuantity As Integer,
                    inTitle As String,
                    inPrice As Decimal)

        Quantity = inQuantity
        Price = inPrice
        Title = inTitle

        'compute
        ExtPrice = Quantity * Price
        'discount
        Discount = ExtPrice * DISCOUNT_RATE
        'final price
        DiscountedPrice = ExtPrice - Discount

    End Sub
    'METHODS
End Class
