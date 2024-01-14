//ABC192_B lowerupper

Module Module1
    Sub Main()
        Dim S As String = Console.ReadLine().Trim()
        Dim n As Integer = S.Length

        For i As Integer = 0 To n - 1
            If (i Mod 2 = 0 AndAlso S(i) <> Char.ToLower(S(i))) OrElse (i Mod 2 = 1 AndAlso S(i) <> Char.ToUpper(S(i))) Then
                Console.WriteLine("No")
                Exit Sub
            End If
        Next

        Console.WriteLine("Yes")
    End Sub
End Module
