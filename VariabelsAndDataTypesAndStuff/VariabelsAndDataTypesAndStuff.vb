'Malachi Marlow

Option Explicit On
'Option Strict On

Module VariabelsAndDataTypesAndStuff

    Sub Main()

        Dim jellyBeans As Integer
        Dim LaffyTaffy As Integer
        Dim money As Decimal
        Dim studentName As String

        Console.WriteLine(jellyBeans)

        jellyBeans = 120
        Console.WriteLine(jellyBeans)

        jellyBeans = jellyBeans + 10
        Console.WriteLine(jellyBeans)

        jellyBeans += 10
        Console.WriteLine(jellyBeans)

        LaffyTaffy = 62
        Console.WriteLine(LaffyTaffy)

        money = 5649564101
        jellyBeans = 159.598
        studentName = "7"

        jellyBeans = CInt(studentName)
        Console.WriteLine("I've played these games before!")

        Console.WriteLine()

    End Sub

End Module
