using AbstractFactorySolucao.Boleto;
using AbstractFactorySolucao.Boleto.Familia;

Banco banco = new Banco();

ICalculosFactory factoryCaixa = new CaixaCalculosFactory();
ICalculosFactory factoryBB = new BBCalculosFactory();

Console.WriteLine("Criar boleto caixa");
banco.GerarBoleto(100, factoryCaixa);

Console.WriteLine("Criar boleto BB");
banco.GerarBoleto(100, factoryBB);