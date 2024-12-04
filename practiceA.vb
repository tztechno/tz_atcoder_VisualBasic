//practiceA.vb
##################################
1
2 3
test
##################################
##################################
##################################
##################################
##################################
##################################
##################################
##################################
Imports System
Module A
    Sub Main()

        Dim f = Function() Console.ReadLine()
        Dim a = f(), b, c As Integer
        Dim d = f().Split(), s = f()
        b = d(0) : c = d(1)

        Console.Write(a + b + c & " " & s)

    End Sub
End Module
##################################
Imports System

Module A
  Sub Main()
    dim a as integer = console.readline()
    dim bc() as string = console.readline.split(" ")
    dim b as integer = Cint(bc(0))
    dim c as integer = Cint(bc(1))
    dim s as string = console.readline()
    
    console.Writeline("{0} {1}",a+b+c,s)
  end sub
end module
##################################
Imports System

Module Program
    Sub Main(args As String())

        Dim a As String = Console.ReadLine()

        Dim line As String = Console.ReadLine()
        Dim b_and_c As String() = line.Split(" ")
        Dim b As Integer = CType(b_and_c(0), Integer)
        Dim c As Integer = CType(b_and_c(1), Integer)

        Dim s As String = Console.ReadLine()

        Console.WriteLine(a + b + c)
        Console.WriteLine(s)

    End Sub
End Module
##################################
Module Module1

#Region ""
    Function Read() As String
        Return Console.ReadLine
    End Function
    Function Reads(Optional ByVal s As Char = " "c) As String()
        Return Console.ReadLine.Split(s)
    End Function
    Sub Write(ByVal s As String)
        Console.WriteLine(s)
    End Sub

    Sub Main()
#If DEBUG Then
        Do
            _Answer()
        Loop
#End If
        _Answer()
    End Sub
#End Region

    Sub _Answer()
        Dim A = Read()
        Dim BC = Reads()
        Dim S = Read()

        Write(CInt(A) + CInt(BC(0)) + CInt(BC(1)))
        Write(S)
    End Sub

End Module

##################################
