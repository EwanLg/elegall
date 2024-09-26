Module Exercice_93
    Sub main()
        Dim paire, p, i As Double
        p = 2
        Console.WriteLine("Entré le nombre de paire que vous voulez : ")
        paire = Console.ReadLine()
        For i = 1 To paire
            Console.WriteLine(p)
            p = p + 2
        Next
        Console.ReadLine()

    End Sub
End Module
