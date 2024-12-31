using System;

public class Program
{
    public static void Main()
    {
        Document documentHtml = new DocumentHtml();
        documentHtml.SetContenu("<h1>Bienvenue sur mon site !</h1>");
        
        documentHtml.Dessine();
        documentHtml.Imprime();

        Console.WriteLine();

        Document documentPdf = new DocumentPdf();
        documentPdf.SetContenu("Voici un document PDF avec du texte.");
        
        documentPdf.Dessine(); 
        documentPdf.Imprime();
    }
}
