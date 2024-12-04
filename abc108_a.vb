abc108_a.vb
##############################################
##############################################
##############################################
##############################################
##############################################
module A
  sub Main(ByVal args() as String)
    Dim s as String
    Dim n as Integer
    s=Console.ReadLine()
    n=s
    Dim ans as integer
    ans=0
    For i as Integer = 1 To n-1
      ans = ans + (i+1)/2
    Next
    Console.WriteLine(ans)
  end sub
end module
##############################################
Imports System
Module Program
    Sub Main()
        Dim N As Integer = Integer.Parse(Console.ReadLine())
        Dim ANS = Int(N/2)*Int((N+1)/2)
        Console.WriteLine(ANS)
    End Sub
End Module
##############################################
[python]
N=int(input())
print((N//2)*((N+1)//2))
##############################################
