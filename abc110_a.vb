abc110_a.vb
###########################################
###########################################
###########################################
Module _20190422
    Sub Main()
        Dim sRead As String = Console.ReadLine()
        Dim iNum() As String = sRead.Split(" ")
        For i As Integer = 0 To iNum.Length - 1
            For j As Integer = iNum.Length - 1 To i + 1 Step -1
                If iNum(j) > iNum(j - 1) Then
                    Dim iTemp As String = iNum(j)
                    iNum(j) = iNum(j - 1)
                    iNum(j - 1) = iTemp
                End If
            Next
        Next
        Console.WriteLine(CInt(iNum(0).ToString & iNum(1).ToString) + iNum(2))
    End Sub
End Module
###########################################
Module Program
  Sub Main
    Dim s = GetInts()
    Dim a=s(0),b=s(1),c=s(2)
    Dim ans=a+b+c+Math.Max(a,Math.Max(b,c))*9
    Console.WriteLine(ans)
  End Sub
  
  ' /_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
  Function Gets() As String()
    Gets = Console.ReadLine().Split(" "c)
  End Function
  Function GetInts() As Integer()
    Dim s = Gets(), r(UBound(s)) As Integer
    For i As Integer=0 To UBound(s): r(i)=s(i): Next i
    GetInts = r
  End Function
End Module
###########################################
Module Main
    Sub Main()
        Dim a,b,c,t As Integer
        Dim input As String = Console.ReadLine()
        Dim inputs() As String = input.Split(" ")
        a = Integer.Parse(inputs(0))
        b = Integer.Parse(inputs(1))
        c = Integer.Parse(inputs(2))
        t = (a+b+c)+Math.Max(a,Math.Max(b,c))*9
        Console.WriteLine(t)
    End Sub
End Module
###########################################
[python]
a,b,c=map(int,input().split())
ans=(a+b+c)+max(a,b,c)*9
print(ans)
###########################################
