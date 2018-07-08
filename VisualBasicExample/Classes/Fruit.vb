Public Class Fruit
    Public Property Id() As Integer
    Public Property Description() As String
    Public Property Picture() As Image

    Public Overrides Function ToString() As String
        Return Description
    End Function
End Class
