Module Module1

    Sub Main()
        'verbing:
        'Given a string, if its length is at least 3,
        'add() 'ing' to its end.
        'Unless it already ends in 'ing', in which case
        'add() 'ly' instead.
        'If the string length is less than 3, leave it unchanged.
        'Return the resulting string.
        'examples:
        'Input() 'end' --> 'ending'
        'Input() 'ending' --> 'endingly'
        'Input() 'go' --> 'go'

        'DECLARATION

        Dim str1, ing, ly, str2 As String

        'INITIALIZATION
        str1 = ""
        ing = ""
        ly = ""
        str2 = ""

        'PROCESS
        Console.Write("Enter Word :")
        str1 = Console.ReadLine()
        If Len(str1) < 3 Then
            Console.Write("No Change : " & str1)
            str1 = Console.ReadLine()

        End If

        If Right(str1, 3) <> "ing" Then
            str1 = str1 & "ing"
        ElseIf Right(str1, 3) = "ing" Then
            str1 = str1 & "ly"
        End If


        Console.WriteLine("Final Word :" & str1)
        str2 = Console.ReadLine()

    End Sub

End Module
