Module Module1

    Sub Main()
        'both_ends:
        'Input a string s, output a string made of the first 2
        'and the last 2 chars of the original string,
        'so() 'spring' yields 'spng'. However, if the string length
        'is less than 2, return string s instead the empty string.

        'DECLARATION
        Dim str1, str2, char1, char2 As String
        Dim X As Integer

        'INITIALISATION
        str1 = ""
        str2 = ""
        char1 = ""
        char2 = ""
        X = 0

        'PROCESS
        Console.Write("Enter String: ")
        str1 = Console.ReadLine()

        X = Len(str1)
        If X > 2 Then
            char1 = Left(str1, 2)
            str2 = str2 & char1
            char2 = Right(str1, 2)
            str2 = str2 & char2

        End If

        Console.WriteLine("FIRST 2 And LAST 2 Characters are : " & str2)
        str2 = Console.ReadLine()
        Console.ReadKey()

    End Sub

End Module
