'Jessica McArthur
'RCET0265
'Fall 2020
'AcculateMessagesFuncton
'https://github.com/jmcarth4/ 

Option Explicit On
Option Strict On
Option Compare Text
Module AcculateMessagesFunction


    'A loop prompts the user to write a message. When Q is pressed all messages are displayed. 
    Sub Main()
        Dim userInput As String
        Do
            Console.WriteLine("Please type a message")
            userInput = Console.ReadLine()
            UserMessages(userInput, False)
            'When C is pressed all previous messages are cleared. 
            If userInput = "C" Then
                UserMessages("", True)
            End If
        Loop While userInput <> "Q"
        Console.WriteLine()
        Console.WriteLine(UserMessages(" ", False))
        Console.ReadLine()
    End Sub
    'Function is written to display messages. Messages clear after program is exited. 
    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean) As String
        Static messages As String
        If clear = True Then
            messages = ""
        ElseIf newMessage <> "" Then
            messages &= newMessage & vbNewLine

        End If
        Return messages
    End Function

End Module
