Module Module1

    Sub Main()
        ' Count and output the NUMBER of an entered character in a string. 
        ' Also output separate counts for alphabets (cap & small together; case neutral),
        ' digits and other characters in same entered string.

        'DECLARATION
        Dim alphacount, digitcount, othercharcount, i, X As Integer
        Dim str1, char1 As String

        'INITIALISATION
        alphacount = 0
        digitcount = 0
        othercharcount = 0
        i = 0
        X = 0
        str1 = 0
        char1 = 0

        'PROCESS
        Console.Write("Enter String :")
        str1 = Console.ReadLine()
        X = Len(str1)
        For i = 1 To Len(str1)
            char1 = Mid(str1, i, 1)
            If char1 >= "0" And char1 <= "9" Then
                digitcount = digitcount + 1
            ElseIf char1 >= "A" And char1 <= "Z" Or char1 >= "a" And char1 <= "z" Then
                alphacount = alphacount + 1
            Else : othercharcount = othercharcount + 1
            End If

        Next

        Console.WriteLine("Total Characters : " & X)
        Console.WriteLine("Number of Alphabets : " & alphacount)
        Console.WriteLine("Number of Digits : " & digitcount)
        Console.WriteLine("Number of Other Characters : " & othercharcount)
        Console.ReadLine()

        Console.ReadKey()


    End Sub

End Module
