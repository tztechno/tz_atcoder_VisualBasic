abc114_a.vb
##########################################
##########################################
##########################################
##########################################
##########################################
##########################################
##########################################
Imports System
Module A
  Sub Main()
    dim X as integer = console.readline()
    If X=7 or X=5 or X=3 Then
      console.Writeline("YES")
    Else   
      console.Writeline("NO")  
    End If 
  End Sub
End Module

##########################################
Imports System
Module A
  Sub Main()
    dim X as integer = console.readline()
    If (X-7)*(X-5)*(X-3)=0 Then
      console.Writeline("YES")
    Else   
      console.Writeline("NO")  
    End If 
  End Sub
End Module

##########################################
[python]
X=int(input())
if (X-7)*(X-5)*(X-3)==0:
  print('YES')
else:
  print('NO')
##########################################
