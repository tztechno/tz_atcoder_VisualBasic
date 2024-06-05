abc112_a.vb
#######################################
数字入力
dim n as integer = console.readline()
#######################################
#######################################
#######################################
#######################################
#######################################
#######################################
#######################################
Module _20190422
    Sub Main()
        Dim iAge As Integer = Console.ReadLine()
        If iAge = 1 Then
            Console.WriteLine("Hello World")
        Else
            Console.WriteLine(CInt(Console.ReadLine()) + CInt(Console.ReadLine()))
        End If
    End Sub
End Module
#######################################
Imports System
Imports System.Collections.Generic
class p
    shared sub main()
        dim n as integer = console.readline()
        if n=1 then
            Console.WriteLine("Hello World")
        else
            dim a as integer = console.readline()
            dim b as integer = console.readline()
            Console.WriteLine(a+b)
        end if
    end sub
end class
#######################################
[python]
N=int(input())
if N==1:
    print("Hello World")
else:
    a=int(input())
    b=int(input())
    print(a+b) 
#######################################
