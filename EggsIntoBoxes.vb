Module Module1

    Sub Main()
        Dim x As Integer
        Dim y, z As Integer
        x = Console.ReadLine
        y = 0
        z = 0
        Call EggsIntoBoxes(x, y, z)
        Console.WriteLine("Number of boxes are: " & y)
        Console.Write("Eggs leftover are : " & z)
        Console.ReadKey()
    End Sub
    Sub EggsIntoBoxes(ByVal NumberOfEggs As Integer, ByRef NumberOfBoxes As Integer, ByRef EggsLeftOver As Integer)
        NumberOfBoxes = NumberOfEggs \ 6
        EggsLeftOver = NumberOfEggs Mod 6


    End Sub
End Module
