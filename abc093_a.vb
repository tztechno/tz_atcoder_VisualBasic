//abc093_a.vb
####################################
####################################
####################################
####################################
####################################
####################################
####################################
module A
  sub Main(ByVal args() as String)
    Dim line() as String
    Dim s as String
    Dim temp as String
    s=Console.ReadLine()
    Dim s1 as String
    Dim s2 as String
    Dim s3 as String
    s1 = Mid(s, 1, 1)
    s2 = Mid(s, 2, 1)
    s3 = Mid(s, 3, 1)
    if s1<>s2 and s2<>s3 and s3<>s1 then
      Console.WriteLine("Yes")
    else
      Console.WriteLine("No")
    end if
  end sub
end module
####################################
Module Program
  Sub Main
    Dim s = Gets()
    Dim a=s(0)
    Dim ans=If(a.Contains("a"c)And a.Contains("b"c) And a.Contains("c"c),"Yes","No")
    Console.WriteLine(ans)
  End Sub
  
  '/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
  Function Gets() As String()
    Gets = Console.ReadLine().Split(" "c)
  End Function
  Function GetInts() As Integer()
    Dim s = Gets(), r(UBound(s)) As Integer
    For i As Integer=0 To UBound(s): r(i)=s(i): Next i
    GetInts = r
  End Function
End Module
####################################
Imports System

Module Program
    Sub Main(args As String())
        Dim S As String = Console.ReadLine()
        Dim S2 As String = SortString(S)
        Dim ans As String = ""

        If S2 = "abc" Then
            ans = "Yes"
        Else
            ans = "No"
        End If

        Console.WriteLine(ans)
    End Sub

    Function SortString(ByVal input As String) As String
        Dim charArray() As Char = input.ToCharArray()
        Array.Sort(charArray)
        Return New String(charArray)
    End Function
End Module
####################################
