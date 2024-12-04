Imports System

Module Module1
    Sub Main()

        Dim input As String = Console.ReadLine()
        Dim parts() As String = input.Split()

        ' Parse values for A and B
        Dim A As Integer = Integer.Parse(parts(0))
        Dim B As Integer = Integer.Parse(parts(1))

        ' Calculate and print the result
        Dim result As Integer = CInt(Math.Pow(32, A - B))
        Console.WriteLine(result)
    End Sub
End Module
