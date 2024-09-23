Module Exercice_92
    Sub main()
        Dim enternote As Double
        Dim note As Double
        Dim nbnote As Double
        Dim moyenne As Double
        nbnote = 0
        note = 0
        Do
            Console.WriteLine("Note ? (entre 0 et 20, -1 pour sortir)")
            enternote = Console.ReadLine()
            If enternote < 0 Then
                Console.WriteLine("La note doit être entre 0 et 20")
            ElseIf enternote > 20 Then
                Console.WriteLine("La note doit être entre 0 et 20")
            Else
                note = note + enternote
                nbnote = nbnote + 1
            End If

        Loop Until enternote = -1
        moyenne = note / nbnote
        Console.WriteLine("Somme : " + note.ToString)
        Console.WriteLine("Compteur : " + nbnote.ToString)
        Console.WriteLine("Moyenne = " + moyenne.ToString)
        Console.WriteLine("Au revoir")
        Console.ReadLine()
    End Sub
End Module
