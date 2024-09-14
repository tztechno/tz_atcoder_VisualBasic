//abc173_a payment.vb
##############################
Module A_173_Payment_
    Sub Main()
        Dim SRL As String = Console.ReadLine()
        Dim IntA As Integer = SRL Mod 1000

        If IntA = 0 Then
            Console.WriteLine(0)
        Else
            Console.WriteLine(1000 - IntA)
        End If

    End Sub
End Module
##############################
Imports System
Module A
    Sub Main()

        Dim N = CInt(Console.ReadLine())
        Dim a = N Mod 1000
        Console.Write(If(a, 1000 - a, 0))

    End Sub
End Module
##############################
Module Module1
Sub main()
    Dim temp as Integer
    Dim N = Console.ReadLine()    
    Dim A=(1000-(N Mod 1000)) Mod 1000
    Console.WriteLine(A)
end sub
end module

##############################
