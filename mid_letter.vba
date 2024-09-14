Module Module1
    Sub Main()
        Dim input As String = Console.ReadLine()
        Dim n As Integer = input.Length\2
        Dim ans As Char = input.Chars(n)
        Console.WriteLine(ans)
    End Sub
End Module
