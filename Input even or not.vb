Module Module1

    Sub Main()
        'figure out if a even number is even or not'
        Dim x As Integer


        Console.WriteLine("Enter your number: ")
        x = Console.ReadLine

        If x Mod 2 = 0 Then Console.WriteLine("True")
        If x Mod 2 <> 0 Then Console.WriteLine("False")


        Console.ReadKey()

    End Sub

End Module
