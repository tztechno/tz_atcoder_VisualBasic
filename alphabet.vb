Module Module1
    Sub Main()
        Dim x As String = Console.ReadLine().Trim()
        If x = LCase(x)  Then
            Console.WriteLine("a")
        Else
            Console.WriteLine("A")
        End If
    End Sub
End Module
