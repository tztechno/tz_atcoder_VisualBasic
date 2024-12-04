abc067_b.vb
#########################################
#########################################
#########################################
#########################################
#########################################
#########################################
#########################################
#########################################
Module B
    Sub Main()

        Dim c() = Console.ReadLine.Split()
        Dim N = CInt(c(0)), K = CInt(c(1))
        Dim L() = Array.ConvertAll(Console.ReadLine.Split(), AddressOf Integer.Parse)
        Array.Sort(L)
        Array.Reverse(L)
        Dim i, Ans As Integer

        For i = 0 To K - 1
            Ans += L(i)
        Next
        Console.Write(Ans)

    End Sub
End Module
#########################################
Imports System.Collections.Generic

Module Main

    Public Sub Main()
        Dim input As String() = Console.ReadLine().Split()
        Dim N As Integer = Integer.Parse(input(0))
        Dim K As Integer = Integer.Parse(input(1))

        Dim arr As List(Of Integer) = Console.ReadLine().Split(" ").Select(Function(s) Integer.Parse(s)).ToList()

        arr.Sort(Function(x, y) y.CompareTo(x))

        Dim sum As Integer = 0
        For i As Integer = 0 To K - 1
            sum += arr(i)
        Next

        Console.WriteLine(sum)
    End Sub

End Module
#########################################
