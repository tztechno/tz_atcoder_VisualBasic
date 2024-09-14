//ABC178_A Not

Module Module1
    Sub Main()
        Dim input As String = Console.ReadLine()
        Dim values() As String = input.Split(" ")
        Dim N As Integer = Integer.Parse(values(0))

        If N = 0 Then
            Console.WriteLine(1)
        Else
            Console.WriteLine(0)
        End If
    End Sub
End Module
