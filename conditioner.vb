//abc174_a conditioner.vb

####################################
Module Module1
Sub main()
    Dim temp as Integer
    temp = Console.ReadLine()    
    If temp >= 30 Then
      Console.WriteLine("Yes")
    Else
      Console.WriteLine("No")
    End If
end sub
end module
####################################
Module Module1
    Sub Main()
        Dim S As String = Trim(Console.ReadLine())
        Dim X As Integer = S
        If X>=30 Then
            Console.WriteLine("Yes")
        Else
            Console.WriteLine("No")
        End if
    End Sub
End Module
####################################
Module Module1
    Sub Main()
        Dim S As String = Trim(Console.ReadLine())
        Dim X As Integer = CInt(S)
        Dim judge As Integer = If(X >= 30, 1, 0)
        Dim ANS() As String = {"No", "Yes"}
        Console.WriteLine(ANS(judge))
    End Sub
End Module
####################################
