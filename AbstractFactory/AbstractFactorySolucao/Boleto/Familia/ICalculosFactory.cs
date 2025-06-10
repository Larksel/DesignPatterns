using AbstractFactorySolucao.Boleto.ConfiguraDesconto;
using AbstractFactorySolucao.Boleto.ConfiguraJuros;
using AbstractFactorySolucao.Boleto.ConfiguraMulta;

namespace AbstractFactorySolucao.Boleto.Familia;

public interface ICalculosFactory
{
    IJuros CriarJuros();
    IDesconto CriarDesconto();
    IMulta CriarMulta();
}
