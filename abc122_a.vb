abc122_a.vb
##########################################
##########################################
##########################################
##########################################
##########################################
##########################################
##########################################
Imports System
Imports System.Collections.Generic

Class Sample
    Shared Sub Main()
        Dim s As String = Console.ReadLine()
        Dim mapp As New Dictionary(Of Char, Char) From {
            {"A"c, "T"c},
            {"C"c, "G"c},
            {"G"c, "C"c},
            {"T"c, "A"c}
        }

        If mapp.ContainsKey(s(0)) Then
            Dim ans As Char = mapp(s(0))
            Console.Write(ans)
        Else
            Console.WriteLine("Invalid input.")
        End If
    End Sub
End Class
##########################################
Imports System
Class Sample
  Shared Sub Main()
    Dim line1 As String = Console.ReadLine()
    If line1 = "A" Then
      Console.Write("T") 
    End If
    If line1 = "T" Then
      Console.Write("A") 
    End If
    If line1 = "C" Then
      Console.Write("G") 
    End If
    If line1 = "G" Then
      Console.Write("C") 
    End If
  End Sub
End Class

##########################################
[python]
b=str(input())
if b=='A':
    ans='T'
elif b=='T':
    ans='A'
elif b=='C':
    ans='G'
elif b=='G':
    ans='C'
print(ans)
##########################################
