Module Exercice_73

    Sub main()
        Dim heures As Double
        Dim salaire As Double
        Dim TauxHoraire As Double
        Dim heuresup As Double
        Dim heuresup2 As Double

        salaire = 0

        Console.WriteLine("Nombre d'heures travaillees hebdomadaire ?")
        heures = Console.ReadLine()

        If (heures < 39) Then
            Console.WriteLine("Vous ne travaillez pas assez !")
        ElseIf (heures = 39) Then
            Console.WriteLine("Taux horaire ?")
            TauxHoraire = Console.ReadLine()
            salaire = heures * TauxHoraire
        ElseIf (heures <= 47) Then
            heuresup = heures - 39
            Console.WriteLine("Taux horaire ?")
            TauxHoraire = Console.ReadLine()
            salaire = 39 * TauxHoraire + heuresup * (TauxHoraire * 125 / 100)
        Else
            heuresup = heures - 44
            heuresup2 = heures - 47
            Console.WriteLine("Taux horaire ?")
            TauxHoraire = Console.ReadLine()
            salaire = 39 * TauxHoraire + heuresup * (TauxHoraire * 125 / 100) + heuresup2 * (TauxHoraire * 150 / 100)
        End If
        Console.WriteLine("Salaire hebdomadaire : " + salaire.ToString)
        Console.WriteLine("Au revoir")
        Console.ReadLine()
    End Sub

End Module
