//abc170_a variables.vb
#####################################
#####################################
#####################################
module x
  sub main()
    dim s = split(console.readline())
    for i as integer = 0 to 4
      if s(i) = "0" then
        console.writeline(i+1)
        exit sub
      end if
    next i
  end sub
end module
#####################################
Option Explicit On
Imports System
Module Program
    Sub Main(args As String())
        Dim tmp As String() = Split(Console.ReadLine(), " ")
        For i As Integer = 0 To 4
            If tmp(i) = "0" Then
                Console.WriteLine(i + 1)
            End If
        Next
    End Sub
End Module
#####################################
Imports System
Imports System.Collections.Generic
Imports System.Linq
Module Program
    Sub Main()
        Dim X As List(Of Integer) = Console.ReadLine().Split(" "c).Select(Function(s) Integer.Parse(s)).ToList()
        For i As Integer = 0 To 4
            If X(i) = 0 Then
                Console.WriteLine(i+1)
            End If
        Next
    End Sub
End Module
#####################################
Module Program
    Sub Main()
        Dim X As List(Of Integer) = Console.ReadLine().Split(" "c).Select(Function(s) Integer.Parse(s)).ToList()
        For i As Integer = 0 To 4
            If X(i) = 0 Then
                Console.WriteLine(i+1)
            End If
        Next
    End Sub
End Module
#####################################
