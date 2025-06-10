namespace BuilderProblema.PDF;

public class GeradorPDFDirector
{
    private IGeradorPDFBuilder _geradorPDFBuilder;

    public GeradorPDFDirector(IGeradorPDFBuilder builder)
    {
        _geradorPDFBuilder = builder;
    }

    public void SetGeradorPDFBuilder(IGeradorPDFBuilder builder)
    {
        _geradorPDFBuilder = builder;
    }

    public void CriarGeradorPDF()
    {
        _geradorPDFBuilder.SetPageConfiguration();
        _geradorPDFBuilder.SetMargin();
        _geradorPDFBuilder.SetHeader();
        _geradorPDFBuilder.SetFooter();
    }

    public void CriarGeradorPDFNoHeader()
    {
        _geradorPDFBuilder.SetPageConfiguration();
        _geradorPDFBuilder.SetMargin();
        _geradorPDFBuilder.SetFooter();
    }

    public void CriarGeradorPDFNoFooter()
    {
        _geradorPDFBuilder.SetPageConfiguration();
        _geradorPDFBuilder.SetMargin();
        _geradorPDFBuilder.SetHeader();
    }

    public void CriarGeradorPDFNoHeaderNoFooter()
    {
        _geradorPDFBuilder.SetPageConfiguration();
        _geradorPDFBuilder.SetMargin();
    }
}
