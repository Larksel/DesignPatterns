namespace AbstractFactorySolucao.Boleto.ConfiguraJuros;

public class BBJuros : IJuros
{
    public double GetJuros()
    {
        return 0.03;
    }
}
