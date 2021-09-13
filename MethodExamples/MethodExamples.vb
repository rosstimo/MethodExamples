Module MethodExamples

    Sub Main()
        Dim robGaveMeMoney As Boolean

        'robGaveMeMoney = True

        If robGaveMeMoney Then
            RobIsCool()
        Else
            RobIsNotCool()
        End If

        Console.Read()
    End Sub

    Sub RobIsCool()
        Console.WriteLine("Hi Rob!!")
    End Sub

    Sub RobIsNotCool()
        Console.WriteLine("Rob is not here, let's make fun of him...")
    End Sub


End Module
