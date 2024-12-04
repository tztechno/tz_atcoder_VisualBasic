//abc168_a.vb
################################
################################
################################
module ABC086A
  sub Main(ByVal args() as String)
    select Console.ReadLine() mod 10
    case 2,4,5,7,9:
        Console.WriteLine("hon")
    case 0,1,6,8:
        Console.WriteLine("pon")
    case else:
        Console.WriteLine("bon")
    end select
  end sub
end module
################################
Module Program
    Sub Main(args As String())
        Dim iInput As Integer = Console.ReadLine()
        If {2, 4, 5, 7, 9}.Contains(Right(iInput, 1)) Then
            Console.WriteLine("hon")
        ElseIf {0, 1, 6, 8}.Contains(Right(iInput, 1)) Then
            Console.WriteLine("pon")
        Else
            Console.WriteLine("bon")
        End If
    End Sub
End Module
################################
Imports System
Module Program
    Sub Main(args As String())
        Dim N As String = Console.ReadLine()
        Dim ans As String
        Select Case Right(N, 1)
            Case 3
                ans = "bon"
            Case 0, 1, 6, 8
                ans = "pon"
            Case Else
                ans = "hon"
        End Select

        Console.WriteLine(ans)
    End Sub
End Module
################################
Module Main
    Sub main()
        Dim S As Integer
        S = Console.ReadLine()
        Dim a As Integer = S Mod 10
        If New Integer() {2, 4, 5, 7, 9}.Contains(a) Then
            Console.WriteLine("hon")
        ElseIf New Integer() {0, 1, 6, 8}.Contains(a) Then
            Console.WriteLine("pon")
        Else
            Console.WriteLine("bon")
        End If
    End Sub
End Module
################################
