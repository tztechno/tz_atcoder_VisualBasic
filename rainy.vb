//abc175_a rainy.vb

############################################

Module Module1
    Sub Main()
        Dim A As String = Console.ReadLine().Trim()
        Dim DP() As Integer = {0, 0, 0, 0}
        Dim ans As Integer = 0

        For i As Integer = 0 To 2
            If A(i) = "R" Then
                DP(i + 1) = DP(i) + 1
                If DP(i + 1) > ans Then
                    ans = DP(i + 1)
                End If
            End If
        Next

        Console.WriteLine(ans)
    End Sub
End Module

############################################

module x
  sub main()
    dim s = split(console.readline(), "S")
    dim ans = 0
    dim i as integer
    for i = 0 to s.length - 1
      dim cnt = s(i).length
      if cnt > ans then
        ans = cnt
      end if
    next i
    console.writeline(ans)
  end sub
end module

############################################
