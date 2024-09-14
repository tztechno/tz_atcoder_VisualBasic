Module Module1
    Sub Main()
        Dim N As Integer

        N = CInt(Console.ReadLine())

        Dim m As Integer = N \ 5
        Dim diff As Integer = N Mod 5

        Dim result As Integer
        If diff <= 2 Then
            result = m * 5
        Else
            result = (m + 1) * 5
        End If

        Console.WriteLine(result)
    End Sub
End Module
