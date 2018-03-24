Module Module1

    Sub Main()
        'reverese string'
        Dim x As String
        Dim y As String = ""
        Dim i As Integer


        x = Console.ReadLine


        For i = 1 To Len(x)
            y = Mid(x, i, 1) & y

        Next
        Console.WriteLine(y)
        Console.ReadKey()
    End Sub

End Module
