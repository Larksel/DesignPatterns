using AbstractFactorySolucao.Boleto.ConfiguraDesconto;
using AbstractFactorySolucao.Boleto.ConfiguraJuros;
using AbstractFactorySolucao.Boleto.ConfiguraMulta;

namespace AbstractFactorySolucao.Boleto.Familia;

public class CaixaCalculosFactory : ICalculosFactory
{
    public IDesconto CriarDesconto()
    {
        return new CaixaDesconto();
    }

    public IJuros CriarJuros()
    {
        return new CaixaJuros();
    }

    public IMulta CriarMulta()
    {
        return new CaixaMulta();
    }
}
