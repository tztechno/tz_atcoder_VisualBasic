abc070_b.vb
##############################
##############################
##############################
##############################
##############################
##############################
##############################
module pra
    sub main(ByVal args() as string)

        dim arr(4) as integer
        dim a1,a2,b1,b2 as integer
        dim result as integer = 0
        arr = Array.ConvertAll(Of String, Integer)(split(Console.ReadLine()), AddressOf Integer.Parse)


        a1=arr(0):a2=arr(1)
        b1=arr(2):b2=arr(3)

        if(a1 <= b2 and b1<= a2)
            if (a1<=b1 and a2<=b2)
                result = a2-b1
            elseif (a1<=b1 and a2>=b2)
                result = b2-b1
            elseif (a1>=b1 and a2<=b2)
                result = a2-a1
            elseif (a1>=b1 and a2>=b2)
                result = b2-a1
            end if
        end if

        Console.Write(result)
        Console.WriteLine()     

    end sub 
end module
##############################
Module Main
    Sub Main()
        Dim a,b,c,d,t As Integer
        Dim input As String = Console.ReadLine()
        Dim inputs() As String = input.Split(" ")
        a = Integer.Parse(inputs(0))
        b = Integer.Parse(inputs(1))
        c = Integer.Parse(inputs(2))
        d = Integer.Parse(inputs(3))
        t=Math.Max(Math.Min(b,d)-Math.Max(a,c),0)
        Console.WriteLine(t)
    End Sub
End Module
##############################
