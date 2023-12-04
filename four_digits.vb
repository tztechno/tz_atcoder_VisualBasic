Module Module1
    Sub Main()
        Dim S As String = Trim(Console.ReadLine())
        Dim n As Integer = S.Length

        If n < 4 Then
            S = S.PadLeft(4, "0"c)
        End If

        Console.WriteLine(S)
    End Sub
End Module
