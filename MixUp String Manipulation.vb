Module Module1

    Sub Main()
        'MixUp
        'swap the first two characters of 2 given strings
        ' output with space between the two words

        Dim x, y, b, z As String

        x = Console.ReadLine
        y = Console.ReadLine

        b = Left(y, 2)
        z = b & Mid(x, 3, Len(x))
        

        b = Left(x, 2)
        z = z & " " & b & Mid(y, 3, Len(y))
        Console.WriteLine(z)
        Console.ReadKey()




    End Sub

End Module
