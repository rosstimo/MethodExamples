Module MethodExamples

    Dim junk As Boolean

    Sub Main()
        Dim firstNumber As Integer = 7
        Dim secondNumber As Integer = 6

        Sum(firstNumber, secondNumber)

        Console.Read()
    End Sub




    Function Sum(ByVal numOne As Integer, ByVal numTwo As Integer) As Integer
        Console.WriteLine($"in sum secondNumber is {numTwo}")
        Return numOne + numTwo
    End Function

    Function RandomNumber() As Integer
        Dim _randomNumber As Integer

        'TODO figure out how to get a random number...

        Return _RandomNumber
    End Function



End Module
