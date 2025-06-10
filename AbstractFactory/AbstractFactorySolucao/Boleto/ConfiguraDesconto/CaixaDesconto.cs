namespace AbstractFactorySolucao.Boleto.ConfiguraDesconto;

public class CaixaDesconto : IDesconto
{
    public double GetDesconto()
    {
        return 0.1;
    }
}
