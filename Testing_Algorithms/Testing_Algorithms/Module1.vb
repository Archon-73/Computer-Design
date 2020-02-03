Module Module1
    Sub Main()

        Handle_2s_Complement()

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
End Module
