Module Module1

    Sub Main()
not_bad:
        'donuts:
        'INPUT an INT count of a number of donuts, OUTPUT a string
        'of the form 'Number of donuts: <count>', where <count> is the number
        'input. However, if the count is 10 or more, then use the word 'many'
        'instead of the actual count.
        'So donuts(5) outputs 'Number of donuts: 5'
        'and donuts(23) outputs 'Number of donuts: many'


        'DECLARATION
        Dim count As Integer
        Dim many As String


        'INITIALISATION
        count = 0
        many = ""

        'PROCESS
        Console.Write("Enter Number of Donuts :")
        count = Console.ReadLine()
        If count < 10 Then
            Console.WriteLine("Number of Donuts:" & count)
            count = Console.ReadLine()
        ElseIf count >= 10 Then
            Console.WriteLine("Number of Donuts :" & "many")
            many = Console.ReadLine()
            Console.ReadKey()


        End If

    End Sub

End Module
