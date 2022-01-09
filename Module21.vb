Module Module1

    Sub Main()
not_bad:
        'Given a string, find the first appearance of the
        'substring() 'not' and 'bad'. If the 'bad' follows
        ' the() 'not', replace the whole 'not'...'bad' substring
        'with 'good'.
        'Return the resulting string.
        'Input:  'This dinner is not that bad!' 
        'Outputs: This(dinner Is good!)


        'DECLARATION
        Dim str1, str2, char1, char2 As String
        Dim x, y, z, j, k As Integer


        'INITIALIZATION
        str1 = ""
        str2 = ""
        char1 = ""
        char2 = ""
        x = 0
        y = 0
        z = 0
        j = 0


        'PROCESS
        Console.Write("Enter String:")
        str1 = Console.ReadLine()
        x = Len(str1)
        y = InStr(str1, "not")
        z = InStr(str1, "bad")
        j = z + 2
        k = y - 1
        char1 = Left(str1, k)
        char2 = Right(str1, x - j)
        str2 = char1 & "good" & char2
        If y > z Then
            Console.WriteLine("No change :" & str1)
            str1 = Console.ReadLine()
        Else : Console.WriteLine("Final String :" & str2)
            str2 = Console.ReadLine()
            Console.ReadKey()

        End If
    End Sub

End Module
