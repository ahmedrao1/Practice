Module Module1

    Sub Main()
        '////////9608/22/M/J/17 Q6a/////////////////
        'VEHICLE REGISTRATION VERIFICATION'
        ' //////// conditions: 
        'Six to nine characters , 1 to 3 uppercase , 4 to 5 numeric , Remaining uppercase////////////

        Dim Registration As String
        Dim Valid As Boolean
        Dim i As Integer
        Registration = Console.ReadLine
        Valid = True

        If Len(Registration) < 6 Or Len(Registration) > 9 Then
            Valid = False
        Else
            For i = 0 To 2
                If Registration(i) < "A" Or Registration(i) > "Z" Then
                    Valid = False


                End If
            Next
            For i = 3 To 4
                If Registration(i) < "0" Or Registration(i) > "9" Then
                    Valid = False

                End If
            Next
            For i = 5 To Len(Registration) - 1
                If Registration(i) < "A" Or Registration(i) > "Z" Then
                    Valid = False
                End If
            Next
        End If

        If Valid = True Then
            Console.WriteLine("valid")
        Else
            Console.WriteLine("Not Valid")
        End If
        Console.ReadKey()








    End Sub

End Module
