Module Module1

    Sub Main()
        'fix_start:
        'Given a string s, return a string
        'where all occurences of its first char have
        'been changed to '*', except do not change
        'the first char itself.
        'e.g., 'babble' yields 'ba**le' or 'alpha' outputs 'alph*'
        'Assume that the string is length 1 or more

        'DECLARATION
        Dim str1, str2, char2, str3 As String
        Dim char1 As Char
        Dim i As Integer

        'INITIALISATION
        str1 = ""
        str2 = ""
        char2 = ""
        char1 = ""
        i = 0

        'PROCESS
        Console.Write("Enter String :")
        str1 = Console.ReadLine()
        char1 = Left(str1, 1)

        For i = 2 To Len(str1)
            char2 = Mid(str1, i, 1)
            If char2 = char1 Then
                str2 = str2 & "*"
            ElseIf char2 <> char1 Then
                str2 = str2 & char2
            End If
        Next
        str3 = char1 & str2
        Console.WriteLine("Final String:" & str3)
        str2 = Console.ReadLine()
        Console.ReadKey()




    End Sub

End Module
