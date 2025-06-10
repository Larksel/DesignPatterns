namespace BuilderProblema.PDF;

public interface IGeradorPDFBuilder
{
    public GeradorPDF GetGeradorPDF();
    public void SetPageConfiguration();
    public void SetMargin();
    public void SetHeader();
    public void SetFooter();
}
