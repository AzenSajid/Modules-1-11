Module Module1

    Sub Main()
        'MixUp:
        'Given strings a and b, return a single string with a and b separated
        'by a space '<a> <b>', except swap the first 2 chars of each string.
        'e.g.
        'mix', pod' -> 'pox mid'
        'dog', 'dinner' -> 'dig donner'
        'Assume a and b are length 2 or more.

        'DECLARATION
        Dim str1, str2, str3, char1, char2, char3, char4 As String
        Dim a, b As Integer

        'INITIALISATION
        str1 = ""
        str2 = ""
        str3 = ""
        char1 = ""
        char2 = ""
        char3 = ""
        char4 = ""
        a = 0
        b = 0

        'PROCESS
        Console.Write("Enter First Word : ")
        str1 = Console.ReadLine()
        Console.Write("Enter Second Word : ")
        str2 = Console.ReadLine()

        a = Len(str1)
        b = Len(str2)

        char1 = Left(str1, 2)
        char2 = Left(str2, 2)
        char3 = Mid(str1, 3, a)
        char4 = Mid(str2, 3, b)
        str1 = char2 & char3
        str2 = char1 & char4
        str3 = str1 & " " & str2

        'OUTPUT
        Console.WriteLine("Final Word : " & str3)
        str3 = Console.ReadLine()
        Console.ReadKey()


    End Sub

End Module
