Module Module1

    Sub Main()
        'Replace selected character with another in entered string.

        'DECLARATION
        Dim str1, str2 As String
        Dim char1, char2, char3 As Char
        Dim i As Integer


        'INITIALISATION
        str1 = ""
        str2 = ""
        char1 = ""
        char2 = ""
        char3 = ""
        i = 0

        Console.Write("Enter String : ")
        str1 = Console.ReadLine()
        Console.Write("Enter Character to be replaced : ")
        char1 = Console.ReadLine()
        Console.Write("Enter character to replace it : ")
        char3 = Console.ReadLine()

        For i = 1 To Len(str1)
            char2 = Mid(str1, i, 1)
            If char2 <> char1 Then
                str2 = str2 & char2
            Else
                If char2 = char1 Then
                    str2 = str2 & char3
                End If

            End If
        Next


        Console.WriteLine("String after Replaced Value:" & str2)
        str1 = Console.ReadLine()

        Console.ReadKey()
    End Sub

End Module
