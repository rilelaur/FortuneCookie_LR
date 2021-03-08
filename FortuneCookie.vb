'Laura Riley
'RCET0265
'Spring 2021
'Fortune Cookie
'https://github.com/rilelaur/FortuneCookie_LR.git

Option Explicit On
Option Strict On

'The program will give the user a wisdom when they open the program
Module FortuneCookie

    Sub Main()
        Dim wisdomNumber As Integer

        'Initializes Rnd
        Randomize()

        'Generates a number between 0 and 2
        wisdomNumber = CInt(3 * Rnd())

        'Gives different wisdom based off of the number generated
        If wisdomNumber = 0 Then
            Console.WriteLine("Work with destiny. Stop trying to outrun it.")
        ElseIf wisdomNumber = 1 Then
            Console.WriteLine("You will find your greatest strength, in your greatest weakness.")
        ElseIf wisdomNumber = 2 Then
            Console.WriteLine("Don't run with scissors.")
        End If

        Console.Read()
    End Sub

End Module
