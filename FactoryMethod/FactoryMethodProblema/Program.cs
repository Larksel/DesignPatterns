using FactoryMethodProblema.boletobancario;
using FactoryMethodProblema.boletobancario.BancoCaixa;
using FactoryMethodProblema.boletobancario.BancoDoBrasil;

Console.WriteLine("--------------CAIXA--------------");
Banco bancoCaixa = new BancoCaixa();
bancoCaixa.GerarBoleto(10, 100);
bancoCaixa.GerarBoleto(30, 100);
bancoCaixa.GerarBoleto(60, 100);

Console.WriteLine("--------------BANCO DO BRASIL--------------");
Banco bancoBrasil = new BancoDoBrasil();
bancoBrasil.GerarBoleto(10, 100);
bancoBrasil.GerarBoleto(30, 100);
bancoBrasil.GerarBoleto(60, 100);
