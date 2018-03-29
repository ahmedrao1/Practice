Module Module1

    Sub Main()
        'M/J/17/22/9608
        'Output all numbers between 100 and 2000

        Dim Mycount As Integer
        Mycount = 101
        Do
            Console.WriteLine(Mycount)
            Mycount = Mycount + 2

        Loop Until Mycount > 199
        Console.ReadKey()

    End Sub

End Module
