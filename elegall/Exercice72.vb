Module Exercice_72
    Sub main()
        Dim essence As Double
        Dim diesel As Double
        Dim days As Double
        Dim km As Double

        Console.WriteLine("Nombre de jours de location ?")
        days = Console.ReadLine()

        Console.WriteLine("Distance à parcourir (en kms) ?")
        km = Console.ReadLine()

        essence = 30 * days + 0.85 * km
        diesel = 35 * days + 0.65 * km

        If (diesel < essence) Then
            Console.WriteLine("Meilleur choix : Diesel")
        ElseIf (essence < diesel) Then
            Console.WriteLine("Meilleur choix : Essence")
        Else
            Console.WriteLine("Même prix")
        End If
        Console.WriteLine("Au revoir")
        Console.ReadLine()
    End Sub
End Module
