Module MethodExamples

    Sub Main()
        Dim charge As Integer = 5
        Dim resetTotal As Boolean = False

        For i = 1 To 10
            Console.WriteLine(RunningTotal(charge, False))
        Next

        Console.WriteLine(RunningTotal())

        ' Console.Read()
        RunningTotal(, True)
        charge = 4

        For i = 1 To 10
            Console.WriteLine(RunningTotal(charge))
        Next

        Console.WriteLine(RunningTotal())

        Console.ReadLine()

    End Sub


    Function RunningTotal(ByVal Optional currentCharge As Integer = 0, ByVal Optional clear As Boolean = False) As Integer
        Static _runningTotal As Integer

        If clear Then
            _runningTotal = 0
        Else
            _runningTotal = _runningTotal + currentCharge
        End If

        Return _runningTotal
    End Function





    Sub display()
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
