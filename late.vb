//ABC177_A late

Module Module1
    Sub Main()
        Dim input As String = Console.ReadLine()
        Dim values() As String = input.Split(" ")
        Dim D As Integer = Integer.Parse(values(0))
        Dim T As Integer = Integer.Parse(values(1))
        Dim S As Integer = Integer.Parse(values(2))
        
        If  D<=T*S Then
            Console.WriteLine("Yes")
        Else
            Console.WriteLine("No")        
        End If
    End Sub
End Module
