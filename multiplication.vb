//abc169_a multiplication.vb
################################
################################
Class Main
    Public Shared Sub Main()
        Dim A, B As Integer
        Dim arr() As String
        arr = Split(Console.ReadLine())
        A = arr(0) : B = arr(1)
        Console.WriteLine(A * B)
    End Sub
End Class
################################
Imports System
Module A
    Sub Main()
        Dim a() As String = Console.ReadLine.Split(" ")
        Console.WriteLine(CInt(a(0)) * CInt(a(1)))
    End Sub
End Module
################################
module x
  sub main()
    dim s = split(console.readline())
    dim n = int(s(0)) * int(s(1))
    console.writeline(n)
  end sub
end module
################################
module x
  sub main()
    dim s = split(console.readline())
    console.writeline(s(0)*s(1))
  end sub
end module
################################
