Module Module1
    Sub Main()
        Dim input As String = Console.ReadLine()
        Dim values As String() = input.Split()
        Dim A(values.Length - 1) As Integer

        For i As Integer = 0 To values.Length - 1
            A(i) = Integer.Parse(values(i))
        Next

        Dim minValue As Integer = FindMin(A)
        Console.WriteLine(minValue)
    End Sub

    Function FindMin(values As Integer()) As Integer
        Dim minValue As Integer = values(0)

        For i As Integer = 1 To values.Length - 1
            If values(i) < minValue Then
                minValue = values(i)
            End If
        Next

        Return minValue
    End Function
End Module
