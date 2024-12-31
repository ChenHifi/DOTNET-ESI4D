using System;

public class DocumentHtml : Document
{
    private string contenu;

    public void SetContenu(string contenu)
    {
        this.contenu = contenu;
    }

    public void Dessine()
    {
        Console.WriteLine("Affichage du contenu HTML :");
        Console.WriteLine($"<html><body>{contenu}</body></html>");
    }

    public void Imprime()
    {
        Console.WriteLine("Impression du document HTML (simulée) :");
        Console.WriteLine($"Fichier HTML imprimé avec le contenu : {contenu}");
    }
}
