Module Module1
    Sub Main()
        Dim K As Integer
        K = CInt(Console.ReadLine())

        Dim h As Integer = 21 + K \ 60
        Dim m As Integer = K Mod 60

        Dim ans As String = $"{h:D2}:{m:D2}"

        Console.WriteLine($"{ans}")
    End Sub
End Module
