Module Exercice_91
    Sub main()
        Dim enternote As Double
        Dim note As Double
        Dim nbnote As Double
        Dim IfPostTen As Double
        Dim PostTen As Double
        Dim moyenne As Double
        nbnote = 0
        note = 0
        ifpostten = 0
        postten = 0
        moyenne = 0
        While enternote <> -1
            Console.WriteLine("Entrez une note (-1 pour fin) : ")
            enternote = Console.ReadLine()
            note = note + enternote
            nbnote = nbnote + 1
            If enternote > 10 Then
                ifpostten = ifpostten + 1
            End If
        End While
        PostTen = (ifpostten / (nbnote - 1) ) * 100
        moyenne = (note + 1) / (nbnote - 1)
        Console.WriteLine("Vous avez " + postten.ToString + "% de notes > à 10")
        Console.WriteLine("Votre moyenne est de " + moyenne.ToString)
        Console.ReadLine()
    End Sub
End Module
