Module Module1

    Sub Main()
        Dim x As Boolean
        Dim a, b As Integer
        a = Console.ReadLine
        b = Console.ReadLine

        x = isDivisible(a, b)
        Console.WriteLine(x)
        Console.ReadKey()
    End Sub
    Function isDivisible(ByVal x As Integer, ByVal y As Integer) As Boolean
        Dim output As Boolean
        If x Mod y = 0 Then
            output = True
        ElseIf x Mod y <> 0 Then
            output = False
        End If
        isDivisible = output
    End Function
End Module
