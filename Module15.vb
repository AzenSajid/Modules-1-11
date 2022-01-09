Module Module1

    Sub Main()
        'Find the count of vowels characters in an entered string separately. 

        'DECLARATION
        Dim str1 As String
        Dim char1 As Char
        Dim i, vcount As Integer


        'INITIALISATION
        str1 = ""
        vcount = 0
        char1 = ""
        i = 0


        'PROCESS
        Console.Write("Enter String:")
        str1 = Console.ReadLine()
        str1 = LCase(str1)


        For i = 1 To Len(str1)
            char1 = Mid(str1, i, 1)
            If char1 = "a" Or char1 = "e" Or char1 = "i" Or char1 = "o" Or char1 = "u" Then
                vcount = vcount + 1
            End If

        Next

        Console.WriteLine("VowelCount: " & vcount)
        vcount = Console.ReadLine()


        Console.ReadKey()



    End Sub


End Module
