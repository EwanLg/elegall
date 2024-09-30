Module Exercice_94
    Sub main()
        Dim representant, other As String
        Dim semaine, sale, totalsale, margin As Double
        Do
            totalsale = 0
            semaine = 1
            Console.WriteLine("Nom du représentant ?")
            representant = Console.ReadLine()
            Do
                Console.WriteLine("Semaine " + semaine.ToString + ": Ventes H.T hebdomadaires (0 pour stopper la saisie) ?")
                Do
                    sale = 0
                    sale = Console.ReadLine()
                    If sale > 0 Then
                        totalsale = totalsale + sale
                        semaine = semaine + 1
                    ElseIf sale < 0 Then
                        Console.WriteLine("Ventes ne peuvent être < 0")
                    End If
                Loop Until sale >= 0
            Loop Until sale = 0 Or semaine = 5
            margin = totalsale * (10 / 100)
            Console.WriteLine("Bilan pour " + representant)
            Console.WriteLine("Total des ventes H.T. = " + totalsale.ToString)
            Console.WriteLine("Commission = " + margin.ToString)
            Console.WriteLine("Autre représentant ? (O/N)")
            other = Console.ReadLine()
        Loop Until other = "N"
        Console.WriteLine("Au revoir")
        Console.ReadLine()
    End Sub
End Module