abc072_b.vb
######################################
######################################
######################################
######################################
Imports System.Collections.Generic
Imports System.Console

Module Program
    Sub Main()
        Dim s As String = NextString()

        For i As Integer = 0 To s.Length - 1
            If i Mod 2 = 0 Then
                Write(s(i))
            End If
        Next
        WriteLine()
    End Sub

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
######################################
######################################
######################################
######################################
######################################
[MY AC]
Module Program
  Sub Main()
      Dim S As String = Trim(Console.ReadLine())
      Dim ANS As String = ""
      For i = 1 To Len(S) Step 2
          ANS = ANS & Mid(S, i, 1)
      Next i
      Console.WriteLine(ANS)
  End Sub
End Module
######################################
