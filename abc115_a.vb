abc115_a.vb
##########################################
##########################################
##########################################
##########################################
##########################################
##########################################
##########################################
Imports System
Class Sample
  Shared Sub Main()
    Dim line1 As String = Console.ReadLine()
    If line1 = "25" Then
      Console.Write("Christmas") 
    End If
    If line1 = "24" Then
      Console.Write("Christmas Eve") 
    End If
    If line1 = "23" Then
      Console.Write("Christmas Eve Eve") 
    End If
    If line1 = "22" Then
      Console.Write("Christmas Eve Eve Eve") 
    End If
  End Sub
End Class
##########################################
Imports System
Imports System.Collections.Generic 
Module Program
    Sub Main()
        Dim D As Integer = Integer.Parse(Console.ReadLine())
        Dim Ans as String = "Christmas"
        For i As Integer = 1 To 25-D
            Ans = Ans + " Eve"
        Next
        Console.WriteLine(Ans)
    End Sub
End Module
##########################################
[python]
D=int(input())
print("Christmas"+" Eve"*(25-D))
##########################################
