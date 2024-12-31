using System;

public class DocumentPdf : Document
{
    private string contenu;

    private ComposantPdf outilPdf;

    public void SetContenu(string contenu)
    {
        this.contenu = contenu;
        this.outilPdf.pdfFixeContenu(contenu);
    }

    public void Dessine()
    {
        this.outilPdf.pdfEnvoieImprimante();
    }

    public void Imprime()
    {
        this.outilPdf.PdfPrépareAffichage();
        this.outilPdf.pdfRafraîchir();
        this.outilPdf.pdfTerminerAffichage();
    }
}
