Module Module1

    Sub Main()
        ' Find if the input string has all the alphabets (case neutral).

        'DECLARATION
        Dim str1, str2, char1 As String
        Dim i As Integer
        Dim Alphas As Boolean

        'INITIALISATION
        str1 = ""
        str2 = ""
        char1 = ""
        i = 0
        Alphas = True

        'PROCESS
        Console.Write("Enter String :")
        str1 = Console.ReadLine()
        UCase(str1)

        For i = 1 To Len(str1)
            char1 = Mid(str1, i, 1)
            If char1 >= "A" And char1 <= "Z" Then
                str2 = str2 & char1
            End If
        Next
        If str2 >= "A" And str2 <= "Z" Then
            Alphas = True
        Else
            Alphas = False
        End If


        Console.WriteLine("Does Entered String Contain All Alphabets : " & Alphas)
        str2 = Console.ReadLine()

        Console.ReadKey()
    End Sub

End Module
