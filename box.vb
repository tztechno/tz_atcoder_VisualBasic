#ABC180_A
#box

Imports System

Module Module1
    Sub Main()

        Dim input As String = Console.ReadLine()
        Dim parts() As String = input.Split()

        ' Parse values for A and B
        Dim N As Integer = Integer.Parse(parts(0))
        Dim A As Integer = Integer.Parse(parts(1))
        Dim B As Integer = Integer.Parse(parts(2))
        
        ' Calculate and print the result
        Console.WriteLine(N-A+B)
    End Sub
End Module
