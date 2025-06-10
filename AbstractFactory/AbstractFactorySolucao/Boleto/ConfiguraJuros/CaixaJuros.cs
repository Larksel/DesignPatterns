namespace AbstractFactorySolucao.Boleto.ConfiguraJuros;

public class CaixaJuros : IJuros
{
    public double GetJuros()
    {
        return 0.02;
    }
}
