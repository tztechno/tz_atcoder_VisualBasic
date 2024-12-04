//abc094_a.vb
####################################
####################################
####################################
####################################
####################################
####################################
####################################
module A
  sub Main(ByVal args() as String)
    Dim line(4) as String
    Dim ary(3) as Integer
    Dim s as String
    Dim a as Integer
    Dim b as Integer
    Dim c as Integer
    Dim d as Integer
    line=Console.ReadLine().Split()
    a = line(0)
    b = line(1)
    c = line(2)
    if a>c or c>a+b-1 then
      Console.WriteLine("NO")
    else
      Console.WriteLine("YES")
    end if
    'b = line(1)
    'c = line(2)
    'Console.WriteLine()
    'Math.Floor()'切り捨て
    'Math.Ceiling()'切り上げ
    'Math.Abs()
    'Math.Max()
    '文字コード=Asc(文字)
    'if 0=a mod 3 or 0=b mod 3 then
    '  Console.WriteLine("Possible")
    'else
    '  Console.WriteLine("Impossible")
    'end if
    'else if
    'Array.Sort(a)
    'Console.WriteLine(a(1)+a(2))
  end sub
end module
####################################
Imports System
Imports System.Collections.Generic
class p
    shared sub main()
        dim s = Console.ReadLine().Split()
        dim a = Integer.Parse(s(0))
        dim b = Integer.Parse(s(1))
        dim x = Integer.Parse(s(2))
        
        if a + b >= x and a <= x then
            Console.WriteLine("YES")
        else
            Console.WriteLine("NO")
        end if
    end sub
end class
####################################
Module MaxBDifference
    Sub Main()
        Dim a,b,x As Integer
        Dim input As String = Console.ReadLine()
        Dim inputs() As String = input.Split(" ")
        a = Integer.Parse(inputs(0))
        b = Integer.Parse(inputs(1))
        x = Integer.Parse(inputs(2))
        If a<=x and x<=a+b Then
        Console.WriteLine("YES")
        Else
        Console.WriteLine("NO")
        END If
    End Sub
End Module
####################################
