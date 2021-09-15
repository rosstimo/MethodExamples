Module MethodExamples

    Dim junk As Boolean

    Sub Main()
        'Dim firstNumber As Integer = 7
        'Dim secondNumber As Integer = 6

        'Sum(firstNumber, secondNumber)

        For column = 1 To 5
            For row = 1 To 8

                RandomNumber()

                'Select Case RandomNumber()
                '    Case <= 5
                '        Console.WriteLine("You are too young to ride.")
                '    Case 6 To 10
                '        Console.WriteLine("You can only ride with an adult")
                '    Case 11 To 35
                '        Console.WriteLine("Enjoy the ride!")
                '    Case >= 36
                '        Console.WriteLine("Don't forget your heart pills!!")
                '    Case Else
                '        Console.WriteLine("Things Got Weird!!")
                'End Select

            Next
            Console.WriteLine()
            'Console.WriteLine(StrDup(80, "-"))
        Next
        Console.Read()
    End Sub




    Function Sum(ByVal numOne As Integer, ByVal numTwo As Integer) As Integer
        Console.WriteLine($"in sum secondNumber is {numTwo}")
        Return numOne + numTwo
    End Function

    Function RandomNumber() As Integer
        Dim _randomNumber As Integer
        Dim junk As String
        'TODO figure out how to get a random number...

        _randomNumber = CInt(Rnd() * 1000)


        junk = CStr(_randomNumber).PadLeft(4) & " |"

        Console.Write(junk)


        Return _RandomNumber
    End Function



End Module
