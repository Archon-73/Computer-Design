Module Module1
    Sub Main()

        'Handle_2s_Complement()
        ExponentMultiplication()


    End Sub

    Sub Handle_2s_Complement()

        Dim byte1 As SByte = -128

        Console.WriteLine(SByte.MaxValue)
        Console.WriteLine(SByte.MinValue)
        Console.WriteLine()

        byte1 -= 8
        Console.WriteLine(byte1)

        Console.ReadKey()
    End Sub

    Sub ExponentMultiplication()

        Dim b As Integer = Console.ReadLine()
        Dim e As Integer = Console.ReadLine()
        Dim p As Integer = 1

        While e <> 0
            p = p * b
            e -= 1
        End While

        Console.WriteLine(p)

    End Sub

End Module
