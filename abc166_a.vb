//abc166_a.vb
################################
################################
################################
################################
Module Module1
    Sub main()
        Dim user1 = Console.ReadLine()
        Dim result As String = "ABC"
        If user1 = result Then result = "ARC"
        Console.WriteLine(result)
    End Sub
End module
################################
module A
  sub Main(ByVal args() as String)
    Dim line(4) as String
    line=Console.ReadLine().Split()
    if mid(line(0),2,1)="R" then
      Console.WriteLine("ABC")
    else
      Console.WriteLine("ARC")
    end if
  end sub
end module
################################
Imports System
Module Program
    Sub Main(args As String())
        Dim S As String = Console.ReadLine()
        Dim ans As String = ""
        If S = "ABC" Then
            ans = "ARC"
        Else
            ans = "ABC"
        End If
        Console.WriteLine(ans)
    End Sub
End Module
################################
