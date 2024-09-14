Module Module1
    Sub Main()
        Dim inputStr As String = Console.ReadLine()
        Dim D As Integer

        If Integer.TryParse(inputStr, D) Then
            Dim ans As Double = D / 100.0
            Console.WriteLine(ans)
        Else
            Console.Error.WriteLine("Invalid input. Please enter an integer.")
            Environment.Exit(1)
        End If
    End Sub
End Module
