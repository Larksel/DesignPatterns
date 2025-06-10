namespace FactoryMethodProblema.boletobancario;

public abstract class Boleto
{
    protected double Valor;
    protected double Juros;
    protected double Desconto;
    protected double Multa;

    public double CalcularJuros()
    {
        return Valor * Juros;
    }

    public double CalcularDesconto()
    {
        return Valor * Desconto;
    }

    public double CalcularMulta()
    {
        return Valor * Multa;
    }
}
