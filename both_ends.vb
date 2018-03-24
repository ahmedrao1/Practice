Module Module1

    Sub Main()
        Dim Inputt As String
        Dim FirstTwo As String
        Dim LastTwo As String


        Console.WriteLine("Enter your string: ")
        Inputt = Console.ReadLine
        FirstTwo = Left(Inputt, 2)
        LastTwo = Right(Inputt, 2)

        If Len(Inputt) < 2 Then
            Console.WriteLine("Too short")
        Else
            Console.WriteLine("New word is: " & FirstTwo & LastTwo)
        End If

        Console.ReadKey()
    End Sub

End Module
