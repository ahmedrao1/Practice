Module Module1

    Sub Main()
        'fix_start
        ' turn all reoccurences of first alphabet to *

        Dim S, b As String
        Dim Ch As Char
        Dim i As Integer

        S = Console.ReadLine

        Ch = Left(S, 1)
        For i = 2 To Len(S)
            b = Mid(S, i, 1)

            If Mid(S, i, 1) = LCase(Ch) Or Mid(S, i, 1) = UCase(Ch) Then
                b = "*"
                Mid(S, i, 1) = b

            End If
        Next
        Console.WriteLine(S)
        Console.ReadKey()
    End Sub

End Module
