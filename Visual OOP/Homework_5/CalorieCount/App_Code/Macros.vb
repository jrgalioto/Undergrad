Imports Microsoft.VisualBasic

Public Class Macros
    'CONSTANTS
    Const FAT_CAL As Integer = 9
    Const CARB_CAL As Integer = 4
    Const PROTEIN_CAL As Integer = 4

    Dim FatInt As Integer
    Dim CarbInt As Integer
    Dim ProteinInt As Integer
    Dim CaloriesInt As Integer

    'PROPERTIES
    Public Property Fat As Integer
        Get
            Return FatInt
        End Get

        Set(value As Integer)
            FatInt = value
        End Set
    End Property

    Public Property Carb As Integer
        Get
            Return CarbInt
        End Get

        Set(value As Integer)
            CarbInt = value
        End Set
    End Property

    Public Property Protein As Integer
        Get
            Return ProteinInt
        End Get

        Set(value As Integer)
            ProteinInt = value
        End Set
    End Property

    Public Property Calories As Integer
        Get
            Return CaloriesInt
        End Get

        Set(value As Integer)
            CaloriesInt = value
        End Set
    End Property

    'CONSTRUCTOR
    Public Sub New()

    End Sub

    Public Sub New(inFat As Integer,
                   inCarb As Integer,
                   InProtein As Integer)

        Fat = inFat
        Carb = inCarb
        Protein = InProtein
        CalorieCalc()


    End Sub

    'METHODS
    Sub CalorieCalc()
        Calories = (Fat * FAT_CAL) + (Carb * CARB_CAL) + (Protein * PROTEIN_CAL)

    End Sub


End Class
