Module Program
  Sub Main
    Dim s=GetInts()
    Dim a=s(0),b=s(1),c=s(2)
    Dim ans=a+b+c-Math.Max(a,Math.Max(b,c))
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
