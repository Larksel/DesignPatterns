namespace AbstractFactorySolucao.Boleto.ConfiguraDesconto;

public class BBDesconto : IDesconto
{
    public double GetDesconto()
    {
        return 0.05;
    }
}
