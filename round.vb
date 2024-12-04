Module Main
    Sub Main()
        Dim input As String
        Console.WriteLine("Enter a floating-point number: ")
        input = Console.ReadLine()

        Dim X As Double
        If Double.TryParse(input, X) Then
            Dim a As Integer = CInt(Math.Floor(X * 10))

            If a Mod 10 >= 5 Then
                Console.WriteLine(CInt(Math.Floor(X)) + 1)
            ElseIf a Mod 10 <= 4 Then
                Console.WriteLine(CInt(Math.Floor(X)))
            End If
        Else
            Console.WriteLine("Invalid input. Please enter a valid floating-point number.")
        End If
    End Sub
End Module
