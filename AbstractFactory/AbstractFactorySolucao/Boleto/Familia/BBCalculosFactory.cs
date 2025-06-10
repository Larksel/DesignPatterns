using AbstractFactorySolucao.Boleto.ConfiguraDesconto;
using AbstractFactorySolucao.Boleto.ConfiguraJuros;
using AbstractFactorySolucao.Boleto.ConfiguraMulta;

namespace AbstractFactorySolucao.Boleto.Familia;

public class BBCalculosFactory : ICalculosFactory
{
    public IDesconto CriarDesconto()
    {
        return new BBDesconto();
    }

    public IJuros CriarJuros()
    {
        return new BBJuros();
    }

    public IMulta CriarMulta()
    {
        return new BBMulta();
    }
}
