abc074_b.vb
#######################################
Dim X As List(Of Integer) = Console.ReadLine().Split(" "c)
    .Select(Function(num) Integer.Parse(num)).ToList() 
#######################################
#######################################
#######################################
#######################################
#######################################
Imports System.Math
Module B
    Sub Main()

        Dim N = CInt(Console.ReadLine())
        Dim K = CInt(Console.ReadLine())
        Dim x() = Console.ReadLine.Split()
        Dim Ans, i As Integer

        For i = 0 To N - 1
            Dim xi = CInt(x(i))
            Ans += Min(xi, Max(xi - K, K - xi)) * 2
        Next
        Console.WriteLine(Ans)

    End Sub
End Module
#######################################
[大文字小文字を区別しない、X,x併用はだめ]

Imports System
Imports System.Linq

Module Program
    Sub Main()
        Dim N As Integer = Integer.Parse(Console.ReadLine())
        Dim K As Integer = Integer.Parse(Console.ReadLine())
        Dim X As List(Of Integer) = Console.ReadLine().Split(" "c).Select(Function(num) Integer.Parse(num)).ToList()
        Dim S As Integer = 0

        For i As Integer = 0 To N - 1
            Dim xValue As Integer = X.ElementAt(i)
            S += Math.Min(xValue, K - xValue) * 2
        Next

        Console.WriteLine(S)
    End Sub
End Module
#######################################
