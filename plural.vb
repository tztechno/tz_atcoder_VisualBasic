//ABC179_A
//plural
// If Then Else End If

Module Module1
    Sub Main()
        Dim input As String
        input = Console.ReadLine()
        Dim n As Integer = input.Length
        If input.EndsWith("s") Then
            Console.WriteLine(input & "es")
        Else
            Console.WriteLine(input & "s")
        End If
    End Sub
End Module
