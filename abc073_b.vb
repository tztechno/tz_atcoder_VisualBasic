abc073_b.vb
#######################################
Dim t As Integer = 0 ' Declare t as Integer
Dim l As Integer = A(0) ' Use () for indexing, not []
Dim r As Integer = A(1) ' Use () for indexing, not []
#######################################
#######################################
#######################################
#######################################
#######################################
Imports System.Collections.Generic
Imports System.Console

Module Program
    Sub Main()
        Dim N As Integer = NextInt()
        Dim ans As Integer = 0

        For i As Integer = 0 To N - 1
            Dim l As Integer = NextInt()
            Dim r As Integer = NextInt()
            ans += r - l + 1
        Next
        WriteLine(ans)
    End Sub

    Function NextInt() As Integer
        Return CInt(NextString())
    End Function

    Function NextString() As String
        Dim result As New List(Of Char)
        Do
            Dim tmp As Integer = Read()
            If tmp < 0 Then Exit Do
            Dim nextChar As Char = Chr(tmp)

            If Not Char.IsWhiteSpace(nextChar) Then
                result.Add(nextChar)
            ElseIf nextChar <> vbCr Then
                Exit Do
            End If
        Loop
        Return New String(result.ToArray())
    End Function

End Module

#######################################
[my AC]

Imports System
Imports System.Collections.Generic ' Need to import the List(Of T) class

Module Program
    Sub Main()
        Dim N As Integer = Integer.Parse(Console.ReadLine())
        Dim t As Integer = 0 ' Declare t as Integer
        For i As Integer = 0 To N - 1
            Dim A As List(Of Integer) = Console.ReadLine().Split(" "c).Select(Function(s) Integer.Parse(s)).ToList()
            Dim l As Integer = A(0) ' Use () for indexing, not []
            Dim r As Integer = A(1) ' Use () for indexing, not []
            t += r - l + 1
        Next
        Console.WriteLine(t)
    End Sub
End Module
#######################################
