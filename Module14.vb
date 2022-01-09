Module Module1

    Sub Main()
        'Find the character that appears most number of times in an entered string and output it.

        'DECLARATION
        Dim Str1 As String
        Dim thischar, MaxChar As Char
        Dim i, CharCount, MaxCharCount As Integer

        'INITIALISE
        Str1 = " "
        thischar = " "
        MaxChar = " "
        CharCount = 0
        MaxCharCount = 0
        i = 0

        'INPUT
        Console.Write("Enter string to process: ")
        Str1 = Console.ReadLine

        'PROCESS
        For i = 1 To Len(Str1)
            thischar = Mid(Str1, i, 1)
            If thischar = Mid(Str1, i + 1, 1) Then
                CharCount = CharCount + 1
            ElseIf CharCount > MaxCharCount Then
                MaxCharCount = CharCount
                MaxChar = Mid(Str1, i - 1, 1)
            End If

        Next

        'OUTPUT
        Console.WriteLine("Most repeated character is: " & MaxChar)

        Console.ReadKey()

    End Sub

End Module
