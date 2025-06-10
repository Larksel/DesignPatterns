namespace BuilderProblema.PDF;

public class BuilderA4 : IGeradorPDFBuilder
{
    private readonly GeradorPDF _geradorPDF;

    public BuilderA4()
    {
        _geradorPDF = new GeradorPDF();
    }

    public GeradorPDF GetGeradorPDF()
    {
        return _geradorPDF;
    }

    public void SetFooter()
    {
        _geradorPDF.hasFooter = true;
        _geradorPDF.footerHeight = 15;
    }

    public void SetHeader()
    {
        _geradorPDF.hasHeader = true;
        _geradorPDF.headerHeight = 15;
    }

    public void SetMargin()
    {
        _geradorPDF.marginTop = 30;
        _geradorPDF.marginRight = 20;
        _geradorPDF.marginBottom = 30;
        _geradorPDF.marginLeft = 20;
    }

    public void SetPageConfiguration()
    {
        _geradorPDF.pageOrientation = "portrait";
        _geradorPDF.unit = "mm";
        _geradorPDF.pageSizeX = 210;
        _geradorPDF.pageSizeY = 297;
        _geradorPDF.pageColor = "#ffffff";
        _geradorPDF.encode = "UTF-8";
    }
}
