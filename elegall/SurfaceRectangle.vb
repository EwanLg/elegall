Module SurfaceRectangle

    Sub Main()

        Dim longueur As Double ' Double = réel

        Dim largeur As Double

        Dim surface As Double

        Console.WriteLine("Entrez la longueur du rectangle.")

        longueur = Console.ReadLine()

        Console.WriteLine("Entrez la largeur du rectangle.")

        largeur = Console.ReadLine()

        surface = longueur * largeur

        Console.WriteLine("La surface du rectangle est:" + surface.ToString())

        Console.ReadLine()

    End Sub

End Module