Module Module1
    Sub Main()
        Dim input As String = Console.ReadLine()
        Dim values() As String = input.Split(" ")
        Dim A As Integer = Integer.Parse(values(0))
        Dim B As Integer = Integer.Parse(values(1))

        For i As Integer = 0 To 255
            If (A Xor i) = B Then
                Console.WriteLine(i)
                Exit For
            End If
        Next
    End Sub
End Module
