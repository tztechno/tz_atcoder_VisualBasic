abc077_b.vb
##############################################
##############################################
##############################################
##############################################
Imports System
Public Class Test
	Public Shared Sub Main()
        Dim input As Long
        input = Console.ReadLine()
        Console.WriteLine(Math.Floor(Math.Sqrt(input)) ^ 2)
	End Sub
End Class
##############################################
[AC]
Imports System
Module Program
    Sub Main(args As String())
        Dim s = Console.ReadLine().Split()
        Dim n = Integer.Parse(s(0))
        Dim m = Math.Floor(Math.Sqrt(n))
        Console.WriteLine(m*m)
    End Sub
End Module
##############################################
[WA]
Imports System
Module Program
    Sub Main(args As String())
        Dim s = Console.ReadLine().Split()
        Dim n = Integer.Parse(s(0))
        Dim m = CInt(Math.Sqrt(n))
        Console.WriteLine(m ^ 2)
    End Sub
End Module
##############################################
[python]
import math
n=int(input())
m=int(math.sqrt(n))
print(m**2)
##############################################
