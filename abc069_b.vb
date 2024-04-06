abc069_b.vb
#########################################
#########################################
#########################################
#########################################
#########################################
#########################################
module main
  sub Main(ByVal args() as String)
    dim s,ans,a as string
    dim n as integer
    s=console.readline()
    n = s.length()
    a=n-2
    ans=s(0)+a+s(n-1)
    console.writeline(ans)
  end sub
end module
#########################################
Module Module1
    Sub Main()
        Dim s = Console.ReadLine
        Console.WriteLine(s.Substring(0, 1) & s.Length - 2 & s.Substring(s.Length - 1, 1))
    End Sub
End Module
#########################################
Module Module1
    Sub Main()
        Dim S As String = Console.ReadLine().Trim()
        Dim n As Integer = Len(S)
        Dim ans As String = S(0) & (n - 2).ToString() & S(n - 1)
        Console.WriteLine(ans)
    End Sub
End Module
#########################################
