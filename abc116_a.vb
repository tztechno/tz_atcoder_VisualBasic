abc116_a.vb
###########################################
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
###########################################
###########################################
###########################################
###########################################
###########################################
###########################################
module A
  sub Main(ByVal args() as String)
    Dim line() as String
    Dim a as Integer
    Dim b as Integer
    Dim c as Integer
    line=Console.ReadLine().Split()
    a = line(0)
    b = line(1)
    c = line(2)
    Console.WriteLine(Math.Floor(a*b/2))
  end sub
end module
###########################################
Imports System
Imports System.Collections.Generic
class p
    shared sub main()
        dim s = Console.ReadLine().Split()
        dim a = Integer.Parse(s(0))
        dim b = Integer.Parse(s(1))
        dim c = Integer.Parse(s(2))
        Console.WriteLine(a*b/2)
    end sub
end class
###########################################
[python]
a,b,c=map(int,input().split())
print(a*b//2)
###########################################
