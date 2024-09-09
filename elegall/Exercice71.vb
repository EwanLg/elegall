Module Exercice_71

    Sub Main()
        Dim montant As Double

        Console.WriteLine("Veuillez taper votre montant")

        montant = Console.ReadLine()

        If (montant <= 500) Then
            Console.WriteLine("Pas de remise")
        ElseIf (montant <= 3000) Then
            Console.WriteLine("Remise de 1%")
            montant = montant - montant * 1 / 100
        ElseIf (montant <= 10000) Then
            Console.WriteLine("Remise de 2%")
            montant = montant - montant * 2 / 100
        End If

        Console.WriteLine("Le montant net est : " + montant.ToString)
        Console.WriteLine("Au revoir")
        Console.ReadLine()
    End Sub

End Module
