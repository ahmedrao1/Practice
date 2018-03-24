Module Module1

    Sub Main()
        Dim Num1 As Integer = 0
        Dim Num2 As Integer = 0
        Dim Num3 As Integer = 0
        Dim S As Integer
        Dim Avg As Integer
        Dim Highest As Integer
        Dim Lowest As Integer
        Dim Range As Integer
        Console.Write("Enter First Number: ")
        Num1 = Console.ReadLine

        Console.Write("Enter second Number: ")
        Num2 = Console.ReadLine

        Console.Write("Enter third Number: ")
        Num3 = Console.ReadLine

        S = Num1 + Num2 + Num3
        Console.WriteLine("Sum of the number is: " & S)

        Avg = S / 3
        Console.WriteLine("Average of number is: " & Avg)


        If Num1 > Num2 Then Highest = Num1
        If Num2 > Num3 Then Highest = Num2
        If Num3 > Num1 Then Highest = Num3
        Console.WriteLine("Highest Number is: " & Highest)

        If Num1 < Num2 Then Lowest = Num1
        If Num2 < Num3 Then Lowest = Num2
        If Num3 < Num1 Then Lowest = Num3
        Console.WriteLine("Lowest Number is: " & Lowest)

        Range = Highest - Lowest
        Console.WriteLine("Your range is: " & Range)



        Console.ReadKey()




    End Sub

End Module
