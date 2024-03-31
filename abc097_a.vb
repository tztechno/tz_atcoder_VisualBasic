abc097_a.vb
#########################################
#########################################
#########################################
#########################################
Module M
    sub Main()
        dim l = Console.ReadLine().Split()'.Select(Function(x) Integer.Parse(x)).ToList()
        dim a = Integer.Parse(l(0)), b = Integer.Parse(l(1)), c = Integer.Parse(l(2)), d = Integer.Parse(l(3))
        dim x = System.Math.Abs(b-a) <= d and System.Math.Abs(c-b) <= l(3)
        dim y = System.Math.Abs(c-a) <= d
        if x or y = True then
            Console.WriteLine("Yes")
        else
            Console.WriteLine("No")
        end if
    end sub
end Module
#########################################
Option Strict On

Module Module1
    Sub Main()
        'let'
        Dim tmp() As Long =
            Array.ConvertAll(Of String, Long) _
            (Console.ReadLine().Split(), AddressOf Long.Parse)
        Dim a As Long = tmp(0)
        Dim b As Long = tmp(1)
        Dim c As Long = tmp(2)
        Dim d As Long = tmp(3)

        Dim arr() As Long = New Long() {a, b, c}

        'var'
        Dim flg As Boolean

        If Math.Abs(a - c) > d Then
            For i As Int32 = 0 To UBound(arr) - 1
                If Math.Abs(arr(i) - arr(i + 1)) > d Then
                    flg = True
                End If
            Next
        End If

        Console.WriteLine(New String() {"Yes", "No"}(Convert.ToInt32(flg)))

    End Sub


End Module

#########################################
Module Program
  Sub Main
    Dim s = GetInts()
    Dim a=s(0),b=s(1),c=s(2),d=s(3)
    Dim ans=If(d>=Math.Abs(c-a)Or(d>=Math.Abs(a-b)And d>=Math.Abs(b-c)),"Yes","No")
    Console.WriteLine(ans)
  End Sub
  
  Function Gets() As String()
    Gets = Console.ReadLine().Split(" "c)
  End Function
  Function GetInts() As Integer()
    Dim s = Gets(), r(UBound(s)) As Integer
    For i As Integer=0 To UBound(s): r(i)=s(i): Next i
    GetInts = r
  End Function
End Module
#########################################
Module MaxBDifference
    Sub Main()
        Dim a, b, c, d As Integer
        Dim input As String = Console.ReadLine()
        Dim inputs() As String = input.Split(" "c)
        a = Integer.Parse(inputs(0))
        b = Integer.Parse(inputs(1))
        c = Integer.Parse(inputs(2))
        d = Integer.Parse(inputs(3))
        
        If Math.Abs(c - a) <= d Then
            Console.WriteLine("Yes")
        ElseIf Math.Abs(a - b) <= d And Math.Abs(b - c) <= d Then
            Console.WriteLine("Yes")
        Else
            Console.WriteLine("No")      
        End If

    End Sub
End Module
#########################################
