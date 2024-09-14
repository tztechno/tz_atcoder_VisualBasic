//ABC182_A
//Follow
//input= 200 300

Module MaxBDifference
    Sub Main()
        Dim A, B, XB As Integer
        Dim input As String = Console.ReadLine()
        Dim inputs() As String = input.Split(" "c)
        A = Integer.Parse(inputs(0))
        B = Integer.Parse(inputs(1))
        XB = 2 * A + 100
        Console.WriteLine(XB - B)
    End Sub
End Module
