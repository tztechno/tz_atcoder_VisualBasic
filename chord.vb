Module Module1
    Sub Main()
        Console.Write("Enter a string: ")
        Dim s As String = Console.ReadLine().Trim()

        Dim name() As String = {"ACE", "BDF", "CEG", "DFA", "EGB", "FAC", "GBD"}

        If Array.Exists(name, Function(x) x = s) Then
            Console.WriteLine("Yes")
        Else
            Console.WriteLine("No")
        End If
    End Sub
End Module
