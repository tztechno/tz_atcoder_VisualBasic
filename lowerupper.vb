//ABC192_B lowerupper


##############################################################################

Module Module1
    Sub Main()
        Dim S As String = Console.ReadLine().Trim()
        Dim n As Integer = S.Length

        For i As Integer = 0 To n - 1
            If (i Mod 2 = 0 AndAlso S(i) <> Char.ToLower(S(i))) OrElse (i Mod 2 = 1 AndAlso S(i) <> Char.ToUpper(S(i))) Then
                Console.WriteLine("No")
                Exit Sub
            End If
        Next

        Console.WriteLine("Yes")
    End Sub
End Module

##############################################################################

Imports System

Module Program
    Sub Main(args As String())
        Dim strInput As String
        Dim strPattern As String
        Dim bResulte As Boolean = True

        strInput = Console.ReadLine()
        For i As Integer = 0 To strInput.Length - 1
            If i Mod 2 = 0 Then
                strPattern = "[a-z]"
            Else
                strPattern = "[A-Z]"
            End If
            If Not Text.RegularExpressions.
            Regex.IsMatch(strInput(i).ToString, strPattern) Then
                bResulte = False
                Exit For
            End If
        Next
        If bResulte Then
            Console.WriteLine("Yes")
        Else
            Console.WriteLine("No")
        End If
    End Sub
End Module

##############################################################################
