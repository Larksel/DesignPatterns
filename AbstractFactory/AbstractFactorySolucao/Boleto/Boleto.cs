using AbstractFactorySolucao.Boleto.ConfiguraDesconto;
using AbstractFactorySolucao.Boleto.ConfiguraJuros;
using AbstractFactorySolucao.Boleto.ConfiguraMulta;
using AbstractFactorySolucao.Boleto.Familia;

namespace AbstractFactorySolucao.Boleto;

public class Boleto
{
    protected double Valor;
    protected IJuros Juros;
    protected IDesconto Desconto;
    protected IMulta Multa;

    public Boleto(double valor, ICalculosFactory factory)
    {
        Valor = valor;
        Juros = factory.CriarJuros();
        Desconto = factory.CriarDesconto();
        Multa = factory.CriarMulta();
    }

    public double CalcularJuros()
    {
        return Valor * Juros.GetJuros();
    }

    public double CalcularDesconto()
    {
        return Valor * Desconto.GetDesconto();
    }

    public double CalcularMulta()
    {
        return Valor * Multa.GetMulta();
    }
}
