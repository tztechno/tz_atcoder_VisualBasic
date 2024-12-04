abc105_a.vb
#######################################
#######################################
#######################################
#######################################
#######################################
#######################################
#######################################
Module Module1
    Sub Main()
        Dim input As String = Console.ReadLine()
        Dim values() As String = input.Split(" ")
        Dim A As Integer = Integer.Parse(values(0))
        Dim B As Integer = Integer.Parse(values(1))

        If A Mod B = 0 Then
            Console.WriteLine(0)
        Else
            Console.WriteLine(1)
        End If
        
    End Sub
End Module
#######################################
