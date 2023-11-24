Imports System

Module Program
    Sub Main()
        Console.Write("Enter N: ")
        Dim N As Integer = Integer.Parse(Console.ReadLine())

        Console.Write("Enter A: ")
        Dim A As List(Of Integer) = Console.ReadLine().Split(" "c).Select(Function(s) Integer.Parse(s)).ToList()

        Console.WriteLine(N)
        Console.WriteLine(String.Join(" ", A))
    End Sub
End Module
